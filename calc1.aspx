<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="notesCont.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <!-- <div style="width:880px"> -->
    <p>
        <asp:TextBox ID="txtDisplay" runat="server" Height="35px" Width="270px">0</asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btn7" runat="server" Height="35px" Text="7" Width="70px" OnClick="btn7_Click" />
        <asp:Button ID="btn8" runat="server" Height="35px" Text="8" Width="70px" OnClick="btn8_Click" />
        <asp:Button ID="btn9" runat="server" Height="35px" Text="9" Width="70px" OnClick="btn9_Click" />
        <asp:Button ID="div" runat="server" Height="35px" Text="÷" Width="70px" OnClick="div_Click" />
    </p>
    <p>
        <asp:Button ID="btn4" runat="server" Height="35px" Text="4" Width="70px" OnClick="btn4_Click" />
        <asp:Button ID="btn5" runat="server" Height="35px" Text="5" Width="70px" OnClick="btn5_Click" />
        <asp:Button ID="btn6" runat="server" Height="35px" Text="6" Width="70px" OnClick="btn6_Click" />
        <asp:Button ID="multi" runat="server" Height="35px" Text="x" Width="70px" OnClick="multi_Click" />
    </p>
    <p>
        <asp:Button ID="btn1" runat="server" Height="35px" Text="1" Width="70px" OnClick="btn1_Click" />
        <asp:Button ID="btn2" runat="server" Height="35px" Text="2" Width="70px" OnClick="btn2_Click" />
        <asp:Button ID="btn3" runat="server" Height="35px" Text="3" Width="70px" OnClick="btn3_Click" />
        <asp:Button ID="min" runat="server" Height="35px" Text="-" Width="70px" OnClick="min_Click" />
    </p>
    <p>
        <asp:Button ID="btn0" runat="server" Height="35px" Text="0" Width="70px" OnClick="btn0_Click" />
        <asp:Button ID="dec" runat="server" Height="35px" Text="." Width="70px" OnClick="dec_Click" />
        <asp:Button ID="plus" runat="server" Height="35px" Text="+" Width="70px" OnClick="plus_Click" />
        <asp:Button ID="equal" runat="server" Height="35px" Text="=" Width="70px" BackColor="Orange" OnClick="equal_Click" />
    </p>
        <!-- </div> -->
</asp:Content>