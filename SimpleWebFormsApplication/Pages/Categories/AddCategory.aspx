<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddCategory.aspx.cs" Inherits="SimpleWebFormsApplication.Pages.Categories.AddCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <div class="add-product">
                <form>
                  <div class="form-group">
                    <label for="txtProductName">Category Name</label>
                    <span class="error">
                        <asp:RequiredFieldValidator ID="Value1RequiredValidator" ControlToValidate="txtCategoryName"  
                     ErrorMessage="Please enter Product Name." Display="Dynamic"  
                     runat="server"/>  
                    </span>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtCategoryName"  placeholder="Category Name" />
                  </div>
                  <div class="form-group">
                    <asp:Button runat="server" Text="Save" CssClass="btn btn-success" ID="btnCategorySave" OnClick="SaveCategory_Click" />
                    <a runat="server" class="btn btn-danger" href="~/Pages/Categories/AllCategories">Cancel</a>
                  </div>
                </form>
            </div>
        </div>
    </div>
</asp:Content>
