Public Class SeasonSearch
    Dim y As String
    Dim s As String
    Dim season_ymd As String
    Dim report_ymd As String
    Private Sub year_SelectedIndexChanged(sender As Object, e As EventArgs) Handles year.SelectedIndexChanged
        y = year.Text
    End Sub

    Private Sub season_SelectedIndexChanged(sender As Object, e As EventArgs) Handles season.SelectedIndexChanged
        s = season.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        season_ymd = y + "/"
        If s = "1" Then
            report_ymd = "date LIKE '" + y + "/01/%' OR date LIKE '" + y + "/02/%' OR date LIKE '" + y + "/03/%'"
        ElseIf s = "2" Then
            report_ymd = "date LIKE '" + y + "/04/%' OR date LIKE '" + y + "/05/%' OR date LIKE '" + y + "/06/%'"
        ElseIf s = "3" Then
            report_ymd = "date LIKE '" + y + "/07/%' OR date LIKE '" + y + "/08/%' OR date LIKE '" + y + "/09/%'"
        ElseIf s = "4" Then
            report_ymd = "date LIKE '" + y + "/10/%' OR date LIKE '" + y + "/11/%' OR date LIKE '" + y + "/12/%'"
        End If

        report.Label5.Text = y + "年" + "第" + s + "季 銷售排行榜"
        report.SQL_SeasonReport(season_ymd)
        report.SQL_sRank(report_ymd)
        Me.Close()
    End Sub
End Class