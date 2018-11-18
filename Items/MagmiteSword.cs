using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementsMod.Items
{
	public class MagmiteSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Magmite Claymore");
            Tooltip.SetDefault("Spicy");
		}
		public override void SetDefaults()
		{
			item.damage = 45;
			item.melee = true;

			item.width = 73;
			item.height = 73;

			item.useTime = 20;
			item.useAnimation = 20;

			item.useStyle = 1;
			item.knockBack = 8;
            item.crit = 4;
			item.value = 20000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;

            item.useTurn = true;
			item.autoReuse = true;

            item.shoot = ProjectileID.HellfireArrow;
            item.shootSpeed = 10;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("MagmiteBar"), 12);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
