using Stimulsoft.Base;
using StimulsoftReports.Engine.NetCore.PersianPdfExporter.DtoFile;
using StimulsoftReports.Engine.NetCore.PersianPdfExporter.Exceptions;
using System.Drawing;

namespace StimulsoftReports.Engine.NetCore.PersianPdfExporter
{
    public static class StiReportEngineFont
    {
        public static StiReportResource AddCustomFontBytes(
            this StiReportResource configuration,
            byte[] font,
            string? alias = null,
            FontStyle? fontStyle = null)
        {
            try
            {
                StiFontCollection
                    .AddFontBytes(
                        font,
                        alias,
                        fontStyle);
                configuration.Fonts.Add(font);
            }
            catch
            {
                throw;
            }

            return configuration;
        }

        public static StiReportResource AddCustomFontFile(
              this StiReportResource configuration,
              CustomFontFile font)
        {
            try
            {
                StiFontCollection
                    .AddFontFile(
                       font.FontPath,
                       font.Alias,
                       font.FontStyle);

                configuration.Fonts.Add(
                    StiFontCollection
                    .GetCustomFontData(
                        StiFontCollection.Instance
                                         .Families.Last().Name));
            }
            catch
            {
                throw;
            }

            return configuration;
        }

        public static StiReportResource AddCustomFontFiles(
              this StiReportResource configuration,
              IList<CustomFontFile> fonts)
        {
            foreach (var font in fonts)
            {
                try
                {
                    StiFontCollection
                        .AddFontFile(
                           font.FontPath,
                           font.Alias,
                           font.FontStyle);

                    configuration.Fonts.Add(
                        StiFontCollection
                        .GetCustomFontData(
                            StiFontCollection.Instance
                                             .Families.Last().Name));
                }
                catch
                {
                    throw;
                }
            }

            return configuration;
        }

        public static StiReportResource AddCustomFontResource(
               this StiReportResource configuration,
               CustomFontResource font)
        {
            try
            {
                StiFontCollection
                    .AddResourceFont(
                       font.FontName,
                       font.FontData,
                       font.Extension,
                       font.Alias);

                StopIfFontNameDoesNotMatchWithFontData(font.FontName, font.FontData);

                configuration.Fonts.Add(font.FontData);
            }
            catch
            {
                throw;
            }

            return configuration;
        }

        public static StiReportResource AddCustomFontResources(
              this StiReportResource configuration,
              IList<CustomFontResource> fonts)
        {
            foreach (var font in fonts)
            {
                try
                {
                    StiFontCollection
                        .AddResourceFont(
                           font.FontName,
                           font.FontData,
                           font.Extension,
                           font.Alias);

                    StopIfFontNameDoesNotMatchWithFontData(
                        font.FontName,
                        font.FontData);

                    configuration.Fonts.Add(font.FontData);
                }
                catch
                {
                    throw;
                }
            }

            return configuration;
        }

        public static StiReportResource AddCustomFontsBytes(
            this StiReportResource configuration,
            IList<byte[]> fonts)
        {
            foreach (var font in fonts)
            {
                try
                {
                    StiFontCollection
                        .AddFontBytes(font);
                    configuration.Fonts.Add(font);
                }

                catch
                {
                    throw;
                }
            }

            return configuration;
        }

        private static void StopIfFontNameDoesNotMatchWithFontData(
            string fontName,
            byte[] fontData)
        {
            if (StiFontCollection.Instance.Families.Last().Name != fontName)
            {
                try
                {
                    StiFontCollection.RemoveResourceFont(fontName, fontData);
                }
                catch
                {
                    throw;
                }
                finally
                {
                    throw new FontNameDoesNotMatchWithFontDataException();
                }
            }
        }
    }
}