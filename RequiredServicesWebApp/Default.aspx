<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RequiredServicesWebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        Try It Page<br />
        Nichole Courtney<br />
        Assignment 5 - Individual Effort<br />
        http://www.localhost:44375/Default<br />
        <br />
        Get Top Ten Words:<br />
        <br />
        public string GetTopTenWords(String url)<br />
        <br />
        1. This will navigate to the provided URL<br />
        2. Convert the contents of the web page to a string<br />
        3. Strip all of the HTML tags<br />
        4. Compare each word against an English dicstionary to remove non words, i.e. www<br />
        5. Uding a dictionary, the words will be counted and sorted in order of occurences<br />
        6. The top ten words will be taken, returned, and displayed<br />
        <br />
        Note: You must enter the entire webpage address i.e.:<br />
        <a>http://www.ThePageYouWant.com</a><br />
        <asp:TextBox ID="topTenWordsUrlTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="topTenWordsButton" runat="server" OnClick="topTenWordsButton_Click" Text="Get The Top 10" />
        <br />
        <br />
        <asp:Label ID="topTenLabel" runat="server"></asp:Label>
        <br />
        <br />
        Filter Words:<br />
        <br />
        public string WordFilter(string str)<br />
        <br />
        1. This will take the inputted string and remove the stop words<br />
        2. The string will be returned with the stop words removed<br />
        <br />
        Note: The stop words that will be removed are:<br />
        the, of, and, in, to, a, is, that, by, as, an, on, are<br />
        <br />
        <asp:TextBox ID="removeStopWordsTextbox" runat="server" Width="225px"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="removeStopWordsButton" runat="server" OnClick="removeStopWordsButton_Click" Text="Remove Stop Words" />
        <br />
        <br />
        <asp:Label ID="removedStopWordsLabel" runat="server"></asp:Label>
    </div>

    <div class="row">
    </div>

</asp:Content>
