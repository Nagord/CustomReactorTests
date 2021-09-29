using PulsarModLoader.Content.Components.WarpDriveProgram;

namespace CustomContentTests.WarpDriveProgram
{
    class DragonWarpDriveProgramVirus : WarpDriveProgramMod
    {
        public override string Name => "Dragon WarpDriveProgramVirus";

        public override string Description => "Who knows?";

        public override bool Experimental => true;

        public override int VirusSubtype => PulsarModLoader.Content.Components.Virus.VirusModManager.Instance.GetVirusIDFromName("Dragon Virus");

        public override bool IsVirus => true;
    }
}
