using Spectrum.API.Interfaces.Plugins;
using Spectrum.API.Interfaces.Systems;

namespace Distance_Spooktober_2018
{
    public class Spook : IPlugin
    {
        public string[] SectorNames = {
            "Sector 17: Creepy Center",
            "Sector 17: Creepy Center",
            "Sector 16: Blood Reserve",
            "Sector 15: Frightenment",
            "Sector 14: Spooking Center",
            "Sector 13: Evil District",
            "Sector 11: Horror Center",
            "Sector 09: Hazardous Cauldron",
            "Sector 06: Graveyard",
            "Sector 05: Pumpkin Testing",
            "Sector 04: The Coffin",
            "Sector 03: Phantom",
            "Sector 02: Bones Repair",
            "Sector 01c: Administraspook",
            "Sector 01b: Nightmare Core",
            "Sector 01a: Corpse Teleportation",
            "Sector ???: Monument Park"
        };


        public void Initialize(IManager manager, string ipcIdentifier)
        {
            Events.Scene.LoadFinish.Subscribe((data) =>
            {
                UnityEngine.Object.FindObjectOfType<BlackFadeLogic>().sectorNames_ = SectorNames;
            });

            Events.Scene.StartLoad.Subscribe((data) =>
            {
                UnityEngine.Object.FindObjectOfType<BlackFadeLogic>().sectorNames_ = SectorNames;
            });
        }
    }
}
