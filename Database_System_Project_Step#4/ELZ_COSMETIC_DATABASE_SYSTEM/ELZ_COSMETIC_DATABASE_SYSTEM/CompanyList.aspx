<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CompanyList.aspx.cs" Inherits="ELZ_COSMETIC_DATABASE_SYSTEM.CompanyList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2"
    runat="server">
    <table class="table table-bordered table-hover">
        <tr>
            <th>Tax ID</th>
            <th>Company Name</th>
            <th>Country</th>
            <th>City</th>
            <th>Postal Code</th>
            <th>Iban Number</th>
            <th>Order ID</th>
            <th>Product ID</th>
            <th>Operations</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("Taxid1")%></td>
                        <td><%#Eval("CompanyName1")%></td>
                        <td><%#Eval("Country1")%></td>
                        <td><%#Eval("City1")%></td>
                        <td><%#Eval("PostalCode1")%></td>
                        <td><%#Eval("IbanNumber1")%></td>
                        <td><%#Eval("OrderID1")%></td>
                        <td><%#Eval("ProductID1")%></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#"~/CompanyDelete.aspx?TaxID=" + Eval("Taxid1")%>' ID="HyperLink1"
                                CssClass="btn btn-danger" runat="server">DELETE</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#"~/CompanyUpdate.aspx?TaxID=" + Eval("Taxid1")%>' ID="HyperLink2"
                                CssClass="btn btn-success" runat="server">UPDATE</asp:HyperLink>
                        </td>
                    </tr>

                </ItemTemplate>
            </asp:Repeater>
    </table>

</asp:Content>
