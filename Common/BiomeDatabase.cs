using BiomeExtractorsMod.Common.Systems;
using BiomeExtractorsMod.Content.TileEntities;
using BiomeExtractorsMod.Content.Tiles;
using CalamityMod;
using CalamityMod.Items.Placeables;
using CalamityMod.Items.Materials;
using CalamityMod.Items.Critters;
using CalamityMod.Items.Placeables.Ores;
using CalamityMod.World;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static BiomeExtractorsMod.Common.Systems.BiomeExtractionSystem;
using NavystoneTile = CalamityMod.Tiles.SunkenSea.Navystone;
using EutrophicSandTile = CalamityMod.Tiles.SunkenSea.EutrophicSand;
using SeaPrismTile = CalamityMod.Tiles.SunkenSea.SeaPrism;
using SulphurousSandTile = CalamityMod.Tiles.Abyss.SulphurousSand;
using SulphurousSandstoneTile = CalamityMod.Tiles.Abyss.SulphurousSandstone;
using HardenedSulphurousSandstoneTile = CalamityMod.Tiles.Abyss.HardenedSulphurousSandstone;
using AbyssGravelTile = CalamityMod.Tiles.Abyss.AbyssGravel;
using PyreMantleTile = CalamityMod.Tiles.Abyss.PyreMantle;
using PyreMantleMoltenTile = CalamityMod.Tiles.Abyss.PyreMantleMolten;
using VoidstoneTile = CalamityMod.Tiles.Abyss.Voidstone;
using BrimstoneSlagTile = CalamityMod.Tiles.Crags.BrimstoneSlag;
using InfernalSueviteTile = CalamityMod.Tiles.Ores.InfernalSuevite;
using AstralDirtTile = CalamityMod.Tiles.Astral.AstralDirt;
using AstralStoneTile = CalamityMod.Tiles.Astral.AstralStone;
using AstralClayTile = CalamityMod.Tiles.Astral.AstralClay;
using AstralOreTile = CalamityMod.Tiles.Ores.AstralOre;
using NovaeSlagTile = CalamityMod.Tiles.Astral.NovaeSlag;
using AstralGrassTile = CalamityMod.Tiles.Astral.AstralGrass;
using AstralIceTile = CalamityMod.Tiles.AstralSnow.AstralIce;
using AstralSandTile = CalamityMod.Tiles.AstralDesert.AstralSand;
using AstralSandstoneTile = CalamityMod.Tiles.AstralDesert.AstralSandstone;
using HardenedAstralSandTile = CalamityMod.Tiles.AstralDesert.HardenedAstralSand;
using CalamityMod.Items.SummonItems;
using System.Collections.Generic;

namespace CalamityBiomeExtractors.Common
{
    internal class BiomeDatabase : ModSystem
    {
        static BiomeExtractionSystem BES => Instance;

        #region IDs
        public static readonly string snow_hm = "snow_hm";
        public static readonly string ug_snow_hm = "ug_snow_hm";
        public static readonly string ug_snow_cryo = "ug_snow_cryo";
        public static readonly string jungle_hm = "jungle_hm";
        public static readonly string jungle_glm = "jungle_glm";
        public static readonly string ug_jungle_hm = "ug_jungle_hm";
        public static readonly string ug_jungle_glm = "ug_jungle_glm";
        public static readonly string ug_jungle_prv = "ug_jungle_prv";
        public static readonly string dungeon_ml = "dungeon_ml";
        public static readonly string space_evil2 = "space_evil2";
        public static readonly string space_hm = "space_hm";
        public static readonly string space_ml = "space_ml";
        public static readonly string caverns_pla = "caverns_pla";
        public static readonly string caverns_yhr = "caverns_yhr";
        public static readonly string hallowed_forest_ml = "hallowed_forest_ml";
        public static readonly string hallowed_desert_ml = "hallowed_desert_ml";
        public static readonly string hallowed_snow_ml = "hallowed_snow_ml";
        public static readonly string underworld_ml = "underworld_ml";

