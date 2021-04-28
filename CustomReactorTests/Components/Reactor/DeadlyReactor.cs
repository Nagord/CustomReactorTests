namespace CustomContentTests.Reactor
{
    class DeadlyReactor : DragonReactor.Components.Reactor.ReactorPlugin
    {
        public override string Name => "Goodie";

        public override string Description => "Idk, I just make things";

        public override float EnergyOutputMax => 1000f;

        public override bool Experimental => true;
    }
}
