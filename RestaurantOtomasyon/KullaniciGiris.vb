Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class KullaniciGiris
    Private databasebaglanti As DatabaseBaglanti

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As SqlConnection = databasebaglanti.OpenConnection()
        ' Kullanıcı adı ve parola alanlarını kontrol edin
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Lütfen kullanıcı adı ve parolayı girin!")
            txtUsername.Text = ""
            txtPassword.Text = ""
            Return ' Fonksiyondan çıkın, işlemi durdurun
        End If

        ' Kullanıcı adı ve parolayı alın
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' Veritabanı bağlantısını oluşturun
        ' SQL sorgusunu oluşturun
        Dim query As String = "SELECT COUNT(*) FROM Personel WHERE per_username = @Username AND per_password = @Password"

        ' SqlCommand'u oluşturun
        Using command As New SqlCommand(query, connection)
            ' Parametreleri ekleyin
            command.Parameters.AddWithValue("@Username", username)
            command.Parameters.AddWithValue("@Password", password)
            ' Bağlantıyı açın
            ' Sorguyu çalıştırın ve sonucu alın
            Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

            ' Kullanıcı doğrulamasını kontrol edin
            If result > 0 Then

                'MessageBox.Show("Giriş başarılı!", "HOŞGELDİNİZ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim queryYetki As String = "SELECT per_yetki FROM Personel WHERE per_username = @Username AND per_password = @Password"
                Using commandYetki As New SqlCommand(queryYetki, connection)
                    commandYetki.Parameters.AddWithValue("@Username", username)
                    commandYetki.Parameters.AddWithValue("@Password", password)
                    Dim userType As String = Convert.ToString(commandYetki.ExecuteScalar())
                    ' Parametreleri ekleyin
                    If userType = "AD" Then
                        Dim userid As String = txtUsername.Text
                        Dim anafrm As New Anaform()
                        anafrm.Username = username
                        anafrm.tsbtnAdminForm.Visible = True
                        anafrm.tsbtnAdminForm.Visible = True
                        anafrm.tsbtnPersonelForm.Visible = True
                        anafrm.tsbtnRaporForm.Visible = True
                        anafrm.Show()
                        Me.Hide()
                    ElseIf userType = "PR" Then
                        Dim anafrm As New Anaform()
                        anafrm.tsbtnAdminForm.Visible = False
                        anafrm.tsbtnPersonelForm.Visible = False
                        anafrm.tsbtnRaporForm.Visible = False
                        anafrm.Show()
                        Me.Hide()
                    End If
                End Using

            Else
                MessageBox.Show("Kullanıcı adı veya parola yanlış!")
                txtUsername.Clear()
                txtPassword.Clear()
            End If
        End Using
    End Sub

    Private Sub KullaniciGiris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=DESKTOP-59UNT62\SQLEXPRESS;Initial Catalog=db_Restaurant;Integrated Security=True"
        databasebaglanti = New DatabaseBaglanti(connectionString)
    End Sub


    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Application.Exit()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim sifreYenileform As New SifreYenileme()
        sifreYenileform.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim kayitform As New kayitform()
        kayitform.Show()
        Me.Hide()
    End Sub
End Class