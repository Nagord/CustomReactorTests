using PulsarModLoader.Content.Components.WarpDriveProgram;

namespace CustomContentTests.WarpDriveProgram
{
    class DragonWarpDriveProgram : WarpDriveProgramMod
    {
        public override string Name => "Dragon WarpDriveProgram";

        public override string Description => "Who knows?";

        public override bool Experimental => true;

        public override float ActiveTime => base.ActiveTime;

        public override void FinalLateAddStats(PLShipComponent InComp)
        {
            InComp.ShipStats.EMDetection *= 1f + .1f * InComp.LevelMultiplier(0.2f, 1f);
            InComp.ShipStats.ShieldsChargeRate *= 1f + .1f * InComp.LevelMultiplier(0.2f, 1f);
            InComp.ShipStats.ShieldsChargeRateMax *= 1f + .1f * InComp.LevelMultiplier(0.2f, 1f);
            InComp.ShipStats.TurretChargeFactor *= 1f + .1f * InComp.LevelMultiplier(0.2f, 1f);
        }
        public override void Execute(PLWarpDriveProgram InWarpDriveProgram)
        {
            InWarpDriveProgram.ShipStats.ShieldsCurrent = 0f;
        }
    }
}
