Public Class Form7

    Dim Count As Integer = 30
    Dim Oper As Integer
    Dim Opc1 As Integer
    Dim Opc2 As Integer
    Dim Opc3 As Integer
    Public FM4 As Integer = 0
    Public Random1 As Integer
    Public Random2 As Integer
    Public Random3 As Integer


    Private Sub Acep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Acep.Click

        PB1.Hide()
        PB2.Hide()
        PB3.Hide()
        PB4.Hide()
        PB5.Hide()
        PB6.Hide()
        PB7.Hide()
        PB8.Hide()
        PB9.Hide()
        PB10.Hide()
        PV1.Hide()
        PV2.Hide()
        PV3.Hide()
        PV4.Hide()
        PV5.Hide()
        PV6.Hide()
        PV7.Hide()
        PV8.Hide()
        PV9.Hide()
        PV10.Hide()
        PL1.Hide()
        PL2.Hide()
        PL3.Hide()
        Check.Hide()
        NotCheck.Hide()

        Op1.Visible = True
        Op2.Visible = True
        Op3.Visible = True

        Dim Begin As Integer

        Begin = Val(Soul.Text)

        Acep.Text = "ACEPTAR"
        Acep.Location = New Point(113, 70)
        Acep.Size = New Size(110, 36)
        Acep.Font = New Font("Showcard Gothic", 12, FontStyle.Bold)

        If Begin = 0 Then
            Timer1.Enabled = True
        End If

        If Begin <> 0 Then
            Plays.Text = Val(Plays.Text) + 1
            If Op1.Checked = True And Val(Op1.Text) = Oper Then
                Check.Show()
                Cor.Text = Val(Cor.Text) + 1
            ElseIf Op2.Checked = True And Val(Op2.Text) = Oper Then
                Check.Show()
                Cor.Text = Val(Cor.Text) + 1
            ElseIf Op3.Checked = True And Val(Op3.Text) = Oper Then
                Check.Show()
                Cor.Text = Val(Cor.Text) + 1
            ElseIf Op1.Checked = False And Op2.Checked = False And Op3.Checked = False Then
                NotCheck.Show()
            Else
                NotCheck.Show()
            End If
        End If


        Op1.Checked = False
        Op2.Checked = False
        Op3.Checked = False

        Soul.Text = Val(Soul.Text) + 1

        Dim OpR As Integer
        Dim OPB As Integer
        Dim OPV As Integer
        Dim Plus As Integer
        Dim SumRes As Integer
        Dim BotCon As Integer = 0

        OPB = Random1
        OPV = Random2

        Oper = OPB + OPV

        Plus = Math.Round(Rnd() * 2 + 1)

        Select Case OPB
            Case 1 : PB1.Show()
            Case 2 : PB2.Show()
            Case 3 : PB3.Show()
            Case 4 : PB4.Show()
            Case 5 : PB5.Show()
            Case 6 : PB6.Show()
            Case 7 : PB7.Show()
            Case 8 : PB8.Show()
            Case 9 : PB9.Show()
            Case 10 : PB10.Show()
        End Select

        Select Case Plus
            Case 1 : PL1.Show()
            Case 2 : PL2.Show()
            Case 3 : PL3.Show()
        End Select

        Select Case OPV
            Case 1 : PV1.Show()
            Case 2 : PV2.Show()
            Case 3 : PV3.Show()
            Case 4 : PV4.Show()
            Case 5 : PV5.Show()
            Case 6 : PV6.Show()
            Case 7 : PV7.Show()
            Case 8 : PV8.Show()
            Case 9 : PV9.Show()
            Case 10 : PV10.Show()
        End Select

        OpR = Random3

        Select Case OpR
            Case 1, 4 : Opc1 = Oper
                SumRes = Math.Round(Rnd() * 1 + 1)
                Select Case SumRes
                    Case 1 : Opc2 = Oper + Math.Round(Rnd() * 2 + 1)
                    Case 2 : Opc2 = Oper - Math.Round(Rnd() * 1 + 1)
                End Select
                SumRes = Math.Round(Rnd() * 1 + 1)
                Select Case SumRes
                    Case 1 : Opc3 = Oper + Math.Round(Rnd() * 2 + 1)
                    Case 2 : Opc3 = Oper - Math.Round(Rnd() * 1 + 1)
                End Select

                If Opc2 = Opc3 Then
                    Opc2 = Opc1 + 5
                End If

            Case 2, 5 : Opc2 = Oper
                SumRes = Math.Round(Rnd() * 1 + 1)
                Select Case SumRes
                    Case 1 : Opc1 = Oper + Math.Round(Rnd() * 2 + 1)
                    Case 2 : Opc1 = Oper - Math.Round(Rnd() * 1 + 1)
                End Select
                SumRes = Math.Round(Rnd() * 1 + 1)
                Select Case SumRes
                    Case 1 : Opc3 = Oper + Math.Round(Rnd() * 2 + 1)
                    Case 2 : Opc3 = Oper - Math.Round(Rnd() * 1 + 1)
                End Select

                If Opc1 = Opc3 Then
                    Opc1 = Opc1 + 5
                End If

            Case 3, 6 : Opc3 = Oper

                SumRes = Math.Round(Rnd() * 1 + 1)
                Select Case SumRes
                    Case 1 : Opc1 = Oper + Math.Round(Rnd() * 2 + 1)
                    Case 2 : Opc1 = Oper - Math.Round(Rnd() * 1 + 1)
                End Select
                SumRes = Math.Round(Rnd() * 1 + 1)
                Select Case SumRes
                    Case 1 : Opc2 = Oper + Math.Round(Rnd() * 2 + 1)
                    Case 2 : Opc2 = Oper - Math.Round(Rnd() * 1 + 1)
                End Select

                If Opc1 = Opc2 Then
                    Opc1 = Opc1 + 5
                End If

        End Select

        Op1.Text = Opc1
        Op2.Text = Opc2
        Op3.Text = Opc3

    End Sub

    Private Sub Out_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Out.MouseLeave
        Out.Font = New Font("Showcard Gothic", 20, FontStyle.Bold)
        Out.Location = New Point(674, 422)
        Out.ForeColor = Color.Black
    End Sub

    Private Sub Out_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Out.MouseMove
        Out.Font = New Font("Showcard Gothic", 30, FontStyle.Bold)
        Out.Location = New Point(665, 412)
        Out.ForeColor = Color.Red
    End Sub

    Private Sub Out_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Out.Click
        Close()
        Form1.Show()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Count = Count - 1
        Down.Text = Count
        If Count < 1 Then
            Timer1.Stop()
            MsgBox("SE ACABO EL TIEMPO", MsgBoxStyle.Critical)
            FM4 = 4
            Form4.Show()
            Form4.Correct.Text = Cor.Text
            Form4.PlaysR.Text = Plays.Text
            Close()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Random1 = Math.Round(Rnd() * 9 + 1)
        Random2 = Math.Round(Rnd() * 9 + 1)
        Random3 = Math.Round(Rnd() * 5 + 1)
    End Sub
End Class