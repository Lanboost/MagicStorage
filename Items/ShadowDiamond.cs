using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MagicStorage.Items
{
    public class ShadowDiamond : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Теневой Алмаз");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Mroczny Diament");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), "Diamant sombre");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Diamante sombreado");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "暗影钻石");

            Tooltip.SetDefault("Traces of light still linger inside");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Следы света все еще мелькают внутри");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Ślady światła wciąż pozostają w środku");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), "Des traces de lumière s'attarde encore à l'intérieur");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Sigue habiendo huellas de luz en el interior");
            Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "那道光所余留的痕迹依旧");
        }
        

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 99;
            item.rare = 1;
            item.value = Item.sellPrice(0, 1, 0, 0);
        }

        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
    }
}
