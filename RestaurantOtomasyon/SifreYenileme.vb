Imports System.Net
Imports System.Net.Mail
Imports System.Random
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SifreYenileme
    Private databasebaglanti As DatabaseBaglanti


    Private Function RandomSayi() As String
        Dim rnd As New Random()
        Dim number As Integer = rnd.Next(100000, 999999) ' Rastgele 6 karakterli sayı oluştur
        Return number.ToString()
    End Function

    Private Sub EmailGonder(emailAddress As String, randomNumber As String)
        Dim fromAddress As New MailAddress("kaderinbu16@outlook.com", "Restaurant Otomasyon")
        Dim toAddress As New MailAddress(emailAddress)
        Dim smtp As New SmtpClient()
        smtp.Host = "smtp-mail.outlook.com"
        smtp.Port = 587
        smtp.EnableSsl = True
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network
        smtp.Credentials = New NetworkCredential("youremailadress", "youremailpassword")
        Dim message As New MailMessage(fromAddress, toAddress)
        message.Subject = "Doğrulama Kodu"
        message.Body = "Doğrulama kodunuz: " & randomNumber
        smtp.Send(message)
    End Sub

    Private Sub SifreYenileme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=DESKTOP-59UNT62\SQLEXPRESS;Initial Catalog=db_Restaurant;Integrated Security=True"
        databasebaglanti = New DatabaseBaglanti(connectionString)
    End Sub

    Private Sub btnGonder_Click_1(sender As Object, e As EventArgs) Handles btnGonder.Click
        Dim connection As SqlConnection = databasebaglanti.OpenConnection()

        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MessageBox.Show("Lütfen kullanıcı adı ve parolayı girin!")
            txtUsername.Clear()
            txtEmail.Clear()
            Return ' Fonksiyondan çıkın, işlemi durdurun
        End If

        ' Kullanıcı adı ve email alın
        Dim username As String = txtUsername.Text
        Dim email As String = txtEmail.Text

        Dim query As String = "SELECT COUNT(*) FROM Personel WHERE per_username = @Username AND per_email = @Email"

        Using command As New SqlCommand(query, connection)
            ' Parametreleri ekleyin
            command.Parameters.AddWithValue("@Username", username)
            command.Parameters.AddWithValue("@Email", email)
            ' Bağlantıyı açın
            ' Sorguyu çalıştırın ve sonucu alın
            Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

            ' Kullanıcı doğrulamasını kontrol edin
            If result > 0 Then
                ' Rastgele 6 karakterli sayı oluştur
                Dim randomnumber As String = RandomSayi()
                ' E-posta gönder
                EmailGonder(txtEmail.Text, randomnumber)

                Dim usernamem As String = txtUsername.Text

                Dim yenisifre As String = "UPDATE Personel SET per_password = @Randomnumber WHERE per_username = @Usernamem"

                Dim komut As New SqlCommand(yenisifre, connection)

                komut.Parameters.AddWithValue("@Randomnumber", randomnumber)
                komut.Parameters.AddWithValue("@Usernamem", usernamem)
                ' Sorguyu çalıştırın
                komut.ExecuteNonQuery()

                ' Kaynakları temizleyin
                komut.Dispose()
                databasebaglanti.CloseConnection()

                MessageBox.Show("E-posta gönderildi. Lütfen e-postanızı kontrol edin.")
            Else
                MessageBox.Show("Kullanıcı adı veya email adresi yanlış!")
                txtUsername.Clear()
                txtEmail.Clear()
            End If
        End Using

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim kulGirisFrom As New KullaniciGiris()
        KullaniciGiris.Show()
        Me.Hide()
    End Sub
End Class