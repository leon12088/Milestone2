<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="Milestone2.ProductList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section>
      <div>
         <hgroup>
            <h2><%: Page.Title %></h2>
         </hgroup>
          <style>
              .logo2 {padding: 100px; }
         </style>
         <asp:ListView ID="productList" runat="server"
            DataKeyNames="ProductID" GroupItemCount="4"
            ItemType="Milestone2.Models.Product" SelectMethod="GetProducts">
            <EmptyDataTemplate>
               <table >
                  <tr>
                     <td>No data was returned.</td>
                  </tr>
               </table>
            </EmptyDataTemplate>
            <EmptyItemTemplate>
               <td/>
            </EmptyItemTemplate>
            <GroupTemplate>
            <tr id="itemPlaceholderContainer" runat="server">
            <td id="itemPlaceholder" runat="server"></td>
            </tr>
            </GroupTemplate>
            <ItemTemplate>
                
               <div runat="server" class="row">
        <div class="col-md-4">
            <b>
            <p class ="lead" align="center">
            <a
                href="ProductDetails.aspx?productID=<%#:Item.ProductID%>">
                <span>
                <%#:Item.ProductName%>
                </span>
           </a>
           </p>
           <a
                href="ProductDetails.aspx?productID=<%#:Item.ProductID%>">
                <img
                    src="/<%#:Item.ImagePath%>"
                    width="400" height="300" style="border:
                    solid" />
           </a>

            <p><b>Description: </b><br/><%#:Item.Description %>
                <br/>
            </p>
           
            <p><b>Price: </b><%#:String.Format("{0:c}",
                              Item.UnitPrice)%></p>
            <p>
            <a href="/AddToCart.aspx?productID=<%#:Item.ProductID %>"> <span class="ProductListItem">
                <b>Add To Cart<b>
                    </span>
            </a></p>
            </b>
        </div>
        
    </div>
            </ItemTemplate>
            
         </asp:ListView>
      </div>
   </section>

</asp:Content>
