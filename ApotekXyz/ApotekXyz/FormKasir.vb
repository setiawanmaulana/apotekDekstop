Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class FormKasir
    Dim WithEvents PD As New PrintDocument
    Dim ppd As New PrintPreviewDialog

    Private Sub FormKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Kondisiawal()
        Call kosongkan()
        Call BuatKolom()
        typeResep.Items.AddRange({"Resep", "Non Resep"})
    End Sub

    Private Sub Kondisiawal()
        typeResep.Text = ""
        noResep.Text = ""
        namaPasien.Text = ""
        namaDokter.Text = ""
        namaObat.Text = ""
        harga.Text = ""
        quantity.Text = ""
        noResep.ReadOnly = True
        harga.ReadOnly = True
        tglSekarang.Text = DateTime.Now
    End Sub

    Sub BuatKolom()
        dgv.Columns.Clear()
        dgv.Columns.Add("tres", "Type Resep")
        dgv.Columns.Add("nres", "No.Resep")
        dgv.Columns.Add("tglres", "Tgl.Resep")
        dgv.Columns.Add("nmpas", "Nama Pasien")
        dgv.Columns.Add("nmdok", "Nama Dokter")
        dgv.Columns.Add("nmob", "Nama Obat")
        dgv.Columns.Add("harga", "Harga")
        dgv.Columns.Add("qty", "Quantity")
        dgv.Columns.Add("subt", "Subtotal")
        dgv.Columns.Add("idob", "Id Obat")
    End Sub

    Function incrementNoResep()
        Dim nextKode As String = ""
        For i As Integer = 0 To dgv.Rows.Count - 1
            Dim cellValue As Object = dgv.Rows(i).Cells("nres").Value
            If cellValue IsNot Nothing AndAlso cellValue.ToString().Length > 1 Then
                nextKode = cellValue.ToString().Substring(1)
            End If
        Next

        If Not String.IsNullOrEmpty(nextKode) Then
            Return "R" & (Integer.Parse(nextKode) + 1).ToString("D3")
        Else
            Call koneksi()
            Cmd = New SqlCommand("SELECT TOP 1 NoResep FROM TblResep ORDER BY NoResep DESC", Conn)
            Dim nres = Cmd.ExecuteScalar()?.ToString()
            If nres IsNot Nothing Then
                nextKode = "R" & (Integer.Parse(nres.Substring(1)) + 1).ToString("D3")
            Else
                nextKode = "R001"
            End If
        End If
        noResep.Text = nextKode
        Return nextKode
    End Function

    Dim noTransaksi As String = ""
    Function incremntNoTr() As String
        Dim tgl As String = Format(Today, "yyyyMMdd")
        Dim nextKode As String

        Call koneksi()
        Cmd = New SqlCommand("SELECT TOP 1 NoTransaksi FROM TblTransaksi ORDER BY NoTransaksi DESC", Conn)
        Dim noTr = Cmd.ExecuteScalar()?.ToString()
        If noTr IsNot Nothing Then
            nextKode = "TR" & tgl & (Integer.Parse(noTr.Substring(10)) + 1).ToString("D3")
        Else
            nextKode = "TR" & tgl & "001"
        End If
        Conn.Close()
        Return nextKode
    End Function

    Private Sub typeResep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles typeResep.SelectedIndexChanged
        Call Kondisiawal()
        Dim isResep As Boolean = (typeResep.SelectedItem IsNot Nothing AndAlso typeResep.SelectedItem.ToString() = "Resep")
        noResep.Enabled = isResep
        tglResep.Enabled = isResep
        namaPasien.Enabled = isResep
        namaDokter.Enabled = isResep
        noResep.Text = If(isResep, incrementNoResep(), "")
    End Sub

    Dim idObat As Integer
    Dim stok As Integer
    Private Sub namaObat_TextChanged(sender As Object, e As EventArgs) Handles namaObat.TextChanged
        If String.IsNullOrEmpty(namaObat.Text) Then
            harga.Text = ""
        Else
            Call koneksi()
            Cmd = New SqlCommand("SELECT IdObat, Harga, Jumlah FROM TblObat WHERE NamaObat = '" & namaObat.Text & "'", Conn)
            Rd = Cmd.ExecuteReader()
            If Rd.Read Then
                stok = Rd!Jumlah
                harga.Text = Rd!Harga
                idObat = Rd!IdObat
            End If
            Rd.Close()
        End If
    End Sub
    Sub kosongkan()
        dgv.Rows.Clear()
        txtJumlah.Text = ""
        txtKembalian.Text = ""
        txtBayar.Text = ""
        btnBayar.Enabled = False
        btnSave.Enabled = False
    End Sub

    Private Sub btnkosongkan_Click(sender As Object, e As EventArgs) Handles btnKosongkan.Click
        Call kosongkan()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If String.IsNullOrEmpty(typeResep.Text) OrElse String.IsNullOrEmpty(namaObat.Text) Or String.IsNullOrEmpty(quantity.Text) Then
            MessageBox.Show("Mohon lengkapi terlebih dahulu!")
        ElseIf String.IsNullOrEmpty(harga.Text) OrElse stok < quantity.Text Then
            MessageBox.Show("Obat tidak ada!, stoknya '" & stok & "' ")
        Else
            Dim subtotal As Integer = CInt(harga.Text) * CInt(quantity.Text)
            dgv.Rows.Add(typeResep.Text, noResep.Text, tglResep.Value.ToString("dd-MM-yyyy"), namaPasien.Text, namaDokter.Text, namaObat.Text, harga.Text, quantity.Text, subtotal, idObat)
            btnBayar.Enabled = True
            btnSave.Enabled = True
            txtBayar.Focus()
            hitung()
            Kondisiawal()
        End If
    End Sub

    Private Sub hitung()
        For i As Integer = 0 To dgv.RowCount - 1
            Dim totalBelanja As Integer = totalBelanja + dgv.Rows(i).Cells("subt").Value
            txtJumlah.Text = totalBelanja
        Next
    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        If String.IsNullOrEmpty(txtBayar.Text) Then
            MessageBox.Show("Mohon isi kolom bayar terlebih dahulu")
        Else
            Dim kembalian As Integer = CInt(txtBayar.Text) - CInt(txtJumlah.Text)
            If CInt(txtBayar.Text) < CInt(txtJumlah.Text) Then
                MessageBox.Show("Jumlah Bayar kamu kurang")
            Else
                txtKembalian.Text = kembalian
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtBayar.Text) OrElse String.IsNullOrEmpty(txtKembalian.Text) Then
            MessageBox.Show("Mohon selesaikan pembayaran terlebih dahulu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                For Each row As DataGridViewRow In dgv.Rows
                    Dim typeResep As String = If(row.Cells("tres").Value?.ToString(), "")
                    Dim isResep As Boolean = (typeResep = "Resep")
                    Dim isNonResep As Boolean = (typeResep = "Non Resep")

                    Dim idObat As Integer = Convert.ToInt32(row.Cells("idob").Value)
                    Dim kuantitas As Integer = Convert.ToInt32(row.Cells("qty").Value)
                    Dim hargaTotal As Integer = Convert.ToInt32(row.Cells("harga").Value) * kuantitas

                    Try
                        Call koneksi()
                        Cmd = New SqlCommand("UPDATE TblObat SET Jumlah = Jumlah - '" & kuantitas & "' WHERE IdObat = '" & idObat & "'", Conn)
                        Cmd.ExecuteNonQuery()
                    Finally
                        Conn.Close()
                    End Try

                    If isResep Then
                        Dim idResep As Integer
                        noTransaksi = incremntNoTr()
                        Try
                            Call koneksi()
                            Dim noResep As String = If(row.Cells("nres").Value?.ToString(), "")
                            Dim tglResep As String = If(row.Cells("tglres").Value, "")
                            Dim namaPasien As String = If(row.Cells("nmpas").Value?.ToString(), "")
                            Dim namaDokter As String = If(row.Cells("nmdok").Value?.ToString(), "")
                            Dim namaObat As String = If(row.Cells("nmob").Value?.ToString(), "")

                            Cmd = New SqlCommand("INSERT INTO TblResep (NoResep, TglResep, NamaDokter, NamaPasien, NamaObatDibeli, JumlahObatDibeli) VALUES ('" & noResep & "', '" & tglResep & "', '" & namaDokter & "', '" & namaPasien & "', '" & namaObat & "','" & kuantitas & "'); SELECT SCOPE_IDENTITY()", Conn)
                            idResep = Convert.ToInt32(Cmd.ExecuteScalar())

                            Cmd = New SqlCommand("INSERT INTO TblTransaksi  VALUES ('" & noTransaksi & "', '" & DateTimePicker2.Value.ToString & "', '" & hargaTotal & "', '" & FormLogin.IdUserLogin() & "', '" & idObat & "', '" & idResep & "')", Conn)
                            Cmd.ExecuteNonQuery()
                        Finally
                            Conn.Close()
                        End Try
                    End If

                    If isNonResep Then
                        noTransaksi = incremntNoTr()
                        Try
                            Call koneksi()
                            Cmd = New SqlCommand("INSERT INTO TblTransaksi (NoTransaksi, TglTransaksi, TotalBayar, IdUser, IdObat)  VALUES ('" & noTransaksi & "', '" & DateTimePicker2.Value.ToString & "', '" & hargaTotal & "', '" & FormLogin.IdUserLogin() & "', '" & idObat & "')", Conn)
                            Cmd.ExecuteNonQuery()
                        Catch ex As Exception
                            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                            Conn.Close()
                        End Try
                    End If
                Next
            Finally
                ppd.Document = PD
                ppd.ShowDialog()
                PD.Print()
                Call Kondisiawal()
                Call kosongkan()
            End Try
        End If
    End Sub
    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pageSetup As New PageSettings
        Dim lebar As Integer = 250
        Dim rowcount As Integer = dgv.RowCount - 1
        Dim tinggi As Integer = rowcount * 15 + 300
        pageSetup.PaperSize = New PaperSize("Custom", lebar, tinggi)
        PD.DefaultPageSettings = pageSetup
    End Sub
    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f14b As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim centerMargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2

        Dim center As New StringFormat
        center.Alignment = StringAlignment.Center

        Dim garis As String = "-------------------------------------------------------"

        e.Graphics.DrawString("Apotek XYZ", f14b, Brushes.Black, centerMargin, 5, center)
        e.Graphics.DrawString("Jl Raya No 2 Kota X", f10, Brushes.Black, centerMargin, 30, center)
        e.Graphics.DrawString("Hub : 0812 - 4769 - 3470", f10, Brushes.Black, centerMargin, 45, center)

        e.Graphics.DrawString("Nama Kasir", f10, Brushes.Black, 20, 70)
        e.Graphics.DrawString(":", f10, Brushes.Black, 110, 70)
        e.Graphics.DrawString(namaKasir.Text, f10, Brushes.Black, 120, 70)

        Dim notr As String = noTransaksi
        e.Graphics.DrawString("No Transaksi", f10, Brushes.Black, 20, 85)
        e.Graphics.DrawString(":", f10, Brushes.Black, 110, 85)
        e.Graphics.DrawString(notr, f10, Brushes.Black, 120, 85)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 100)

        Dim tinggi As Integer = 110
        Dim verticalSpacing As Integer = 20
        For i As Integer = 0 To dgv.RowCount - 1
            e.Graphics.DrawString(dgv.Rows(i).Cells("qty").Value, f10, Brushes.Black, 20, tinggi)
            e.Graphics.DrawString(dgv.Rows(i).Cells("nmob").Value, f10, Brushes.Black, 100, tinggi)
            e.Graphics.DrawString(dgv.Rows(i).Cells("harga").Value, f10, Brushes.Black, 200, tinggi)
            tinggi += verticalSpacing
        Next

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, tinggi + 10)
        e.Graphics.DrawString("Total", f10, Brushes.Black, 20, tinggi + 25)
        e.Graphics.DrawString(":", f10, Brushes.Black, 110, tinggi + 25)
        e.Graphics.DrawString(txtJumlah.Text, f10, Brushes.Black, 200, tinggi + 25)

        e.Graphics.DrawString("Kembalian", f10, Brushes.Black, 20, tinggi + 40)
        e.Graphics.DrawString(":", f10, Brushes.Black, 110, tinggi + 40)
        e.Graphics.DrawString(txtKembalian.Text, f10, Brushes.Black, 200, tinggi + 40)

        e.Graphics.DrawString("Apotek XYZ mengucapkan", f10, Brushes.Black, centerMargin, tinggi + 65, center)
        e.Graphics.DrawString("Semoga Lekas Sembuh", f10, Brushes.Black, centerMargin, tinggi + 85, center)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim pesan As String = MessageBox.Show("Yakin ingin Logout?", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If pesan = vbYes Then
            Me.Close()
            FormLogin.Show()
            FormLogin.kondisiawal()
            FormLogin.insertLog(FormLogin.IdUserLogin, FormLogin.UserLogin, "Logout")
        End If
    End Sub
    Private Sub harga_TextChanged(sender As Object, e As EventArgs) Handles harga.KeyPress
        FormKelolaUser.formatNumeric(e)
    End Sub
    Private Sub quantity_TextChanged(sender As Object, e As EventArgs) Handles quantity.KeyPress
        FormKelolaUser.formatNumeric(e)
    End Sub
    Private Sub txtBayar_TextChanged(sender As Object, e As EventArgs) Handles txtBayar.KeyPress
        FormKelolaUser.formatNumeric(e)
    End Sub
End Class