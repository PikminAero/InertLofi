using CalamityMod.Events;
using CalamityMod.NPCs.DevourerofGods;
using CalamityMod.NPCs.Yharon;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class Yharon1Scene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/YharonPhase1");

    public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
    public override float GetWeight(Player player)
    {
        return 1f;
    }

    public override bool IsSceneEffectActive(Player player)
    {
        bool inPhase1 = false;
        ModNPC Yharon = default(ModNPC);
        ModLoader.GetMod("CalamityMod").TryFind<ModNPC>("Yharon", out Yharon);
        for (int i = 0; i < Main.npc.Length; i++)
        {
            NPC npc = Main.npc[i];
            if (!((Entity)npc).active)
            {
                continue;
            }
            if (npc.type == Yharon.Type)
            {
                if (npc.GetLifePercent() > 0.55f)
                {
                    inPhase1 = true;
                }
            }
        }
        return NPC.AnyNPCs(ModContent.NPCType<Yharon>()) && inPhase1 && !BossRushEvent.BossRushActive;
    }
}
