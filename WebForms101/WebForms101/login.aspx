<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebForms101.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 200px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="First Name:"></asp:Label>
        <asp:TextBox ID="txtFirst" runat="server" Height="16px" style="margin-left: 31px" Width="165px"></asp:TextBox>
    
    </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Last Name:"></asp:Label>
            <asp:TextBox ID="txtLast" runat="server" style="margin-left: 33px" Width="161px"></asp:TextBox>
        </p>
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Login" />
        <p>
            <asp:Label ID="lblName" runat="server" BorderStyle="Inset" Width="260px"></asp:Label>
        </p>
    </form>
</body>
</html>
