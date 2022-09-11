using hub.Models;

namespace hub.Data
{
    public interface IRepository
    {
        Dictionary<string, object> GetHubs(string state);
    }
}