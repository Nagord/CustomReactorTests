using PulsarModLoader.Content.Components.CaptainsChair;

namespace CustomContentTests.CaptainsChair
{
    class DragonCaptainsChair : CaptainsChairMod
    {
        public override string Name => "Dragon CaptainsChair";

        public override string Description => "A design of chair that has been installed in Colonial Union ships for many decades. It is quite comfortable. \n\n+10% EM Detection\n+10% Shield Charge Rate\n+10% Turret Charge Rate";

        public override void LateAddStats(PLShipComponent InComp)
        {
            InComp.ShipStats.EMDetection *= 1.1f;
            InComp.ShipStats.ShieldsChargeRate *= 1.1f;
            InComp.ShipStats.ShieldsChargeRateMax *= 1.1f;
            InComp.ShipStats.TurretChargeFactor *= 1.1f;
        }
    }
}
