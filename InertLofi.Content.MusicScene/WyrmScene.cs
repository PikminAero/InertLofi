﻿using CalamityMod.Events;
using CalamityMod.NPCs.Abyss;
using CalamityMod.NPCs.PrimordialWyrm;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class WyrmScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/PrimordialWyrm");

    public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;

    public override bool IsSceneEffectActive(Player player)
    {
        return NPC.AnyNPCs(ModContent.NPCType<EidolonWyrmHead>()) 
            || NPC.AnyNPCs(ModContent.NPCType<ColossalSquid>())
            || NPC.AnyNPCs(ModContent.NPCType<ReaperShark>())
            || NPC.AnyNPCs(ModContent.NPCType<PrimordialWyrmHead>())
            && !BossRushEvent.BossRushActive
            && ModContent.GetInstance<InertLofiConfig>().ReplaceWyrm
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
    }
}
