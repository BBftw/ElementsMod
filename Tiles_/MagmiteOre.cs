using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace ElementsMod.Tiles_
{
    public class MagmiteOre : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileLighted[Type] = true;

            drop = mod.ItemType("MagmiteOreItem");

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Magmite Ore");
            AddMapEntry(new Color(255, 60, 41), name);

            minPick = 100;
        }
    }
}
