using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MagicStorage.Items
{
    public class StorageUnitDemonite : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Demonite Storage Unit");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Демонитовая Ячейка Хранилища");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Jednostka magazynująca (Demonit)");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), "Unité de stockage (Démonite)");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Unidad de Almacenamiento (Endemoniado)");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "存储单元(魔金)");
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
            item.value = Item.sellPrice(0, 0, 32, 0);
            item.createTile = Mod.TileType("StorageUnit");
            item.placeStyle = 1;
        }

        public override void AddRecipes()
        {
			Recipe recipe = CreateRecipe();
			recipe.createItem = this.item.Clone();
			recipe.createItem.stack = 1;
			recipe.AddIngredient(Mod.ItemType("StorageUnit"));
            recipe.AddIngredient(Mod.ItemType("UpgradeDemonite"));
			recipe.Register();
        }
    }
}
