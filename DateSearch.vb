Public Class DateSearch
    Dim y As String
    Dim m As String
    Dim d As String
    Dim date_ymd As String
    Dim report_ymd As String
    Private Sub year_SelectedIndexChanged(sender As Object, e As EventArgs) Handles year.SelectedIndexChanged
        y = year.Text
    End Sub

    Private Sub month_SelectedIndexChanged(sender As Object, e As EventArgs) Handles month.SelectedIndexChanged
        m = month.Text
    End Sub

    Private Sub day_SelectedIndexChanged(sender As Object, e As EventArgs) Handles day.SelectedIndexChanged
        d = day.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        date_ymd = y + "/" + m + "/"
        report_ymd = y + "/" + m + "/" + d

        report.Label5.Text = y + "年" + m + "月" + d + "日 銷售排行榜"
        report.SQL_DateReport(date_ymd)
        report.SQL_Rank(report_ymd)
        Me.Close()
    End Sub

    Private Sub DateSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class