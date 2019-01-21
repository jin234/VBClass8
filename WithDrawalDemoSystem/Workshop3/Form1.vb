Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim student As Student = New Student

        student.STU_ID = TextBox1.Text)
        student.STU_NAME = TextBox2.Text)
        student.Score_Prac = CInt(TextBox3.Text)
        student.Score_Proj = CInt(TextBox4.Text)
        student.Score_Mid = CInt(TextBox5.Text)
        student.Score_Fin = CInt(TextBox6.Text)

        MessageBox.Show("")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        For Each i In TextBox1.Text
            If Char.IsDigit(i) = False And i <> "-" Then
                TextBox1.Text = TextBox1.Text.Replace(i, "")
            End If
        Next

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        For Each i In TextBox3.Text
            If Char.IsDigit(i) = False Then
                TextBox3.Text = TextBox3.Text.Replace(i, "")
            End If
        Next

        If TextBox3.TextLength <> 0 Then

            If CInt(TextBox3.Text) >= 0 And CInt(TextBox3.Text) <= 10 Then
                Label7.Text = "คะแนนถูกต้อง"
                Label7.ForeColor = Color.Green
            Else
                Label7.Text = "คะแนนต้องอยู่ในช่วง 0 - 10 เท่านั้น"
                Label7.ForeColor = Color.Red
            End If

        Else
            Label7.Text = ""
            Label7.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        For Each i In TextBox4.Text
            If Char.IsDigit(i) = False Then
                TextBox4.Text = TextBox4.Text.Replace(i, "")
            End If
        Next

        If TextBox4.TextLength <> 0 Then

            If CInt(TextBox4.Text) >= 0 And CInt(TextBox4.Text) <= 20 Then
                Label8.Text = "คะแนนถูกต้อง"
                Label8.ForeColor = Color.Green
            Else
                Label8.Text = "คะแนนต้องอยู่ในช่วง 0 - 20 เท่านั้น"
                Label8.ForeColor = Color.Red
            End If

        Else
            Label8.Text = ""
            Label8.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        For Each i In TextBox5.Text
            If Char.IsDigit(i) = False Then
                TextBox5.Text = TextBox5.Text.Replace(i, "")
            End If
        Next

        If TextBox5.TextLength <> 0 Then

            If CInt(TextBox5.Text) >= 0 And CInt(TextBox5.Text) <= 30 Then
                Label9.Text = "คะแนนถูกต้อง"
                Label9.ForeColor = Color.Green
            Else
                Label9.Text = "คะแนนต้องอยู่ในช่วง 0 - 30 เท่านั้น"
                Label9.ForeColor = Color.Red
            End If

        Else
            Label9.Text = ""
            Label9.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        For Each i In TextBox6.Text
            If Char.IsDigit(i) = False Then
                TextBox6.Text = TextBox6.Text.Replace(i, "")
            End If
        Next

        If TextBox6.TextLength <> 0 Then

            If CInt(TextBox6.Text) >= 0 And CInt(TextBox6.Text) <= 30 Then
                Label10.Text = "คะแนนถูกต้อง"
                Label10.ForeColor = Color.Green
            Else
                Label10.Text = "คะแนนต้องอยู่ในช่วง 0 - 30 เท่านั้น"
                Label10.ForeColor = Color.Red
            End If

        Else
            Label10.Text = ""
            Label10.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox6.TextChanged, TextBox5.TextChanged, TextBox4.TextChanged, TextBox3.TextChanged, TextBox2.TextChanged, TextBox1.TextChanged
        If TextBox1.TextLength > 0 And TextBox2.TextLength > 0 And Label7.ForeColor = Color.Green And Label8.ForeColor = Color.Green And Label9.ForeColor = Color.Green And Label10.ForeColor = Color.Green Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub
End Class
