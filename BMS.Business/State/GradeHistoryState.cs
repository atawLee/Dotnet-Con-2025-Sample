using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.Data;

namespace BMS.Business.State;

public class GradeHistoryState
{
    private List<GradeInfoDetail> GradeInfoDetails { get; set; } = new(32);
    public void Add(GradeInfoDetail detail)
    {
        GradeInfoDetails.Add(detail);
    }
    public int Count => GradeInfoDetails.Count;
}