<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Connect_To_Database.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 103px;
        }

        .body h1 {
            text-align: center;
        }

        .auto-style2 {
            width: 61%;
            margin: auto;
        }
        .ancer a{
            text-decoration:none;
            font-size:20px;
            color:red;
        }
        .ancer a:hover {
            color:orange;
        }
    </style>
    <script type="text/javascript">
        //Another Method To Show Password
        function showpassword(checkbox) {
            var passstextbox = document.getElementById('TextBox2');
            if (checkbox.checkbox == true) {
                passstextbox.setAttribute("type","text");

            } else {
                passstextbox.setAttribute("type","password");

            }

        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="body">
            <h1>Login Form</h1>
            <div class="table">

                <table class="auto-style2">
                    <tr>
                        <td class="auto-style1">USERNAME :</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" Width="247px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Please Enter UserName" Font-Size="X-Small" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">PASSWORD :</td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server" Width="247px" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="Please Enter Password" Font-Size="X-Small" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                       <%-- <td>
                            <input type="checkbox" onchange="document.getElementById('TextBox2').type=this.Checked?'text':'password'"  />
                            Show Password</td>--%>
                       <td> <input type="checkbox" onclick="showpassword(this)"/> Show Password</td>

                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td>
                            <asp:Button ID="Button1" runat="server" Height="34px" Text="Sumbit" Width="100px" OnClick="Button1_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td class="ancer">
                            <a href="signup.aspx"> Not Registered ? SignUp</a></td>
                    </tr>
                </table>

            </div>
        </div>
    </form>
</body>
</html>
