Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols

' 若要允許使用 ASP.NET AJAX 從指令碼呼叫此 Web 服務，請取消註解下列一行。
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri1.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class Convert
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function FahrenheitToCelsius(ByVal Fahrenheit As Double) As Double
        Return ((Fahrenheit - 32) * 5) / 9
    End Function

    <WebMethod()> _
    Public Function CelsiusToFahrenheit(ByVal Celsius As Double) As Double
        Return ((Celsius * 9) / 5) + 32
    End Function
End Class