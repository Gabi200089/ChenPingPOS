Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Public Class report
    Dim ConString As New MySqlConnectionStringBuilder
    Dim orderid As Integer
    Dim date_data(31) As String
    Dim date_sum(31) As Integer
    'Dim date_rank()
    Dim month_data(12) As String
    Dim month_sum(12) As Integer
    Dim season_data(4) As String
    Dim season_sum(4) As Integer
    Dim r(5) As String
    Dim stage As Char

    Sub connect()
        '建立連線字串
        'ConString.Database = "report_test"
        ConString.Database = "sa"
        ConString.Server = "127.0.0.1"
        ConString.UserID = "user"
        ConString.Password = "12345678"
        ConString.SslMode = MySqlSslMode.None
    End Sub

    Sub resetall()
        For i = 1 To 31
            date_data(i) = ""
            date_sum(i) = 0
        Next
        For i = 1 To 12
            month_data(i) = ""
            month_sum(i) = 0
        Next
        For i = 1 To 4
            season_data(i) = ""
            season_sum(i) = 0
        Next
        For i = 1 To 5
            r(i) = Nothing
        Next


    End Sub
#Region "查價"
    Private Function change(ByVal d As String, ByVal sum As Integer) As Integer
        Select Case d
            Case "A0"
                sum += 25
            Case "A1"
                sum += 30
            Case "A2"
                sum += 35
            Case "B0"
                sum += 25
            Case "B1"
                sum += 30
            Case "B2"
                sum += 35
            Case "C0"
                sum += 30
            Case "C1"
                sum += 35
            Case "C2"
                sum += 40
            Case "D0"
                sum += 30
            Case "D1"
                sum += 35
            Case "D2"
                sum += 40
            Case "E0"
                sum += 35
            Case "E1"
                sum += 40
            Case "E2"
                sum += 45
            Case "dA500"
                sum += 20
            Case "dA1000"
                sum += 40
            Case "dB500"
                sum += 40
            Case "dB1000"
                sum += 80
            Case "dC500"
                sum += 35
            Case "dC1000"
                sum += 70
            Case "ice0"
                sum += 35
            Case "ice1"
                sum += 40
            Case "ice2"
                sum += 40
            Case "ice3"
                sum += 50
            Case "ice4"
                sum += 55
        End Select
        Return sum
    End Function
#End Region
#Region "查名"
    Private Function change_name(ByVal id As String) As String
        Dim name As String
        Select Case id
            Case "A0"
                name = "焦糖豆花原味"
            Case "A1"
                name = "焦糖豆花1料"
            Case "A2"
                name = "焦糖豆花2或3料"
            Case "B0"
                name = "豆漿豆花原味"
            Case "B1"
                name = "豆漿豆花1料"
            Case "B2"
                name = "豆漿豆花2或3料"
            Case "C0"
                name = "杏仁豆花原味"
            Case "C1"
                name = "杏仁豆花1料"
            Case "C2"
                name = "杏仁豆花2或3料"
            Case "D0"
                name = "芝麻糊豆花原味"
            Case "D1"
                name = "芝麻糊豆花1料"
            Case "D2"
                name = "芝麻糊豆花2或3料"
            Case "E0"
                name = "香草鮮奶豆花原味"
            Case "E1"
                name = "香草鮮奶豆花1料"
            Case "E2"
                name = "香草鮮奶豆花2或3料"
            Case "dA500"
                name = "豆漿500cc"
            Case "dA1000"
                name = "豆漿1000cc"
            Case "dB500"
                name = "杏仁茶500cc"
            Case "dB1000"
                name = "杏仁茶1000cc"
            Case "dC500"
                name = "芝麻糊500cc"
            Case "dC1000"
                name = "芝麻糊1000cc"
            Case "ice0"
                name = "黑糖刨冰原味"
            Case "ice1"
                name = "黑糖刨冰加煉乳"
            Case "ice2"
                name = "鳳梨刨冰原味"
            Case "ice3"
                name = "鳳梨刨冰加料"
            Case "ice4"
                name = "鳳梨刨冰加料加煉乳"
        End Select
        Return name
    End Function
