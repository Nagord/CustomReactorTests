namespace CustomContentTests.Reactor
{
    class DeadlyReactor : PulsarModLoader.Content.Components.Reactor.ReactorMod
    {
        public override string Name => "Deadly";

        public override string Description => "Idk, I just make things";

        public override float EnergyOutputMax => 1000f;

        public override bool Experimental => true;
    }
}
