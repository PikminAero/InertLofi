using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace InertLofi.Items.Placeables
{
    // Abstract class taken straight from CalamityMusicMod.
    // Will greatly help for all the music boxes.
    public abstract class MusicBox : ModItem
    {
        public abstract int MusicBoxTile { get; }
        public virtual bool Obtainable { get; } = true;

        public override void SetStaticDefaults()
        {
            ItemID.Sets.CanGetPrefixes[Type] = false;
            ItemID.Sets.ShimmerTransformToItem[Type] = ItemID.MusicBox;

            if (!Obtainable)
            {
                Item.ResearchUnlockCount = 0;
            }
        }

        public override void SetDefaults()
        {
            Item.DefaultToMusicBox(MusicBoxTile, 0);
        }
    }
}
