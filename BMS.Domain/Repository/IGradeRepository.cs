using BMS.Data;
using BMS.Domain.Entity;

namespace BMS.Domain.Repository;

public interface IGradeRepository
{
    Task<List<ExamInfo>> GetExamInformationList();
    Task<List<GradeInfo>> GetGradingInfoList(string examineeId);
    Task<GradeInfoDetail> GetGradingDetail(GradeInfo gradeInfo);
    Task SaveGrade(GradeInfoDetail detail);
}