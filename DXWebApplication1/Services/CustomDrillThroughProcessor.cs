using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using DevExpress.XtraReports.Services;
using DevExpress.XtraReports.Web.WebDocumentViewer;
//using System.Text.Json;
using Newtonsoft.Json;

namespace DXWebApplication1.Services
{
    public class NavigateInfo
    {
        public string NavigateTo { get; set; }
        public string MasterID { get; set; }
    }
    public class CustomDrillThroughProcessor : IDrillThroughProcessor
    {
        readonly IReportProvider reportProvider;

        public CustomDrillThroughProcessor(IReportProvider reportProvider)
        {
            this.reportProvider = reportProvider;
        }
        public DrillThroughResult CreateReport(DrillThroughContext context)
        {
            var data = context.CustomData;
            //NavigateInfo navigateInfo = JsonSerializer.Deserialize<NavigateInfo>(data);
            JavaScriptSerializer js = new JavaScriptSerializer();
            NavigateInfo navigateInfo = js.Deserialize<NavigateInfo>(data);

            var reportNameToOpen = navigateInfo.NavigateTo == "back" ? "MainReport"
                : navigateInfo.NavigateTo == "details" ? "DetailReport1" : null;
            var report = reportProvider.GetReport(reportNameToOpen, null) ?? context.Report;

            if (navigateInfo.NavigateTo == "details")
            {
                int catID = 0;
                Int32.TryParse(navigateInfo.MasterID, out catID);
                report.Parameters["categoryID"].Value = catID;
            }
            return new DrillThroughResult(report);
        }
    }
}