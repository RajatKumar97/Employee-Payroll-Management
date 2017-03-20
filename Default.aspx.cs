using System;
using System.Data.SqlClient;
using System.Diagnostics;


public partial class _Default : System.Web.UI.Page
{
    //    private object request;

    SqlConnectionStringBuilder table = new SqlConnectionStringBuilder();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand command = null;
        SqlDataReader reader = null;
       
         string password = TextBox2.Text;
        string email = TextBox1.Text;
        Session["Email"] = "";
        Session["employeeid"] = "";
        //  String temp = (string)Session["Email"]; // String temp2 = (string)Session["employeeid"];
        
        Session["Email"] = "";
        try
        {
            con.ConnectionString = "workstation id = Epayroll.mssql.somee.com; packet size = 4096; user id = Rrajatkumar7465_SQLLogin_1; pwd = baqckhp38b; data source = Epayroll.mssql.somee.com; persist security info = False; initial catalog = Epayroll";
            string query = "select * from SignUp where Email='" + email + "' and password='" + password + "'";
            command = new SqlCommand(query,con);

            Label1.Text = "Connected to Database";
          

            con.Open();
            Session["email"] = email;

         //   command.ExecuteNonQuery();
           reader = command.ExecuteReader();
          
           // while (reader.Read())
       while(reader.Read())
            {
             // Response.Redirect("EmployeePayroll.aspx");
           //   string employeeid=  reader.GetString(0);
               
                //Response.Redirect("showPayroll.aspx", true);
              Response.Redirect("reviews.aspx");

            }
       
           
        }
        catch (Exception ex)
        {
            Label1.Text = "query error";
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("SignUp.aspx");
    }
}