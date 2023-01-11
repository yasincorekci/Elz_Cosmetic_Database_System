<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ELZ_COSMETIC_DATABASE_SYSTEM.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">
        <div class="form-group">
        </div>
        <h1>
        <asp:Label for= "CreateCompany" runat="server" Text=  "Create Company"  style="font-weight:1000; border-style:dashed"  ></asp:Label>
         </h1>
         <br />
        </div>
        
        <asp:Label for="TxtTaxID" runat="server" Text="TaxID" style="font-weight: 700"></asp:Label>
        <asp:TextBox ID="TxtTaxID" runat="server" CssClass="form-control " ></asp:TextBox>
        </div>
        
        </div>
            <asp:Label for="TxtCName" runat="server" Text="Company Name" style="font-weight: 700"></asp:Label>
        <asp:TextBox ID="TxtCname" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
       
        </div>
            <asp:Label for="TxtCountry" runat="server" Text="Country" style="font-weight: 700"></asp:Label>
        <asp:TextBox ID="TxtCountry" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
      
        </div>
            <asp:Label for="TxtCity" runat="server" Text="City" style="font-weight: 700"></asp:Label>
        <asp:TextBox ID="TxtCity" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
       
        </div>
            <asp:Label for="TxtPostalCode" runat="server" Text="Postal Code" style="font-weight: 700"></asp:Label>
        <asp:TextBox ID="TxtPostalCode" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
          
        </div>
            <asp:Label for="TxtIbanNumber" runat="server" Text="Iban Number" style="font-weight: 700"></asp:Label>
        <asp:TextBox ID="TxtIbanNumber" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        
        </div>
            <asp:Label for="TxtOrderID" runat="server" Text="Order ID" style="font-weight: 700"></asp:Label>
        <asp:TextBox ID="TxtOrderID" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        </div>
            <asp:Label for="TxtProductID" runat="server" Text="Product ID" style="font-weight: 700"></asp:Label>
        <asp:TextBox ID="TxtProductID" runat="server" CssClass="form-control"></asp:TextBox>
        </div>


        </div>


    <asp:Button ID="Button1" runat="server" Text="CREATE" OnClick="Button1_Click" CssClass="btn btn-info" />


    </form>

</asp:Content>
