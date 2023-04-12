Imports MySql.Data.MySqlClient
Public Class pay
    Dim ConString As New MySqlConnectionStringBuilder
    Dim x As String


    Private Sub pay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '需考慮第一個數字不為0'
        'TextBox2.Select()
        TextBox1.Text = ""
        TextBox2.Text = orderpage.total.ToString
    End Sub
#Region "鍵盤樣式設定"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + Button1.Text
    End Sub
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackgroundImage = My.Resources.button_after
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackgroundImage = My.Resources.button_before
    End Sub
    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Button2.BackgroundImage = My.Resources.button_after
    End Sub
    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackgroundImage = My.Resources.button_before
    End Sub
    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        Button3.BackgroundImage = My.Resources.button_after
    End Sub
    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.BackgroundImage = My.Resources.button_before
    End Sub
    Private Sub Button4_MouseHover(sender As Object, e As EventArgs) Handles Button4.MouseHover
        Button4.BackgroundImage = My.Resources.button_after
    End Sub
    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Button4.BackgroundImage = My.Resources.button_before
    End Sub
    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles Button5.MouseHover
        Button5.BackgroundImage = My.Resources.button_after
    End Sub
    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.BackgroundImage = My.Resources.button_before
    End Sub
    Private Sub Button6_MouseHover(sender As Object, e As EventArgs) Handles Button6.MouseHover
        Button6.BackgroundImage = My.Resources.button_after
    End Sub
    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs) Handles Button6.MouseLeave
        Button6.BackgroundImage = My.Resources.button_before
    End Sub
    Private Sub Button7_MouseHover(sender As Object, e As EventArgs) Handles Button7.MouseHover
        Button7.BackgroundImage = My.Resources.button_after
    End Sub
    Private Sub Button7_MouseLeave(sender As Object, e As EventArgs) Handles Button7.MouseLeave
        Button7.BackgroundImage = My.Resources.button_before
    End Sub
    Private Sub Button8_MouseHover(sender As Object, e As EventArgs) Handles Button8.MouseHover
        Button8.BackgroundImage = My.Resources.button_after
    End Sub
    Private Sub Button8_MouseLeave(sender As Object, e As EventArgs) Handles Button8.MouseLeave
        Button8.BackgroundImage = My.Resources.button_before
    End Sub
    Private Sub Button9_MouseHover(sender As Object, e As EventArgs) Handles Button9.MouseHover
        Button9.BackgroundImage = My.Resources.button_after
    End Sub
    Private Sub Button9_MouseLeave(sender As Object, e As EventArgs) Handles Button9.MouseLeave
        Button9.BackgroundImage = My.Resources.button_before
    End Sub
    Private Sub Button10_MouseHover(sender As Object, e As EventArgs) Handles Button10.MouseHover
        Button10.BackgroundImage = My.Resources.button_after
    End Sub
    Private Sub Button10_MouseLeave(sender As Object, e As EventArgs) Handles Button10.MouseLeave
        Button10.BackgroundImage = My.Resources.button_before
    End Sub
    Private Sub Button12_MouseHover(sender As Object, e As EventArgs) Handles Button12.MouseHover
        Button12.BackgroundImage = My.Resources.redo_after
    End Sub
    Private Sub Button12_MouseLeave(sender As Object, e As EventArgs) Handles Button12.MouseLeave
        Button12.BackgroundImage = My.Resources.redo
    End Sub
    Private Sub Button13_MouseHover(sender As Object, e As EventArgs) Handles Button13.MouseHover
        Button13.BackgroundImage = My.Resources.back_after1
    End Sub
    Private Sub Button13_MouseLeave(sender As Object, e As EventArgs) Handles Button13.MouseLeave
        Button13.BackgroundImage = My.Resources.back_before1
    End Sub
#End Region

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text + Button2.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text + Button3.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text + Button4.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text + Button5.Text
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + Button6.Text
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text + Button7.Text
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text + Button8.Text
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text + Button9.Text
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text + Button10.Text
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = ""
        TextBox3.Text = orderpage.total
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If TextBox1.Text <> "" Then
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
        End If
        If TextBox1.Text = "" Then
            TextBox3.Text = 0
        End If
    End Sub
    Private Sub confirmButton1_Click(sender As Object, e As EventArgs) Handles confirmButton1.Click
        If CInt(TextBox3.Text) < 0 Then
            MsgBox("付款金額不足", 48 + 0, "金額不足")
        Else
            MsgBox("交易完成，須找零" + TextBox3.Text + "元", 64 + 0, "交易完成")
            orderpage.done = True
            Me.Hide()
            TextBox1.Text = ""
            TextBox2.Text = "0"
            TextBox3.Text = ""
        End If


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then
            TextBox3.Text = CInt(TextBox1.Text) - CInt(TextBox2.Text)
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Close()
    End Sub
End Class