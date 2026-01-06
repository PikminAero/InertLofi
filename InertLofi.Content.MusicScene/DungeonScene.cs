using CalamityMod.BiomeManagers;
using CalamityMod.BiomeManagers.BestiaryCategories;
using CalamityMod.Events;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class DungeonScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(InertLofiMod.Instance, "Assets/Music/Dungeon");

    public override SceneEffectPriority Priority => SceneEffectPriority.Environment;

    public override bool IsSceneEffectActive(Player player)
    {
        return player.ZoneDungeon && !BossRushEvent.BossRushActive
            && ModContent.GetInstance<InertLofiConfig>().ReplaceDungeon
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
    }
}