#End Region
#Region "日報表"
    Public Function SQL_DateReport(ByVal date_ymd As String)
        Dim i As Integer = 1
        Call connect()
        '建立查詢字串
        Dim QueryString As String = "SELECT dish_id, date FROM orders WHERE date LIKE '" & date_ymd & "%' ORDER BY `date` ASC;"
        '建立資料庫連線物件
        Using Connection As New MySqlConnection(ConString.ToString)
            '建立送入查詢字串物件
            Dim MyCommand As MySqlCommand = Connection.CreateCommand()
            MyCommand.CommandText = QueryString
            Try
                '開啟資料庫連線
                Connection.Open()

                '建立資料表橋接器
                Dim Adapter As New MySqlDataAdapter()
                '送出給MySql Server 執行的 SQL 指令
                Adapter.SelectCommand = MyCommand

                'DataSet可以存放多個表格資料，把資料放到 DataSet1 的第一個表格
                Adapter.Fill(DataSet1.Tables(0))

                '如果程式操作期間有對DataSet1中的任何資料做修改且需要更新資料庫，則可利用 update 方法把資料送回MySql Server
                'Adapter.Update(DataSet1)

                '設定繫結資料來源
                BindingSource1.DataSource = DataSet1
                '設定有繫結作用的資料來源中的哪個表格
                BindingSource1.DataMember = DataSet1.Tables(0).ToString
                'DataGridView1.DataSource = BindingSource1
                'Label1.Text = BindingSource1.ToString
                'i = 0
                Dim dataReader As MySqlDataReader = MyCommand.ExecuteReader()

                Do While dataReader.Read()
                    If dataReader(1).ToString.Substring(8, 1) = 0 Then
                        i = dataReader(1).ToString.Substring(9, 1)
                        date_data(i) = dataReader(0)
                        date_sum(i) = change(date_data(i), date_sum(i)).ToString
                    Else
                        i = dataReader(1).ToString.Substring(8, 2)
                        date_data(i) = dataReader(0)
                        date_sum(i) = change(date_data(i), date_sum(i)).ToString

                    End If
                Loop
                For j = 1 To 31
                    Chart1.Series("Series").Points.AddXY(j, date_sum(j))
                Next
                dataReader.Close()

            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                Connection.Close()
            End Try
        End Using
    End Function
#End Region
#Region "月報表"

    Public Function SQL_MonthReport(ByVal month_ymd As String)
        Dim i As Integer = 1
        Call connect()
        '建立查詢字串
        Dim QueryString As String = "SELECT dish_id, date FROM orders WHERE date LIKE '" & month_ymd & "%' ORDER BY `date` ASC;"
        '建立資料庫連線物件
        Using Connection As New MySqlConnection(ConString.ToString)
            '建立送入查詢字串物件
            Dim MyCommand As MySqlCommand = Connection.CreateCommand()
            MyCommand.CommandText = QueryString
            Try
                '開啟資料庫連線
                Connection.Open()

                '建立資料表橋接器
                Dim Adapter As New MySqlDataAdapter()
                '送出給MySql Server 執行的 SQL 指令
                Adapter.SelectCommand = MyCommand

                'DataSet可以存放多個表格資料，把資料放到 DataSet1 的第一個表格
                Adapter.Fill(DataSet1.Tables(0))

                '如果程式操作期間有對DataSet1中的任何資料做修改且需要更新資料庫，則可利用 update 方法把資料送回MySql Server
                'Adapter.Update(DataSet1)

                '設定繫結資料來源
                BindingSource1.DataSource = DataSet1
                '設定有繫結作用的資料來源中的哪個表格
                BindingSource1.DataMember = DataSet1.Tables(0).ToString
                'DataGridView1.DataSource = BindingSource1
                'Label1.Text = BindingSource1.ToString
                'i = 0
                Dim dataReader As MySqlDataReader = MyCommand.ExecuteReader()

                Do While dataReader.Read()
                    If dataReader(1).ToString.Substring(5, 1) = 0 Then
                        i = dataReader(1).ToString.Substring(6, 1)
                        month_data(i) = dataReader(0)
                        month_sum(i) = change(month_data(i), month_sum(i)).ToString
                    Else
                        i = dataReader(1).ToString.Substring(5, 2)
                        month_data(i) = dataReader(0)
                        month_sum(i) = change(month_data(i), month_sum(i)).ToString
                    End If
                Loop
                For j = 1 To 12
                    Chart1.Series("Series").Points.AddXY(j, month_sum(j))
                Next
                dataReader.Close()

            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                Connection.Close()
            End Try
        End Using
    End Function
