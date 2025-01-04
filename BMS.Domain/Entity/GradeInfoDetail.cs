using BMS.Data;

namespace BMS.Domain.Entity;

public class GradeInfoDetail
{
    public AnswerInfo Answer { get; set; }
    public QuestionInfo Question { get; set; }  

    public string ExamineeId { get; set; }
    public int Score { get; set; }
    public string Note { get; set; }
    public int IsGraded { get; set; }

    public DateTime GradedAt { get; set; }
}