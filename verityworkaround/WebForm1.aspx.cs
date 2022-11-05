// verity workaround dominic.love@nationalarchives.gov.uk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

// grey dependencies above may not be needed but kept for caution 

namespace verityworkaround
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        SqlConnection con;
        //declare parameters 
        SqlCommand cmd = new SqlCommand();
        SqlParameter sp1 = new SqlParameter();
        SqlParameter sp2 = new SqlParameter();
        SqlParameter sp3 = new SqlParameter();
        SqlParameter sp4 = new SqlParameter();
        SqlParameter sp5 = new SqlParameter();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"server=; database=;uid=sa;pwd=");
            cmd.Parameters.Add("@lettercode", SqlDbType.VarChar).Value = TextBox1.Text;
            cmd.Parameters.Add("@class_no", SqlDbType.Int).Value = TextBox2.Text;
            cmd.Parameters.Add("@minPRef", SqlDbType.NVarChar).Value = TextBox3.Text;
            cmd.Parameters.Add("@maxPRef", SqlDbType.NVarChar).Value = TextBox4.Text;
            cmd.Parameters.Add("@editSetID", SqlDbType.Int).Value = TextBox5.Text;
            cmd = new SqlCommand("usp_Edit_InsertPiecesToEditSet", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open(); 
            cmd.ExecuteNonQuery(); // Procedure or function 'usp_Edit_InsertPiecesToEditSet' expects parameter '@lettercode', which was not supplied.'

            con.Close();
        }
    }
}