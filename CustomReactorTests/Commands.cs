using ContentMod.Components.Hull;
using ContentMod.Components.InertiaThruster;
using ContentMod.Components.Thruster;
using ContentMod.Components.Reactor;
using ContentMod.Components.Shield;
using ContentMod.Components.WarpDrive;
using PulsarPluginLoader.Chat.Commands.CommandRouter;
using PulsarPluginLoader.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContentMod.Components.ManeuverThruster;
using ContentMod.Components.CaptainsChair;
using ContentMod.Components.Extractor;
using ContentMod.Components.Missile;
using ContentMod.Components.NuclearDevice;
using ContentMod.Components.MissionShipComponent;
using ContentMod.Components.Virus;

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
            return "runs subcommands. addtoship, addtoinv, dbg, tbdg";
        }

        public override void Execute(string arguments)
        {
            string[] args = arguments.Split(' ');
            switch (args[0].ToLower())
            {
                default:
                    Messaging.Notification("Wrong subcommand");
                    break;
                case "addtoship":
                    PLNetworkManager.Instance.MyLocalPawn.CurrentShip.MyStats.AddShipComponent(ReactorPluginManager.CreateReactor(ReactorPluginManager.Instance.GetReactorIDFromName("Dragon Reactor"), 0), -1, ESlotType.E_COMP_NONE);
                    PLNetworkManager.Instance.MyLocalPawn.CurrentShip.MyStats.AddShipComponent(ShieldPluginManager.CreateShield(ShieldPluginManager.Instance.GetShieldIDFromName("Dragon Shield"), 0), -1, ESlotType.E_COMP_NONE);
                    PLNetworkManager.Instance.MyLocalPawn.CurrentShip.MyStats.AddShipComponent(HullPluginManager.CreateHull(HullPluginManager.Instance.GetHullIDFromName("Dragon Hull"), 0), -1, ESlotType.E_COMP_NONE);
                    PLNetworkManager.Instance.MyLocalPawn.CurrentShip.MyStats.AddShipComponent(WarpDrivePluginManager.CreateWarpDrive(WarpDrivePluginManager.Instance.GetWarpDriveIDFromName("Dragon WarpDrive"), 0), -1, ESlotType.E_COMP_NONE);
                    PLNetworkManager.Instance.MyLocalPawn.CurrentShip.MyStats.AddShipComponent(ThrusterPluginManager.CreateThruster(ThrusterPluginManager.Instance.GetThrusterIDFromName("Dragon Thruster"), 0), -1, ESlotType.E_COMP_NONE);
                    PLNetworkManager.Instance.MyLocalPawn.CurrentShip.MyStats.AddShipComponent(InertiaThrusterPluginManager.CreateInertiaThruster(InertiaThrusterPluginManager.Instance.GetInertiaThrusterIDFromName("Dragon InertiaThruster"), 0), -1, ESlotType.E_COMP_NONE);
                    PLNetworkManager.Instance.MyLocalPawn.CurrentShip.MyStats.AddShipComponent(ManeuverThrusterPluginManager.CreateManeuverThruster(ManeuverThrusterPluginManager.Instance.GetManeuverThrusterIDFromName("Dragon ManeuverThruster"), 0), -1, ESlotType.E_COMP_NONE);
                    PLNetworkManager.Instance.MyLocalPawn.CurrentShip.MyStats.AddShipComponent(CaptainsChairPluginManager.CreateCaptainsChair(CaptainsChairPluginManager.Instance.GetCaptainsChairIDFromName("Dragon CaptainsChair"), 0), -1, ESlotType.E_COMP_NONE);
                    PLNetworkManager.Instance.MyLocalPawn.CurrentShip.MyStats.AddShipComponent(new CustomContentTests.MegaTurret.DragonMegaTurret(0, 0), -1, ESlotType.E_COMP_NONE);
                    PLNetworkManager.Instance.MyLocalPawn.CurrentShip.MyStats.AddShipComponent(ExtractorPluginManager.CreateExtractor(ExtractorPluginManager.Instance.GetExtractorIDFromName("Dragon Extractor"), 0), -1, ESlotType.E_COMP_NONE);
                    PLNetworkManager.Instance.MyLocalPawn.CurrentShip.MyStats.AddShipComponent(MissilePluginManager.CreateMissile(MissilePluginManager.Instance.GetMissileIDFromName("Dragon Missile"), 0), -1, ESlotType.E_COMP_NONE);
                    PLNetworkManager.Instance.MyLocalPawn.CurrentShip.MyStats.AddShipComponent(NuclearDevicePluginManager.CreateNuclearDevice(NuclearDevicePluginManager.Instance.GetNuclearDeviceIDFromName("Dragon NuclearDevice"), 0), -1, ESlotType.E_COMP_NONE);
                    PLNetworkManager.Instance.MyLocalPawn.CurrentShip.MyStats.AddShipComponent(new CustomContentTests.Turret.DragonTurret(0, 0), -1, ESlotType.E_COMP_NONE);
                    PLNetworkManager.Instance.MyLocalPawn.CurrentShip.MyStats.AddShipComponent(new CustomContentTests.HullPlating.DragonHullPlating(0, 0), -1, ESlotType.E_COMP_NONE);
                    PLNetworkManager.Instance.MyLocalPawn.CurrentShip.MyStats.AddShipComponent(MissionShipComponentPluginManager.CreateMissionShipComponent(MissionShipComponentPluginManager.Instance.GetMissionShipComponentIDFromName("Dragon MissionShipComponent"), 0), -1, ESlotType.E_COMP_NONE);
                    PLNetworkManager.Instance.MyLocalPawn.CurrentShip.MyStats.AddShipComponent(new CustomContentTests.AutoTurret.DragonAutoTurret(0, 0), -1, ESlotType.E_COMP_NONE);
                    PLNetworkManager.Instance.MyLocalPawn.CurrentShip.MyStats.AddShipComponent(VirusPluginManager.CreateVirus(VirusPluginManager.Instance.GetVirusIDFromName("Dragon Virus"), 0), -1, ESlotType.E_COMP_CARGO);
                    break;
                case "addtoinv":
                    ContentMod.Items.ItemPluginManager.Instance.GetItemIDsFromName("Slime", out int Main, out int Sub);
                    PLNetworkManager.Instance.LocalPlayer.MyInventory.UpdateItem(PLServer.Instance.PawnInvItemIDCounter++, Main, Sub, 0, -1);
                    ContentMod.Items.ItemPluginManager.Instance.GetItemIDsFromName("Pizza", out Main, out Sub);
                    PLNetworkManager.Instance.LocalPlayer.MyInventory.UpdateItem(PLServer.Instance.PawnInvItemIDCounter++, Main, Sub, 0, -1);
                    break;
            }
        }
    }
}
