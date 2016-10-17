<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PapaBobsPizzaMegaChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="page-header">
                        <h1>Papa Bob's Pizza</h1>
                        <p class="lead">Pizza to code by</p>
                    </div>
                    
                    <div class="form-group">
                        <label>Size:</label>
                        <asp:DropDownList ID="sizeDropDownList" runat="server" CssClass="form-control">
                            <asp:ListItem Text="Small (12 inch - $12)" Value="Small" />
                            <asp:ListItem Text="Option 2" Value="Medium" />
                            <asp:ListItem Text="Option 3" Value="Fast" />
                        </asp:DropDownList>
                    </div>

                    <div class="form-group">
                        <label>Crust:</label>
                        <asp:DropDownList ID="crustDropDownList" runat="server" CssClass="form-control">
                            <asp:ListItem Text="Regular" Value="Small" />
                            <asp:ListItem Text="Option 2" Value="Medium" />
                            <asp:ListItem Text="Option 3" Value="Fast" />
                        </asp:DropDownList>
                    </div>

                    <div class="checkbox">
                        <label>
                            <asp:CheckBox ID="sausaugeCheckBox" runat="server"></asp:CheckBox>
                            Sausage
                        </label>
                    </div>

                    <div class="checkbox">
                        <label>
                            <asp:CheckBox ID="pepperoniCheckBox" runat="server"></asp:CheckBox>
                            Pepperoni
                        </label>
                    </div>

                    <div class="checkbox">
                        <label>
                            <asp:CheckBox ID="onionsCheckBox" runat="server"></asp:CheckBox>
                            Onions
                        </label>
                    </div>

                    <div class="checkbox">
                        <label>
                            <asp:CheckBox ID="greenPeppersCheckBox" runat="server"></asp:CheckBox>
                            Green Peppers
                        </label>
                    </div>

                    <h3>Deliver To:</h3>

                    <div class="form-group">
                        <label>Name:</label>
                        <asp:TextBox ID="nameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label>Address:</label>
                        <asp:TextBox ID="addressTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label>Zip Code:</label>
                        <asp:TextBox ID="zipTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label>Phone Number:</label>
                        <asp:TextBox ID="phoneTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <h3>Payment:</h3>

                    <div class="radio">
                        <label>
                            <asp:RadioButton ID="cashRadioButton" runat="server" GroupName="PaymentGroup"></asp:RadioButton>Cash
                        </label>
                    </div>
                    <div class="radio">
                        <label>
                            <asp:RadioButton ID="creditRadioBox" runat="server" GroupName="PaymentGroup"></asp:RadioButton>Credit
                        </label>
                    </div>

                    <asp:Button ID="orderButton" runat="server" Text="Order" CssClass="btn btn-lg btn-primary" />

                    <h3>Order Total:</h3>

                    <p>
                        <asp:Label ID="resultLabel" runat="server" />
                    </p>

                </div>
            </div>
        </div>
    </form>
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
