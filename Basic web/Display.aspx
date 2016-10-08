<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Display.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title>
<style>
    .dis
    {
        font-size:x-large;
        color:#00ffff;
    }
    .display
    {
        font-size:large;
        color:#66ff66;
    }
    td
    {
        padding:5px;
    }
    </style>
</head>

<body bgcolor=#222222>
    <form id="form1" runat="server">
    <div class="dis">
        <asp:Button ID="BtnSubmit" runat="server" Text="Click to Login" 
                onclick="c1data"/>
    </div>
    <div class="display" width = 200px >
        <asp:Label ID="Lblstat" runat="server" Text=""></asp:Label><br />
    <asp:GridView ID="GV" runat="server">
    </asp:GridView>
    </div>
    </form>
</body>
</html>
