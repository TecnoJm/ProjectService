<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="frmListOilService.aspx.cs" Inherits="LevelPresentation.frmListOilService" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <section>
        <h1 align="center"> OIL SERVICES LIST </h1>
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
                        <table id="tbl_oilservices" class="table table-bordered table-hover text-center">
                            <thead>
                                <tr>
                                    <th>Plate</th>
                                    <th>Customer Name</th>
                                    <th>Customer Phone</th>
                                    <th>Grade</th>
                                    <th>Miles</th>
                                    <th>OilType</th>
                                    <th>Today Date</th>
                                    <th>Change Date</th>
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
</asp:Content>
