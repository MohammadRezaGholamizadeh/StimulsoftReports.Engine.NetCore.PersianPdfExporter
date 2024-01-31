
# Project Title
This Project Developed For Exporting The Pdf With Persian Or English Language By Stimulsoft Report Engile For Dotnet Project. 

In This Project All Of Problems Of Exporting Persian Pdf and English Pdf Are Solved And Combined Over 100 Different Font To Use.

The Font List That You Can Use For This Tools Explained In The End Of Readme File.
Otherwise You Can Set Your Custom Own Font By Your Self To Export Pdf.



## Methods And Implementation

#### All Methods

```http
  StartReport();

  SetLicenseKey(licenseKey);

  SetCustomFont(font, alias, fontStyle);

  SetCustomFont(fontName, extension, fontContent, alias);

  GetAllSettedFontsUntilNow();

  SetMrtFile(mrtFileBytes);

  AddDataContentAsBusinessObject(name, data);

  RenderWithBusinessObjectDataMode(showProgressState);

  ExportPdfToPath(absolutePath);

  ExportPdfAsMemoryStream(settings);

  ExportPdfAsCustomStream(customStream, settings);

```




***
**Methods Definition**
- **StiReportEngine : Main Class**
- #### **StartReport()**
|Description                                                                   |
|:-------                                                                      |
|First Method That You Must Call To Start Report Process .This Method Create an instance of StiReportConfiguration To Continue                                 |

- #### **SetLicenseKey(licenseKey)**
| Parameter | Type     | Description                                         |
| :-------- | :------- | :--------------------------------                   |
| `licenseKey`      | `string` | **Required**. Stimulsoft License Key To Set |

**Method Description** : This Method Used For Set License Key To Stimulsoft Report Engine.

- #### **SetCustomFont(font, alias, fontStyle)**
| Parameter | Type     | Description                                         |
| :-------- | :------- | :--------------------------------                   |
| `font`      | `byte[]` | **Required**. Font Bytes |
| `alias`      | `string?` | **Not Required**. Font Alies |
| `fontStyle`      | `FontStyle?` | **Not Required**. Font Style |

**Method Description** : This Method Used For Set Custom Font (Client Choice) To Stimulsoft Report Engine.

- #### **SetCustomFont(fontName, extension, fontContent, alias)**
| Parameter | Type     | Description                                         |
| :-------- | :------- | :--------------------------------                   |
| `fontName`      | `string` | **Required**. Font Name |
| `extension`      | `string` | **Required**. Font Extension |
| `fontContent`      | `byte[]` | **Required**. Font Content As Bytes[] |
| `alias`      | `string?` | **Not Required**. Font Alias |

**Method Description** : This Method Used For Set Custom Font (Client Choice) To Stimulsoft Report Engine.


- #### **GetAllSettedFontsUntilNow()**
|Description                                                                   |
|:-------                                                                      |
|Get All Fonts That Be Setted Until Now    |

**Method Description** : This Method Give You All Fonts That added to Stimulsoft Report Engine until app stoped .

- #### **SetMrtFile(mrtFileBytes)**
| Parameter | Type     | Description                                         |
| :-------- | :------- | :--------------------------------                   |
| `mrtFileBytes`      | `byte[]` | **Required**. Mrt File Bytes |

**Method Description** : This Method Used For Set Mrt File To Stimulsoft Report Engine.

- #### **AddDataContentAsBusinessObject(name, data);**
| Parameter | Type     | Description                                         |
| :-------- | :------- | :--------------------------------                   |
| `name`      | `string` | **Required**. Name Of Business Object Data That You Created In Stimulsoft Designer|
| `data`      | `dynamic` | **Required**. Data Of Business Object Data That You Created In Stimulsoft Designer|

**Method Description** : This Method Used For Set Datas That You Want To Export In PDF To Stimulsoft Report Engine.

- #### **RenderWithBusinessObjectDataMode(showProgressState)**
| Parameter | Type     | Description                                         |
| :-------- | :------- | :--------------------------------                   |
| `showProgressState`      | `bool` | **Required**. Start Rendering The Report With Data And Fonts That You Setted In Stimulsoft Design By Sti Report Engine|

**Method Description** : This Method Used For Start Rendering The Report With Data And Fonts That You Setted In Stimulsoft Design By Sti Report Engine.

- #### **ExportPdfToPath(absolutePath)**
| Parameter | Type     | Description                                         |
| :-------- | :------- | :--------------------------------                   |
| `absolutePath`      | `string` | **Required**. The Path That You Want Pdf Be Exported To |

