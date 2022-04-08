using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;



namespace WebApplication1
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            if (!IsPostBack)
            {
                Gvbind();
            }
        }
        protected void Gvbind()
        {
            string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select Name,City from Employee", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    GridView1.DataSource = dr;
                    GridView1.DataBind();


                 }
            }
        }
    }
}