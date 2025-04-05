

using CookiesCookbookTutorSolution.App;
using CookiesCookbookTutorSolution.DataAccess;
using CookiesCookbookTutorSolution.FileAccess;
using CookiesCookbookTutorSolution.Recipes;
using CookiesCookbookTutorSolution.Recipes.Ingredients;
using System.Text.Json;

const FileFormat Format = FileFormat.Json;

IStringsRepository stringsReposiory = Format == FileFormat.Json ? new StringsJsonRepository() : new StringsTextualRepository();


const string FileName = "recipes";
var fileMetaData = new FileMetaData(FileName, Format);

var ingredientsRegister = new IngredientsRegister();

var cookiesRecipeApp = new CookiesRecipeApp(
    new RecipesRepository(stringsReposiory, ingredientsRegister),
    new RecipesConsoleUserInteraction(ingredientsRegister)
    );

cookiesRecipeApp.Run(fileMetaData.ToPath());





