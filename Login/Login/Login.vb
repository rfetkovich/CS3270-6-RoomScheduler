﻿Public Class Login

    Dim userName As String = Nothing
    Dim passWord As String = Nothing

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If userName <> "abc" Then
            MessageBox.Show("User is Invalid")
        End If
        If PassWord <> "123" Then
            MessageBox.Show("Password is Invalid")
        End If
        If userName = "abc" And passWord = "123" Then
            Form2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ForgotPassword.Show()
    End Sub

    Private Sub tbUserName_TextChanged(sender As Object, e As EventArgs) Handles tbUserName.TextChanged
        userName = tbUserName.Text
    End Sub

    Private Sub tbPassWord_TextChanged(sender As Object, e As EventArgs) Handles tbPassWord.TextChanged
        passWord = tbPassWord.Text
    End Sub
End Class
