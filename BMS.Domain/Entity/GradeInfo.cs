namespace BMS.Domain.Entity
{
    public class GradeInfo
    {
        public int ExamId { get; set; }
        public string ExamineeId { get; set; }
        public string QuestionId { get; set; }
        public string AnswerId { get; set; }
        public int Score { get; set; }
        public int IsGraded { get; set; }
    }
}
