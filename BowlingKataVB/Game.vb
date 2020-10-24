Public Class Game

    Private score As Integer = 0

    ''' <summary>
    ''' 1投で倒したピンの数
    ''' </summary>
    ''' <param name="pins">1投で倒したピンの数</param>
    Public Sub Roll(ByVal pins As Integer)
        score += pins
    End Sub

    ''' <summary>
    ''' スコア
    ''' </summary>
    ''' <returns>スコア</returns>
    Public Function GetScore() As Integer
        Return score
    End Function
End Class
