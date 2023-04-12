Public Class menu2
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
    End Sub

    Private Sub menu2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        time.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
        'Me.BackColor = Color.FromArgb(237, 226, 166)
        '.BackColor = Color.FromArgb(196, 185, 126)
        Button1.FlatAppearance.BorderColor = Color.FromArgb(184, 176, 105)
        Button2.FlatAppearance.BorderColor = Color.FromArgb(184, 176, 105)
        Button3.FlatAppearance.BorderColor = Color.FromArgb(184, 176, 105)
        Button4.FlatAppearance.BorderColor = Color.FromArgb(184, 176, 105)
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(207, 200, 130)
        Button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(207, 200, 130)
        Button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(207, 200, 130)
        Button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(207, 200, 130)
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(207, 200, 130)
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(207, 200, 130)
        Button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(207, 200, 130)
        Button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(207, 200, 130)
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
        report.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        login.Show()
        Me.Close()
    End Sub
End Class