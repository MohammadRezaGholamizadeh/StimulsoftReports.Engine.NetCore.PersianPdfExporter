using Microsoft.Data.SqlClient;
using Stimulsoft.Base;
using Stimulsoft.Report.Design;
using Stimulsoft.Report.Dictionary;
using StimulsoftReports.Engine.NetCore.PersianPdfExporter.DtoFile;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Xml.Linq;

namespace StimulsoftReports.Engine.NetCore.PersianPdfExporter
{
    public static class StiReportEngineDataContent
    {

        public static StiReportResource AddDataContentAsDataSources(
           this StiReportResource tools,
           IDictionary<string, StiReportDataSource> datas)
        {
            try
            {
                foreach (var data in datas)
                {
                    tools.ReportEngine.ReportDataSources.Add(data.Key, data.Value);
                }
            }

            catch
            {
                throw;
            }

            return tools;
        }

        public static StiReportResource AddDataContentAsDataSource(
               this StiReportResource tools,
               StiReportDataSource data)
        {
            try
            {
                tools.ReportEngine.ReportDataSources.Add(data);
            }

            catch
            {
                throw;
            }

            return tools;
        }

        public static StiReportResource AddDataContentAsDataSource(
           this StiReportResource tools,
           string name,
           object data)
        {
            try
            {
                tools.ReportEngine.ReportDataSources.Add(name, data);
                tools.ReportEngine.Dictionary.DataStore.RegData(name, data);
                tools.ReportEngine.CompiledReport?.Dictionary?.DataStore?.RegData(name, data);
            }

            catch
            {
                throw;
            }

            return tools;
        }


        //
        // Summary:
        //     Registers an object in the Data Store.
        //
        // Parameters:
        //   name:
        //     DataTable name in the Data Store.
        //
        //   data:
        //     Data for registration.
        public static StiReportResource AddDataContent(
            this StiReportResource configuration,
            string name, object data)
        {
            configuration.ReportEngine.Dictionary.DataStore.RegData(name, data);
            configuration.ReportEngine.CompiledReport?.Dictionary?.DataStore?.RegData(name, data);
            return configuration;
        }

        //
        // Summary:
        //     Registers an object in the Data Store.
        //
        // Parameters:
        //   name:
        //     DataTable name in the Data Store.
        //
        //   dataTable:
        //     DataTable for registration.
        public static StiReportResource AddDataContent(
            this StiReportResource configuration,
            string name, DataTable dataTable)
        {
            configuration.ReportEngine.Dictionary.DataStore.RegData(name, dataTable);
            configuration.ReportEngine.CompiledReport?.Dictionary?.DataStore?.RegData(name, dataTable);
            return configuration;
        }

        //
        // Summary:
        //     Registers the DataTable in the Data Store.
        //
        // Parameters:
        //   dataTable:
        //     The DataTable for registration.
        public static StiReportResource AddDataContent(
            this StiReportResource configuration,
            DataTable dataTable)
        {
            configuration.ReportEngine.Dictionary.DataStore.RegData(dataTable);
            configuration.ReportEngine.CompiledReport?.Dictionary?.DataStore?.RegData(dataTable);
            return configuration;
        }

        //
        // Summary:
        //     Registers all DataTables and DataRelations which are in the specified DataSet
        //     in the Data Store.
        //
        // Parameters:
        //   name:
        //     Prefix for object registration.
        //
        //   dataSet:
        //     DataSet for registration.
        public static StiReportResource AddDataContent(
            this StiReportResource configuration,
            string name, DataSet dataSet)
        {
            configuration.ReportEngine.Dictionary.DataStore.RegData(name, dataSet);
            configuration.ReportEngine.CompiledReport?.Dictionary?.DataStore?.RegData(name, dataSet);
            return configuration;
        }

        //
        // Summary:
        //     Registers all DataTable and DataRelation which are in the specified DataSet in
        //     the Data Store.
        //
        // Parameters:
        //   dataSet:
        //     DataSet for registration.
        public static StiReportResource AddDataContent(
            this StiReportResource configuration,
            DataSet dataSet)
        {
            configuration.ReportEngine.Dictionary.DataStore.RegData(dataSet);
            configuration.ReportEngine.CompiledReport?.Dictionary?.DataStore?.RegData(dataSet);
            return configuration;
        }

        //
        // Summary:
        //     Registers the DataCollection in the DataStore of the report.
        //
        // Parameters:
        //   element:
        //     XElement for registration.
        //
        //   relationDirection:
        //     Specifies direction of the relation processing.
        public static StiReportResource AddDataContent(
            this StiReportResource configuration,
            XElement element,
            StiRelationDirection relationDirection = StiRelationDirection.ParentToChild)
        {
            DataSet dataSet =
                ((StiBaseOptions.DefaultJsonConverterVersion == StiJsonConverterVersion.ConverterV2)
                ? StiJsonToDataSetConverterV2.GetDataSet(element, relationDirection)
                : StiJsonToDataSetConverter.GetDataSet(element));
            configuration.ReportEngine.RegData(dataSet);
            return configuration;
        }

