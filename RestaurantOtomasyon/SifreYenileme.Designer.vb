<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SifreYenileme
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(SifreYenileme))
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        txtUsername = New TextBox()
        btnGonder = New Button()
        txtEmail = New TextBox()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(262, 5)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(25, 25)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 23
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(26, 268)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(25, 25)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 22
        PictureBox3.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.Location = New Point(26, 299)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(236, 1)
        Panel2.TabIndex = 21
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(26, 202)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(25, 25)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 20
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Location = New Point(26, 233)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(236, 1)
        Panel1.TabIndex = 19
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(3, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(287, 36)
        Label3.TabIndex = 18
        Label3.Text = "ŞİFRE YENİLEME"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(102, 48)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(87, 71)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.White
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtUsername.Location = New Point(57, 202)
        txtUsername.MaxLength = 6
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(205, 24)
        txtUsername.TabIndex = 14
        txtUsername.Tag = ""
        ' 
        ' btnGonder
        ' 
        btnGonder.BackColor = Color.Black
        btnGonder.FlatStyle = FlatStyle.Flat
        btnGonder.Font = New Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnGonder.ForeColor = Color.White
        btnGonder.Location = New Point(26, 329)
        btnGonder.Name = "btnGonder"
        btnGonder.Size = New Size(236, 40)
        btnGonder.TabIndex = 16
        btnGonder.Text = "GÖNDER"
        btnGonder.UseVisualStyleBackColor = False
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.White
        txtEmail.BorderStyle = BorderStyle.None
        txtEmail.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtEmail.Location = New Point(57, 268)
        txtEmail.MaxLength = 40
        txtEmail.Multiline = True
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(205, 24)
        txtEmail.TabIndex = 15
        txtEmail.UseSystemPasswordChar = True
        ' 
        ' SifreYenileme
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ClientSize = New Size(292, 447)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(Panel2)
        Controls.Add(PictureBox2)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(txtUsername)
        Controls.Add(btnGonder)
        Controls.Add(txtEmail)
        FormBorderStyle = FormBorderStyle.None
        Name = "SifreYenileme"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SifreYenileme"
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnGonder As Button
    Friend WithEvents txtEmail As TextBox
End Class
