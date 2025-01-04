namespace BMS.Data;

public class ExamInfo
{
    public string ExamineeId { get; set; }          // 응시자 ID
    public string ExamTitle { get; set; }           // 시험 제목
    public DateTime LastModified { get; set; }      // 최종 수정 시간
    public string GradingStatus { get; set; }       // 채점 상태 (완료, 진행 중, 대기 중 등)
    public double GradingProgress { get; set; }     // 채점 진행률 (0~100%)
    public int TotalGradedScore { get; set; }       // 채점된 총 점수
    public int MaxScore { get; set; } //시험 최대 점수
    public int AutoGradingScore { get; set; }       // 자동 채점 점수
    public int ManualGradingScore { get; set; }     // 수동 채점 점수
}