        public static readonly string sunken_sea = "sunken_sea";
        public static readonly string sunken_sea_ds = "sunken_sea_ds";
        public static readonly string sulphur_sea = "sulphur_sea";
        public static readonly string sulphur_sea_hm = "sulphur_sea_hm";
        public static readonly string sulphur_sea_as = "sulphur_sea_as";
        public static readonly string sulphur_sea_ml = "sulphur_sea_ml";
        public static readonly string sulphur_depths = "sulphur_depths";
        public static readonly string sulphur_depths_lev = "sulphur_depths_lev";
        public static readonly string murky_waters = "murky_waters";
        public static readonly string murky_waters_lev = "murky_waters_leb";
        public static readonly string murky_waters_glm = "murky_waters_glm";
        public static readonly string thermal_vents = "thermal_vents";
        public static readonly string thermal_vents_pla = "thermal_vents_pla";
        public static readonly string thermal_vents_lev = "thermal_vents_lev";
        public static readonly string thermal_vents_glm = "thermal_vents_glm";
        public static readonly string the_void = "the_void";
        public static readonly string the_void_pla = "the_void_pla";
        public static readonly string the_void_lev = "the_void_lev";
        public static readonly string the_void_pgh = "the_void_pgh";
        public static readonly string brimstone_crag = "brimstone_crag";
        public static readonly string brimstone_crag_hm = "brimstone_crag_hm";
        public static readonly string brimstone_crag_mch = "brimstone_crag_mch";
        public static readonly string brimstone_crag_prv = "brimstone_crag_prv";
        public static readonly string astral_forest = "astral_forest";
        public static readonly string astral_ore_forest = "astral_ore_forest";
        public static readonly string astral_snow = "astral_snow";
        public static readonly string astral_ore_snow = "astral_ore_snow";
        public static readonly string astral_desert = "astral_desert";
        public static readonly string astral_ore_desert = "astral_ore_desert";
        public static readonly string ug_astral_forest = "ug_astral_forest";
        public static readonly string ug_astral_ore_forest = "ug_astral_ore_forest";
        public static readonly string ug_astral_snow = "ug_astral_snow";
        public static readonly string ug_astral_ore_snow = "ug_astral_ore_snow";
        public static readonly string ug_astral_desert = "ug_astral_desert";
        public static readonly string ug_astral_ore_desert = "ug_astral_ore_desert";

        #endregion

        #region Checks
        //BLOCK LISTS
        static readonly ushort[] sunken_sea_blocks = [(ushort)ModContent.TileType<NavystoneTile>(), (ushort)ModContent.TileType<EutrophicSandTile>(), (ushort)ModContent.TileType<SeaPrismTile>()];
        static readonly ushort[] sulphur_sea_blocks = [(ushort)ModContent.TileType<SulphurousSandTile>(), (ushort)ModContent.TileType<SulphurousSandstoneTile>(), (ushort)ModContent.TileType<HardenedSulphurousSandstoneTile>()];
        static readonly ushort[] abyss_gravel = [(ushort)ModContent.TileType<AbyssGravelTile>()];
        static readonly ushort[] thermal_blocks = [(ushort)ModContent.TileType<PyreMantleTile>(), (ushort)ModContent.TileType<PyreMantleMoltenTile>()];
        static readonly ushort[] voidstone = [(ushort)ModContent.TileType<VoidstoneTile>()];
        static readonly ushort[] brimstone_blocks = [(ushort)ModContent.TileType<BrimstoneSlagTile>(), (ushort)ModContent.TileType<InfernalSueviteTile>()];
        static readonly ushort[] astral_forest_blocks = [(ushort)ModContent.TileType<AstralDirtTile>(), (ushort)ModContent.TileType<AstralStoneTile>(), (ushort)ModContent.TileType<AstralOreTile>(), (ushort)ModContent.TileType<AstralClayTile>(), (ushort)ModContent.TileType<NovaeSlagTile>(), (ushort)ModContent.TileType<AstralGrassTile>()];
        static readonly ushort[] astral_snow_blocks = [(ushort)ModContent.TileType<AstralIceTile>()];
        static readonly ushort[] astral_desert_blocks = [(ushort)ModContent.TileType<AstralSandTile>(), (ushort)ModContent.TileType<AstralSandstoneTile>(), (ushort)ModContent.TileType<HardenedAstralSandTile>()];

        //COMPLEX
        static readonly Predicate<ScanData> in_sulphur_sea = scan => abyss_side.Invoke(scan) || sulphur_sea300.Invoke(scan);

        //POSITION
        static readonly Predicate<ScanData> abyss_side = scan =>
        {
            if (Abyss.AtLeftSideOfWorld)
                { if (scan.X < 435) return true; }
            else
                { if (scan.X > Main.maxTilesX - 435) return true; }
            return false;
        };

        //PROGRESSION
        static readonly Predicate<ScanData> post_scourge = scan => CalamityConditions.DownedDesertScourge.IsMet();
        static readonly Predicate<ScanData> post_scourge2 = scan => CalamityConditions.DownedAquaticScourge.IsMet();
        static readonly Predicate<ScanData> post_evil2 = scan => CalamityConditions.DownedHiveMindOrPerforator.IsMet();
        static readonly Predicate<ScanData> hardmodeOnly = scan => Main.hardMode;
        static readonly Predicate<ScanData> post_cryogen = scan => CalamityConditions.DownedCryogen.IsMet();
        static readonly Predicate<ScanData> post_plantera= scan => Condition.DownedPlantera.IsMet();
        static readonly Predicate<ScanData> post_leviathan = scan => CalamityConditions.DownedLeviathan.IsMet();
        static readonly Predicate<ScanData> post_golem = scan => Condition.DownedGolem.IsMet();
        static readonly Predicate<ScanData> post_deus = scan => CalamityConditions.DownedAstrumDeus.IsMet();
        static readonly Predicate<ScanData> post_moon_lord = scan => Condition.DownedMoonLord.IsMet();
        static readonly Predicate<ScanData> post_providence = scan => CalamityConditions.DownedProvidence.IsMet();
        static readonly Predicate<ScanData> post_polterghast = scan => CalamityConditions.DownedPolterghast.IsMet();
        static readonly Predicate<ScanData> post_yharon = scan => CalamityConditions.DownedYharon.IsMet();

