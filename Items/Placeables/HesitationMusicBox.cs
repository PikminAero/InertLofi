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
    public class HesitationMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<HesitationMusicBoxTile>();


        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.MusicBox).AddIngredient<SulphurousShale>(5).AddTile(TileID.WorkBenches).Register();

        }
    }
}
