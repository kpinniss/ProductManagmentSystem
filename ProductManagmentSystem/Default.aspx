<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProductManagmentSystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="BtnRedirect" runat="server" OnClick="BtnRedirect_Click" Text="Go to contact" />
    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
      <div class="col-lg-8 col-lg-offset-1">
        
          <asp:GridView ID="ItemsTable" CssClass="table table-striped" runat="server" AutoGenerateColumns="false" ItemType="Repository.DataModels.Product">
              <Columns>
                  <asp:BoundField DataField="sku" HeaderText="SKU" />
                  <asp:CommandField 
              </Columns>
          </asp:GridView>
          
      </div>
    </div>

</asp:Content>
