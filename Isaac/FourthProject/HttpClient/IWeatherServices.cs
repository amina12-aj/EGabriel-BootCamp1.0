namespace ExternalApi
{
    public interface IWeatherServices
    {
        Task<string> Get(string cityName);
    }
}
