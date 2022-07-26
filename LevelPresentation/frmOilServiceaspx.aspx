<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="frmOilServiceaspx.aspx.cs" Inherits="LevelPresentation.frmOilServiceaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <h1 align="center"> OIL SERVICE </h1>
    </section>
    <section class="content">
        <!-- Row of OIL SERVICE -->
        <div class="row"> 
            <div class="center">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>CUSTOMER ID</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtCustomerID" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>GRADE</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtGrade" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>MILES</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtMiles" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>OIL TYPE</label>
                        </div>
                        <div class="form-group">
                           <!-- <asp:TextBox ID="txtOilType" runat="server" Text="" CssClass="form-control"></asp:TextBox> -->

                            <asp:DropDownList CssClass="form-control" id="ddlOilType" runat="server"> 
                             <asp:ListItem Value="Standard"> Standard </asp:ListItem>
                             <asp:ListItem Value="Synthetic"> Synthetic </asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>DATE</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtDate" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
             </div>
        </div>

        <div align="center">
            <table>
                <tr>
                    <td>
                        <asp:Button ID="btnRecord" runat="server" CssClass="btn btn-primary" Width="200px" Text="Record" OnClick="btnRecord_Click" />
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td>
                        <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-danger" Width="200px" Text="Cancel" OnClick="btnCancel_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <br />
     </section>
</asp:Content>
