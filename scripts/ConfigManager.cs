using BepInEx.Configuration;

namespace StructureThermodynamicsOverhaulMod.scripts
{
    public static class ConfigManager
    {
        public static ConfigEntry<float> Entry_ThermalRateMultiplier;
        public static ConfigEntry<bool> Entry_DebugLogInChat;
        public static ConfigEntry<bool> Entry_DebugHomeKey;

        public static void Bind(ConfigFile config)
        {
            Entry_ThermalRateMultiplier = config.Bind(
                "General",
                "thermalRateMultiplier",
                1.0f,
                "Sets the rate of heat transfer through solid blocks. Lower numbers reduce thermal effects from environmet, making the game easier. 0 = disables thermal effects; 1.0 = default; 10.0 = realistic (this would make the game too difficult)");

            Entry_DebugLogInChat = config.Bind(
                "Debug",
                "debugLogInConsole",
                false,
                "Set to true to enable the debug messages in the F3/console window. Warning enabaling this will spam you every thermal update tick (2 fps)");

            Entry_DebugHomeKey = config.Bind(
                "Debug",
                "debugForceUpdate",
                true,
                "If set to true, will enable force structure recalculation (which only happens when you build blocks) when you press the \"Home\" key. Output log will be printed to your console window (F3)");
        }
    }
}
