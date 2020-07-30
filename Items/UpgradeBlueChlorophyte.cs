using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MagicStorage.Items
{
    public class UpgradeBlueChlorophyte : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blue Chlorophyte Storage Upgrade");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Синее Хлорофитовое Улучшение Ячейки");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Ulepszenie jednostki magazynującej (Niebieski Chlorofit)");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), "Amélioration d'Unité de stockage (Chlorophylle Bleu)");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Actualización de Unidad de Almacenamiento (Clorofita Azul)");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "存储升级珠(蓝色叶绿)");

            Tooltip.SetDefault("Upgrades Storage Unit to 240 capacity"
                + "\n<right> a Hallowed Storage Unit to use");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Увеличивает количество слотов в Ячейке Хранилища до 240"
                + "\n<right> на Святой Ячейке Хранилища для улучшения");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Ulepsza jednostkę magazynującą do 240 miejsc"
                + "\n<right> na Jednostkę magazynującą (Święconą), aby użyć");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), "améliore la capacité de unité de stockage à 240"
                + "\n<right> l'unité de stockage (Sacré) pour utiliser");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Capacidad de unidad de almacenamiento mejorada a 240"
                + "\n<right> en la unidad de almacenamiento (Sagrado) para utilizar");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "将存储单元升级至240容量"
                + "\n<right>一个存储单元(神圣)可镶嵌");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.maxStack = 99;
            item.rare = 7;
            item.value = Item.sellPrice(0, 1, 0, 0);
        }

        public override void AddRecipes()
        {
			Recipe recipe = CreateRecipe();
			recipe.createItem = this.item.Clone();
			recipe.createItem.stack = 1;
			recipe.AddIngredient(ItemID.ShroomiteBar, 5);
            recipe.AddIngredient(ItemID.SpectreBar, 5);
            recipe.AddIngredient(ItemID.BeetleHusk, 2);
            if (MagicStorage.legendMod == null)
            {
                recipe.AddIngredient(ItemID.Emerald);
            }
            else
            {
                recipe.AddRecipeGroup("MagicStorage:AnyEmerald");
            }
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
        }
    }
}
