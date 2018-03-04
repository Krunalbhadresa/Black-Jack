<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="BLACK JACK GAME"></asp:Label>
    
    </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Cards    "></asp:Label>
            <asp:TextBox ID="c1" runat="server" Width="50px"></asp:TextBox>
            <asp:TextBox ID="c2" runat="server" Width="50px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="New card "></asp:Label>
            <asp:TextBox ID="hc" runat="server" Width="131px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="utotal" runat="server"></asp:Label>
            <asp:Label ID="uscore" runat="server"></asp:Label>
        </p>
        <asp:Button ID="deal" runat="server" OnClick="deal_Click" Text="Deal" />
        <asp:Button ID="hit" runat="server" OnClick="hit_Click" Text="Hit" />
        <asp:Button ID="pass" runat="server" OnClick="pass_Click" Text="Pass" />
        <p>
            <asp:Label ID="dtotal" runat="server"></asp:Label>
            <asp:Label ID="dscore" runat="server"></asp:Label>
        </p>
        <asp:Label ID="result" runat="server"></asp:Label>
        <p>
            <asp:Button ID="restart" runat="server" OnClick="restart_Click" Text="Play again" />
            <asp:Button ID="exit" runat="server" Text="Exit" />
        </p>
    </form>
</body>
</html>
