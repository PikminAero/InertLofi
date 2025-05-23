﻿using CalamityMod.Events;
using CalamityMod.NPCs.HiveMind;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class HiveMindScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/HiveMind");

    public override SceneEffectPriority Priority => (SceneEffectPriority)8;

    public override bool IsSceneEffectActive(Player player)
    {
        return NPC.AnyNPCs(ModContent.NPCType<HiveMind>()) && !BossRushEvent.BossRushActive
            && ModContent.GetInstance<InertLofiConfig>().ReplaceHiveMind
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
    }
}
