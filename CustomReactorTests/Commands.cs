using PulsarModLoader.Content.Components.Hull;
using PulsarModLoader.Content.Components.InertiaThruster;
using PulsarModLoader.Content.Components.Thruster;
using PulsarModLoader.Content.Components.Reactor;
using PulsarModLoader.Content.Components.Shield;
using PulsarModLoader.Content.Components.WarpDrive;
using PulsarModLoader.Chat.Commands.CommandRouter;
using PulsarModLoader.Utilities;
using PulsarModLoader.Content.Components.ManeuverThruster;
using PulsarModLoader.Content.Components.CaptainsChair;
using PulsarModLoader.Content.Components.Extractor;
using PulsarModLoader.Content.Components.Missile;
using PulsarModLoader.Content.Components.NuclearDevice;
using PulsarModLoader.Content.Components.MissionShipComponent;
using PulsarModLoader.Content.Components.CPU;
using PulsarModLoader.Content.Components.WarpDriveProgram;
using PulsarModLoader.Content.Components.PolytechModule;
using PulsarModLoader.Content.Components.FBRecipeModule;


namespace CustomReactorTests
{
    class Commands : ChatCommand
    {
        public override string[] CommandAliases()
        {
            return new string[] { "conttests", "ct" };
        }

        public override string Description()
        {
            return "runs subcommands. addtoship, addtoinv";
        }

        public override void Execute(string arguments)
        {
            string[] args = arguments.Split(' ');
            switch (args[0].ToLower())
            {
                default:
                    Messaging.Notification("Wrong subcommand. Commands: addtoship, addtoinv");
                    break;
                case "addtoship":
                    PLShipInfo CurrentShip = PLNetworkManager.Instance.MyLocalPawn.CurrentShip;
                    CurrentShip.MyStats.AddShipComponent(ReactorModManager.CreateReactor(ReactorModManager.Instance.GetReactorIDFromName("CryoCore"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(ReactorModManager.CreateReactor(ReactorModManager.Instance.GetReactorIDFromName("Goodie"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(ReactorModManager.CreateReactor(ReactorModManager.Instance.GetReactorIDFromName("Deadly"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(new CustomContentTests.AutoTurret.DragonAutoTurret(0, 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(CaptainsChairModManager.CreateCaptainsChair(CaptainsChairModManager.Instance.GetCaptainsChairIDFromName("Dragon CaptainsChair"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(CPUModManager.CreateCPU(CPUModManager.Instance.GetCPUIDFromName("Dragon CPU"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(ExtractorModManager.CreateExtractor(ExtractorModManager.Instance.GetExtractorIDFromName("Dragon Extractor"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(HullModManager.CreateHull(HullModManager.Instance.GetHullIDFromName("Dragon Hull"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(new CustomContentTests.HullPlating.DragonHullPlating(0, 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(InertiaThrusterModManager.CreateInertiaThruster(InertiaThrusterModManager.Instance.GetInertiaThrusterIDFromName("Dragon InertiaThruster"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(ManeuverThrusterModManager.CreateManeuverThruster(ManeuverThrusterModManager.Instance.GetManeuverThrusterIDFromName("Dragon ManeuverThruster"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(new CustomContentTests.MegaTurret.DragonMegaTurret(0, 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(MissileModManager.CreateMissile(MissileModManager.Instance.GetMissileIDFromName("Dragon Missile"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(MissionShipComponentModManager.CreateMissionShipComponent(MissionShipComponentModManager.Instance.GetMissionShipComponentIDFromName("Dragon MissionShipComponent"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(NuclearDeviceModManager.CreateNuclearDevice(NuclearDeviceModManager.Instance.GetNuclearDeviceIDFromName("Dragon NuclearDevice"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(ShieldModManager.CreateShield(ShieldModManager.Instance.GetShieldIDFromName("Dragon Shield"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(ThrusterModManager.CreateThruster(ThrusterModManager.Instance.GetThrusterIDFromName("Dragon Thruster"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(new CustomContentTests.Turret.DragonTurret(0, 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(WarpDriveModManager.CreateWarpDrive(WarpDriveModManager.Instance.GetWarpDriveIDFromName("Dragon WarpDrive"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(WarpDriveProgramModManager.CreateWarpDriveProgram(WarpDriveProgramModManager.Instance.GetWarpDriveProgramIDFromName("Dragon WarpDriveProgram"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(WarpDriveProgramModManager.CreateWarpDriveProgram(WarpDriveProgramModManager.Instance.GetWarpDriveProgramIDFromName("Dragon WarpDriveProgramVirus"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(PolytechModuleModManager.CreatePolytechModule(PolytechModuleModManager.Instance.GetPolytechModuleIDFromName("P.T. Module: Mass Annihilator"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(FBRecipeModuleModManager.CreateFBRecipeModule(FBRecipeModuleModManager.Instance.GetFBRecipeModuleIDFromName("Phase Pistol"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(FBRecipeModuleModManager.CreateFBRecipeModule(FBRecipeModuleModManager.Instance.GetFBRecipeModuleIDFromName("Pizza"), 0), -1, ESlotType.E_COMP_NONE);
                    break;
                case "addtoinv":
                    PulsarModLoader.Content.Items.ItemModManager.Instance.GetItemIDsFromName("Slime", out int Main, out int Sub);
                    PLNetworkManager.Instance.LocalPlayer.MyInventory.UpdateItem(PLServer.Instance.PawnInvItemIDCounter++, Main, Sub, 0, -1);
                    PulsarModLoader.Content.Items.ItemModManager.Instance.GetItemIDsFromName("Pizza", out Main, out Sub);
                    PLNetworkManager.Instance.LocalPlayer.MyInventory.UpdateItem(PLServer.Instance.PawnInvItemIDCounter++, Main, Sub, 0, -1);
                    break;
            }
        }
    }
}
