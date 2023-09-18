Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Add() 'calling the sub function after defining it
        Add2(txtA.Text, txtB.Text)
    End Sub

    Private Sub Add()
        Dim a As Integer = 19597
        Dim b As Integer = 78298
        Dim sum As Integer
        sum = a + b
        MsgBox("The sum of a and b is " & sum)
    End Sub
    Private Sub Add2(ByVal c As Integer, ByVal d As Integer)
        Dim sum1 As Integer
        sum1 = c + d
        MsgBox("The sum of c and d is : " & sum1)
    End Sub
End Class
