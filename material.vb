Imports MySql.Data.MySqlClient
Public Class material
    Dim ConString As New MySqlConnectionStringBuilder
    Dim x As String
    Dim xd As String '資料庫撈取半成品的id以及名稱
    Dim dx As String '資料庫撈取半成品的存量
    Dim materialid As String
    Dim name, weight, num As String
    Dim selected_name As String
    Dim modify_num, modify_name, modify_gram As String
    Dim select_num As Integer = 1
    Dim maxid As Integer     '讀取最大值
    Dim count As Integer
    ' Dim selsectnum As Integer = 1 '鍵盤框框預設 

    Dim lab(10000) As Label   '放半成品的id與名稱
    Dim lab2(10000) As Label  '放半成品的存量
    Dim but(10000) As Button  '動態生成修改的按鈕
    Dim but2(10000) As Button '動態生成刪除的按鈕
    Dim xx           '存貨label的x
    Dim yy = -25     '存貨label的y(負越大越往上-例如-140變-150)
    Dim xxx          'id與名字label的x
    Dim yyy = -100   'id與名字label的y(負越大越往上)
    Dim aa           '修改按鈕的x
    Dim aaa          '刪除按鈕的x
    Dim bb = 20      '修改按鈕的y(負越大越往上)
    Dim bbb = 20     '刪除按鈕的y
    Dim a As Integer '看要製造幾個動態物件
    Dim all3(10000)
    Dim all(10000)   '存放半成品id與名稱
    Dim all2(10000)  '存放半成品的存量(字串型態)
    Dim bg(10000)    '存放半成品的存量(數字型態，才能做運算判斷)
    Dim butIndex As Int32   '取得我點擊的修改按鈕是哪個id的
    Dim but2Index As Int32  '取得我點擊的刪除按鈕是哪個id的

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        time.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
        all3(1) = 1
        SQL(x)
        SQL_materialid()
        Panel1.Visible = False
        Panel2.Visible = False
        For a = 1 To count
            Dynamic(a) '動態生成物件的函數呼叫
        Next
    End Sub

