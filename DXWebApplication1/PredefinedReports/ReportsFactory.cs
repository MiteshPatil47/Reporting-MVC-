using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DXWebApplication1.PredefinedReports
{
    public static class ReportsFactory
    {
        static ReportsFactory ()
        {
            Reports.Add("TestReport", () => new TestReport());
            Reports.Add("MainReport", () => new MainReport());
            Reports.Add("DetailReport1", () => new Details());
        }
        public static Dictionary<string, Func<XtraReport>> Reports = new Dictionary<string, Func<XtraReport>>();
    }
}