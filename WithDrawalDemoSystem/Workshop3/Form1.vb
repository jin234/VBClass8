﻿Public Class Form1
    Dim chck As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox6.TextChanged, TextBox5.TextChanged, TextBox4.TextChanged, TextBox3.TextChanged, TextBox2.TextChanged, TextBox1.TextChanged
        If TextBox1.TextLength > 0 And TextBox2.TextLength > 0 And TextBox3.TextLength > 0 And TextBox4.TextLength > 0 And TextBox5.TextLength > 0 And TextBox6.TextLength > 0 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If

    End Sub
End Class
