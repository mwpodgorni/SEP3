<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="CarRentalWebApplication.SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            text-align: center;
            height: 42px;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 933px;
        }
        .auto-style4 {
            width: 935px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1" style="padding: 20px; margin-bottom: 0px; margin-top: 0px;">
            <strong>Sign in to continue</strong></div>
        <table class="auto-style2">
            <tr>
                <td style="text-align: right" class="auto-style4">Email:&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBoxEmail" runat="server" TextMode="Email" Width="655px"></asp:TextBox>
                </td>
          
            </tr>
            <tr>
                <td style="text-align: right" class="auto-style4">Password:&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password" Width="655px"></asp:TextBox>
                </td>
              
            </tr>
            <tr>
                <td class="auto-style4">Help</td>  <td>Register</td>
                <td class="auto-style3">
                    <asp:Button ID="ButtonSignIn" runat="server" OnClick="ButtonSignIn_Click" Text="Sign In" />
                </td>
              
            </tr>
        
        </table>
    </form>
</body>
</html>
