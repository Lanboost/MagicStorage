using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MagicStorage.Items
{
    public class StorageUnitBlueChlorophyte : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blue Chlorophyte Storage Unit");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Синяя Хлорофитовая Ячейка Хранилища");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Jednostka magazynująca (Niebieski Chlorofit)");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), "Unité de stockage (Chlorophylle Bleu)");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Unidad de Almacenamiento (Clorofita Azul)");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "存储单元(蓝色叶绿)");
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
            item.rare = 7;
            item.value = Item.sellPrice(0, 1, 60, 0);
            item.createTile = Mod.TileType("StorageUnit");
            item.placeStyle = 5;
        }

        public override void AddRecipes()
        {
			Recipe recipe = CreateRecipe();
			recipe.createItem = this.item.Clone();
			recipe.createItem.stack = 1;
			recipe.AddIngredient(Mod.ItemType("StorageUnitHallowed"));
            recipe.AddIngredient(Mod.ItemType("UpgradeBlueChlorophyte"));
			recipe.Register();
        }
    }
}
