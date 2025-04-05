using CookiesCookbookTutorSolution.Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbookTutorSolution.App;

// Main Application Workflow
public class CookiesRecipeApp
{
    private readonly IRecipesRepository _recipesRepository;
    private readonly IRecipesUserInteraction _recipesUserInteraction;

    public CookiesRecipeApp(IRecipesRepository recipesRepository, IRecipesUserInteraction recipesUserInteraction)
    {
        _recipesRepository = recipesRepository;
        _recipesUserInteraction = recipesUserInteraction;
    }
    public void Run(string filePath)
    {
        // Read All Recipes from the file
        var allRecipes = _recipesRepository.Read(filePath);
        // Print all Recipes
        _recipesUserInteraction.PrintExistingRecipes(allRecipes);
        // Prompt user to create a recipe
        _recipesUserInteraction.PromptToCreateRecipe();
        // Read Ingredients entered by the user
        var ingredients = _recipesUserInteraction.ReadIngredientsFromUser();

        // Check if user entered any ingredients - if yes create recipe and save it to the recipes file
        if (ingredients.Count() > 0)
        {
            var recipe = new Recipe(ingredients);
            allRecipes.Add(recipe);
            _recipesRepository.Write(filePath, allRecipes);

            _recipesUserInteraction.ShowMessage("Recipe added:");
            _recipesUserInteraction.ShowMessage(recipe.ToString());
        }
        else
        {
            _recipesUserInteraction.ShowMessage("No ingredients have been selected. " + "Recipe will not be saved");
        }
        // Exit the application
        _recipesUserInteraction.Exit();
    }
}
