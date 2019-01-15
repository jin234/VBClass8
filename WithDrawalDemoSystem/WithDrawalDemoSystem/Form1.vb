Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rng As Random = New Random
        TextBalance.Text = rng.Next(1, 9) * 100000
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each i In CStr(TextWithdraw.Text)
            If Char.IsNumber(i) = False Then
                MessageBox.Show("กรุณาป้อนแต่ตัวเลข ที่ไม่มีอักขระพิเศษ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextWithdraw.Text = ""
                Exit Sub
            End If
        Next

        Dim Balance As Integer = CInt(TextBalance.Text)
        Dim Withdraw As Integer = CInt(TextWithdraw.Text)


        If Withdraw > Balance Then
            MessageBox.Show("ยอดเงินคงเหลือไม่พอ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Withdraw > 20000 Then
            MessageBox.Show("ยอดถอนเกิน 20,000 บาท", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Withdraw Mod 100.0 <> 0 Then
            MessageBox.Show("ยอดถอนต้องเป็นหลักร้อยเท่านั้น", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Withdraw <= 0 Then
            MessageBox.Show("ยอดถอนต้องเป็นจำนวนเต็มบวกเท่านั้น", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim withdrawal As New Withdrawal
            withdrawal.Withdraw = Withdraw
            withdrawal.Balance = Balance
            Dim Note1000 As Integer = Withdraw \ 1000
            Dim Note500 As Integer = (Withdraw Mod 1000) \ 500
            Dim Note100 As Integer = ((Withdraw Mod 1000) Mod 500) \ 100

            LabelResult.Text = "1000 : " & Note1000 & vbNewLine &
                            "500 : " & Note500 & vbNewLine &
                            "100 : " & Note100
        End If




    End Sub

    Private Sub TextWithdraw_TextChanged(sender As Object, e As EventArgs) Handles TextWithdraw.TextChanged
        If TextWithdraw.TextLength <> 0 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub
End Class
