using InertLofi.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace InertLofi.Items.Placeables
{
    public class CrabulonMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<CrabulonMusicBoxTile>();


        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.MusicBox).AddIngredient(ItemID.GlowingMushroom, 20)
                .AddIngredient(ItemID.MushroomGrassSeeds, 3).AddTile(TileID.WorkBenches).Register();

        }
    }
}
