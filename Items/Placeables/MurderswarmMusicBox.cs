using CalamityMod.Items.Materials;
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
    public class MurderswarmMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<MurderswarmMusicBoxTile>();


        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.MusicBox).AddIngredient<EffulgentFeather>(5).AddTile(TileID.WorkBenches).Register();

        }
    }
}
