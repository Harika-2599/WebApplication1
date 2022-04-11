using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebApplicationUsingLoops
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            




                string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM tblEmployees", con);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);



                //foreach (DataRow rows in dt.Rows)
                //{
                // if (Convert.ToInt32(rows["eid"]) == 2)
                // {
                // rows["eid"] = 8;
                // }
                //}
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dt.Rows[i]["EmployeeId"]) == 2)
                        dt.Rows[i]["EmployeeId"] = 4;
                }



                GridView1.DataSource = dt;
                GridView1.DataBind();





                string rowValue = string.Empty;
                foreach (DataRow row in dt.Rows)
                {
                    rowValue = row["EmployeeId"] + " ,";
                }
            }

        }



    }

    