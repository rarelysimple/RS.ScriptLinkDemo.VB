Imports RS.ScriptLinkDemo.VB.Objects
Imports RS.ScriptLinkDemo.VB.Soap.Commands

<TestClass()> Public Class HelloWorldCommandTests

    <TestMethod()> Public Sub Execute_HelloWorldCommand_ReturnsOptionObject2015()
        ' Arrange
        Dim expected As New OptionObject2015()

        Dim optionObject2015 As OptionObject2015 = New OptionObject2015()
        Dim command = New HelloWorldCommand(optionObject2015)

        ' Act
        Dim actual = command.Execute()

        ' Assert
        Assert.AreEqual(expected.GetType(), actual.GetType())
    End Sub

    <TestMethod()> Public Sub Execute_HelloWorldCommand_ErrorCodeEquals3()
        ' Arrange
        Dim expected As Double = 3

        Dim optionObject2015 As New OptionObject2015()
        Dim command = New HelloWorldCommand(optionObject2015)

        ' Act
        Dim actual As OptionObject2015 = command.Execute()

        ' Assert
        Assert.AreEqual(expected, actual.ErrorCode)
    End Sub

End Class