#End Region
#Region "季報表"
    Public Function SQL_SeasonReport(ByVal season_ymd As String)
        Dim i As Integer = 1
        Call connect()
        '建立查詢字串
        Dim QueryString As String = "SELECT dish_id, date FROM orders WHERE date LIKE '" & season_ymd & "%' ORDER BY `date` ASC;"
        '建立資料庫連線物件
        Using Connection As New MySqlConnection(ConString.ToString)
            '建立送入查詢字串物件
            Dim MyCommand As MySqlCommand = Connection.CreateCommand()
            MyCommand.CommandText = QueryString
            Try
                '開啟資料庫連線
                Connection.Open()

                '建立資料表橋接器
                Dim Adapter As New MySqlDataAdapter()
                '送出給MySql Server 執行的 SQL 指令
                Adapter.SelectCommand = MyCommand

                'DataSet可以存放多個表格資料，把資料放到 DataSet1 的第一個表格
                Adapter.Fill(DataSet1.Tables(0))

                '如果程式操作期間有對DataSet1中的任何資料做修改且需要更新資料庫，則可利用 update 方法把資料送回MySql Server
                'Adapter.Update(DataSet1)

                '設定繫結資料來源
                BindingSource1.DataSource = DataSet1
                '設定有繫結作用的資料來源中的哪個表格
                BindingSource1.DataMember = DataSet1.Tables(0).ToString
                'DataGridView1.DataSource = BindingSource1
                'Label1.Text = BindingSource1.ToString
                'i = 0
                Dim dataReader As MySqlDataReader = MyCommand.ExecuteReader()

                Do While dataReader.Read()
                    If dataReader(1).ToString.Substring(5, 2) = "01" Or dataReader(1).ToString.Substring(5, 2) = "02" Or dataReader(1).ToString.Substring(5, 2) = "03" Then
                        i = 1
                        season_data(i) = dataReader(0)
                        season_sum(i) = change(season_data(i), season_sum(i)).ToString
                    ElseIf dataReader(1).ToString.Substring(5, 2) = "04" Or dataReader(1).ToString.Substring(5, 2) = "05" Or dataReader(1).ToString.Substring(5, 2) = "06" Then
                        i = 2
                        season_data(i) = dataReader(0)
                        season_sum(i) = change(season_data(i), season_sum(i)).ToString
                    ElseIf dataReader(1).ToString.Substring(5, 2) = "07" Or dataReader(1).ToString.Substring(5, 2) = "08" Or dataReader(1).ToString.Substring(5, 2) = "09" Then
                        i = 3
                        season_data(i) = dataReader(0)
                        season_sum(i) = change(season_data(i), season_sum(i)).ToString
                    Else
                        i = 4
                        season_data(i) = dataReader(0)
                        season_sum(i) = change(season_data(i), season_sum(i)).ToString
                    End If
                Loop
                For j = 1 To 4
                    Chart1.Series("Series").Points.AddXY(j, season_sum(j))
                Next
                dataReader.Close()

            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                Connection.Close()
            End Try
        End Using
    End Function
