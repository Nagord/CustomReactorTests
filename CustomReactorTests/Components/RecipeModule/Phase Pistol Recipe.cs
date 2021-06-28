namespace CustomContentTests.Components.RecipeModule
{
    class PhasePistolRecipe : PulsarPluginLoader.Content.Components.FBRecipeModule.FBRecipeModulePlugin
    {
        public override int[] ItemTypeToProduce => new int[] { 2, 0 };

        public override string Name => "Phase Pistol";

        public override string Description => "Did you know you can make phase pistols out of common biscuit mix?";
    }
}
