Imports RS.ScriptLinkDemo.VB.Objects
Imports RS.ScriptLinkDemo.VB.Soap.Commands
Imports RS.ScriptLinkDemo.VB.Soap.Factories

<TestClass()> Public Class CommandSelectorTests

    <TestMethod()> Public Sub GetCommand_EmptyParameter_ReturnsDefaultCommand()
        ' Arrange
        Dim optionObject2015 As New OptionObject2015()
        Dim parameter As String = ""
        Dim expected = New DefaultCommand(optionObject2015, parameter)

        ' Act
        Dim actual As IRunScriptCommand = CommandSelector.GetCommand(optionObject2015, parameter)

        ' Assert
        Assert.AreEqual(expected.GetType(), actual.GetType())
    End Sub

    <TestMethod()> Public Sub GetCommand_EmptyParameter_ReturnsHelloWorldCommand()
        ' Arrange
        Dim optionObject2015 As New OptionObject2015()
        Dim parameter As String = "HelloWorld"
        Dim expected = New HelloWorldCommand(optionObject2015)

        ' Act
        Dim actual As IRunScriptCommand = CommandSelector.GetCommand(optionObject2015, parameter)

        ' Assert
        Assert.AreEqual(expected.GetType(), actual.GetType())
    End Sub

End Class