        //TIERS
        static readonly Predicate<ScanData> demonic = scan => scan.MinTier((int)BiomeExtractorEnt.EnumTiers.DEMONIC);
        static readonly Predicate<ScanData> infernal = scan => scan.MinTier((int)BiomeExtractorEnt.EnumTiers.INFERNAL);
        static readonly Predicate<ScanData> steampunk = scan => scan.MinTier((int)BiomeExtractorEnt.EnumTiers.STEAMPUNK);
        static readonly Predicate<ScanData> cyber = scan => scan.MinTier((int)BiomeExtractorEnt.EnumTiers.CYBER);
        static readonly Predicate<ScanData> lunar = scan => scan.MinTier((int)BiomeExtractorEnt.EnumTiers.LUNAR);
        static readonly Predicate<ScanData> ethereal = scan => scan.MinTier((int)BiomeExtractorEnt.EnumTiers.ETHEREAL);
        static readonly Predicate<ScanData> spectral = scan => scan.MinTier((int)BiomeExtractorEnt.EnumTiers.ETHEREAL); //TODO
        static readonly Predicate<ScanData> cosmic = scan => scan.MinTier((int)BiomeExtractorEnt.EnumTiers.ETHEREAL); //TODO
        static readonly Predicate<ScanData> miraculous = scan => scan.MinTier((int)BiomeExtractorEnt.EnumTiers.ETHEREAL); //TODO

        //BLOCKS
        static readonly Predicate<ScanData> sunken_sea150 = scan => scan.Tiles(sunken_sea_blocks) >= 150;
        static readonly Predicate<ScanData> sulphur_sea300 = scan => scan.Tiles(sulphur_sea_blocks) >= 300;
        static readonly Predicate<ScanData> abyss_gravel300 = scan => scan.Tiles(abyss_gravel) >= 300;
        static readonly Predicate<ScanData> thermal_blocks300 = scan => scan.Tiles(thermal_blocks) >= 300;
        static readonly Predicate<ScanData> voidstone300 = scan => scan.Tiles(voidstone) >= 300;
        static readonly Predicate<ScanData> brimstone100 = scan => scan.Tiles(brimstone_blocks) >= 100;
        static readonly Predicate<ScanData> astral_forest950 = scan => scan.Tiles(astral_forest_blocks) >= 950;
        static readonly Predicate<ScanData> astral_snow951 = scan => scan.Tiles(astral_snow_blocks) >= 951;
        static readonly Predicate<ScanData> astral_desert951 = scan => scan.Tiles(astral_desert_blocks) >= 951;

        //MACHINE(, TURN BACK NOW)
        static readonly Predicate<ScanData> sulphuric_extractor = scan => pressurized_extractor.Invoke(scan) || TileUtils.TryGetTileEntityAs((int)scan.X, (int)scan.Y, out BiomeExtractorEnt _); //TODO BiomeExtractorSulphuric
        static readonly Predicate<ScanData> pressurized_extractor = scan => thermal_extractor.Invoke(scan) ||TileUtils.TryGetTileEntityAs((int)scan.X, (int)scan.Y, out BiomeExtractorEnt _); //TODO BiomeExtractorPressurized, requires dungeon materials
        static readonly Predicate<ScanData> thermal_extractor = scan => abyssal_extractor.Invoke(scan) || TileUtils.TryGetTileEntityAs((int)scan.X, (int)scan.Y, out BiomeExtractorEnt _); //TODO BiomeExtractorThermoresistant, requires post-golem materials
        static readonly Predicate<ScanData> abyssal_extractor = scan => TileUtils.TryGetTileEntityAs((int)scan.X, (int)scan.Y, out BiomeExtractorEnt _) || scan.IsScanner; //TODO BiomeExtractorAbyssal, requires post-polterghast materials

        #endregion

        #region Database Setup
        private static string LocalizeAs(string suffix) => $"{CalamityBiomeExtractors.LocPoolNames}.{suffix}";
        public override void PostSetupContent()
        {
            ExpandVanillaPools();
            InitializePools();
            SetRequirements();
            PopulatePools();
            BES.GenerateLocalizationKeys();
        }

