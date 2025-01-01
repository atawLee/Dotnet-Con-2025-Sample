using BMS.Business;
using BMS.Data;
using Newtonsoft.Json;
// ReSharper disable All

namespace BMS;

public partial class ManualGradingForm : UserControl
{
    private readonly List<ExamInfo> _gradeProgressList = new(100);
    private readonly List<GradeInfo> _gradingInfoList = new(100);
    private readonly GradeService _service = new();
    private GradeInfoDetail _detailInfo;

    public ManualGradingForm()
    {
        InitializeComponent();
        datagridGradeProgressList.DataSource = _gradeProgressList;
    }

    private async void btnSearch_Click(object sender, EventArgs e)
    {
        var data = await _service.GetExamInformationList();
        _gradeProgressList.Clear();
        _gradeProgressList.AddRange(data);
    }

    private async void datagridGradeProgressList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        var gradeProgressInfo = _gradeProgressList[e.RowIndex];
        var data = await _service.GetGradingInfoList(gradeProgressInfo.ExamineeId);
        _gradingInfoList.Clear();
        _gradingInfoList.AddRange(data);
        this.tabControl1.SelectedIndex = 1;

        // 첫 번째 행 선택
        if (datagridAnswer.Rows.Count > 0)
        {
            datagridAnswer.Rows[0].Selected = true;  // 첫 번째 행 선택
            datagridAnswer.CurrentCell = datagridAnswer.Rows[0].Cells[0]; // 포커스 설정
        }
    }

    private async void datagridAnswer_SelectionChanged(object sender, EventArgs e)
    {
        if (datagridAnswer.SelectedRows.Count != 0) return;

        GradeInfo selectedData = _gradingInfoList[datagridAnswer.SelectedRows[0].Index];
        _detailInfo = await _service.GetGradingDetail(selectedData);

        var answer = _detailInfo.Answer;
        var question = _detailInfo.Question;

        txtNote.Text = _detailInfo?.Note ?? "";
        numScore.Value = _detailInfo?.Score ?? 0;
        txtScoringRubric.Text = question.ScoringRubric;
        txtQuestion.Text = question.Text ?? "";
        txtAnswer.Text = answer.AnswerText;
    }

    private async void btSave_Click(object sender, EventArgs e)
    {
        _detailInfo.Score = (int)numScore.Value;
        _detailInfo.Note = txtNote.Text;
        
        await _service.SaveGrade(_detailInfo);
    }
}