using CalamityMod.Events;
using CalamityMod.NPCs.Yharon;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class Yharon2Scene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/Yharon2");

    public override SceneEffectPriority Priority => (SceneEffectPriority)8;

    public override bool IsSceneEffectActive(Player player)
    {
        int wantedId = ModContent.NPCType<Yharon>();
        bool inPhase2 = false;
        for (int i = 0; i < 200; i++)
        {
            if (Main.npc[i].active && Main.npc[i].type == wantedId)
            {
                if ((double)Main.npc[i].GetLifePercent() <= 0.55)
                {
                    inPhase2 = true;
                }
            }
        }
        return inPhase2 && !BossRushEvent.BossRushActive;
    }
}
