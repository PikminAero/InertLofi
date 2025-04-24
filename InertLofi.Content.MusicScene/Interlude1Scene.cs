using CalamityMod.Events;
using CalamityMod.NPCs.HiveMind;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class Interlude1Scene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/Interlude1");

    public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;
    public override float GetWeight(Player player)
    {
        return 1f;
    }
    public override bool IsSceneEffectActive(Player player)
    {
        Mod cache = new Mod();
        // If we can't find CalamityMod, then the scene cannot take place and this method returns false
        if (!ModLoader.TryGetMod("CalamityMod", out cache))
        {
            return false;
        }
        // Return true if the music that's currently playing is the Interlude song
        bool isInterlude1Playing = Main.curMusic == MusicLoader.GetMusicSlot(cache, "Sounds/Music/Interlude1");
        /*
        Main.NewText("Is Interlude1 playing? " + isInterlude1Playing);
        Main.NewText("Interlude1 ID: " + MusicLoader.GetMusicSlot(cache, "Sounds/Music/Interlude1"));
        Main.NewText("Currently playing ID: " + Main.curMusic);
        */
        //return isInterlude1Playing && !BossRushEvent.BossRushActive;
        return false;
    }
}