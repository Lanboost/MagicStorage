using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MagicStorage.Items
{
    public class StorageAccess : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Модуль Доступа к Хранилищу");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Okno dostępu do magazynu");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), "Access de Stockage");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Acceso de Almacenamiento");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "存储装置");
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
            item.value = Item.sellPrice(0, 0, 67, 50);
            item.createTile = Mod.TileType("StorageAccess");
        }

        public override void AddRecipes()
        {
			Recipe recipe = CreateRecipe();
			recipe.createItem = this.item.Clone();
			recipe.createItem.stack = 1;
			recipe.AddIngredient(null, "StorageComponent");
            recipe.AddRecipeGroup("MagicStorage:AnyDiamond", 1);
            if (MagicStorage.legendMod == null)
            {
                recipe.AddIngredient(ItemID.Topaz, 7);
            }
            else
            {
                recipe.AddRecipeGroup("MagicStorage:AnyTopaz", 7);
            }
            recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
        }
    }
}
