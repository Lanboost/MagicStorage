using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MagicStorage.Items
{
    public class SnowBiomeEmulator : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Broken Snowglobe");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Сломанная Снежная Сфера");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Emulator Śnieżnego Biomu");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), "Emulateur de biome de neige");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Emulador de bioma de la nieve");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "雪地环境模拟器");

            Tooltip.SetDefault("Allows the Storage Crafting Interface to craft snow biome recipes");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Позволяет Модулю Создания Предметов создавать предметы требующие нахождения игрока в снежном биоме");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Dodaje funkcje do Interfejsu Rzemieślniczego, pozwalającą na wytwarzanie przedmiotów dostępnych jedynie w Śnieżnym Biomie");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), "Permet à L'interface de Stockage Artisanat de créer des recettes de biome de neige");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Permite la Interfaz de Elaboración de almacenamiento a hacer de recetas de bioma de la nieve");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "允许制作存储单元拥有雪地环境");

            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(8, 8));
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.rare = 1;
        }

        public override void AddRecipes()
        {
			Recipe recipe = CreateRecipe();
			recipe.createItem = this.item.Clone();
			recipe.createItem.stack = 1;
            recipe.AddRecipeGroup("MagicStorage:AnySnowBiomeBlock", 300);
            recipe.AddTile(null, "CraftingAccess");
            recipe.Register();
		}
    }
}
