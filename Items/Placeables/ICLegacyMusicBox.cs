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
    public class ICLegacyMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<ICLegacyMusicBoxTile>();

        /* Since this song isn't covered, it would be pointless for its music box to be obtainable.
        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.MusicBox).AddTile(TileID.WorkBenches).Register();

        }
        */
    }
}
