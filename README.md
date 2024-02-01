
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

  AddCustomFontBytes(font, alias, fontStyle);

  AddCustomFontsBytes(fonts);

  AddCustomFontFile(font);

  AddCustomFontFiles(fonts);

  AddCustomFontResource(font);

  AddCustomFontResources(fonts);

  GetAllSettedFontsUntilNow();

  SetMrtFile(mrtFileBytes);

  AddDataContentAsBusinessObject(name, data);

  Render(showProgressState);

  ExportPdfToPath(absolutePath);

  ExportPdfAsMemoryStream(settings);

  ExportPdfAsCustomStream(customStream, settings);



  AddDataContentAsDataSource(StiReportDataSource data);     => Has 2 OverLoads Methods

  AddDataContent(name,data);                                => Has 19 OverLoad Methods

  AddDataContentAsBusinessObject(name, data)                => Has 3 OverLoad Methods
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

- #### **AddCustomFontByte(font, alias, fontStyle)**
| Parameter | Type     | Description                                         |
| :-------- | :------- | :--------------------------------                   |
| `font`      | `byte[]` | **Required**. Font Bytes |
| `alias`      | `string?` | **Not Required**. Font Alies |
| `fontStyle`      | `FontStyle?` | **Not Required**. Font Style |

**Method Description** : This Method Used For Set Custom Font (Client Choice) To Stimulsoft Report Engine.

- #### **AddCustomFontByte(fonts)**
| Parameter | Type     | Description                                         |
| :-------- | :------- | :--------------------------------                   |
| `fonts`      | `IList<byte[]>` | **Required**. Fonts Bytes |

**Method Description** : This Method Used For Set Custom Font (Client Choice) To Stimulsoft Report Engine.


- #### **AddCustomFontFile(font)**
| Parameter | Type     | Description                                         |
| :-------- | :------- | :--------------------------------                   |
| `font`      | `CustomFontFile` | **Required**. Dto Object With Font Details That You Want To Add |

**Method Description** : This Method Used For Set Custom Font (Client Choice) To Stimulsoft Report Engine.

- #### **AddCustomFontFiles(fonts)**
| Parameter | Type     | Description                                         |
| :-------- | :------- | :--------------------------------                   |
| `fonts`      | `IList<CustomFontFile>` | **Required**. Dto Objects With Font Details That You Want To Add |

**Method Description** : This Method Used For Set Custom Font (Client Choice) To Stimulsoft Report Engine.

- #### **AddCustomFontResource(font)**
| Parameter | Type     | Description                                         |
| :-------- | :------- | :--------------------------------                   |
| `font`      | `CustomFontResource` | **Required**. Dto Objects With Font Details That You Want To Add |

**Method Description** : This Method Used For Set Custom Font (Client Choice) To Stimulsoft Report Engine.

- #### **AddCustomFontResources(fonts)**
| Parameter | Type     | Description                                         |
| :-------- | :------- | :--------------------------------                   |
| `fonts`      | `IList<CustomFontResource>` | **Required**. Dto Objects With Font Details That You Want To Add |

**Method Description** : This Method Used For Set Custom Font (Client Choice) To Stimulsoft Report Engine.

- #### **AddCustomFont(fontName, extension, fontContent, alias)**
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


- #### **AddDataContentAsBusinessObjects(datas);**
| Parameter | Type     | Description                                         |
| :-------- | :------- | :--------------------------------                   |
| `datas`      | `IList<StiBusinessObjectData>` | **Required**. Name Of Business Objects Data That You Created In Stimulsoft Designer|

**Method Description** : This Method Used For Set Datas That You Want To Export In PDF To Stimulsoft Report Engine.


- #### **AddDataContentAsBusinessObject(name, data);**
| Parameter | Type     | Description                                         |
| :-------- | :------- | :--------------------------------                   |
| `datas`      | `IDictionary<string, dynamic> datas` | **Required**. Name Of Business Objects Data That You Created In Stimulsoft Designer|

**Method Description** : This Method Used For Set Datas That You Want To Export In PDF To Stimulsoft Report Engine.

- #### **AddDataContentAsDataSources(data);**
| Parameter | Type     | Description                                         |
| :-------- | :------- | :--------------------------------                   |
| `datas`      | `IDictionary<string, StiReportDataSource>` | **Required**. Datas Of DataSources That You Created In Stimulsoft Designer|

**Method Description** : This Method Used For Set Datas That You Want To Export In PDF To Stimulsoft Report Engine.


- #### **AddDataContentAsDataSource(data);**
| Parameter | Type     | Description                                         |
| :-------- | :------- | :--------------------------------                   |
| `data`      | `StiReportDataSource` | **Required**. Data Of DataSource That You Created In Stimulsoft Designer|

**Method Description** : This Method Used For Set Datas That You Want To Export In PDF To Stimulsoft Report Engine.

