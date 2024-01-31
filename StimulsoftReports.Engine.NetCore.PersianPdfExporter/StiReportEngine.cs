using Stimulsoft.Base;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Export;
using System.Drawing;
using System.Text;

namespace StimulsoftReports.Engine.NetCore.PersianPdfExporter
{
    public static class StiReportEngine
    {
        public static StiReportConfiguration StartReport()
        {
            return new StiReportConfiguration();
        }

        public static StiReportConfiguration SetLicenseKey(
           this StiReportConfiguration configuration,
           string licenseKey)
        {
            StiLicense.LoadFromString(licenseKey);
            return configuration;
        }

        public static StiReportConfiguration SetCustomFont(
            this StiReportConfiguration configuration,
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

        public static StiReportConfiguration SetMrtFile(
            this StiReportConfiguration configuration,
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
        public static StiReportConfiguration AddDataContentAsBusinessObject(
          this StiReportConfiguration tools,
          string name,
          dynamic data)
        {
            try
            {
                tools.ReportData.Add(name, data);
            }
            catch
            {
                throw;
            }

            return tools;
        }
        public static StiReport RenderWithBusinessObjectDataMode(
           this StiReportConfiguration configuration,
           bool showProgressState = false)
        {
            var report = new StiReport();
            SetDefaultMrtFileFont(configuration);

            report.Load(configuration.MrtFileContent);

            report.RegBusinessObject(
                configuration.ReportData
                     .Select(_ => new StiBusinessObjectData(null, _.Key, _.Value))
                     .ToList());

            report.Render(showProgressState);

            return report;
        }

        private static void SetDefaultMrtFileFont(StiReportConfiguration configuration)
        {
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
