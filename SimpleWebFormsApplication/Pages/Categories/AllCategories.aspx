<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllCategories.aspx.cs" Inherits="SimpleWebFormsApplication.Pages.Categories.AllCategories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12" style="padding: 50px;width:700px;">
            <a runat="server" href="~/Pages/Categories/AddCategory" class="btn btn-primary">Add New Category</a>
            <table class="table">
              <thead>
                <tr>
                    <th scope="col">ID</th>
                    <th scope="col">Category Name</th>
                    <th scope="col"></th>
                </tr>
              </thead>
              <tbody>
                <asp:Repeater ID="rptCategories" runat="server">
                    <ItemTemplate>
                       <tr>
                            <th scope="row"><%# DataBinder.Eval(Container, "DataItem.Id") %></th>
                            <td><%# DataBinder.Eval(Container, "DataItem.CategoryName") %></td>
                            <td><asp:Button runat="server" UseSubmitBehavior="false" OnClick="SetIdToDelete_Click" class="btn btn-danger btn-sm"
                                CommandArgument='<%# DataBinder.Eval(Container, "DataItem.Id") %>' Text="Delete"></asp:Button></td>
                       </tr>
                    </ItemTemplate>
                </asp:Repeater>
              </tbody>
            </table>
        </div>
    </div>
</asp:Content>
