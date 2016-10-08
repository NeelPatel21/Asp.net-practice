using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    DataTable dt = new DataTable();
    SqlConnection cx = new SqlConnection();
    SqlCommand cc = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void c1data(object sender, EventArgs e)
    {
        try
        {
            dbConn ob = new dbConn();
            String str = "";
            str += "select * from tbl";
            cx = ob.OpenConnection();
            dt = ob.sel(str).Tables[0];
            GV.DataSource = dt;
            GV.DataBind();
            Lblstat.Text = "add successfully";
        }
        catch (Exception ex)
        {
            Lblstat.Text = "error";
        }
    }
}