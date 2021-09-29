namespace CustomContentTests.Components.RecipeModule
{
    class PizzaRecipe : PulsarModLoader.Content.Components.FBRecipeModule.FBRecipeModuleMod
    {
        public override int[] ItemTypeToProduce
        {
            get
            {
                PulsarModLoader.Content.Items.ItemModManager.Instance.GetItemIDsFromName("Pizza", out int main, out int sub);
                return new int[] { main, sub };
            }
        }

        public override string Name => "Pizza";

        public override string Description => "Biscuit mix is super dense.";
    }
}
