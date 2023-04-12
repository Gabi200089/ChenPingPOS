Public Class menu1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
    End Sub

    Private Sub menu1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        time.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
        'Button1.BackColor = Color.FromArgb(236, 236, 236)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        orderpage.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        material.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        prepared.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        login.Show()
        Me.Close()
    End Sub
End Class