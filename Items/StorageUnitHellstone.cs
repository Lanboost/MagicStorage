using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MagicStorage.Items
{
    public class StorageUnitHellstone : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hellstone Storage Unit");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Адская Ячейка Хранилища");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Jednostka magazynująca (Piekielny kamień)");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), "Unité de stockage (Infernale)");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Unidad de Almacenamiento (Piedra Infernal)");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "存储单元(狱岩)");
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
            item.rare = 2;
            item.value = Item.sellPrice(0, 0, 50, 0);
            item.createTile = Mod.TileType("StorageUnit");
            item.placeStyle = 3;
        }

        public override void AddRecipes()
        {
			Recipe recipe = CreateRecipe();
			recipe.createItem = this.item.Clone();
			recipe.createItem.stack = 1;
			recipe.AddIngredient(Mod.ItemType("StorageUnitDemonite"));
            recipe.AddIngredient(Mod.ItemType("UpgradeHellstone"));
			recipe.Register();

			recipe = CreateRecipe();
			recipe.createItem = this.item.Clone();
			recipe.createItem.stack = 1;
			recipe.AddIngredient(Mod.ItemType("StorageUnitCrimtane"));
            recipe.AddIngredient(Mod.ItemType("UpgradeHellstone"));
			recipe.Register();
        }
    }
}