#Region "動態生成物件"
    Private Function Dynamic(a)
        '取得存量至動態label
        xd = "SELECT material_id,material_name,material_price,material_gram FROM material WHERE  material_id = '" & all3(a) & "';"
        '動態生成修改的按鈕

        but(a) = New Button
        With but(a)
            .Width = 100
            .Height = 50
            If (a Mod 5 = 1) Then
                aa = -100
                aa = aa + 150
                .Left = aa
                bb = bb + 202
                .Top = bb
            Else
                .Left = aa + 250
                .Top = bb
            End If
            aa = .Left
            bb = .Top
            .Text = ""
            .TextAlign = ContentAlignment.MiddleCenter
            .Name = "btn_" & a
        End With
        AddHandler but(a).Click, AddressOf but_Click
        but(a).BackgroundImage = My.Resources.revise
        but(a).BackgroundImageLayout = ImageLayout.Stretch
        but(a).FlatStyle = FlatStyle.Flat
        but(a).BackColor = BackColor.Transparent
        but(a).FlatAppearance.BorderSize = 0
        Me.Controls.Add(but(a))

        '動態生成刪除的按鈕
        but2(a) = New Button
        With but2(a)
            .Width = 100
            .Height = 49
            If (a Mod 5 = 1) Then
                aaa = -50
                aaa = aaa + 200
                .Left = aaa
                bbb = bbb + 202
                .Top = bbb
            Else
                .Left = aaa + 250
                .Top = bbb
            End If
            aaa = .Left
            bbb = .Top
            .Text = ""
            .TextAlign = ContentAlignment.MiddleCenter
            .Name = "btn2_" & a
        End With
        AddHandler but2(a).Click, AddressOf but2_Click
        but2(a).BackgroundImage = My.Resources.delete
        but2(a).BackgroundImageLayout = ImageLayout.Stretch
        but2(a).FlatStyle = FlatStyle.Flat
        but2(a).FlatAppearance.BorderSize = 0
        but2(a).BackColor = BackColor.Transparent
        Me.Controls.Add(but2(a))

        '取得數量至動態label
        GETSQL(xd)
        'lab3(a) = New Label
        'With lab3(a)
        '    .Width = 140
        '    .Height = 90
        '    If (a Mod 5 = 1) Then
        '        xxxx = -50
        '        xxxx = xxxx + 130
        '        .Left = xxxx
        '        yyyy = yyyy + 180
        '        .Top = yyyy
        '    Else
        '        .Left = xxxx + 250
        '        .Top = yyyy
        '    End If
        '    xxxx = .Left
        '    yyyy = .Top
        '    .Text = all(a)
        '    .TextAlign = ContentAlignment.TopLeft
        'End With
        'lab3(a).TextAlign = ContentAlignment.MiddleCenter
        'lab3(a).BackColor = Color.Transparent
        'lab3(a).Font = New Font("微軟正黑體", 16)
        'Me.Controls.Add(lab3(a))
        '動態產生ID與名稱的label
        lab2(a) = New Label
        With lab2(a)
            .Width = 140
            .Height = 60
            If (a Mod 5 = 1) Then
                xx = -50
                xx = xx + 130
                .Left = xx
                yy = yy + 195
                .Top = yy
            Else
                .Left = xx + 250
                .Top = yy
            End If
            xx = .Left
            yy = .Top
            .Text = all2(a)
            .TextAlign = ContentAlignment.TopLeft
        End With
        lab2(a).TextAlign = ContentAlignment.MiddleCenter
        lab2(a).BackColor = Color.Transparent
        lab2(a).Font = New Font("微軟正黑體", 12)
        Me.Controls.Add(lab2(a))

        '取得id與名稱至動態label
        GETSQL(xd)
        '動態產生重量及成本的label
        lab(a) = New Label
        With lab(a)
            .Width = 200
            .Height = 140
            If (a Mod 5 = 1) Then
                xxx = -100
                xxx = xxx + 150
                .Left = xxx
                yyy = yyy + 195
                .Top = yyy
            Else
                .Left = xxx + 250
                .Top = yyy
            End If
            xxx = .Left
            yyy = .Top
            .Text = all(a)
            .TextAlign = ContentAlignment.TopCenter
        End With
        lab(a).Font = New Font("微軟正黑體", 15, FontStyle.Bold)
        lab(a).BackgroundImageLayout = ImageLayout.Stretch
        lab(a).FlatStyle = FlatStyle.Flat
        'lab2(a).FlatAppearance.BorderSize = 0
        Me.Controls.Add(lab(a))


        '根據半成品存量變更顏色
        If (CInt(bg(a))) >= 200 Then
            lab2(a).BackgroundImage = My.Resources.green_box2
            'lab3(a).BackgroundImage = My.Resources.green_box2
            lab(a).BackgroundImage = My.Resources.green_box
        Else
            lab2(a).BackgroundImage = My.Resources.red_box2
            lab(a).BackgroundImage = My.Resources.red_box
            ' lab3(a).BackgroundImage = My.Resources.red_box2
        End If
    End Function
#End Region
#Region "點擊修改按鈕"
    '點擊修改按鈕
    Private Sub but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        butIndex = Val(CType(sender, Button).Name.Split("_")(1))
        Panel1.Visible = True
        Panel2.Visible = False
        If (count < 10) Then
            TextBox8.Text = Trim(all(butIndex).Substring(6)) 'panel上的修改食材名稱的框框自動把字匯入
        Else
            TextBox8.Text = Trim(all(butIndex).Substring(9)) 'panel上的修改食材名稱的框框自動把字匯入
        End If
        selected_name = TextBox8.Text
    End Sub
#End Region
#Region "點擊刪除按鈕"
    '點擊刪除按鈕
    Private Sub but2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim answer
        Dim i As Integer

        butIndex = Val(CType(sender, Button).Name.Split("_")(1))
        selected_name = Trim(all(butIndex).Substring(7)) 'panel上的修改食材名稱的框框自動把字匯入
        answer = MsgBox("確定要刪除嗎？", MsgBoxStyle.YesNo, "刪除")
        If answer = MsgBoxResult.Yes Then
            SQL_delete()
            SQL(x)
            For a = 1 To count
                Me.Controls.Remove(lab(a))
                Me.Controls.Remove(lab2(a))
                Me.Controls.Remove(but(a))
                Me.Controls.Remove(but2(a))
            Next

            count = 0
            yy = -25
            yyy = -100
            bb = 20
            bbb = 20
            all3(1) = 1
            SQL(x)
            SQL_materialid()
            Panel1.Visible = False
            Panel2.Visible = False
            For a = 1 To count
                Dynamic(a) '動態生成物件的函數呼叫
            Next
        End If
    End Sub

