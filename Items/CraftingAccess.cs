using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MagicStorage.Items
{
    public class CraftingAccess : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Storage Crafting Interface");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Модуль Создания Предметов");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Interfejs Rzemieślniczy Magazynu");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), "Interface de Stockage Artisanat");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Interfaz de Elaboración de almacenamiento");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "制作存储单元");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 26;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.rare = 1;
            item.value = Item.sellPrice(0, 1, 16, 25);
            item.createTile = Mod.TileType("CraftingAccess");
        }

        public override void AddRecipes()
        {
			Recipe recipe = CreateRecipe();
			recipe.createItem = this.item.Clone();
			recipe.createItem.stack = 1;
			
            recipe.AddIngredient(null, "StorageComponent");
            recipe.AddRecipeGroup("MagicStorage:AnyDiamond", 3);
            if (MagicStorage.legendMod == null)
            {
                recipe.AddIngredient(ItemID.Sapphire, 7);
            }
            else
            {
                recipe.AddRecipeGroup("MagicStorage:AnySapphire", 7);
            }
            recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
    }
}
