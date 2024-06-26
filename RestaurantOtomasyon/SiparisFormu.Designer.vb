<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OdemeForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(OdemeForm))
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        Label1 = New Label()
        lbltutar = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(13, 90)
        DataGridView1.Margin = New Padding(4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(735, 443)
        DataGridView1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(228, 635)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(315, 63)
        Button1.TabIndex = 1
        Button1.Text = "ÖDEME AL"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(339, 602)
        RadioButton1.Margin = New Padding(4)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(75, 25)
        RadioButton1.TabIndex = 2
        RadioButton1.TabStop = True
        RadioButton1.Text = "NAKİT"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(422, 602)
        RadioButton2.Margin = New Padding(4)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(121, 25)
        RadioButton2.TabIndex = 3
        RadioButton2.TabStop = True
        RadioButton2.Text = "KREDİ KARTI"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(316, 558)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 21)
        Label1.TabIndex = 4
        Label1.Text = "Tutar: "
        ' 
        ' lbltutar
        ' 
        lbltutar.AutoSize = True
        lbltutar.Location = New Point(380, 558)
        lbltutar.Margin = New Padding(4, 0, 4, 0)
        lbltutar.Name = "lbltutar"
        lbltutar.Size = New Size(58, 21)
        lbltutar.TabIndex = 5
        lbltutar.Text = "Label2"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(185, 42)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(148, 21)
        Label2.TabIndex = 6
        Label2.Text = "Müşteri Ad Soyad: "
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(341, 39)
        TextBox1.Margin = New Padding(4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(201, 29)
        TextBox1.TabIndex = 7
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(718, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(35, 35)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(228, 604)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 21)
        Label3.TabIndex = 9
        Label3.Text = "Ödeme Türü:"
        ' 
        ' OdemeForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        ClientSize = New Size(758, 727)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(lbltutar)
        Controls.Add(Label1)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "OdemeForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ÖDEME"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lbltutar As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