#End Region
#Region "日月排名"

    Public Function SQL_Rank(ByVal rank As String)
        Dim i As Integer = 1
        Call connect()
        '建立查詢字串
        Dim QueryString As String = "SELECT dish_id,count( * ) AS count FROM orders WHERE date LIKE '" & rank & "%' GROUP BY dish_id ORDER BY count DESC LIMIT 5;"
        '建立資料庫連線物件
        Using Connection As New MySqlConnection(ConString.ToString)
            '建立送入查詢字串物件
            Dim MyCommand As MySqlCommand = Connection.CreateCommand()
            MyCommand.CommandText = QueryString
            Try
                '開啟資料庫連線
                Connection.Open()

                '建立資料表橋接器
                Dim Adapter As New MySqlDataAdapter()
                '送出給MySql Server 執行的 SQL 指令
                Adapter.SelectCommand = MyCommand

                'DataSet可以存放多個表格資料，把資料放到 DataSet1 的第一個表格
                Adapter.Fill(DataSet1.Tables(0))

                '如果程式操作期間有對DataSet1中的任何資料做修改且需要更新資料庫，則可利用 update 方法把資料送回MySql Server
                'Adapter.Update(DataSet1)

                '設定繫結資料來源
                BindingSource1.DataSource = DataSet1
                '設定有繫結作用的資料來源中的哪個表格
                BindingSource1.DataMember = DataSet1.Tables(0).ToString
                'DataGridView1.DataSource = BindingSource1
                'Label1.Text = BindingSource1.ToString
                'i = 0
                Dim dataReader As MySqlDataReader = MyCommand.ExecuteReader()

                Do While dataReader.Read()
                    r(i) = change_name(dataReader(0).ToString)
                    i = i + 1
                Loop

                dataReader.Close()

                number1_name.Text = r(1)
                number2_name.Text = r(2)
                number3_name.Text = r(3)
                number4_name.Text = r(4)
                number5_name.Text = r(5)

            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                Connection.Close()
            End Try
        End Using
    End Function
#End Region
#Region "季排名"

    Public Function SQL_sRank(ByVal rank As String) 'ByVal rank As String
        Dim i As Integer = 1
        Call connect()
        '建立查詢字串
        Dim QueryString As String = "SELECT dish_id,count( * ) AS count FROM orders WHERE " & rank & " GROUP BY dish_id ORDER BY count DESC LIMIT 5;"
        'Dim QueryString As String = "SELECT dish_id,count( * ) AS count FROM orders WHERE date LIKE '2020/04/%' OR date LIKE '2020/05/%' OR date LIKE '2020/06/%' GROUP BY dish_id ORDER BY count DESC LIMIT 5;"
        '建立資料庫連線物件
        Using Connection As New MySqlConnection(ConString.ToString)
            '建立送入查詢字串物件
            Dim MyCommand As MySqlCommand = Connection.CreateCommand()
            MyCommand.CommandText = QueryString
            Try
                '開啟資料庫連線
                Connection.Open()

                '建立資料表橋接器
                Dim Adapter As New MySqlDataAdapter()
                '送出給MySql Server 執行的 SQL 指令
                Adapter.SelectCommand = MyCommand

                'DataSet可以存放多個表格資料，把資料放到 DataSet1 的第一個表格
                Adapter.Fill(DataSet1.Tables(0))

                '如果程式操作期間有對DataSet1中的任何資料做修改且需要更新資料庫，則可利用 update 方法把資料送回MySql Server
                'Adapter.Update(DataSet1)

                '設定繫結資料來源
                BindingSource1.DataSource = DataSet1
                '設定有繫結作用的資料來源中的哪個表格
                BindingSource1.DataMember = DataSet1.Tables(0).ToString
                'DataGridView1.DataSource = BindingSource1
                'Label1.Text = BindingSource1.ToString
                'i = 0
                Dim dataReader As MySqlDataReader = MyCommand.ExecuteReader()

                Do While dataReader.Read()
                    r(i) = change_name(dataReader(0).ToString)
                    i = i + 1
                Loop

                dataReader.Close()

                number1_name.Text = r(1)
                number2_name.Text = r(2)
                number3_name.Text = r(3)
                number4_name.Text = r(4)
                number5_name.Text = r(5)

            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                Connection.Close()
            End Try
        End Using
    End Function
