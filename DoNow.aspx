<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoNow.aspx.cs" Inherits="notesCont.SQL.DoNow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblShow" runat="server" Text=""></asp:Label>
        <div>
            <asp:GridView ID="gvPatients2" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="gvPatients2_RowCancelingEdit" OnRowDeleting="gvPatients2_RowDeleting" OnRowEditing="gvPatients2_RowEditing" OnRowUpdating="gvPatients2_RowUpdating">
                <Columns>
                    <asp:TemplateField HeaderText="ID">
                        <EditItemTemplate>
                            <asp:Label ID="lblID" runat="server" Text='<%# Eval("ID") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblID" runat="server" Text='<%# Eval("ID") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Name">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtName" runat="server" Text='<%# Eval("Name") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblName" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Address">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtAddress" runat="server" Text='<%# Eval("Address") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblAddress" runat="server" Text='<%# Eval("Address") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Diagnosis">
                        <EditItemTemplate>
                            <asp:DropDownList ID="ddlDiagnosis" runat="server" SelectedValue='<%# Eval("Diagnosis") %>'>
                                <asp:ListItem>Other</asp:ListItem>
                                <asp:ListItem Value="Cancer"></asp:ListItem>
                                <asp:ListItem Value="Osteoporosis"></asp:ListItem>
                                <asp:ListItem Value="Wuhan Flu"></asp:ListItem>
                                <asp:ListItem Value="Common Cold"></asp:ListItem>
                                <asp:ListItem>Spanish Flu</asp:ListItem>
                                <asp:ListItem>Black Plague</asp:ListItem>
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblDiagnosis" runat="server" Text='<%# Eval("Diagnosis") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Gender">
                        <EditItemTemplate>
                            <asp:Button ID="btnGender" runat="server" OnClick="btnGender_Click" Text='<%# Eval("Gender").ToString() == "False" ? "Female" : "Male" %>' />
                            <asp:Label ID="lblInvis" runat="server" Text='<%# Eval("Gender") %>' Visible="False"></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblGender" runat="server" Text='<%# Eval("Gender").ToString() == "False" ? "Female" : "Male" %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Age">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtAge" runat="server" Text='<%# Eval("Age") %>' TextMode="Number" min="0" max="125"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblAge" runat="server" Text='<%# Eval("Age") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Zip">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtZip" runat="server" Text='<%# Eval("Zip") %>' TextMode="Number" min="10000" max="99999"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblZip" runat="server" Text='<%# Eval("Zip") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="SSN">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtSSN" runat="server" Text='<%# Eval("SSN") %>' max="999999999"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblSSN" runat="server" Text='<%# Eval("SSN") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="State">
                        <EditItemTemplate>
                            <asp:DropDownList ID="ddlState" runat="server" SelectedValue='<%# Eval("State") %>'>
                                <asp:ListItem>OH</asp:ListItem>
                                <asp:ListItem>TX</asp:ListItem>
                                <asp:ListItem>AL</asp:ListItem>
                                <asp:ListItem>AK</asp:ListItem>
                                <asp:ListItem>AS</asp:ListItem>
                                <asp:ListItem>AZ</asp:ListItem>
                                <asp:ListItem>AR</asp:ListItem>
                                <asp:ListItem>NM</asp:ListItem>
                                <asp:ListItem>NY</asp:ListItem>
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblState" runat="server" Text='<%# Eval("State") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Symptoms">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtSymptoms" runat="server" Text='<%# Eval("Symptoms") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblSymptoms" runat="server" Text='<%# Eval("Symptoms") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Appointment">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtAppointment" runat="server" Text='<%# Eval("Appointment") %>' TextMode="Date"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblAppointment" runat="server" Text='<%# Eval("Appointment") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Actions">
                        <EditItemTemplate>
                            <asp:Button ID="btnUpdate" runat="server" CommandName="Update" Text="Update" />
                            <asp:Button ID="btnCancel" runat="server" CommandName="Cancel" Text="Cancel" />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Button ID="btnEdit" runat="server" CommandName="Edit" Text="Edit" />
                            <asp:Button ID="btnDelete" runat="server" CommandName="Delete" Text="Delete" />
                        </ItemTemplate>
                        <HeaderStyle BackColor="#FF9900" Font-Bold="True" />
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
