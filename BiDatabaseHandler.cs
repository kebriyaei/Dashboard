using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using BpcBI.DAL.Models;
using System.Configuration;
using System.Globalization;


namespace BpcBI.DAL
{
    public class BiDatabaseHandler
    {
        public static string GetConnectionStringDashboard()
        {
            string Conn = ConfigurationManager.ConnectionStrings["WEBSERVERConnectionString"].ConnectionString;
            return Conn;
        }
        public static string GetConnectionStringPercentage()
        {
            string Conn = ConfigurationManager.ConnectionStrings["PercentageConnectionString"].ConnectionString;
            return Conn;
        }
        public PeriodInfo GetPeriod(string statusPeriod)
        {
            string Y_statusPeriod = "Y_" + statusPeriod;
            if (Y_statusPeriod == "Y_14")
            {
                var newPeriodInfo = new PeriodInfo
                {
                    CoNo = "006",
                    PeriodNo = "14",
                    YearNow = "2017",
                    YearPre = "2016",
                    strYearNow = "95-96 سال",
                    strYearPre = "94-95 سال",
                    strTargetNow = "95-96 هدف",
                    strTargetPre = "94-95 هدف"
                };
                return newPeriodInfo;
            }
            else if (Y_statusPeriod == "Y_13")
            {
                var newPeriodInfo = new PeriodInfo
                {
                    CoNo = "006",
                    PeriodNo = "13",
                    YearNow = "2016",
                    YearPre = "2015",
                    strYearNow = "94-95 سال",
                    strYearPre = "93-94 سال",
                    strTargetNow = "94-95 هدف",
                    strTargetPre = "93-94 هدف"
                };
                return newPeriodInfo;
            }
            else if (Y_statusPeriod == "Y_12")
            {
                var newPeriodInfo = new PeriodInfo
                {
                    CoNo = "006",
                    PeriodNo = "12",
                    YearNow = "2015",
                    YearPre = "2014",
                    strYearNow = "93-94 سال",
                    strYearPre = "92-93 سال",
                    strTargetNow = "93-94 هدف",
                    strTargetPre = "92-93 هدف"
                };
                return newPeriodInfo;
            }
            else if (Y_statusPeriod == "Y_11")
            {
                var newPeriodInfo = new PeriodInfo
                {
                    CoNo = "006",
                    PeriodNo = "11",
                    YearNow = "2014",
                    YearPre = "2013",
                    strYearNow = "92-93 سال",
                    strYearPre = "91-92 سال",
                    strTargetNow = "92-93 هدف",
                    strTargetPre = "91-92 هدف"
                };
                return newPeriodInfo;
            }
            else
            {
                var newPeriodInfo = new PeriodInfo
                {
                    CoNo = "006",
                    PeriodNo = "14",
                    YearNow = "2017",
                    YearPre = "2016",
                    strYearNow = "95-96 سال",
                    strYearPre = "94-95 سال",
                    strTargetNow = "95-96 هدف",
                    strTargetPre = "94-95 هدف"
                };
                return newPeriodInfo;
            }
        }

        public static string toPersianNumber(string input)
        {
            //string[] persian = new string[10] { "0", "1", "2", "3", "4", "", "6", "7", "8", "9" };// "۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹"

            input = input.Replace("0", "۰");
            input = input.Replace("1", "۱");
            input = input.Replace("2", "۲");
            input = input.Replace("3", "۳");
            input = input.Replace("4", "۴");
            input = input.Replace("5", "۵");
            input = input.Replace("6", "۶");
            input = input.Replace("7", "۷");
            input = input.Replace("8", "۸");
            input = input.Replace("9", "۹");
            return input;
        }

        public static string toEnglishNumber(string input)
        {
            //string[] persian = new string[10] { "0", "1", "2", "3", "4", "", "6", "7", "8", "9" };// "۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹"

            input = input.Replace("۰", "0");
            input = input.Replace("۱", "1");
            input = input.Replace("۲", "2");
            input = input.Replace("۳", "3");
            input = input.Replace("۴", "4");
            input = input.Replace("۵", "5");
            input = input.Replace("۶", "6");
            input = input.Replace("۷", "7");
            input = input.Replace("۸", "8");
            input = input.Replace("۹", "9");
            return input;
        }
        public static string SelectDate()
        {
            var pcalendar = new PersianCalendar();
            int dayP = pcalendar.GetDayOfMonth(DateTime.Now);
            int monthP = pcalendar.GetMonth(DateTime.Now);
            int yearP = pcalendar.GetYear(DateTime.Now);
            string mp = monthP.ToString(CultureInfo.InvariantCulture);
            string dp = dayP.ToString(CultureInfo.InvariantCulture);
            if (monthP < 10)
            {
                mp = "0" + monthP;
            }
            if (dayP < 10)
            {
                dp = "0" + dayP;
            }
            string persianDate = yearP + "/" + mp + "/" + dp;

            return persianDate;
        }
        //Update job
        public static DataTable GetUpdateTime()
        {
            string connectionString = GetConnectionStringDashboard();
            string strSelectCommand = "IF (EXISTS (SELECT *  FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' " +
                "AND  TABLE_NAME = 'UpdateHistory_HYG')) " +
            "BEGIN " +
            "select top 1 (updateshamsidate) from UpdateHistory_HYG order by lr desc" +

            " END " +
            " ELSE " +
                " select '' as updateshamsidate   ";

            DataTable dt = new DataTable();

            try
            {
                // Connect to the database and run the query.
                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter adapter = new SqlDataAdapter(strSelectCommand, connection);

                // Fill the DataSet.
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {


            }

            return dt;
        }


        //فروش  وزنی ماهیانه Optional1 - VIEWS-شرکت
        public static DataTable GetDataCoOptionalWeight1(string statusPeriod)
        {
            string connectionString = GetConnectionStringDashboard();
            BiDatabaseHandler dataFetch = new BiDatabaseHandler();
            PeriodInfo getPeriod = dataFetch.GetPeriod(statusPeriod);
            string strSelectCommand = "IF (EXISTS (SELECT *  FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_SCHEMA = 'dbo' " +
                    "AND  TABLE_NAME = 'DSHVIW_" + getPeriod.YearNow.ToString() + "_SLS0001_Comp')) " +
                "BEGIN " +
                    "select MOONNAME as 'ماه' , TotalNetWEIGHTHNow as '" + getPeriod.strYearNow.ToString() + "', TotalNetWEIGHTHPre as '" + getPeriod.strYearPre.ToString() + "' from DSHVIW_" + getPeriod.YearNow.ToString() + "_SLS0001_Comp WITH(NOLOCK) order by MOONCODE " +
                " END " +
                " ELSE " +
                    " select '' as MOONNAME, 0 as TotalNetWEIGHTHNow, 0 as TotalNetWEIGHTHPre ";
            DataTable dt = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter adapter = new SqlDataAdapter(strSelectCommand, connection);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
            }
            return dt;
        }
    

    }
}