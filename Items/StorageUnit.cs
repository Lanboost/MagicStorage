using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MagicStorage.Items
{
    public class StorageUnit : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Ячейка Хранилища");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Jednostka magazynująca");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), "Unité de stockage");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Unidad de Almacenamiento");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "存储单元");
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
            item.rare = 0;
            item.value = Item.sellPrice(0, 0, 6, 0);
            item.createTile = Mod.TileType("StorageUnit");
        }

        public override void AddRecipes()
        {
			Recipe recipe = CreateRecipe();
			recipe.createItem = this.item.Clone();
			recipe.createItem.stack = 1;
			recipe.AddIngredient(Mod.ItemType("StorageComponent"));
            recipe.AddRecipeGroup("MagicStorage:AnyChest");
            recipe.AddIngredient(ItemID.SilverBar, 10);
            recipe.AddTile(TileID.WorkBenches);
			recipe.Register();

			recipe = CreateRecipe();
			recipe.createItem = this.item.Clone();
			recipe.createItem.stack = 1;
			recipe.AddIngredient(Mod.ItemType("StorageComponent"));
            recipe.AddRecipeGroup("MagicStorage:AnyChest");
            recipe.AddIngredient(ItemID.TungstenBar, 10);
            recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
        }
    }
}
