<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<List<MeetupLibrary.Member>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Members
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Members</h2>
<ul>
<%foreach (MeetupLibrary.Member item in Model)
  { %>
  <li><%=item.Name %></li>
<%} %>
</ul>
</asp:Content>