        private static void ExpandVanillaPools()
        {
            //create supplementary pools
            BES.AddPool(caverns_pla, 1050, [cyber,  post_plantera]);
            BES.AddPool(caverns_yhr, 1050, [cosmic, post_yharon]);

            BES.AddPool(snow_hm, 50, [steampunk, hardmodeOnly]);
            BES.AddPool(ug_snow_hm,   1050, [steampunk, hardmodeOnly]);
            BES.AddPool(ug_snow_cryo, 1050, [steampunk, post_cryogen]);

            BES.AddPool(jungle_hm,  50, [steampunk, hardmodeOnly]);
            BES.AddPool(jungle_glm, 50, [cyber,     post_golem]);
            BES.AddPool(ug_jungle_hm,  1050, [steampunk, hardmodeOnly]);
            BES.AddPool(ug_jungle_glm, 1050, [cyber,     post_golem]);
            BES.AddPool(ug_jungle_prv, 1050, [ethereal,  post_providence]);

            BES.AddPool(hallowed_forest_ml, 100, [ethereal, post_moon_lord]);
            BES.AddPool(hallowed_desert_ml, 100, [ethereal, post_moon_lord]);
            BES.AddPool(hallowed_snow_ml, 100, [ethereal, post_moon_lord]);

            BES.AddPool(dungeon_ml, 2000, [ethereal, post_moon_lord]);

            BES.AddPool(space_evil2, 4000, [infernal,  post_evil2]);
            BES.AddPool(space_hm,    4000, [steampunk, hardmodeOnly]);
            BES.AddPool(space_ml,    4000, [ethereal,  post_moon_lord]);

            BES.AddPool(underworld_ml, 4000, [ethereal, post_moon_lord]);

            //setup supplementary pools
            BES.AddPoolRequirements(caverns_pla, cavernLayer);
            BES.AddPoolRequirements(caverns_yhr, cavernLayer);

            BES.AddPoolRequirements(snow_hm, frost1500);
            BES.AddPoolRequirements(ug_snow_hm,   belowSurfaceLayer, frost1500);
            BES.AddPoolRequirements(ug_snow_cryo, belowSurfaceLayer, frost1500);

            BES.AddPoolRequirements(jungle_hm,  jungle140);
            BES.AddPoolRequirements(jungle_glm, jungle140);
            BES.AddPoolRequirements(ug_jungle_hm,  middleUnderground, jungle140);
            BES.AddPoolRequirements(ug_jungle_glm, middleUnderground, jungle140);
            BES.AddPoolRequirements(ug_jungle_prv, middleUnderground, jungle140);

            BES.AddPoolRequirements(hallowed_snow,   hallow125.Invoke(hallowIceBlocks));
            BES.AddPoolRequirements(hallowed_forest, hallow125.Invoke(hallowForestBlocks));
            BES.AddPoolRequirements(hallowed_desert, hallow125.Invoke(hallowSandBlocks));

            BES.AddPoolRequirements(dungeon_ml, dungeon250, belowSurfaceLayer, dungeon_bg);

            BES.AddPoolRequirements(space_evil2, dungeon250, belowSurfaceLayer, dungeon_bg);
            BES.AddPoolRequirements(space_hm, spaceLayer, dungeon_bg);
            BES.AddPoolRequirements(space_ml, spaceLayer, dungeon_bg);

            BES.AddPoolRequirements(underworld_ml, underworldLayer);

            //fill pools
            BES.AddItemInPool(forest, (short)ModContent.ItemType<WulfrumMetalScrap>(), 40);
            BES.AddItemInPool(forest, (short)ModContent.ItemType<EnergyCore>(), 5);

            BES.AddItemInPool(underground, (short)ModContent.ItemType<AncientBoneDust>(), 10);

            BES.AddItemInPool(caverns, (short)ModContent.ItemType<AncientBoneDust>(), 10);
            BES.AddItemInPool(caverns_pla, (short)ModContent.ItemType<PerennialOre>(), 12);
            BES.AddItemInPool(caverns_yhr, (short)ModContent.ItemType<AuricOre>(), 15);

            BES.AddItemInPool(snow, ItemID.Leather, 1);
            BES.AddItemInPool(snow_hm, (short)ModContent.ItemType<EssenceofEleum>(), 1);

            BES.AddItemInPool(jungle, (short)ModContent.ItemType<MurkyPaste>(), 10);
            BES.AddItemInPool(jungle_hm, (short)ModContent.ItemType<TrapperBulb>(), 8);
            BES.AddItemInPool(jungle_glm, (short)ModContent.ItemType<MurkyPaste>(), 10);

            BES.AddItemInPool(hallowed_forest_ml, (short)ModContent.ItemType<UnholyEssence>(), 5);
            BES.AddItemInPool(hallowed_desert_ml, (short)ModContent.ItemType<UnholyEssence>(), 5);
            BES.AddItemInPool(hallowed_snow_ml,   (short)ModContent.ItemType<UnholyEssence>(), 5);

            BES.AddItemInPool(corrupt_forest, (short)ModContent.ItemType<BlightedGel>(), 15);
            BES.AddItemInPool(corrupt_desert, (short)ModContent.ItemType<BlightedGel>(), 7);
            BES.AddItemInPool(corrupt_snow,   (short)ModContent.ItemType<BlightedGel>(), 7);
            BES.AddItemInPool(crimson_forest, (short)ModContent.ItemType<BlightedGel>(), 15);
            BES.AddItemInPool(crimson_desert, (short)ModContent.ItemType<BlightedGel>(), 7);
            BES.AddItemInPool(crimson_snow,   (short)ModContent.ItemType<BlightedGel>(), 7);

            BES.AddItemInPool(ug_desert, (short)ModContent.ItemType<StormlionMandible>(), 5);

            BES.AddItemInPool(ug_snow_hm, (short)ModContent.ItemType<EssenceofEleum>(), 1);
            BES.AddItemInPool(ug_snow_cryo, (short)ModContent.ItemType<CryonicOre>(), 1);

            BES.AddItemInPool(ug_jungle, (short)ModContent.ItemType<MurkyPaste>(), 10);
            BES.AddItemInPool(ug_jungle_hm, (short)ModContent.ItemType<TrapperBulb>(), 8);
            BES.AddItemInPool(ug_jungle_glm, (short)ModContent.ItemType<PlagueCellCanister>(), 10);
            BES.AddItemInPool(ug_jungle_prv, (short)ModContent.ItemType<UelibloomOre>(), 20);

            BES.AddItemInPool(dungeon_ml, (short)ModContent.ItemType<Necroplasm>(), 20);

            BES.AddItemInPool(space_evil2, (short)ModContent.ItemType<AerialiteOre>(), 5);
            BES.AddItemInPool(space_hm, (short)ModContent.ItemType<EssenceofSunlight>(), 2);
            BES.AddItemInPool(space_ml, new ItemEntry((short)ModContent.ItemType<ExodiumCluster>(), 1, 3), 5);

            BES.AddItemInPool(underworld, (short)ModContent.ItemType<DemonicBoneAsh>(), 5);
            BES.AddItemInPool(underworld_ml, (short)ModContent.ItemType<UnholyEssence>(), 5);
            //TODO
        }