#End Region
    Private Sub report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each cs As Series In Chart1.Series
            cs.IsValueShownAsLabel = True
            ' cs.SmartLabelStyle.Enabled = False
        Next
        'https://social.msdn.microsoft.com/Forums/vstudio/en-US/dd43be17-d0b6-4eb3-9523-8349ff096286/x-axis-labels?forum=MSWinWebChart
        Dim CArea As ChartArea = Chart1.ChartAreas(0)
        'CArea.BackColor = Color.Azure
        'CArea.ShadowColor = Color.Red
        CArea.Area3DStyle.Enable3D = False
        'CArea.AxisX.LabelStyle.Angle = -45
        CArea.AxisX.LabelStyle.Font = New Font("微軟正黑體", 13.0F)
        CArea.AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount
        CArea.AxisX.IsLabelAutoFit = False
        CArea.AxisX.LabelStyle.IsStaggered = True
        'https://blog.csdn.net/wf824284257/article/details/54947350
        CArea.AxisX.Interval = 1
        CArea.AxisX.LabelStyle.Angle = -40
        ' Chart1.ChartAreas("ChartArea1").AxisX.LabelAngle = 90;
    End Sub
    Private Sub date_btn_Click(sender As Object, e As EventArgs) Handles date_btn.Click
        year.Text = Format(Now, "yyyy")
        month.Text = Format(Now, "MM")
        day.Text = Format(Now, "dd")
#Region "Button設定"
        date_btn.BackColor = System.Drawing.Color.White
        month_btn.BackColor = System.Drawing.Color.SteelBlue
        season_btn.BackColor = System.Drawing.Color.SteelBlue
        date_btn.ForeColor = System.Drawing.Color.SteelBlue
        month_btn.ForeColor = System.Drawing.Color.White
        season_btn.ForeColor = System.Drawing.Color.White
#End Region
        Panel4.Visible = True
        Panel5.Visible = False
        Panel6.Visible = False
        Panel4.Location = New Point(135, 129)

        stage = "a"
        Chart1.Series("Series").Points.Clear()
        resetall()
        Chart1.ChartAreas(0).AxisX.Title = "單位:日"
        If Today.Month().ToString = "1" Or Today.Month().ToString = "2" Or Today.Month().ToString = "3" Or Today.Month().ToString = "4" Or Today.Month().ToString = "5" Or Today.Month().ToString = "6" Or Today.Month().ToString = "7" Or Today.Month().ToString = "8" Or Today.Month().ToString = "9" Then
            SQL_DateReport(DateTime.Today.Year().ToString + "/0" + DateTime.Today.Month().ToString + "/")
            If Today.Day().ToString = "1" Or Today.Day().ToString = "2" Or Today.Day().ToString = "3" Or Today.Day().ToString = "4" Or Today.Day().ToString = "5" Or Today.Day().ToString = "6" Or Today.Day().ToString = "7" Or Today.Day().ToString = "8" Or Today.Day().ToString = "9" Then
                SQL_Rank(DateTime.Today.Year().ToString + "/0" + DateTime.Today.Month().ToString + "/0" + DateTime.Today.Day().ToString)
            Else
                SQL_Rank(DateTime.Today.Year().ToString + "/" + DateTime.Today.Month().ToString + "/" + DateTime.Today.Day().ToString)
            End If
        Else
            SQL_DateReport(DateTime.Today.Year().ToString + "/" + DateTime.Today.Month().ToString + "/")
        End If


        Label5.Text = DateTime.Today.Year().ToString + "年" + DateTime.Today.Month().ToString + "月" + DateTime.Today.Day().ToString + "日 銷售排行榜"
    End Sub

    Private Sub month_btn_Click(sender As Object, e As EventArgs) Handles month_btn.Click
