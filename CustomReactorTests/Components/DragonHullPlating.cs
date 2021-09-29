using PulsarModLoader.Content.Components.HullPlating;

namespace CustomContentTests.HullPlating
{
    class DragonHullPlatingMod : HullPlatingMod
    {
        public override PLShipComponent PLHullPlating => new DragonHullPlating();

        public override string Name => "DragonHullPlating";
    }
    public class DragonHullPlating : PLHullPlating
    {
        public DragonHullPlating(int inLevel = 0, int inSubTypeData = 1) : base(EHullPlatingType.E_HULLPLATING_CCGE, 0)
        {
            SubType = HullPlatingModManager.Instance.GetHullPlatingIDFromName("DragonHullPlating");
            Name = "DragonHullPlating";
            Desc = "a hull plating, nothing special.";
            m_MarketPrice = 100000;
            Experimental = true;
            Level = inLevel;
            SubTypeData = (short)inSubTypeData;
        }
    }
}
