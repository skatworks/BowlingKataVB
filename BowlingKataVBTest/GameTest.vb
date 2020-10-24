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
        RollMany(20, 0)
        Assert.AreEqual(game.GetScore(), 0)
    End Sub

    ''' <summary>
    ''' すべて1ピンだった場合
    ''' </summary>
    <TestMethod()> Public Sub AllOneRollTest()
        RollMany(20, 1)
        Assert.AreEqual(game.GetScore(), 20)
    End Sub

    ''' <summary>
    ''' １回スペアを出した場合
    ''' </summary>
    <TestMethod()> Public Sub OneSpareTest()
        game.Roll(5)
        game.Roll(5)
        game.Roll(3)
        RollMany(17, 0)
        Assert.AreEqual(game.GetScore(), 16)
    End Sub

    ''' <summary>
    ''' １回ストライクを出した場合
    ''' </summary>
    <TestMethod()> Public Sub OneStrikeTest()
        game.Roll(10)
        game.Roll(3)
        game.Roll(4)
        RollMany(17, 0)
        Assert.AreEqual(game.GetScore(), 24)
    End Sub

    ''' <summary>
    ''' パーフェクトゲームだった場合
    ''' </summary>
    <TestMethod()> Public Sub PerfectGameTest()
        RollMany(12, 10)
        Assert.AreEqual(game.GetScore(), 300)
    End Sub

    ''' <summary>
    ''' 多数回投球して、その際倒したピン数をまとめて入力
    ''' </summary>
    ''' <param name="n">投球回数</param>
    ''' <param name="pins">その都度倒したピンの数</param>
    Private Sub RollMany(ByVal n As Integer, ByVal pins As Integer)
        For i As Integer = 1 To n
            game.Roll(pins)
        Next
    End Sub

End Class