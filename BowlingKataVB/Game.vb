Public Class Game

    Private Rolls(21) As Integer
    Private currentRoll As Integer = 1

    ''' <summary>
    ''' 1投で倒したピンの数
    ''' </summary>
    ''' <param name="pins">1投で倒したピンの数</param>
    Public Sub Roll(ByVal pins As Integer)
        Rolls(currentRoll) = pins
        currentRoll = currentRoll + 1
    End Sub

    ''' <summary>
    ''' スコア
    ''' </summary>
    ''' <returns>スコア</returns>
    Public Function GetScore() As Integer
        Dim score As Integer = 0
        Dim frameIndex As Integer = 1
        For frame As Integer = 1 To 10
            If (Rolls(frameIndex) = 10) Then
                score += 10 + Rolls(frameIndex + 1) + Rolls(frameIndex + 2)
                frameIndex = frameIndex + 1
            ElseIf (Rolls(frameIndex) + Rolls(frameIndex + 1)) = 10 Then
                score += 10 + Rolls(frameIndex + 2)
                frameIndex = frameIndex + 2
            Else
                score += Rolls(frameIndex) + Rolls(frameIndex + 1)
                frameIndex = frameIndex + 2
            End If
        Next

        Return score
    End Function
End Class
