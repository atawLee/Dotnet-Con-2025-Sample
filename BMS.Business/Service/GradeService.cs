using System.Text;
using BMS.Business.State;
using BMS.Data;
using BMS.Repository;
using Newtonsoft.Json;

namespace BMS.Business.Service;

/// <summary>
/// 채점 서비스
/// </summary>
public class GradeService
{
    private readonly IGradeRepository _repository;
    private readonly GradeHistoryState _state;

    public GradeService(IGradeRepository repository, GradeHistoryState state)
    {
        _repository = repository;
        _state = state;
    }

    public async Task<List<ExamInfo>> GetExamInformationList()
    {
        return await _repository.GetExamInformationList();
    }

    public async Task<List<GradeInfo>> GetGradingInfoList(string examineeId)
    {
        return await _repository.GetGradingInfoList(examineeId);
    }

    public async Task<GradeInfoDetail> GetGradingDetail(GradeInfo gradeInfo)
    {
        return await _repository.GetGradingDetail(gradeInfo);
    }

    public async Task SaveGrade(GradeInfoDetail detail)
    {
        detail.GradedAt = DateTime.Now;
        await _repository.SaveGrade(detail);
        _state.Add(detail);
    }
}