- #### **AddDataContentAsDataSource(name, data);**
| Parameter | Type     | Description                                         |
| :-------- | :------- | :--------------------------------                   |
| `name`      | `string` | **Required**. Name Of DataSource That You Created In Stimulsoft Designer|
| `data`      | `object` | **Required**. Data Of DataSource That You Created In Stimulsoft Designer|

**Method Description** : This Method Used For Set Datas That You Want To Export In PDF To Stimulsoft Report Engine.


- #### **AddDataContent(name, data);**
| Parameter | Type     | Description                                         |
| :-------- | :------- | :--------------------------------                   |
| `name`      | `string` | **Required**. Name Of DataContent That You Created In Stimulsoft Designer|
| `data`      | `object` | **Required**. Data Of DataContent That You Created In Stimulsoft Designer|

**Method Description** : This Method Used For Set Datas That You Want To Export In PDF To Stimulsoft Report Engine.


- #### **AddDataContent(name, data);**
| Parameter | Type     | Description                                         |
| :-------- | :------- | :--------------------------------                   |
| `name`      | `string` | **Required**. DataTable name in the Data Store.|
| `dataTable`      | `DataTable` | **Required**. DataTable for registration |

**Method Description** :  Registers an object in the Data Store.

- #### **AddDataContent(data);**
| Parameter | Type     | Description                                         |
| :-------- | :------- | :--------------------------------                   |
| `dataSet`      | `DataSet` | **Required**. DataSet for registration.       |
| `name`      | `string` | **Required**.  Prefix for object registration.    |

**Method Description** :  Registers all DataTables and DataRelations which are in the specified DataSet in the Data Store.

- #### **AddDataContent(data);**
| Parameter | Type     | Description                                         |
| :-------- | :------- | :--------------------------------                   |
| `name`      | `string` | **Required**.  Prefix for object registration.    |

**Method Description** :  Registers an object in the Data Store.


