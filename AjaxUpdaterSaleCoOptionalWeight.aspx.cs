using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BpcBI.DAL;
using DotNet.Highcharts.Options;
using Newtonsoft.Json;

public partial class AjaxUpdaterSaleCoOptionalWeight : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string CategoryTheme = "";
        string statusPeriod = General.GetUserDefinedPeriod().Substring(2, 2);

        if (!string.IsNullOrEmpty((Request.QueryString["type"] ?? "").ToString()))
        {
            //= HttpUtility.UrlEncode(Request.QueryString["P1"].ToString());
            if (HttpUtility.UrlEncode(Request.QueryString["type"].ToString()) == "1")
            {
                DataTable dtCoOptionalWeight = BiDatabaseHandler.GetDataCoOptionalWeight1(statusPeriod);
                List<Series> seri = ChartSeries.GetChartSeri(dtCoOptionalWeight, "CoThemeOptional");

                string json = JsonConvert.SerializeObject(seri);

                Response.Clear();
                Response.ContentType = "application/json; charset=utf-8";
                Response.Write(json);
                Response.End();
            }
            if (HttpUtility.UrlEncode(Request.QueryString["type"].ToString()) == "2")
            {
                
                DataTable dtCoOptionalWeight = BiDatabaseHandler.GetDataCoOptionalWeight2(statusPeriod);
                List<Series> seri = ChartSeries.GetChartSeri(dtCoOptionalWeight, "PaxanThemeOptional");

                string json = JsonConvert.SerializeObject(seri);

                Response.Clear();
                Response.ContentType = "application/json; charset=utf-8";
                Response.Write(json);
                Response.End();
            }
            if (HttpUtility.UrlEncode(Request.QueryString["type"].ToString()) == "3")
            {
                DataTable dtCoOptionalWeight = BiDatabaseHandler.GetDataCoOptionalWeight3(statusPeriod);
                List<Series> seri = ChartSeries.GetChartSeri(dtCoOptionalWeight, "AriamelalThemeOptional");

                string json = JsonConvert.SerializeObject(seri);

                Response.Clear();
                Response.ContentType = "application/json; charset=utf-8";
                Response.Write(json);
                Response.End();
            }
            if (HttpUtility.UrlEncode(Request.QueryString["type"].ToString()) == "4")
            {
                DataTable dtCoOptionalWeight = BiDatabaseHandler.GetDataCoOptionalWeight4(statusPeriod);
                List<Series> seri = ChartSeries.GetChartSeri(dtCoOptionalWeight, "MasoulehThemeOptional");

                string json = JsonConvert.SerializeObject(seri);

                Response.Clear();
                Response.ContentType = "application/json; charset=utf-8";
                Response.Write(json);
                Response.End();
            }
            if (HttpUtility.UrlEncode(Request.QueryString["type"].ToString()) == "5")
            {
                DataTable dtCoOptionalWeight = BiDatabaseHandler.GetDataCoOptionalWeight5(statusPeriod);
                List<Series> seri = ChartSeries.GetChartSeri(dtCoOptionalWeight, "OtherThemeOptional");

                string json = JsonConvert.SerializeObject(seri);

                Response.Clear();
                Response.ContentType = "application/json; charset=utf-8";
                Response.Write(json);
                Response.End();
            }
            if (HttpUtility.UrlEncode(Request.QueryString["type"].ToString()) == "6")
            {
                DataTable dtCoOptionalWeight = BiDatabaseHandler.GetDataCoOptionalWeight6(statusPeriod);
                List<Series> seri = ChartSeries.GetChartSeri(dtCoOptionalWeight, "AftabThemeOptional");

                string json = JsonConvert.SerializeObject(seri);

                Response.Clear();
                Response.ContentType = "application/json; charset=utf-8";
                Response.Write(json);
                Response.End();
            }
            if (HttpUtility.UrlEncode(Request.QueryString["type"].ToString()) == "7")
            {
                DataTable dtCoOptionalWeight = BiDatabaseHandler.GetDataCoOptionalWeight7(statusPeriod);
                List<Series> seri = ChartSeries.GetChartSeri(dtCoOptionalWeight, "parsshahabThemeOptional");

                string json = JsonConvert.SerializeObject(seri);

                Response.Clear();
                Response.ContentType = "application/json; charset=utf-8";
                Response.Write(json);
                Response.End();
            }
            if (HttpUtility.UrlEncode(Request.QueryString["type"].ToString()) == "8")
            {
                DataTable dtCoOptionalWeight = BiDatabaseHandler.GetDataCoOptionalWeight8(statusPeriod);
                List<Series> seri = ChartSeries.GetChartSeri(dtCoOptionalWeight, "behpakThemeOptional");

                string json = JsonConvert.SerializeObject(seri);

                Response.Clear();
                Response.ContentType = "application/json; charset=utf-8";
                Response.Write(json);
                Response.End();
            }
        }
    }
}