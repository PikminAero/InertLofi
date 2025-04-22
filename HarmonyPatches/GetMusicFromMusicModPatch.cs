using Terraria.ModLoader;
using HarmonyLib;
using InertLofi;

[HarmonyPatch(typeof(CalamityMod.CalamityMod), "GetMusicFromMusicMod")]
public static class GetMusicFromMusicModPatch
{

    static bool Prefix(ref int? __result, string musicName)
    {
        __result = MusicLoader.GetMusicSlot(InertLofiMod.Instance, "Assets/Music/"+musicName);
        // If the song does not exist (eg. Inert hasn't made a cover of it),
        // fallback to the default OST
        if (__result == 0)
        {
            return true;
        }
        // Otherwise, replace
        return false;
    }
}