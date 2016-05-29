<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage"%>
<%@ Import Namespace="Tweakers.Controllers" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    private readonly UserController uc = new UserController();

    protected void Login_Click(object sender, EventArgs e)
    {
        if (uc.Login(UserName.Text, Password.Text))
        {
            Message.Text = "U bent ingelogd";
        }
        else if (!uc.Login(UserName.Text, Password.Text))
        {
            Message.Text = "U bent niet ingelogd";
        }
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Title</title>
    <style type="text/css">
        #form1 {
            width: 238px;
        }
    </style>
</head>
<body style="height: 361px">
    <form id="form1" runat="server">
        <div>
            Username:
            <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
        </div>
        <div>
            Password:
            <asp:TextBox ID="Password" runat="server"></asp:TextBox>
        </div>
        <div align="right">
            
            <asp:Button ID="Login" runat="server" Text="Login" OnClick="Login_Click" />
            
        </div>
        <div>
            <asp:Label ID="Message" runat="server" Text=" "></asp:Label>
        </div>
    </form>
</body>
</html>