#Region "Button設定"

        month_btn.BackColor = System.Drawing.Color.White
        date_btn.BackColor = System.Drawing.Color.SteelBlue
        season_btn.BackColor = System.Drawing.Color.SteelBlue
        month_btn.ForeColor = System.Drawing.Color.SteelBlue
        date_btn.ForeColor = System.Drawing.Color.White
        season_btn.ForeColor = System.Drawing.Color.White
#End Region
        my.Text = Format(Now, "yyyy")
        mm.Text = Format(Now, "MM")
        Panel5.Visible = True
        Panel4.Visible = False
        Panel6.Visible = False
        Panel5.Location = New Point(135, 129)
        stage = "b"
        Chart1.Series("Series").Points.Clear()
        resetall()
        Chart1.ChartAreas(0).AxisX.Title = "單位:月"
        SQL_MonthReport(DateTime.Today.Year().ToString + "/")
        If Today.Month().ToString = "1" Or Today.Month().ToString = "2" Or Today.Month().ToString = "3" Or Today.Month().ToString = "4" Or Today.Month().ToString = "5" Or Today.Month().ToString = "6" Or Today.Month().ToString = "7" Or Today.Month().ToString = "8" Or Today.Month().ToString = "9" Then
            SQL_Rank(DateTime.Today.Year().ToString + "/0" + DateTime.Today.Month().ToString)
        Else
            SQL_Rank(DateTime.Today.Year().ToString + "/" + DateTime.Today.Month().ToString)
        End If

        Label5.Text = DateTime.Today.Year().ToString + "年" + DateTime.Today.Month().ToString + "月 銷售排行榜"
    End Sub

    Private Sub season_btn_Click(sender As Object, e As EventArgs) Handles season_btn.Click
#Region "Button設定"
        season_btn.BackColor = System.Drawing.Color.White
        date_btn.BackColor = System.Drawing.Color.SteelBlue
        month_btn.BackColor = System.Drawing.Color.SteelBlue
        season_btn.ForeColor = System.Drawing.Color.SteelBlue
        date_btn.ForeColor = System.Drawing.Color.White
        month_btn.ForeColor = System.Drawing.Color.White
