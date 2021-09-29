using PulsarModLoader;
using System.IO;
using UnityEngine;

namespace CustomContentTests
{
    public class Mod : PulsarMod
    {
        public Mod()
        {
            Global.PizzaAssetBundle = AssetBundle.LoadFromFile( Path.Combine(Directory.GetCurrentDirectory(), "Mods/CustomComponentTests/pizza.pizza"));
            Global.PizzaAsset = Global.PizzaAssetBundle.LoadAsset<GameObject>("Assets/Pizza.prefab");
        }
        public override string Version => "0.0.3";

        public override string Author => "Dragon";

        public override string LongDescription => "Creates custom content, meant as examples for PulsarModLoader.Content";

        public override string Name => "CustomContentTests";

        public override string HarmonyIdentifier()
        {
            return "Dragon.CustomContentTests";
        }
    }
}
