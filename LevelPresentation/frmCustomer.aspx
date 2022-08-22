<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="frmCustomer.aspx.cs" Inherits="LevelPresentation.frmCustomer" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
    <section>
        <h1 align="center"> CUSTOMER REGISTRATION </h1>
    </section>

    <!-- Styles -->

    <style type="text/css">  
        .Background  
        {  
            background-color: Black;  
            filter: opacity(80%);  
            opacity: 0.8;  
        }  

        .img
        {
          border: 1px solid #ddd;
          border-radius: 4px;
          padding: 5px;
          width: 150px;
        }

        .Popup  
        {  
            background-color: #FFFFFF;  
            border-width: 3px;  
            border-style: solid;  
            border-color: black;  
            padding-top: 10px;  
            padding-left: 10px;  
            width: 300px;  
            height: 250px;  
        }  
        .lbl  
        {  
            font-size:16px;  
            font-style:italic;  
            font-weight:bold;  
        }  
    </style>  

    <!--   -->
    <section class="content">
        <!-- Row of CUSTOMER REGISTRATION -->
        <div class="row"> 
           <div class="col-md-6">
            <div class="center">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>PLATE</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtPlate" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>
                            <label>NAME</label>
                        <div class="form-group">
                            <asp:TextBox ID="txtName" runat="server" Text="" CssClass="form-control"></asp:TextBox>
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
                            <asp:TextBox ID="txtPhone" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>
                            <label>EMAIL</label>
                        <div class="form-group">
                            <asp:TextBox ID="txtEmail" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
               </div>
            </div>
        </div>

       <!-- Notifications Modal -->
        <asp:ScriptManager ID="ScriptManager1" runat="server"> </asp:ScriptManager>
        <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="pnl1" TargetControlID="btnRecord" 
            CancelControlID="Button2" BackgroundCssClass="Background">
         </cc1:ModalPopupExtender>

        <asp:Panel ID="pnl1" runat="server" CssClass="Popup" align="center" style="display:none">
            <image src="css/images/information.png" width="50" height="50"> </image>
             <br/> 
             <br/> 
            <asp:Label runat="server" CssClass="lbl" Text="Customer Added Sucessfully!"></asp:Label>
            <br/> <br/> <br/>
            <asp:Button ID="Button2" runat="server" CssClass="btn btn-danger" BackColor="Red" Width="200px" Text="Ok"/>
         </asp:Panel>
       <!-- Notifications Modal -->

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
