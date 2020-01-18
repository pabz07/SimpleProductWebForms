<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditProduct.aspx.cs" Inherits="SimpleWebFormsApplication.Pages.Products.EditProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <div class="add-product">
                <form>
                  <div class="form-group">
                    <label for="txtProductName">Product Name</label>
                    <span class="error">
                        <asp:RequiredFieldValidator ID="Value1RequiredValidator" ControlToValidate="txtProductName"  
                     ErrorMessage="Please enter Product Name." Display="Dynamic"  
                     runat="server"/>  
                    </span>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtProductName"  placeholder="Product Name" />
                  </div>
                  <div class="form-group">
                    <label for="formGroupExampleInput2">Product Description</label>
                     <span class="error">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtProductDescription"  
                     ErrorMessage="Please enter Product Description." Display="Dynamic"  
                     runat="server"/>  
                    </span>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtProductDescription"  placeholder="Product Description" />
                  </div>
                  <div class="form-group">
                    <label for="ddlCategory">Category</label>
                    <asp:DropDownList runat="server" CssClass="form-control" ID="ddlCategory"></asp:DropDownList>
                  </div>
                  <div class="form-group">
                    <label for="txtProductName">Product Image</label>
                    <span class="error">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtImage"  
                     ErrorMessage="Please enter Product Image." Display="Dynamic"  
                     runat="server"/>  
                    </span>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtImage"  placeholder="Product Image" />
                  </div>
                  <div class="form-group">
                    <asp:Button runat="server" Text="Save" CssClass="btn btn-success" ID="btnSaveProduct" OnClick="SaveProduct_Click" />
                      <a runat="server" class="btn btn-danger" href="/">Cancel</a>
                  </div>
                </form>
            </div>
        </div>
    </div>
</asp:Content>
