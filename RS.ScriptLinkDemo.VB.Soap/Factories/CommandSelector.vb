Imports RS.ScriptLinkDemo.VB.Objects
Imports RS.ScriptLinkDemo.VB.Soap.Commands

Namespace Factories
    Public Class CommandSelector
        Public Shared Function GetCommand(ByVal optionObject2015 As OptionObject2015, ByVal parameter As String)
            Select Case (parameter)
                Case "HelloWorld"
                    Return New HelloWorldCommand(optionObject2015)
                Case Else
                    Return New DefaultCommand(optionObject2015, parameter)
            End Select
        End Function
    End Class
End Namespace
