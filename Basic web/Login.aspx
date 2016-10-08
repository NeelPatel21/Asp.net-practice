<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title>
<style>
    .dis
    {
        font-size:x-large;
        color:#00ffff;
        margin-left:500px;
        padding-top:50px;
    }
    .display
    {
        font-size:large;
        color:#66ff66;
        margin-left:500px;
        padding-top:50px;
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
        <table>
        <tr><td><asp:Label ID="Lblname" runat="server" Text="Name"></asp:Label></td>
            <td><asp:TextBox ID="Txtname" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ErrorMessage="name required" ControlToValidate="Txtname" 
                    ForeColor="#FF9900" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr><td><asp:Label ID="Lblpas" runat="server" Text="Password"></asp:Label></td>
            <td><asp:TextBox ID="Txtpwd" runat="server" TextMode="password"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ErrorMessage="password required" ControlToValidate="Txtpwd" 
                    ForeColor="#FF9900"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr><td><asp:Button ID="BtnSubmit" runat="server" Text="Click to Login" 
                onclick="pdata"/>
            </td>
            <td><asp:Button ID="Btndel" runat="server" Text="Click to Delete" 
                onclick="ddata"/>
            </td>
        </tr>
        </table>
    </div>
    <div class="display" width = 200px >
        <asp:Label ID="Lblstat" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Lblname1" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Lblemail1" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Lblmob1" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Lblgen1" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Lbladd1" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Lblcoun1" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Lblpri1" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Lbllan1" runat="server" Text=""></asp:Label><br />
    </div>
    </form>
</body>
</html>
