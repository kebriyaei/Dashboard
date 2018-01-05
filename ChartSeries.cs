using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Helpers;
using DotNet.Highcharts.Options;


/// <summary>
/// Summary description for ChartSeries
/// </summary>
public class ChartSeries
{
    public ChartSeries()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static List<System.Drawing.Color> GetTheme(string CategoryTheme)
    {
        string statusPeriod = General.GetUserDefinedPeriod().Substring(2, 2);
        int intStatusPeriodPre = Convert.ToInt32(statusPeriod);
        List<System.Drawing.Color> theme = new List<System.Drawing.Color>();

        if (CategoryTheme == "SalePurchase")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#d30601"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#167f01"));
        }
        if (CategoryTheme == "SupplierKPISKU")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#d9534f"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#f0ad4e"));
        }
        if (CategoryTheme == "SupplierKPICustomer")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#577492"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#856969"));
        }
        if (CategoryTheme == "SupplierKPIFactor")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#1bc9bc"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#7f4976"));
        }
        if (CategoryTheme == "SupplierKPIRial")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#bdd62b"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#b75459"));
        }
        if (CategoryTheme == "SupplierKPIWeight")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#173c42"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#bda85b"));
        }
        else if (CategoryTheme == "PercentageMonthYearTheme")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#d94f86"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#8b4c65"));
        }
        else if (CategoryTheme == "PercentageMonthTheme")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#d94f86"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#d94f86"));
        }
        else if (CategoryTheme == "PercentageMonthChannelTheme")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#f15c80"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#8085e9"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#ff8a50"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6ee5c8"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#52229a"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#b15801"));//ghahvei تخصصی

            theme.Add(System.Drawing.ColorTranslator.FromHtml("#f15c80"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#8085e9"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#ff8a50"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6ee5c8"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#52229a"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#b15801"));//ghahvei تخصصی

            theme.Add(System.Drawing.ColorTranslator.FromHtml("#f15c80"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#8085e9"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#ff8a50"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6ee5c8"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#52229a"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#b15801"));//ghahvei تخصصی

            theme.Add(System.Drawing.ColorTranslator.FromHtml("#f15c80"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#8085e9"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#ff8a50"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6ee5c8"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#52229a"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#b15801"));//ghahvei تخصصی

            theme.Add(System.Drawing.ColorTranslator.FromHtml("#f15c80"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#8085e9"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#ff8a50"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6ee5c8"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#52229a"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#b15801"));//ghahvei تخصصی

            theme.Add(System.Drawing.ColorTranslator.FromHtml("#f15c80"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#8085e9"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#ff8a50"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6ee5c8"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#52229a"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#b15801"));//ghahvei تخصصی

            theme.Add(System.Drawing.ColorTranslator.FromHtml("#f15c80"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#8085e9"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#ff8a50"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6ee5c8"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#52229a"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#b15801"));//ghahvei تخصصی

            theme.Add(System.Drawing.ColorTranslator.FromHtml("#f15c80"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#8085e9"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#ff8a50"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6ee5c8"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#52229a"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#b15801"));//ghahvei تخصصی

            theme.Add(System.Drawing.ColorTranslator.FromHtml("#f15c80"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#8085e9"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#ff8a50"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6ee5c8"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#52229a"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#b15801"));//ghahvei تخصصی

            theme.Add(System.Drawing.ColorTranslator.FromHtml("#f15c80"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#8085e9"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#ff8a50"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6ee5c8"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#52229a"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#b15801"));//ghahvei تخصصی

            theme.Add(System.Drawing.ColorTranslator.FromHtml("#f15c80"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#8085e9"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#ff8a50"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6ee5c8"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#52229a"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#b15801"));//ghahvei تخصصی

            theme.Add(System.Drawing.ColorTranslator.FromHtml("#f15c80"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#8085e9"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#ff8a50"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6ee5c8"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#52229a"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#b15801"));//ghahvei تخصصی
        }
        else if (CategoryTheme == "CheckTheme")
        {
            //theme.Add(System.Drawing.ColorTranslator.FromHtml("#ff0b6d"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#01c4db"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));
        }
        else if (CategoryTheme == "IndexProfitTheme")
        {
            //theme.Add(System.Drawing.ColorTranslator.FromHtml("#71008d"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#71008d"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));
        }
        else if (CategoryTheme == "PieChanelTheme")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#f15c80"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#8085e9"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#ff8a50"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6ee5c8"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#52229a"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#b15801"));//ghahvei تخصصی
        }
        else if (CategoryTheme == "BarChanelTheme")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#f15c80"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//a51236
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#8085e9"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//3b3f87
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#ff8a50"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//ac4715
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6ee5c8"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//257e68
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#52229a"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//050505
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#b15801"));//ghahvei تخصصی
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));

        }
        else if (CategoryTheme == "PieSupplierTheme")
        {
            if (intStatusPeriodPre != 11)
            {
                theme.Add(System.Drawing.ColorTranslator.FromHtml("#1bc9bc"));//behpak
                theme.Add(System.Drawing.ColorTranslator.FromHtml("#f92e2e"));//parsshahab
            }
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fe7c4a"));//others  5bc0de
            if (intStatusPeriodPre != 12 && intStatusPeriodPre != 11)
            {
                theme.Add(System.Drawing.ColorTranslator.FromHtml("#bf3ffb")); //Masouleh  5cb85c
            }
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fed500"));//aftab fed500
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fe69b2"));//ariamelal d9534f
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#0000ff"));//paxan 428bca

        }
        else if (CategoryTheme == "PolarTargetTheme")
        {

            theme.Add(System.Drawing.ColorTranslator.FromHtml("#bdd62b"));//behpak
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#ff00cf"));//parsshahab


        }
        else if (CategoryTheme == "BarSupplierThemeWithTarget")
        {
            //if (intStatusPeriodPre == 14)
            //{
            //    theme.Add(System.Drawing.ColorTranslator.FromHtml("#fe7c4a"));//others  5bc0de
            //    theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//others  b33301
            //    theme.Add(System.Drawing.ColorTranslator.FromHtml("#1bc9bc"));//behpak
            //    theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//behpak
            //    theme.Add(System.Drawing.ColorTranslator.FromHtml("#f92e2e"));//parsshahab
            //    theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//parsshahab
            //    theme.Add(System.Drawing.ColorTranslator.FromHtml("#fed500"));//aftab fed500
            //    theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//aftab d9b601
            //    theme.Add(System.Drawing.ColorTranslator.FromHtml("#0000ff"));//paxan 428bca
            //    theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//paxan 1e1e9b
            //}
            //else
            //{
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6b1470"));
            //theme.Add(System.Drawing.ColorTranslator.FromHtml("#fcb79c"));//others  5bc0de
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//others  b33301
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fe7c4a"));//others  5bc0de

            if (intStatusPeriodPre != 11)
            {
                theme.Add(System.Drawing.ColorTranslator.FromHtml("#6b1470"));

                //theme.Add(System.Drawing.ColorTranslator.FromHtml("#90faf2"));//behpak
                theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//behpak
                theme.Add(System.Drawing.ColorTranslator.FromHtml("#1bc9bc"));//behpak


                theme.Add(System.Drawing.ColorTranslator.FromHtml("#6b1470"));

                //theme.Add(System.Drawing.ColorTranslator.FromHtml("#f98282"));//parsshahab
                theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//parsshahab
                theme.Add(System.Drawing.ColorTranslator.FromHtml("#f92e2e"));//parsshahab

            }
            if (intStatusPeriodPre != 12 && intStatusPeriodPre != 11)
            {
                theme.Add(System.Drawing.ColorTranslator.FromHtml("#6b1470"));

                //theme.Add(System.Drawing.ColorTranslator.FromHtml("#db92fd")); //Masouleh  5cb85c
                theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f")); //ghonche  5a5731
                theme.Add(System.Drawing.ColorTranslator.FromHtml("#bf3ffb")); //Masouleh  5cb85c

            }
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6b1470"));

            //theme.Add(System.Drawing.ColorTranslator.FromHtml("#e5d686"));//aftab fed500
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//aftab d9b601
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fed500"));//aftab fed500


            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6b1470"));

            //theme.Add(System.Drawing.ColorTranslator.FromHtml("#ebb5cf"));//ariamelal d9534f
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//ariamelal e50c76
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fe69b2"));//ariamelal d9534f


            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6b1470"));

            //theme.Add(System.Drawing.ColorTranslator.FromHtml("#80bcfe"));//paxan 428bca
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//paxan 1e1e9b
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#0000ff"));//paxan 428bca

            //}


        }
        else if (CategoryTheme == "BarSupplierTheme")
        {
            //if (intStatusPeriodPre == 14)
            //{
            //    theme.Add(System.Drawing.ColorTranslator.FromHtml("#fe7c4a"));//others  5bc0de
            //    theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//others  b33301
            //    theme.Add(System.Drawing.ColorTranslator.FromHtml("#1bc9bc"));//behpak
            //    theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//behpak
            //    theme.Add(System.Drawing.ColorTranslator.FromHtml("#f92e2e"));//parsshahab
            //    theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//parsshahab
            //    theme.Add(System.Drawing.ColorTranslator.FromHtml("#fed500"));//aftab fed500
            //    theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//aftab d9b601
            //    theme.Add(System.Drawing.ColorTranslator.FromHtml("#0000ff"));//paxan 428bca
            //    theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//paxan 1e1e9b
            //}
            //else
            //{
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fe7c4a"));//others  5bc0de
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//others  b33301
            if (intStatusPeriodPre != 11)
            {
                theme.Add(System.Drawing.ColorTranslator.FromHtml("#1bc9bc"));//behpak
                theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//behpak
                theme.Add(System.Drawing.ColorTranslator.FromHtml("#f92e2e"));//parsshahab
                theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//parsshahab
            }
            if (intStatusPeriodPre != 12 && intStatusPeriodPre != 11)
            {
                theme.Add(System.Drawing.ColorTranslator.FromHtml("#bf3ffb")); //Masouleh  5cb85c
                theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f")); //ghonche  5a5731
            }
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fed500"));//aftab fed500
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//aftab d9b601
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fe69b2"));//ariamelal d9534f
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//ariamelal e50c76
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#0000ff"));//paxan 428bca
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//paxan 1e1e9b
            //}


        }
        else if (CategoryTheme == "BarSupplierDetailsTheme")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fe7c4a"));//others  5bc0de
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#1bc9bc"));//behpak
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#f92e2e"));//parsshahab
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#bf3ffb"));//Masouleh  5cb85c
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fed500"));//aftab fed500
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fe69b2"));//ariamelal d9534f
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#0000ff"));//paxan 428bca

            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fe7c4a"));//others
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#1bc9bc"));//behpak
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#f92e2e"));//parsshahab
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#bf3ffb"));//Masouleh
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fed500"));//aftab
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fe69b2"));//ariamelal
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#0000ff"));//paxan

            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fe7c4a"));//others
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#1bc9bc"));//behpak
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#f92e2e"));//parsshahab
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#bf3ffb"));//Masouleh
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fed500"));//aftab
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fe69b2"));//ariamelal
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#0000ff"));//paxan
        }
        else if (CategoryTheme == "CoTheme")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//co
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#331700"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "PaxanTheme")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//paxan
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#0000ff"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "AriamelalTheme")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//ariamelal 
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fe69b2"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "GhoncheTheme")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//ghonche
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#bbb56a"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "MasoulehTheme")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//Masouleh
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#bf3ffb"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "AftabTheme")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//aftab
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fed500"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "behpakTheme")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//behpak
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#1bc9bc"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "parsshahabTheme")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//parsshahab
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#f92e2e"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "OtherTheme")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//others
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fe7c4a"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "CoTargetTheme")
        {

            theme.Add(System.Drawing.ColorTranslator.FromHtml("#331700"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6b1470"));//co
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "PaxanTargetTheme")
        {
            //paxan
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#0000ff"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6b1470"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "AriamelalTargetTheme")
        {
            //ariamelal 
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fe69b2"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6b1470"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "GhoncheTargetTheme")
        {
            //ghonche
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#bbb56a"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6b1470"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "MasoulehTargetTheme")
        {
            //Masouleh
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#bf3ffb"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6b1470"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "AftabTargetTheme")
        {
            //aftab
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fed500"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6b1470"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "behpakTargetTheme")
        {
            //behpak
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#1bc9bc"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6b1470"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "parsshahabTargetTheme")
        {
            //parsshahab
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#f92e2e"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6b1470"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "OtherTargetTheme")
        {
            //others
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fe7c4a"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#6b1470"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "CoThemeOptional")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#331700"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//co

            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "PaxanThemeOptional")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#0000ff"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//paxan

            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "AriamelalThemeOptional")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fe69b2"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//ariamelal 

            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "GhoncheThemeOptional")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#bbb56a"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//ghonche

            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "MasoulehThemeOptional")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#bf3ffb"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//Masouleh

            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "AftabThemeOptional")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fed500"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//aftab

            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "behpakThemeOptional")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#1bc9bc"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//behpak

            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "parsshahabThemeOptional")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#f92e2e"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//parsshahab

            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "OtherThemeOptional")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#fe7c4a"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#5b5b5f"));//others

            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "Channel1Theme")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#f15c80"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "Channel2Theme")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#434348"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "Channel3Theme")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#f7a35c"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "SenfTheme")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#90ed7d"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "ZanjireiTheme")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#8085e9"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else if (CategoryTheme == "Takhasosi")
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#b15801"));//ghahvei تخصصی
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#000000"));
        }
        else
        {
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#DF5353"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#ff0066"));
            theme.Add(System.Drawing.ColorTranslator.FromHtml("#aaeeee"));
        }

        return theme;
    }
    public static List<Series> GetChartSeriLine(DataTable dt, string CategoryTheme)
    {
        List<System.Drawing.Color> theme = GetTheme(CategoryTheme);
        List<Series> seri = new List<Series>();
        try
        {
            for (int i = 1; i < dt.Columns.Count; i++)
            {
                List<object> data = new List<object>();
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    data.Add(dt.Rows[j][i]);
                }
                seri.Add(new Series
                {
                    Data = new Data(data.ToArray()),
                    Name = dt.Columns[i].Caption,
                    Color = theme[i - 1],
                    //Color=System.Drawing.Color.Red


                });
            }
        }
        catch (Exception ex)
        {


        }
        return seri;
    }
    public static List<Series> GetChartSeri(DataTable dt, string CategoryTheme)
    {
        List<System.Drawing.Color> theme = GetTheme(CategoryTheme);
        List<Series> seri = new List<Series>();
        try
        {
            for (int i = 1; i < dt.Columns.Count; i++)
            {
                List<object> data = new List<object>();
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    data.Add(dt.Rows[j][i]);
                }
                seri.Add(new Series
                {
                    Data = new Data(data.ToArray()),
                    Name = dt.Columns[i].Caption,
                    Color = theme[i - 1],
                    //Color=System.Drawing.Color.Red

                    PlotOptionsBar = new PlotOptionsBar
                    {
                        DataLabels = new PlotOptionsBarDataLabels
                        {
                            Enabled = true,
                            //Rotation = -90,
                            //Color = System.Drawing.Color.White,
                            //X = 4,
                            //Y = 30,
                            //Style = "fontSize: '13px',fontFamily: 'Verdana, sans-serif',textShadow: '0 0 3px black'",

                            BorderWidth = 1,
                            Color = System.Drawing.Color.Black,
                            BorderColor = System.Drawing.Color.Black,
                            BackgroundColor = new BackColorOrGradient(System.Drawing.Color.White)
                            ,
                            Style = "color: '#000000', font: '12px Tahoma'",
                            X = 0.5,
                            Y = 0.5,




                        }
                    }

                });
            }
        }
        catch (Exception ex)
        {


        }
        return seri;
    }
    public static List<Series> GetChartSeriKPI(DataTable dt, string CategoryTheme)
    {
        List<System.Drawing.Color> theme = GetTheme(CategoryTheme);
        List<Series> seri = new List<Series>();
        try
        {
            for (int i = 1; i < dt.Columns.Count; i++)
            {
                List<object> data = new List<object>();
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    data.Add(dt.Rows[j][i]);
                }
                seri.Add(new Series
                {
                    Data = new Data(data.ToArray()),
                    Name = dt.Columns[i].Caption,
                    Color = theme[i - 1],
                    //Color=System.Drawing.Color.Red

                    PlotOptionsBar = new PlotOptionsBar
                    {
                        DataLabels = new PlotOptionsBarDataLabels
                        {
                            Enabled = true,
                            //Rotation = -90,
                            //Color = System.Drawing.Color.White,
                            //X = 4,
                            //Y = 30,
                            //Style = "fontSize: '13px',fontFamily: 'Verdana, sans-serif',textShadow: '0 0 3px black'",

                            BorderWidth = 1,
                            Color = System.Drawing.Color.Black,
                            BorderColor = System.Drawing.Color.Black,
                            BackgroundColor = new BackColorOrGradient(System.Drawing.Color.White)
                            ,
                            Style = "color: '#000000', font: '12px Tahoma'",
                            X = 0.5,
                            Y = 0.5,




                        }
                    }

                });
            }
        }
        catch (Exception ex)
        {


        }
        return seri;
    }
    public static List<Series> GetChartSeriBarGroup(DataTable dt, string CategoryTheme)
    {
        List<System.Drawing.Color> theme = GetTheme(CategoryTheme);
        List<Series> seri = new List<Series>();
        try
        {
            for (int i = 1; i < dt.Columns.Count; i++)
            {
                List<Point> data = new List<Point>();
                int k = 0;
                for (int j = 0; j < dt.Rows.Count; j++)
                {

                    Point p = new Point();
                    p.Y = Convert.ToInt64(dt.Rows[j][i]);
                    //p.Color = i == 1 ? System.Drawing.Color.Black : theme[j];
                    p.Color = i == 1 ? theme[k + 1] : theme[k];
                    k = k + 2;
                    //p.Color =  theme[j];
                    data.Add(p);
                }

                seri.Add(new Series
                {
                    Data = new Data(data.ToArray()),
                    Name = dt.Columns[i].Caption,
                    //Color=System.Drawing.Color.Red
                    PlotOptionsBar = new PlotOptionsBar
                    {
                        DataLabels = new PlotOptionsBarDataLabels
                        {
                            Enabled = true,
                            //Rotation = -90,
                            //Color = System.Drawing.Color.White,
                            //X = 4,
                            //Y = 30,
                            //Style = "fontSize: '13px',fontFamily: 'Verdana, sans-serif',textShadow: '0 0 3px black'",

                            BorderWidth = 1,
                            Color = System.Drawing.Color.Black,
                            BorderColor = System.Drawing.Color.Black,
                            BackgroundColor = new BackColorOrGradient(System.Drawing.Color.White)
                            ,
                            Style = "color: '#000000', font: '12px Tahoma'",
                            X = 0.5,
                            Y = 0.5,
                        }
                    }
                });
            }
        }
        catch (Exception ex)
        {


        }
        return seri;
    }
    public static List<Series> GetChartSeriBarGroupThreeSeries(DataTable dt, string CategoryTheme)
    {
        List<System.Drawing.Color> theme = GetTheme(CategoryTheme);
        List<Series> seri = new List<Series>();
        try
        {
            for (int i = 1; i < dt.Columns.Count; i++)
            {
                List<Point> data = new List<Point>();
                int k = 0;
                for (int j = 0; j < dt.Rows.Count; j++)
                {

                    Point p = new Point();
                    p.Y = Convert.ToInt64(dt.Rows[j][i]);
                    //p.Color = i == 1 ? System.Drawing.Color.Black : theme[j];
                    p.Color = i < 3 ? theme[k + i] : theme[k];

                    k = k + 3;
                    //p.Color =  theme[j];
                    data.Add(p);
                }

                seri.Add(new Series
                {
                    Data = new Data(data.ToArray()),
                    Name = dt.Columns[i].Caption,
                    //Color=System.Drawing.Color.Red
                    PlotOptionsBar = new PlotOptionsBar
                    {
                        DataLabels = new PlotOptionsBarDataLabels
                        {
                            Enabled = true,
                            //Rotation = -90,
                            //Color = System.Drawing.Color.White,
                            //X = 4,
                            //Y = 30,
                            //Style = "fontSize: '13px',fontFamily: 'Verdana, sans-serif',textShadow: '0 0 3px black'",

                            BorderWidth = 1,
                            Color = System.Drawing.Color.Black,
                            BorderColor = System.Drawing.Color.Black,
                            BackgroundColor = new BackColorOrGradient(System.Drawing.Color.White)
                            ,
                            Style = "color: '#000000', font: '12px Tahoma'",
                            X = 0.5,
                            Y = 0.5,
                        }
                    }
                });
            }
        }
        catch (Exception ex)
        {


        }
        return seri;
    }
    public static List<XAxis> GetChartxAxis(DataTable dt)
    {
        List<XAxis> xAxis = new List<XAxis>();
        List<string> cat = new List<string>();
        try
        {

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cat.Add(dt.Rows[i][0].ToString());

            }
            xAxis.Add(new XAxis
            {
                Categories = cat.ToArray(),
                Title = new XAxisTitle { Text = dt.Columns[0].Caption },
                Labels = new XAxisLabels { Rotation = 45, Style = "color: '#000000', font: '12px Tahoma'", },
            });
        }
        catch (Exception ex)
        {


        }
        return xAxis;
    }
    public static List<XAxis> GetChartxAxisThree(DataTable dt)
    {
        List<XAxis> xAxis = new List<XAxis>();
        List<string> cat = new List<string>();
        try
        {

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                double pr = Convert.ToDouble(dt.Rows[i][2]) / Convert.ToDouble(dt.Rows[i][3]);
                pr = Math.Round(pr * 100, 0);
                cat.Add("%" + pr.ToString() + "-" + dt.Rows[i][0].ToString());

            }
            xAxis.Add(new XAxis
            {
                Categories = cat.ToArray(),
                Title = new XAxisTitle { Text = dt.Columns[0].Caption },
                Labels = new XAxisLabels { Rotation = 80, Style = "color: '#000000', font: '12px Tahoma'", },

            });
        }
        catch (Exception ex)
        {


        }
        return xAxis;
    }
    public static List<XAxis> GetChartxAxisKPI(DataTable dt)
    {
        List<XAxis> xAxis = new List<XAxis>();
        List<string> cat = new List<string>();
        try
        {

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cat.Add(dt.Rows[i][0].ToString());

            }
            xAxis.Add(new XAxis
            {
                Categories = cat.ToArray(),
                //Title = new XAxisTitle { Text = dt.Columns[0].Caption },
                Labels = new XAxisLabels { Rotation = 0, Style = "color: '#000000', font: '12px Tahoma'", },
            });
        }
        catch (Exception ex)
        {


        }
        return xAxis;
    }
    public static List<YAxis> GetChartyAxis(DataTable dt)
    {
        List<YAxis> yAxis = new List<YAxis>();
        List<string> cat = new List<string>();
        try
        {


            yAxis.Add(new YAxis
            {
                Title = new YAxisTitle
                {
                    Text = "",
                    Margin = -40,
                    Offset = -20,
                    Align = AxisTitleAligns.Low,
                    Style = "fontSize: 12",
                    Enabled = "false",
                },
                Labels = new YAxisLabels
                {
                    Formatter = "function() { return Highcharts.numberFormat(this.value, 0); }"
                    ,
                    X = -40

                },//function to convert 4k to 4000

                //Type = AxisTypes.Logarithmic,

                //AllowDecimals=false,
                //ShowFirstLabel=false,


            });
        }
        catch (Exception ex)
        {


        }
        return yAxis;
    }

    public static List<string> GetChartyAxisPolarTargets()
    {
        List<YAxis> yAxis = new List<YAxis>();
        List<string> cat = new List<string>();
        try
        {
            
            cat.Add("فروش_ریالی");
            cat.Add("فروش_تناژی");
            cat.Add("پوشش_مشتریان");
            cat.Add("رتبه_شرکت");
            cat.Add("فروش_سرانه");
            cat.Add("پوشش_سیستمی");
            cat.Add("هزینه_مالی");
            cat.Add("سود_ناخالص");
            cat.Add("سهم_سبد_کالای_گروه");
            cat.Add("سهم_فروش_ريالی_فروشگاه‌ها");
            cat.Add("ضریب_فروش");
            cat.Add("هزینه_توزیع");
            cat.Add("هزینه_فروش");
            cat.Add("رضایت_مشتریان");
            cat.Add("سطح_سرویس_به_مشتریان");
            cat.Add("کارایی_زیرساخت‌ها");
            cat.ForEach(x =>
            {
                x = x.Replace(" ", "_");
            });
        }
        catch (Exception ex)
        {


        }
        return cat;
    }

    public static List<YAxis> GetChartyAxisKPI(DataTable dt)
    {
        List<YAxis> yAxis = new List<YAxis>();
        List<string> cat = new List<string>();
        try
        {


            yAxis.Add(new YAxis
            {
                Title = new YAxisTitle
                {
                    Text = "",
                    Margin = -40,
                    Offset = -20,
                    Align = AxisTitleAligns.Low,
                    Style = "fontSize: 12",
                    Enabled = "false",
                },
                Labels = new YAxisLabels
                {
                    Formatter = "function() { return Highcharts.numberFormat(this.value, 0); }"
                    ,
                    X = 0

                },//function to convert 4k to 4000

                //Type = AxisTypes.Logarithmic,

                //AllowDecimals=false,
                //ShowFirstLabel=false,


            });
        }
        catch (Exception ex)
        {


        }
        return yAxis;
    }
    public static List<XAxis> GetChartxAxisBarBig(DataTable dt)
    {
        List<XAxis> xAxis = new List<XAxis>();
        List<string> cat = new List<string>();
        try
        {

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cat.Add(dt.Rows[i][0].ToString());

            }
            xAxis.Add(new XAxis
            {
                Categories = cat.ToArray(),
                Title = new XAxisTitle { Text = dt.Columns[0].Caption },
                Labels = new XAxisLabels { Rotation = 45, Style = "color: '#000000', font: '12px Tahoma'", },
            });
        }
        catch (Exception ex)
        {


        }
        return xAxis;
    }

    public static List<XAxis> GetChartxAxisBarBigSaleSupplierBranchTarget(DataTable dt)
    {
        List<XAxis> xAxis = new List<XAxis>();
        List<string> cat = new List<string>();
        try
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                double pr = Convert.ToDouble(dt.Rows[i][1]) / Convert.ToDouble(dt.Rows[i][2]);
                pr = Math.Round(pr * 100, 0);
                cat.Add("%" + pr.ToString() + "-" + dt.Rows[i][0].ToString());

            }


            xAxis.Add(new XAxis
            {
                Categories = cat.ToArray(),
                Title = new XAxisTitle { Text = dt.Columns[0].Caption },
                Labels = new XAxisLabels { Rotation = 80, Style = "color: '#000000', font: '12px Tahoma'", },
            });
        }
        catch (Exception ex)
        {


        }
        return xAxis;
    }

    public static List<Series> GetChartSeriPie(DataTable dt, string CategoryTheme)
    {

        List<Series> seri = new List<Series>();
        List<Point> data = new List<Point>();
        List<System.Drawing.Color> theme = GetTheme(CategoryTheme);
        try
        {

            //DataColumn column = dt.Columns[0];
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                Point p = new Point();
                p.Name = dt.Rows[j][0].ToString();
                p.Y = Convert.ToSingle(dt.Rows[j][1]);
                p.Color = theme[j];

                //DataRow row = dt.Rows[j];
                //data.Add(dt.Rows[j][1]);
                data.Add(p);
            }
            data.First().Selected = true;
            data.First().Sliced = true;
            seri.Add(new Series
                {
                    Type = ChartTypes.Pie,

                    Name = "Sale",
                    //Data = new Data(new object[]
                    //                       {
                    //                           new object[] { "Firefox", 45.0 },
                    //                           new object[] { "IE", 26.8 },
                    //                           new DotNet.Highcharts.Options.Point
                    //                           {
                    //                               Name = "Chrome",
                    //                               Y = 12.8,
                    //                               Sliced = true,
                    //                               Selected = true
                    //                           },
                    //                           new object[] { "Safari", 8.5 },
                    //                           new object[] { "Opera", 6.2 },
                    //                           new object[] { "Others", 0.7 }
                    //                       })
                    Data = new Data(data.ToArray()),
                    //Name = row.ItemArray[0].ToString()
                });
        }
        catch (Exception ex)
        {


        }
        return seri;
    }
    public static List<XAxis> GetChartxAxisPie(DataTable dt)
    {
        List<XAxis> xAxis = new List<XAxis>();
        List<string> cat = new List<string>();
        try
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cat.Add(dt.Rows[i][0].ToString());

            }
            xAxis.Add(new XAxis
            {
                Categories = cat.ToArray(),

                Title = new XAxisTitle { Text = dt.Columns[0].Caption }
            });
        }
        catch (Exception ex)
        {


        }
        return xAxis;
    }

    public static List<Series> GetChartSeriPolar2(DataTable dt, string CategoryTheme)
    {

        List<Series> seri = new List<Series>();
        List<Point> data = new List<Point>();
        List<Object> serie1 = new List<Object>();
        List<System.Drawing.Color> theme = GetTheme(CategoryTheme);
        try
        {

            //DataColumn column = dt.Columns[0];
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                Point p = new Point();
                p.Name = dt.Rows[j][0].ToString();

                p.Y = Convert.ToSingle(dt.Rows[j][1]);
                p.Color = theme[j];

                //DataRow row = dt.Rows[j];
                //data.Add(dt.Rows[j][1]);
                data.Add(p);
            }
            data.First().Selected = true;
            data.First().Sliced = true;
            seri.Add(new Series
            {
                Type = ChartTypes.Pie,

                Name = "Sale",
                //Data = new Data(new object[]
                //                       {
                //                           new object[] { "Firefox", 45.0 },
                //                           new object[] { "IE", 26.8 },
                //                           new DotNet.Highcharts.Options.Point
                //                           {
                //                               Name = "Chrome",
                //                               Y = 12.8,
                //                               Sliced = true,
                //                               Selected = true
                //                           },
                //                           new object[] { "Safari", 8.5 },
                //                           new object[] { "Opera", 6.2 },
                //                           new object[] { "Others", 0.7 }
                //                       })
                Data = new Data(data.ToArray()),
                //Name = row.ItemArray[0].ToString()
            });
        }
        catch (Exception ex)
        {


        }
        return seri;
    }


    public static List<Series> GetChartSeriPolar(DataTable dt, DataTable descriptions, string CategoryTheme)
    {

        List<Series> seri = new List<Series>();
        List<Point> data = new List<Point>();
        List<Object> serie1 = new List<Object>();
        List<System.Drawing.Color> theme = GetTheme(CategoryTheme);
        List<DotNet.Highcharts.Enums.ChartTypes> typs = new List<DotNet.Highcharts.Enums.ChartTypes>();
        typs.Add(ChartTypes.Line);
        typs.Add(ChartTypes.Line);
        try
        {

            ////DataColumn column = dt.Columns[0];
            //for (int j = 0; j < dt.Rows.Count; j++)
            //{
            //    Point p = new Point();
            //    p.Name = dt.Rows[j][0].ToString();

            //    p.Y = Convert.ToSingle(dt.Rows[j][1]);
            //    p.Color = theme[j];

            //    //DataRow row = dt.Rows[j];
            //    //data.Add(dt.Rows[j][1]);
            //    data.Add(p);
            //}
            //data.First().Selected = true;
            //data.First().Sliced = true;

            //var colors = new System.Drawing.Color[] { System.Drawing.ColorTranslator.FromHtml("#bdd62b"),  System.Drawing.ColorTranslator.FromHtml("#ff00cf")};
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                List<Point> points = new List<Point>();
                for (int k = 1; k <= 16; k++)
                {
                    Point point = new Point
                    {
                        Name = string.Format("Name: {0}", dt.Rows[j][k].ToString()),
                        Color = theme[j],

                        DataLabels = string.Format("- معادل {0}", descriptions.Rows[j][k])
                    };
                    point.Y = Convert.ToSingle(dt.Rows[j][k].ToString());
                    points.Add(point);
                }

                seri.Add(new Series
                {

                    Type = typs[j],
                    Color = theme[j],
                    Name = dt.Rows[j][0].ToString(),
                    //Data = new Data((new object[] { Convert.ToDouble(dt.Rows[j][1]), Convert.ToDouble(dt.Rows[j][2]), Convert.ToDouble(dt.Rows[j][3]), Convert.ToDouble(dt.Rows[j][4]), Convert.ToDouble(dt.Rows[j][5]), Convert.ToDouble(dt.Rows[j][6]), Convert.ToDouble(dt.Rows[j][7]), Convert.ToDouble(dt.Rows[j][8]), Convert.ToDouble(dt.Rows[j][9]), Convert.ToDouble(dt.Rows[j][10]), Convert.ToDouble(dt.Rows[j][11]), Convert.ToDouble(dt.Rows[j][12]), Convert.ToDouble(dt.Rows[j][13]), Convert.ToDouble(dt.Rows[j][14]), Convert.ToDouble(dt.Rows[j][15]), Convert.ToDouble(dt.Rows[j][16]) }).ToArray()),
                    Data = new Data(points.ToArray()),
                    PlotOptionsLine = new PlotOptionsLine
                    {
                        PointPlacement = new PointPlacement(Placement.On)

                    }
                    //Data = new Data(new object[]
                    //                       {
                    //                           new object[] { "Firefox", 45.0 },
                    //                           new object[] { "IE", 26.8 },
                    //                           new DotNet.Highcharts.Options.Point
                    //                           {
                    //                               Name = "Chrome",
                    //                               Y = 12.8,
                    //                               Sliced = true,
                    //                               Selected = true
                    //                           },
                    //                           new object[] { "Safari", 8.5 },
                    //                           new object[] { "Opera", 6.2 },
                    //                           new object[] { "Others", 0.7 }
                    //                       })
                    //Data = new Data(data.ToArray()),
                    //Name = row.ItemArray[0].ToString()
                });
            }
        }
        catch (Exception ex)
        {


        }
        return seri;
    }
    public static List<YAxis> GetChartyAxisGauge(DataTable dt)
    {
        List<YAxis> yAxis = new List<YAxis>();
        List<string> cat = new List<string>();
        try
        {
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            cat.Add(dt.Rows[0][0].ToString());

            //}
            //yAxis.Add(new YAxis
            //{
            //    //Categories = cat.ToArray(),
            //    //Title = new YAxisTitle { Text = dt.Columns[0].Caption }

            //    Stops =
            //    {
            //        { Gradient= 0.1, Color="#55BF3B"}, // green
            //        {Gradient=0.5, Color="#DDDF0D"}, // yellow
            //        {Gradient=0.9, Color="#DF5353"} // red
            //    },
            //});
        }
        catch (Exception ex)
        {


        }
        return yAxis;
    }
    public static List<Series> GetGaugeSeriWeight(DataTable dt)
    {
        List<Series> seri = new List<Series>();
        List<object> data = new List<object>();
        try
        {
            data.Add(dt.Rows[0][0].ToString());

            seri.Add(new Series
            {
                Type = ChartTypes.Gauge,
                Name = "فروش وزنی دیروز",
                Data = new Data(data.ToArray()),
                Color = System.Drawing.Color.Blue,
                PlotOptionsGauge = new PlotOptionsGauge
                {
                    Dial = new PlotOptionsGaugeDial
                    {
                        BackgroundColor = new BackColorOrGradient(System.Drawing.Color.Blue)
                    }

                }
            });
            List<object> data1 = new List<object>();
            data1.Add(dt.Rows[1][0].ToString());
            seri.Add(new Series
            {
                Type = ChartTypes.Gauge,
                Name = "فروش وزنی امروز",
                Data = new Data(data1.ToArray()),
                Color = System.Drawing.Color.Green,
                PlotOptionsGauge = new PlotOptionsGauge
                {
                    Dial = new PlotOptionsGaugeDial
                    {
                        BackgroundColor = new BackColorOrGradient(System.Drawing.Color.Green)
                    }

                }
            });
            List<object> data2 = new List<object>();
            data2.Add(dt.Rows[2][0].ToString());
            seri.Add(new Series
            {
                Type = ChartTypes.Gauge,
                Name = "فروش وزنی فردا",
                Data = new Data(data2.ToArray()),
                Color = System.Drawing.Color.DarkRed,
                PlotOptionsGauge = new PlotOptionsGauge
                {
                    Dial = new PlotOptionsGaugeDial
                    {
                        BackgroundColor = new BackColorOrGradient(System.Drawing.Color.DarkRed)
                    }
                }
            });
        }
        catch (Exception ex)
        {


        }
        return seri;
    }
    public static List<Series> GetGaugeSeriRial(DataTable dt)
    {
        List<Series> seri = new List<Series>();
        List<object> data = new List<object>();
        try
        {
            data.Add(dt.Rows[0][1].ToString());

            seri.Add(new Series
            {
                Type = ChartTypes.Gauge,
                Name = "فروش ریالی دیروز",
                Data = new Data(data.ToArray()),
                Color = System.Drawing.Color.Blue,
                PlotOptionsGauge = new PlotOptionsGauge
                {
                    Dial = new PlotOptionsGaugeDial
                    {
                        BackgroundColor = new BackColorOrGradient(System.Drawing.Color.Blue)
                    }

                }
            });
            List<object> data1 = new List<object>();
            data1.Add(dt.Rows[1][1].ToString());
            seri.Add(new Series
            {
                Type = ChartTypes.Gauge,
                Name = "فروش ریالی امروز",
                Data = new Data(data1.ToArray()),
                Color = System.Drawing.Color.Green,
                PlotOptionsGauge = new PlotOptionsGauge
                {
                    Dial = new PlotOptionsGaugeDial
                    {
                        BackgroundColor = new BackColorOrGradient(System.Drawing.Color.Green)
                    }

                }
            });
            List<object> data2 = new List<object>();
            data2.Add(dt.Rows[2][1].ToString());
            seri.Add(new Series
            {
                Type = ChartTypes.Gauge,
                Name = "فروش ریالی فردا",
                Data = new Data(data2.ToArray()),
                Color = System.Drawing.Color.DarkRed,
                PlotOptionsGauge = new PlotOptionsGauge
                {
                    Dial = new PlotOptionsGaugeDial
                    {
                        BackgroundColor = new BackColorOrGradient(System.Drawing.Color.DarkRed)
                    }
                }
            });
        }
        catch (Exception ex)
        {


        }
        return seri;
    }

}