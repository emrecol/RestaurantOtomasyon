<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RaporForm
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DataGridView1 = New DataGridView()
        dtpStartDate = New DateTimePicker()
        dtpEndDate = New DateTimePicker()
        ComboBox1 = New ComboBox()
        txtPersonel = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtMusteri = New TextBox()
        btnFiltrele = New Button()
        cbMasano = New ComboBox()
        Label6 = New Label()
        Panel1 = New Panel()
        rbtnalt = New RadioButton()
        rbtnust = New RadioButton()
        btnExportToExcel = New Button()
        dtgvodemesiparisleri = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(dtgvodemesiparisleri, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(317, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.ScrollBars = ScrollBars.Vertical
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1142, 600)
        DataGridView1.TabIndex = 0
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        dtpStartDate.Location = New Point(46, 172)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(220, 29)
        dtpStartDate.TabIndex = 2
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        dtpEndDate.Location = New Point(46, 245)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(220, 29)
        dtpEndDate.TabIndex = 3
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"TÜMÜ", "NAKİT", "KREDİ KARTI"})
        ComboBox1.Location = New Point(46, 327)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(220, 29)
        ComboBox1.TabIndex = 4
        ' 
        ' txtPersonel
        ' 
        txtPersonel.BorderStyle = BorderStyle.FixedSingle
        txtPersonel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtPersonel.Location = New Point(46, 403)
        txtPersonel.Name = "txtPersonel"
        txtPersonel.Size = New Size(220, 29)
        txtPersonel.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(46, 538)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 21)
        Label1.TabIndex = 6
        Label1.Text = "Masa No:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(46, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 21)
        Label2.TabIndex = 7
        Label2.Text = "Başlangıç Tarihi:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(46, 295)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 21)
        Label3.TabIndex = 8
        Label3.Text = "Ödeme Türü:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(46, 371)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 21)
        Label4.TabIndex = 9
        Label4.Text = "Personel ID:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(46, 459)
        Label5.Name = "Label5"
        Label5.Size = New Size(144, 21)
        Label5.TabIndex = 11
        Label5.Text = "Müşteri Ad Soyad:"
        ' 
        ' txtMusteri
        ' 
        txtMusteri.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtMusteri.Location = New Point(46, 491)
        txtMusteri.Name = "txtMusteri"
        txtMusteri.Size = New Size(220, 29)
        txtMusteri.TabIndex = 10
        ' 
        ' btnFiltrele
        ' 
        btnFiltrele.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btnFiltrele.FlatStyle = FlatStyle.Flat
        btnFiltrele.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnFiltrele.Location = New Point(46, 650)
        btnFiltrele.Name = "btnFiltrele"
        btnFiltrele.Size = New Size(220, 46)
        btnFiltrele.TabIndex = 12
        btnFiltrele.Text = "FİLTRELE"
        btnFiltrele.UseVisualStyleBackColor = False
        ' 
        ' cbMasano
        ' 
        cbMasano.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        cbMasano.FormattingEnabled = True
        cbMasano.Items.AddRange(New Object() {"TÜMÜ", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35"})
        cbMasano.Location = New Point(46, 570)
        cbMasano.Name = "cbMasano"
        cbMasano.Size = New Size(220, 29)
        cbMasano.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(46, 213)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 21)
        Label6.TabIndex = 14
        Label6.Text = "Bitiş Tarihi:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkOrange
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(rbtnalt)
        Panel1.Controls.Add(rbtnust)
        Panel1.Controls.Add(btnExportToExcel)
        Panel1.Controls.Add(cbMasano)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtPersonel)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txtMusteri)
        Panel1.Controls.Add(dtpStartDate)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(btnFiltrele)
        Panel1.Controls.Add(dtpEndDate)
        Panel1.Controls.Add(Label4)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(317, 880)
        Panel1.TabIndex = 15
        ' 
        ' rbtnalt
        ' 
        rbtnalt.AutoSize = True
        rbtnalt.Location = New Point(176, 707)
        rbtnalt.Name = "rbtnalt"
        rbtnalt.Size = New Size(90, 19)
        rbtnalt.TabIndex = 17
        rbtnalt.TabStop = True
        rbtnalt.Text = "Alttaki Tablo"
        rbtnalt.UseVisualStyleBackColor = True
        ' 
        ' rbtnust
        ' 
        rbtnust.AutoSize = True
        rbtnust.Location = New Point(50, 707)
        rbtnust.Name = "rbtnust"
        rbtnust.Size = New Size(92, 19)
        rbtnust.TabIndex = 16
        rbtnust.TabStop = True
        rbtnust.Text = "Üstteki Tablo"
        rbtnust.UseVisualStyleBackColor = True
        ' 
        ' btnExportToExcel
        ' 
        btnExportToExcel.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btnExportToExcel.FlatStyle = FlatStyle.Flat
        btnExportToExcel.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnExportToExcel.Location = New Point(46, 732)
        btnExportToExcel.Name = "btnExportToExcel"
        btnExportToExcel.Size = New Size(220, 77)
        btnExportToExcel.TabIndex = 15
        btnExportToExcel.Text = "EXCEL OLARAK KAYDET"
        btnExportToExcel.UseVisualStyleBackColor = False
        ' 
        ' dtgvodemesiparisleri
        ' 
        dtgvodemesiparisleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgvodemesiparisleri.Dock = DockStyle.Bottom
        dtgvodemesiparisleri.Location = New Point(317, 600)
        dtgvodemesiparisleri.MaximumSize = New Size(0, 280)
        dtgvodemesiparisleri.Name = "dtgvodemesiparisleri"
        dtgvodemesiparisleri.RowTemplate.Height = 25
        dtgvodemesiparisleri.ScrollBars = ScrollBars.Vertical
        dtgvodemesiparisleri.Size = New Size(1142, 280)
        dtgvodemesiparisleri.TabIndex = 16
        ' 
        ' RaporForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ClientSize = New Size(1459, 880)
        Controls.Add(DataGridView1)
        Controls.Add(dtgvodemesiparisleri)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "RaporForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "RaporForm"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dtgvodemesiparisleri, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtPersonel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMusteri As TextBox
    Friend WithEvents btnFiltrele As Button
    Friend WithEvents cbMasano As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtgvodemesiparisleri As DataGridView
    Friend WithEvents btnExportToExcel As Button
    Friend WithEvents rbtnalt As RadioButton
    Friend WithEvents rbtnust As RadioButton
End Class
