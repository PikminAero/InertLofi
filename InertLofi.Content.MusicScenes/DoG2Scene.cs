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
        ModNPC npc = default(ModNPC);
        ModLoader.GetMod("CalamityMod").TryFind<ModNPC>("DevourerofGodsHead", out npc);
        DevourerofGodsHead DoG = (DevourerofGodsHead)npc;
        if (DoG != null)
        {
            inPhase2 = DoG.Phase2Started;
        }
        return inPhase2 && !BossRushEvent.BossRushActive;
    }
}
