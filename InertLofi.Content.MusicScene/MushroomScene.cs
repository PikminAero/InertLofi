using CalamityMod.BiomeManagers;
using CalamityMod.BiomeManagers.BestiaryCategories;
using CalamityMod.Events;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class MushroomScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(InertLofiMod.Instance, "Assets/Music/Mushroom");

    public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;

    public override bool IsSceneEffectActive(Player player)
    {
        return player.ZoneGlowshroom && !BossRushEvent.BossRushActive
            && ModContent.GetInstance<InertLofiConfig>().ReplaceMushroom
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
    }
}
