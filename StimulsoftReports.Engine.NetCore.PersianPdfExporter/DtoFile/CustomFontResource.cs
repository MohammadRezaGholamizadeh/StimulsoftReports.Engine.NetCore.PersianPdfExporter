using System.Drawing;

namespace StimulsoftReports.Engine.NetCore.PersianPdfExporter.DtoFile
{
    public class CustomFontResource
    {
        public CustomFontResource(
            string fontName,
            byte[] fontData,
            string extension,
            string alias)
        {
            FontName = fontName;
            Alias = alias;
            Extension = extension;
            FontData = fontData;
        }

        internal string FontName { get; private set; }
        internal string Alias { get; private set; }
        internal string Extension { get; private set; }
        internal byte[] FontData { get; private set; }
    }

    public class CustomFontFile
    {
        public CustomFontFile(
            string fontPath,
            string? alias = null,
            FontStyle? fontStyle = null)
        {
            FontPath = fontPath;
            Alias = alias;
            FontStyle = fontStyle;
        }

        internal string FontPath { get; private set; }
        internal string? Alias { get; private set; }
        internal FontStyle? FontStyle { get; private set; }
    }
}
