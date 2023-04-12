Public Class MonthSearch
    Dim y As String
    Dim m As String
    Dim month_ymd As String
    Dim report_ymd As String

    Private Sub year_SelectedIndexChanged(sender As Object, e As EventArgs) Handles year.SelectedIndexChanged
        y = year.Text
    End Sub

    Private Sub month_SelectedIndexChanged(sender As Object, e As EventArgs) Handles month.SelectedIndexChanged
        m = month.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        month_ymd = y + "/"
        report_ymd = y + "/" + m
        report.Label5.Text = y + "年" + m + "月 銷售排行榜"
        report.SQL_MonthReport(month_ymd)
        report.SQL_Rank(report_ymd)
        Me.Close()
    End Sub
End Class