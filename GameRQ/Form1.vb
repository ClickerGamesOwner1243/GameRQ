Public Class Form1
    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Me.Close()
    End Sub
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Me.Close()
    End Sub
    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Me.Close()
    End Sub
    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        Me.Close()
    End Sub
    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles Button5.MouseEnter
        Me.Close()
    End Sub
    Private Sub Button6_MouseEnter(sender As Object, e As EventArgs) Handles Button6.MouseEnter
        Me.Close()
    End Sub
    Private Sub Button7_MouseEnter(sender As Object, e As EventArgs) Handles Button7.MouseEnter
        Me.Close()
    End Sub
    Private Sub Button8_MouseEnter(sender As Object, e As EventArgs) Handles Button8.MouseEnter
        Me.Close()
    End Sub
    Private Sub Button10_MouseEnter(sender As Object, e As EventArgs) Handles Button10.MouseEnter
        Me.Close()
    End Sub
    Private Sub Button9_MouseEnter(sender As Object, e As EventArgs) Handles Button9.MouseEnter
        Me.Close()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        MessageBox.Show("You win", "Good job", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Button11.Visible = False
        Label1.Visible = False
        Label2.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = True
        Label1.BringToFront()
        Button11.Visible = True
        Button11.BringToFront()
        Label2.Visible = True
        Label2.BringToFront()
    End Sub
End Class
