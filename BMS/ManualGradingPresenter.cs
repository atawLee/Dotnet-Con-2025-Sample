using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.Business.Service;
using BMS.Data;

namespace BMS.Winform;

public class ManualGradingPresenter 
{
    private readonly GradeService _service;
    private ManualGradingForm _view;

    public ManualGradingPresenter(GradeService service)
    {
        _service = service;
    }

    public void SetView(ManualGradingForm view)
    {
        this._view = view;
    }


    public async Task SearchExamInfo()
    {
        var list =await _service.GetExamInformationList();
        _view.UpdateExamInfoList(list);
    }

    public async Task SelectExamData(string examineeId)
    {
        var data = await _service.GetGradingInfoList(examineeId);
        _view.UpdateGradingInfoList(data);
        _view.SetTab(1);
        _view.InitGridAnswerSelection();
    }

    public async Task SelectGradeInfo(GradeInfo selectedData)
    {
        var detail = await _service.GetGradingDetail(selectedData);
        _view.UpdateGradeDetail(detail);
    }

    public async Task SaveGrade(GradeInfoDetail detailInfo)
    {
        await _service.SaveGrade(detailInfo);
    }
}