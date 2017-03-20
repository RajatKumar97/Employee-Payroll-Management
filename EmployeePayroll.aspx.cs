using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Diagnostics;

public partial class EmployeePayroll : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = (string)Session["employeeid"];
        /*  MySqlConnection con = new MySqlConnection();
          MySqlCommand command = null;
          MySqlDataReader reader = null;

          //    string query;

          try
          {
              con.ConnectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=finalproject";

              //  string query = "select * from payroll where EmployeeId='"+ (string)Session["employeeid"] +"'";
              string query = "select * from payroll";

              command = new MySqlCommand(query, con);
              Label1.Text = "Connected to Database";
              con.Open();

              reader = command.ExecuteReader();

              // while (reader.Read())
              while (reader.Read())
              {
                  Label1.Text = reader.GetString(0);
                    Label2.Text = reader.GetString(1);
                  //   Label9.Text = "Inserted Successfully";
                  //Server.Transfer("Default.aspx", true);

              }


          }
          catch (Exception ex)
          {
              Debug.WriteLine(ex.Message);
              Debug.WriteLine(ex.StackTrace);
          } */
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = (string)Session["empid"];
    }
}