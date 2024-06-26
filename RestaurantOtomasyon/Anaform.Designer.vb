<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Anaform
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Anaform))
        ToolStrip1 = New ToolStrip()
        tsbtnPersonelForm = New ToolStripButton()
        tsbtnAdminForm = New ToolStripButton()
        tsbtnSiparis = New ToolStripButton()
        tsbtnRaporForm = New ToolStripButton()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        ToolStrip1.GripStyle = ToolStripGripStyle.Hidden
        ToolStrip1.Items.AddRange(New ToolStripItem() {tsbtnPersonelForm, tsbtnAdminForm, tsbtnSiparis, tsbtnRaporForm})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Padding = New Padding(2)
        ToolStrip1.ShowItemToolTips = False
        ToolStrip1.Size = New Size(1367, 33)
        ToolStrip1.TabIndex = 0
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' tsbtnPersonelForm
        ' 
        tsbtnPersonelForm.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbtnPersonelForm.Image = CType(resources.GetObject("tsbtnPersonelForm.Image"), Image)
        tsbtnPersonelForm.ImageTransparentColor = Color.Magenta
        tsbtnPersonelForm.Margin = New Padding(0)
        tsbtnPersonelForm.Name = "tsbtnPersonelForm"
        tsbtnPersonelForm.Padding = New Padding(0, 0, 0, 10)
        tsbtnPersonelForm.Size = New Size(67, 29)
        tsbtnPersonelForm.Text = "PERSONEL"
        ' 
        ' tsbtnAdminForm
        ' 
        tsbtnAdminForm.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbtnAdminForm.Image = CType(resources.GetObject("tsbtnAdminForm.Image"), Image)
        tsbtnAdminForm.ImageTransparentColor = Color.Magenta
        tsbtnAdminForm.Margin = New Padding(0)
        tsbtnAdminForm.Name = "tsbtnAdminForm"
        tsbtnAdminForm.Padding = New Padding(0, 0, 0, 10)
        tsbtnAdminForm.Size = New Size(50, 29)
        tsbtnAdminForm.Text = "ADMİN"
        ' 
        ' tsbtnSiparis
        ' 
        tsbtnSiparis.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbtnSiparis.Image = CType(resources.GetObject("tsbtnSiparis.Image"), Image)
        tsbtnSiparis.ImageTransparentColor = Color.Magenta
        tsbtnSiparis.Margin = New Padding(0)
        tsbtnSiparis.Name = "tsbtnSiparis"
        tsbtnSiparis.Padding = New Padding(0, 0, 0, 10)
        tsbtnSiparis.Size = New Size(50, 29)
        tsbtnSiparis.Text = "SİPARİŞ"
        ' 
        ' tsbtnRaporForm
        ' 
        tsbtnRaporForm.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbtnRaporForm.Image = CType(resources.GetObject("tsbtnRaporForm.Image"), Image)
        tsbtnRaporForm.ImageTransparentColor = Color.Magenta
        tsbtnRaporForm.Margin = New Padding(0)
        tsbtnRaporForm.Name = "tsbtnRaporForm"
        tsbtnRaporForm.Padding = New Padding(0, 0, 0, 10)
        tsbtnRaporForm.Size = New Size(82, 29)
        tsbtnRaporForm.Text = "RAPORLAMA"
        ' 
        ' Anaform
        ' 
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(1367, 813)
        Controls.Add(ToolStrip1)
        Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        IsMdiContainer = True
        Name = "Anaform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RESTAURANT OTOMASYON"
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents tsbtnPersonelForm As ToolStripButton
    Friend WithEvents tsbtnAdminForm As ToolStripButton
    Friend WithEvents tsbtnSiparis As ToolStripButton
    Friend WithEvents tsbtnRaporForm As ToolStripButton
    Public WithEvents ToolStrip1 As ToolStrip
End Class
