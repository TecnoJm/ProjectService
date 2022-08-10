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
                         <asp:ListItem Text="Plate"></asp:ListItem>   
                         <asp:ListItem Text="Name"></asp:ListItem>       
                         <asp:ListItem Text="Phone"></asp:ListItem>
                         <asp:ListItem Text="Email"></asp:ListItem>
                       </asp:DropDownList>
                      <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                       <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click"></asp:Button>
                    </div>
                    <div class="box-body table-responsive">
                        <asp:GridView ID="tblcustomers" class="table table-bordered table-hover text-center" AutoGenerateColumns="false" runat="server" >
                          <Columns>
                           <asp:BoundField HeaderText="ID" DataField="ID" />
                           <asp:BoundField HeaderText="Plate" DataField="Plate" />
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
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
