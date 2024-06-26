<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PersonelForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnEkle = New Button()
        DataGridView1 = New DataGridView()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        btnGuncelle = New Button()
        btnSil = New Button()
        Panel1 = New Panel()
        TextBox5 = New TextBox()
        Label6 = New Label()
        Panel2 = New Panel()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnEkle
        ' 
        btnEkle.BackColor = SystemColors.Window
        btnEkle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnEkle.Location = New Point(88, 448)
        btnEkle.Name = "btnEkle"
        btnEkle.Size = New Size(322, 43)
        btnEkle.TabIndex = 0
        btnEkle.Text = "EKLE"
        btnEkle.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.ScrollBars = ScrollBars.Vertical
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1138, 882)
        DataGridView1.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(216, 184)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(194, 33)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(216, 223)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(194, 33)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox3.Location = New Point(216, 262)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(194, 33)
        TextBox3.TabIndex = 4
        ' 
        ' TextBox4
        ' 
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox4.Location = New Point(216, 301)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(194, 33)
        TextBox4.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(166, 186)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 25)
        Label1.TabIndex = 8
        Label1.Text = "AD:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(130, 225)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 25)
        Label2.TabIndex = 9
        Label2.Text = "SOYAD:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(90, 264)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 25)
        Label3.TabIndex = 10
        Label3.Text = "USERNAME:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(88, 303)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 25)
        Label4.TabIndex = 11
        Label4.Text = "PASSWORD:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(142, 384)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 25)
        Label5.TabIndex = 12
        Label5.Text = "YETKİ:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"ADMİN", "PERSONEL"})
        ComboBox1.Location = New Point(216, 381)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(194, 33)
        ComboBox1.TabIndex = 13
        ' 
        ' btnGuncelle
        ' 
        btnGuncelle.BackColor = SystemColors.Window
        btnGuncelle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnGuncelle.Location = New Point(88, 497)
        btnGuncelle.Name = "btnGuncelle"
        btnGuncelle.Size = New Size(322, 43)
        btnGuncelle.TabIndex = 14
        btnGuncelle.Text = "GÜNCELLE"
        btnGuncelle.UseVisualStyleBackColor = False
        ' 
        ' btnSil
        ' 
        btnSil.BackColor = SystemColors.Window
        btnSil.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnSil.Location = New Point(88, 546)
        btnSil.Name = "btnSil"
        btnSil.Size = New Size(322, 43)
        btnSil.TabIndex = 15
        btnSil.Text = "SİL"
        btnSil.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(btnSil)
        Panel1.Controls.Add(btnEkle)
        Panel1.Controls.Add(btnGuncelle)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(495, 882)
        Panel1.TabIndex = 16
        ' 
        ' TextBox5
        ' 
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox5.Location = New Point(216, 340)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(194, 33)
        TextBox5.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(136, 342)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 25)
        Label6.TabIndex = 17
        Label6.Text = "EMAİL:"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.IndianRed
        Panel2.Controls.Add(DataGridView1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(495, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1138, 882)
        Panel2.TabIndex = 17
        ' 
        ' PersonelForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1633, 882)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        HelpButton = True
        MinimizeBox = False
        Name = "PersonelForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnEkle As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnGuncelle As Button
    Friend WithEvents btnSil As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
End Class
