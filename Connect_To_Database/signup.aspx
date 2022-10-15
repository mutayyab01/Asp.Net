<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="Connect_To_Database.signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 135px;
        }
        .auto-style2 {
            width: 135px;
            height: 30px;
        }
        .auto-style3 {
            height: 30px;
        }
        #Button1{
            margin-left:150px;
            color:red;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="body">
            <div class="signup">

                <table style="width:100%;">
                    <tr>
                        <td class="auto-style1">First Name :</td>
                        <td>
                            <asp:TextBox ID="fTextBox1" runat="server" Width="227px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="fTextBox1" Display="Dynamic" ErrorMessage="Please Enter First Name" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Last Name :</td>
                        <td>
                            <asp:TextBox ID="lTextBox2" runat="server" Width="227px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lTextBox2" Display="Dynamic" ErrorMessage="Please Enter Last Name" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Gender :</td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="234px">
                                <asp:ListItem>--- Select Item ---</asp:ListItem>
                                <asp:ListItem>Male</asp:ListItem>
                                <asp:ListItem>Female</asp:ListItem>
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator InitialValue="--- Select Item ---" ID="RequiredFieldValidator3" runat="server" ControlToValidate="DropDownList1" Display="Dynamic" ErrorMessage="Please Select gender" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Age :</td>
                        <td>
                            <asp:TextBox ID="aTextBox3" runat="server" Width="227px" MaxLength="2" TextMode="Number"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="aTextBox3" Display="Dynamic" ErrorMessage="Please Enter Age" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">Username :</td>
                        <td class="auto-style3">
                            <asp:TextBox ID="uTextBox4" runat="server" Width="227px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="uTextBox4" Display="Dynamic" ErrorMessage="Please Enter Username" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Email :</td>
                        <td>
                            <asp:TextBox ID="eTextBox5" runat="server" Width="227px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="eTextBox5" Display="Dynamic" ErrorMessage="Please Enter Email" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="eTextBox5" Display="Dynamic" ErrorMessage="Email Is Not valid" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Password :</td>
                        <td>
                            <asp:TextBox ID="pTextBox6" runat="server" Width="227px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="pTextBox6" Display="Dynamic" ErrorMessage="Please Enter Password" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="pTextBox6" Display="Dynamic" ErrorMessage="Password Must Be Strong" ForeColor="Red" SetFocusOnError="True" ValidationExpression="(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Coonfirm Password : </td>
                        <td>
                            <asp:TextBox ID="cpTextBox7" runat="server" Width="227px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" Display="Dynamic" ErrorMessage="Please Enter Confirm Password" ForeColor="Red" SetFocusOnError="True" ControlToValidate="cpTextBox7"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="pTextBox6" ControlToValidate="cpTextBox7" Display="Dynamic" ErrorMessage="Password is not identical" ForeColor="Red" SetFocusOnError="True"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button ID="Button1" runat="server" Height="35px" Text="Submit" Width="85px" OnClick="Button1_Click" />
                        </td>
                    </tr>
                </table>

            </div>
        </div>
    </form>
</body>
</html>
