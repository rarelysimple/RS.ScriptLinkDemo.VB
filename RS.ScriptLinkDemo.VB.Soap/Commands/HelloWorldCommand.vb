Imports RS.ScriptLinkDemo.VB.Objects

Namespace Commands
    Public Class HelloWorldCommand
        Implements IRunScriptCommand

        Private ReadOnly _optionObject2015 As OptionObject2015

        Public Sub New(ByVal optionObject2015 As OptionObject2015)
            _optionObject2015 = optionObject2015
        End Sub

        Function Execute() As OptionObject2015 Implements IRunScriptCommand.Execute
            Return New OptionObject2015 With {
                .EntityID = _optionObject2015.EntityID,
                .EpisodeNumber = _optionObject2015.EpisodeNumber,
                .ErrorCode = 3,
                .ErrorMesg = "Hello, World!",
                .Facility = _optionObject2015.Facility,
                .Forms = _optionObject2015.Forms,
                .NamespaceName = _optionObject2015.NamespaceName,
                .OptionId = _optionObject2015.OptionId,
                .OptionStaffId = _optionObject2015.OptionStaffId,
                .OptionUserId = _optionObject2015.OptionUserId,
                .ParentNamespace = _optionObject2015.ParentNamespace,
                .ServerName = _optionObject2015.ServerName,
                .SessionToken = _optionObject2015.SessionToken,
                .SystemCode = _optionObject2015.SystemCode
            }
        End Function
    End Class
End Namespace
