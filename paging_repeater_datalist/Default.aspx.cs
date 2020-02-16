using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    Int32 CurrentPage;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Page.IsPostBack == false)
        {
            list_bind();
            ViewState["PageCount1"] = 0;

        }

        CurrentPage = Convert.ToInt32(ViewState["PageCount1"]);

    }
    private void list_bind()
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from tbemp", ConfigurationManager.ConnectionStrings["tbtempConnectionString"].ConnectionString);
        DataTable ds = new DataTable();
        adp.Fill(ds);
        // DataList1.DataSource = ds;
       //  DataList1.DataBind();
        DataListPaging(ds);
    }

    private void DataListPaging(DataTable ds)
    {
        //creating object of PagedDataSource;  


        PagedDataSource PD = new PagedDataSource();

        PD.DataSource = ds.DefaultView;
        PD.PageSize = 4;
        PD.AllowPaging = true;
        PD.CurrentPageIndex = CurrentPage;
        Button1.Enabled = !PD.IsFirstPage;
        Button2.Enabled = !PD.IsFirstPage;
        Button4.Enabled = !PD.IsLastPage;
        Button3.Enabled = !PD.IsLastPage;
        ViewState["TotalCount"] = PD.PageCount;
        DataList1.DataSource = PD;
        DataList1.DataBind();
        ViewState["PagedDataSurce"] = ds;
        Lbpageno.Text = "Page" + (CurrentPage + 1).ToString() + "of" + (ViewState["TotalCount"]).ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        CurrentPage = 0;
        DataList1.DataSource = (DataTable)ViewState["PagedDataSurce"];
        DataListPaging((DataTable)ViewState["PagedDataSurce"]);


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        CurrentPage = (int)ViewState["PageCount1"];
        CurrentPage -= 1;
        ViewState["PageCount1"] = CurrentPage;

        DataListPaging((DataTable)ViewState["PagedDataSurce"]);

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        CurrentPage = (int)ViewState["PageCount1"];
        CurrentPage += 1;
        ViewState["PageCount1"] = CurrentPage;
        DataListPaging((DataTable)ViewState["PagedDataSurce"]);

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        CurrentPage = (int)ViewState["TotalCount"] - 1;
        DataListPaging((DataTable)ViewState["PagedDataSurce"]);

    }




    /* protected void Button1_Click(object sender, EventArgs e)
     {
         string d = "";
         for(Int32 i=0; i<DataList1.Items.Count;i++)
         {
             CheckBox ch;
             ch = (CheckBox)(DataList1.Items[i].FindControl("chk"));
             if(ch.Checked)
             {
                 d += DataList1.DataKeys[i].ToString()+ ",";
             }

         }
         d = d.Substring(0, d.Length - 1);
         string qry = "select * from tbemp where eid in(" + d + ")";
         SqlDataAdapter adp = new SqlDataAdapter(qry, ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
         DataSet ds = new DataSet();
         adp.Fill(ds);
         Repeater1.DataSource = ds;
         Repeater1.DataBind();
     } */

    /* protected void chk_CheckedChanged(object sender, EventArgs e)
     {
         string d = "";
         for (Int32 i = 0; i < DataList1.Items.Count; i++)
         {
             CheckBox ch;
             ch = (CheckBox)(DataList1.Items[i].FindControl("chk"));
             if (ch.Checked)
             {
                 d += DataList1.DataKeys[i].ToString() + ",";
             }

         }
         d = d.Substring(0, d.Length - 1);
         string qry = "select * from tbemp where eid in(" + d + ")";
         SqlDataAdapter adp = new SqlDataAdapter(qry, ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
         DataSet ds = new DataSet();
         adp.Fill(ds);
         Repeater1.DataSource = ds;
         Repeater1.DataBind();
     }*/
}