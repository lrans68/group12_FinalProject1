<!--# Name: Sarah Mahan, Josh Klingelhafer, Lucas Ransick
# email: mahansa@mail.uc.edu, klingejo@mail.uc.edu, ransiclu@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 4/23/24
# Course: IS 3050
# Semester/Year: Spring 2024
# Brief Description: This project is our final project. 
# Workload: Sarah (Easy Problem, Default page, implementation, optional styling, GIT host), Lucas (Medium, testing, implementation), Josh (Hard, testing, implementation)
# Citations: AI used to solve problems: https://chat.openai.com/share/aa542af9-6d34-475b-bcfa-c4a604d5ad20, https://chat.openai.com/share/a4995f4e-6e83-4d75-8509-69dbe504eb94,https://chat.openai.com/share/721a0175-a423-427f-986e-57126ac955a6
# CSS style buttons taken from: https://getcssscan.com/css-buttons-examples
# Anything else that's relevant: Nothing, Thank you for a great semester!
    -->


<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="group12_FinalProject1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="style.css">
    <title> LeetCode Problems: Group 12</title>
    <h1> LeetCode Problems </h1>
    <h2> Group 12 </h2>
    <h3> Select a problem difficulty:</h3>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table ID="tbButtons" runat="server" HorizontalAlign="Center">
                <asp:TableHeaderRow>
                    <asp:TableCell>
                        <asp:Button ID="btnEasy" onclick="BtnEasy_Click" runat="server" Text="Easy" CssClass="button-50" role="button"/>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Button ID="btnMedium" onclick="BtnMedium_Click" runat="server" Text="Medium" CssClass="button-50" role="button"/>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Button ID="btnHard" onclick="BtnHard_Click" runat="server" Text="Hard" CssClass="button-50" role="button"/>
                    </asp:TableCell>
                </asp:TableHeaderRow>
                <asp:TableRow>
                    <asp:TableCell></asp:TableCell>
                    <asp:TableCell>
                        <asp:Button ID="btnClear" OnClick="btnClear_Click" runat ="server" Text="Clear" CssClass="button-50" role="button" />
                    </asp:TableCell>
                </asp:TableRow>
                 </asp:Table>
            <asp:Table>
                <asp:TableRow>
                 <asp:TableCell>
                     <br />
                    <asp:Label ID="lblProblemTitle" runat="server" Text=""></asp:Label>
                        <br />
                    <asp:Label ID="lblProblemDescription" runat="server" Text=""></asp:Label>
                        <br />
                        <br />
                    <asp:Label ID="lblTestCase" runat="server" Text=""></asp:Label>
                         <br />
                    <asp:Label ID="lblSolutionDescription" runat="server" Text=""></asp:Label>
                </asp:TableCell>
                </asp:TableRow>
           </asp:Table>
        </div>
    </form>
</body>
</html>