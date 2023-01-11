<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EmployeeList.aspx.cs" Inherits="ELZ_COSMETIC_DATABASE_SYSTEM.EmployeeList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2"
	runat="server">
	<table class="table table-bordered table-hover">
		<tr>
			<th>Ssn</th>
			<th>First Name</th>
			<th>Last Name</th>
			<th>Birthdate</th>
			<th>Age</th>
			<th>Dno</th>
			<th>Gender</th>
			<th>Country</th>
			<th>City</th>
			<th>Postal Code</th>
			<th>Salary</th>
			 </tr>
        <tbody>
			<asp:Repeater ID="Repeater2" runat="server">
				<ItemTemplate>
					<tr>
						<td><%#("Ssn1")%></td>
						<td><%#Eval("FirstName1")%></td>
						<td><%#Eval("LastName1")%></td>
						<td><%#Eval("Birthdate1")%></td>
						<td><%#Eval("Age1")%></td>
						<td><%#Eval("Dno1")%></td>
						<td><%#Eval("Gender1")%></td>
						<td><%#Eval("Country1")%></td>
						<td><%#Eval("City1")%></td>
						<td><%#Eval("Salary1")%></td>
						<td><%#Eval("Dname1")%></td>

						<td>
					</tr>

				</ItemTemplate>
			</asp:Repeater>
	</table>

</asp:Content>
