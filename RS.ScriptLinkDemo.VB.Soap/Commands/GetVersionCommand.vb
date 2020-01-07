Imports RS.ScriptLinkDemo.VB.Objects

Public Class GetVersionCommand
    Implements IGetVersionCommand

    Private ReadOnly _optionObject As Object

    Public Sub New(ByVal optionObject As Object)
        _optionObject = optionObject
    End Sub

    Public Function Execute() As String Implements IGetVersionCommand.Execute
        Dim version As String = "v.0.0.1"

        If ((TypeOf _optionObject Is OptionObject) Or
            (TypeOf _optionObject Is OptionObject2) Or
            (TypeOf _optionObject Is OptionObject2015)) Then
            Return version + " (" + TypeName(_optionObject) + ")"
        Else
            Return version
        End If
    End Function
End Class
