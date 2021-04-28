using ContentMod.Components.Hull;

namespace CustomContentTests.Hull
{
    class DragonHull : HullPlugin
    {
        public override string Name => "Dragon Hull";

        public override float HullMax => 100000f;
    }
}
