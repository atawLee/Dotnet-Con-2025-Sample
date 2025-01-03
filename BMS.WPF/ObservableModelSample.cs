using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BMS.WPF;

public partial class ObservableModelSample : ObservableObject
{
    [ObservableProperty] private string _name;

    [ObservableProperty] private string _email;
}