<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKelolaObat
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKelolaObat))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.namaObat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.kadaluarsa = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.pencarian = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.kodeObat = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.kelolaLaporan = New System.Windows.Forms.Button()
        Me.kelolaObat = New System.Windows.Forms.Button()
        Me.kelolaUser = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Green
        Me.Panel2.Location = New System.Drawing.Point(496, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 142)
        Me.Panel2.TabIndex = 2
        '
        'namaObat
        '
        Me.namaObat.Location = New System.Drawing.Point(242, 130)
        Me.namaObat.Name = "namaObat"
        Me.namaObat.Size = New System.Drawing.Size(212, 20)
        Me.namaObat.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(239, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Kode Obat"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(242, 257)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(517, 170)
        Me.dgv.TabIndex = 5
        '
        'kadaluarsa
        '
        Me.kadaluarsa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.kadaluarsa.Location = New System.Drawing.Point(242, 178)
        Me.kadaluarsa.Name = "kadaluarsa"
        Me.kadaluarsa.Size = New System.Drawing.Size(215, 20)
        Me.kadaluarsa.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(239, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Obat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(544, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jumlah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(544, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Harga Per Unit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(242, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Expired Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(504, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Cari"
        '
        'jumlah
        '
        Me.jumlah.Location = New System.Drawing.Point(547, 82)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(212, 20)
        Me.jumlah.TabIndex = 4
        '
        'harga
        '
        Me.harga.Location = New System.Drawing.Point(547, 130)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(212, 20)
        Me.harga.TabIndex = 5
        '
        'pencarian
        '
        Me.pencarian.Location = New System.Drawing.Point(547, 213)
        Me.pencarian.Name = "pencarian"
        Me.pencarian.Size = New System.Drawing.Size(212, 20)
        Me.pencarian.TabIndex = 9
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Location = New System.Drawing.Point(245, 210)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 27)
        Me.btnTambah.TabIndex = 6
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(326, 210)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(65, 26)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(397, 210)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(65, 26)
        Me.btnHapus.TabIndex = 8
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(457, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Kelola Obat"
        '
        'kodeObat
        '
        Me.kodeObat.Location = New System.Drawing.Point(242, 82)
        Me.kodeObat.Name = "kodeObat"
        Me.kodeObat.Size = New System.Drawing.Size(212, 20)
        Me.kodeObat.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.kelolaLaporan)
        Me.Panel1.Controls.Add(Me.kelolaObat)
        Me.Panel1.Controls.Add(Me.kelolaUser)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 450)
        Me.Panel1.TabIndex = 8
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(12, 388)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(172, 50)
        Me.btnLogout.TabIndex = 14
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'kelolaLaporan
        '
        Me.kelolaLaporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kelolaLaporan.Location = New System.Drawing.Point(12, 331)
        Me.kelolaLaporan.Name = "kelolaLaporan"
        Me.kelolaLaporan.Size = New System.Drawing.Size(172, 51)
        Me.kelolaLaporan.TabIndex = 13
        Me.kelolaLaporan.Text = "Kelola Laporan"
        Me.kelolaLaporan.UseVisualStyleBackColor = True
        '
        'kelolaObat
        '
        Me.kelolaObat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kelolaObat.Location = New System.Drawing.Point(12, 277)
        Me.kelolaObat.Name = "kelolaObat"
        Me.kelolaObat.Size = New System.Drawing.Size(172, 48)
        Me.kelolaObat.TabIndex = 12
        Me.kelolaObat.Text = "Kelola Obat"
        Me.kelolaObat.UseVisualStyleBackColor = True
        '
        'kelolaUser
        '
        Me.kelolaUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kelolaUser.Location = New System.Drawing.Point(12, 220)
        Me.kelolaUser.Name = "kelolaUser"
        Me.kelolaUser.Size = New System.Drawing.Size(172, 51)
        Me.kelolaUser.TabIndex = 11
        Me.kelolaUser.Text = "Kelola User"
        Me.kelolaUser.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 188)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FormKelolaObat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.kadaluarsa)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pencarian)
        Me.Controls.Add(Me.harga)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.kodeObat)
        Me.Controls.Add(Me.namaObat)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FormKelolaObat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormKelolaObat"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents namaObat As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents kadaluarsa As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents jumlah As TextBox
    Friend WithEvents harga As TextBox
    Friend WithEvents pencarian As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents kodeObat As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents kelolaLaporan As Button
    Friend WithEvents kelolaObat As Button
    Friend WithEvents kelolaUser As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
