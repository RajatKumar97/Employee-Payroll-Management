<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
      <link type="text/css" rel="stylesheet" href="StyleSheet.css" />
    <head runat="server">
    <title></title>
</head>
<body>
    <div>
        <center>
    <fieldset style="height:350px ;width:400px">
        <legend>  Register here</legend>
    <form id="form1" runat="server">
    <div>
    
    
        <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
        
        <asp:TextBox ID="TextBox1" runat="server" CssClass="textbox" ></asp:TextBox>
         <br />
        <asp:Label ID="Label5" runat="server" Text="Last Name"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" CssClass="textbox"></asp:TextBox>
    
        </div>
        
            <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="textbox"></asp:TextBox>
        <br />

        <asp:Label ID="Label6" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" CssClass="textbox"></asp:TextBox>
        <br />

        <asp:Label ID="Label7" runat="server" Text="ConfirmPassword" CssClass="textbox"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" CssClass="textbox"></asp:TextBox>
        <asp:Label ID="Label8" runat="server" Text="Label" CssClass="textbox"></asp:Label>
       <br /> 
        
             <label>Date of Birth</label>
            <asp:Calendar ID="Calendar1" runat="server" Height="21px" Width="16px"></asp:Calendar>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SignUp" />
            <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
            </form>
      </fieldset>
            </center>
        </div>
</body>
</html>
