using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
/// <summary>
/// Summary description for General
/// </summary>
public class General
{
    public static string GetUserDefinedPeriod()
    {
        try
        {
            string period = HttpUtility.UrlDecode(HttpContext.Current.Request.Cookies["cYear"].Value);
            if (period.Length != 4)
            {
                return "Y_14";
            }
            return period;
        }
        catch
        {
            return "Y_14";
        }
    }
}