using CookiesCookbookTutorSolution.Recipes.Ingredients;
using CookiesCookbookTutorSolution.Recipes;

namespace CookiesCookbookTutorSolution.App;

public interface IRecipesUserInteraction
{
    void ShowMessage(string message);
    void Exit();
    void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
    void PromptToCreateRecipe();
    IEnumerable<Ingredient> ReadIngredientsFromUser();
}
