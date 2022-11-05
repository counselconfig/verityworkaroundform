<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="verityworkaround.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>verity workaround</title>
</head>
<body>
    <form id="WebForm1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Lettercode"></asp:Label>  
             <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />  
             <asp:Label ID="Label2" runat="server" Text="Class number"></asp:Label>  
             <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /><br />  
             <asp:Label ID="Label3" runat="server" Text="Minimum Reference"></asp:Label>  
             <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br /><br />  
             <asp:Label ID="Label4" runat="server" Text="Maximum Reference"></asp:Label>  
             <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br /><br /><br /> 
             <asp:Label ID="Label5" runat="server" Text="EditSetID"></asp:Label>  
             <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br /><br /><br />  
             <asp:Button ID="Button1" runat="server" Text="Add Piece" OnClick="Button1_Click" /> 
        </div>
    </form>
</body>
</html>

<!--needs to be aligned DL-->