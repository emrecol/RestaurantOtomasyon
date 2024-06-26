Public Class Anaform
    Public Property Username As String

    Private Sub tsbtnPersonelForm_Click(sender As Object, e As EventArgs) Handles tsbtnPersonelForm.Click
        CloseOpenForms()
        Dim personelfrm As New PersonelForm()
        personelfrm.MdiParent = Me
        personelfrm.Dock = DockStyle.Fill
        personelfrm.Show()
    End Sub
    Private Sub Anaform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim girisform As New KullaniciGiris()
    End Sub

    Private Sub tsbtnSiparis_Click(sender As Object, e As EventArgs) Handles tsbtnSiparis.Click
        CloseOpenForms()
        Dim siparisfrm As New SiparisForm()
        siparisfrm.Username = Me.Username
        siparisfrm.MdiParent = Me
        siparisfrm.Dock = DockStyle.Fill
        siparisfrm.Show()


    End Sub

    Private Sub tsbtnAdminForm_Click(sender As Object, e As EventArgs) Handles tsbtnAdminForm.Click
        CloseOpenForms()
        Dim AdminFrm As New AdminForm()
        AdminFrm.MdiParent = Me
        AdminFrm.Dock = DockStyle.Fill
        AdminFrm.Show()

    End Sub

    Private Sub Anaform_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
    Private Sub CloseOpenForms()
        ' Mevcut açık formları kapat
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next
    End Sub

    Private Sub tsbtnRaporForm_Click(sender As Object, e As EventArgs) Handles tsbtnRaporForm.Click
        CloseOpenForms()
        Dim raporfrm As New RaporForm()
        raporfrm.MdiParent = Me
        raporfrm.Dock = DockStyle.Fill
        raporfrm.Show()
    End Sub
End Class