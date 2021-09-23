using HarmonyLib;
using NeosModLoader;
using FrooxEngine.LogiX;

namespace ShowHiddenNodes
{
    public class ShowHiddenNodes : NeosMod
    {
        public override string Name => "ShowHiddenNodes";
        public override string Author => "eia485";
        public override string Version => "1.0.0";
        public override string Link => "https://github.com/EIA485/NeosShowHiddenNodes/";
        public override void OnEngineInit()
        {
            Harmony harmony = new Harmony("net.eia485.ShowHiddenNodes");
            harmony.PatchAll();
        }
        [HarmonyPatch(typeof(LogixHelper), "IsHidden")]
        class ShowHiddenNodesPatch
        {
            static bool Prefix(ref bool __result)
            {
                __result = false;
                    return false;
            }
        }
    }
}