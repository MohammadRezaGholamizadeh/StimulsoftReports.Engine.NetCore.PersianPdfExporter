
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

- #### **SetCustomFont(font, alias, fontStyle)**
| Parameter | Type     | Description                                         |
| :-------- | :------- | :--------------------------------                   |
| `font`      | `byte[]` | **Required**. Font Bytes |
| `alias`      | `string?` | **Not Required**. Font Alies |
| `fontStyle`      | `FontStyle?` | **Not Required**. Font Style |

- #### **GetAllSettedFontsUntilNow()**
|Description                                                                   |
|:-------                                                                      |
|Get All Fonts That Be Setted Until Now    |


- #### **SetCustomFont(fontName, extension, fontContent, alias)**
| Parameter | Type     | Description                                         |
| :-------- | :------- | :--------------------------------                   |
| `fontName`      | `string` | **Required**. Font Name |
| `extension`      | `string` | **Required**. Font Extension |
| `fontContent`      | `byte[]` | **Required**. Font Content As Bytes[] |
| `alias`      | `string?` | **Not Required**. Font Alias |

Takes two numbers and returns the sum.


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

Clone the project

```bash
  git clone https://link-to-project
```

Go to the project directory

