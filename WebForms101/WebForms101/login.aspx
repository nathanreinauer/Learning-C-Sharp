<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebForms101.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        First Name:<asp:TextBox ID="TextBox1" runat="server" Height="16px" style="margin-left: 31px" Width="165px"></asp:TextBox>
    
    </div>
        <p>
            Last Name:<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 33px" Width="161px"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Login" />
        <p>
            <asp:TextBox ID="TextBox3" runat="server" Width="222px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
