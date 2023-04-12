Imports MySql.Data.MySqlClient
Public Class orderpage

    Dim x As String
    Dim ds(20) As String
    Dim dishid(20) As String
    Dim sugar(20) As String
    Dim ice(20) As String
    Dim price(20) As Integer
    Dim num(20) As Integer
    Dim ConString As New MySqlConnectionStringBuilder
    Dim orderid As Integer
    Dim orderidNow As Integer
    Public total As Integer = 0
    Public a As Integer = 0
    Dim ordertime As String
    Public add1(20), add2(20), add3(20), add4(20) As Integer
    Public n As Integer = 0
    Public done As Boolean = False
    Sub connect()
        '建立連線字串
        ConString.Database = "sa"
        ConString.Server = "127.0.0.1"
        ConString.UserID = "root"
        'ConString.Password = "12345678"
        ConString.SslMode = MySqlSslMode.None
    End Sub
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQL_orderid()
        orderidNow = orderid + 1
        time.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
        number.Text = "單號:" + (orderidNow).ToString
        For i = 0 To 20
            num(i) = 1
            sugar(i) = "(預設)"
            ice(i) = "(預設)"
            add1(i) = 0
            add2(i) = 0
            add3(i) = 0
            add4(i) = 0
        Next
    End Sub
    Sub buttonset()
        CaramelBeanCurd.BackColor = System.Drawing.Color.Azure
        Button1.BackColor = System.Drawing.Color.Azure
        Button2.BackColor = System.Drawing.Color.Azure
        SoyMilkBeanCurd.BackColor = System.Drawing.Color.Azure
        Button6.BackColor = System.Drawing.Color.Azure
        Button7.BackColor = System.Drawing.Color.Azure
        AlmondBeanCurd.BackColor = System.Drawing.Color.Azure
        Button8.BackColor = System.Drawing.Color.Azure
        Button9.BackColor = System.Drawing.Color.Azure
        SesameBeanCurd.BackColor = System.Drawing.Color.Azure
        Button10.BackColor = System.Drawing.Color.Azure
        Button11.BackColor = System.Drawing.Color.Azure
        VanillaBeanCurd.BackColor = System.Drawing.Color.Azure
        Button12.BackColor = System.Drawing.Color.Azure
        Button13.BackColor = System.Drawing.Color.Azure
        SoyMilk_cup.BackColor = System.Drawing.Color.Azure
        SoyMilk_bottle.BackColor = System.Drawing.Color.Azure
        AlmondTea_cup.BackColor = System.Drawing.Color.Azure
        AlmondTea_bottle.BackColor = System.Drawing.Color.Azure
        Sesame_cup.BackColor = System.Drawing.Color.Azure
        Sesame_bottle.BackColor = System.Drawing.Color.Azure
        BrownSugarIce.BackColor = System.Drawing.Color.Azure
        Button3.BackColor = System.Drawing.Color.Azure
        PineappleIce.BackColor = System.Drawing.Color.Azure
        Button4.BackColor = System.Drawing.Color.Azure
    End Sub