#End Region
#Region "建立連線"
    Sub connect()
        '建立連線字串
        ConString.Database = "sa"
        ConString.Server = "127.0.0.1"
        ConString.UserID = "root"
        'ConString.Password = "12345678"
        ConString.SslMode = MySqlSslMode.None
    End Sub
#End Region
#Region "讀取個別資料"
    Private Function GETSQL(xd)
        'maxid = 1
        Call connect()
        '建立查詢字串
        Dim QueryString As String = xd
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

                '設定繫結資料來源
                ' BindingSource1.DataSource = DataSet1
                '設定有繫結作用的資料來源中的哪個表格
                'BindingSource1.DataMember = DataSet1.Tables(0).ToString

                Dim dataReader As MySqlDataReader = MyCommand.ExecuteReader()
                Do While dataReader.Read()

                    all(a) = vbCrLf & vbCrLf & dataReader(0).ToString & "." & "   " & dataReader(1).ToString
                    all2(a) = "剩餘重量:" & dataReader(3).ToString & "公克" & vbCrLf & "進貨成本:" & dataReader(2).ToString & "元"
                    bg(a) = CInt(Trim(dataReader(3)))
                    count = count + 1
                Loop
                dataReader.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connection.Close()
            End Try
        End Using
    End Function
#End Region
#Region "讀取datagridview資料"
    Private Function SQL(x)
        Dim k As Integer = 1
        Call connect()
        '建立查詢字串
        Dim QueryString As String = "SELECT * From material;"
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
                Dim dataReader As MySqlDataReader = MyCommand.ExecuteReader()
                Do While dataReader.Read()
                    all3(k) = dataReader(0)
                    k = k + 1
                Loop
                dataReader.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connection.Close()
            End Try
        End Using
    End Function
#End Region
#Region "SQL_materialid()"
    Private Function SQL_materialid()
        Call connect()
        '建立查詢字串
        Dim QueryString As String = "SELECT material_id FROM material;"
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
                    materialid = dataReader(0).ToString
                    'ComboBox1.Items.Add(dataReader(0))
                    count = count + 1
                Loop
                dataReader.Close()
                materialid = materialid + 1
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connection.Close()
            End Try
        End Using
    End Function

    'panel上的修改按鈕
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim i As Integer
        modify_name = TextBox8.Text
        modify_num = TextBox9.Text
        modify_gram = TextBox1.Text
        SQL_modify()
        SQL(x)

        TextBox1.Text = ""
        TextBox9.Text = ""
        Panel1.Visible = False

        a = butIndex
        xd = "SELECT material_id,material_name,material_price,material_gram FROM material WHERE  material_id = " & a & ";"
        GETSQL(xd)
        lab2(butIndex).Text = all2(butIndex)

        '根據半成品存量變更顏色
        If (CInt(bg(a))) >= 200 Then
            lab2(a).BackgroundImage = My.Resources.green_box2
            'lab3(a).BackgroundImage = My.Resources.green_box2
            lab(a).BackgroundImage = My.Resources.green_box
        Else
            lab2(a).BackgroundImage = My.Resources.red_box2
            lab(a).BackgroundImage = My.Resources.red_box
            ' lab3(a).BackgroundImage = My.Resources.red_box2
        End If
    End Sub

    'panel上的刪除按鈕
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Panel1.Visible = False
    End Sub

    'panel上的新增
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        name = TextBox10.Text
        num = TextBox3.Text
        weight = TextBox2.Text
        SQL_new()
        For a = 1 To count
            Me.Controls.Remove(lab(a))
            Me.Controls.Remove(lab2(a))
            Me.Controls.Remove(but(a))
            Me.Controls.Remove(but2(a))
        Next

        count = 0
        yy = -25
        yyy = -100
        bb = 20
        bbb = 20
        all3(1) = 1
        SQL(x)
        SQL_materialid()
        Panel1.Visible = False
        Panel2.Visible = False
        For a = 1 To count
            Dynamic(a) '動態生成物件的函數呼叫
        Next

        TextBox11.Text = ""
        TextBox10.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Panel2.Visible = False
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Panel2.Visible = False
        TextBox10.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox10.Text = ""
        TextBox3.Text = ""
    End Sub

