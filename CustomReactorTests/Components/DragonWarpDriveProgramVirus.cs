using ContentMod.Components.WarpDriveProgram;

namespace CustomContentTests.WarpDriveProgram
{
    class DragonWarpDriveProgramVirus : WarpDriveProgramPlugin
    {
        public override string Name => "Dragon WarpDriveProgramVirus";

        public override string Description => "Who knows?";

        public override bool Experimental => true;

        public override int VirusSubtype => DragonReactor.Components.Virus.VirusPluginManager.Instance.GetVirusIDFromName("Dragon Virus");

        public override bool IsVirus => true;
    }
}
