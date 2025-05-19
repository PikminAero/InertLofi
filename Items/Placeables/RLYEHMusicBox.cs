using CalamityMod.Items.Placeables;
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
    public class RLYEHMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<RLYEHMusicBoxTile>();


        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.MusicBox).AddIngredient<PyreMantle>(1).AddTile(TileID.WorkBenches).Register();

        }
    }
}
