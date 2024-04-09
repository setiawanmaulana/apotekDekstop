Imports System.Data.SqlClient

Public Class FormApoteker
    Private Sub FormApoteker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()
    End Sub

    Private Sub kondisiawal()
        Call munculGrid()
        noResep.Text = ""
        tglResep.Text = ""
        namaPasien.Text = ""
        namaDokter.Text = ""
        namaObat.Text = ""
        quantity.Text = ""
        pencarian.Text = ""
    End Sub

    Private Sub munculGrid()
        Call koneksi()
        Da = New SqlDataAdapter("select IdResep, NoResep, NamaDokter, NamaObatDibeli, JumlahObatDibeli from TblResep ", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "TblResep")
        dgv.DataSource = Ds.Tables("TblResep")
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Dim i As Integer = dgv.CurrentRow.Index
        Call koneksi()
        Cmd = New SqlCommand("select * from TblResep where IdResep = '" & dgv.Item(0, i).Value & "' ", Conn)
        Rd = Cmd.ExecuteReader
        If Rd.Read Then
            noResep.Text = Rd!NoResep
            tglResep.Text = Rd!TglResep
            namaPasien.Text = Rd!NamaPasien
            namaDokter.Text = Rd!NamaDokter
            namaObat.Text = Rd!NamaObatDibeli
            quantity.Text = Rd!JumlahObatDibeli
            On Error Resume Next
        End If
        Rd.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If noResep.Text = "" Or tglResep.Text = "" Or namaPasien.Text = "" Or namaDokter.Text = "" Or namaObat.Text = "" Or quantity.Text = "" Then
            MessageBox.Show("Pilih data yang akan di Edit terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim i As Integer = dgv.CurrentRow.Index
            Call koneksi()
            Cmd = New SqlCommand("update TblResep set NoResep = '" & noResep.Text & "', TglResep = '" & tglResep.Text & "', NamaDokter = '" & namaDokter.Text & "', NamaPasien = '" & namaPasien.Text & "', NamaObatDibeli = '" & namaObat.Text & "', JumlahObatDibeli = '" & quantity.Text & "' where IdResep = '" & dgv.Item(0, i).Value & "'", Conn)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diedit", "Pemberitahuan", MessageBoxButtons.OK)
            Call kondisiawal()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If noResep.Text = "" Or tglResep.Text = "" Or namaPasien.Text = "" Or namaDokter.Text = "" Or namaObat.Text = "" Or quantity.Text = "" Then
            MessageBox.Show("Pilih data yang akan di HAPUS terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim pesan As String = MessageBox.Show("Yakin ingin Menghapus?", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pesan = vbYes Then
                Dim i As Integer = dgv.CurrentRow.Index
                Call koneksi()
                Cmd = New SqlCommand("Delete From TblResep where IdResep = '" & dgv.Item(0, i).Value & "'", Conn)
                Cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil dihapus", "Pemberitahuan", MessageBoxButtons.OK)
                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub pencarian_TextChanged(sender As Object, e As EventArgs) Handles pencarian.TextChanged
        Try
            Call koneksi()
            Da = New SqlDataAdapter("select * from TblResep where NamaDokter like '%" & pencarian.Text & "%' ", Conn)
            Ds = New DataSet
            Ds.Clear()
            Da.Fill(Ds, "search")
            dgv.DataSource = Ds.Tables("search")
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim pesan As String = MessageBox.Show("Yakin ingin Logout?", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If pesan = vbYes Then
            Me.Close()
            munculGrid()
            FormLogin.Show()
            FormLogin.kondisiawal()
            FormLogin.insertLog(FormLogin.IdUserLogin, FormLogin.UserLogin, "Logout")
        End If
    End Sub
End Class