
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
  dotnet add package Stimulsoft.Reports.Engine.NetCore --version 2024.1.3
```

- Package Manager
```bash
  NuGet\Install-Package Stimulsoft.Reports.Engine.NetCore -Version 2024.1.3
```

- Package Reference
```bash
  <PackageReference Include="Stimulsoft.Reports.Engine.NetCore" Version="2024.1.3" />
```

- Packet CLI
```bash
  paket add Stimulsoft.Reports.Engine.NetCore --version 2024.1.3
```

- Script & InterActive
```bash
  #r "nuget: Stimulsoft.Reports.Engine.NetCore, 2024.1.3"
```

- Cake
```bash
  // Install Stimulsoft.Reports.Engine.NetCore as a Cake Addin
     #addin nuget:?package=Stimulsoft.Reports.Engine.NetCore&version=2024.1.3
  // Install Stimulsoft.Reports.Engine.NetCore as a Cake Tool
     #tool nuget:?package=Stimulsoft.Reports.Engine.NetCore&version=2024.1.3
```

Be Lucky !!!

