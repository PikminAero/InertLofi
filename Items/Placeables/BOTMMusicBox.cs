﻿using InertLofi.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace InertLofi.Items.Placeables
{
    public class BOTMMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<BOTMMusicBoxTile>();


        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.MusicBox).AddIngredient(ItemID.Star, 5).AddTile(TileID.WorkBenches).Register();

        }
    }
}
