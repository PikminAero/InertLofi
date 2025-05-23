﻿using CalamityMod.Events;
using CalamityMod.NPCs.CalClone;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class CalCloneScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/CalamitasClone");

    public override SceneEffectPriority Priority => (SceneEffectPriority)8;

    public override bool IsSceneEffectActive(Player player)
    {
        return NPC.AnyNPCs(ModContent.NPCType<CalamitasClone>()) && !BossRushEvent.BossRushActive
            && ModContent.GetInstance<InertLofiConfig>().ReplaceCalClone
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
    }
}