        //
        // Summary:
        //     Registers the DataCollection in the DataStore of the report.
        //
        // Parameters:
        //   name:
        //     Prefix for object registration.
        //
        //   element:
        //     XElement for registration.
        //
        //   relationDirection:
        //     Specifies direction of the relation processing.
        public static StiReportResource AddDataContent(
            this StiReportResource configuration,
            string name,
            XElement element,
            StiRelationDirection relationDirection = StiRelationDirection.ParentToChild)
        {
            DataSet dataSet =
                ((StiBaseOptions.DefaultJsonConverterVersion == StiJsonConverterVersion.ConverterV2)
                ? StiJsonToDataSetConverterV2.GetDataSet(element, relationDirection)
                : StiJsonToDataSetConverter.GetDataSet(element));
            configuration.ReportEngine.RegData(name, dataSet);
            return configuration;
        }

        //
        // Summary:
        //     Registers DataView in the Data Store.
        //
        // Parameters:
        //   name:
        //     DataView name in the Data Store.
        //
        //   dataView:
        //     DataView for registration.
        public static StiReportResource AddDataContent(
            this StiReportResource configuration,
            string name, DataView dataView)
        {
            configuration.ReportEngine.Dictionary.DataStore.RegData(name, dataView);
            configuration.ReportEngine.CompiledReport?.Dictionary?.DataStore?.RegData(name, dataView);
            return configuration;
        }

        //
        // Summary:
        //     Registers DataView in the Data Store.
        //
        // Parameters:
        //   dataView:
        //     DataView for registration.
        public static StiReportResource AddDataContent(
            this StiReportResource configuration,
            DataView dataView)
        {
            configuration.ReportEngine.Dictionary.DataStore.RegData(dataView);
            configuration.ReportEngine.CompiledReport?.Dictionary?.DataStore?.RegData(dataView);
            return configuration;
        }

        //
        // Summary:
        //     Registers SqlConnection in the Data Store.
        //
        // Parameters:
        //   name:
        //     SqlConnection name in the Data Store.
        //
        //   connection:
        //     SqlConnection for registration.
        public static StiReportResource AddDataContent(
            this StiReportResource configuration,
            string name, SqlConnection connection)
        {
            configuration.ReportEngine.Dictionary.DataStore.RegData(name, connection);
            configuration.ReportEngine.CompiledReport?.Dictionary?.DataStore?.RegData(name, connection);
            return configuration;
        }

        //
        // Summary:
        //     Registers OleDbConnection in the Data Store.
        //
        // Parameters:
        //   name:
        //     OleDbConnection name in the Data Store.
        //
        //   connection:
        //     OleDbConnection for registration.
        public static StiReportResource AddDataContent(
            this StiReportResource configuration,
            string name, OleDbConnection connection)
        {
            configuration.ReportEngine.Dictionary.DataStore.RegData(name, connection);
            configuration.ReportEngine.CompiledReport?.Dictionary?.DataStore?.RegData(name, connection);
            return configuration;
        }

        //
        // Summary:
        //     Registers OdbcConnection in the Data Store.
        //
        // Parameters:
        //   name:
        //     OdbcConnection name in the Data Store.
        //
        //   connection:
        //     OdbcConnection for registration.
        public static StiReportResource AddDataContent(
            this StiReportResource configuration,
            string name, OdbcConnection connection)
        {
            configuration.ReportEngine.Dictionary.DataStore.RegData(name, connection);
            configuration.ReportEngine.CompiledReport?.Dictionary?.DataStore?.RegData(name, connection);
            return configuration;
        }

        //
        // Summary:
        //     Registers an object in the Data Store.
        //
        // Parameters:
        //   name:
        //     A data name in the Data Store.
        //
        //   alias:
        //     A data alias in the Data Store.
        //
        //   data:
        //     The object for registration.
        public static StiReportResource AddDataContent(
            this StiReportResource configuration,
            string name, string alias, object data)
        {
            configuration.ReportEngine.Dictionary.DataStore.RegData(name, alias, data);
            configuration.ReportEngine.CompiledReport?.Dictionary?.DataStore?.RegData(name, alias, data);
            return configuration;
        }

        //
        // Summary:
        //     Registers an object in the Data Store.
        //
        // Parameters:
        //   name:
        //     A data name in the Data Store.
        //
        //   alias:
        //     A data alias in the Data Store.
        //
        //   dataTable:
        //     DataTable for registration.
        public static StiReportResource AddDataContent(
            this StiReportResource configuration,
            string name, string alias, DataTable dataTable)
        {
            configuration.ReportEngine.Dictionary.DataStore.RegData(name, alias, dataTable);
            configuration.ReportEngine.CompiledReport?.Dictionary?.DataStore?.RegData(name, alias, dataTable);
            return configuration;
        }

