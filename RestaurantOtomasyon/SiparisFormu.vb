Imports System.Reflection.Emit

Public Class OdemeForm

    Dim connectionString As String = "Data Source=DESKTOP-59UNT62\SQLEXPRESS;Initial Catalog=db_Restaurant;Integrated Security=True"
    Dim connection As SqlConnection
    Private databasebaglanti As DatabaseBaglanti

    Public Property masanumara As Integer
    Public Property perno As String

    Dim odemeturu As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            odemeturu = "Nakit"
        ElseIf RadioButton2.Checked Then
            odemeturu = "Kredi Kartı"
        End If
        If String.IsNullOrEmpty(odemeturu) Then
            MessageBox.Show("Lütfen bir ödeme türü seçin.")
            Return
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO Odeme (musteriadsoyad, perid, OdemeTuru, OdemeTutar, masaNo,OdemeTarih) VALUES (@musadsoyad, @perID, @odemeturu, @odemetutar, @masanumara, GETDATE())"
                Dim query1 As String = "UPDATE Masa SET MasaDurum = 'bos', MasaBasTarih = NULL WHERE MasaNo = @masanumara"

                Using command As New SqlCommand(query, connection)

                    'Üçüncü TextBox değeri
                    If TextBox1.Text = "" Then
                        command.Parameters.AddWithValue("@musadsoyad", "Müşteri")
                    Else
                        command.Parameters.AddWithValue("@musadsoyad", TextBox1.Text)
                    End If

                    'command.Parameters.AddWithValue("@musadsoyad", TextBox1.Text)
                    command.Parameters.AddWithValue("@perID", perno)
                    command.Parameters.AddWithValue("@odemeturu", odemeturu)
                    command.Parameters.AddWithValue("@odemetutar", lbltutar.Text)
                    command.Parameters.AddWithValue("@masanumara", masanumara)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        'MessageBox.Show("Masa durumu başarıyla güncellendi.")
                    Else
                        MessageBox.Show("Masa durumu güncellenirken bir hata oluştu.")
                    End If
                End Using
                Using command1 As New SqlCommand(query1, connection)
                    command1.Parameters.AddWithValue("@masanumara", masanumara)
                    Dim rowsAffected3 As Integer = command1.ExecuteNonQuery()
                    If rowsAffected3 > 0 Then
                        'MessageBox.Show("Masa durumu başarıyla güncellendi.")
                    Else
                        MessageBox.Show("Masa durumu güncellenirken bir hata oluştu.")
                    End If
                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show("Error executing SQL query: " & ex.Message)
        End Try

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query2 As String = "SELECT TOP 1 OdemeId FROM Odeme ORDER BY OdemeTarih DESC;"
                Dim query3 As String = "UPDATE Siparis SET siparisdurum = 'pasif', odemeID = @odemeid where masano = @masanumara and siparisdurum = 'aktif'"
                Dim veri As Integer = 0 ' varsayılan olarak sıfır olarak başlatıyoruz
                Using command2 As New SqlCommand(query2, connection)
                    Using reader As SqlDataReader = command2.ExecuteReader()
                        If reader.HasRows AndAlso reader.Read() Then
                            ' İlk sütunu integer olarak alıyoruz
                            veri = reader.GetInt32(0)
                        Else
                            MessageBox.Show("Sorgudan dönen veri bulunamadı.")
                        End If
                    End Using
                End Using
                Using command3 As New SqlCommand(query3, connection)
                    command3.Parameters.AddWithValue("@masanumara", masanumara)
                    command3.Parameters.AddWithValue("@odemeid", veri)
                    Dim rowsAffected3 As Integer = command3.ExecuteNonQuery()
                    If rowsAffected3 > 0 Then
                        'MessageBox.Show("Masa durumu başarıyla güncellendi.")
                    Else
                        MessageBox.Show("Masa durumu güncellenirken bir hata oluştu.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error executing SQL query: " & ex.Message)

        End Try
        siparisler()
    End Sub

    Private Sub SiparisFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        databasebaglanti = New DatabaseBaglanti(connectionString)
        connection = New SqlConnection(connectionString)
        siparisler()
        tutarhesapla()
    End Sub

    Private Sub siparisler()
        Dim dataTable As New DataTable()
        Dim connection As SqlConnection = databasebaglanti.OpenConnection()

        Dim query As String = "SELECT urunturu, urunad,urunfiyat,urunadet,masano FROM Siparis where siparisdurum = 'aktif' and masano = @masano"
        Using command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            command.Parameters.AddWithValue("@masano", masanumara)
            adapter.Fill(dataTable)
        End Using


        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub tutarhesapla()
        Dim connection As SqlConnection = databasebaglanti.OpenConnection()

        Dim query As String = "select FORMAT(SUM(urunadet * urunfiyat), 'N2') from Siparis where masano = @masano and siparisdurum = 'aktif'"
        Using command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@masano", masanumara)
            Dim toplamTutar As Object = command.ExecuteScalar()
            If IsDBNull(toplamTutar) Then
                toplamTutar = 0
            End If
            lbltutar.Text = toplamTutar.ToString()
        End Using
    End Sub

    Private Sub SiparisFormu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Dim siparisfrm As SiparisForm = CType(Application.OpenForms("SiparisForm"), SiparisForm)
        siparisfrm.siparisler()
        siparisfrm.LoadRadioButtonsFromDatabase()
    End Sub
End Class