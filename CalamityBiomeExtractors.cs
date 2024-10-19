using Terraria.ModLoader;

namespace CalamityBiomeExtractors
{
	// Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
	public class CalamityBiomeExtractors : Mod
    {
        private static readonly object LocBase = "Mods.CalamityBiomeExtractors";

        private static string LocItemsCategory => $"{LocBase}.Items";
        private static string LocItemsExtractor(string variant) => $"{LocItemsCategory}.{variant}ExtractorItem";
        public static string LocItemsExtractorName(string variant) => $"{LocItemsExtractor(variant)}.DisplayName";
        public static string LocItemsExtractorDescr(string variant) => $"{LocItemsExtractor(variant)}.Tooltip";

        private static string LocTextCategory => $"{LocBase}.Text";
        public static string LocPoolNames => $"{LocTextCategory}.PoolNames";
        public static object LocArticles => $"{LocTextCategory}.Articles";

    }
}
