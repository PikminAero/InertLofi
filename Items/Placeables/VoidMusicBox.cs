﻿using CalamityMod.Items.Placeables;
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
    public class VoidMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<VoidMusicBoxTile>();


        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.MusicBox).AddIngredient<Voidstone>(5).AddTile(TileID.WorkBenches).Register();

        }
    }
}
