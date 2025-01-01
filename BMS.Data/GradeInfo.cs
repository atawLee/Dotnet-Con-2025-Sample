using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Data
{
    public class GradeInfo
    {
        public int ExamId { get; set; }
        public string ExamineeId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public int Score { get; set; }
        public int IsGraded { get; set; }
    }
}
