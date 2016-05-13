Public Class Form1

    Public FM1 As Integer = 0

    Private Sub Point_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Point.MouseLeave
        Point.Font = New Font("Showcard Gothic", 12, FontStyle.Bold)
        Point.Location = New Point(170, 168)
        Point.ForeColor = Color.Black
    End Sub

    Private Sub Point_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Point.MouseMove
        Point.Font = New Font("Showcard Gothic", 20, FontStyle.Bold)
        Point.Location = New Point(145, 159)
        Point.ForeColor = Color.Red
    End Sub

    Private Sub Time_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Time.MouseLeave
        Time.Font = New Font("Showcard Gothic", 12, FontStyle.Bold)
        Time.Location = New Point(128, 209)
        Time.ForeColor = Color.Black
    End Sub

    Private Sub Time_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Time.MouseMove
        Time.Font = New Font("Showcard Gothic", 20, FontStyle.Bold)
        Time.Location = New Point(85, 200)
        Time.ForeColor = Color.Red
    End Sub

    Private Sub Out_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Out.MouseLeave
        Out.Font = New Font("Showcard Gothic", 20, FontStyle.Bold)
        Out.Location = New Point(387, 254)
        Out.ForeColor = Color.Black
    End Sub

    Private Sub Out_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Out.MouseMove
        Out.Font = New Font("Showcard Gothic", 30, FontStyle.Bold)
        Out.Location = New Point(380, 248)
        Out.ForeColor = Color.Red
    End Sub

    Private Sub Out_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Out.Click
        Close()
    End Sub

    Private Sub Point_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Point.Click
        FM1 = 1
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Time_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Time.Click
        FM1 = 2
        Form2.Show()
        Me.Hide()
    End Sub
End Class
