﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="frmCustomer.aspx.cs" Inherits="LevelPresentation.frmCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <h1 align="center"> CUSTOMER REGISTRATION </h1>
    </section>
    <section class="content">
        <!-- Row of CUSTOMER REGISTRATION -->
        <div class="row"> 
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>ID</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtID" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>
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
          </section>
</asp:Content>
