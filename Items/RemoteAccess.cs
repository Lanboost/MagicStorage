using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MagicStorage.Items
{
    public class RemoteAccess : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Remote Storage Access");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Модуль Удаленного Доступа к Хранилищу");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Zdalna Jednostka Dostępu");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), "Fenêtre d'accès éloigné");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Acceso a Almacenamiento Remoto");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "远程存储装置");
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
            item.value = Item.sellPrice(0, 1, 72, 50);
            item.createTile = Mod.TileType("RemoteAccess");
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
                recipe.AddIngredient(ItemID.Ruby, 7);
            }
            else
            {
                recipe.AddRecipeGroup("MagicStorage:AnyRuby", 7);
            }
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
		}
    }
}
