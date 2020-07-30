using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MagicStorage.Items
{
    public class UpgradeHallowed : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hallowed Storage Upgrade");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Святое Улучшение Ячейки Хранилища");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Ulepszenie jednostki magazynującej (Święcone)");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), "Amélioration d'Unité de stockage (Sacré)");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Actualización de Unidad de Almacenamiento (Sagrado)");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "存储升级珠(神圣)");

            Tooltip.SetDefault("Upgrades Storage Unit to 160 capacity"
                + "\n<right> a Hellstone Storage Unit to use");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Увеличивает количество слотов в Ячейке Хранилища до 160"
                + "\n<right> на Адской Ячейке Хранилища для улучшения");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Ulepsza jednostkę magazynującą do 160 miejsc"
                + "\n<right> na Jednostkę magazynującą (Piekielny kamień), aby użyć");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), "améliore la capacité de unité de stockage à 160"
                + "\n<right> l'unité de stockage (Infernale) pour utiliser");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Capacidad de unidad de almacenamiento mejorada a 160"
                + "\n<right> en la unidad de almacenamiento (Piedra Infernal) para utilizar");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "将存储单元升级至160容量"
                + "\n<right>一个存储单元(神圣)可镶嵌");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.maxStack = 99;
            item.rare = 4;
            item.value = Item.sellPrice(0, 0, 40, 0);
        }

        public override void AddRecipes()
        {
			Recipe recipe = CreateRecipe();
			recipe.createItem = this.item.Clone();
			recipe.createItem.stack = 1;
			recipe.AddIngredient(ItemID.HallowedBar, 10);
            recipe.AddIngredient(ItemID.SoulofFright);
            recipe.AddIngredient(ItemID.SoulofMight);
            recipe.AddIngredient(ItemID.SoulofSight);
            if (MagicStorage.legendMod == null)
            {
                recipe.AddIngredient(ItemID.Sapphire);
            }
            else
            {
                recipe.AddRecipeGroup("MagicStorage:AnySapphire");
            }
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
        }
    }
}
