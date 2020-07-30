using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MagicStorage.Items
{
    public class StorageComponent : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Компонент Хранилища");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Komponent Magazynu");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), "Composant de Stockage");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Componente de Almacenamiento");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "存储组件");
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
            item.value = Item.sellPrice(0, 0, 1, 0);
            item.createTile = Mod.TileType("StorageComponent");
        }

        public override void AddRecipes()
        {
			Recipe recipe = CreateRecipe();
			recipe.createItem = this.item.Clone();
			recipe.createItem.stack = 1;
			recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddIngredient(ItemID.IronBar, 2);
            //recipe.anyWood = true;
            //recipe.anyIronBar = true;
            recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
        }
    }
}
