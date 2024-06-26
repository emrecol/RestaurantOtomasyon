Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class kayitform
    Private databasebaglanti As DatabaseBaglanti
    Private Sub kayitform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=DESKTOP-59UNT62\SQLEXPRESS;Initial Catalog=db_Restaurant;Integrated Security=True"
        databasebaglanti = New DatabaseBaglanti(connectionString)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim kullaniciform As New KullaniciGiris()
        kullaniciform.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As SqlConnection = databasebaglanti.OpenConnection()

        If txTAd.Text = "" AndAlso
       txtSoyad.Text = "" AndAlso
       txtUsername.Text = "" AndAlso
       txtPassword.Text = "" AndAlso
       txtEmail.Text = "" Then

            MessageBox.Show("Lütfen tüm alanları doldurun!")

        Else

            Dim value1 As String = txTAd.Text
            Dim value2 As String = txtSoyad.Text
            Dim value3 As String = txtUsername.Text
            Dim value4 As String = txtPassword.Text
            Dim value5 As String = txtEmail.Text
            Dim yetki As String = "PR"

            Dim query As String = "INSERT INTO Personel (per_ad, per_soyad, per_username, per_password, per_email, per_yetki) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Yetki)"

            Dim command As New SqlCommand(query, connection)

            command.Parameters.AddWithValue("@Value1", value1)
            command.Parameters.AddWithValue("@Value2", value2)
            command.Parameters.AddWithValue("@Value3", value3)
            command.Parameters.AddWithValue("@Value4", value4)
            command.Parameters.AddWithValue("@Value5", value5)
            command.Parameters.AddWithValue("@Yetki", yetki)

            ' Sorguyu çalıştırın
            command.ExecuteNonQuery()

            ' Kaynakları temizleyin
            command.Dispose()
            databasebaglanti.CloseConnection()

            MessageBox.Show("Kullanıcı kaydı oluşturuldu.")

            txTAd.Clear()
            txtSoyad.Clear()
            txtUsername.Clear()
            txtPassword.Clear()
            txtEmail.Clear()


        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class