using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BpcBI.DAL;
using DotNet.Highcharts;

public partial class WebUserControls_BarOptional_TotalSaleCoOptional : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string CategoryTheme = "CoThemeOptional";
        string statusPeriod = General.GetUserDefinedPeriod().Substring(2, 2);
        DataTable dtCoOptionalRial = BiDatabaseHandler.GetDataCoOptionalRial1(statusPeriod);
        Highcharts ChartLineCoOptionalRial = Charts.GetChartLine(dtCoOptionalRial, CategoryTheme, "ChartBarCoOptionalRial");
        ltrChartLineCoOptionalRial.Text = ChartLineCoOptionalRial.ToHtmlString();

        CategoryTheme = "CoThemeOptional";
        DataTable dtCoOptionalWeight = BiDatabaseHandler.GetDataCoOptionalWeight1(statusPeriod);
        Highcharts ChartLineCoOptionalWeight = Charts.GetChartLine(dtCoOptionalWeight, CategoryTheme, "ChartBarCoOptionalWeight");
        ltrChartLineCoOptionalWeight.Text = ChartLineCoOptionalWeight.ToHtmlString();
    }
}