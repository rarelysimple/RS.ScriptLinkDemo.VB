Imports System.ComponentModel
Imports System.Web.Services
Imports RS.ScriptLinkDemo.VB.Objects
Imports RS.ScriptLinkDemo.VB.Soap.Factories

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")>
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
<ToolboxItem(False)>
Public Class ScriptLinkController
    Inherits System.Web.Services.WebService

    <WebMethod()>
    Public Function GetVersion() As String

        Dim command As IGetVersionCommand = New GetVersionCommand(New OptionObject2015())
        Return command.Execute()

    End Function

    <WebMethod()>
    Public Function RunScript(ByVal optionObject2015 As OptionObject2015, ByVal parameter As String) As OptionObject2015

        Dim command As IRunScriptCommand = CommandSelector.GetCommand(optionObject2015, parameter)
        Return command.Execute()

    End Function

End Class