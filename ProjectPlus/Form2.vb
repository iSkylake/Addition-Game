Public Class Form2

    Public FM As Integer

    Private Sub PointEasy_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Easy.MouseLeave
        Easy.Font = New Font("Showcard Gothic", 12, FontStyle.Bold)
        Easy.Location = New Point(182, 157)
        Easy.ForeColor = Color.Black
    End Sub


    Private Sub PointEasy_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Easy.MouseMove
        Easy.Font = New Font("Showcard Gothic", 20, FontStyle.Bold)
        Easy.Location = New Point(165, 150)
        Easy.ForeColor = Color.Red
    End Sub

    Private Sub PointAsian_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Asian.MouseLeave
        Asian.Font = New Font("Showcard Gothic", 12, FontStyle.Bold)
        Asian.Location = New Point(169, 194)
        Asian.ForeColor = Color.Black
    End Sub

    Private Sub PointAsian_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Asian.MouseMove
        Asian.Font = New Font("Showcard Gothic", 20, FontStyle.Bold)
        Asian.Location = New Point(140, 185)
        Asian.ForeColor = Color.Red
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
        Form1.Close()
        Close()
    End Sub

    Private Sub Back_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Back.MouseLeave
        Back.Font = New Font("Showcard Gothic", 12, FontStyle.Bold)
        Back.Location = New Point(24, 255)
        Back.ForeColor = Color.Black
    End Sub

    Private Sub Back_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Back.MouseMove
        Back.Font = New Font("Showcard Gothic", 20, FontStyle.Bold)
        Back.Location = New Point(12, 246)
        Back.ForeColor = Color.Red
    End Sub

    Private Sub Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Easy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Easy.Click
        FM = Form1.FM1
        Select Case FM
            Case 1 : Form3.Show()
            Case 2 : Form5.Show()
        End Select
        Me.Hide()
    End Sub

    Private Sub Asian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Asian_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Asian.Click
        FM = Form1.FM1
        Select Case FM
            Case 1 : Form6.Show()
            Case 2 : Form7.Show()
        End Select
        Me.Hide()
    End Sub
End Class