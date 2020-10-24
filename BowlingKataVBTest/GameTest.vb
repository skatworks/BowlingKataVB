Imports System.Text
Imports BowlingKataVB
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class GameTest

    Private game As Game = Nothing

    ''' <summary>
    ''' テスト初期化
    ''' </summary>
    <TestInitialize()> Public Sub Init()
        game = New Game()
    End Sub

    ''' <summary>
    ''' すべてガターの場合
    ''' </summary>
    <TestMethod()> Public Sub AllGutterTest()
        For i As Integer = 1 To 20
            game.Roll(0)
        Next
        Assert.AreEqual(game.GetScore(), 0)
    End Sub

    ''' <summary>
    ''' すべて1ピンだった場合
    ''' </summary>
    <TestMethod()> Public Sub AllOneRollTest()
        For i As Integer = 1 To 20
            game.Roll(1)
        Next
        Assert.AreEqual(game.GetScore(), 20)
    End Sub

End Class