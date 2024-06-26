<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SiparisForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Timer1 = New Timer(components)
        btnDurdur = New Button()
        btnBaslat = New Button()
        dtgvuadfiyat = New DataGridView()
        btnSiparis = New Button()
        dtgvuturu = New DataGridView()
        btneksilt = New Button()
        DataGridView1 = New DataGridView()
        nudadet = New NumericUpDown()
        btnarttir = New Button()
        GroupBox2 = New GroupBox()
        rBtn26 = New RadioButton()
        rBtn27 = New RadioButton()
        rBtn35 = New RadioButton()
        rBtn28 = New RadioButton()
        rBtn34 = New RadioButton()
        rBtn29 = New RadioButton()
        rBtn33 = New RadioButton()
        rBtn30 = New RadioButton()
        rBtn32 = New RadioButton()
        rBtn31 = New RadioButton()
        GroupBox1 = New GroupBox()
        rBtn1 = New RadioButton()
        rBtn2 = New RadioButton()
        rBtn3 = New RadioButton()
        Label1 = New Label()
        rBtn4 = New RadioButton()
        Label2 = New Label()
        rBtn5 = New RadioButton()
        rBtn6 = New RadioButton()
        rBtn7 = New RadioButton()
        rBtn8 = New RadioButton()
        rBtn9 = New RadioButton()
        rBtn10 = New RadioButton()
        rBtn11 = New RadioButton()
        rBtn25 = New RadioButton()
        rBtn12 = New RadioButton()
        rBtn24 = New RadioButton()
        rBtn13 = New RadioButton()
        rBtn23 = New RadioButton()
        rBtn14 = New RadioButton()
        rBtn22 = New RadioButton()
        rBtn15 = New RadioButton()
        rBtn21 = New RadioButton()
        rBtn16 = New RadioButton()
        rBtn20 = New RadioButton()
        rBtn17 = New RadioButton()
        rBtn19 = New RadioButton()
        rBtn18 = New RadioButton()
        CType(dtgvuadfiyat, ComponentModel.ISupportInitialize).BeginInit()
        CType(dtgvuturu, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudadet, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' btnDurdur
        ' 
        btnDurdur.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnDurdur.FlatStyle = FlatStyle.Popup
        btnDurdur.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        btnDurdur.Location = New Point(1077, 822)
        btnDurdur.Name = "btnDurdur"
        btnDurdur.Size = New Size(373, 55)
        btnDurdur.TabIndex = 54
        btnDurdur.Text = "ÖDEME AL"
        btnDurdur.UseVisualStyleBackColor = False
        ' 
        ' btnBaslat
        ' 
        btnBaslat.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnBaslat.FlatStyle = FlatStyle.Popup
        btnBaslat.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        btnBaslat.Location = New Point(686, 822)
        btnBaslat.Name = "btnBaslat"
        btnBaslat.Size = New Size(373, 55)
        btnBaslat.TabIndex = 53
        btnBaslat.Text = "OTURUM BAŞLAT"
        btnBaslat.UseVisualStyleBackColor = False
        ' 
        ' dtgvuadfiyat
        ' 
        dtgvuadfiyat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dtgvuadfiyat.BackgroundColor = Color.White
        dtgvuadfiyat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgvuadfiyat.Location = New Point(242, 12)
        dtgvuadfiyat.Name = "dtgvuadfiyat"
        dtgvuadfiyat.RowHeadersVisible = False
        dtgvuadfiyat.RowTemplate.Height = 25
        dtgvuadfiyat.ScrollBars = ScrollBars.Vertical
        dtgvuadfiyat.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtgvuadfiyat.Size = New Size(438, 196)
        dtgvuadfiyat.TabIndex = 58
        ' 
        ' btnSiparis
        ' 
        btnSiparis.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnSiparis.FlatStyle = FlatStyle.Popup
        btnSiparis.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnSiparis.Location = New Point(384, 255)
        btnSiparis.MaximumSize = New Size(254, 55)
        btnSiparis.Name = "btnSiparis"
        btnSiparis.Size = New Size(254, 55)
        btnSiparis.TabIndex = 59
        btnSiparis.Text = "SİPARİŞ AL"
        btnSiparis.UseVisualStyleBackColor = False
        ' 
        ' dtgvuturu
        ' 
        dtgvuturu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dtgvuturu.BackgroundColor = Color.White
        dtgvuturu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgvuturu.Location = New Point(12, 12)
        dtgvuturu.MaximumSize = New Size(265, 263)
        dtgvuturu.Name = "dtgvuturu"
        dtgvuturu.RowHeadersVisible = False
        dtgvuturu.RowTemplate.Height = 25
        dtgvuturu.ScrollBars = ScrollBars.Vertical
        dtgvuturu.Size = New Size(224, 196)
        dtgvuturu.TabIndex = 57
        ' 
        ' btneksilt
        ' 
        btneksilt.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btneksilt.FlatStyle = FlatStyle.Popup
        btneksilt.Font = New Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btneksilt.Location = New Point(277, 282)
        btneksilt.Name = "btneksilt"
        btneksilt.Size = New Size(50, 50)
        btneksilt.TabIndex = 62
        btneksilt.Text = "-"
        btneksilt.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 356)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(668, 521)
        DataGridView1.TabIndex = 60
        ' 
        ' nudadet
        ' 
        nudadet.AutoSize = True
        nudadet.BorderStyle = BorderStyle.FixedSingle
        nudadet.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        nudadet.Location = New Point(40, 226)
        nudadet.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        nudadet.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudadet.Name = "nudadet"
        nudadet.Size = New Size(120, 22)
        nudadet.TabIndex = 63
        nudadet.TextAlign = HorizontalAlignment.Center
        nudadet.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' btnarttir
        ' 
        btnarttir.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnarttir.FlatStyle = FlatStyle.Popup
        btnarttir.Font = New Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnarttir.Location = New Point(277, 226)
        btnarttir.Name = "btnarttir"
        btnarttir.Size = New Size(50, 50)
        btnarttir.TabIndex = 61
        btnarttir.Text = "+"
        btnarttir.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        GroupBox2.Controls.Add(rBtn26)
        GroupBox2.Controls.Add(rBtn27)
        GroupBox2.Controls.Add(rBtn35)
        GroupBox2.Controls.Add(rBtn28)
        GroupBox2.Controls.Add(rBtn34)
        GroupBox2.Controls.Add(rBtn29)
        GroupBox2.Controls.Add(rBtn33)
        GroupBox2.Controls.Add(rBtn30)
        GroupBox2.Controls.Add(rBtn32)
        GroupBox2.Controls.Add(rBtn31)
        GroupBox2.Location = New Point(686, 555)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(764, 252)
        GroupBox2.TabIndex = 65
        GroupBox2.TabStop = False
        GroupBox2.Text = "DIŞ MEKAN"
        ' 
        ' rBtn26
        ' 
        rBtn26.Appearance = Appearance.Button
        rBtn26.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn26.Location = New Point(41, 38)
        rBtn26.Name = "rBtn26"
        rBtn26.Size = New Size(125, 80)
        rBtn26.TabIndex = 25
        rBtn26.TabStop = True
        rBtn26.Text = "26"
        rBtn26.TextAlign = ContentAlignment.MiddleCenter
        rBtn26.UseVisualStyleBackColor = True
        ' 
        ' rBtn27
        ' 
        rBtn27.Appearance = Appearance.Button
        rBtn27.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn27.Location = New Point(177, 38)
        rBtn27.Name = "rBtn27"
        rBtn27.Size = New Size(125, 80)
        rBtn27.TabIndex = 26
        rBtn27.TabStop = True
        rBtn27.Text = "27"
        rBtn27.TextAlign = ContentAlignment.MiddleCenter
        rBtn27.UseVisualStyleBackColor = True
        ' 
        ' rBtn35
        ' 
        rBtn35.Appearance = Appearance.Button
        rBtn35.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn35.Location = New Point(585, 129)
        rBtn35.Name = "rBtn35"
        rBtn35.Size = New Size(125, 80)
        rBtn35.TabIndex = 34
        rBtn35.TabStop = True
        rBtn35.Text = "35"
        rBtn35.TextAlign = ContentAlignment.MiddleCenter
        rBtn35.UseVisualStyleBackColor = True
        ' 
        ' rBtn28
        ' 
        rBtn28.Appearance = Appearance.Button
        rBtn28.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn28.Location = New Point(313, 38)
        rBtn28.Name = "rBtn28"
        rBtn28.Size = New Size(125, 80)
        rBtn28.TabIndex = 27
        rBtn28.TabStop = True
        rBtn28.Text = "28"
        rBtn28.TextAlign = ContentAlignment.MiddleCenter
        rBtn28.UseVisualStyleBackColor = True
        ' 
        ' rBtn34
        ' 
        rBtn34.Appearance = Appearance.Button
        rBtn34.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn34.Location = New Point(449, 129)
        rBtn34.Name = "rBtn34"
        rBtn34.Size = New Size(125, 80)
        rBtn34.TabIndex = 33
        rBtn34.TabStop = True
        rBtn34.Text = "34"
        rBtn34.TextAlign = ContentAlignment.MiddleCenter
        rBtn34.UseVisualStyleBackColor = True
        ' 
        ' rBtn29
        ' 
        rBtn29.Appearance = Appearance.Button
        rBtn29.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn29.Location = New Point(449, 38)
        rBtn29.Name = "rBtn29"
        rBtn29.Size = New Size(125, 80)
        rBtn29.TabIndex = 28
        rBtn29.TabStop = True
        rBtn29.Text = "29"
        rBtn29.TextAlign = ContentAlignment.MiddleCenter
        rBtn29.UseVisualStyleBackColor = True
        ' 
        ' rBtn33
        ' 
        rBtn33.Appearance = Appearance.Button
        rBtn33.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn33.Location = New Point(313, 129)
        rBtn33.Name = "rBtn33"
        rBtn33.Size = New Size(125, 80)
        rBtn33.TabIndex = 32
        rBtn33.TabStop = True
        rBtn33.Text = "33"
        rBtn33.TextAlign = ContentAlignment.MiddleCenter
        rBtn33.UseVisualStyleBackColor = True
        ' 
        ' rBtn30
        ' 
        rBtn30.Appearance = Appearance.Button
        rBtn30.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn30.Location = New Point(585, 38)
        rBtn30.Name = "rBtn30"
        rBtn30.Size = New Size(125, 80)
        rBtn30.TabIndex = 29
        rBtn30.TabStop = True
        rBtn30.Text = "30"
        rBtn30.TextAlign = ContentAlignment.MiddleCenter
        rBtn30.UseVisualStyleBackColor = True
        ' 
        ' rBtn32
        ' 
        rBtn32.Appearance = Appearance.Button
        rBtn32.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn32.Location = New Point(177, 129)
        rBtn32.Name = "rBtn32"
        rBtn32.Size = New Size(125, 80)
        rBtn32.TabIndex = 31
        rBtn32.TabStop = True
        rBtn32.Text = "32"
        rBtn32.TextAlign = ContentAlignment.MiddleCenter
        rBtn32.UseVisualStyleBackColor = True
        ' 
        ' rBtn31
        ' 
        rBtn31.Appearance = Appearance.Button
        rBtn31.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn31.Location = New Point(41, 129)
        rBtn31.Name = "rBtn31"
        rBtn31.Size = New Size(125, 80)
        rBtn31.TabIndex = 30
        rBtn31.TabStop = True
        rBtn31.Text = "31"
        rBtn31.TextAlign = ContentAlignment.MiddleCenter
        rBtn31.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.AutoSize = True
        GroupBox1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        GroupBox1.Controls.Add(rBtn1)
        GroupBox1.Controls.Add(rBtn2)
        GroupBox1.Controls.Add(rBtn3)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(rBtn4)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(rBtn5)
        GroupBox1.Controls.Add(rBtn6)
        GroupBox1.Controls.Add(rBtn7)
        GroupBox1.Controls.Add(rBtn8)
        GroupBox1.Controls.Add(rBtn9)
        GroupBox1.Controls.Add(rBtn10)
        GroupBox1.Controls.Add(rBtn11)
        GroupBox1.Controls.Add(rBtn25)
        GroupBox1.Controls.Add(rBtn12)
        GroupBox1.Controls.Add(rBtn24)
        GroupBox1.Controls.Add(rBtn13)
        GroupBox1.Controls.Add(rBtn23)
        GroupBox1.Controls.Add(rBtn14)
        GroupBox1.Controls.Add(rBtn22)
        GroupBox1.Controls.Add(rBtn15)
        GroupBox1.Controls.Add(rBtn21)
        GroupBox1.Controls.Add(rBtn16)
        GroupBox1.Controls.Add(rBtn20)
        GroupBox1.Controls.Add(rBtn17)
        GroupBox1.Controls.Add(rBtn19)
        GroupBox1.Controls.Add(rBtn18)
        GroupBox1.Location = New Point(686, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(751, 537)
        GroupBox1.TabIndex = 64
        GroupBox1.TabStop = False
        GroupBox1.Text = "İÇ MEKAN"
        ' 
        ' rBtn1
        ' 
        rBtn1.Appearance = Appearance.Button
        rBtn1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn1.Location = New Point(41, 71)
        rBtn1.Name = "rBtn1"
        rBtn1.Size = New Size(125, 80)
        rBtn1.TabIndex = 0
        rBtn1.TabStop = True
        rBtn1.Text = "1"
        rBtn1.TextAlign = ContentAlignment.MiddleCenter
        rBtn1.UseVisualStyleBackColor = True
        ' 
        ' rBtn2
        ' 
        rBtn2.Appearance = Appearance.Button
        rBtn2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn2.Location = New Point(177, 71)
        rBtn2.Name = "rBtn2"
        rBtn2.Size = New Size(125, 80)
        rBtn2.TabIndex = 1
        rBtn2.TabStop = True
        rBtn2.Text = "2"
        rBtn2.TextAlign = ContentAlignment.MiddleCenter
        rBtn2.UseVisualStyleBackColor = True
        ' 
        ' rBtn3
        ' 
        rBtn3.Appearance = Appearance.Button
        rBtn3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn3.Location = New Point(313, 71)
        rBtn3.Name = "rBtn3"
        rBtn3.Size = New Size(125, 80)
        rBtn3.TabIndex = 2
        rBtn3.TabStop = True
        rBtn3.Text = "3"
        rBtn3.TextAlign = ContentAlignment.MiddleCenter
        rBtn3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(448, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 39
        ' 
        ' rBtn4
        ' 
        rBtn4.Appearance = Appearance.Button
        rBtn4.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn4.Location = New Point(449, 71)
        rBtn4.Name = "rBtn4"
        rBtn4.Size = New Size(125, 80)
        rBtn4.TabIndex = 3
        rBtn4.TabStop = True
        rBtn4.Text = "4"
        rBtn4.TextAlign = ContentAlignment.MiddleCenter
        rBtn4.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(388, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 40
        Label2.Text = "TARİH:"
        ' 
        ' rBtn5
        ' 
        rBtn5.Appearance = Appearance.Button
        rBtn5.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn5.Location = New Point(585, 71)
        rBtn5.Name = "rBtn5"
        rBtn5.Size = New Size(125, 80)
        rBtn5.TabIndex = 4
        rBtn5.TabStop = True
        rBtn5.Text = "5"
        rBtn5.TextAlign = ContentAlignment.MiddleCenter
        rBtn5.UseVisualStyleBackColor = True
        ' 
        ' rBtn6
        ' 
        rBtn6.Appearance = Appearance.Button
        rBtn6.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn6.Location = New Point(41, 162)
        rBtn6.Name = "rBtn6"
        rBtn6.Size = New Size(125, 80)
        rBtn6.TabIndex = 5
        rBtn6.TabStop = True
        rBtn6.Text = "6"
        rBtn6.TextAlign = ContentAlignment.MiddleCenter
        rBtn6.UseVisualStyleBackColor = True
        ' 
        ' rBtn7
        ' 
        rBtn7.Appearance = Appearance.Button
        rBtn7.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn7.Location = New Point(177, 162)
        rBtn7.Name = "rBtn7"
        rBtn7.Size = New Size(125, 80)
        rBtn7.TabIndex = 6
        rBtn7.TabStop = True
        rBtn7.Text = "7"
        rBtn7.TextAlign = ContentAlignment.MiddleCenter
        rBtn7.UseVisualStyleBackColor = True
        ' 
        ' rBtn8
        ' 
        rBtn8.Appearance = Appearance.Button
        rBtn8.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn8.Location = New Point(313, 162)
        rBtn8.Name = "rBtn8"
        rBtn8.Size = New Size(125, 80)
        rBtn8.TabIndex = 7
        rBtn8.TabStop = True
        rBtn8.Text = "8"
        rBtn8.TextAlign = ContentAlignment.MiddleCenter
        rBtn8.UseVisualStyleBackColor = True
        ' 
        ' rBtn9
        ' 
        rBtn9.Appearance = Appearance.Button
        rBtn9.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn9.Location = New Point(449, 162)
        rBtn9.Name = "rBtn9"
        rBtn9.Size = New Size(125, 80)
        rBtn9.TabIndex = 8
        rBtn9.TabStop = True
        rBtn9.Text = "9"
        rBtn9.TextAlign = ContentAlignment.MiddleCenter
        rBtn9.UseVisualStyleBackColor = True
        ' 
        ' rBtn10
        ' 
        rBtn10.Appearance = Appearance.Button
        rBtn10.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn10.Location = New Point(585, 162)
        rBtn10.Name = "rBtn10"
        rBtn10.Size = New Size(125, 80)
        rBtn10.TabIndex = 9
        rBtn10.TabStop = True
        rBtn10.Text = "10"
        rBtn10.TextAlign = ContentAlignment.MiddleCenter
        rBtn10.UseVisualStyleBackColor = True
        ' 
        ' rBtn11
        ' 
        rBtn11.Appearance = Appearance.Button
        rBtn11.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn11.Location = New Point(41, 253)
        rBtn11.Name = "rBtn11"
        rBtn11.Size = New Size(125, 80)
        rBtn11.TabIndex = 10
        rBtn11.TabStop = True
        rBtn11.Text = "11"
        rBtn11.TextAlign = ContentAlignment.MiddleCenter
        rBtn11.UseVisualStyleBackColor = True
        ' 
        ' rBtn25
        ' 
        rBtn25.Appearance = Appearance.Button
        rBtn25.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn25.Location = New Point(585, 435)
        rBtn25.Name = "rBtn25"
        rBtn25.Size = New Size(125, 80)
        rBtn25.TabIndex = 24
        rBtn25.TabStop = True
        rBtn25.Text = "25"
        rBtn25.TextAlign = ContentAlignment.MiddleCenter
        rBtn25.UseVisualStyleBackColor = True
        ' 
        ' rBtn12
        ' 
        rBtn12.Appearance = Appearance.Button
        rBtn12.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn12.Location = New Point(177, 253)
        rBtn12.Name = "rBtn12"
        rBtn12.Size = New Size(125, 80)
        rBtn12.TabIndex = 11
        rBtn12.TabStop = True
        rBtn12.Text = "12"
        rBtn12.TextAlign = ContentAlignment.MiddleCenter
        rBtn12.UseVisualStyleBackColor = True
        ' 
        ' rBtn24
        ' 
        rBtn24.Appearance = Appearance.Button
        rBtn24.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn24.Location = New Point(449, 435)
        rBtn24.Name = "rBtn24"
        rBtn24.Size = New Size(125, 80)
        rBtn24.TabIndex = 23
        rBtn24.TabStop = True
        rBtn24.Text = "24"
        rBtn24.TextAlign = ContentAlignment.MiddleCenter
        rBtn24.UseVisualStyleBackColor = True
        ' 
        ' rBtn13
        ' 
        rBtn13.Appearance = Appearance.Button
        rBtn13.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn13.Location = New Point(313, 253)
        rBtn13.Name = "rBtn13"
        rBtn13.Size = New Size(125, 80)
        rBtn13.TabIndex = 12
        rBtn13.TabStop = True
        rBtn13.Text = "13"
        rBtn13.TextAlign = ContentAlignment.MiddleCenter
        rBtn13.UseVisualStyleBackColor = True
        ' 
        ' rBtn23
        ' 
        rBtn23.Appearance = Appearance.Button
        rBtn23.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn23.Location = New Point(313, 435)
        rBtn23.Name = "rBtn23"
        rBtn23.Size = New Size(125, 80)
        rBtn23.TabIndex = 22
        rBtn23.TabStop = True
        rBtn23.Text = "23"
        rBtn23.TextAlign = ContentAlignment.MiddleCenter
        rBtn23.UseVisualStyleBackColor = True
        ' 
        ' rBtn14
        ' 
        rBtn14.Appearance = Appearance.Button
        rBtn14.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn14.Location = New Point(449, 253)
        rBtn14.Name = "rBtn14"
        rBtn14.Size = New Size(125, 80)
        rBtn14.TabIndex = 13
        rBtn14.TabStop = True
        rBtn14.Text = "14"
        rBtn14.TextAlign = ContentAlignment.MiddleCenter
        rBtn14.UseVisualStyleBackColor = True
        ' 
        ' rBtn22
        ' 
        rBtn22.Appearance = Appearance.Button
        rBtn22.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn22.Location = New Point(177, 435)
        rBtn22.Name = "rBtn22"
        rBtn22.Size = New Size(125, 80)
        rBtn22.TabIndex = 21
        rBtn22.TabStop = True
        rBtn22.Text = "22"
        rBtn22.TextAlign = ContentAlignment.MiddleCenter
        rBtn22.UseVisualStyleBackColor = True
        ' 
        ' rBtn15
        ' 
        rBtn15.Appearance = Appearance.Button
        rBtn15.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn15.Location = New Point(585, 253)
        rBtn15.Name = "rBtn15"
        rBtn15.Size = New Size(125, 80)
        rBtn15.TabIndex = 14
        rBtn15.TabStop = True
        rBtn15.Text = "15"
        rBtn15.TextAlign = ContentAlignment.MiddleCenter
        rBtn15.UseVisualStyleBackColor = True
        ' 
        ' rBtn21
        ' 
        rBtn21.Appearance = Appearance.Button
        rBtn21.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn21.Location = New Point(41, 435)
        rBtn21.Name = "rBtn21"
        rBtn21.Size = New Size(125, 80)
        rBtn21.TabIndex = 20
        rBtn21.TabStop = True
        rBtn21.Text = "21"
        rBtn21.TextAlign = ContentAlignment.MiddleCenter
        rBtn21.UseVisualStyleBackColor = True
        ' 
        ' rBtn16
        ' 
        rBtn16.Appearance = Appearance.Button
        rBtn16.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn16.Location = New Point(40, 344)
        rBtn16.Name = "rBtn16"
        rBtn16.Size = New Size(125, 80)
        rBtn16.TabIndex = 15
        rBtn16.TabStop = True
        rBtn16.Text = "16"
        rBtn16.TextAlign = ContentAlignment.MiddleCenter
        rBtn16.UseVisualStyleBackColor = True
        ' 
        ' rBtn20
        ' 
        rBtn20.Appearance = Appearance.Button
        rBtn20.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn20.Location = New Point(585, 344)
        rBtn20.Name = "rBtn20"
        rBtn20.Size = New Size(125, 80)
        rBtn20.TabIndex = 19
        rBtn20.TabStop = True
        rBtn20.Text = "20"
        rBtn20.TextAlign = ContentAlignment.MiddleCenter
        rBtn20.UseVisualStyleBackColor = True
        ' 
        ' rBtn17
        ' 
        rBtn17.Appearance = Appearance.Button
        rBtn17.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn17.Location = New Point(177, 344)
        rBtn17.Name = "rBtn17"
        rBtn17.Size = New Size(125, 80)
        rBtn17.TabIndex = 16
        rBtn17.TabStop = True
        rBtn17.Text = "17"
        rBtn17.TextAlign = ContentAlignment.MiddleCenter
        rBtn17.UseVisualStyleBackColor = True
        ' 
        ' rBtn19
        ' 
        rBtn19.Appearance = Appearance.Button
        rBtn19.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn19.Location = New Point(449, 344)
        rBtn19.Name = "rBtn19"
        rBtn19.Size = New Size(125, 80)
        rBtn19.TabIndex = 18
        rBtn19.TabStop = True
        rBtn19.Text = "19"
        rBtn19.TextAlign = ContentAlignment.MiddleCenter
        rBtn19.UseVisualStyleBackColor = True
        ' 
        ' rBtn18
        ' 
        rBtn18.Appearance = Appearance.Button
        rBtn18.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        rBtn18.Location = New Point(313, 344)
        rBtn18.Name = "rBtn18"
        rBtn18.Size = New Size(125, 80)
        rBtn18.TabIndex = 17
        rBtn18.TabStop = True
        rBtn18.Text = "18"
        rBtn18.TextAlign = ContentAlignment.MiddleCenter
        rBtn18.UseVisualStyleBackColor = True
        ' 
        ' SiparisForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1464, 889)
        ControlBox = False
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(btnBaslat)
        Controls.Add(dtgvuadfiyat)
        Controls.Add(btnDurdur)
        Controls.Add(btnSiparis)
        Controls.Add(dtgvuturu)
        Controls.Add(btneksilt)
        Controls.Add(DataGridView1)
        Controls.Add(nudadet)
        Controls.Add(btnarttir)
        FormBorderStyle = FormBorderStyle.None
        MinimizeBox = False
        Name = "SiparisForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "SiparisForm"
        CType(dtgvuadfiyat, ComponentModel.ISupportInitialize).EndInit()
        CType(dtgvuturu, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(nudadet, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btneksilt As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnarttir As Button
    Friend WithEvents btnDurdur As Button
    Friend WithEvents btnBaslat As Button
    Friend WithEvents dtgvuadfiyat As DataGridView
    Friend WithEvents btnSiparis As Button
    Friend WithEvents dtgvuturu As DataGridView
    Friend WithEvents nudadet As NumericUpDown
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rBtn26 As RadioButton
    Friend WithEvents rBtn27 As RadioButton
    Friend WithEvents rBtn35 As RadioButton
    Friend WithEvents rBtn28 As RadioButton
    Friend WithEvents rBtn34 As RadioButton
    Friend WithEvents rBtn29 As RadioButton
    Friend WithEvents rBtn33 As RadioButton
    Friend WithEvents rBtn30 As RadioButton
    Friend WithEvents rBtn32 As RadioButton
    Friend WithEvents rBtn31 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rBtn1 As RadioButton
    Friend WithEvents rBtn2 As RadioButton
    Friend WithEvents rBtn3 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents rBtn4 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents rBtn5 As RadioButton
    Friend WithEvents rBtn6 As RadioButton
    Friend WithEvents rBtn7 As RadioButton
    Friend WithEvents rBtn8 As RadioButton
    Friend WithEvents rBtn9 As RadioButton
    Friend WithEvents rBtn10 As RadioButton
    Friend WithEvents rBtn11 As RadioButton
    Friend WithEvents rBtn25 As RadioButton
    Friend WithEvents rBtn12 As RadioButton
    Friend WithEvents rBtn24 As RadioButton
    Friend WithEvents rBtn13 As RadioButton
    Friend WithEvents rBtn23 As RadioButton
    Friend WithEvents rBtn14 As RadioButton
    Friend WithEvents rBtn22 As RadioButton
    Friend WithEvents rBtn15 As RadioButton
    Friend WithEvents rBtn21 As RadioButton
    Friend WithEvents rBtn16 As RadioButton
    Friend WithEvents rBtn20 As RadioButton
    Friend WithEvents rBtn17 As RadioButton
    Friend WithEvents rBtn19 As RadioButton
    Friend WithEvents rBtn18 As RadioButton
End Class
