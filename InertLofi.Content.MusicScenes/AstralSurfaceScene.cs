using CalamityMod.BiomeManagers;
using CalamityMod.Events;
using CalamityMod.NPCs.AstrumAureus;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class AstralSurfaceScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/AstralSurface");

    public override SceneEffectPriority Priority => (SceneEffectPriority)8;

    public override bool IsSceneEffectActive(Player player)
    {
        return player.InModBiome<AstralInfectionBiome>();
    }
}
