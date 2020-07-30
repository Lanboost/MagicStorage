using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MagicStorage.Items
{
    public class StorageConnector : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Соединитель Ячеек Хранилища");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Łącznik");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), "Connecteur de Stockage");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Conector de Almacenamiento");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "存储连接器");
        }    
    
        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.rare = 0;
            item.value = Item.sellPrice(0, 0, 0, 10);
            item.createTile = Mod.TileType("StorageConnector");
        }

        public override void AddRecipes()
        {
			Recipe recipe = CreateRecipe();
			recipe.createItem = this.item.Clone();
			recipe.createItem.stack = 1;
			recipe.AddIngredient(ItemID.Wood, 16);
            recipe.AddIngredient(ItemID.IronBar);
            //recipe.anyWood = true;
            //recipe.anyIronBar = true;
            recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
        }
    }
}
