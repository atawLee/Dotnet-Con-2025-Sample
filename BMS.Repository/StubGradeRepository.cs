using BMS.Data;

namespace BMS.Repository;

public class StubGradeRepository : IGradeRepository
{
    private List<ExamInfo> examInfos = new()
    {
        new ExamInfo
        {
            ExamineeId = "E001",
            ExamTitle = "Math Exam",
            LastModified = DateTime.Now,
            GradingStatus = "Completed",
            GradingProgress = 100,
            TotalGradedScore = 90,
            MaxScore = 100,
            AutoGradingScore = 50,
            ManualGradingScore = 40
        },
        new ExamInfo
        {
            ExamineeId = "E002",
            ExamTitle = "Science Exam",
            LastModified = DateTime.Now,
            GradingStatus = "In Progress",
            GradingProgress = 50,
            TotalGradedScore = 45,
            MaxScore = 100,
            AutoGradingScore = 30,
            ManualGradingScore = 15
        }
    };
    private List<GradeInfo> gradeInfos = new()
    {
        new GradeInfo
        {
            ExamId = 1,
            ExamineeId = "E001",
            QuestionId = "101",
            AnswerId = "1001",
            Score = 10,
            IsGraded = 1
        },
        new GradeInfo
        {
            ExamId = 1,
            ExamineeId = "E001",
            QuestionId = "102",
            AnswerId = "1002",
            Score = 20,
            IsGraded = 1
        }
    };
    private List<GradeInfoDetail> gradeInfoDetails = new()
    {
        new GradeInfoDetail
        {
            Answer = new AnswerInfo
            {
                AnswerId = "1001",
                QuestionId = "101",
                ExamineeId = "E001",
                AnswerText = "Answer to question 101",
                IsGraded = true
            },
            Question = new QuestionInfo
            {
                QuestionId = "101",
                Text = "What is 2+2?",
                MaxScore = 10,
                ScoringRubric = "Correct answer is 4",
                ScoringRubricUrl = "http://example.com/rubric/101"
            },
            ExamineeId = "E001",
            Score = 10,
            Note = "Good answer",
            IsGraded = 1,
            GradedAt = DateTime.Now
        },
        new GradeInfoDetail
        {
            Answer = new AnswerInfo
            {
                AnswerId = "1002",
                QuestionId = "102",
                ExamineeId = "E001",
                AnswerText = "Answer to question 102",
                IsGraded = true
            },
            Question = new QuestionInfo
            {
                QuestionId = "102",
                Text = "What is the capital of France?",
                MaxScore = 20,
                ScoringRubric = "Correct answer is Paris",
                ScoringRubricUrl = "http://example.com/rubric/102"
            },
            ExamineeId = "E001",
            Score = 20,
            Note = "Correct",
            IsGraded = 1,
            GradedAt = DateTime.Now
        }
    };
    public Task<List<ExamInfo>> GetExamInformationList()
    {
        return Task.FromResult(examInfos);
    }

    public Task<List<GradeInfo>> GetGradingInfoList(string examineeId)
    {
        var result = gradeInfos.Where(g => g.ExamineeId == examineeId).ToList();
        return Task.FromResult(result);
    }

    public Task<GradeInfoDetail> GetGradingDetail(GradeInfo gradeInfo)
    {
        var result = gradeInfoDetails.FirstOrDefault(g => g.ExamineeId == gradeInfo.ExamineeId && g.Question.QuestionId == gradeInfo.QuestionId);
        return Task.FromResult(result);
    }

    public Task SaveGrade(GradeInfoDetail detail)
    {
        gradeInfoDetails.Add(detail);
        return Task.CompletedTask;
    }
}