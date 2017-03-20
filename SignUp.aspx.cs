using System;
using System.Data.SqlClient;
using System.Diagnostics;

public partial class SignUp : System.Web.UI.Page
{
    private object calenderUserDate;

    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand command = null;
        SqlDataReader reader = null;
        string ss = TextBox1.Text;
        string ss2 = TextBox2.Text;
        string ss3 = TextBox3.Text;
        string ss4 = TextBox4.Text;
        string ss5 = TextBox5.Text;
        DateTime dtUserDate;
        dtUserDate = Calendar1.SelectedDate;



        //    string query;

        try
        {
            con.ConnectionString = "workstation id = Epayroll.mssql.somee.com; packet size = 4096; user id = Rrajatkumar7465_SQLLogin_1; pwd = baqckhp38b; data source = Epayroll.mssql.somee.com; persist security info = False; initial catalog = Epayroll";
            //  if (TextBox4.Text == TextBox5.Text)
            // {


            string query = "insert into signup (FirstName,LastName,Email,Password,ConfirmPassword,DateOfBirth)values('" + ss + "','" + ss2 + "','" + ss3 + "','" + ss4 + "','" + ss5 + "','"+dtUserDate+"')";


                command = new SqlCommand(query, con);
                Label9.Text = "Connected to Database";
                con.Open();
         //   command.ExecuteNonQuery();
                reader = command.ExecuteReader();
            Label9.Text = "inserted";
                // while (reader.Read())
                while (reader.Read())
                {
                   //   Response.Redirect("www.google.com");
                    //Label9.Text = "inserted";
                    //   Label3.Text = reader.GetString(0);
                    //  Label2.Text = reader.GetString(1);
                    //Debug.WriteLine(reader.GetString(0));
                    //Debug.WriteLine(reader.GetString(1));
                }

            // }
            //else
            //{
            //  Label8.Text = "password not match";
            //}
            con.Close();
        }
        catch (Exception ex)
        {
            Label9.Text = "query error";
        }
    }
}
