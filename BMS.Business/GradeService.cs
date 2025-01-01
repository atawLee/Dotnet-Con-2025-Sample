using BMS.Data;
using Newtonsoft.Json;

namespace BMS.Business;

/// <summary>
/// 채점 서비스
/// </summary>
public class GradeService
{
    public GradeService()
    {
        
    }

    public async Task<List<ExamInfo>> GetExamInformationList()
    {
        HttpClient client = new HttpClient();
        var result = await client.GetAsync("https://sampledata");
        result.EnsureSuccessStatusCode();
        var json = await result.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<ExamInfo>>(json);
    }

    public async Task<List<GradeInfo>> GetGradingInfoList()
    {

    }

    public void GetGradingDetail(GradeInfo gradeInfo)
    {

    }
}