**Method Description** : This Method Used For Exporting Renderred Pdf To Absolute Path That You Choose.

- #### **ExportPdfAsMemoryStream(settings)**
| Parameter | Type     | Description                                         |
| :-------- | :------- | :--------------------------------                   |
| `settings`      | `StiExportSettings` | **Required**. The Setting That You Want To Add Into Pdf Export Process By Sti Report Engine|

**Method Description** : This Method Used For Exporting Pdf As Memoty Stream.

- #### **  ExportPdfAsCustomStream(customStream, settings);**
| Parameter | Type     | Description                                         |
| :-------- | :------- | :--------------------------------                   |
| `customStream`      | `Stream` | **Required**. Pdf Will Be Exporting To Your Stream Instance .|
| `settings`      | `StiExportSettings` | **Required**. The Setting That You Want To Add Into Pdf Export Process By Sti Report Engine|

**Method Description** : This Method Used For Exporting Pdf As Memoty Stream.

## Acknowledgements

 - [Get Start With Sample Code](https://github.com/MohammadRezaGholamizadeh/StimulsoftReports.Engine.NetCore.PersianPdfExporter.SampleCode.git)


 - [Author And Developer Github Link](https://github.com/MohammadRezaGholamizadeh)
## License

[GPL - v.3](https://github.com/MohammadRezaGholamizadeh/StimulsoftReports.Engine.NetCore.PersianPdfExporter/blob/main/LICENSE)


## Used By

This project is used by the following companies:

- TaavSys Corporation - Shiraz


## Authors

- [@MohammadRezaGholamizadeh](https://github.com/MohammadRezaGholamizadeh)


![Logo](https://raw.githubusercontent.com/MohammadRezaGholamizadeh/StimulsoftReports.Engine.NetCore.PersianPdfExporter/main/StimulsoftReports.Engine.NetCore.PersianPdfExporter/icon.ico)


## 🔗 Links
[![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/mohammadreza-gholamizadeh-b94b1521b/)
[![linkedin](https://img.shields.io/badge/github-0A66C2?style=for-the-badge&logo=github&logoColor=black)](https://github.com/MohammadRezaGholamizadeh/)




## Tech Stack

**Client:** WebBrowser

**Server:** DotNet 5, Dotnet 6, Dotnet 7


## Run Locally

Add Package To Your Project With Command

- .NET CLI
```bash
  dotnet add package StimulsoftReports.Engine.NetCore.PersianPdfExportere --version 2024.1.3
```

- Package Manager
```bash
  NuGet\Install-Package StimulsoftReports.Engine.NetCore.PersianPdfExportere -Version 2024.1.3
```

- Package Reference
```bash
  <PackageReference Include="StimulsoftReports.Engine.NetCore.PersianPdfExportere" Version="2024.1.3" />
```

- Packet CLI
```bash
  paket add StimulsoftReports.Engine.NetCore.PersianPdfExportere --version 2024.1.3
```

- Script & InterActive
```bash
  #r "nuget: StimulsoftReports.Engine.NetCore.PersianPdfExportere, 2024.1.3"
```

- Cake
```bash
  // Install StimulsoftReports.Engine.NetCore.PersianPdfExportere as a Cake Addin
     #addin nuget:?package=StimulsoftReports.Engine.NetCore.PersianPdfExporter&version=2024.1.3
  // Install StimulsoftReports.Engine.NetCore.PersianPdfExportere as a Cake Tool
     #tool nuget:?package=StimulsoftReports.Engine.NetCore.PersianPdfExporter&version=2024.1.3
```

## Supported Default Fonts

| FontName | Type     |
| :-------- | :------- |
| `+ Badr`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `A  Duel-Fat`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `A  Duel`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `A Aref_ graffiti`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `A Banoo Light`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `A Banoo Thin`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `A Hayat`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `A Jannat LT`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `A Kavir`| `.otf` |
| FontName | Type     |
| :-------- | :------- |
| `A Kavir`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `A MehdiHeydari`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `A Nahar-Bold`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `A Nahar-Medium`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `A Nahar`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `A Nasr`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `A RaiMedia-Black`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `A RaiMedia-Bold`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `A Sadeh`| `.otf` |
| FontName | Type     |
| :-------- | :------- |
| `A Sadeh`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `A Saray`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `A Sogand`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Adobe Arabic`| `.otf` |
| FontName | Type     |
| :-------- | :------- |
| `Afshid`| `.otf` |
| FontName | Type     |
| :-------- | :------- |
| `ArianLT-Bold`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `ArianLT-Demi`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `ArianLT-Heavy`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `ArianLT-Light`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `ArianLT-Regular`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Bahij Palatino Arabic`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Bahij Palatino Sans Arabic`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `BBCNassim`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Bieta`| `.otf` |
| FontName | Type     |
| :-------- | :------- |
| `Clother Black`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Clother Light`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Clother`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `dara- latin-banaei-conect`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `dara- latin-banaei`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `dara- latin`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Decora Arabic`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Dima Sogand new`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `DIN NEXT™ ARABIC BLACK`| `.otf` |
| FontName | Type     |
| :-------- | :------- |
| `DIN NEXT™ ARABIC BOLD`| `.otf` |
| FontName | Type     |
| :-------- | :------- |
| `DIN NEXT™ ARABIC HEAVY`| `.otf` |
| FontName | Type     |
| :-------- | :------- |
| `DIN NEXT™ ARABIC LIGHT`| `.otf` |
| FontName | Type     |
| :-------- | :------- |
| `DIN NEXT™ ARABIC MEDIUM`| `.otf` |
| FontName | Type     |
| :-------- | :------- |
| `DIN NEXT™ ARABIC REGULAR`| `.otf` |
| FontName | Type     |
| :-------- | :------- |
| `DIN NEXT™ ARABIC ULTRALIGHT`| `.otf` |
| FontName | Type     |
| :-------- | :------- |
| `DINArabic-Black`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `DINArabic-Bold`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `DINArabic-Cond`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `DINArabic-CondBlack`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `DINArabic-CondBold`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `DINArabic-CondExtlight`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `DINArabic-CondLight`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `DINArabic-CondMedium`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `DINArabic-CondThin`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `DINArabic-Extlight`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `DINArabic-Light`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `DINArabic-Medium`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `DINArabic`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `DiodrumArabic-Bold`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `DiodrumArabic-Extralight`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `DiodrumArabic-Light`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `DiodrumArabic-Medium`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `DiodrumArabic-Regular`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `DiodrumArabic-Semibold`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Dordaneh`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `FreeFarsi Monospace`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `FreeFarsi`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Gilan Bold`| `.otf` |
| FontName | Type     |
| :-------- | :------- |
| `Gilan Light`| `.otf` |
| FontName | Type     |
| :-------- | :------- |
| `Gilan Medium`| `.otf` |
| FontName | Type     |
| :-------- | :------- |
| `Hakim Ghazali`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `KindahBold-Bold`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `KindahRegular-Regular`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `KindahThin-Thin`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Nazli`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `NusaibahBold-Bold`| `.otf` |
| FontName | Type     |
| :-------- | :------- |
| `NusaibahRegular-Regular`| `.otf` |
| FontName | Type     |
| :-------- | :------- |
| `Palatino LT Arabic`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Palatino Sans Arabic Bold`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Palatino Sans`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Palatino`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Parastoo Print FD`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Parastoo Print`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Parvin`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Samim FD`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Samim`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `SG Kara SemiBold`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `SG Kara`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Shabnam FD`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Shabnam`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Tanha FD`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Tanha`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Terafik`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Thabit-Bold-Oblique`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Thabit-Bold`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Thabit-Oblique`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Thabit`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Vazir FD`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `Vazir`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Andalus`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Arabic`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Arash`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Aria`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Arshia`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Babak`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Badr`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Bam`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Bijan`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Davat`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Dorosht`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Elham`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Fantasy`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Farnaz`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Farsi`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Ferdosi`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Forouzan`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Gity`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Homa`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Jalal`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Johar`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Kamran`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Kaveh`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Kerman`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Khorsheed`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Koodak`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Kufi`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Mahsa`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Majid`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Mashgh`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Mitra`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Moj`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Morvarid`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Nahid`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Narm`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Naskh`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Nazanin`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Nima`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Nimrooz`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Paatch`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Persian`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Roya`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Sahra`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Shafigh`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Shiraz`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Simin`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Sina`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Sousan`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Tabassom`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Tawfig`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Termeh`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Thulth`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Tir`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Titre`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Traffic`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Vahid`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Vosta`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Yagut`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Yas`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Yekan`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Zar`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `X Ziba`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `XB Kayhan Navaar`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `XB Kayhan Pook`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `XB Kayhan Sayeh`| `.ttf` |
| FontName | Type     |
| :-------- | :------- |
| `XB Kayhan`| `.ttf` |