- #### **Render(showProgressState)**
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
| `A  Duel-Fat`| `.ttf` |
| `A  Duel`| `.ttf` |
| `A Aref_ graffiti`| `.ttf` |
| `A Banoo Light`| `.ttf` |
| `A Banoo Thin`| `.ttf` |
| `A Hayat`| `.ttf` |
| `A Jannat LT`| `.ttf` |
| `A Kavir`| `.otf` |
| `A Kavir`| `.ttf` |
| `A MehdiHeydari`| `.ttf` |
| `A Nahar-Bold`| `.ttf` |
| `A Nahar-Medium`| `.ttf` |
| `A Nahar`| `.ttf` |
| `A Nasr`| `.ttf` |
| `A RaiMedia-Black`| `.ttf` |
| `A RaiMedia-Bold`| `.ttf` |
| `A Sadeh`| `.otf` |
| `A Sadeh`| `.ttf` |
| `A Saray`| `.ttf` |
| `A Sogand`| `.ttf` |
| `Adobe Arabic`| `.otf` |
| `Afshid`| `.otf` |
| `ArianLT-Bold`| `.ttf` |
| `ArianLT-Demi`| `.ttf` |
| `ArianLT-Heavy`| `.ttf` |
| `ArianLT-Light`| `.ttf` |
| `ArianLT-Regular`| `.ttf` |
| `Bahij Palatino Arabic`| `.ttf` |
| `Bahij Palatino Sans Arabic`| `.ttf` |
| `BBCNassim`| `.ttf` |
| `Bieta`| `.otf` |
| `Clother Black`| `.ttf` |
| `Clother Light`| `.ttf` |
| `Clother`| `.ttf` |
| `dara- latin-banaei-conect`| `.ttf` |
| `dara- latin-banaei`| `.ttf` |
| `dara- latin`| `.ttf` |
| `Decora Arabic`| `.ttf` |
| `Dima Sogand new`| `.ttf` |
| `DIN NEXT™ ARABIC BLACK`| `.otf` |
| `DIN NEXT™ ARABIC BOLD`| `.otf` |
| `DIN NEXT™ ARABIC HEAVY`| `.otf` |
| `DIN NEXT™ ARABIC LIGHT`| `.otf` |
| `DIN NEXT™ ARABIC MEDIUM`| `.otf` |
| `DIN NEXT™ ARABIC REGULAR`| `.otf` |
| `DIN NEXT™ ARABIC ULTRALIGHT`| `.otf` |
| `DINArabic-Black`| `.ttf` |
| `DINArabic-Bold`| `.ttf` |
| `DINArabic-Cond`| `.ttf` |
| `DINArabic-CondBlack`| `.ttf` |
| `DINArabic-CondBold`| `.ttf` |
| `DINArabic-CondExtlight`| `.ttf` |
| `DINArabic-CondLight`| `.ttf` |
| `DINArabic-CondMedium`| `.ttf` |
| `DINArabic-CondThin`| `.ttf` |
| `DINArabic-Extlight`| `.ttf` |
| `DINArabic-Light`| `.ttf` |
| `DINArabic-Medium`| `.ttf` |
| `DINArabic`| `.ttf` |
| `DiodrumArabic-Bold`| `.ttf` |
| `DiodrumArabic-Extralight`| `.ttf` |
| `DiodrumArabic-Light`| `.ttf` |
| `DiodrumArabic-Medium`| `.ttf` |
| `DiodrumArabic-Regular`| `.ttf` |
| `DiodrumArabic-Semibold`| `.ttf` |
| `Dordaneh`| `.ttf` |
| `FreeFarsi Monospace`| `.ttf` |
| `FreeFarsi`| `.ttf` |
| `Gilan Bold`| `.otf` |
| `Gilan Light`| `.otf` |
| `Gilan Medium`| `.otf` |
| `Hakim Ghazali`| `.ttf` |
| `KindahBold-Bold`| `.ttf` |
| `KindahRegular-Regular`| `.ttf` |
| `KindahThin-Thin`| `.ttf` |
| `Nazli`| `.ttf` |
| `NusaibahBold-Bold`| `.otf` |
| `NusaibahRegular-Regular`| `.otf` |
| `Palatino LT Arabic`| `.ttf` |
| `Palatino Sans Arabic Bold`| `.ttf` |
| `Palatino Sans`| `.ttf` |
| `Palatino`| `.ttf` |
| `Parastoo Print FD`| `.ttf` |
| `Parastoo Print`| `.ttf` |
| `Parvin`| `.ttf` |
| `Samim FD`| `.ttf` |
| `Samim`| `.ttf` |
| `SG Kara SemiBold`| `.ttf` |
| `SG Kara`| `.ttf` |
| `Shabnam FD`| `.ttf` |
| `Shabnam`| `.ttf` |
| `Tanha FD`| `.ttf` |
| `Tanha`| `.ttf` |
| `Terafik`| `.ttf` |
| `Thabit-Bold-Oblique`| `.ttf` |
| `Thabit-Bold`| `.ttf` |
| `Thabit-Oblique`| `.ttf` |
| `Thabit`| `.ttf` |
| `Vazir FD`| `.ttf` |
| `Vazir`| `.ttf` |
| `X Andalus`| `.ttf` |
| `X Arabic`| `.ttf` |
| `X Arash`| `.ttf` |
| `X Aria`| `.ttf` |
| `X Arshia`| `.ttf` |
| `X Babak`| `.ttf` |
| `X Badr`| `.ttf` |
| `X Bam`| `.ttf` |
| `X Bijan`| `.ttf` |
| `X Davat`| `.ttf` |
| `X Dorosht`| `.ttf` |
| `X Elham`| `.ttf` |
| `X Fantasy`| `.ttf` |
| `X Farnaz`| `.ttf` |
| `X Farsi`| `.ttf` |
| `X Ferdosi`| `.ttf` |
| `X Forouzan`| `.ttf` |
| `X Gity`| `.ttf` |
| `X Homa`| `.ttf` |
| `X Jalal`| `.ttf` |
| `X Johar`| `.ttf` |
| `X Kamran`| `.ttf` |
| `X Kaveh`| `.ttf` |
| `X Kerman`| `.ttf` |
| `X Khorsheed`| `.ttf` |
| `X Koodak`| `.ttf` |
| `X Kufi`| `.ttf` |
| `X Mahsa`| `.ttf` |
| `X Majid`| `.ttf` |
| `X Mashgh`| `.ttf` |
| `X Mitra`| `.ttf` |
| `X Moj`| `.ttf` |
| `X Morvarid`| `.ttf` |
| `X Nahid`| `.ttf` |
| `X Narm`| `.ttf` |
| `X Naskh`| `.ttf` |
| `X Nazanin`| `.ttf` |
| `X Nima`| `.ttf` |
| `X Nimrooz`| `.ttf` |
| `X Paatch`| `.ttf` |
| `X Persian`| `.ttf` |
| `X Roya`| `.ttf` |
| `X Sahra`| `.ttf` |
| `X Shafigh`| `.ttf` |
| `X Shiraz`| `.ttf` |
| `X Simin`| `.ttf` |
| `X Sina`| `.ttf` |
| `X Sousan`| `.ttf` |
| `X Tabassom`| `.ttf` |
| `X Tawfig`| `.ttf` |
| `X Termeh`| `.ttf` |
| `X Thulth`| `.ttf` |
| `X Tir`| `.ttf` |
| `X Titre`| `.ttf` |
| `X Traffic`| `.ttf` |
| `X Vahid`| `.ttf` |
| `X Vosta`| `.ttf` |
| `X Yagut`| `.ttf` |
| `X Yas`| `.ttf` |
| `X Yekan`| `.ttf` |
| `X Zar`| `.ttf` |
| `X Ziba`| `.ttf` |
| `XB Kayhan Navaar`| `.ttf` |
| `XB Kayhan Pook`| `.ttf` |
| `XB Kayhan Sayeh`| `.ttf` |
| `XB Kayhan`| `.ttf` |


