﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 459px;
        }
    </style>
</head>
<body style="height: 461px">
    <form id="form1" runat="server">
        <div style="height: 161px">
            <asp:TextBox ID="txtItemID" runat="server" style="z-index: 1; left: 124px; top: 33px; position: absolute"></asp:TextBox>
        </div>
        <asp:Label ID="lblItemID" runat="server" style="z-index: 1; left: 11px; top: 33px; position: absolute" Text="ItemID" width="100px"></asp:Label>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 349px; top: 30px; position: absolute" Text="Find" />
        <p style="height: 215px">
            <asp:Label ID="lblSupplierID" runat="server" style="z-index: 1; left: 9px; top: 64px; position: absolute" Text="Supplier ID" width="100px"></asp:Label>
            <asp:Label ID="lblItemPrice" runat="server" Text="Item Price                           "></asp:Label>
            <asp:TextBox ID="txtItemPrice" runat="server" Height="16px" style="margin-top: 16px; margin-bottom: 0px;" Width="102px"></asp:TextBox>
            <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 364px; top: 223px; position: absolute" Text="Return to main menu" />
        </p>
        <asp:TextBox ID="txtSupplierID" runat="server" style="z-index: 1; left: 124px; top: 61px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblItemName" runat="server" style="z-index: 1; left: 10px; top: 97px; position: absolute; bottom: 343px;" Text="Item Name" width="100px"></asp:Label>
        <asp:TextBox ID="txtItemDescription" runat="server" style="z-index: 1; left: 124px; top: 129px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtItemName" runat="server" style="z-index: 1; left: 124px; top: 94px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblItemDescription" runat="server" style="z-index: 1; left: 10px; top: 129px; position: absolute" Text="Item Description"></asp:Label>
        </p>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 11px; top: 167px; position: absolute; height: 1px" Text="Supply Date" width="100px"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 122px; top: 167px; position: absolute; width: 119px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p style="height: 249px">
            <asp:CheckBox ID="chkInStock" runat="server" style="z-index: 1; left: 95px; top: 261px; position: absolute" Text="In Stock?" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 64px; top: 317px; position: absolute" Text="Cancel" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 283px; position: absolute; height: 34px" Text="Label"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 19px; top: 318px; position: absolute" Text="OK" />
    </form>
</body>
</html>
