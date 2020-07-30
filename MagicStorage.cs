using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.UI;
using Microsoft.Xna.Framework;
using Terraria.Localization;

namespace MagicStorage
{
    public class MagicStorage : Mod
    {
        public static MagicStorage Instance;
        public static Mod bluemagicMod;
        public static Mod legendMod;

        public static readonly Version requiredVersion = new Version(0, 11);

        public override void Load()
        {
            if (ModLoader.version < requiredVersion)
            {
                throw new Exception("Magic storage requires a tModLoader version of at least " + requiredVersion);
            }
            Instance = this;
            InterfaceHelper.Initialize();
            legendMod = ModLoader.GetMod("LegendOfTerraria3");
            bluemagicMod = ModLoader.GetMod("Bluemagic");
            AddTranslations();
        }

        public override void Unload()
        {
            Instance = null;
            bluemagicMod = null;
            legendMod = null;
            StorageGUI.Unload();
            //CraftingGUI.Unload();
        }

        private void AddTranslations()
        {
            ModTranslation text = CreateTranslation("SetTo");
            text.SetDefault("Set to: X={0}, Y={1}");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Ustawione na: X={0}, Y={1}");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Mis à: X={0}, Y={1}");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Ajustado a: X={0}, Y={1}");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "已设置为: X={0}, Y={1}");
            AddTranslation(text);

