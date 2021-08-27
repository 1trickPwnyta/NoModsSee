using Verse;
using HarmonyLib;

namespace NoModsSee
{
    public class NoModsSeeMod : Mod
    {
        public const string PACKAGE_ID = "nomodssee.1trickPonyta";
        public const string PACKAGE_NAME = "No Mods! See?";

        public NoModsSeeMod(ModContentPack content) : base(content)
        {
            var harmony = new Harmony(PACKAGE_ID);
            harmony.PatchAll();

            Log.Message($"[{PACKAGE_NAME}] Loaded.");
        }
    }
}
