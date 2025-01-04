using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Data;

public class AnswerInfo
{
    public string AnswerId { get; set; }          // 답안 ID
    public string QuestionId { get; set; }        // 연결된 문제 ID
    public string ExamineeId { get; set; }        // 응시자 ID
    public string AnswerText { get; set; }              // 응시자의 답변 내용
    public bool IsGraded { get; set; }            // 채점 여부
}