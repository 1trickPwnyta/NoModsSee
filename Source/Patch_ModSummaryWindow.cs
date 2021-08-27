using HarmonyLib;
using Verse;

namespace NoModsSee
{
    [HarmonyPatch(typeof(ModSummaryWindow))]
    [HarmonyPatch("get_AnyMods")]
    public static class Patch_ModSummaryWindow_get_AnyMods
    {
        public static void Postfix(ref bool __result) 
        {
            __result = false;
        }
    }
}
