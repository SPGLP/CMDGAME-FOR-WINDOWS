Public Class Form1
    Dim t As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If t < 3 Then
            t += 1
        Else
            F_start.Show()
            Timer1.Stop()
            Me.Hide()
        End If
    End Sub
End Class
