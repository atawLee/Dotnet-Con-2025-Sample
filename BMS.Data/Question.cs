using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Data;

public class QuestionInfo
{
    public string QuestionId { get; set; }         // 문제 ID
    public string Text { get; set; }              // 문제 내용
    public int MaxScore { get; set; }             // 문제의 최대 점수
    public string ScoringRubric { get; set; }    // 채점 기준 
    public string ScoringRubricUrl { get; set; } // 채점 기준 URL
}