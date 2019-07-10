<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OverviewScreen.aspx.cs" Inherits="ClinicBookingApplication.WebForm1" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <!DOCTYPE html>   
    <meta name="viewport" content ="width=device-width, initial-scale = 1.0">
    <h1> OVERVIEW SCREEN</h1>
    
          
    <h2>Welcome!</h2>
        
    
    
    <h3> Search Criteria</h3>
    <h3> &nbsp;<asp:TextBox ID="SearchByTagTextBox" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>

        <asp:GridView ID="SearchResultsGrid" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="SearchResultsGrid_SelectedIndexChanged" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
            <Columns>
                <asp:BoundField DataField="AppointmentID" HeaderText="AppointmentNo." ItemStyle-Width ="30" Visible="False">
<ItemStyle Width="30px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="IsActive" HeaderText="Status" ItemStyle-Width="150" >
                <ItemStyle Width="150px" />
                </asp:BoundField>
                <asp:BoundField DataField="PatientID" HeaderText="Patient" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="StartDateTime" HeaderText="Date/Time" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="DurationID" HeaderText="Duration" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="ClinicID" HeaderText="Clinic" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
                </asp:BoundField>
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        <br/>
    <asp:DropDownList ID="DropDownList1" runat="server" Height="45px" Width="127px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList>

        <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Height="43px" Width="130px">
        </asp:DropDownList>

        <asp:DropDownList ID="DropDownList3" runat="server">
        </asp:DropDownList>
        <asp:DropDownList ID="DropDownList4" runat="server">
        </asp:DropDownList>
        <asp:DropDownList ID="DropDownList5" runat="server">
        </asp:DropDownList>
        <asp:DropDownList ID="DropDownList6" runat="server">
        </asp:DropDownList>
        <asp:DropDownList ID="DropDownList7" runat="server">
        </asp:DropDownList>

        <asp:Button ID="SearchByTagButton" runat="server" Height="34px" OnClick="SearchByTagButton_Click" Text="Button" />

    </h3>
    <p> &nbsp;</p>
    <p> &nbsp;</p>
    <p> &nbsp;</p>
    <p> &nbsp;</p>
    <p> &nbsp;</p>
 
</asp:Content>
