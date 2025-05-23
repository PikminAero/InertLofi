﻿using CalamityMod.Events;
using CalamityMod.NPCs.CeaselessVoid;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class CeaselessVoidScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/CeaselessVoid");

    public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;

    public override bool IsSceneEffectActive(Player player)
    {
        return NPC.AnyNPCs(ModContent.NPCType<CeaselessVoid>()) && !BossRushEvent.BossRushActive
            && ModContent.GetInstance<InertLofiConfig>().ReplaceCeaselessVoid
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
    }
}
