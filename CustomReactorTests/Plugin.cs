using PulsarPluginLoader;
using UnityEngine;

namespace CustomContentTests
{
    public class Plugin : PulsarPlugin
    {
        Plugin()
        {
            Global.PizzaAssetBundle = AssetBundle.LoadFromFile(Application.dataPath + "/Managed/Plugins/CustomComponentTests/pizza.pizza");
            Global.PizzaAsset = Global.PizzaAssetBundle.LoadAsset<GameObject>("Assets/Pizza.prefab");
        }
        public override string Version => "0.0.2";

        public override string Author => "Dragon";

        public override string LongDescription => "Creates components, meant as examples.";

        public override string Name => "ComponentTests";

        public override string HarmonyIdentifier()
        {
            return "Dragon.ComponentTests";
        }
    }
}
