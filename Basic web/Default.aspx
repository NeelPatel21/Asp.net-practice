<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    .ne
    {
        color:#1010ff;
        font-size:xx-large;
    }
    .display
    {
        font-size:large;
        color:#00bb00;
        margin-left:500px;
    }
    .dis
    {
        font-size:large;
        color:#00ffff;
        margin-left:500px;
    }
    </style>
</head>
<body bgcolor=#222222>
    <form id="form1" runat="server">
    <asp:HyperLink ID="Hllogin" runat="server" NavigateUrl="~/Login.aspx" ForeColor="#FF9900" Font-Size="15" Font-Underline="False">Login</asp:HyperLink>
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
        <tr><td><asp:Label ID="Lblcpas" runat="server" Text="Confirm Password"></asp:Label></td>
            <td><asp:TextBox ID="Txtcpwd" runat="server" TextMode="password"></asp:TextBox></td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="Txtpwd" ControlToValidate="Txtcpwd" 
                    ErrorMessage="Password not match" ForeColor="#FF9900"></asp:CompareValidator>
            </td>
        </tr>
        <tr><td><asp:Label ID="Lblmob" runat="server" Text="Mobile"></asp:Label></td>
            <td><asp:TextBox ID="Txtmob" runat="server" ></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ErrorMessage="Number required" ControlToValidate="Txtmob" 
                    ForeColor="#FF9900" Display="Dynamic"></asp:RequiredFieldValidator>
                
            </td>
        </tr>
        <tr><td><asp:Label ID="Lblemail" runat="server" Text="Email"></asp:Label></td>
            <td><asp:TextBox ID="Txtemail" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ErrorMessage="Email required" ControlToValidate="Txtemail" 
                    ForeColor="#FF9900" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="Txtemail" ErrorMessage="Invalid Email" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    ForeColor="#FF9900" Display="Dynamic"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
        <td><asp:Label ID="Lblpri" runat="server" Text="Privilage"></asp:Label></td>
        <td><asp:DropDownList ID="DDLpri" runat="server" >
            <asp:ListItem Value="user">User</asp:ListItem>
            <asp:ListItem Value="admin">Admin</asp:ListItem>
            <asp:ListItem Value="customer">Customer</asp:ListItem>
        </asp:DropDownList>
        </td>
        </tr>
        <tr>
        <td><asp:Label ID="Lblgen" runat="server" Text="Gender"/></td>
        <td><asp:RadioButtonList ID="RBL1" runat="server">
            <asp:ListItem Value="Female">female</asp:ListItem>
            <asp:ListItem Value="Male">male</asp:ListItem>
        </asp:RadioButtonList>
        </td>
        </tr>
        <tr>
        <td><asp:Label ID="Lbllan" runat="server" Text="Language"/></td>
        <td><asp:CheckBoxList ID="CB1" runat="server">
            <asp:ListItem Value="java">java</asp:ListItem>
            <asp:ListItem Value="php">php</asp:ListItem>
            <asp:ListItem Value=".net">.net</asp:ListItem>
        </asp:CheckBoxList><br />
        </td>
        </tr>
        <tr>
        <td><asp:Label ID="Lbladd" runat="server" Text="Address"></asp:Label></td>
        <td><asp:TextBox ID="Txtadd" runat="server" TextMode="MultiLine" Width="150px" Height="60px"></asp:TextBox><br />
        </td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ErrorMessage="address required" ControlToValidate="Txtadd" 
                    ForeColor="#FF9900"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
        <td><asp:Label ID="Lblcoun" runat="server" Text="Country"></asp:Label></td>
        <td><asp:DropDownList ID="DDLcoun" runat="server" >
            <asp:ListItem Value="user">User</asp:ListItem>
            <asp:ListItem Value="admin">Admin</asp:ListItem>
            <asp:ListItem Value="customer">Customer</asp:ListItem>
        </asp:DropDownList>
        </td>
        </tr>
        <tr ><td><asp:Button ID="BtnSubmit" runat="server" Text="Click to Login" onclick="cdata" /><br />
        </td></tr>
        </table>
    </div>
    <div class="display" width = 200px >
        <asp:Label ID="Lblstat" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Lblname1" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Lblpass1" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Lblemail1" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Lblpri1" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Lblgen1" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Lbladd1" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Lblcoun1" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Lbllan1" runat="server" Text=""></asp:Label><br />
    </div>

    </form>

</body>
</html>
