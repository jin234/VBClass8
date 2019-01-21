Public Class Form1
    Private Sub TextBoxNum_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNum.TextChanged
        If TextBoxNum.Text <> "" Then
            ButtonCalculate.Enabled = True
            ButtonClear.Enabled = True
        End If
        If TextBoxNum.Text = "" Then
            ButtonCalculate.Enabled = True
            ButtonClear.Enabled = False
            ButtonCalculate.Enabled = False
        End If
    End Sub

    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        Dim ppl As Integer
        Dim BasePrice As Double
        Dim DisPrice As Double

        Try
            ppl = CInt(TextBoxNum.Text)
        Catch ex As Exception
            MessageBox.Show("กรุณาป้อนจำนวนลูกค้าเป็นตัวเลข", "Error", MessageBoxButtons.OK,
                                                MessageBoxIcon.Error)
        End Try

        Dim output As Integer
        If Not (Integer.TryParse(TextBoxNum.Text, output)) Then
            MessageBox.Show("ห้ามใส่จุด", "Error", MessageBoxButtons.OK,
                                                MessageBoxIcon.Error)
            TextBoxNum.Text = ""
            Exit Sub
        End If

        BasePrice = ppl * 299

        If ppl <= 0 Then
            MessageBox.Show("ใส่จำนวนลูกค้า")
            TextBoxNum.Text = ""
            Exit Sub
        End If
        Dim BBQ As New BBQ(ppl, BasePrice, DisPrice)

        If rdNo.Checked = True Then
            LabelTotal.Text = Format(BBQ.calculate, "###0.00") & " บาท"
        End If

        If rdFriend.Checked = True Then
            'Dim dis5 = (BasePrice * 5) / 100
            'DisPrice = BasePrice - dis5
            LabelTotal.Text = Format(BBQ.calculateD5, "###0.00") & " บาท"
        End If

        If rdBuddy.Checked = True Then
            'Dim dis10 = (BasePrice * 10) / 100
            'DisPrice = BasePrice - dis10
            LabelTotal.Text = Format(BBQ.calculateD10, "###0.00") & " บาท"
        End If

    End Sub






    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxNum.Text = ""
        LabelTotal.Text = ""
        rdFriend.Checked = False
        rdBuddy.Checked = False
        rdNo.Checked = False
        ButtonCalculate.Enabled = False
        ButtonClear.Enabled = False
    End Sub
End Class