            text = CreateTranslation("SnowBiomeBlock");
            text.SetDefault("Snow Biome Block");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Bloc de biome de neige");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Bloque de Biomas de la Nieve");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "雪地环境方块");
            AddTranslation(text);

            text = CreateTranslation("DepositAll");
            text.SetDefault("Deposit All");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Переместить всё");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Déposer tout");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Depositar todo");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "全部存入");
            AddTranslation(text);

            text = CreateTranslation("Search");
            text.SetDefault("Search");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Поиск");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Rechercher");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Buscar");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "搜索");
            AddTranslation(text);

            text = CreateTranslation("SearchName");
            text.SetDefault("Search Name");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Поиск по имени");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Recherche par nom");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "búsqueda por nombre");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "搜索名称");
            AddTranslation(text);

            text = CreateTranslation("SearchMod");
            text.SetDefault("Search Mod");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Поиск по моду");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Recherche par mod");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "búsqueda por mod");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "搜索模组");
            AddTranslation(text);

            text = CreateTranslation("SortDefault");
            text.SetDefault("Default Sorting");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Стандартная сортировка");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Tri Standard");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Clasificación por defecto");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "默认排序");
            AddTranslation(text);

            text = CreateTranslation("SortID");
            text.SetDefault("Sort by ID");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Сортировка по ID");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Trier par ID");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Ordenar por ID");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "按ID排序");
            AddTranslation(text);

            text = CreateTranslation("SortName");
            text.SetDefault("Sort by Name");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Сортировка по имени");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Trier par nom");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Ordenar por nombre");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "按名称排序");
            AddTranslation(text);

            text = CreateTranslation("SortStack");
            text.SetDefault("Sort by Stacks");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Сортировка по стакам");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Trier par piles");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Ordenar por pilas");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "按堆栈排序");
            AddTranslation(text);

            text = CreateTranslation("FilterAll");
            text.SetDefault("Filter All");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Фильтр (Всё)");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Filtrer tout");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Filtrar todo");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "筛选全部");
            AddTranslation(text);

            text = CreateTranslation("FilterWeapons");
            text.SetDefault("Filter Weapons");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Фильтр (Оружия)");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Filtrer par armes");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Filtrar por armas");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "筛选武器");
            AddTranslation(text);

            text = CreateTranslation("FilterTools");
            text.SetDefault("Filter Tools");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Фильтр (Инструменты)");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Filtrer par outils");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Filtrar por herramientas");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "筛选工具");
            AddTranslation(text);

            text = CreateTranslation("FilterEquips");
            text.SetDefault("Filter Equipment");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Фильтр (Снаряжения)");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Filtrer par Équipement");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Filtrar por equipamiento");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "筛选装备");
            AddTranslation(text);

            text = CreateTranslation("FilterPotions");
            text.SetDefault("Filter Potions");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Фильтр (Зелья)");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Filtrer par potions");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Filtrar por poción");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "筛选药水");
            AddTranslation(text);

            text = CreateTranslation("FilterTiles");
            text.SetDefault("Filter Placeables");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Фильтр (Размещаемое)");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Filtrer par placeable");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Filtrar por metido");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "筛选放置物");
            AddTranslation(text);

            text = CreateTranslation("FilterMisc");
            text.SetDefault("Filter Misc");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Фильтр (Разное)");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Filtrer par miscellanées");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Filtrar por otros");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "筛选杂项");
            AddTranslation(text);

            text = CreateTranslation("CraftingStations");
            text.SetDefault("Crafting Stations");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Станции создания");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Stations d'artisanat");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Estaciones de elaboración");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "制作站");
            AddTranslation(text);

            text = CreateTranslation("Recipes");
            text.SetDefault("Recipes");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Рецепты");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Recettes");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Recetas");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "合成配方");
            AddTranslation(text);

            text = CreateTranslation("SelectedRecipe");
            text.SetDefault("Selected Recipe");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Recette sélectionnée");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Receta seleccionada");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "选择配方");
            AddTranslation(text);

            text = CreateTranslation("Ingredients");
            text.SetDefault("Ingredients");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Ingrédients");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Ingredientes");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "材料");
            AddTranslation(text);

            text = CreateTranslation("StoredItems");
            text.SetDefault("Stored Ingredients");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Ingrédients Stockés");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Ingredientes almacenados");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "存储中的材料");
            AddTranslation(text);

            text = CreateTranslation("RecipeAvailable");
            text.SetDefault("Show available recipes");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Afficher les recettes disponibles");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Mostrar recetas disponibles");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "显示可合成配方");
            AddTranslation(text);

            text = CreateTranslation("RecipeAll");
            text.SetDefault("Show all recipes");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Afficher toutes les recettes");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Mostrar todas las recetas");
            text.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "显示全部配方");
            AddTranslation(text);
        }

        public override void PostSetupContent()
        {
            
        }

        public override void AddRecipeGroups()
        {
            RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " Chest",
            ItemID.Chest,
            ItemID.GoldChest,
            ItemID.ShadowChest,
            ItemID.EbonwoodChest,
            ItemID.RichMahoganyChest,
            ItemID.PearlwoodChest,
            ItemID.IvyChest,
            ItemID.IceChest,
            ItemID.LivingWoodChest,
            ItemID.SkywareChest,
            ItemID.ShadewoodChest,
            ItemID.WebCoveredChest,
            ItemID.LihzahrdChest,
            ItemID.WaterChest,
            ItemID.JungleChest,
            ItemID.CorruptionChest,
            ItemID.CrimsonChest,
            ItemID.HallowedChest,
            ItemID.FrozenChest,
            ItemID.DynastyChest,
            ItemID.HoneyChest,
            ItemID.SteampunkChest,
            ItemID.PalmWoodChest,
            ItemID.MushroomChest,
            ItemID.BorealWoodChest,
            ItemID.SlimeChest,
            ItemID.GreenDungeonChest,
            ItemID.PinkDungeonChest,
            ItemID.BlueDungeonChest,
            ItemID.BoneChest,
            ItemID.CactusChest,
            ItemID.FleshChest,
            ItemID.ObsidianChest,
            ItemID.PumpkinChest,
            ItemID.SpookyChest,
            ItemID.GlassChest,
            ItemID.MartianChest,
            ItemID.GraniteChest,
            ItemID.MeteoriteChest,
            ItemID.MarbleChest);
            RecipeGroup.RegisterGroup("MagicStorage:AnyChest", group);
            group = new RecipeGroup(() => Lang.misc[37].Value + " " + Language.GetTextValue("Mods.MagicStorage.SnowBiomeBlock"), ItemID.SnowBlock, ItemID.IceBlock, ItemID.PurpleIceBlock, ItemID.PinkIceBlock);
            if (bluemagicMod != null)
            {
                group.ValidItems.Add(bluemagicMod.ItemType("DarkBlueIce"));
            }
            RecipeGroup.RegisterGroup("MagicStorage:AnySnowBiomeBlock", group);
            group = new RecipeGroup(() => Lang.misc[37].Value + " " + Lang.GetItemNameValue(ItemID.Diamond), ItemID.Diamond, ItemType("ShadowDiamond"));
            if (legendMod != null)
            {
                group.ValidItems.Add(legendMod.ItemType("GemChrysoberyl"));
                group.ValidItems.Add(legendMod.ItemType("GemAlexandrite"));
            }
            RecipeGroup.RegisterGroup("MagicStorage:AnyDiamond", group);
            if (legendMod != null)
            {
                group = new RecipeGroup(() => Lang.misc[37].Value + " " + Lang.GetItemNameValue(ItemID.Amethyst), ItemID.Amethyst, legendMod.ItemType("GemOnyx"), legendMod.ItemType("GemSpinel"));
                RecipeGroup.RegisterGroup("MagicStorage:AnyAmethyst", group);
                group = new RecipeGroup(() => Lang.misc[37].Value + " " + Lang.GetItemNameValue(ItemID.Topaz), ItemID.Topaz, legendMod.ItemType("GemGarnet"));
                RecipeGroup.RegisterGroup("MagicStorage:AnyTopaz", group);
                group = new RecipeGroup(() => Lang.misc[37].Value + " " + Lang.GetItemNameValue(ItemID.Sapphire), ItemID.Sapphire, legendMod.ItemType("GemCharoite"));
                RecipeGroup.RegisterGroup("MagicStorage:AnySapphire", group);
                group = new RecipeGroup(() => Lang.misc[37].Value + " " + Lang.GetItemNameValue(ItemID.Emerald), legendMod.ItemType("GemPeridot"));
                RecipeGroup.RegisterGroup("MagicStorage:AnyEmerald", group);
                group = new RecipeGroup(() => Lang.misc[37].Value + " " + Lang.GetItemNameValue(ItemID.Ruby), ItemID.Ruby, legendMod.ItemType("GemOpal"));
                RecipeGroup.RegisterGroup("MagicStorage:AnyRuby", group);
            }
        }

        public override void HandlePacket(BinaryReader reader, int whoAmI)
        {
            NetHelper.HandlePacket(reader, whoAmI);
        }

        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            InterfaceHelper.ModifyInterfaceLayers(layers);
        }

        public override void PostUpdateInput()
        {
            if (!Main.instance.IsActive)
            {
                return;
            }
            StorageGUI.Update(null);
            //CraftingGUI.Update(null);
        }
    }
}

