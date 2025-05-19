using CalamityMod.Items.Accessories;
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
    public class SWMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<SWMusicBoxTile>();


        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.MusicBox).AddIngredient<LeviathanAmbergris>(1).AddTile(TileID.WorkBenches).Register();

        }
    }
}
