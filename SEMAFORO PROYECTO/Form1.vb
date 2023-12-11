Imports System.ComponentModel

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        COM4.Open()
        inicializar()
    End Sub

    Private Sub inicializar()
        COM4.Write("2")
        COM4.Write("4")
        COM4.Write("6")
    End Sub

    Private Sub rbtRojoEncender_Click(sender As Object, e As EventArgs) Handles rbtRojoEncender.Click
        COM4.Write("1")
    End Sub

    Private Sub rbtRojoApagar_Click(sender As Object, e As EventArgs) Handles rbtRojoApagar.Click
        COM4.Write("2")
    End Sub

    Private Sub rbtVerdeEncender_Click(sender As Object, e As EventArgs) Handles rbtVerdeEncender.Click
        COM4.Write("3")
    End Sub

    Private Sub rbtVerdeApagar_Click(sender As Object, e As EventArgs) Handles rbtVerdeApagar.Click
        COM4.Write("4")
    End Sub

    Private Sub rbtAzulEncender_Click(sender As Object, e As EventArgs) Handles rbtAmarilloEncender.Click
        COM4.Write("5")
    End Sub

    Private Sub rbtAzulApagar_Click(sender As Object, e As EventArgs) Handles rbtAmarilloApagar.Click
        COM4.Write("6")
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        COM4.Close()
    End Sub
End Class
