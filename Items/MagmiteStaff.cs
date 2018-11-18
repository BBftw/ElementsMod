using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementsMod.Items
{
    public class MagmiteStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magmite Staff");
            Tooltip.SetDefault("Casts a red hot lava rock");
        }
        public override void SetDefaults()
        {
            item.damage = 45;
            item.magic = true;                     //this make the item do magic damage
            item.width = 23;
            item.height = 23;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 5;
            item.value = 20000;
            item.rare = 4;
            item.mana = 12;             //mana use
            item.UseSound = SoundID.Item21;            //this is the sound when you use the item
            item.autoReuse = true;
            item.useTurn = true;
            item.shoot = mod.ProjectileType("LavaRock");  //this make the item shoot your projectile
            item.shootSpeed = 18;    //projectile speed when shoot
        }
            
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("MagmiteBar"), 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}