namespace CookiesCookbookTutorSolution.Recipes.Ingredients;

public abstract class Flour : Ingredient
{
    public override string PreparationInstructions =>
             $"Sieve. {base.PreparationInstructions}";   // Take second sentence from the base type (Ingredient) to reduce repetition
}
