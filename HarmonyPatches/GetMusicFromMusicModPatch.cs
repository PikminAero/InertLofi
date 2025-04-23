using Terraria.ModLoader;
using HarmonyLib;
using CalamityMod;
using InertLofi;

[HarmonyPatch(typeof(CalamityMod.CalamityMod), "GetMusicFromMusicMod")]
public static class GetMusicFromMusicModPatch
{
    static bool Prefix(CalamityMod.CalamityMod __instance, ref int? __result, string songFilename)
    {
        
        int customSlot = MusicLoader.GetMusicSlot(InertLofiMod.Instance, "Assets/Music/" + songFilename);

        if (customSlot == 0)
        {
            // Fall back to Calamity's default behavior
            return true;
        }

        __result = customSlot;
        return false; // Skip original method
    }
}