        private static void InitializePools()
        {
            BES.AddPool(astral_forest,     350, [hardmodeOnly, steampunk], LocalizeAs(astral_forest));
            BES.AddPool(astral_snow,       350, [hardmodeOnly, steampunk], LocalizeAs(astral_snow));
            BES.AddPool(astral_desert,     350, [hardmodeOnly, steampunk], LocalizeAs(astral_desert));
            BES.AddPool(astral_ore_forest, 350, [post_deus, lunar]);
            BES.AddPool(astral_ore_snow,   350, [post_deus, lunar]);
            BES.AddPool(astral_ore_desert, 350, [post_deus, lunar]);

            BES.AddPool(ug_astral_forest,     1050, [hardmodeOnly, steampunk], LocalizeAs(ug_astral_forest));
            BES.AddPool(ug_astral_snow,       1050, [hardmodeOnly, steampunk], LocalizeAs(ug_astral_snow));
            BES.AddPool(ug_astral_desert,     1050, [hardmodeOnly, steampunk], LocalizeAs(ug_astral_desert));
            BES.AddPool(ug_astral_ore_forest, 1050, [post_deus, lunar]);
            BES.AddPool(ug_astral_ore_snow,   1050, [post_deus, lunar]);
            BES.AddPool(ug_astral_ore_desert, 1050, [post_deus, lunar]);

            BES.AddPool(sunken_sea, 1050, LocalizeAs(sunken_sea));
            BES.AddPool(sunken_sea_ds, 1050, [post_scourge, belowSurfaceLayer]);

            BES.AddPool(sulphur_sea, 2600, (int)BiomeExtractorEnt.EnumTiers.DEMONIC, LocalizeAs(sulphur_sea));
            BES.AddPool(sulphur_sea_hm, 2600, [infernal, hardmodeOnly]);
            BES.AddPool(sulphur_sea_as, 2600, [steampunk, post_scourge2]);
            BES.AddPool(sulphur_sea_ml, 2600, [ethereal, post_moon_lord]);

            BES.AddPool(sulphur_depths,     2601, [sulphuric_extractor], LocalizeAs(sulphur_depths));
            BES.AddPool(sulphur_depths_lev, 2601, [sulphuric_extractor, post_leviathan]);
            BES.AddPool(murky_waters,     2602, [pressurized_extractor], LocalizeAs(murky_waters));
            BES.AddPool(murky_waters_lev, 2602, [pressurized_extractor, post_leviathan]);
            BES.AddPool(murky_waters_glm, 2602, [thermal_extractor]);
            BES.AddPool(thermal_vents,     2603, [thermal_extractor], LocalizeAs(thermal_vents));
            BES.AddPool(thermal_vents_pla, 2603, [thermal_extractor, post_plantera]);
            BES.AddPool(thermal_vents_lev, 2603, [thermal_extractor, post_leviathan]);
            BES.AddPool(thermal_vents_glm, 2603, [thermal_extractor, post_golem]);
            BES.AddPool(the_void,     2604, [abyssal_extractor], LocalizeAs(the_void));
            BES.AddPool(the_void_pla, 2604, [abyssal_extractor, post_plantera]);
            BES.AddPool(the_void_lev, 2604, [abyssal_extractor, post_leviathan]);
            BES.AddPool(the_void_pgh, 2604, [abyssal_extractor, post_polterghast]);

            BES.AddPool(brimstone_crag,     4100, (int)BiomeExtractorEnt.EnumTiers.INFERNAL, LocalizeAs(brimstone_crag));
            BES.AddPool(brimstone_crag_mch, 4100, (int)BiomeExtractorEnt.EnumTiers.STEAMPUNK);
            BES.AddPool(brimstone_crag_hm,  4100, [infernal, hardmodeOnly]);
            BES.AddPool(brimstone_crag_prv, 4100, [ethereal, post_providence]);
        }

