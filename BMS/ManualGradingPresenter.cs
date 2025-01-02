using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.Business;

namespace BMS.Winform;

public class ManualGradingPresenter 
{
    private readonly GradeService _service;
    private ManualGradingForm _view;

    public ManualGradingPresenter(GradeService service)
    {
        _service = service;
    }

    public void SetView(ManualGradingForm view)
    {
        this._view = view;
    }

}