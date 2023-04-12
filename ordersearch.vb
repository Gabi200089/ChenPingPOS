Imports MySql.Data.MySqlClient
' DataGridView1.Rows.Add(ds(n), price(n), num(n), sugar(n), ice(n), a1 + a2 + a3 + a4)
Public Class ordersearch
    Dim starttime As DateTime = DateTime.Now.Date
    Dim a As Integer = 0
    Dim DGVnum As Integer = 0
    Dim dishid As String
    Dim seldate As DateTime = DateTime.Now.Date
    Dim dtp As DateTimePicker
    Dim dates(1000) As String
    Dim dish(1000) As String
    Dim Orders_num(1000) As String
    Dim ps(1000) As String
    Dim add1(1000) As String
    Dim add2(1000) As String
    Dim add3(1000) As String
    Dim add4(1000) As String

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        dtp = DirectCast(sender, DateTimePicker)
        seldate = dtp.Value.Date
        ' Label1.Text = seldate.ToString

        If DateTime.Compare(seldate, starttime) > 0 Then
            'If a = 1 Then
            MsgBox("不能選擇未來的時間喔!")
            DateTimePicker1.Value = starttime
            ' End If
            'a = 1
        End If
        'If DateTimePicker1.Value < seldate Then
        '    If a = 1 Then
        '        MsgBox("不能選擇未來的時間喔!")
        '        DateTimePicker1.Value = DateTimePicker1.Value
        '    End If
        '    a = 1
        'End If

    End Sub

    Private Sub ordersearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = starttime
        If DateTimePicker1.Value.Month < 9 Then
            If DateTimePicker1.Value.Day < 9 Then

            Else

            End If
        End If


        'starttime = DateTimePicker1.Value.Date
        'Label1.Text = starttime.ToString
    End Sub

    'Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
    '    If RadioButton1.Checked = True Then
    '        ComboBox1.Enabled = True
    '    End If
    'End Sub
    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        If RadioButton1.Checked = True And ComboBox1.Enabled = False Then
            RadioButton1.Checked = True
            ComboBox1.Enabled = True
        ElseIf RadioButton1.Checked = True And ComboBox1.Enabled = True Then
            RadioButton1.Checked = False
            ComboBox1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SQL_dishid()
        For i = 0 To DGVnum - 1  '清空datagridview資料
            DataGridView1.Rows.RemoveAt(0)
        Next
        SQL()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        SQL_dishid()
        ' Button1.Text = dishid
    End Sub
    Private Function SQL()
        Dim ConString As New MySqlConnectionStringBuilder
        ConString.Database = "sa" '資料庫名稱為lifemanager
        ConString.Server = "127.0.0.1" '資料庫的IP位置
        ConString.UserID = "user" '資料庫使用者
        ConString.Password = "12345678" '資料庫使用者密碼
        ConString.SslMode = MySqlSslMode.None
        ConString.AllowZeroDateTime = True
        Dim time As String = ""
        Dim QueryString As String
        '建立查詢字串

        If DateTimePicker1.Value.Month < 9 Then
            If DateTimePicker1.Value.Day < 9 Then
                time = DateTimePicker1.Value.Year.ToString + "/0" + DateTimePicker1.Value.Month.ToString + "/0" + DateTimePicker1.Value.Day.ToString
            Else
                time = DateTimePicker1.Value.Year.ToString + "/0" + DateTimePicker1.Value.Month.ToString + "/" + DateTimePicker1.Value.Day.ToString
            End If
        End If

        If RadioButton1.Checked = True Then
            'If DateTimePicker1.Value.Month.
            QueryString = "SELECT * From orders where (date like '%" & time & "%')and(dish_id = '" & dishid & "');"
        ElseIf RadioButton1.Checked = False Then
            QueryString = "SELECT * From orders where (date like '%" & time & "%');"
        End If


        '"SELECT * From mything where userid='" & userid & "';"

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
                ' DataGridView1.DataSource = BindingSource1

                Dim dataReader As MySqlDataReader = MyCommand.ExecuteReader()
                DGVnum = 0
                Do While dataReader.Read()
                    dish(DGVnum) = change_name(dataReader(2).ToString)
                    dates(DGVnum) = dataReader(3).ToString
                    Orders_num(DGVnum) = dataReader(4).ToString
                    ps(DGVnum) = dataReader(5).ToString
                    add1(DGVnum) = change_add(dataReader(6).ToString)
                    add2(DGVnum) = change_add(dataReader(7).ToString)
                    add3(DGVnum) = change_add(dataReader(8).ToString)
                    add4(DGVnum) = change_add(dataReader(9).ToString)
                    DataGridView1.Rows.Add(dish(DGVnum), dates(DGVnum), Orders_num(DGVnum), ps(DGVnum), add1(DGVnum), add2(DGVnum), add3(DGVnum), add4(DGVnum))
                    DGVnum = DGVnum + 1
                Loop
                dataReader.Close()

                'MsgBox(i)

            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                Connection.Close()
            End Try

        End Using
    End Function
    Private Function SQL_dishid()
        Dim ConString As New MySqlConnectionStringBuilder
        ConString.Database = "sa" '資料庫名稱為lifemanager
        ConString.Server = "127.0.0.1" '資料庫的IP位置
        ConString.UserID = "user" '資料庫使用者
        ConString.Password = "12345678" '資料庫使用者密碼
        ConString.SslMode = MySqlSslMode.None
        ConString.AllowZeroDateTime = True
        '建立查詢字串
        Dim QueryString As String = "SELECT dish_id FROM dish WHERE dish_name='" & ComboBox1.Text & "';"
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
                'Adapter.Fill(DataSet1.Tables(0)) 關起來是因為materialid在查詢後會再fatagridvoew重複顯示

                '如果程式操作期間有對DataSet1中的任何資料做修改且需要更新資料庫，則可利用 update 方法把資料送回MySql Server
                'Adapter.Update(DataSet1)

                '設定繫結資料來源
                BindingSource1.DataSource = DataSet1
                '設定有繫結作用的資料來源中的哪個表格
                BindingSource1.DataMember = DataSet1.Tables(0).ToString
                'DataGridView1.DataSource = BindingSource1

                Dim dataReader As MySqlDataReader = MyCommand.ExecuteReader()
                Do While dataReader.Read()
                    dishid = dataReader(0).ToString
                    'ComboBox1.Items.Add(dataReader(0))
                Loop
                dataReader.Close()

            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                Connection.Close()
            End Try
        End Using
    End Function
#Region "add"
    Private Function change_add(ByVal add As String) As String
        Dim addname As String
        Select Case add
            Case 1
                addname = "花生 "
            Case 2
                addname = "雪蓮子 "
            Case 3
                addname = "紅豆 "
            Case 4
                addname = "綠豆 "
            Case 5
                addname = "薏仁 "
            Case 6
                addname = "粉圓 "
            Case 7
                addname = "芋圓 "
            Case 8
                addname = "地瓜圓 "
            Case 9
                addname = "黑糖粉粿 "
        End Select
        Return addname
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
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub
End Class