#Region "數字鍵盤"
    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click
        If select_num = 2 Then
            TextBox1.Text = TextBox1.Text + Button11.Text
        ElseIf select_num = 3 Then
            TextBox9.Text = TextBox9.Text + Button11.Text
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If select_num = 2 Then
            TextBox1.Text = TextBox1.Text + Button1.Text
        ElseIf select_num = 3 Then
            TextBox9.Text = TextBox9.Text + Button1.Text
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If select_num = 2 Then
            TextBox1.Text = TextBox1.Text + Button3.Text
        ElseIf select_num = 3 Then
            TextBox9.Text = TextBox9.Text + Button3.Text
        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If select_num = 2 Then
            TextBox1.Text = TextBox1.Text + Button4.Text
        ElseIf select_num = 3 Then
            TextBox9.Text = TextBox9.Text + Button4.Text
        End If
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        If select_num = 2 Then
            TextBox1.Text = TextBox1.Text + Button5.Text
        ElseIf select_num = 3 Then
            TextBox9.Text = TextBox9.Text + Button5.Text
        End If
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        If select_num = 2 Then
            TextBox1.Text = TextBox1.Text + Button6.Text
        ElseIf select_num = 3 Then
            TextBox9.Text = TextBox9.Text + Button6.Text
        End If
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        If select_num = 2 Then
            TextBox1.Text = TextBox1.Text + Button7.Text
        ElseIf select_num = 3 Then
            TextBox9.Text = TextBox9.Text + Button7.Text
        End If
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        If select_num = 2 Then
            TextBox1.Text = TextBox1.Text + Button8.Text
        ElseIf select_num = 3 Then
            TextBox9.Text = TextBox9.Text + Button8.Text
        End If
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        If select_num = 2 Then
            TextBox1.Text = TextBox1.Text + Button9.Text
        ElseIf select_num = 3 Then
            TextBox9.Text = TextBox9.Text + Button9.Text
        End If
    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        If select_num = 2 Then
            TextBox1.Text = TextBox1.Text + Button10.Text
        ElseIf select_num = 3 Then
            TextBox9.Text = TextBox9.Text + Button10.Text
        End If
    End Sub

    Private Sub TextBox8_OnClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox8.Click
        select_num = 1
    End Sub

    Private Sub TextBox1_OnClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Click
        select_num = 2
    End Sub

    Private Sub TextBox9_OnClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox9.Click
        select_num = 3
    End Sub

#Region "點擊新增按鈕"
    '點擊新增按鈕
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Panel2.Visible = True
        Panel1.Visible = False
        TextBox11.Text = materialid
    End Sub
    Private Sub Button19_MouseHover(sender As Object, e As EventArgs) Handles Button19.MouseHover
        Button19.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral
        Button19.ForeColor = System.Drawing.Color.LightCoral
    End Sub

    Private Sub Button19_MouseLeave(sender As Object, e As EventArgs) Handles Button19.MouseLeave
        Button19.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose
        Button19.ForeColor = System.Drawing.Color.MistyRose
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = ""
        TextBox3.Text = orderpage.total
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Close()
    End Sub


#End Region

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click
        If select_num = 2 Then
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
        ElseIf select_num = 3 Then
            TextBox9.Text = TextBox9.Text.Substring(0, TextBox9.Text.Length - 1)
        End If

    End Sub

