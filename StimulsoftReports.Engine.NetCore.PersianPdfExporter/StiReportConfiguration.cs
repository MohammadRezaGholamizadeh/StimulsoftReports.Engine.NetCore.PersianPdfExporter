namespace StimulsoftReports.Engine.NetCore.PersianPdfExporter
{
    public class StiReportConfiguration
    {
        public StiReportConfiguration()
        {
            ReportData = new Dictionary<string, dynamic>();
            Fonts = new List<byte[]>();
        }

        internal Dictionary<string, dynamic> ReportData { get; private set; }
        internal List<byte[]> Fonts { get; private set; }
        internal byte[] MrtFileContent { get; set; }
        internal string StimulsoftLicenseKey { get; set; } = default;
    }

}
