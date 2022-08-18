<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="frmListCustomer.aspx.cs" Inherits="LevelPresentation.frmListCustomer" ClientIDMode="Static" %>
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
                       <asp:DropDownList ID="ddlSearchBy" runat="server" AutoPostBack="True">
                         <asp:ListItem Text="All"></asp:ListItem>  
                         <asp:ListItem Text="Name"></asp:ListItem>       
                         <asp:ListItem Text="Phone"></asp:ListItem>
                         <asp:ListItem Text="Email"></asp:ListItem>
                       </asp:DropDownList>
                      <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                       <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click"></asp:Button>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnSearchVehicle" runat="server" Enabled="false" Text="Customer Vehicles" OnClick="btnSearchVehicle_Click" Width="126px"></asp:Button>
                        <asp:Button ID="btnBack" runat="server" Enabled="true" Visible="false" Text="Back" OnClick="btnBack_Click" Width="126px"></asp:Button>
                    </div>
                    <div class="box-body table-responsive">
                        <asp:GridView ID="tblcustomers" class="table table-bordered table-hover text-center" AutoGenerateColumns="False" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="tblcustomers_SelectedIndexChanged" >
                          <Columns>
                           <asp:BoundField HeaderText="Plate" DataField="Plate" ReadOnly="True" />
                           <asp:BoundField HeaderText="Customer Name" DataField="CustomerName" />
                           <asp:BoundField HeaderText="Phone" DataField="Phone" />
                           <asp:BoundField HeaderText="Email" DataField="Email" />
                          </Columns>
                        </asp:GridView>      
                    </div>
                </div>
            </div>
        </div>
        <!-- End Datatable -->
    </section>

    <section class="content">
        <!-- Row of CUSTOMER REGISTRATION -->
        <div class="row"> 
           <div class="col-md-6">
            <div class="center">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>ID</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtID" runat="server" Text="" ReadOnly="true" CssClass="form-control"></asp:TextBox>
                        </div>
                            <label>NAME</label>
                        <div class="form-group">
                            <asp:TextBox ID="txtName" runat="server" Text="" Enabled="false" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
               </div>
            </div>

           <div class="col-md-6">
            <div class="center">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>PHONE</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtPhone" runat="server" Text="" Enabled="false" CssClass="form-control"></asp:TextBox>
                        </div>
                            <label>EMAIL</label>
                        <div class="form-group">
                            <asp:TextBox ID="txtEmail" runat="server" Text="" Enabled="false" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
               </div>
            </div>
          </div>
        <div align="center">
            <table>
                <tr>
                    <td>
                        <asp:Button ID="btnUpdate" runat="server" CssClass="btn btn-primary" BackColor="Red" Width="200px" Text="Update" Enabled="false" OnClick="btnUpdate_Click"  />
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td>
                        <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-danger" BackColor="Red" Width="200px" Text="Cancel" OnClick="btnCancel_Click"  />
                    </td>
                </tr>
            </table>
        </div>
        <br />
    </section>
</asp:Content>
