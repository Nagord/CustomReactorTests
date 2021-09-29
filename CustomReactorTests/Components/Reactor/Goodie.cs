namespace CustomContentTests.Reactor
{
    class Goodie : PulsarModLoader.Content.Components.Reactor.ReactorMod
    {
        public override string Name => "Goodie";

        public override string Description => "Idk, I just make things";

        public override float EnergyOutputMax => 1000000f;

        public override bool Experimental => true;
    }
}
