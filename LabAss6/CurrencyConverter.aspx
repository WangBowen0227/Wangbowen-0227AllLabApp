<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CurrencyConverter.aspx.cs" Inherits="LabAss6.CurrencyConverter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Label ID="Label1" runat="server" Text="Convert："></asp:Label>
            <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
            <asp:Label ID="lblmessage" runat="server" Text="" ForeColor="Red"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Chinese Yuan to Dollars"></asp:Label>
            :<br />
            <asp:Button ID="btnOK" runat="server" OnClick="Button1_Click" Text="OK" />
            
            <br />
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            Chinese Yuan= 
            <asp:Label ID="lblDollars" runat="server"></asp:Label>
            Dollar.</div>
    </form>
</body>
</html>
