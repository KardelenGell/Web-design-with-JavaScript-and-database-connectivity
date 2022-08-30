<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="FinalProject.LoginPage" MasterPageFile="~/Site3.Master" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <p>
      
    &nbsp;</p>
<p>
      
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Maroon" Text="Üye Giri&#351;i"></asp:Label>
      
    </p>
<p>
      
    Kullan&#305;c&#305; Ad&#305;:
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
      
    </p>
<p>
      
    &#350;ifre:&nbsp; &nbsp;
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
      
    </p>
<p>
      
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Font-Bold="True" ForeColor="Maroon" OnClick="Button1_Click" Text="Giri&#351;" />
      
    </p>
<p>
      
    <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="Label"></asp:Label>
      
    </p>
<p>
      
    &nbsp;</p>
</asp:Content>




