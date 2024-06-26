<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KullaniciGiris
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(KullaniciGiris))
        Button1 = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Panel2 = New Panel()
        PictureBox4 = New PictureBox()
        LinkLabel1 = New LinkLabel()
        LinkLabel2 = New LinkLabel()
        Label3 = New Label()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(27, 328)
        Button1.Name = "Button1"
        Button1.Size = New Size(236, 40)
        Button1.TabIndex = 2
        Button1.Text = "GİRİŞ"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.White
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtPassword.Location = New Point(58, 267)
        txtPassword.MaxLength = 6
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(205, 20)
        txtPassword.TabIndex = 1
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.White
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtUsername.Location = New Point(58, 201)
        txtUsername.MaxLength = 6
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(205, 24)
        txtUsername.TabIndex = 0
        txtUsername.Tag = ""
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(103, 39)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(87, 71)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Location = New Point(27, 232)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(236, 1)
        Panel1.TabIndex = 7
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(27, 201)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(25, 25)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(27, 267)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(25, 25)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.Location = New Point(27, 298)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(236, 1)
        Panel2.TabIndex = 9
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(263, 4)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(25, 25)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.DimGray
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LinkLabel1.LinkColor = Color.Black
        LinkLabel1.Location = New Point(147, 302)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(116, 17)
        LinkLabel1.TabIndex = 12
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Şifremi unuttum..."
        LinkLabel1.VisitedLinkColor = Color.Black
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.ActiveLinkColor = Color.DimGray
        LinkLabel2.AutoSize = True
        LinkLabel2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LinkLabel2.LinkColor = Color.Black
        LinkLabel2.Location = New Point(116, 371)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(55, 17)
        LinkLabel2.TabIndex = 13
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Kayıt Ol"
        LinkLabel2.VisitedLinkColor = Color.Black
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(47, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(199, 36)
        Label3.TabIndex = 6
        Label3.Text = "RESTAURANT"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bauhaus 93", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(60, 149)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 30)
        Label1.TabIndex = 14
        Label1.Text = "OTOMASYON"
        ' 
        ' KullaniciGiris
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ClientSize = New Size(292, 447)
        Controls.Add(Label1)
        Controls.Add(LinkLabel2)
        Controls.Add(LinkLabel1)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(Panel2)
        Controls.Add(PictureBox2)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(txtUsername)
        Controls.Add(Button1)
        Controls.Add(txtPassword)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "KullaniciGiris"
        StartPosition = FormStartPosition.CenterScreen
        Text = "KullaniciGiris"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Public WithEvents txtUsername As TextBox
End Class
