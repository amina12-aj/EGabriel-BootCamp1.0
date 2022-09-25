namespace CocktailApplication.Service
{
    public interface ICocktailService
    {
        bool AlreadyExists(string ingredient);

        Task Persist(string ingredient);
    }
}