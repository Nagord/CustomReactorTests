using PulsarPluginLoader.Content.Components.Hull;
using PulsarPluginLoader.Content.Components.InertiaThruster;
using PulsarPluginLoader.Content.Components.Thruster;
using PulsarPluginLoader.Content.Components.Reactor;
using PulsarPluginLoader.Content.Components.Shield;
using PulsarPluginLoader.Content.Components.WarpDrive;
using PulsarPluginLoader.Chat.Commands.CommandRouter;
using PulsarPluginLoader.Utilities;
using PulsarPluginLoader.Content.Components.ManeuverThruster;
using PulsarPluginLoader.Content.Components.CaptainsChair;
using PulsarPluginLoader.Content.Components.Extractor;
using PulsarPluginLoader.Content.Components.Missile;
using PulsarPluginLoader.Content.Components.NuclearDevice;
using PulsarPluginLoader.Content.Components.MissionShipComponent;
using PulsarPluginLoader.Content.Components.CPU;
using PulsarPluginLoader.Content.Components.WarpDriveProgram;
using PulsarPluginLoader.Content.Components.PolytechModule;
using PulsarPluginLoader.Content.Components.FBRecipeModule;


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
                    CurrentShip.MyStats.AddShipComponent(ReactorPluginManager.CreateReactor(ReactorPluginManager.Instance.GetReactorIDFromName("CryoCore"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(ReactorPluginManager.CreateReactor(ReactorPluginManager.Instance.GetReactorIDFromName("Goodie"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(ReactorPluginManager.CreateReactor(ReactorPluginManager.Instance.GetReactorIDFromName("Deadly"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(new CustomContentTests.AutoTurret.DragonAutoTurret(0, 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(CaptainsChairPluginManager.CreateCaptainsChair(CaptainsChairPluginManager.Instance.GetCaptainsChairIDFromName("Dragon CaptainsChair"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(CPUPluginManager.CreateCPU(CPUPluginManager.Instance.GetCPUIDFromName("Dragon CPU"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(ExtractorPluginManager.CreateExtractor(ExtractorPluginManager.Instance.GetExtractorIDFromName("Dragon Extractor"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(HullPluginManager.CreateHull(HullPluginManager.Instance.GetHullIDFromName("Dragon Hull"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(new CustomContentTests.HullPlating.DragonHullPlating(0, 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(InertiaThrusterPluginManager.CreateInertiaThruster(InertiaThrusterPluginManager.Instance.GetInertiaThrusterIDFromName("Dragon InertiaThruster"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(ManeuverThrusterPluginManager.CreateManeuverThruster(ManeuverThrusterPluginManager.Instance.GetManeuverThrusterIDFromName("Dragon ManeuverThruster"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(new CustomContentTests.MegaTurret.DragonMegaTurret(0, 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(MissilePluginManager.CreateMissile(MissilePluginManager.Instance.GetMissileIDFromName("Dragon Missile"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(MissionShipComponentPluginManager.CreateMissionShipComponent(MissionShipComponentPluginManager.Instance.GetMissionShipComponentIDFromName("Dragon MissionShipComponent"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(NuclearDevicePluginManager.CreateNuclearDevice(NuclearDevicePluginManager.Instance.GetNuclearDeviceIDFromName("Dragon NuclearDevice"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(ShieldPluginManager.CreateShield(ShieldPluginManager.Instance.GetShieldIDFromName("Dragon Shield"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(ThrusterPluginManager.CreateThruster(ThrusterPluginManager.Instance.GetThrusterIDFromName("Dragon Thruster"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(new CustomContentTests.Turret.DragonTurret(0, 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(WarpDrivePluginManager.CreateWarpDrive(WarpDrivePluginManager.Instance.GetWarpDriveIDFromName("Dragon WarpDrive"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(WarpDriveProgramPluginManager.CreateWarpDriveProgram(WarpDriveProgramPluginManager.Instance.GetWarpDriveProgramIDFromName("Dragon WarpDriveProgram"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(WarpDriveProgramPluginManager.CreateWarpDriveProgram(WarpDriveProgramPluginManager.Instance.GetWarpDriveProgramIDFromName("Dragon WarpDriveProgramVirus"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(PolytechModulePluginManager.CreatePolytechModule(PolytechModulePluginManager.Instance.GetPolytechModuleIDFromName("P.T. Module: Mass Annihilator"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(FBRecipeModulePluginManager.CreateFBRecipeModule(FBRecipeModulePluginManager.Instance.GetFBRecipeModuleIDFromName("Phase Pistol"), 0), -1, ESlotType.E_COMP_NONE);
                    CurrentShip.MyStats.AddShipComponent(FBRecipeModulePluginManager.CreateFBRecipeModule(FBRecipeModulePluginManager.Instance.GetFBRecipeModuleIDFromName("Pizza"), 0), -1, ESlotType.E_COMP_NONE);
                    break;
                case "addtoinv":
                    PulsarPluginLoader.Content.Items.ItemPluginManager.Instance.GetItemIDsFromName("Slime", out int Main, out int Sub);
                    PLNetworkManager.Instance.LocalPlayer.MyInventory.UpdateItem(PLServer.Instance.PawnInvItemIDCounter++, Main, Sub, 0, -1);
                    PulsarPluginLoader.Content.Items.ItemPluginManager.Instance.GetItemIDsFromName("Pizza", out Main, out Sub);
                    PLNetworkManager.Instance.LocalPlayer.MyInventory.UpdateItem(PLServer.Instance.PawnInvItemIDCounter++, Main, Sub, 0, -1);
                    break;
            }
        }
    }
}
