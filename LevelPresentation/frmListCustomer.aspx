<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="frmListCustomer.aspx.cs" Inherits="LevelPresentation.frmListCustomer" ClientIDMode="Static" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <h1 align="center"> CUSTOMER LIST </h1>
    </section>
    <section class="content">     
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
                                    <th>Code</th>
                                    <th>Plate</th>
                                    <th>Customer Name</th>
                                    <th>Phone</th>
                                    <th>Email</th>
                                    <th>Actions</th>
                                </tr>
                            </thead>
                            <tbody id="tbl_body_table">
                                <!-- DATA FROM AJAX JAVASCRIPT -->
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
        <!-- End Datatable -->
    </section>

    <div class="modal fade" id="imodal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title" id="myModalLabel">Update Record</h4>
                </div>
                <div class="modal-body">
                    <div class="form-group">
                        <label>Customer Name</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtCustomerNameModal" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>Plate</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtCustomerPlateModal" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>Phone</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtCustomerPhoneModal" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>Email</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtCustomerEmailModal" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-primary" id="btnupdate">Update</button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
    <script src="js/customer.js" type="text/javascript"></script>
</asp:Content>
