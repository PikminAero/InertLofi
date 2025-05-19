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
    public class SerenityMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<SerenityMusicBoxTile>();


        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.MusicBox).AddIngredient(ItemID.ReleaseLantern).AddTile(TileID.WorkBenches).Register();

        }
    }
}
