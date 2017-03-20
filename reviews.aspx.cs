using System;
using System.Data.SqlClient;
using System.Diagnostics;

public partial class reviews : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();
    SqlCommand command = null;
    SqlDataReader reader = null;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        Label8.Text = (string)Session["email"];

        if (Session["email"] != null)

        {
            Button2.Visible = true;
        }
        else
        { Button2.Visible = false;
            Response.Redirect("Default.aspx");

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string value1 = RadioButtonList1.SelectedValue;
        string value2 = RadioButtonList2.SelectedValue;
        string value3 = RadioButtonList3.SelectedValue;
        string value4 = RadioButtonList4.SelectedValue;
        string value5 = RadioButtonList5.SelectedValue;
        string value6 = RadioButtonList6.SelectedValue;
        string fedback = TextBox1.Text;
        string email = (string)Session["email"];

        try
        {
            string query = "insert into reviews  (email,Question1, Question2, Question3, Question4, Question5, Question6,Feedback)values('" + email + "','" + value1 + "', '" + value2 + "', '" + value3 + "', '" + value4 + "', '" + value5 + "', '" + value6 + "','" + fedback + "')";

            con.ConnectionString = "workstation id = Epayroll.mssql.somee.com; packet size = 4096; user id = Rrajatkumar7465_SQLLogin_1; pwd = baqckhp38b; data source = Epayroll.mssql.somee.com; persist security info = False; initial catalog = Epayroll";
            command = new SqlCommand(query, con);

            con.Open();
            Label7.Text = "inserted";

            reader = command.ExecuteReader();

            // while (reader.Read())
            while(reader.Read() == true)
            {
                //  Response.Redirect("www.google.com");
               // Response.Redirect("AdminIndex.aspx");
                //   Server.Transfer("SignUp.aspx", true);

            }
            //else
           // {
            //     Label7.Text = "Query error";
            //}
        }
        catch (Exception ex)
        {
            Label7.Text = "query error";
            //  Debug.WriteLine(ex.Message);
            //  Debug.WriteLine(ex.StackTrace);
        }
    }
    

    protected void Button2_Click1(object sender, EventArgs e)
    {
        Session.Remove("email");
        Response.Redirect(Request.RawUrl);
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("showpayroll.aspx");
    }

   
}
