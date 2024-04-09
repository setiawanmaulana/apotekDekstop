Imports System.Data.SqlClient

Public Class FormKelolaObat
    Private Sub FormKelolaObat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()
    End Sub
    Sub kondisiawal()
        Call munculgrid()
        incrementKodeObt()
        namaObat.Text = ""
        jumlah.Text = ""
        harga.Text = ""
        pencarian.Text = ""
    End Sub

    Sub munculgrid()
        Call koneksi()
        Da = New SqlDataAdapter("Select * from TblObat", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "TblObat")
        dgv.DataSource = Ds.Tables("TblObat")
    End Sub

    Sub incrementKodeObt()
        Dim nextKode As String

        Call koneksi()
        Cmd = New SqlCommand("SELECT TOP 1 KodeObat FROM TblObat ORDER BY KodeObat DESC", Conn)
        Dim kdObt = Cmd.ExecuteScalar()?.ToString()
        If kdObt IsNot Nothing Then
            nextKode = "OBT" & (Integer.Parse(kdObt.Substring(3)) + 1).ToString("D3")
        Else
            nextKode = "OBT001"
        End If
        kodeObat.Text = nextKode
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If kodeObat.Text = "" Or namaObat.Text = "" Or jumlah.Text = "" Or harga.Text = "" Then
            MessageBox.Show("Semua Data diperlukan!, Lengkapi terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Call koneksi()
            Cmd = New SqlCommand("insert into TblObat values ('" & kodeObat.Text & "','" & namaObat.Text & "','" & kadaluarsa.Value.ToString("yyyy-MM-dd") & "','" & jumlah.Text & "','" & harga.Text & "')", Conn)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil ditambahkan", "Pemberitahuan", MessageBoxButtons.OK)
            Call kondisiawal()
        End If
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Dim i As Integer = dgv.CurrentRow.Index
        Call koneksi()
        Cmd = New SqlCommand("select * from TblObat where IdObat= '" & dgv.Item(0, i).Value & "'", Conn)
        Rd = Cmd.ExecuteReader
        If Rd.Read Then
            kodeObat.Text = Rd!KodeObat
            namaObat.Text = Rd!NamaObat
            kadaluarsa.Value = Rd!ExpiredDate
            jumlah.Text = Rd!Jumlah
            harga.Text = Rd!Harga
            On Error Resume Next
        End If
        Rd.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If kodeObat.Text = "" Or namaObat.Text = "" Or jumlah.Text = "" Or harga.Text = "" Then
            MessageBox.Show("Pilih data yang akan diedit terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim i As Integer = dgv.CurrentRow.Index
            Call koneksi()
            Cmd = New SqlCommand("Update TblObat set KodeObat = '" & kodeObat.Text & "',NamaObat = '" & namaObat.Text & "',ExpiredDate = '" & kadaluarsa.Value.ToString("yyyy-MM-dd") & "',Jumlah = '" & jumlah.Text & "',Harga = '" & harga.Text & "' where IdObat='" & dgv.Item(0, i).Value & "'", Conn)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diedit", "Pemberitahuan", MessageBoxButtons.OK)
            Call kondisiawal()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If kodeObat.Text = "" Or namaObat.Text = "" Or jumlah.Text = "" Or harga.Text = "" Then
            MessageBox.Show("Pilih data yang akan di HAPUS terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim pesan As String = MessageBox.Show("Yakin ingin Menghapus?", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pesan = vbYes Then
                Dim i As Integer = dgv.CurrentRow.Index
                Call koneksi()
                Cmd = New SqlCommand("Delete From TblObat where IdObat= '" & dgv.Item(0, i).Value & "' ", Conn)
                Cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil dihapus", "Pemberitahuan", MessageBoxButtons.OK)
                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub pencarian_TextChanged(sender As Object, e As EventArgs) Handles pencarian.TextChanged
        Try
            Call koneksi()
            Da = New SqlDataAdapter("SELECT * FROM TblObat WHERE NamaObat LIKE '%" & pencarian.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "search")
            dgv.DataSource = Ds.Tables("search")
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub kelolaUser_Click(sender As Object, e As EventArgs) Handles kelolaUser.Click
        Me.Close()
        FormKelolaUser.Show()
    End Sub

    Private Sub kelolaObat_Click(sender As Object, e As EventArgs) Handles kelolaObat.Click
        MessageBox.Show("Kamu sudah di menu Kelola Obat!", "Pemberitahuan")
    End Sub

    Private Sub kelolaLaporan_Click(sender As Object, e As EventArgs) Handles kelolaLaporan.Click
        Me.Close()
        FormKelolaLaporan.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim pesan As String = MessageBox.Show("Yakin ingin Logout?", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If pesan = vbYes Then
            Me.Close()
            munculgrid()
            FormLogin.Show()
            FormLogin.kondisiawal()
            FormLogin.insertLog(FormLogin.IdUserLogin, FormLogin.UserLogin, "Logout")
        End If
    End Sub

    Private Sub jumlah_TextChanged(sender As Object, e As EventArgs) Handles jumlah.KeyPress
        FormKelolaUser.formatNumeric(e)
    End Sub

    Private Sub harga_TextChanged(sender As Object, e As EventArgs) Handles harga.KeyPress
        FormKelolaUser.formatNumeric(e)
    End Sub
End Class