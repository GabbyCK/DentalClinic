Public Class splash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        progressb.Increment(5)

        If progressb.Value = 100 Then
            Me.Hide()
            Dim log = New Login()
            log.Show()
            Timer1.Enabled = False

        End If
    End Sub

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

End Class
