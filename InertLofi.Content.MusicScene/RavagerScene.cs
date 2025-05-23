﻿using CalamityMod.Events;
using CalamityMod.NPCs.PlaguebringerGoliath;
using CalamityMod.NPCs.Ravager;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class RavagerScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/Ravager");

    public override SceneEffectPriority Priority => (SceneEffectPriority)8;

    public override bool IsSceneEffectActive(Player player)
    {
        return NPC.AnyNPCs(ModContent.NPCType<RavagerBody>()) && !BossRushEvent.BossRushActive
            && ModContent.GetInstance<InertLofiConfig>().ReplaceRavager
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
    }
}
