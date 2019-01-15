Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim withdrawal As New Withdrawal
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Balance As Integer = CInt(TextBalance.Text)
        Dim Withdraw As Integer = CInt(TextWithdraw.Text)

        If Withdraw > Balance Then
            MessageBox.Show("ยอดเงินคงเหลือไม่พอ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Withdraw > 20000 Then
            MessageBox.Show("ยอดถอนเกิน 20,000 บาท", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Withdraw Mod 100.0 <> 0 Then
            MessageBox.Show("ยอดถอนต้องเป็นหลักร้อยเท่านั้น", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            TextBalance.Text = Balance - Withdraw

            Dim Note1000 As Integer = Withdraw \ 1000
            Dim Note500 As Integer = (Withdraw Mod 1000) \ 500
            Dim Note100 As Integer = ((Withdraw Mod 1000) Mod 500) \ 100

            LabelResult.Text = "1000 : " & Note1000 & vbNewLine &
                            "500 : " & Note500 & vbNewLine &
                            "100 : " & Note100
        End If




    End Sub

End Class
