<%@ Page Title="Technical Exercise" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Exercise.aspx.cs" Inherits="TopFiveWebApp.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">     
    <h3><asp:Label runat ="server" Text ="Please upload a text file"></asp:Label></h3>
    <asp:FileUpload id="fileUpLoader" runat="server"/>  
    <br />
    <asp:Button id="UploadBtn" Text="Upload File" OnClick="UploadBtn_Click" runat="server" Width="105px" />  
    <asp:Label ID ="lblFileUploaded" runat ="server"></asp:Label>
    <br />
    <br />
    <asp:Label ID ="lblResult" runat ="server"></asp:Label>
</asp:Content>


