using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ElementsMod.Items
{
    public class MagmiteBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magmite Bar");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.autoReuse = true;
            item.maxStack = 99;
            item.useStyle = 1;
            item.useTime = 10;
            item.useAnimation = 10;
            item.value = 5000;
            item.rare = 4;
            item.useTurn = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("MagmiteOreItem"), 4);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
