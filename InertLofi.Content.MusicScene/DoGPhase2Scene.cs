using CalamityMod.Events;
using CalamityMod.NPCs.DevourerofGods;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class DoG2Scene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/DevourerofGodsPhase2");

    public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
    public override float GetWeight(Player player)
    {
        return 1f;
    }

    public override bool IsSceneEffectActive(Player player)
    {
        bool inPhase2 = false;
        ModNPC DoG = default(ModNPC);
        ModLoader.GetMod("CalamityMod").TryFind<ModNPC>("DevourerofGodsHead", out DoG);
        for (int i = 0; i < Main.npc.Length; i++)
        {
            NPC npc = Main.npc[i];
            if (!((Entity)npc).active)
            {
                continue;
            }
            if (npc.type == DoG.Type)
            {
                if (npc.GetLifePercent() <= 0.6f && npc.localAI[2] <= 400f)
                {
                    inPhase2 = true;
                }
            }
        }
        return NPC.AnyNPCs(ModContent.NPCType<DevourerofGodsHead>()) && inPhase2 && !BossRushEvent.BossRushActive;
    }
}
