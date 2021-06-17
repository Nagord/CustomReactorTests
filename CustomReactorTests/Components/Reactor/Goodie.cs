namespace CustomContentTests.Reactor
{
    class Goodie : PulsarPluginLoader.Content.Components.Reactor.ReactorPlugin
    {
        public override string Name => "Goodie";

        public override string Description => "Idk, I just make things";

        public override float EnergyOutputMax => 1000000f;

        public override bool Experimental => true;
    }
}
