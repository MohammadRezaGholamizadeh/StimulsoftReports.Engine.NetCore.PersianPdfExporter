using Stimulsoft.Base;
using Stimulsoft.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Export;
using StimulsoftReports.Engine.NetCore.PersianPdfExporter.DtoFile;
using System.Data;
using System.Text;

namespace StimulsoftReports.Engine.NetCore.PersianPdfExporter
{
    public static class StiReportEngine
    {
        public static DtoFile.StiReportResource StartReport()
        {
            return new DtoFile.StiReportResource();
        }

        public static DtoFile.StiReportResource SetLicenseKey(
           this DtoFile.StiReportResource configuration,
           string licenseKey)
        {
            StiLicense.LoadFromString(licenseKey);
            return configuration;
        }

        public static DtoFile.StiReportResource SetMrtFile(
            this DtoFile.StiReportResource configuration,
            byte[] mrtFileBytes)
        {
            try
            {
                configuration.MrtFileContent = mrtFileBytes;

            }
            catch
            {
                throw;
            }

            return configuration;
        }


        public static StiReport Render(
        this DtoFile.StiReportResource configuration,
        bool showProgressState = false)
        {
            SetDefaultMrtFileFont(configuration);
            configuration.ReportEngine.Load(configuration.MrtFileContent);
            configuration.ReportEngine.RegReportDataSources()
                                      .Render(showProgressState);
            return configuration.ReportEngine;
        }


        private static void SetDefaultMrtFileFont(DtoFile.StiReportResource configuration)
        {
            var mrtFontName = "";
            try
            {
                var mrtFileFonts = Encoding.UTF8
                              .GetString(configuration.MrtFileContent)
                              .Split(Environment.NewLine)
                              .Where(_ => _.Contains("<Font>"))
                              .Select(_ => _.Replace("<Font>", "")
                                            .Replace("</Font>", "")
                                            .Split(",")
                                            .First().Trim())
                              .Distinct();

                foreach (var mrtFileFont in mrtFileFonts)
                {
                    mrtFontName = mrtFileFont;
                    var fontExtension =
                        Path.GetExtension(
                             Path.GetFullPath(
                                  typeof(StiReportEngine)
                                  .Assembly
                                  .GetManifestResourceNames()
                                  .First(_ => _.Contains($"{typeof(StiReportEngine).Namespace}.Fonts.{mrtFileFont}.ttf"))));

                    var fontPath = $"{typeof(StiReportEngine).Namespace}.Fonts.{mrtFileFont}{fontExtension}";
                    var fontStream =
                         typeof(StiReportEngine)
                             .Assembly.GetManifestResourceStream(fontPath);
                    var memoryStream = new MemoryStream();
                    fontStream.CopyTo(memoryStream);
                    var fontByte = memoryStream.ToArray();

                    configuration.Fonts.Add(fontByte);
                    StiFontCollection.AddFontBytes(fontByte);
                }
            }
            catch (Exception)
            {
                if (!StiFontCollection
                     .Instance
                     .Families
                     .Any(_ => _.Name == mrtFontName))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($" ::Error:: => !! Font {'"'}{mrtFontName}{'"'} Not Found To Set In Export !!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        public static void ExportPdfToPath(this StiReport report, string absolutePath)
        {
            report.ExportDocument(StiExportFormat.Pdf, absolutePath);
        }

        public static Stream ExportPdfAsMemoryStream(this StiReport report, StiExportSettings settings)
        {
            settings ??= new StiPdfExportSettings();

            var memoryStream = new MemoryStream();
            report.ExportDocument(StiExportFormat.Pdf, memoryStream, settings);
            memoryStream.Seek(0, SeekOrigin.Begin);
            return memoryStream;
        }

        public static Stream ExportPdfAsCustomStream(
            this StiReport report,
            Stream customStream,
            StiExportSettings settings)
        {
            settings ??= new StiPdfExportSettings();

            report.ExportDocument(StiExportFormat.Pdf, customStream, settings);
            customStream.Seek(0, SeekOrigin.Begin);
            return customStream;
        }
    }

}
