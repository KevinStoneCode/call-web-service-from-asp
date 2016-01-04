Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols

' 若要允許使用 ASP.NET AJAX 從指令碼呼叫此 Web 服務，請將下面這行文字取消註解。
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri1.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class Service
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function sayHello(ByVal Name As String, ByVal Name1 As String) As String
        Return Name1 & " Hello World " & Name
    End Function

End Class