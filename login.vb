Imports MySql.Data.MySqlClient
Public Class login
    Dim password, name As String

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.BackColor = Color.FromArgb(10, 46, 124)
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackgroundImage = My.Resources.yellow1
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackgroundImage = My.Resources.yellow
    End Sub
    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Button2.BackgroundImage = My.Resources.green_1_
    End Sub
    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackgroundImage = My.Resources.green_box
    End Sub

    Private Sub CheckBox2_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Checked = False
            'Me.BackColor = Color.FromArgb(237, 226, 166)
            'TextBox1.BackColor = Color.FromArgb(196, 185, 126)
            'Button1.BackColor = Color.FromArgb(196, 185, 126)
            'Button2.BackColor = Color.FromArgb(196, 185, 126)
            'Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(123, 128, 66)
            'Button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(123, 128, 66)
            'Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(148, 153, 81)
            'Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(148, 153, 81)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
            'Me.BackColor = SystemColors.GradientInactiveCaption
            'TextBox1.BackColor = SystemColors.InactiveCaption
            'Button1.BackColor = SystemColors.GradientActiveCaption
            'Button2.BackColor = SystemColors.GradientActiveCaption
            'Button1.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption
            'Button2.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption
            'Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(77, 119, 163)
            'Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(77, 119, 163)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel5.Show()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox3.Text = ""
        TextBox10.Text = ""
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Panel5.Hide()
    End Sub
#Region "修改確認"
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim pass
        If CheckBox1.Checked = True Then
            name = "員工"
        ElseIf CheckBox2.Checked = True Then
            name = "管理者"
        End If

        pass = TextBox1.Text

        Dim ConString As New MySqlConnectionStringBuilder
        ConString.Database = "sa" '資料庫名稱為lifemanager
        ConString.Server = "127.0.0.1" '資料庫的IP位置
        ConString.UserID = "user" '資料庫使用者
        ConString.Password = "12345678" '資料庫使用者密碼
        ConString.SslMode = MySqlSslMode.None

        '建立查詢字串
        Dim QueryString As String = "SELECT * From user where user='" & name & "';"
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

                Dim dataReader As MySqlDataReader = MyCommand.ExecuteReader()
                Do While dataReader.Read()
                    'id = dataReader(0)
                    name = dataReader(0)
                    password = dataReader(1)
                    'ComboBox1.Items.Add(dataReader(0))
                Loop
                dataReader.Close()



                If password = TextBox3.Text Then
                    MsgBox("修改密碼成功請重新登入",, "修改成功")
                    Dim qs1 As String = "update user set password='" & TextBox10.Text & "' WHERE user='" & name & "';"
                    Dim cmd As MySqlCommand = New MySqlCommand(qs1, Connection)
                    cmd.ExecuteNonQuery()
                    'MsgBox(id)
                    'MsgBox(name)
                    Panel5.Hide()
                    'MsgBox(name)
                ElseIf TextBox10.Text = "" Then
                    MsgBox("新密碼尚未輸入喔!",, "新密碼未輸入")
                Else
                    'MsgBox(password)
                    MsgBox("密碼錯誤，請重新輸入",, "密碼錯誤")
                    TextBox3.Text = ""
                    TextBox10.Text = ""
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connection.Close()

            End Try
        End Using
    End Sub

#End Region

#Region "登入確認"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pass
        If CheckBox1.Checked = True Then
            name = "員工"
        ElseIf CheckBox2.Checked = True Then
            name = "管理者"
        End If

        pass = TextBox1.Text

        Dim ConString As New MySqlConnectionStringBuilder
        ConString.Database = "sa" '資料庫名稱為lifemanager
        ConString.Server = "127.0.0.1" '資料庫的IP位置
        ConString.UserID = "user" '資料庫使用者
        ConString.Password = "12345678" '資料庫使用者密碼
        ConString.SslMode = MySqlSslMode.None

        '建立查詢字串
        Dim QueryString As String = "SELECT * From user where user='" & name & "';"
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

                Dim dataReader As MySqlDataReader = MyCommand.ExecuteReader()
                Do While dataReader.Read()
                    'id = dataReader(0)
                    name = dataReader(0)
                    password = dataReader(1)
                    'ComboBox1.Items.Add(dataReader(0))
                Loop
                dataReader.Close()



                If pass = password Then
                    MsgBox("恭喜你成功登入",, "成功登入")
                    'MsgBox(id)
                    'MsgBox(name)
                    TextBox1.Clear()
                    If name = "員工" Then
                        menu1.Show()
                    ElseIf name = "管理者" Then
                        menu2.Show()
                    End If
                    Me.Close()


                    'MsgBox(name)
                Else
                    'MsgBox(password)
                    MsgBox("輸入錯誤，請重新輸入",, "輸入錯誤")
                    TextBox1.Clear()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                Connection.Close()

            End Try
        End Using
    End Sub
#End Region
    Private Sub Button16_MouseHover(sender As Object, e As EventArgs) Handles Button16.MouseHover
        Button16.BackgroundImage = My.Resources.後
    End Sub
    Private Sub Button16_MouseLeave(sender As Object, e As EventArgs) Handles Button16.MouseLeave
        Button16.BackgroundImage = My.Resources.按鈕
    End Sub
    Private Sub Button17_MouseHover(sender As Object, e As EventArgs) Handles Button17.MouseHover
        Button17.BackgroundImage = My.Resources.後
    End Sub
    Private Sub Button17_MouseLeave(sender As Object, e As EventArgs) Handles Button17.MouseLeave
        Button17.BackgroundImage = My.Resources.按鈕
    End Sub
    Private Sub Button18_MouseHover(sender As Object, e As EventArgs) Handles Button18.MouseHover
        Button18.BackgroundImage = My.Resources.後
    End Sub
    Private Sub Button18_MouseLeave(sender As Object, e As EventArgs) Handles Button18.MouseLeave
        Button18.BackgroundImage = My.Resources.按鈕
    End Sub
End Class