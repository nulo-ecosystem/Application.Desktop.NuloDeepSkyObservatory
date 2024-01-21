namespace Nulo.Core.Utilities {

    internal static partial class NativeMethods {

        public static string GetCopyright() {
            try {
                var info = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
                return info.LegalCopyright;
            } catch {
                return string.Empty;
            }
        }

        public static string GetSmallVersion() {
            try {
                var info = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
                return $"{info.ProductMajorPart}.{info.ProductMinorPart}";
            } catch {
                return string.Empty;
            }
        }

        public static string GetProductName() {
            try {
                var info = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
                return info.ProductName.Replace(" ®", "®");
            } catch {
                return string.Empty;
            }
        }

        public static string GetIdProduct() {
            return "{3e487cd9-128f-43d3-b87a-2e195a065ce7}";
        }
    }
}