        //
        // Summary:
        //     Registers all DataTables and DataRelations which are in the specified DataSet
        //     in the Data Store.
        //
        // Parameters:
        //   name:
        //     A data name in the Data Store.
        //
        //   alias:
        //     A data alias in the Data Store.
        //
        //   dataSet:
        //     DataSet for registration.
        public static StiReportResource AddDataContent(
            this StiReportResource configuration,
            string name,
            string alias,
            DataSet dataSet)
        {
            configuration.ReportEngine.Dictionary.DataStore.RegData(name, alias, dataSet);
            configuration.ReportEngine.CompiledReport?.Dictionary?.DataStore?.RegData(name, alias, dataSet);
            return configuration;
        }

        //
        // Summary:
        //     Registers DataView in the Data Store.
        //
        // Parameters:
        //   name:
        //     A data name in the Data Store.
        //
        //   alias:
        //     A data alias in the Data Store.
        //
        //   dataView:
        //     DataView for registration.
        public static StiReportResource AddDataContent(
            this StiReportResource configuration,
            string name,
            string alias,
            DataView dataView)
        {
            configuration.ReportEngine.Dictionary.DataStore.RegData(name, alias, dataView);
            configuration.ReportEngine.CompiledReport?.Dictionary?.DataStore?.RegData(name, alias, dataView);
            return configuration;
        }

        //
        // Summary:
        //     Registers SqlConnection in the Data Store.
        //
        // Parameters:
        //   name:
        //     A data name in the Data Store.
        //
        //   alias:
        //     A data alias in the Data Store.
        //
        //   connection:
        //     SqlConnection for registration.
        public static StiReportResource AddDataContent(
            this StiReportResource configuration,
            string name,
            string alias,
            SqlConnection connection)
        {
            configuration.ReportEngine.Dictionary.DataStore.RegData(name, alias, connection);
            configuration.ReportEngine.CompiledReport?.Dictionary?.DataStore?.RegData(name, alias, connection);
            return configuration;
        }

        //
        // Summary:
        //     Registers OleDbConnection in the Data Store.
        //
        // Parameters:
        //   name:
        //     A data name in the Data Store.
        //
        //   alias:
        //     A data alias in the Data Store.
        //
        //   connection:
        //     OleDbConnection for registration.
        public static StiReportResource AddDataContent(
            this StiReportResource configuration,
            string name,
            string alias,
            OleDbConnection connection)
        {
            configuration.ReportEngine.Dictionary.DataStore.RegData(name, alias, connection);
            configuration.ReportEngine.CompiledReport?.Dictionary?.DataStore?.RegData(name, alias, connection);
            return configuration;
        }

        //
        // Summary:
        //     Registers OdbcConnection in the Data Store.
        //
        // Parameters:
        //   name:
        //     A data name in the Data Store.
        //
        //   alias:
        //     A data alias in the Data Store.
        //
        //   connection:
        //     OdbcConnection for registration.
        public static StiReportResource AddDataContent(
            this StiReportResource configuration,
            string name,
            string alias,
            OdbcConnection connection)
        {
            configuration.ReportEngine.DataStore.RegData(name, alias, connection);
            configuration.ReportEngine.CompiledReport?.Dictionary?.DataStore?.RegData(name, alias, connection);
            return configuration;
        }

        //
        // Summary:
        //     Registers the DataCollection in the DataStore of the report.
        //
        // Parameters:
        //   datas:
        //     DataCollection for registration.
        public static StiReportResource AddDataContent(
            this StiReportResource configuration,
            StiDataCollection datas)
        {
            configuration.ReportEngine.Dictionary.DataStore.RegData(datas);
            configuration.ReportEngine.CompiledReport?.Dictionary?.DataStore?.RegData(datas);
            return configuration;
        }


        public static StiReportResource AddDataContentAsBusinessObject(
            this StiReportResource tools,
            string name,
            dynamic data)
        {
            try
            {
                tools.ReportEngine.RegBusinessObject(name, data);
            }
            catch
            {
                throw;
            }

            return tools;
        }

        public static StiReportResource AddDataContentAsBusinessObjects(
           this StiReportResource tools,
           IList<StiBusinessObjectData> datas)
        {
            try
            {
                tools.ReportEngine.RegBusinessObject(datas as List<StiBusinessObjectData>);
            }
            catch
            {
                throw;
            }

            return tools;
        }

        public static StiReportResource AddDataContentAsBusinessObjects(
            this StiReportResource tools,
            IDictionary<string, dynamic> datas)
        {
            try
            {
                foreach (var data in datas)
                {
                    tools.ReportEngine.RegBusinessObject(data.Key, data.Value);
                }
            }
            catch
            {
                throw;
            }

            return tools;
        }
    }
}