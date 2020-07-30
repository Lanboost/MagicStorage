using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MagicStorage.Items
{
    public class UpgradeDemonite : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Demonite Storage Upgrade");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Демонитовое Улучшение Ячейки Хранилища");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Ulepszenie jednostki magazynującej (Demonit)");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), "Amélioration d'Unité de stockage (Démonite)");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Actualización de Unidad de Almacenamiento (Endemoniado)");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "存储升级珠(魔金)");

            Tooltip.SetDefault("Upgrades Storage Unit to 80 capacity"
                + "\n<right> a Storage Unit to use");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Увеличивает количество слотов в Ячейке Хранилища до 80"
                + "\n<right> на Ячейке Хранилища для улучшения");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Ulepsza jednostkę magazynującą do 80 miejsc"
                + "\n<right> na Jednostkę magazynującą (Standardową), aby użyć");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), "améliore la capacité de unité de stockage à 80"
                + "\n<right> l'unité de stockage pour utiliser");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Capacidad de unidad de almacenamiento mejorada a 80"
                + "\n<right> en la unidad de almacenamiento para utilizar");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "将存储单元升级至80容量"
                + "\n<right>一个存储单元(魔金)可镶嵌");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.maxStack = 99;
            item.rare = 1;
            item.value = Item.sellPrice(0, 0, 32, 0);
        }

        public override void AddRecipes()
        {
			Recipe recipe = CreateRecipe();
			recipe.createItem = this.item.Clone();
			recipe.createItem.stack = 1;
			recipe.AddIngredient(ItemID.DemoniteBar, 10);
            if (MagicStorage.legendMod == null)
            {
                recipe.AddIngredient(ItemID.Amethyst);
            }
            else
            {
                recipe.AddRecipeGroup("MagicStorage:AnyAmethyst");
            }
            recipe.AddTile(TileID.Anvils);
			recipe.Register();
        }
    }
}
