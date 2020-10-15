<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="Milestone2.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="productDetail" runat="server"
      ItemType="Milestone2.Models.Product" SelectMethod ="GetProduct"
      RenderOuterTable="false">
      <ItemTemplate>
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
           

          <p>
                <b>Description:</b><br /><%#:Item.Description %>
                <br />
            </p>

            <p><b>Price: </b><%#:String.Format("{0:c}",
                              Item.UnitPrice)%>
            </p>
            
        </div>
        
    </div>
      </ItemTemplate>
   </asp:FormView>
</asp:Content>