#End Region
        sy.Text = Format(Now, "yyyy")
        If Format(Now, "MM").ToString = "01" Or Format(Now, "MM") = "02" Or Format(Now, "MM") = "03" Then
            season.Text = 1
        ElseIf Format(Now, "MM").ToString = "04" Or Format(Now, "MM") = "05" Or Format(Now, "MM") = "06" Then
            season.Text = 2
        ElseIf Format(Now, "MM").ToString = "07" Or Format(Now, "MM") = "08" Or Format(Now, "MM") = "09" Then
            season.Text = 3
        ElseIf Format(Now, "MM").ToString = "10" Or Format(Now, "MM") = "11" Or Format(Now, "MM") = "12" Then
            season.Text = 4
        End If
        Panel6.Visible = True
        Panel5.Visible = False
        Panel4.Visible = False
        Panel6.Location = New Point(135, 129)
        stage = "c"
        Chart1.Series("Series").Points.Clear()
        resetall()
        Chart1.ChartAreas(0).AxisX.Title = "單位:季"
        SQL_SeasonReport(DateTime.Today.Year().ToString + "/")
        If DateTime.Today.Month().ToString = "1" Or DateTime.Today.Month().ToString = "2" Or DateTime.Today.Month().ToString = "3" Then
            SQL_sRank("date LIKE '" + DateTime.Today.Year().ToString + "/01/%' OR date LIKE '" + DateTime.Today.Year().ToString + "/02/%' OR date LIKE '" + DateTime.Today.Year().ToString + "/03/%'")
            Label5.Text = DateTime.Today.Year().ToString + "年" + "第1季 銷售排行榜"
        ElseIf DateTime.Today.Month().ToString = "4" Or DateTime.Today.Month().ToString = "5" Or DateTime.Today.Month().ToString = "6" Then
            SQL_sRank("date LIKE '" + DateTime.Today.Year().ToString + "/04/%' OR date LIKE '" + DateTime.Today.Year().ToString + "/05/%' OR date LIKE '" + DateTime.Today.Year().ToString + "/06/%'")
            Label5.Text = DateTime.Today.Year().ToString + "年" + "第2季 銷售排行榜"
        ElseIf DateTime.Today.Month().ToString = "7" Or DateTime.Today.Month().ToString = "8" Or DateTime.Today.Month().ToString = "9" Then
            SQL_sRank("date LIKE '" + DateTime.Today.Year().ToString + "/07/%' OR date LIKE '" + DateTime.Today.Year().ToString + "/08/%' OR date LIKE '" + DateTime.Today.Year().ToString + "/09/%'")
            Label5.Text = DateTime.Today.Year().ToString + "年" + "第3季 銷售排行榜"
        ElseIf DateTime.Today.Month().ToString = "10" Or DateTime.Today.Month().ToString = "11" Or DateTime.Today.Month().ToString = "12" Then
            SQL_sRank("date LIKE '" + DateTime.Today.Year().ToString + "/10/%' OR date LIKE '" + DateTime.Today.Year().ToString + "/11/%' OR date LIKE '" + DateTime.Today.Year().ToString + "/12/%'")
            Label5.Text = DateTime.Today.Year().ToString + "年" + "第4季 銷售排行榜"
        End If
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Chart1.Series("Series").Points.Clear()
    '    resetall()
    '    If stage = "a" Then
    '        DateSearch.Show()
    '    ElseIf stage = "b" Then
    '        MonthSearch.Show()
    '    ElseIf stage = "c" Then
    '        SeasonSearch.Show()
    '    End If
    'End Sub

    Private Sub report_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        date_btn.PerformClick()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Chart1.Series("Series").Points.Clear()
        resetall()
        Label5.Text = year.Text + "年" + month.Text + "月" + day.Text + "日 銷售排行榜"
        SQL_DateReport(year.Text + "/" + month.Text + "/")
        SQL_Rank(year.Text + "/" + month.Text + "/" + day.Text)
    End Sub

    Private Sub msearch_Click(sender As Object, e As EventArgs) Handles msearch.Click
        Chart1.Series("Series").Points.Clear()
        resetall()
        Label5.Text = my.Text + "年" + mm.Text + "月 銷售排行榜"
        SQL_MonthReport(my.Text + "/")
        SQL_Rank(my.Text + "/" + mm.Text)
    End Sub

    Private Sub ssearch_Click(sender As Object, e As EventArgs) Handles ssearch.Click
        Chart1.Series("Series").Points.Clear()
        resetall()
        If season.Text = "1" Then
            SQL_sRank("date LIKE '" + sy.Text + "/01/%' OR date LIKE '" + sy.Text + "/02/%' OR date LIKE '" + sy.Text + "/03/%'")
        ElseIf season.Text = "2" Then
            SQL_sRank("date LIKE '" + sy.Text + "/04/%' OR date LIKE '" + sy.Text + "/05/%' OR date LIKE '" + sy.Text + "/06/%'")
        ElseIf season.Text = "3" Then
            SQL_sRank("date LIKE '" + sy.Text + "/07/%' OR date LIKE '" + sy.Text + "/08/%' OR date LIKE '" + sy.Text + "/09/%'")
        ElseIf season.Text = "4" Then
            SQL_sRank("date LIKE '" + sy.Text + "/10/%' OR date LIKE '" + sy.Text + "/11/%' OR date LIKE '" + sy.Text + "/12/%'")
        End If
        Label5.Text = sy.Text + "年" + "第" + season.Text + "季 銷售排行榜"
        SQL_SeasonReport(sy.Text + "/")

    End Sub


End Class