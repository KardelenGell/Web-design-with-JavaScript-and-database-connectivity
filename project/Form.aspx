<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="FinalProject.Form" MasterPageFile="~/Site3.Master" %>


<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <p>
      
        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Black" Text="Label"></asp:Label>
    </p>
    <p>
      
        &#304;sim:</p>
    <p>
      
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
      
        &nbsp;</p>
    <p>
      
        Soyisim:</p>
    <p>
      
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
      
        &nbsp;</p>
    <p>
      
        &#304;ncelenmesini istedi&#287;iniz kitap önerisi:</p>
    <p>
      
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
      
        &nbsp;</p>
    <p>
      
        &#304;ncelenmesini istedi&#287;iniz kitab&#305;n türü:</p>
    <p>
      
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
    </p>
    <p>
      
        &nbsp;</p>
    <p>
      
        Sayfam&#305;zda incelenmesini istedi&#287;iniz ba&#351;ka tür veya türler varsa lütfen seçin!</p>
    <p>
      
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
        </asp:CheckBoxList>
    </p>
    <p>
      
        &nbsp;</p>
    <p>
      
        Yeni bir tür ekleyebilir ya da yarars&#305;z oldu&#287;unu dü&#351;ündü&#287;ünüz bir türü kald&#305;rabilirsiniz!</p>
    <p>
      
        <asp:Label ID="Label2" runat="server" Text="Tür ID         : "></asp:Label>
&nbsp;<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    </p>
    <p>
      
        <asp:Label ID="Label3" runat="server" Text="Tür &#304;smi : "></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    </p>
    <p>
      
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Tür Ekle" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Tür Sil" />
    &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Tür Güncelle" />
    </p>
    <p>
      
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Güncel Tür Tablosunu Göster" />
      
        &nbsp;&nbsp;
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
&nbsp;&nbsp;&nbsp; 
    </p>
    <p>
      
        Yorumlar&#305;n&#305;z:</p>
    <p>
      
        <asp:TextBox ID="TextBox4" runat="server" Height="92px" Width="480px"></asp:TextBox>
    </p>
    <p>
   
        <asp:Button ID="Button1" runat="server" ForeColor="Black" OnClick="Button1_Click" Text="Gönder" />
    </p>
    <p>
   
        <asp:Label ID="Label4" runat="server" ForeColor="Red" Text="Label"></asp:Label>
    </p>
    <p>
      
        &nbsp;</p>
</asp:Content>



