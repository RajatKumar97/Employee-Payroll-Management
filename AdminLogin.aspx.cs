using System;
using System.Data.SqlClient;
using System.Diagnostics;


public partial class AdminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand command = null;
        SqlDataReader reader = null;
        string ss = TextBox1.Text;
        string email = TextBox1.Text;

        string ss2 = TextBox2.Text;
        Session["Email"] = "";

        string query = "select * from AdminLogin where Username='" + ss + "' and Password='" + ss2 + "'";

        try
        {
            con.ConnectionString = "workstation id = Epayroll.mssql.somee.com; packet size = 4096; user id = Rrajatkumar7465_SQLLogin_1; pwd = baqckhp38b; data source = Epayroll.mssql.somee.com; persist security info = False; initial catalog = Epayroll";
            command = new SqlCommand(query, con);
            Label1.Text = "Connected to Database";
            con.Open();
            Session["email"] = email;

            reader = command.ExecuteReader();

            // while (reader.Read())
            if (reader.Read() == true)
            {
                //  Response.Redirect("www.google.com");
                Response.Redirect("AdminIndex.aspx");
             //   Server.Transfer("SignUp.aspx", true);
             
            }
            else
            {
                Label1.Text = "Query error";
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            Debug.WriteLine(ex.StackTrace);
        }
    }
}