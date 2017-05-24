Public Class Form1
    Dim no_transaksi As Integer
    Dim no_parkir As String = "MU13"
    Dim PlatPolisi As String
    Dim jam_masuk As DateTime
    Dim jam_keluar As DateTime
    Dim biaya_Parkir As Integer
    Dim Deposito As Integer = 10000
    Dim Total As Integer
    Sub modestandby()
        Txt_Biaya.Enabled = False
        Txt_JamMasuk.Enabled = False
        Txt_No_Transaksi.Enabled = False
        Txt_No_Parkir.Enabled = True
        Btn_Proses.Enabled = True
        Btn_Save.Enabled = False
        Btn_Clear.Enabled = False
    End Sub

    Sub modeEdit()
        Txt_Biaya.Enabled = True
        Txt_JamMasuk.Enabled = True
        Txt_No_Transaksi.Enabled = False
        Txt_No_Parkir.Enabled = True
        Txt_JamMasuk.Enabled = True
        Btn_Clear.Enabled = True
        Btn_Save.Enabled = True
        Btn_Proses.Enabled = False
    End Sub

    Private Sub Btn_Proses_Click(sender As Object, e As EventArgs) Handles Btn_Proses.Click
        'Proses pengambilan data dari database

        For x = 0 To no_parkir.Count - 1
            If Txt_No_Parkir.Text = "" Then
                MessageBox.Show("Anda Belum mengisi no parkir")
                Exit For
            End If
            If Txt_No_Parkir.Text = no_parkir Then
                modeEdit()
                no_transaksi += 1
                no_parkir = Txt_No_Parkir.Text
                Txt_No_Transaksi.Text = no_transaksi

                'Mendapatkan selisih waktu
                Dim ts As TimeSpan =
                    (Convert.ToDateTime(Txt_JamKeluar.Text).Subtract(Convert.ToDateTime(Txt_JamMasuk.Text))).Duration()
                Dim Lama_Parkir As String = [String].Format("{0}", ts.Hours)

                'Pengecekakn Jenis kendaraan
                If no_parkir.Substring(0, 1) = "M" Then
                    biaya_Parkir = Lama_Parkir * 2000
                End If

                'Pengecekan jenis pelanggan
                If no_parkir.Substring(1, 1) = "L" Then
                    If Deposito = 0 Then
                        MessageBox.Show("Anda Sudah tidak memiliki saldo")
                    ElseIf Deposito > biaya_Parkir Then
                        Deposito -= biaya_Parkir
                        MessageBox.Show("Anda Memiliki sisa saldo sebesar : " & Deposito)
                        biaya_Parkir = 0
                    Else
                        biaya_Parkir -= Deposito
                        Deposito = 0
                        MessageBox.Show("Anda Memiliki sisa saldo sebesar : " & Deposito)
                    End If
                ElseIf no_parkir.Substring(1, 1) = "S" Then
                    biaya_Parkir = 0
                End If
                Txt_Biaya.Text = Format(biaya_Parkir, "##,###")
                Exit For
            Else
                MessageBox.Show("Maaf Data tidak ditemukkan")
                Txt_No_Parkir.Clear()
                Exit For
            End If
        Next

    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        'proses pembayaran dan penyimpanan data..ketika tombol ini di klik
        Dim JnsPelanggan As String
        Dim JnsKendaraan As String
        If no_parkir.Substring(1, 1) = "L" Then
            JnsPelanggan = "Langganan"
        ElseIf no_parkir.Substring(1, 1) = "S" Then
            JnsPelanggan = "Staff"
        Else
            JnsPelanggan = "Umum"
        End If
        If no_parkir.Substring(0, 1) = "M" Then
            JnsKendaraan = "Mobil"
        End If
        MessageBox.Show("No Transaksi : " & no_transaksi &
                        " No Parkir : " & no_parkir &
                        " Jenis Pelanggan : " & JnsPelanggan &
                        " Jenis Kendaraan : " & JnsKendaraan &
                        " Jam Masuk : " & Txt_JamMasuk.Text &
                        " Jam_Keluar : " & Txt_JamKeluar.Text)
        'anggap saja palang parkir terbuka
        modestandby()
        Txt_Biaya.Clear()
        Txt_JamMasuk.Clear()
        Txt_No_Transaksi.Clear()
        Txt_No_Parkir.Clear()
    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        Txt_Biaya.Clear()
        Txt_JamMasuk.Clear()
        Txt_No_Transaksi.Clear()
        Txt_No_Parkir.Clear()
        If no_transaksi = 0 Then
            MessageBox.Show("tidak ada transaksi")
        Else
            no_transaksi -= 1
        End If
        modestandby()
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Txt_JamKeluar.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Txt_JamMasuk.Text = Format("05:00:00")
    End Sub
End Class
