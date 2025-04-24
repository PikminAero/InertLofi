using CalamityMod.Events;
using CalamityMod.NPCs.DesertScourge;
using CalamityMod.NPCs.DevourerofGods;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class DoG1PhaseScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/DevourerofGodsPhase1");

    public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;

    public override float GetWeight(Player player)
    {
        return 1f;
    }
     public override bool IsSceneEffectActive(Player player)
    {
        //int wantedId = ModContent.NPCType<DevourerofGodsHead>();
        bool inPhase2 = false;
        ModNPC npc = default(ModNPC);
        ModLoader.GetMod("CalamityMod").TryFind<ModNPC>("DevourerofGodsHead", out npc);
        DevourerofGodsHead DoG = (DevourerofGodsHead)npc;
        if (DoG != null)
        {
            inPhase2 = DoG.Phase2Started;
        }
        return NPC.AnyNPCs(ModContent.NPCType<DevourerofGodsHead>()) && !inPhase2 && !BossRushEvent.BossRushActive;
    }
}
