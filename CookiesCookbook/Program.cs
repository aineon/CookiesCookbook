
Console.WriteLine( "Create a new cookie recipe! Available ingredients are: ");

List<Ingredient> ingredients = new List<Ingredient>
{
    new WheatFlour(),
    new CoconutFlour(),
    new Butter(),
    new Chocolate(),
    new Sugar(),
    new Cardamom(),
    new Cinnamon(),
    new CocoaPowder(),
};

foreach (var ingredient in ingredients)
{
    Console.WriteLine($"{ingredient.Id}. {ingredient.Name}");
}

Console.WriteLine("Add an ingredient by it's Id or press any other key if finished.");
var selectedIngredient = Console.ReadLine();

Console.WriteLine(selectedIngredient);

Console.ReadKey();

public enum FileFormat
{
    txt,
    json
}

public class Recipe
{
    public List<Ingredient> recipe = new List<Ingredient>();
    
    
    public void AddIngredient(int selection)
    {
        Console.WriteLine("Add an ingredient by it's Id or press any other key if finished.");
        var selectedIngredient = Console.ReadLine();

        
      
    }
}

public abstract class Ingredient
{
    public override string ToString() => Name;
    public virtual string Name { get; } = "Some ingredient";
    public virtual int Id { get; } = 0;

    public abstract void PreparationInstructions(); 

    public void PrintIngredients(Ingredient ingredient)
    {
        
    }
    
}
public class WheatFlour : Ingredient
{
    public override int Id => 1;
    public override string Name => "Wheat Flour";

    public override void PreparationInstructions()
    {
        Console.WriteLine("Sieve. Add to other ingredients.");
    }
}

public class CoconutFlour : Ingredient
{
    public override int Id => 2;
    public override string Name => "Coconut Flour";

    public override void PreparationInstructions()
    {
        Console.WriteLine("Sieve. Add to other ingredients.");
    }
}

public class Butter : Ingredient
{
    public override int Id => 3;
    public override string Name => "Butter";

    public override void PreparationInstructions()
    {
        Console.WriteLine("Melt on low heat. Add to other ingredients.");
    }
}

public class Chocolate : Ingredient
{
    public override int Id => 4;
    public override string Name => "Chocolate";

    public override void PreparationInstructions()
    {
        Console.WriteLine("Melt in a water bath. Add to other ingredients.");
    }
}

public class Sugar : Ingredient
{
    public override int Id => 5;
    public override string Name => "Sugar";

    public override void PreparationInstructions()
    {
        Console.WriteLine("Add to other ingredients.");
    }
}

public class Cardamom : Ingredient
{
    public override int Id => 6;
    public override string Name => "Cardamom";

    public override void PreparationInstructions()
    {
        Console.WriteLine("Take half a teaspoon. Add to other ingredients.");
    }
}

public class Cinnamon : Ingredient
{
    public override int Id => 7;
    public override string Name => "Cinnamon";

    public override void PreparationInstructions()
    {
        Console.WriteLine("Take half a teaspoon. Add to other ingredients.");
    }
}

public class CocoaPowder : Ingredient
{
    public override int Id => 8;
    public override string Name => "Cocoa Powder";

    public override void PreparationInstructions()
    {
        Console.WriteLine("Add to other ingredients.");
    }
}



class StringsTextualRepository
{
    private static readonly string Separator = Environment.NewLine;
    public List<string> Read(string filePath)
    {
        var fileContents = File.ReadAllText(filePath);
        return fileContents.Split(Environment.NewLine).ToList();
    }

    public void Write(string filePath, List<string> strings) =>
        File.WriteAllText(filePath, string.Join(Environment.NewLine, strings));
}