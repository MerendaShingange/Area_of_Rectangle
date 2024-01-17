Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A As Double
        Dim H As Double
        Dim L As Double
        Dim P As Double
        L = Val(TextBox1.Text)
        H = Val(TextBox2.Text)
        A = L * H
        P = 2 * (L = L)
        TextBox3.Text = A





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim A As Double
        Dim H As Double
        Dim L As Double
        Dim P As Double
        L = Val(TextBox1.Text)
        H = Val(TextBox2.Text)
        A = L * H
        P = 2 * (L = L)
        TextBox4.Text = P
    End Sub
End Class
