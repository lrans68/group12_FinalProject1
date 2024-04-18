<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="group12_FinalProject1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table ID="tblProblems" runat="server">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell>
                        <asp:Label runat="server" Text="LeetCode Problems"></asp:Label>
                    </asp:TableHeaderCell>
                </asp:TableHeaderRow>
                <asp:TableRow>
                    <asp:TableCell>
                         <asp:Label runat="server" Text="Easy"></asp:Label>
                            <br />
                         <asp:Label runat="server" Text="Medium"></asp:Label>
                            <br />
                         <asp:Label runat="server" Text="Hard"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Button ID="btnEasy" runat="server" Text="Show" />
                        <br />
                        <asp:Button ID="btnMedium" runat="server" Text="Show" />
                        <br />
                        <asp:Button ID="btdHard" runat="server" Text="Show" />
                    </asp:TableCell>
                    <asp:TableCell></asp:TableCell>
                    <asp:TableCell>
                        <asp:Label ID="lblProblemTitle" runat="server" Text="Text"></asp:Label>
                        <br />
                        <asp:Label ID="lblSolutionDescription" runat="server" Text="Text"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
