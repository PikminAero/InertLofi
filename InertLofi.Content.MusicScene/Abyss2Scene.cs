﻿using CalamityMod.BiomeManagers;
using CalamityMod.BiomeManagers.BestiaryCategories;
using CalamityMod.Events;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class Abyss2Scene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/AbyssLayer2");

    public override SceneEffectPriority Priority => SceneEffectPriority.Event;

    public override bool IsSceneEffectActive(Player player)
    {
        return player.InModBiome<AbyssLayer2Biome>() && !BossRushEvent.BossRushActive
            && ModContent.GetInstance<InertLofiConfig>().ReplaceAbyss2
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
    }
}
