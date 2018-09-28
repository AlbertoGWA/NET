<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP_CONSUME_SERVICE._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        section {
            width:1000px;
            height:400px;
        }
        .L {
            height:200px;
            width:50%;
            float:left;
        }
        .R {
            height:200px;
            width:50%;
        }
        .box {
            width : 100%;
            height: 50px;
        }
    </style>
    <section>
        <div class="L">
            <div class="box">
                <asp:TextBox ID="txtID" runat="server" Height="30px" Width="419px"></asp:TextBox>
            </div>
            <div class="box">
                <asp:TextBox ID="txtName" runat="server" Height="32px" Width="424px"></asp:TextBox>
                <asp:Button ID="SearchName" runat="server" Text="..." OnClick="SearchName_Click" Height="26px" Width="36px" />
            </div>
            <div class="box">
                <textarea id="rtxtDescription" rows="2"></textarea>
                <asp:Button ID="SearchDescription" runat="server" Text="..." OnClick="SearchDescription_Click" Width="33px" />
            </div>
            <div class="box">
                <asp:Button ID="ButtonInsert" runat="server" Text="INSERT" OnClick="ButtonInsert_Click" />
                <asp:Button ID="ButtonUpdate" runat="server" Text="UPDATE" OnClick="ButtonUpdate_Click" />
                <asp:Button ID="ButtonDelete" runat="server" Text="DELETE" OnClick="ButtonDelete_Click" />
            </div>
            
            
        </div>
        <div class="R">
            <div class="box">
                <asp:Image ID="pbxPicture" runat="server" Height="42px" Width="66px" />
            </div>
            <div class="box">
                <asp:Button ID="ButtonLoadPhoto" runat="server" Text="#" OnClick="ButtonLoadPhoto_Click" />
            </div>
        </div>
    </section>

</asp:Content>