        private static void SetRequirements()
        {
            BES.AddPoolRequirements(astral_forest,     astral_forest950);
            BES.AddPoolRequirements(astral_ore_forest, astral_forest950);
            BES.AddPoolRequirements(astral_snow,       astral_snow951);
            BES.AddPoolRequirements(astral_ore_snow,   astral_snow951);
            BES.AddPoolRequirements(astral_desert,     astral_desert951);
            BES.AddPoolRequirements(astral_ore_desert, astral_desert951);

            BES.AddPoolRequirements(ug_astral_forest,     belowSurfaceLayer, astral_forest950);
            BES.AddPoolRequirements(ug_astral_snow,       belowSurfaceLayer, astral_snow951);
            BES.AddPoolRequirements(ug_astral_desert,     belowSurfaceLayer, astral_desert951);
            BES.AddPoolRequirements(ug_astral_ore_forest, belowSurfaceLayer, astral_forest950);
            BES.AddPoolRequirements(ug_astral_ore_snow,   belowSurfaceLayer, astral_snow951);
            BES.AddPoolRequirements(ug_astral_ore_desert, belowSurfaceLayer, astral_desert951);

            BES.AddPoolRequirements(sunken_sea,    sunken_sea150);
            BES.AddPoolRequirements(sunken_sea_ds, sunken_sea150);

            BES.AddPoolRequirements(sulphur_sea,    in_sulphur_sea);
            BES.AddPoolRequirements(sulphur_sea_hm, in_sulphur_sea);
            BES.AddPoolRequirements(sulphur_sea_as, in_sulphur_sea);
            BES.AddPoolRequirements(sulphur_sea_ml, in_sulphur_sea);

            BES.AddPoolRequirements(sulphur_depths,     abyss_side, cavernLayer);
            BES.AddPoolRequirements(sulphur_depths_lev, abyss_side, cavernLayer);
            BES.AddPoolRequirements(murky_waters,       abyss_side, cavernLayer, abyss_gravel300);
            BES.AddPoolRequirements(murky_waters_lev,   abyss_side, cavernLayer, abyss_gravel300);
            BES.AddPoolRequirements(murky_waters_glm,   abyss_side, cavernLayer, abyss_gravel300);
            BES.AddPoolRequirements(thermal_vents,      abyss_side, cavernLayer, thermal_blocks300);
            BES.AddPoolRequirements(thermal_vents_pla,  abyss_side, cavernLayer, thermal_blocks300);
            BES.AddPoolRequirements(thermal_vents_lev,  abyss_side, cavernLayer, thermal_blocks300);
            BES.AddPoolRequirements(thermal_vents_glm,  abyss_side, cavernLayer, thermal_blocks300);
            BES.AddPoolRequirements(the_void,           abyss_side, cavernLayer, voidstone300);
            BES.AddPoolRequirements(the_void_pla,       abyss_side, cavernLayer, voidstone300);
            BES.AddPoolRequirements(the_void_lev,       abyss_side, cavernLayer, voidstone300);
            BES.AddPoolRequirements(the_void_pgh,       abyss_side, cavernLayer, voidstone300);

            BES.AddPoolRequirements(brimstone_crag,     underworldLayer, brimstone100);
            BES.AddPoolRequirements(brimstone_crag_hm,  underworldLayer, brimstone100);
            BES.AddPoolRequirements(brimstone_crag_mch, underworldLayer, brimstone100);
            BES.AddPoolRequirements(brimstone_crag_prv, underworldLayer, brimstone100);
        }

