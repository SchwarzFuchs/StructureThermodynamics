using Assets.Scripts;
using BepInEx;
using HarmonyLib;
using StationeersMods.Interface;


namespace StructureThermodynamicsOverhaulMod.scripts
{
    [StationeersMod("StructureThermodynamicsOverhaul", "Structure Thermodynamics", "0.2.6428.27798.8")]
    class StructureThermodynamicsOverhaulMod : ModBehaviour
    {
        public override void OnLoaded(ContentHandler contentHandler)
        {
            Harmony harmony = new Harmony("StructureThermodynamicsOverhaul");
            harmony.PatchAll();
            ConfigManager.Bind(Config);
        }

    }
}