#Region "品項按鈕"
    Private Sub CaramelBeanCurd_Click(sender As Object, e As EventArgs) Handles CaramelBeanCurd.Click
        '焦糖豆花原味按鈕
        buttonset()
        CaramelBeanCurd.BackColor = System.Drawing.Color.LightBlue
        x = "SELECT dish_name, dish_price FROM dish WHERE dish_id='A0';"
        dishid(n) = "A0"
    End Sub

    Private Sub SoyMilkBeanCurd_Click(sender As Object, e As EventArgs) Handles SoyMilkBeanCurd.Click
        '豆漿豆花原味按鈕
        buttonset()
        SoyMilkBeanCurd.BackColor = System.Drawing.Color.LightBlue
        x = "SELECT dish_name, dish_price FROM dish WHERE dish_id='B0';"
        dishid(n) = "B0"
    End Sub

    Private Sub AlmondBeanCurd_Click(sender As Object, e As EventArgs) Handles AlmondBeanCurd.Click
        buttonset()
        AlmondBeanCurd.BackColor = System.Drawing.Color.LightBlue
        x = "SELECT dish_name, dish_price FROM dish WHERE dish_id='C0';"
        dishid(n) = "C0"
    End Sub

    Private Sub SesameBeanCurd_Click(sender As Object, e As EventArgs) Handles SesameBeanCurd.Click
        '芝麻豆花原味按鈕
        buttonset()
        SesameBeanCurd.BackColor = System.Drawing.Color.LightBlue
        x = "SELECT dish_name, dish_price FROM dish WHERE dish_id='D0';"
        dishid(n) = "D0"
    End Sub

    Private Sub VanillaBeanCurd_Click(sender As Object, e As EventArgs) Handles VanillaBeanCurd.Click
        '香草豆花原味按鈕
        buttonset()
        VanillaBeanCurd.BackColor = System.Drawing.Color.LightBlue
        x = "SELECT dish_name, dish_price FROM dish WHERE dish_id='E0';"
        dishid(n) = "E0"
    End Sub

    Private Sub BrownSugarIce_Click(sender As Object, e As EventArgs) Handles BrownSugarIce.Click
        '黑糖刨冰
        buttonset()
        BrownSugarIce.BackColor = System.Drawing.Color.LightBlue
        a = 4
        Ingredient.Show()
        x = "SELECT dish_name, dish_price FROM dish WHERE dish_id='ice0';"
        dishid(n) = "ice0"
    End Sub

    Private Sub PineappleIce_Click(sender As Object, e As EventArgs) Handles PineappleIce.Click
        '鳳梨刨冰
        buttonset()
        PineappleIce.BackColor = System.Drawing.Color.LightBlue
        x = "SELECT dish_name, dish_price FROM dish WHERE dish_id='ice2';"
        dishid(n) = "ice2"
        a = 4
        Ingredient.Show()
    End Sub
#End Region
#Region "SQL_write(i)"
    Private Function SQL_write(i)
        Call connect()
        '建立查詢字串
        Dim QueryString As String = "SELECT * FROM orders;"
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
                Dim qs1 As String = "insert into orders(orders_id,dish_id,date,oders_num,ps,add1,add2,add3,add4)values('" & orderidNow & "','" & dishid(i) & "','" & ordertime & "','" & num(i) & "','" & sugar(i) & " + " & ice(i) & "','" & add1(i) & "','" & add2(i) & "','" & add3(i) & "','" & add4(i) & "');"
                'INSERT INTO `mything` (`userid`, `thingid`, `tname`, `amount`, `price`, `kind`, `place`, `buyingdate`, `endingdate`, `note`, `state`) VALUES ('', NULL, '', '', '', '', '', '', '', '', '');
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
#Region "SQL_minus(i)"
    Private Function SQL_minus(n)
        Call connect()
        '建立查詢字串
        Dim QueryString As String = "SELECT * FROM prepared;"
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
                Dim qs1 As String = "update `prepared` set `prepared_num` =   IF(`prepared_num`<1, 0, `prepared_num`-1) WHERE `prepared_id` = '" & n & "';"
                'INSERT INTO `mything` (`userid`, `thingid`, `tname`, `amount`, `price`, `kind`, `place`, `buyingdate`, `endingdate`, `note`, `state`) VALUES ('', NULL, '', '', '', '', '', '', '', '', '');
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
#Region "SQL(X)"
    Private Function SQL(x)
        Call connect()
        '建立查詢字串
        Dim QueryString As String = x
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
                    ds(n) = dataReader(0).ToString
                    price(n) = dataReader(1).ToString
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
#End Region
#Region "SQL_orderid()"
    Private Function SQL_orderid()
        Dim num As Integer
        Call connect()
        '建立查詢字串
        Dim QueryString As String = "SELECT orders_id FROM orders;"
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
                    orderid = dataReader(0).ToString
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
#End Region

    Private Sub AddDish_Click(sender As Object, e As EventArgs) Handles AddDish.Click
        Dim a1, a2, a3, a4 As String
        If x <> "" Then
            SQL(x)
        Else
            MsgBox("尚未選取品項喔!",, "警告")
        End If

