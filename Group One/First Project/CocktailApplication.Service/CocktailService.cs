using CocktailApplication.Domain;
using CocktailApplication.Repository;

namespace CocktailApplication.Service
{
    public class CocktailService : ICocktailService
    {
        private readonly IRepository<Ingredient> _ingredientRepository;

        public CocktailService(IRepository<Ingredient> ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
        }
        
        public bool AlreadyExists(string ingredient)
        {
            var ingredients = _ingredientRepository.GetAll();
            var i = ingredients.Select(i => i.Name = ingredient);
            return i == null;
        }

        public async Task Persist(string ingredient)
        {
            Ingredient i = new() { Id = Guid.NewGuid(), Name = ingredient};
            await _ingredientRepository.Create(i);
        }
    }
}