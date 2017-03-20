using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Web.UI.WebControls;

public partial class showPayroll : System.Web.UI.Page
{
    StringBuilder table = new StringBuilder();

    protected void Page_Load(object sender, EventArgs e)
    {

        Label1.Text = (string)Session["email"];
        if (Session["email"] != null)

        {
            Button1.Visible = true;
        }
        else
        {
            Button1.Visible = false;
            Response.Redirect("Default.aspx");

        }


        string path = @"d:\MyTest.txt";
        string email= (string)Session["email"];
      //  string employeeid = (string)Session["employeeid"];


        SqlConnection con = new SqlConnection();
        
        SqlDataReader reader = null;
       
       // string empid = "select employee id from signup where email='" + email + "'";
      //  Label2.Text = Convert.ToString(employeeid) ;
        
        con.ConnectionString = "workstation id = Epayroll.mssql.somee.com; packet size = 4096; user id = Rrajatkumar7465_SQLLogin_1; pwd = baqckhp38b; data source = Epayroll.mssql.somee.com; persist security info = False; initial catalog = Epayroll";
        SqlCommand command = null;
       
        string query = "select  monday,tuesday,wednesday,thursday,friday,saturday,sunday,monday1,tuesday1,wednesday1,thursday1,friday1,saturday1,sunday1,startdate,endate,tax,total from payroll where email='"+email+"'";
        
        command = new SqlCommand(query, con);
        //command = new MySqlCommand(empid, con);
        con.Open();
        reader = command.ExecuteReader();
        table.Append("<table border=2 style=width: 100 %  >");
        table.Append("<tr><th>week </th><th>Monday</th><th>Tuesday</th><th>Wednesday</th><th>Thursday</th><th>Friday</th><th>Saturday</th><th>Sunday</th>");
        table.Append("</tr>");
       // table.Append("<tr><th>MONDAY1</th>");
         //table.Append("</tr>");
        if (reader.HasRows)
        {
            while (reader.Read())
            {
                Label2.Text = Convert.ToString(reader[14]);
                Label3.Text = Convert.ToString(reader[15]);
                Label4.Text = Convert.ToString(reader[16]);
                Label5.Text = Convert.ToString(reader[17]);
                table.Append("<tr>");
                table.Append("<th> Week 1 </th>");
                table.Append("<td>" + reader[0] + "</td>");
                table.Append("<td>" + reader[1] + "</td>");
                table.Append("<td>" + reader[2] + "</td>");
                table.Append("<td>" + reader[3] + "</td>");
                table.Append("<td>" + reader[4] + "</td>");
                table.Append("<td>" + reader[5] + "</td>");
                table.Append("<td>" + reader[6] + "</td>");
                //table.Append("<td>" + reader[7] + "</td>");

               table.Append("</tr>");
               
                table.Append("<tr>");
                table.Append("<th> Week 2</th>");
                table.Append("<td>" + reader[7] +" </td>");
                table.Append("<td>" + reader[8] + "</td>");
                table.Append("<td>" + reader[9] + "</td>");
                table.Append("<td>" + reader[10] + "</td>");
                table.Append("<td>" + reader[11] + "</td>");
                table.Append("<td>" + reader[12] + "</td>");
                table.Append("<td>" + reader[13] + "</td>");
                table.Append("</tr>");
              //  string eader1 = reader[0];
            }
           
        }
        table.Append("</table>");
        PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });

         string appendText = "This is extra text" +table.ToString() ;
       // string appendText = "This is extra text" + Convert.ToString(reader[0]);
        File.WriteAllText(path, appendText);

        reader.Close();

        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.Remove("email");
        //Response.Redirect(Request.RawUrl);
        Response.Redirect("Default.aspx");
    }

   
}