using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

public partial class AdminIndex : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = (string)Session["email"];
        
        if (Session["email"] != null)

        {
            Button2.Visible = true;
        }
        else
        { Button2.Visible = false; }
     //   string MyConnection2 = "server=localhost;user id=root;persistsecurityinfo=True;database=finalproject";
        //Display query  
      //  string Query = "select * from signup;";
       // MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
       // MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
        //MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
        //MyAdapter.SelectCommand = MyCommand2;
        DataTable dTable = new DataTable();
      

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand command = null;
        SqlDataReader reader = null;
        string email = TextBox18.Text;

        string empid = TextBox9.Text;
        int  Monday = Convert.ToInt32(TextBox1.Text);
        int Tuesday = Convert.ToInt32(TextBox2.Text);
        int Wednesday = Convert.ToInt32(TextBox3.Text);
        int Thursday = Convert.ToInt32(TextBox4.Text);
        int Friday = Convert.ToInt32(TextBox5.Text);
        int Saturday = Convert.ToInt32(TextBox6.Text);
        int Sunday = Convert.ToInt32(TextBox7.Text);
        int TotalHours = Monday + Tuesday + Wednesday + Thursday + Friday + Saturday + Sunday;
        int Monday1 = Convert.ToInt32(TextBox11.Text);
        int Tuesday1 = Convert.ToInt32(TextBox12.Text);
        int Wednesday1 = Convert.ToInt32(TextBox13.Text);
        int Thursday1 = Convert.ToInt32(TextBox14.Text);
        int Friday1 = Convert.ToInt32(TextBox15.Text);
        int Saturday1 = Convert.ToInt32(TextBox16.Text);
        int Sunday1 = Convert.ToInt32(TextBox17.Text);
        int TotalHours2 = Monday1 + Tuesday1 + Wednesday1 + Thursday1 + Friday1 + Saturday1 + Sunday1;
        DateTime StartDate;
        StartDate = Calendar1.SelectedDate;
        DateTime EndDate;
        EndDate = Calendar2.SelectedDate;
        int total1 = Monday + Monday1 + Tuesday + Tuesday1 + Wednesday + Wednesday1 + Thursday + Thursday + Friday + Friday1 + Saturday + Saturday1 + Sunday + Sunday1;
        double tax = total1*0.13;
        double total = total1 + tax;
        
        //    string query;

        try
        {
            con.ConnectionString = "workstation id = Epayroll.mssql.somee.com; packet size = 4096; user id = Rrajatkumar7465_SQLLogin_1; pwd = baqckhp38b; data source = Epayroll.mssql.somee.com; persist security info = False; initial catalog = Epayroll";
               string query = "insert into Payroll(email,StartDate,Endate,EmployeeId,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday,TotalHours,Monday1,Tuesday1,Wednesday1,Thursday1,Friday1,Saturday1,Sunday1,Tax,Total) values('"+email+"','"+StartDate+"','"+EndDate+"','"+empid+"','" + Monday + "','" + Tuesday + "','" + Wednesday + "','" + Thursday + "','" + Friday + "','"+Saturday+"','"+Sunday+"','"+TotalHours+"','"+Monday1+"','"+Tuesday1+"','"+Wednesday1+"','"+Thursday1+"','"+Friday1+"','"+Saturday1+"','"+Sunday1+"','"+tax+"','"+total+"')";
//string query = "insert into payroll(email,monday,tuesday) values('" + email + "','" + Monday + "','" + Tuesday + "')";

                command = new SqlCommand(query, con);
            Label1.Text = "inserted";
            con.Open();

                reader = command.ExecuteReader();
           
            // while (reader.Read())
            while (reader.Read())
                {
                 //   Label1.Text = "Inserted Successfully";
                    //Server.Transfer("Default.aspx", true);
                    
                }
            con.Close();
           
        }
        catch (Exception ex)
        {
            Label1.Text = "query error";
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Session.Remove("email");
        Response.Redirect(Request.RawUrl);
    }
}