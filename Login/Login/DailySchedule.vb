﻿Imports System.IO

Public Class DailySchedule

    Private fileToLoad As New StreamReader("mySchedule.txt")
    'Private fileToWrite As New StreamWriter("availSchedule.txt")

    Public tmpName As String = Login.userName

    Private Sub DailySchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcomeUser.Text = "Welcome " & tmpName
        Dim tempString As String
        'listDailySched.Items.Add(fileToLoad.ReadToEnd())
        While (fileToLoad.Peek() <> -1)
            tempString = fileToLoad.ReadLine()
            listDailySched.Items.Add(tempString)
        End While
        'listDailySched.Sorted()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        End
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        index.Show()

    End Sub

    Private Sub btnModifed_Click(sender As Object, e As EventArgs) Handles btnModifed.Click
        modifiedSchedule.Show()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

    End Sub
End Class