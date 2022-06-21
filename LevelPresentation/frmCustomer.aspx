<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="frmCustomer.aspx.cs" Inherits="LevelPresentation.frmCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <h1 align="center"> CUSTOMER REGISTRATION </h1>
    </section>
    <section class="content">
        <!-- Row of CUSTOMER REGISTRATION -->
        <div class="row"> 
            <div class="center">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>NAME</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtName" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>PHONE</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtPhone" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>EMAIL</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtEmail" runat="server" Text="" CssClass="form-control"></asp:TextBox>
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
                        <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-danger" Width="200px" Text="Cancel" />
                    </td>
                </tr>
            </table>
        </div>
        <br />

        <!-- Datatable Part -->
        <div class="row">
            <div class="col-xs-12">
                <div class="box box-primary">
                    <div class="box-header">
                        <h3 class="box-title">Customers List</h3>
                    </div>
                    <div class="box-body table-responsive">
                        <table id="tbl_customers" class="table table-bordered table-hover text-center">
                            <thead>
                                <tr>
                                    <th>ID</th>
                                    <th>Customer Name</th>
                                    <th>Phone</th>
                                    <th>Email</th>
                                </tr>
                            </thead>
                            <tbody id="tbl_body_table">
                                <!-- DATA POR MEDIO DE AJAX-->
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
        <!-- End Datatable -->

    </section>
</asp:Content>
