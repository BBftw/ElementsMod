using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ElementsMod.Items
{
    public class MagmiteOreItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magmite Ore");
            Tooltip.SetDefault("It's letting off steam...");
        }

        public override void SetDefaults()
        {
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;
            item.consumable = true;
            item.useStyle = 1;
            item.useTime = 10;
            item.useAnimation = 10;
            item.createTile = mod.TileType("MagmiteOre");
            item.autoReuse = true;
            item.rare = 4;
        }
    }
}