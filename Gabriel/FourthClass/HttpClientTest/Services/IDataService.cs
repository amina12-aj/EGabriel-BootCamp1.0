using HttpClientTest.Models;

namespace HttpClientTest.Services
{
    public interface IDataService
    {
        Task<TimezoneResponse> GetTimezone();
        Task<PredictionsModel> GetPredictions();
    }
}