#Region "add1~4轉文字"
        Select Case add1(n)
            Case 1
                a1 = "花生 "
            Case 2
                a1 = "雪蓮子 "
            Case 3
                a1 = "紅豆 "
            Case 4
                a1 = "綠豆 "
            Case 5
                a1 = "薏仁 "
            Case 6
                a1 = "粉圓 "
            Case 7
                a1 = "芋圓 "
            Case 8
                a1 = "地瓜圓 "
            Case 9
                a1 = "黑糖粉粿 "
        End Select
        Select Case add2(n)
            Case 1
                a2 = "花生 "
            Case 2
                a2 = "雪蓮子 "
            Case 3
                a2 = "紅豆 "
            Case 4
                a2 = "綠豆 "
            Case 5
                a2 = "薏仁 "
            Case 6
                a2 = "粉圓 "
            Case 7
                a2 = "芋圓 "
            Case 8
                a2 = "地瓜圓 "
            Case 9
                a2 = "黑糖粉粿 "
        End Select
        Select Case add3(n)
            Case 1
                a3 = "花生 "
            Case 2
                a3 = "雪蓮子 "
            Case 3
                a3 = "紅豆 "
            Case 4
                a3 = "綠豆 "
            Case 5
                a3 = "薏仁 "
            Case 6
                a3 = "粉圓 "
            Case 7
                a3 = "芋圓 "
            Case 8
                a3 = "地瓜圓 "
            Case 9
                a3 = "黑糖粉粿 "
        End Select
        Select Case add4(n)
            Case 1
                a4 = "花生 "
            Case 2
                a4 = "雪蓮子 "
            Case 3
                a4 = "紅豆 "
            Case 4
                a4 = "綠豆 "
            Case 5
                a4 = "薏仁 "
            Case 6
                a4 = "粉圓 "
            Case 7
                a4 = "芋圓 "
            Case 8
                a4 = "地瓜圓 "
            Case 9
                a4 = "黑糖粉粿 "
        End Select
#End Region
        total = total + price(n) * CInt(order_num.Text)
        Sum.Text = "總金額" + total.ToString + "元"

        If ds(n) <> "" Then
            DataGridView1.Rows.Add(ds(n), price(n) * CInt(order_num.Text), num(n), sugar(n), ice(n), a1 + a2 + a3 + a4)
        End If

        n = n + 1

        ds(n) = Nothing
        price(n) = Nothing
        ComboBox1.Text = Nothing
        ComboBox2.Text = Nothing
        order_num.Text = 1
        buttonset()
        x = ""
        'sugar(n) = "(預設)"
        'ice(n) = "(預設)"
        'num(n) = 1

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            sugar(n) = "(預設)"
        ElseIf ComboBox1.SelectedIndex = 1 Then
            sugar(n) = "全糖"
        ElseIf ComboBox1.SelectedIndex = 2 Then
            sugar(n) = "半糖"
        ElseIf ComboBox1.SelectedIndex = 3 Then
            sugar(n) = "微糖"
        ElseIf ComboBox1.SelectedIndex = 4 Then
            sugar(n) = "無糖"
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedIndex = 0 Then
            ice(n) = "(預設)"
        ElseIf ComboBox2.SelectedIndex = 1 Then
            ice(n) = "正常冰"
        ElseIf ComboBox2.SelectedIndex = 2 Then
            ice(n) = "少冰"
        ElseIf ComboBox2.SelectedIndex = 3 Then
            ice(n) = "微冰"
        ElseIf ComboBox2.SelectedIndex = 4 Then
            ice(n) = "去冰"
        End If
    End Sub
