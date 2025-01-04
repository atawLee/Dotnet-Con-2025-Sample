using System.Collections.ObjectModel;
using BMS.Business.Service;
using BMS.Domain.Entity;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BMS.WPF.ViewModels;

public partial class ManualGradeViewModel : ObservableObject
{
    private readonly GradeService _service;
    public ObservableCollection<ExamInfo> ExamInfos { get; set; } = new();
    public ObservableCollection<GradeInfo> GradeInfos { get; set; } = new();
    
    private GradeInfo _selectedGradeInfo;
    public GradeInfo SelectedGradeInfo
    {
        get => _selectedGradeInfo;
        set
        {
            SetProperty(ref _selectedGradeInfo, value);
            LoadGradeDetail(value);
        }
    }

    private async Task LoadGradeDetail(GradeInfo value)
    {
        if(value == null) return;

        var data = await _service.GetGradingDetail(value);
        this.GradeInfoDetail = data;
    }

    [ObservableProperty] private GradeInfoDetail _gradeInfoDetail;

    [ObservableProperty] private int _selectedTabIndex = 0;

    public ManualGradeViewModel(GradeService service)
    {
        _service = service;

        LoadExamInfo();
    }

    public async Task LoadExamInfo()
    {
        var examInfos = await _service.GetExamInformationList();
        ExamInfos.Clear();
        examInfos.ForEach(x=> ExamInfos.Add(x));
    }

    [RelayCommand]
    public async Task SelectGradeInfo(ExamInfo info)
    {
        var list = await _service.GetGradingInfoList(info.ExamineeId);
        GradeInfos.Clear();
        list.ForEach(x => GradeInfos.Add(x));
        this.SelectedTabIndex = 1;
    }

    [RelayCommand]
    public async Task SelectGradeDetail(GradeInfo info)
    {

    }


}