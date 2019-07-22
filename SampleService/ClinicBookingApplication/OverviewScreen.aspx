<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OverviewScreen.aspx.cs" Inherits="ClinicBookingApplication.WebForm1" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <!DOCTYPE html>   
    <meta name="viewport" content ="width=device-width, initial-scale = 1.0">
    <%-- ReSharper disable once UnusedLocals --%>
    <script>
        $(function () {
            $('#DateTimeTextBox').popover();
        });
        var myTimeout;
        $(function waitFunction() {
            var myTimeout = setTimeout(function () {
                document.getElementById("loader").style.display = "none";
                document.getElementById("LoadDone").style.display = "block";  }, 1500);
        });
    </script>

    
    <div id="loader"></div>
    <div style="display: none;" id="LoadDone" class="animate-bottom">
    <h1> OVERVIEW SCREEN</h1>
    
          
    <h2>Welcome!</h2>
    
    
    <h3> Search Criteria</h3>
    <h3> &nbsp;<asp:TextBox ID="SearchByTagTextBox" runat="server" OnTextChanged="SearchByTagTextBoxTextChanged"></asp:TextBox>
        
        <asp:GridView ID="SearchResultsGrid" CssClass="GridChanges" runat="server" AutoGenerateColumns="false" AllowSorting="true" OnSorting="AppointmentsSorting" OnSelectedIndexChanged="SearchResultsGridSelectedIndexChanged" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
            <Columns>
                <asp:BoundField DataField="AppointmentID" HeaderText="AppointmentNo." SortExpression="AppointmentNo." ItemStyle-Width ="30" Visible="False">
<ItemStyle Width="30px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="IsActive" HeaderText="Status" SortExpression="IsActive" ItemStyle-Width="150" >
                <ItemStyle Width="150px" />
                </asp:BoundField>
                <asp:BoundField DataField="PatientID" HeaderText="Patient" SortExpression="PatientID" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="StartDateTime" HeaderText="Date/Time" SortExpression="StartDateTime" ItemStyle-Width="150">
<ItemStyle Width="150px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="DurationID" HeaderText="Duration" SortExpression="DurationID" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="ClinicID" HeaderText="Clinic" SortExpression="ClinicID" ItemStyle-Width="150" >
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
    <asp:DropDownList ID="PatientDropDownList" runat="server" OnSelectedIndexChanged="DropDownList1SelectedIndexChanged">
    </asp:DropDownList>
        <asp:TextBox ID="DateTimeTextBox" runat="server" BackColor="White" BorderColor="Black" OnTextChanged="DateTimeTextBoxTextChanged"
               TabIndex="0">yyyy MM dd HH:mm</asp:TextBox>

        <asp:DropDownList ID="DurationDropDownList" runat="server">
        </asp:DropDownList>
        <asp:DropDownList ID="ClinicDropDownList" AutoPostBack="True" OnSelectedIndexChanged="ClinicDropDownListSelectedIndexChanged" OnDataBound="ClinicDropDownList_OnDataBound" runat="server">
        </asp:DropDownList>
        <asp:DropDownList ID="SpecialtyDropDownList" runat="server"/>
        <asp:DropDownList ID="UrgencyDropDownList" runat="server">
        </asp:DropDownList>
        <asp:DropDownList ID="AppointmentTypeDropDownList" runat="server">
        </asp:DropDownList>
        

        <asp:Button ID="NewAppointmentButton" runat="server" Height="34px" OnClick="NewAppointmentButtonClick" Text="Submit" />
        <asp:RequiredFieldValidator
         ControlToValidate = "DateTimeTextBox" Display="Dynamic" 
         ErrorMessage="Please enter a valid DATE and TIME." ID="rfvDateTime"
         EnableClientScript="True"
         runat="server">
       
    </asp:RequiredFieldValidator>

    </h3>
    <p> &nbsp;</p>
    <p> &nbsp;</p>
    <p> &nbsp;</p>
    <p> &nbsp;</p>
    <p> &nbsp;</p>
    <p> &nbsp;</p>
    <p> &nbsp;</p>
    <p> &nbsp;</p>
    <p> &nbsp;</p>

    </div>
</asp:Content>
