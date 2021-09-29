using PulsarModLoader.Content.Components.Thruster;

namespace CustomContentTests.Thruster
{
    class DragonThruster : ThrusterMod
    {
        public override string Name => "Dragon Thruster";

        public override float MaxOutput => 1f;

        public override float MaxPowerUsage_Watts => 400f;
    }
}
