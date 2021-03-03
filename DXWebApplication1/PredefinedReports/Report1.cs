using DevExpress.DataAccess.Sql.DataApi;
using DevExpress.XtraReports.UI;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace DXWebApplication1.PredefinedReports
{
    public partial class Report1 : DevExpress.XtraReports.UI.XtraReport
    {
        public Report1()
        {
            InitializeComponent();
        }
        // Save the data for the current category to the label's Tag property.
        //private void xrLabel6_BeforePrint(object sender, PrintEventArgs e)
        //{
        //    ((XRLabel)sender).Tag = GetCurrentRow();
        //}
        //private void tableCell6_PreviewClick(object sender, PreviewMouseEventArgs e)
        //{ // Create a new Detail Report instance.
        //    Details detailReport = new Details();

        //    // Obtain the current category's ID and Name from the e.Brick.Value property,
        //    // which stores an object assigned to the label's Tag property.
        //    IRow row = (IRow)e.Brick.Value;
        //    // Obtain the current category's ID and Name from the row object.
        //    detailReport.Parameters["catId"].Value = row["CategoryID"];
        //    detailReport.Parameters["catName"].Value = row["CategoryName"];

        //    // Show the detail report in a new modal window.
        //    //ReportPrintTool pt = new ReportPrintTool(detailReport);
        //    //pt.ShowPreviewDialog();

        //}
    }
}
