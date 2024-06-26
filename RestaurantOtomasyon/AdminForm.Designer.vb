<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        DataGridView1 = New DataGridView()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnEkle = New Button()
        btnGuncelle = New Button()
        btnSil = New Button()
        ComboBox1 = New ComboBox()
        btnCorba = New Button()
        btnArasicak = New Button()
        btnAnayemek = New Button()
        btnTatli = New Button()
        btnİcecek = New Button()
        Panel1 = New Panel()
        Label5 = New Label()
        rbtnartizam = New RadioButton()
        rbtneksizam = New RadioButton()
        btnZam = New Button()
        txtOran = New TextBox()
        Label4 = New Label()
        Panel2 = New Panel()
        Panel4 = New Panel()
        Panel3 = New Panel()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = SystemColors.Window
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(804, 768)
        DataGridView1.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(247, 191)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(224, 29)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(247, 246)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(224, 29)
        TextBox2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(113, 196)
        Label1.Margin = New Padding(3)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 24)
        Label1.TabIndex = 4
        Label1.Text = "URUN AD:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(80, 249)
        Label2.Margin = New Padding(3)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 24)
        Label2.TabIndex = 5
        Label2.Text = "URUN FİYAT:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(83, 303)
        Label3.Margin = New Padding(3)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 24)
        Label3.TabIndex = 6
        Label3.Text = "URUN TÜRÜ:"
        ' 
        ' btnEkle
        ' 
        btnEkle.BackColor = Color.White
        btnEkle.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnEkle.Location = New Point(109, 368)
        btnEkle.Name = "btnEkle"
        btnEkle.Size = New Size(362, 43)
        btnEkle.TabIndex = 7
        btnEkle.Text = "EKLE"
        btnEkle.UseVisualStyleBackColor = False
        ' 
        ' btnGuncelle
        ' 
        btnGuncelle.BackColor = Color.White
        btnGuncelle.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnGuncelle.Location = New Point(109, 427)
        btnGuncelle.Name = "btnGuncelle"
        btnGuncelle.Size = New Size(362, 43)
        btnGuncelle.TabIndex = 8
        btnGuncelle.Text = "GÜNCELLE"
        btnGuncelle.UseVisualStyleBackColor = False
        ' 
        ' btnSil
        ' 
        btnSil.BackColor = Color.White
        btnSil.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnSil.Location = New Point(109, 486)
        btnSil.Name = "btnSil"
        btnSil.Size = New Size(362, 43)
        btnSil.TabIndex = 9
        btnSil.Text = "SİL"
        btnSil.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"ÇORBA", "ANA YEMEK", "ARA SICAK", "TATLI", "İÇECEK"})
        ComboBox1.Location = New Point(247, 300)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(224, 32)
        ComboBox1.TabIndex = 10
        ' 
        ' btnCorba
        ' 
        btnCorba.AutoSize = True
        btnCorba.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnCorba.Location = New Point(31, 12)
        btnCorba.Name = "btnCorba"
        btnCorba.Size = New Size(144, 50)
        btnCorba.TabIndex = 11
        btnCorba.Text = "ÇORBA"
        btnCorba.UseVisualStyleBackColor = True
        ' 
        ' btnArasicak
        ' 
        btnArasicak.AutoSize = True
        btnArasicak.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnArasicak.Location = New Point(181, 12)
        btnArasicak.Name = "btnArasicak"
        btnArasicak.Size = New Size(144, 50)
        btnArasicak.TabIndex = 12
        btnArasicak.Text = "ARA SICAK"
        btnArasicak.UseVisualStyleBackColor = True
        ' 
        ' btnAnayemek
        ' 
        btnAnayemek.AutoSize = True
        btnAnayemek.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnAnayemek.Location = New Point(331, 12)
        btnAnayemek.Name = "btnAnayemek"
        btnAnayemek.Size = New Size(144, 50)
        btnAnayemek.TabIndex = 14
        btnAnayemek.Text = "ANA YEMEK"
        btnAnayemek.UseVisualStyleBackColor = True
        ' 
        ' btnTatli
        ' 
        btnTatli.AutoSize = True
        btnTatli.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnTatli.Location = New Point(481, 12)
        btnTatli.Name = "btnTatli"
        btnTatli.Size = New Size(144, 50)
        btnTatli.TabIndex = 13
        btnTatli.Text = "TATLI"
        btnTatli.UseVisualStyleBackColor = True
        ' 
        ' btnİcecek
        ' 
        btnİcecek.AutoSize = True
        btnİcecek.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnİcecek.Location = New Point(631, 12)
        btnİcecek.Name = "btnİcecek"
        btnİcecek.Size = New Size(144, 50)
        btnİcecek.TabIndex = 16
        btnİcecek.Text = "İÇECEK"
        btnİcecek.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDark
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(rbtnartizam)
        Panel1.Controls.Add(rbtneksizam)
        Panel1.Controls.Add(btnZam)
        Panel1.Controls.Add(txtOran)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(btnEkle)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(btnGuncelle)
        Panel1.Controls.Add(btnSil)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(579, 852)
        Panel1.TabIndex = 17
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(430, 629)
        Label5.Name = "Label5"
        Label5.Size = New Size(31, 30)
        Label5.TabIndex = 16
        Label5.Text = "%"
        ' 
        ' rbtnartizam
        ' 
        rbtnartizam.AutoSize = True
        rbtnartizam.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        rbtnartizam.Location = New Point(278, 616)
        rbtnartizam.Name = "rbtnartizam"
        rbtnartizam.Size = New Size(40, 28)
        rbtnartizam.TabIndex = 15
        rbtnartizam.TabStop = True
        rbtnartizam.Text = "+"
        rbtnartizam.UseVisualStyleBackColor = True
        ' 
        ' rbtneksizam
        ' 
        rbtneksizam.AutoSize = True
        rbtneksizam.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        rbtneksizam.Location = New Point(278, 639)
        rbtneksizam.Name = "rbtneksizam"
        rbtneksizam.Size = New Size(35, 28)
        rbtneksizam.TabIndex = 14
        rbtneksizam.TabStop = True
        rbtneksizam.Text = "-"
        rbtneksizam.UseVisualStyleBackColor = True
        ' 
        ' btnZam
        ' 
        btnZam.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnZam.Location = New Point(236, 678)
        btnZam.Name = "btnZam"
        btnZam.Size = New Size(146, 37)
        btnZam.TabIndex = 13
        btnZam.Text = "UYGULA"
        btnZam.UseVisualStyleBackColor = True
        ' 
        ' txtOran
        ' 
        txtOran.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtOran.Location = New Point(319, 629)
        txtOran.Name = "txtOran"
        txtOran.Size = New Size(105, 29)
        txtOran.TabIndex = 12
        txtOran.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(105, 630)
        Label4.Name = "Label4"
        Label4.Size = New Size(146, 24)
        Label4.TabIndex = 11
        Label4.Text = "Fiyat Değişimi:"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel3)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(579, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(804, 852)
        Panel2.TabIndex = 16
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(DataGridView1)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(0, 84)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(804, 768)
        Panel4.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(btnİcecek)
        Panel3.Controls.Add(btnCorba)
        Panel3.Controls.Add(btnArasicak)
        Panel3.Controls.Add(btnAnayemek)
        Panel3.Controls.Add(btnTatli)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(804, 84)
        Panel3.TabIndex = 1
        ' 
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1383, 852)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        HelpButton = True
        Name = "AdminForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "AdminForm"
        TopMost = True
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEkle As Button
    Friend WithEvents btnGuncelle As Button
    Friend WithEvents btnSil As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnCorba As Button
    Friend WithEvents btnArasicak As Button
    Friend WithEvents btnAnayemek As Button
    Friend WithEvents btnTatli As Button
    Friend WithEvents btnİcecek As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbtnartizam As RadioButton
    Friend WithEvents rbtneksizam As RadioButton
    Friend WithEvents btnZam As Button
    Friend WithEvents txtOran As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
End Class
