<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleWebFormsApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-6" style="padding-top:50px;">
            <div class="form-group">
                <div class="input-group">
                  <asp:TextBox runat="server" CssClass="form-control" ID="txtProductSearch" placeholder="Search" style="height: 45px;max-width: 100%;" />
                  <div class="input-group-addon">
                      <asp:Button runat="server" CssClass="btn btn-sm" Text="Search" OnClick="SearchProduct_Click" />
                  </div>
                </div>
              </div>
        </div>
        <div class="col-md-12 product-list">
            <asp:Repeater ID="rptProducts" runat="server">
                <ItemTemplate>
                    <div class="card" style="width: 25rem;">
                      <div class="product-image-container">
                        <img src="<%# DataBinder.Eval(Container, "DataItem.Image") %>" class="card-img-top" alt="...">
                      </div>
                      <div class="card-body">
                        <h5 class="card-title"><%# DataBinder.Eval(Container, "DataItem.Name") %></h5>
                        <div class="product-descrption-container">
                            <p class="card-text"><%# DataBinder.Eval(Container, "DataItem.Description") %></p>
                        </div>
                        <p class="product-descrption"><span>Category:</span><%# DataBinder.Eval(Container, "DataItem.Category.CategoryName") %></p>
                        <asp:Button runat="server" UseSubmitBehavior="false" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.Id") %>' 
                            class="btn btn-primary" Text="Edit" OnClick="EditProduct_Click"></asp:Button>
                        <asp:Button runat="server" href="#" class="btn btn-danger" onclick="DeleteProduct_Click" UseSubmitBehavior="false" 
                            CommandArgument='<%# DataBinder.Eval(Container, "DataItem.Id") %>' Text="Delete"></asp:Button>
                      </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

</asp:Content>
