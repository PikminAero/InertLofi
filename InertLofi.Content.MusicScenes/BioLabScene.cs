using System;
using CalamityMod.Systems;
using CalamityMod.Walls;
using CalamityMod.Walls.DraedonStructures;
using CalamityMod.World;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi.Content.MusicScenes;

public class BioLabScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/BioLab");

    public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;

    public override bool IsSceneEffectActive(Player player)
    {
        Tile tileSafely = Framing.GetTileSafely((int)(player.Center.X / 16f), (int)(player.Center.Y / 16f));
        Vector2 center = player.Center;
        float num = Vector2.DistanceSquared(CalamityWorld.SunkenSeaLabCenter, center);
        float num2 = Vector2.DistanceSquared(CalamityWorld.PlanetoidLabCenter, center);
        float num3 = Vector2.DistanceSquared(CalamityWorld.JungleLabCenter, center);
        float num4 = Vector2.DistanceSquared(CalamityWorld.HellLabCenter, center);
        float num5 = Vector2.DistanceSquared(CalamityWorld.IceLabCenter, center);
        float num6 = Vector2.DistanceSquared(CalamityWorld.CavernLabCenter, center);
        double num7 = Math.Pow(1280.0, 2.0);
        bool flag = tileSafely.WallType == 20 || tileSafely.WallType == 21 || tileSafely.WallType == 40 || tileSafely.WallType == 71 || tileSafely.WallType == 136 || tileSafely.WallType == 137 || tileSafely.WallType == 231 || tileSafely.WallType == ModContent.WallType<AstralIceWall>() || tileSafely.WallType == ModContent.WallType<AstralSnowWall>() || tileSafely.WallType == ModContent.WallType<HavocplateWall>() || tileSafely.WallType == ModContent.WallType<CinderplateWall>() || tileSafely.WallType == ModContent.WallType<ElumplateWall>() || tileSafely.WallType == ModContent.WallType<HazardChevronWall>() || tileSafely.WallType == ModContent.WallType<LaboratoryPanelWall>() || tileSafely.WallType == ModContent.WallType<LaboratoryPlateBeam>() || tileSafely.WallType == ModContent.WallType<LaboratoryPlatePillar>() || tileSafely.WallType == ModContent.WallType<LaboratoryPlatingWall>() || tileSafely.WallType == ModContent.WallType<NavyplateWall>() || tileSafely.WallType == ModContent.WallType<PlagueContainmentCellsWall>() || tileSafely.WallType == ModContent.WallType<PlaguedPlateWall>() || tileSafely.WallType == ModContent.WallType<RustedPlatePillar>() || tileSafely.WallType == ModContent.WallType<RustedPlatingWall>();
        bool flag2 = (double)num <= num7 || (double)num2 <= num7 || (double)num3 <= num7 || (double)num4 <= num7 || (double)num5 <= num7 || (double)num6 <= num7;
        return BiomeTileCounterSystem.ArsenalLabTiles > 150 && flag && flag2;
    }
}