#Region "品項按鈕2"
    Private Sub SoyMilk_cup_Click(sender As Object, e As EventArgs) Handles SoyMilk_cup.Click
        '豆漿(杯裝)
        buttonset()
        SoyMilk_cup.BackColor = System.Drawing.Color.LightBlue
        x = "SELECT dish_name, dish_price FROM dish WHERE dish_id='dA500';"
        dishid(n) = "dA500"
    End Sub

    Private Sub SoyMilk_bottle_Click(sender As Object, e As EventArgs) Handles SoyMilk_bottle.Click
        '豆漿(瓶裝)
        buttonset()
        SoyMilk_bottle.BackColor = System.Drawing.Color.LightBlue
        x = "SELECT dish_name, dish_price FROM dish WHERE dish_id='dA1000';"
        dishid(n) = "dA1000"
    End Sub

    Private Sub AlmondTea_cup_Click(sender As Object, e As EventArgs) Handles AlmondTea_cup.Click
        '杏仁茶(杯裝)
        buttonset()
        AlmondTea_cup.BackColor = System.Drawing.Color.LightBlue
        x = "SELECT dish_name, dish_price FROM dish WHERE dish_id='dB500';"
        dishid(n) = "dB500"
    End Sub

    Private Sub AlmondTea_bottle_Click(sender As Object, e As EventArgs) Handles AlmondTea_bottle.Click
        '杏仁茶(瓶裝)
        buttonset()
        AlmondTea_bottle.BackColor = System.Drawing.Color.LightBlue
        x = "SELECT dish_name, dish_price FROM dish WHERE dish_id='dB1000';"
        dishid(n) = "dB1000"
    End Sub

    Private Sub Sesame_cup_Click(sender As Object, e As EventArgs) Handles Sesame_cup.Click
        '芝麻糊(杯裝)
        buttonset()
        Sesame_cup.BackColor = System.Drawing.Color.LightBlue
        x = "SELECT dish_name, dish_price FROM dish WHERE dish_id='dC500';"
        dishid(n) = "dC500"
    End Sub

    Private Sub Sesame_bottle_Click(sender As Object, e As EventArgs) Handles Sesame_bottle.Click
        '芝麻糊(瓶裝)
        buttonset()
        Sesame_bottle.BackColor = System.Drawing.Color.LightBlue
        x = "SELECT dish_name, dish_price FROM dish WHERE dish_id='dC1000';"
        dishid(n) = "dC1000"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '黑糖刨冰加煉乳
        buttonset()
        Button3.BackColor = System.Drawing.Color.LightBlue
        a = 4
        Ingredient.Show()
        x = "SELECT dish_name, dish_price FROM dish WHERE dish_id='ice1';"
        dishid(n) = "ice1"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '鳳梨刨冰加煉乳
        buttonset()
        Button4.BackColor = System.Drawing.Color.LightBlue
        a = 4
        Ingredient.Show()
        x = "SELECT dish_name, dish_price FROM dish WHERE dish_id='ice4';"
        dishid(n) = "ice4"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '焦糖豆花加1料按鈕
        buttonset()
        Button1.BackColor = System.Drawing.Color.LightBlue
        x = "SELECT dish_name, dish_price FROM dish WHERE dish_id='A1';"
        dishid(n) = "A1"
        a = 1
        Ingredient.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '焦糖豆花加多料按鈕
        buttonset()
        Button2.BackColor = System.Drawing.Color.LightBlue
        a = 3
        Ingredient.Show()
        x = "SELECT dish_name, dish_price FROM dish WHERE dish_id='A2';"
        dishid(n) = "A2"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '豆漿豆花加1料按鈕
        buttonset()
        Button6.BackColor = System.Drawing.Color.LightBlue
        a = 1
        Ingredient.Show()
        x = "SELECT dish_name, dish_price FROM dish WHERE dish_id='B1';"
        dishid(n) = "B1"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        '豆漿豆花加多料按鈕
        buttonset()
        Button7.BackColor = System.Drawing.Color.LightBlue
        a = 3
        Ingredient.Show()
        x = "SELECT dish_name, dish_price FROM dish WHERE dish_id='B2';"
        dishid(n) = "B2"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        '杏仁豆花加1料按鈕
        buttonset()
        Button8.BackColor = System.Drawing.Color.LightBlue
        a = 1
        Ingredient.Show()
        x = "SELECT dish_name, dish_price FROM dish WHERE dish_id='C1';"
        dishid(n) = "C1"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        '杏仁豆花加多料按鈕
        buttonset()
        Button9.BackColor = System.Drawing.Color.LightBlue
        a = 3
        Ingredient.Show()
        x = "SELECT dish_name, dish_price FROM dish WHERE dish_id='C2';"
        dishid(n) = "C2"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        a = 1
        Ingredient.Show()
        '芝麻豆花加1料按鈕
        buttonset()
        Button10.BackColor = System.Drawing.Color.LightBlue
        x = "SELECT dish_name, dish_price FROM dish WHERE dish_id='D1';"
        dishid(n) = "D1"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        '芝麻豆花加多料按鈕
        buttonset()
        Button11.BackColor = System.Drawing.Color.LightBlue
        a = 3
        Ingredient.Show()
        x = "SELECT dish_name, dish_price FROM dish WHERE dish_id='D2';"
        dishid(n) = "D2"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        '香草豆花加1料按鈕
        buttonset()
        Button12.BackColor = System.Drawing.Color.LightBlue
        a = 1
        Ingredient.Show()
        x = "SELECT dish_name, dish_price FROM dish WHERE dish_id='E1';"
        dishid(n) = "E1"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        '香草豆花加多料按鈕
        a = 3
        buttonset()
        Button13.BackColor = System.Drawing.Color.LightBlue
        Ingredient.Show()
        x = "SELECT dish_name, dish_price FROM dish WHERE dish_id='E2';"
        dishid(n) = "E2"
    End Sub
