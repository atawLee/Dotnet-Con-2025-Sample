using BMS.Data;

namespace BMS.Repository;

public interface IGradeRepository
{
    Task<List<ExamInfo>> GetExamInformationList();
    Task<List<GradeInfo>> GetGradingInfoList(string examineeId);
    Task<GradeInfoDetail> GetGradingDetail(GradeInfo gradeInfo);
    Task SaveGrade(GradeInfoDetail detail);
}