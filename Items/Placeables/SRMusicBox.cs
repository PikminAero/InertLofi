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
    public class SRMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<SRMusicBoxTile>();

        /* Unused
        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.MusicBox).AddTile(TileID.WorkBenches).Register();

        }
        */
    }
}
