using Stimulsoft.Report;

namespace StimulsoftReports.Engine.NetCore.PersianPdfExporter.DtoFile
{
    public class StiReportResource
    {
        public StiReportResource()
        {
            Fonts = new List<byte[]>();
            ReportEngine = new StiReport();
        }

        internal List<byte[]> Fonts { get; private set; }
        internal byte[] MrtFileContent { get; set; }
        internal string StimulsoftLicenseKey { get; private set; } = default;
        internal StiReport ReportEngine { get; private set; }
    }

}