#End Region

    Private Sub Peanut_plus_Click(sender As Object, e As EventArgs) Handles order_plus.Click
        num(n) = num(n) + 1
        order_num.Text = num(n).ToString
    End Sub

    Private Sub order_minus_Click(sender As Object, e As EventArgs) Handles order_minus.Click
        If num(n) > 1 Then
            num(n) = num(n) - 1
            order_num.Text = num(n).ToString
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub

    Private Sub Button14_MouseHover(sender As Object, e As EventArgs) Handles Button14.MouseHover
        Button14.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Button14.ForeColor = System.Drawing.Color.Gold
    End Sub

    Private Sub Button14_MouseLeave(sender As Object, e As EventArgs) Handles Button14.MouseLeave
        Button14.FlatAppearance.BorderColor = System.Drawing.Color.LemonChiffon
        Button14.ForeColor = System.Drawing.Color.LemonChiffon
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        ordersearch.Show()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DeleteOrder_Click(sender As Object, e As EventArgs) Handles DeleteOrder.Click
        Dim i = 0
        i = Val(DataGridView1.CurrentRow.Index)
        price(n) = Val(DataGridView1.CurrentRow.Cells(1).Value)
        total = total - price(n)
        Sum.Text = "總金額" + total.ToString + "元"
        DataGridView1.Rows.RemoveAt(i)

    End Sub

    Private Sub checkout_Click(sender As Object, e As EventArgs) Handles checkout.Click
        Dim r As Integer
        Dim i = 0
        pay.TextBox2.Text = total.ToString
        pay.Show()
        total = 0
        Sum.Text = "總金額" + total.ToString + "元"
        ordertime = Format(Now, "yyyy/MM/dd HH:mm:ss")
        r = DataGridView1.Rows.Count
        If done = True Then
            For i = 0 To r - 1
                SQL_minus(add1(i))
                SQL_minus(add2(i))
                SQL_minus(add3(i))
                SQL_minus(add4(i))
                SQL_write(i)
            Next
        End If

        DataGridView1.Rows.Clear()
        SQL_orderid()
        orderidNow = orderid + 1
        number.Text = "單號:" + (orderidNow).ToString
        For i = 0 To 20
            num(i) = 1
            sugar(i) = "(預設)"
            ice(i) = "(預設)"
            add1(i) = 0
            add2(i) = 0
            add3(i) = 0
            add4(i) = 0
        Next
        n = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
        'Label6.Text = dishid(n)
    End Sub

End Class
