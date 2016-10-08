using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Login : System.Web.UI.Page
{
    SqlConnection cx = new SqlConnection();
    SqlCommand cc = new SqlCommand();
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void pdata(object sender, EventArgs e)
    {
        try
        {
            cx.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\My folder\Fun\Data\Asp.net\Basic web\App_Data\Database2.mdf;Integrated Security=True;User Instance=True";
            cx.Open();
            cc.Connection = cx;
            //cc.CommandText = "select Name,Email,Mobile,Gender,Address,Privilage from tbl where Name="+Txtname.Text;
            string str;
            Lblname1.Text = "Name :- ";
            Lblemail1.Text = "Email :- ";
            Lblgen1.Text = "Gender :- ";
            Lblmob1.Text = "Mobile :- ";
            Lblpri1.Text = "Privilage :- ";
            Lbladd1.Text = "Address :- ";
            Lblcoun1.Text = "Country :- ";
            Lbllan1.Text = "Language :- ";
            cc.CommandText = "select Name from tbl where Name='" + Txtname.Text + "' AND Password='" + Txtpwd.Text + "'";
            str = cc.ExecuteScalar().ToString();
            Lblname1.Text += str;
            cc.CommandText = "select Email from tbl where Name='" + Txtname.Text + "' AND Password='" + Txtpwd.Text + "'";
            str=cc.ExecuteScalar().ToString();
            Lblemail1.Text += str;
            cc.CommandText = "select Mobile from tbl where Name='" + Txtname.Text + "' AND Password='" + Txtpwd.Text + "'";
            str = cc.ExecuteScalar().ToString();
            Lblmob1.Text += str;
            cc.CommandText = "select Gender from tbl where Name='" + Txtname.Text + "' AND Password='" + Txtpwd.Text + "'";
            str = cc.ExecuteScalar().ToString();
            Lblgen1.Text += str;
            cc.CommandText = "select Address from tbl where Name='" + Txtname.Text + "' AND Password='" + Txtpwd.Text + "'";
            str = cc.ExecuteScalar().ToString();
            Lbladd1.Text += str;
            cc.CommandText = "select Country from tbl where Name='" + Txtname.Text + "' AND Password='" + Txtpwd.Text + "'";
            str = cc.ExecuteScalar().ToString();
            Lblcoun1.Text += str;
            cc.CommandText = "select Privilage from tbl where Name='" + Txtname.Text + "' AND Password='" + Txtpwd.Text + "'";
            str = cc.ExecuteScalar().ToString();
            Lblpri1.Text += str;
            cc.CommandText = "select Language from tbl where Name='" + Txtname.Text + "' AND Password='" + Txtpwd.Text + "'";
            str = cc.ExecuteScalar().ToString();
            Lbllan1.Text += str;
            cx.Close();
            Lblstat.Text = "Successfull";
        }
        catch (Exception ex)
        {
            Lblname1.Text = "";
            Lblemail1.Text = "";
            Lblgen1.Text = "";
            Lblmob1.Text = "";
            Lblpri1.Text = "";
            Lbladd1.Text = "";
            Lblcoun1.Text = "";
            Lbllan1.Text = "";
            Lblstat.Text = "Invalid Data";
        }
    }
    protected void ddata(object sender, EventArgs e)
    {
        try
        {
            cx.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\My folder\Fun\Data\Asp.net\Basic web\App_Data\Database2.mdf;Integrated Security=True;User Instance=True";
            cx.Open();
            cc.Connection = cx;
            //cc.CommandText = "select Name,Email,Mobile,Gender,Address,Privilage from tbl where Name="+Txtname.Text;
            string str;
            cc.CommandText = "delete from tbl where Name='" + Txtname.Text + "' AND Password='" + Txtpwd.Text  +"'";
            cc.ExecuteNonQuery();
            cx.Close();
            Lblstat.Text = "Delete Successfull";
        }
        catch (Exception ex)
        {
            Lblname1.Text = "";
            Lblemail1.Text = "";
            Lblgen1.Text = "";
            Lblmob1.Text = "";
            Lblpri1.Text = "";
            Lbladd1.Text = "";
            Lbllan1.Text = "";
            Lblstat.Text = "Invalid Data";
        }
    }
}