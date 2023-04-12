<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class report
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(report))
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.season_btn = New System.Windows.Forms.Button()
        Me.month_btn = New System.Windows.Forms.Button()
        Me.date_btn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.number5_name = New System.Windows.Forms.Label()
        Me.number4_name = New System.Windows.Forms.Label()
        Me.number3_name = New System.Windows.Forms.Label()
        Me.number2_name = New System.Windows.Forms.Label()
        Me.number1_name = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.day = New System.Windows.Forms.ComboBox()
        Me.month = New System.Windows.Forms.ComboBox()
        Me.year = New System.Windows.Forms.ComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.msearch = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mm = New System.Windows.Forms.ComboBox()
        Me.my = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.season = New System.Windows.Forms.ComboBox()
        Me.ssearch = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.sy = New System.Windows.Forms.ComboBox()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        ChartArea3.AlignmentOrientation = CType((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical Or System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal), System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)
        ChartArea3.AxisX.MajorGrid.Enabled = False
        ChartArea3.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far
        ChartArea3.AxisX.TitleFont = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea3.AxisY.InterlacedColor = System.Drawing.Color.White
        ChartArea3.AxisY.MajorGrid.Enabled = False
        ChartArea3.AxisY.MajorTickMark.LineWidth = 0
        ChartArea3.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal
        ChartArea3.AxisY.Title = "單位:元"
        ChartArea3.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far
        ChartArea3.AxisY.TitleFont = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea3.BackColor = System.Drawing.Color.Transparent
        ChartArea3.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center
        ChartArea3.BorderColor = System.Drawing.Color.Transparent
        ChartArea3.IsSameFontSizeForAllAxes = True
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(-30, 173)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(2)
        Me.Chart1.Name = "Chart1"
        Series3.BorderWidth = 5
        Series3.ChartArea = "ChartArea1"
        Series3.Color = System.Drawing.Color.SteelBlue
        Series3.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series3.IsVisibleInLegend = False
        Series3.IsXValueIndexed = True
        Series3.Legend = "Legend1"
        Series3.MarkerBorderColor = System.Drawing.Color.Gray
        Series3.MarkerBorderWidth = 4
        Series3.MarkerColor = System.Drawing.Color.White
        Series3.MarkerSize = 4
        Series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series3.Name = "Series"
        Series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(812, 560)
        Me.Chart1.TabIndex = 4
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.TableName = "Table1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.season_btn)
        Me.Panel1.Controls.Add(Me.month_btn)
        Me.Panel1.Controls.Add(Me.date_btn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1344, 78)
        Me.Panel1.TabIndex = 12
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Navy
        Me.Panel7.Controls.Add(Me.Button2)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(302, 78)
        Me.Panel7.TabIndex = 21
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(19, 14)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 48)
        Me.Button2.TabIndex = 37
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(66, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(219, 61)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "報表系統"
        '
        'season_btn
        '
        Me.season_btn.FlatAppearance.BorderSize = 0
        Me.season_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.season_btn.Font = New System.Drawing.Font("微軟正黑體", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.season_btn.ForeColor = System.Drawing.Color.White
        Me.season_btn.Location = New System.Drawing.Point(885, 0)
        Me.season_btn.Name = "season_btn"
        Me.season_btn.Size = New System.Drawing.Size(260, 78)
        Me.season_btn.TabIndex = 15
        Me.season_btn.Text = "季報表"
        Me.season_btn.UseVisualStyleBackColor = True
        '
        'month_btn
        '
        Me.month_btn.FlatAppearance.BorderSize = 0
        Me.month_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.month_btn.Font = New System.Drawing.Font("微軟正黑體", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.month_btn.ForeColor = System.Drawing.Color.White
        Me.month_btn.Location = New System.Drawing.Point(626, 0)
        Me.month_btn.Name = "month_btn"
        Me.month_btn.Size = New System.Drawing.Size(260, 78)
        Me.month_btn.TabIndex = 14
        Me.month_btn.Text = "月報表"
        Me.month_btn.UseVisualStyleBackColor = True
        '
        'date_btn
        '
        Me.date_btn.FlatAppearance.BorderSize = 0
        Me.date_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.date_btn.Font = New System.Drawing.Font("微軟正黑體", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.date_btn.ForeColor = System.Drawing.Color.White
        Me.date_btn.Location = New System.Drawing.Point(368, 0)
        Me.date_btn.Name = "date_btn"
        Me.date_btn.Size = New System.Drawing.Size(260, 78)
        Me.date_btn.TabIndex = 13
        Me.date_btn.Text = "日報表"
        Me.date_btn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(86, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(408, 37)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "XXXX年XX月XX日 銷售排行榜"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.number5_name)
        Me.Panel2.Controls.Add(Me.number4_name)
        Me.Panel2.Controls.Add(Me.number3_name)
        Me.Panel2.Controls.Add(Me.number2_name)
        Me.Panel2.Controls.Add(Me.number1_name)
        Me.Panel2.Location = New System.Drawing.Point(751, 132)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(581, 624)
        Me.Panel2.TabIndex = 16
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(72, 459)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(87, 83)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 26
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(72, 370)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(87, 83)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 25
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(72, 281)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(87, 83)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 24
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(72, 192)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(87, 83)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(72, 103)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(581, 97)
        Me.Panel3.TabIndex = 19
        '
        'number5_name
        '
        Me.number5_name.AutoSize = True
        Me.number5_name.Font = New System.Drawing.Font("微軟正黑體", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.number5_name.Location = New System.Drawing.Point(164, 474)
        Me.number5_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.number5_name.Name = "number5_name"
        Me.number5_name.Size = New System.Drawing.Size(56, 44)
        Me.number5_name.TabIndex = 14
        Me.number5_name.Text = "ID"
        '
        'number4_name
        '
        Me.number4_name.AutoSize = True
        Me.number4_name.Font = New System.Drawing.Font("微軟正黑體", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.number4_name.Location = New System.Drawing.Point(164, 392)
        Me.number4_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.number4_name.Name = "number4_name"
        Me.number4_name.Size = New System.Drawing.Size(56, 44)
        Me.number4_name.TabIndex = 16
        Me.number4_name.Text = "ID"
        '
        'number3_name
        '
        Me.number3_name.AutoSize = True
        Me.number3_name.Font = New System.Drawing.Font("微軟正黑體", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.number3_name.Location = New System.Drawing.Point(164, 301)
        Me.number3_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.number3_name.Name = "number3_name"
        Me.number3_name.Size = New System.Drawing.Size(56, 44)
        Me.number3_name.TabIndex = 18
        Me.number3_name.Text = "ID"
        '
        'number2_name
        '
        Me.number2_name.AutoSize = True
        Me.number2_name.Font = New System.Drawing.Font("微軟正黑體", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.number2_name.Location = New System.Drawing.Point(164, 211)
        Me.number2_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.number2_name.Name = "number2_name"
        Me.number2_name.Size = New System.Drawing.Size(56, 44)
        Me.number2_name.TabIndex = 20
        Me.number2_name.Text = "ID"
        '
        'number1_name
        '
        Me.number1_name.AutoSize = True
        Me.number1_name.Font = New System.Drawing.Font("微軟正黑體", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.number1_name.Location = New System.Drawing.Point(164, 122)
        Me.number1_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.number1_name.Name = "number1_name"
        Me.number1_name.Size = New System.Drawing.Size(56, 44)
        Me.number1_name.TabIndex = 12
        Me.number1_name.Text = "ID"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.day)
        Me.Panel4.Controls.Add(Me.month)
        Me.Panel4.Controls.Add(Me.year)
        Me.Panel4.Location = New System.Drawing.Point(129, 87)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(542, 61)
        Me.Panel4.TabIndex = 18
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.BackColor = System.Drawing.Color.LightGray
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(415, 14)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 34)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "查詢"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(358, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 27)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "日"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(241, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 27)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "月"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 27)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "年"
        '
        'day
        '
        Me.day.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.day.FormattingEnabled = True
        Me.day.IntegralHeight = False
        Me.day.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.day.Location = New System.Drawing.Point(280, 14)
        Me.day.MaxDropDownItems = 15
        Me.day.Name = "day"
        Me.day.Size = New System.Drawing.Size(72, 32)
        Me.day.TabIndex = 8
        '
        'month
        '
        Me.month.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.month.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.month.FormattingEnabled = True
        Me.month.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.month.Location = New System.Drawing.Point(156, 14)
        Me.month.Name = "month"
        Me.month.Size = New System.Drawing.Size(79, 32)
        Me.month.TabIndex = 7
        '
        'year
        '
        Me.year.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.year.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.year.FormattingEnabled = True
        Me.year.Items.AddRange(New Object() {"2020", "2021"})
        Me.year.Location = New System.Drawing.Point(19, 14)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(92, 32)
        Me.year.TabIndex = 6
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.msearch)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.mm)
        Me.Panel5.Controls.Add(Me.my)
        Me.Panel5.Location = New System.Drawing.Point(113, 90)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(542, 61)
        Me.Panel5.TabIndex = 19
        '
        'msearch
        '
        Me.msearch.AutoSize = True
        Me.msearch.BackColor = System.Drawing.Color.LightGray
        Me.msearch.FlatAppearance.BorderSize = 0
        Me.msearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.msearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.msearch.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.msearch.Location = New System.Drawing.Point(280, 16)
        Me.msearch.Name = "msearch"
        Me.msearch.Size = New System.Drawing.Size(75, 36)
        Me.msearch.TabIndex = 12
        Me.msearch.Text = "查詢"
        Me.msearch.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(241, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 27)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "月"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(117, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 27)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "年"
        '
        'mm
        '
        Me.mm.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.mm.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.mm.FormattingEnabled = True
        Me.mm.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.mm.Location = New System.Drawing.Point(156, 14)
        Me.mm.Name = "mm"
        Me.mm.Size = New System.Drawing.Size(79, 32)
        Me.mm.TabIndex = 7
        '
        'my
        '
        Me.my.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.my.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.my.FormattingEnabled = True
        Me.my.Items.AddRange(New Object() {"2020", "2021"})
        Me.my.Location = New System.Drawing.Point(19, 14)
        Me.my.Name = "my"
        Me.my.Size = New System.Drawing.Size(92, 32)
        Me.my.TabIndex = 6
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.season)
        Me.Panel6.Controls.Add(Me.ssearch)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.sy)
        Me.Panel6.Location = New System.Drawing.Point(126, 90)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(542, 61)
        Me.Panel6.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(241, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 27)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "季"
        '
        'season
        '
        Me.season.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.season.FormattingEnabled = True
        Me.season.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.season.Location = New System.Drawing.Point(156, 14)
        Me.season.Name = "season"
        Me.season.Size = New System.Drawing.Size(79, 32)
        Me.season.TabIndex = 14
        '
        'ssearch
        '
        Me.ssearch.AutoSize = True
        Me.ssearch.BackColor = System.Drawing.Color.LightGray
        Me.ssearch.FlatAppearance.BorderSize = 0
        Me.ssearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.ssearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ssearch.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ssearch.Location = New System.Drawing.Point(289, 16)
        Me.ssearch.Name = "ssearch"
        Me.ssearch.Size = New System.Drawing.Size(75, 36)
        Me.ssearch.TabIndex = 12
        Me.ssearch.Text = "查詢"
        Me.ssearch.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(117, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 27)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "年"
        '
        'sy
        '
        Me.sy.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.sy.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.sy.FormattingEnabled = True
        Me.sy.Items.AddRange(New Object() {"2020", "2021"})
        Me.sy.Location = New System.Drawing.Point(19, 14)
        Me.sy.Name = "sy"
        Me.sy.Size = New System.Drawing.Size(92, 32)
        Me.sy.TabIndex = 6
        '
        'report
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1344, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Chart1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "report"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents DataTable1 As DataTable
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents season_btn As Button
    Friend WithEvents month_btn As Button
    Friend WithEvents date_btn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents number5_name As Label
    Friend WithEvents number4_name As Label
    Friend WithEvents number3_name As Label
    Friend WithEvents number2_name As Label
    Friend WithEvents number1_name As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents day As ComboBox
    Friend WithEvents month As ComboBox
    Friend WithEvents year As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents msearch As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents mm As ComboBox
    Friend WithEvents my As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents ssearch As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents sy As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents season As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel7 As Panel
End Class
