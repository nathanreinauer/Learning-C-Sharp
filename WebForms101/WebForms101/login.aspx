<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebForms101.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 472px;
        }
    </style>
</head>
<body>
    <form data-bind="submit: addItem" id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="First Name:"></asp:Label>
        <asp:TextBox data-bind='value: itemToAdd, valueUpdate: "afterkeydown"' ID="txtFirst" runat="server" Height="16px" style="margin-left: 31px" Width="165px"></asp:TextBox>
    
    </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Last Name:"></asp:Label>
            <asp:TextBox data-bind="options: items" ID="txtLast" runat="server" style="margin-left: 33px" Width="161px"></asp:TextBox>
        </p>
        <asp:Button data-bind="enable: itemToAdd().length > 0" ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Sign Guestbook" />
        <p>
            <asp:Label data-bind="enable: itemToAdd().length > 0" ID="lblName" runat="server" BorderStyle="Inset" Width="260px"></asp:Label>
        </p>
        <p>
        </p>
        <asp:BulletedList  data-bind="enable: itemToAdd().length ID > 0" ID="BulletedList1" runat="server" Height="20px" OnClick="BulletedList1_Click" style="margin-left: 51px">
        </asp:BulletedList>
        <br />
        <br />
        <br />
    </form>
</body>




    <script src="http://knockoutjs.com/downloads/knockout-3.4.0.js">

        var SimpleListModel = function (items) {
            this.items = ko.observableArray(items);
            this.itemToAdd = ko.observable("");
            this.addItem = function () {
                if (this.itemToAdd() != "") {
                    this.items.push(this.itemToAdd()); // Adds the item. Writing to the "items" observableArray causes any associated UI to update.
                    this.itemToAdd(""); // Clears the text box, because it's bound to the "itemToAdd" observable
                }
            }.bind(this);  // Ensure that "this" is always this view model
        };

        ko.applyBindings(new SimpleListModel(["Alpha", "Beta", "Gamma"]));


    </script>


</html>
