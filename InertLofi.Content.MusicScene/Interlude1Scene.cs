using CalamityMod;
using CalamityMod.Events;
using CalamityMod.NPCs.HiveMind;
using System;
using Terraria;
using Terraria.Audio;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class Interlude1Scene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/Interlude1");

    public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
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
        

        // QUARANTINE
        var calamity = cache as CalamityMod.CalamityMod;
        if (calamity != null)
        {
            calamity.GetMusicFromMusicMod("Interlude1");
        }
        else
        {
            Console.WriteLine("cache is not a CalamityMod instance.");
        }

        // Return true if the music that's currently playing is the Interlude song
        bool isInterlude1Playing = Main.curMusic == calamity.GetMusicFromMusicMod("Interlude1");
        Main.NewText("Is Interlude1 playing? " + isInterlude1Playing);
        Main.NewText("Interlude1 ID: " + calamity.GetMusicFromMusicMod("Interlude1"));
        Main.NewText("Currently playing ID: " + Main.curMusic);
        Main.NewText("Is the scene active? " + (isInterlude1Playing && !BossRushEvent.BossRushActive));
        if ((isInterlude1Playing && !BossRushEvent.BossRushActive))
        {
            Main.musicBox2 = Music;
            Main.curMusic = Music;
        }
        return isInterlude1Playing && !BossRushEvent.BossRushActive;
    }
}