namespace CustomContentTests.Components.RecipeModule
{
    class PizzaRecipe : PulsarPluginLoader.Content.Components.FBRecipeModule.FBRecipeModulePlugin
    {
        public override int[] ItemTypeToProduce
        {
            get
            {
                PulsarPluginLoader.Content.Items.ItemPluginManager.Instance.GetItemIDsFromName("Pizza", out int main, out int sub);
                return new int[] { main, sub };
            }
        }

        public override string Name => "Pizza";

        public override string Description => "Biscuit mix is super dense.";
    }
}
