<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="WebApplication2.Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <% WebApplication2.Tutorial tp=new WebApplication2.Tutorial();%>

		    <%=tp.Name%>
            <br />
            Mean of array { 1, 2, 3, 4} is: <%=tp.Mean(new int[] { 1, 2, 3, 4})%>
            <br />
            Median of array { 2, 1, 5, 4, 3} is: <%=tp.Median(new int[] { 2, 1, 5, 4, 3})%>
        </div>
    </form>
</body>
</html>
