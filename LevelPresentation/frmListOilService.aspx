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
                       <asp:DropDownList ID="ddlSearchBy" runat="server" AutoPostBack="True">
                         <asp:ListItem Text="All"></asp:ListItem>
                         <asp:ListItem Text="Plate"></asp:ListItem>   
                         <asp:ListItem Text="Name"></asp:ListItem>       
                         <asp:ListItem Text="Phone"></asp:ListItem>
                         <asp:ListItem Text="Grade"></asp:ListItem>
                         <asp:ListItem Text="Miles"></asp:ListItem>
                         <asp:ListItem Text="Oil Type"></asp:ListItem>
                       </asp:DropDownList>
                      <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                       <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click"></asp:Button>
                    </div>
                    <div class="box-body table-responsive">
                         <asp:GridView ID="tbloilservice" class="table table-bordered table-hover text-center" AutoGenerateColumns="False" runat="server" >
                          <Columns>
                           <asp:BoundField HeaderText="CustomerPlate" DataField="CustomerPlate" />
                           <asp:BoundField HeaderText="CustomerName" DataField="CustomerName" />
                           <asp:BoundField HeaderText="CustomerPhone" DataField="CustomerPhone" />
                           <asp:BoundField HeaderText="Grade" DataField="Grade" />
                           <asp:BoundField HeaderText="Miles" DataField="Miles" />
                           <asp:BoundField HeaderText="Change Miles" DataField="ChangeMiles" />
                           <asp:BoundField HeaderText="Oil Type" DataField="OilType" />
                           <asp:BoundField HeaderText="Date" DataField="TodayDate" />
                           <asp:BoundField HeaderText="Change Date" DataField="ChangeDate" />
                          </Columns>
                        </asp:GridView>   
                    </div>
                </div>
            </div>
        </div>
        <!-- End Datatable -->
    </section>
</asp:Content>
