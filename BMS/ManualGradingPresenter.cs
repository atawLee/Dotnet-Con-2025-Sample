using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.Business.Service;
using BMS.Data;
using BMS.Domain.Entity;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

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

    public async Task SelectExamData(string id)
    {
        var data = await _service.GetGradingInfoList(id);
        _view.UpdateGradingInfoList(data);
        _view.SetGradingTab();
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