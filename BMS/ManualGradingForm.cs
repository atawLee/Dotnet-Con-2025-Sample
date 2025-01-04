using System.ComponentModel;
using BMS.Business.Service;
using BMS.Data;
using BMS.Winform;
using Newtonsoft.Json;
// ReSharper disable All

namespace BMS;

public partial class ManualGradingForm : UserControl
{
    private readonly ManualGradingPresenter _presenter;
    private readonly BindingList<ExamInfo> _examInfoList = new();
    private readonly BindingList<GradeInfo> _gradingInfoList = new();
    private GradeInfoDetail _detailInfo;

    public ManualGradingForm(ManualGradingPresenter presenter)
    {
        _presenter = presenter;
        _presenter.SetView(this);
        InitializeComponent();
        datagridGradeProgressList.DataSource = _examInfoList;
        datagridAnswer.DataSource = _gradingInfoList;
    }

    private async void btnSearch_Click(object sender, EventArgs e)
    {
        await _presenter.SearchExamInfo();
    }

    public void UpdateExamInfoList(List<ExamInfo> data)
    {
        _examInfoList.Clear();
        data.ForEach(examInfo=>_examInfoList.Add(examInfo));
    }

    private async void datagridGradeProgressList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        var gradeProgressInfo = _examInfoList[e.RowIndex];
        await _presenter.SelectExamData(gradeProgressInfo.ExamineeId);
    }

    public void UpdateGradingInfoList(List<GradeInfo> data)
    {
        _gradingInfoList.Clear();
        data.ForEach(gradeInfo => _gradingInfoList.Add(gradeInfo));
    }

    public void SetTab(int index)
    {
        this.tabControl1.SelectedIndex = index;
    }

    public void InitGridAnswerSelection()
    {
        if (datagridAnswer.Rows.Count > 0)
        {
            datagridAnswer.Rows[0].Selected = true;  // 첫 번째 행 선택
            datagridAnswer.CurrentCell = datagridAnswer.Rows[0].Cells[0]; // 포커스 설정
        }
    }

    private async void datagridAnswer_SelectionChanged(object sender, EventArgs e)
    {
        if (datagridAnswer.SelectedRows ==null ||  datagridAnswer.SelectedRows.Count == 0) return;

        GradeInfo selectedData = _gradingInfoList[datagridAnswer.SelectedRows[0].Index];
        await _presenter.SelectGradeInfo(selectedData);
    }

    public void UpdateGradeDetail(GradeInfoDetail info)
    {
        this._detailInfo = info;
        var answer = info.Answer;
        var question = info.Question;

        txtNote.Text = info?.Note ?? "";
        numScore.Value = info?.Score ?? 0;
        txtScoringRubric.Text = question.ScoringRubric;
        txtQuestion.Text = question.Text ?? "";
        txtAnswer.Text = answer.AnswerText;
    }

    private async void btSave_Click(object sender, EventArgs e)
    {
        _detailInfo.Score = (int)numScore.Value;
        _detailInfo.Note = txtNote.Text;
        
        await _presenter.SaveGrade(_detailInfo);
        MessageBox.Show("저장되었습니다.");
    }
}