using PulsarPluginLoader.Content.Components.Virus;

namespace CustomContentTests.Virus
{
    class DragonVirus : VirusPlugin
    {
        public override string Name => "Dragon Virus";

        public override string Description => "disabled EM sensors";

        public override bool Experimental => true;

        public override void FinalLateAddStats(PLShipComponent InComp)
        {
            InComp.ShipStats.EMDetection = 0;
        }
    }
}
