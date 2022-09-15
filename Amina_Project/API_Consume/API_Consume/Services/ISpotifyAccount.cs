namespace API_Consume.Services
{
    public interface ISpotifyAccount
    {
        Task<string> GetToken(string clientId, string clientSecret);
    }
}
