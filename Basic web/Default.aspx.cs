using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    dbConn ob = new dbConn();
    DataSet ds = new DataSet();
    DataTable dt = new DataTable();
    SqlConnection cx = new SqlConnection();
    SqlCommand cc = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {
        //Response.Redirect("Display.aspx");
        ob.OpenConnection();
        ob.fillcombo("select * from country", DDLcoun);
    }
    protected void bsub(object sender, EventArgs e)
    {
        Lblname1.Text ="Name :- " + Txtname.Text;
        Lblpass1.Text ="Password :- " + Txtpwd.Text;
        Lblname1.Text = "Email :- " + Txtemail.Text;
        Lblgen1.Text = "Gender :- " + RBL1.SelectedValue;
        Lblpri1.Text = "Privilage :- " + DDLpri.SelectedItem.Text;
        Lbladd1.Text = "Address :- " + Txtadd.Text;
        Lbllan1.Text = "Language :- ";
        foreach(ListItem i in CB1.Items){
            if(i.Selected)
            Lbllan1.Text += i.Text + " ";
        }

    }
    protected void pdata(object sender, EventArgs e)
    {
        try
        {
            String str="";
            foreach(ListItem i in CB1.Items)
                if(i.Selected)
                    str += i.ToString() + " ";
            cx.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\My folder\Fun\Data\Asp.net\Basic web\App_Data\Database2.mdf;Integrated Security=True;User Instance=True";
            cx.Open();
            cc.Connection = cx;
            cc.CommandText = "insert into tbl(Name,Password,Email,Mobile,Gender,Address,Privilage,Language) values('" + Txtname.Text + "','" + Txtpwd.Text + "','" + Txtemail.Text + "','" + Txtmob.Text + "','" + RBL1.SelectedValue + "','" + Txtadd.Text + "','" + DDLpri.SelectedValue +"','" +str+ "')";
            cc.ExecuteNonQuery();
            cx.Close();
            Lblstat.Text = "add successfully";
        }
        catch (Exception ex)
        {
            Lblstat.Text = "error";
        }
    }
    protected void cdata(object sender, EventArgs e)
    {
        try
        {
            dbConn ob = new dbConn();
            String strl= "",str="";
            foreach (ListItem i in CB1.Items)
                if (i.Selected)
                    strl += i.ToString() + " ";
            str+=@"insert into tbl(Name,Password,Email,Mobile,Gender,Address,Country,Privilage,Language) values('" + Txtname.Text + "','" + Txtpwd.Text + "','" + Txtemail.Text + "','" + Txtmob.Text + "','" + RBL1.SelectedValue + "','" + Txtadd.Text + "','" + DDLcoun.SelectedValue + "','" + DDLpri.SelectedValue + "','" + strl + "')";
            cx=ob.OpenConnection();
            ob.inserquery(str);
            //cx.Close();
            Lblstat.Text = "add successfully";
        }
        catch (Exception ex)
        {
            Lblstat.Text = "error";
        }
    }
    protected void c1data(object sender, EventArgs e)
    {
        try
        {
            dbConn ob = new dbConn();
            String strl = "", str = "";
            foreach (ListItem i in CB1.Items)
                if (i.Selected)
                    strl += i.ToString() + " ";
            str += "select * from tbl";
            cx = ob.OpenConnection();
            dt = ob.sel(str).Tables[0];
            cx.Close();
            Lblstat.Text = "add successfully";
        }
        catch (Exception ex)
        {
            Lblstat.Text = "error";
        }
    }
}