<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 85px;
        }
        .auto-style4 {
            width: 551px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">
                        <asp:DataList ID="DataList1" runat="server"  BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" GridLines="Both" DataKeyField="eid" Width="480px">
                            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                            <ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                            <ItemTemplate>
  <b>Emp Id</b><%#Eval("eid") %><br /><b>Emp Name</b><%#Eval("ename") %><br /><b>Department</b><%#Eval("edept") %><br /><b>Salary</b><%#Eval("esalary") %><br /><b>Add this emp on list</b>
                             
                            </ItemTemplate>
                            <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        </asp:DataList>
                        
                       
                        
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Lbpageno" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <asp:Button ID="Button1" runat="server" Text="First"  OnClick="Button1_Click"/>
&nbsp;<asp:Button ID="Button2" runat="server" Text="Previous" OnClick="Button2_Click" />
&nbsp;<asp:Button ID="Button3" runat="server" Text="Next"  OnClick="Button3_Click"/>
&nbsp;<asp:Button ID="Button4" runat="server" Text="Last"  OnClick="Button4_Click"/>
                        
                       
                        
                    </td>
                   
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