        private static void PopulatePools()
        {
            BES.AddItemInPool(astral_forest, ItemID.None, 72);
            BES.AddItemInPool(astral_forest, (short)ModContent.ItemType<AstralDirt>(), 26);
            BES.AddItemInPool(astral_forest, (short)ModContent.ItemType<AstralStone>(), 7);
            BES.AddItemInPool(astral_forest, (short)ModContent.ItemType<AstralClay>(), 8);
            BES.AddItemInPool(astral_forest, (short)ModContent.ItemType<AstralMonolith>(), 50);
            BES.AddItemInPool(astral_forest, (short)ModContent.ItemType<StarblightSoot>(), 36);
            BES.AddItemInPool(astral_forest, (short)ModContent.ItemType<TitanHeart>(), 4);
            BES.AddItemInPool(astral_forest, (short)ModContent.ItemType<AstralGrassSeeds>(), 7);
            BES.AddItemInPool(astral_forest, ItemID.EnchantedNightcrawler, 1);
            BES.AddItemInPool(astral_forest, (short)ModContent.ItemType<TwinklerItem>(), 4);
            BES.AddItemInPool(astral_desert, ItemID.None, 31);
            BES.AddItemInPool(astral_desert, (short)ModContent.ItemType<AstralSand>(), 41);
            BES.AddItemInPool(astral_desert, (short)ModContent.ItemType<AstralMonolith>(), 25);
            BES.AddItemInPool(astral_desert, (short)ModContent.ItemType<StarblightSoot>(), 27);
            BES.AddItemInPool(astral_desert, (short)ModContent.ItemType<TitanHeart>(), 3);
            BES.AddItemInPool(astral_desert, ItemID.EnchantedNightcrawler, 2);
            BES.AddItemInPool(astral_desert, (short)ModContent.ItemType<TwinklerItem>(), 5);
            BES.AddItemInPool(astral_snow, ItemID.None, 50);
            BES.AddItemInPool(astral_snow, ItemID.SnowBlock, 27);
            BES.AddItemInPool(astral_snow, (short)ModContent.ItemType<AstralIce>(), 14);
            BES.AddItemInPool(astral_snow, (short)ModContent.ItemType<AstralMonolith>(), 17);
            BES.AddItemInPool(astral_snow, (short)ModContent.ItemType<StarblightSoot>(), 27);
            BES.AddItemInPool(astral_snow, (short)ModContent.ItemType<TitanHeart>(), 3);
            BES.AddItemInPool(astral_snow, ItemID.EnchantedNightcrawler, 2);
            BES.AddItemInPool(astral_snow, (short)ModContent.ItemType<TwinklerItem>(), 6);
            BES.AddItemInPool(astral_ore_forest, new ItemEntry((short)ModContent.ItemType<AstralOre>(), 1, 3), 1);
            BES.AddItemInPool(astral_ore_snow,   new ItemEntry((short)ModContent.ItemType<AstralOre>(), 1, 3), 1);
            BES.AddItemInPool(astral_ore_desert, new ItemEntry((short)ModContent.ItemType<AstralOre>(), 1, 3), 1);

            BES.AddItemInPool(ug_astral_forest, ItemID.None, 70);
            BES.AddItemInPool(ug_astral_forest, (short)ModContent.ItemType<AstralDirt>(), 16);
            BES.AddItemInPool(ug_astral_forest, (short)ModContent.ItemType<AstralStone>(), 8);
            BES.AddItemInPool(ug_astral_forest, (short)ModContent.ItemType<NovaeSlag>(), 4);
            BES.AddItemInPool(ug_astral_forest, (short)ModContent.ItemType<StarblightSoot>(), 27);
            BES.AddItemInPool(ug_astral_forest, (short)ModContent.ItemType<TitanHeart>(), 3);
            BES.AddItemInPool(ug_astral_desert, (short)ModContent.ItemType<AstralSand>(), 6);
            BES.AddItemInPool(ug_astral_desert, (short)ModContent.ItemType<HardenedAstralSand>(), 6);
            BES.AddItemInPool(ug_astral_desert, (short)ModContent.ItemType<AstralSandstone>(), 6);
            BES.AddItemInPool(ug_astral_desert, (short)ModContent.ItemType<CelestialRemains>(), 6);
            BES.AddItemInPool(ug_astral_desert, (short)ModContent.ItemType<StarblightSoot>(), 27);
            BES.AddItemInPool(ug_astral_desert, (short)ModContent.ItemType<TitanHeart>(), 3);
            BES.AddItemInPool(ug_astral_snow, ItemID.None, 69);
            BES.AddItemInPool(ug_astral_snow, ItemID.SnowBlock, 10);
            BES.AddItemInPool(ug_astral_snow, (short)ModContent.ItemType<AstralIce>(), 10);
            BES.AddItemInPool(ug_astral_snow, (short)ModContent.ItemType<NovaeSlag>(), 4);
            BES.AddItemInPool(ug_astral_snow, (short)ModContent.ItemType<StarblightSoot>(), 27);
            BES.AddItemInPool(ug_astral_snow, (short)ModContent.ItemType<TitanHeart>(), 3);
            BES.AddItemInPool(ug_astral_ore_forest, new ItemEntry((short)ModContent.ItemType<AstralOre>(), 1, 3), 1);
            BES.AddItemInPool(ug_astral_ore_snow,   new ItemEntry((short)ModContent.ItemType<AstralOre>(), 1, 3), 1);
            BES.AddItemInPool(ug_astral_ore_desert, new ItemEntry((short)ModContent.ItemType<AstralOre>(), 1, 3), 1);

            BES.AddItemInPool(sunken_sea, ItemID.None, 20);
            BES.AddItemInPool(sunken_sea, (short)ModContent.ItemType<EutrophicSand>(), 11);
            BES.AddItemInPool(sunken_sea, (short)ModContent.ItemType<Navystone>(), 7);
            BES.AddItemInPool(sunken_sea, (short)ModContent.ItemType<SeaPrism>(), 13);
            BES.AddItemInPool(sunken_sea, (short)ModContent.ItemType<PrismShard>(), 13);
            BES.AddItemInPool(sunken_sea, (short)ModContent.ItemType<PrismShard>(), 10);
            BES.AddItemInPool(sunken_sea, (short)ModContent.ItemType<PrismShard>(), 3);
            BES.AddItemInPool(sunken_sea, (short)ModContent.ItemType<PrismShard>(), 1);
            BES.AddItemInPool(sunken_sea, (short)ModContent.ItemType<BabyGhostBellItem>(), 3);
            BES.AddItemInPool(sunken_sea, (short)ModContent.ItemType<SeaMinnowItem>(), 4);

            BES.AddItemInPool(sulphur_sea, ItemID.None, 90);
            BES.AddItemInPool(sulphur_sea, (short)ModContent.ItemType<SulphurousSand>(), 12);
            BES.AddItemInPool(sulphur_sea, (short)ModContent.ItemType<SulphurousSandstone>(), 6);
            BES.AddItemInPool(sulphur_sea, (short)ModContent.ItemType<HardenedSulphurousSandstone>(), 4);
            BES.AddItemInPool(sulphur_sea, ItemID.Coral, 5);
            BES.AddItemInPool(sulphur_sea, ItemID.Seashell, 4);
            BES.AddItemInPool(sulphur_sea, ItemID.Starfish, 3);
            BES.AddItemInPool(sulphur_sea, ItemID.Cactus, 20);
            BES.AddItemInPool(sulphur_sea_hm, ItemID.TurtleShell, 5);
            BES.AddItemInPool(sulphur_sea_as, (short)ModContent.ItemType<BabyFlakCrabItem>(), 6);
            BES.AddItemInPool(sulphur_sea_ml, (short)ModContent.ItemType<BloodwormItem>(), 1);

            BES.AddItemInPool(sulphur_depths, ItemID.None, 51);
            BES.AddItemInPool(sulphur_depths, (short)ModContent.ItemType<SulphurousShale>(), 18);
            BES.AddItemInPool(sulphur_depths, (short)ModContent.ItemType<BabyCannonballJellyfishItem>(), 7);
            BES.AddItemInPool(sulphur_depths_lev, (short)ModContent.ItemType<DepthCells>(), 1);

            BES.AddItemInPool(murky_waters, ItemID.None, 62);
            BES.AddItemInPool(murky_waters, (short)ModContent.ItemType<AbyssGravel>(), 26);
            BES.AddItemInPool(murky_waters, (short)ModContent.ItemType<PlantyMush>(), 10);
            BES.AddItemInPool(murky_waters, (short)ModContent.ItemType<Voidstone>(), 2);
            BES.AddItemInPool(murky_waters, ItemID.WhitePearl, 3);
            BES.AddItemInPool(murky_waters, ItemID.PinkPearl, 1);
            BES.AddItemInPool(murky_waters_lev, (short)ModContent.ItemType<Lumenyl>(), 20);
            BES.AddItemInPool(murky_waters_lev, (short)ModContent.ItemType<DepthCells>(), 28);
            BES.AddItemInPool(murky_waters_glm, (short)ModContent.ItemType<ScoriaOre>(), 12);

            BES.AddItemInPool(thermal_vents, ItemID.None, 26);
            BES.AddItemInPool(thermal_vents, (short)ModContent.ItemType<PyreMantle>(), 13);
            BES.AddItemInPool(thermal_vents, (short)ModContent.ItemType<PyreMantleMolten>(), 5);
            BES.AddItemInPool(thermal_vents, (short)ModContent.ItemType<ScoriaOre>(), 5);
            BES.AddItemInPool(thermal_vents, ItemID.BlackInk, 1);
            BES.AddItemInPool(thermal_vents_pla, ItemID.Ectoplasm, 2);
            BES.AddItemInPool(thermal_vents_lev, (short)ModContent.ItemType<Lumenyl>(), 13);
            BES.AddItemInPool(thermal_vents_lev, (short)ModContent.ItemType<DepthCells>(), 15);
            BES.AddItemInPool(thermal_vents_glm, (short)ModContent.ItemType<ScoriaOre>(), 5);

            BES.AddItemInPool(the_void, ItemID.None, 26);
            BES.AddItemInPool(the_void, (short)ModContent.ItemType<Voidstone>(), 26);
            BES.AddItemInPool(the_void, ItemID.BlackInk, 1);
            BES.AddItemInPool(the_void_pla, ItemID.Ectoplasm, 5);
            BES.AddItemInPool(the_void_lev, (short)ModContent.ItemType<Lumenyl>(), 9);
            BES.AddItemInPool(the_void_lev, (short)ModContent.ItemType<DepthCells>(), 14);
            BES.AddItemInPool(the_void_pgh, (short)ModContent.ItemType<ReaperTooth>(), 3);

            BES.AddItemInPool(brimstone_crag, ItemID.None, 22);
            BES.AddItemInPool(brimstone_crag, (short)ModContent.ItemType<BrimstoneSlag>(), 10);
            BES.AddItemInPool(brimstone_crag, (short)ModContent.ItemType<ScorchedRemains>(), 6);
            BES.AddItemInPool(brimstone_crag, ItemID.Lens, 3);
            BES.AddItemInPool(brimstone_crag, (short)ModContent.ItemType<SpineSapling>(), 5);
            BES.AddItemInPool(brimstone_crag_hm, (short)ModContent.ItemType<EssenceofHavoc>(), 18);
            BES.AddItemInPool(brimstone_crag_mch, (short)ModContent.ItemType<InfernalSuevite>(), 6);
            BES.AddItemInPool(brimstone_crag_prv, (short)ModContent.ItemType<Bloodstone>(), 15);
        }

        #endregion
    }
}
