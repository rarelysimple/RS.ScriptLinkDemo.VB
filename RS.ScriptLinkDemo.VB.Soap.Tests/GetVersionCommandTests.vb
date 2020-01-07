Imports RS.ScriptLinkDemo.VB.Objects

<TestClass()> Public Class GetVersionCommandTests

    <TestMethod()> Public Sub Execute_OptionObject_ReturnsString()

        'Arrange
        Dim expected = ""
        Dim command As IGetVersionCommand = New GetVersionCommand(New OptionObject())

        ' Act
        Dim actual = command.Execute()

        ' Assert
        Assert.AreEqual(expected.GetType(), actual.GetType())

    End Sub

    <TestMethod()> Public Sub Execute_OptionObject2_ReturnsString()

        'Arrange
        Dim expected = ""
        Dim command As IGetVersionCommand = New GetVersionCommand(New OptionObject2())

        ' Act
        Dim actual = command.Execute()

        ' Assert
        Assert.AreEqual(expected.GetType(), actual.GetType())

    End Sub

    <TestMethod()> Public Sub Execute_OptionObject2015_ReturnsString()

        'Arrange
        Dim expected = ""
        Dim command As IGetVersionCommand = New GetVersionCommand(New OptionObject2015())

        ' Act
        Dim actual = command.Execute()

        ' Assert
        Assert.AreEqual(expected.GetType(), actual.GetType())

    End Sub

    <TestMethod()> Public Sub Execute_String_ReturnsString()

        'Arrange
        Dim expected = ""
        Dim command As IGetVersionCommand = New GetVersionCommand(New String(""))

        ' Act
        Dim actual = command.Execute()

        ' Assert
        Assert.AreEqual(expected.GetType(), actual.GetType())

    End Sub

End Class