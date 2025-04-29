using CalamityMod.Events;
using CalamityMod.NPCs.DevourerofGods;
using CalamityMod.NPCs.SupremeCalamitas;
using CalamityMod.NPCs.Yharon;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class CalamitasPhase4Scene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/CalamitasDefeat");

    public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
    public override float GetWeight(Player player)
    {
        return 1f;
    }

    public override bool IsSceneEffectActive(Player player)
    {
        bool active = false;
        ModNPC Cal = default(ModNPC);
        ModLoader.GetMod("CalamityMod").TryFind<ModNPC>("SupremeCalamitas", out Cal);
        for (int i = 0; i < Main.npc.Length; i++)
        {
            NPC npc = Main.npc[i];
            if (!((Entity)npc).active)
            {
                continue;
            }
            if (npc.type == Cal.Type)
            {
                if (npc.GetLifePercent() <= 0.01f)
                {
                    active = true;
                }
            }
        }
        return NPC.AnyNPCs(ModContent.NPCType<SupremeCalamitas>()) && active && !BossRushEvent.BossRushActive;
    }
}
