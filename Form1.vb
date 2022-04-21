Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y As Integer
        For x = 1 To 3
            For y = 1 To 4
                TextBox1.Text = TextBox1.Text & "#" & vbCr
            Next y
            TextBox1.Text = TextBox1.Text & "#" & vbCrLf

        Next x

        Dim z, a As Integer
        For z = 1 To 3
            For a = 1 To 4
                TextBox2.Text = TextBox2.Text & "#" & vbCr
            Next a
            TextBox2.Text = TextBox2.Text & "#" & vbCrLf

        Next z
    End Sub
End Class
