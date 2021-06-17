using PulsarPluginLoader;
using UnityEngine;

namespace CustomContentTests
{
    public class Plugin : PulsarPlugin
    {
        public Plugin()
        {
            Global.PizzaAssetBundle = AssetBundle.LoadFromFile(Application.dataPath + "/Managed/Mods/CustomComponentTests/pizza.pizza");
            Global.PizzaAsset = Global.PizzaAssetBundle.LoadAsset<GameObject>("Assets/Pizza.prefab");
        }
        public override string Version => "0.0.2";

        public override string Author => "Dragon";

        public override string LongDescription => "Creates custom content, meant as examples for PulsarPluginLoader.Content";

        public override string Name => "CustomContentTests";

        public override string HarmonyIdentifier()
        {
            return "Dragon.CustomContentTests";
        }
    }
}
