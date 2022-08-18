﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" Async="true" AutoEventWireup="true" CodeBehind="frmOilServiceaspx.aspx.cs" Inherits="LevelPresentation.frmOilServiceaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <h1 align="center"> OIL SERVICE </h1>
    </section>
    <section class="content">
        <!-- Row of OIL SERVICE -->
        <div class="row"> 
          <div class="col-md-6">
            <div class="center">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <asp:Label ID="lblCustomer" runat="server" Visible="false" Font-Bold="true" Text="NEW CUSTOMER"></asp:Label>
                        </div>
                        <div class="form-group">
                            <label>CAR PLATE</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtCustomerID" runat="server" Text="" CssClass="form-control" style="text-transform:capitalize;" OnTextChanged="txtCustomerID_TextChanged" AutoPostBack="True"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>CUSTOMER NAME</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtCustomerName" runat="server" CssClass="form-control" style="text-transform:capitalize;"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>CUSTOMER PHONE</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtCustomerPhone" TextMode="Number" runat="server" CssClass="form-control" ></asp:TextBox>
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
                            <label>GRADE</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtGrade" runat="server" Text="" CssClass="form-control" style="text-transform:capitalize;"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>MILES</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtMiles" runat="server" TextMode="Number" CssClass="form-control" OnTextChanged="txtMiles_TextChanged"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>OIL TYPE</label>
                        </div>
                        <div class="form-group">                         
                            <asp:DropDownList CssClass="form-control" id="ddlOilType" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddlOilType_SelectedIndexChanged"> 
                             <asp:ListItem Value="Standard"> Standard </asp:ListItem>
                             <asp:ListItem Value="Synthetic"> Synthetic </asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>CHANGE MILES</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtChangeMiles" runat="server" TextMode="Number" Enabled="false" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>NEXT CHANGE DATE</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox  ID="txtDate" runat="server" Text="" Enabled="false" CssClass="form-control"></asp:TextBox>
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
                        <asp:Button ID="btnRecord" runat="server" CssClass="btn btn-primary" BackColor="Red" Width="200px" Text="Record" OnClick="btnRecord_Click" />
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td>
                        <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-danger" BackColor="Red" Width="200px" Text="Cancel" OnClick="btnCancel_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <br />
     </section>
</asp:Content>
