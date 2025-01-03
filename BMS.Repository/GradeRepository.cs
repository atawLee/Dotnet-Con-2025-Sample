using System.Net.Http.Headers;
using BMS.Data;
using System.Text;
using Newtonsoft.Json;

namespace BMS.Repository;

public interface IGradeRepository
{
    Task<List<ExamInfo>> GetExamInformationList();
    Task<List<GradeInfo>> GetGradingInfoList(string examineeId);
    Task<GradeInfoDetail> GetGradingDetail(GradeInfo gradeInfo);
    Task SaveGrade(GradeInfoDetail detail);
}

public class StubGradeRepository : IGradeRepository
{
    private List<ExamInfo> examInfos = new();
    private List<GradeInfo> gradeInfos = new();
    private List<GradeInfoDetail> gradeInfoDetails = new();
    public Task<List<ExamInfo>> GetExamInformationList()
    {
        throw new NotImplementedException();
    }

    public Task<List<GradeInfo>> GetGradingInfoList(string examineeId)
    {
        throw new NotImplementedException();
    }

    public Task<GradeInfoDetail> GetGradingDetail(GradeInfo gradeInfo)
    {
        throw new NotImplementedException();
    }

    public Task SaveGrade(GradeInfoDetail detail)
    {
        throw new NotImplementedException();
    }
}

public class GradeRepository : IGradeRepository
{
    public GradeRepository()
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

    public async Task<List<GradeInfo>> GetGradingInfoList(string examineeId)
    {
        HttpClient client = new HttpClient();
        var result = await client.GetAsync($"https://sampledata/examineeId={examineeId}");
        result.EnsureSuccessStatusCode();
        var json = await result.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<GradeInfo>>(json);
    }

    public async Task<GradeInfoDetail> GetGradingDetail(GradeInfo gradeInfo)
    {
        HttpClient client = new HttpClient();
        var result = await client.GetAsync("https://sampledata");
        result.EnsureSuccessStatusCode();
        var json = await result.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<GradeInfoDetail>(json);
    }

    public async Task SaveGrade(GradeInfoDetail detail)
    {
        HttpClient client = new HttpClient();
        var json = JsonConvert.SerializeObject(detail);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var result = await client.PostAsync("https://sampledata", content);
        result.EnsureSuccessStatusCode();
    }
}

