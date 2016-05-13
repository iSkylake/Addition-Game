Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tro1.Hide()
        Tro2.Hide()
        Tro3.Hide()
        FinL1.Hide()
        FinR1.Hide()
        FinL2.Hide()
        FinR2.Hide()
        FinL3.Hide()
        FinR3.Hide()
        GoldL.Hide()
        GoldR.Hide()
        SilL.Hide()
        SilR.Hide()
        BroL.Hide()
        BroR.Hide()

        Dim FM As Integer = 0
        Dim Por As Double

        FM = Form3.FM1 + Form5.FM2 + Form6.FM3 + Form7.FM4

        Select Case FM
            Case 1 : Por = Val(Form3.Cor.Text) / Val(Form3.Plays.Text)
                Por = Por * 100
                If Por = 100 Then
                    Tro1.Show()
                    FinL1.Show()
                    FinR1.Show()
                    GoldL.Show()
                    GoldR.Show()
                ElseIf Por > 49 Then
                    Tro2.Show()
                    FinL2.Show()
                    FinR2.Show()
                    SilL.Show()
                    SilR.Show()
                ElseIf Por < 50 Then
                    Tro3.Show()
                    FinL3.Show()
                    FinR3.Show()
                    BroL.Show()
                    BroR.Show()
                Else
                    Tro3.Show()
                    FinL3.Show()
                    FinR3.Show()
                    BroL.Show()
                    BroR.Show()
                    Correct.Text = 0
                    PlaysR.Text = 0
                End If
            Case 2 : If Val(Form5.Cor.Text) > 9 Then
                    Tro1.Show()
                    FinL1.Show()
                    FinR1.Show()
                    GoldL.Show()
                    GoldR.Show()
                ElseIf Val(Form5.Cor.Text) > 5 And Val(Form5.Cor.Text) < 10 Then
                    Tro2.Show()
                    FinL2.Show()
                    FinR2.Show()
                    SilL.Show()
                    SilR.Show()
                Else
                    Tro3.Show()
                    FinL3.Show()
                    FinR3.Show()
                    BroL.Show()
                    BroR.Show()
                End If
            Case 3 : Por = Val(Form6.Cor.Text) / Val(Form6.Plays.Text)
                Por = Por * 100
                If Por = 100 Then
                    Tro1.Show()
                    FinL1.Show()
                    FinR1.Show()
                    GoldL.Show()
                    GoldR.Show()
                ElseIf Por > 49 Then
                    Tro2.Show()
                    FinL2.Show()
                    FinR2.Show()
                    SilL.Show()
                    SilR.Show()
                ElseIf Por < 50 Then
                    Tro3.Show()
                    FinL3.Show()
                    FinR3.Show()
                    BroL.Show()
                    BroR.Show()
                Else
                    Tro3.Show()
                    FinL3.Show()
                    FinR3.Show()
                    BroL.Show()
                    BroR.Show()
                    Correct.Text = 0
                    PlaysR.Text = 0
                End If
            Case 4 : If Val(Form7.Cor.Text) > 9 Then
                    Tro1.Show()
                    FinL1.Show()
                    FinR1.Show()
                    GoldL.Show()
                    GoldR.Show()
                ElseIf Val(Form7.Cor.Text) > 5 And Val(Form7.Cor.Text) < 10 Then
                    Tro2.Show()
                    FinL2.Show()
                    FinR2.Show()
                    SilL.Show()
                    SilR.Show()
                Else
                    Tro3.Show()
                    FinL3.Show()
                    FinR3.Show()
                    BroL.Show()
                    BroR.Show()
                End If
        End Select

    End Sub

    Private Sub Continiu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Continiu.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Continiu_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Continiu.MouseLeave
        Continiu.Font = New Font("Showcard Gothic", 20, FontStyle.Bold)
        Continiu.Location = New Point(144, 293)
        Continiu.ForeColor = Color.Black
    End Sub

    Private Sub Continiu_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Continiu.MouseMove
        Continiu.Font = New Font("Showcard Gothic", 25, FontStyle.Bold)
        Continiu.Location = New Point(120, 287)
        Continiu.ForeColor = Color.Red
    End Sub
End Class