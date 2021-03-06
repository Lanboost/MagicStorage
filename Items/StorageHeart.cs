﻿using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MagicStorage.Items
{
    public class StorageHeart : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Сердце Хранилища");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Serce Jednostki Magazynującej");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), "Cœur de Stockage");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Corazón de Almacenamiento");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "存储核心");
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
            item.value = Item.sellPrice(0, 1, 35, 0);
            item.createTile = Mod.TileType("StorageHeart");
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
                recipe.AddIngredient(ItemID.Emerald, 7);
            }
            else
            {
                recipe.AddRecipeGroup("MagicStorage:AnyEmerald", 7);
            }
            recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
        }
    }
}
