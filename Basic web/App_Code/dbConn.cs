using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;
/// <summary>
/// Summary description for dbConn
/// </summary>
public class dbConn
{
    public SqlConnection con = new SqlConnection();
    public SqlCommand cmd = new SqlCommand();
    public SqlDataAdapter da = new SqlDataAdapter();
    public DataTable dt = new DataTable();

    public dbConn()
    {
        con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\My folder\Fun\Data\Asp.net\Basic web\App_Data\Database2.mdf;Integrated Security=True;User Instance=True";
        //My.Settings.CDRConnectionString           
        con.Open();
    }
    public SqlConnection OpenConnection()
    {
        try
        {
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\My folder\Fun\Data\Asp.net\Basic web\App_Data\Database2.mdf;Integrated Security=True;User Instance=True";
            //My.Settings.CDRConnectionString           
            con.Open();

            return con;
        }
        catch (Exception ex)
        {
            return null;
        }
    }
    public string inserquery(string insertdata)
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }

        cmd.Connection = con;
        cmd.CommandText = insertdata;
        cmd.CommandTimeout = 0;
        cmd.ExecuteNonQuery();
        //sqlsda.SelectCommand = sqlcmd 
        //sqlsda.Fill(sqldataset)
        return "0";
    }

    public DropDownList fillcombo(string str1, DropDownList cmb)
    {

        DataSet ds = new DataSet();

        //If ds.Tables(0).Rows.Count - 1 = 0 Then
        //    MsgBox(" their is no record ")
        //    Return Nothing
        //End If
        //cmb.DataSource = ds.Tables(0)
        if (con.State == ConnectionState.Closed)
        {
            con.Open();

        }
        SqlDataAdapter dap = new SqlDataAdapter(str1, con);
        dap.Fill(ds);


        cmb.DataSource = ds.Tables[0];
        cmb.DataValueField = ds.Tables[0].Columns[0].ColumnName;
        cmb.DataTextField = ds.Tables[0].Columns[1].ColumnName;
        cmb.DataBind();
        //cmb.Items.Add(ds.Tables(0).Rows(i).Item(0))

        return null;
    }

    public System.Data.DataSet sel(string str)
    {
        DataSet sqldataset = new DataSet();
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        SqlDataAdapter da = new SqlDataAdapter(str, con);
        da.SelectCommand.CommandTimeout = 0;
        da.Fill(sqldataset);
        con.Close();
        return sqldataset;
    }




}