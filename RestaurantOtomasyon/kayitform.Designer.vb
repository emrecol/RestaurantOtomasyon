<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kayitform
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(kayitform))
        PictureBox4 = New PictureBox()
        Panel2 = New Panel()
        Panel1 = New Panel()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        txTAd = New TextBox()
        Button1 = New Button()
        txtSoyad = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Panel3 = New Panel()
        txtUsername = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Panel4 = New Panel()
        txtPassword = New TextBox()
        Label6 = New Label()
        Panel5 = New Panel()
        txtEmail = New TextBox()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(364, 4)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(25, 25)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 23
        PictureBox4.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.Location = New Point(44, 237)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(335, 1)
        Panel2.TabIndex = 21
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Location = New Point(69, 200)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(310, 1)
        Panel1.TabIndex = 19
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(120, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(149, 36)
        Label3.TabIndex = 18
        Label3.Text = "KAYIT OL"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(153, 47)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(87, 71)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' txTAd
        ' 
        txTAd.BackColor = Color.White
        txTAd.BorderStyle = BorderStyle.None
        txTAd.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txTAd.Location = New Point(115, 170)
        txTAd.MaxLength = 20
        txTAd.Multiline = True
        txTAd.Name = "txTAd"
        txTAd.Size = New Size(264, 24)
        txTAd.TabIndex = 0
        txTAd.Tag = ""
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(14, 367)
        Button1.Name = "Button1"
        Button1.Size = New Size(365, 40)
        Button1.TabIndex = 5
        Button1.Text = "ONAYLA"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtSoyad
        ' 
        txtSoyad.BackColor = Color.White
        txtSoyad.BorderStyle = BorderStyle.None
        txtSoyad.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtSoyad.Location = New Point(115, 207)
        txtSoyad.MaxLength = 25
        txtSoyad.Multiline = True
        txtSoyad.Name = "txtSoyad"
        txtSoyad.Size = New Size(264, 24)
        txtSoyad.TabIndex = 1
        txtSoyad.UseSystemPasswordChar = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(73, 173)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 21)
        Label1.TabIndex = 26
        Label1.Text = "AD:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(44, 210)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 21)
        Label2.TabIndex = 27
        Label2.Text = "SOYAD:"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Black
        Panel3.Location = New Point(14, 274)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(365, 1)
        Panel3.TabIndex = 29
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.White
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtUsername.Location = New Point(115, 244)
        txtUsername.MaxLength = 6
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(264, 24)
        txtUsername.TabIndex = 2
        txtUsername.UseSystemPasswordChar = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(10, 247)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 21)
        Label4.TabIndex = 30
        Label4.Text = "USERNAME:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(10, 284)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 21)
        Label5.TabIndex = 33
        Label5.Text = "PASSWORD:"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Black
        Panel4.Location = New Point(14, 311)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(365, 1)
        Panel4.TabIndex = 32
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.White
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtPassword.Location = New Point(115, 281)
        txtPassword.MaxLength = 6
        txtPassword.Multiline = True
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(264, 24)
        txtPassword.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(48, 321)
        Label6.Name = "Label6"
        Label6.Size = New Size(61, 21)
        Label6.TabIndex = 36
        Label6.Text = "EMAİL:"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Black
        Panel5.Location = New Point(49, 348)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(330, 1)
        Panel5.TabIndex = 35
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.White
        txtEmail.BorderStyle = BorderStyle.None
        txtEmail.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtEmail.Location = New Point(115, 318)
        txtEmail.MaxLength = 40
        txtEmail.Multiline = True
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(264, 24)
        txtEmail.TabIndex = 4
        txtEmail.UseSystemPasswordChar = True
        ' 
        ' kayitform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ClientSize = New Size(393, 447)
        Controls.Add(Label6)
        Controls.Add(Panel5)
        Controls.Add(txtEmail)
        Controls.Add(Label5)
        Controls.Add(Panel4)
        Controls.Add(txtPassword)
        Controls.Add(Label4)
        Controls.Add(Panel3)
        Controls.Add(txtUsername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox4)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(txTAd)
        Controls.Add(Button1)
        Controls.Add(txtSoyad)
        FormBorderStyle = FormBorderStyle.None
        Name = "kayitform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "kayitform"
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txTAd As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtSoyad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtEmail As TextBox
End Class
