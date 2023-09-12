<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sandwichBuilder.aspx.cs" Inherits="Project1.sandwichBuilder" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sandwich Builder Recipt</title>
    <link href="sandwichBuilder.css" rel="stylesheet" type="text/css" />  
</head>
<body>
    <div class="center">
        <h2 contenteditable="true">Order Recipt</h2>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="Label2" runat="server" style="text-align: center" Text="Name:"></asp:Label>
        <asp:Label ID="lblName" runat="server"></asp:Label>
            <br />
         <asp:Label ID="Label13" runat="server" Text="Phone Number:"></asp:Label>
         <asp:Label ID="lblPhone" runat="server"></asp:Label>
            <br />
         <asp:Label ID="Label4" runat="server" style="height: 19px;" Text="Size:" width="28"></asp:Label>
         <asp:Label ID="lblSize" runat="server"></asp:Label>
            <br />
        <asp:Label ID="Label1" runat="server" Text="Bread:" style="height: 22px; width: 41px;"></asp:Label>
        <asp:Label ID="lblToasted" runat="server"></asp:Label>
            <br />
        <asp:Label ID="Label12" runat="server" Text="Spreads:"></asp:Label>
        <asp:Label ID="lblSpreads" runat="server"></asp:Label>
            <br />
        <asp:Label ID="Label3" runat="server" Text="Toppings:" width="59"></asp:Label>
        <asp:Label ID="lblToppings" runat="server"></asp:Label>
            <br />
        <asp:Label ID="Label5" runat="server" Text="Premium Toppings:"></asp:Label>
        <asp:Label ID="lblpToppings" runat="server" ></asp:Label>
            <br />
        <asp:Label ID="Label7" runat="server" style="text-align: justify; " Text="Meal:"></asp:Label>
        <asp:Label ID="lblMeal" runat="server"></asp:Label>
            <br />
        <asp:Label ID="Label8" runat="server" style="width: 34px; height: 15px;" Text="Drink:"></asp:Label>
        <asp:Label ID="lblDrink" runat="server"></asp:Label>
            <br />
        <asp:Label ID="Label9" runat="server" Text="Side:"></asp:Label>
        <asp:Label ID="lblSide" runat="server"></asp:Label>
            <br />
        <asp:Label ID="Label10" runat="server" Text="Tip:"></asp:Label>
        <asp:Label ID="lblTip" runat="server" style="height: 22px;"></asp:Label>
            <br />
        <asp:Label ID="Label11" runat="server" Text="Total:"></asp:Label>
        <asp:Label ID="lblTotal" runat="server"></asp:Label>
            <br />
        </div>
    </form>
    </div>
</body>
</html>
