using StimulsoftReports.Engine.NetCore.PersianPdfExporter;
var datas = new List<dynamic>()
{
    "متن اول به زبان فارسی",
    "1234567890",
    "zxcvbnmlkjhgfdsaqwertyuiopZXCVBNMLKJHGFDSAQWERTYUIOP",
    "این متن برای تست زیرساخت استیمول سافت است",
    "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد. در این صورت می توان امید داشت که تمام و دشواری موجود در ارائه راهکارها و شرایط سخت تایپ به پایان رسد و زمان مورد نیاز شامل حروفچینی دستاوردهای اصلی و جوابگوی سوالات پیوسته اهل دنیای موجود طراحی اساسا مورد استفاده قرار گیرد."
};

var mrtFilePath = $"{typeof(Program).Namespace ?? "StiPdfExporterSample"}.MrtFiles.Report.mrt";
var mrtFileStream =
     typeof(Program).Assembly.GetManifestResourceStream(mrtFilePath);
var memoryStream = new MemoryStream();
mrtFileStream.CopyTo(memoryStream);
var mrtFileBytes = memoryStream.ToArray();


//Use Sti Report Engine To Start Report
StiReportEngine.StartReport()
               // Set Mrt File By Insert Mrt File Bytes      
               .SetMrtFile(mrtFileBytes)
               // This Method Used When You Are Using Business Object Data Mode
               .AddDataContentAsBusinessObject("Datas", datas)
               // Set Setting And Default Fonts That Used In Mrt File And Load And Render Mrt File
               .RenderWithBusinessObjectDataMode()
               // This Method Used When You Are Using Export Pdf To Absolute Path Mpde => If You Want To Export As Stream Use > .ExportPdfAsMemoryStream | .ExportPdfAsCustomStream
               .ExportPdfToPath($@"C:\Users\M.Gholamizadeh.TAAVSYS\Desktop\AllPdf\Test.Pdf");
