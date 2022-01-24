namespace BlazorInferenceCallback
{
    public class Ingredient : IIngredient
    {
        public static IEnumerable<Ingredient> Ingredients { get; } = new Ingredient[] { "Mango", "Garlic", "Sugar" , "Honey" };
        public string Name { get; init; } = default!;

        public static implicit operator Ingredient(string name)
            => new() { Name = name };
        public override string ToString()
            => Name;
    }

    public interface IIngredient
    {
        public string Name { get; }
    }
}
