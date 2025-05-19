using CalamityMod.Items.Placeables.Ores;
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
    public class TSBHMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<TSBHMusicBoxTile>();


        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.MusicBox).AddIngredient<InfernalSuevite>(5).AddTile(TileID.WorkBenches).Register();

        }
    }
}
