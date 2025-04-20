using CalamityMod.Events;
using CalamityMod.NPCs.DevourerofGods;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class DoG2Scene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/DoG2");

    public override SceneEffectPriority Priority => (SceneEffectPriority)8;

    public override bool IsSceneEffectActive(Player player)
    {
        int wantedId = ModContent.NPCType<DevourerofGodsHead>();
        bool inPhase2 = false;
        for (int i = 0; i < 200; i++)
        {
            if (Main.npc[i].active && Main.npc[i].type == wantedId)
            {
                //if ((DevourerofGodsHead)Main.npc[i].Phase2Started)
                //{
                //    inPhase2 = true;
                //}
            }
        }
        return inPhase2 && !BossRushEvent.BossRushActive;
    }
}
