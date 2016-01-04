<!DOCTYPE html>
<html>
<head>
    <title>Calling a webservice from classic ASP</title>
    <meta charset="UTF-8">
</head>
<body>
<%
    If Request.ServerVariables("REQUEST_METHOD") = "POST" Then
        Dim xmlhttp
        Dim DataToSend
        Dim postUrl
    
        If Request.Form.Item("temp") = "Fahrenheit" Then
            postUrl = "http://localhost/TemperatureWebService/Convert.asmx/FahrenheitToCelsius"
            DataToSend = "Fahrenheit=" & Request.Form("num")
        else
            postUrl = "http://localhost/TemperatureWebService/Convert.asmx/CelsiusToFahrenheit" 
            DataToSend = "Celsius=" & Request.Form("num")
        end if 
        Set xmlhttp = server.Createobject("MSXML2.XMLHTTP")
        xmlhttp.Open "POST", postUrl, false
        xmlhttp.setRequestHeader "Content-Type","application/x-www-form-urlencoded"
        xmlhttp.send DataToSend
        Response.Write "輸入:" & DataToSend & "<br>"
        Response.Write("輸出:" & xmlhttp.responseText)
    Else
        Response.Write "第一次載入" 
    End If
%>
    <FORM method=POST name="form1" ID="Form1">
        <p>輸入目前溫度</p>
        <select name="temp">選擇目前溫度
            <option value="Celsius">攝氏轉華氏</option>
            <option value="Fahrenheit">華氏轉攝氏</option>
        </select> 
        <INPUT type="number" name="num" ID="Text1">
        <BR><BR>
        <INPUT type="submit" value="計算" name="submit1" ID="Submit1">
    </form>
</body>
</html>