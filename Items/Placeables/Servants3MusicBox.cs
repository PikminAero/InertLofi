﻿using CalamityMod.Items.Materials;
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
    public class Servants3MusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Servants3MusicBoxTile>();


        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.MusicBox).AddIngredient<TwistingNether>(1).AddTile(TileID.WorkBenches).Register();

        }
    }
}