#End Region
#End Region
#Region "SQL_modify()"
    Private Function SQL_modify()
        Call connect()
        '建立查詢字串
        Dim QueryString As String = "SELECT * FROM material WHERE material_name='" & selected_name & "';"
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

                'Dim qs1 As String = "insert into orders(orders_id)values('" & num & "');"
                Dim qs1 As String = "update material set material_price='" & modify_num & "',material_gram='" & modify_gram & "',material_name='" & modify_name & "' WHERE material_name='" & selected_name & "';"
                'INSERT INTO `mything` (`userid`, `thingid`, `tname`, `amount`, `num`, `kind`, `place`, `buyingdate`, `endingdate`, `note`, `state`) VALUES ('', NULL, '', '', '', '', '', '', '', '', '');
                Dim cmd As MySqlCommand = New MySqlCommand(qs1, Connection)
                cmd.ExecuteNonQuery()

                Adapter.Fill(DataSet1.Tables(0))

                '如果程式操作期間有對DataSet1中的任何資料做修改且需要更新資料庫，則可利用 update 方法把資料送回MySql Server
                'Adapter.Update(DataSet1)

                '設定繫結資料來源
                BindingSource1.DataSource = DataSet1
                '設定有繫結作用的資料來源中的哪個表格
                BindingSource1.DataMember = DataSet1.Tables(0).ToString
                'DataGridView1.DataSource = BindingSource1

                Dim dataReader As MySqlDataReader = MyCommand.ExecuteReader()

            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                Connection.Close()
            End Try
        End Using
    End Function
#End Region
#Region "SQL_new()"
    Private Function SQL_new()
        Call connect()
        '建立查詢字串
        Dim QueryString As String = "SELECT * FROM material;"
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

                'Dim qs1 As String = "insert into orders(orders_id)values('" & num & "');"
                Dim qs1 As String = "insert into material(material_id,material_name,material_price,material_gram)values('" & materialid & "','" & name & "','" & num & "','" & weight & "');"
                'INSERT INTO `mything` (`userid`, `thingid`, `tname`, `amount`, `num`, `kind`, `place`, `buyingdate`, `endingdate`, `note`, `state`) VALUES ('', NULL, '', '', '', '', '', '', '', '', '');
                Dim cmd As MySqlCommand = New MySqlCommand(qs1, Connection)
                cmd.ExecuteNonQuery()

                Adapter.Fill(DataSet1.Tables(0))

                '如果程式操作期間有對DataSet1中的任何資料做修改且需要更新資料庫，則可利用 update 方法把資料送回MySql Server
                'Adapter.Update(DataSet1)

                '設定繫結資料來源
                BindingSource1.DataSource = DataSet1
                '設定有繫結作用的資料來源中的哪個表格
                BindingSource1.DataMember = DataSet1.Tables(0).ToString
                'DataGridView1.DataSource = BindingSource1

                Dim dataReader As MySqlDataReader = MyCommand.ExecuteReader()

            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                Connection.Close()
            End Try
        End Using
    End Function
#End Region
#Region "SQL_delete()"
    Private Function SQL_delete()
        Call connect()
        '建立查詢字串
        Dim QueryString As String = "SELECT * FROM material WHERE material_name='" & selected_name & "';"
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

                'Dim qs1 As String = "insert into orders(orders_id)values('" & num & "');"
                Dim qs1 As String = "delete from material WHERE material_name='" & selected_name & "';"
                'INSERT INTO `mything` (`userid`, `thingid`, `tname`, `amount`, `num`, `kind`, `place`, `buyingdate`, `endingdate`, `note`, `state`) VALUES ('', NULL, '', '', '', '', '', '', '', '', '');
                Dim cmd As MySqlCommand = New MySqlCommand(qs1, Connection)
                cmd.ExecuteNonQuery()

                Adapter.Fill(DataSet1.Tables(0))

                '如果程式操作期間有對DataSet1中的任何資料做修改且需要更新資料庫，則可利用 update 方法把資料送回MySql Server
                'Adapter.Update(DataSet1)

                '設定繫結資料來源
                BindingSource1.DataSource = DataSet1
                '設定有繫結作用的資料來源中的哪個表格
                BindingSource1.DataMember = DataSet1.Tables(0).ToString
                'DataGridView1.DataSource = BindingSource1

                Dim dataReader As MySqlDataReader = MyCommand.ExecuteReader()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connection.Close()
            End Try
        End Using
    End Function
#End Region
End Class