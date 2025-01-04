using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.WPF.View;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.DependencyInjection;

namespace BMS.WPF.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private object _mainContent;
    public MainWindowViewModel()
    {
        this._mainContent = App.MainServiceProvider.GetRequiredService<ManualGradeView>();
    }
}