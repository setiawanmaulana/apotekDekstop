<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKasir
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKasir))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.typeResep = New System.Windows.Forms.ComboBox()
        Me.btnKosongkan = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.namaObat = New System.Windows.Forms.TextBox()
        Me.namaDokter = New System.Windows.Forms.TextBox()
        Me.noResep = New System.Windows.Forms.TextBox()
        Me.namaPasien = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tglResep = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.quantity = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.tglSekarang = New System.Windows.Forms.Label()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.txtJumlah = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.namaKasir = New System.Windows.Forms.Label()
        Me.txtKembalian = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 450)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(33, 102)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.Control
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(41, 354)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(119, 29)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "LOG OUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(37, 273)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Transaksi"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(37, 249)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 24)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Kelola"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(56, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 24)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "KASIR"
        '
        'typeResep
        '
        Me.typeResep.FormattingEnabled = True
        Me.typeResep.Location = New System.Drawing.Point(319, 62)
        Me.typeResep.Name = "typeResep"
        Me.typeResep.Size = New System.Drawing.Size(152, 21)
        Me.typeResep.TabIndex = 46
        '
        'btnKosongkan
        '
        Me.btnKosongkan.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnKosongkan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKosongkan.Location = New System.Drawing.Point(589, 200)
        Me.btnKosongkan.Name = "btnKosongkan"
        Me.btnKosongkan.Size = New System.Drawing.Size(96, 26)
        Me.btnKosongkan.TabIndex = 45
        Me.btnKosongkan.Text = "Kosongkan"
        Me.btnKosongkan.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Location = New System.Drawing.Point(309, 199)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(105, 27)
        Me.btnTambah.TabIndex = 43
        Me.btnTambah.Text = "Tambahkan"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(241, 232)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(517, 109)
        Me.dgv.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(238, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Tgl Resep"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(526, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(526, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Nama Obat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(206, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 20)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Form Transaksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(526, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Nama Dokter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(238, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "No Resep"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(238, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Type Resep"
        '
        'harga
        '
        Me.harga.Location = New System.Drawing.Point(606, 123)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(152, 20)
        Me.harga.TabIndex = 30
        '
        'namaObat
        '
        Me.namaObat.Location = New System.Drawing.Point(606, 93)
        Me.namaObat.Name = "namaObat"
        Me.namaObat.Size = New System.Drawing.Size(152, 20)
        Me.namaObat.TabIndex = 29
        '
        'namaDokter
        '
        Me.namaDokter.Location = New System.Drawing.Point(606, 62)
        Me.namaDokter.Name = "namaDokter"
        Me.namaDokter.Size = New System.Drawing.Size(152, 20)
        Me.namaDokter.TabIndex = 28
        '
        'noResep
        '
        Me.noResep.Location = New System.Drawing.Point(319, 93)
        Me.noResep.Name = "noResep"
        Me.noResep.Size = New System.Drawing.Size(152, 20)
        Me.noResep.TabIndex = 32
        '
        'namaPasien
        '
        Me.namaPasien.Location = New System.Drawing.Point(319, 157)
        Me.namaPasien.Name = "namaPasien"
        Me.namaPasien.Size = New System.Drawing.Size(152, 20)
        Me.namaPasien.TabIndex = 33
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Green
        Me.Panel2.Location = New System.Drawing.Point(495, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 157)
        Me.Panel2.TabIndex = 27
        '
        'tglResep
        '
        Me.tglResep.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tglResep.Location = New System.Drawing.Point(319, 123)
        Me.tglResep.Name = "tglResep"
        Me.tglResep.Size = New System.Drawing.Size(152, 20)
        Me.tglResep.TabIndex = 47
        Me.tglResep.Value = New Date(2024, 4, 6, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(238, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Nama Pasien"
        '
        'quantity
        '
        Me.quantity.Location = New System.Drawing.Point(606, 157)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(152, 20)
        Me.quantity.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(526, 160)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Quantity"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(647, 386)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(97, 26)
        Me.btnSave.TabIndex = 49
        Me.btnSave.Text = "Print   Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnBayar
        '
        Me.btnBayar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBayar.Location = New System.Drawing.Point(309, 388)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(51, 23)
        Me.btnBayar.TabIndex = 50
        Me.btnBayar.Text = "Bayar"
        Me.btnBayar.UseVisualStyleBackColor = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(697, 25)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker2.TabIndex = 51
        Me.DateTimePicker2.Value = New Date(2024, 4, 6, 0, 0, 0, 0)
        '
        'tglSekarang
        '
        Me.tglSekarang.AutoSize = True
        Me.tglSekarang.Location = New System.Drawing.Point(658, 0)
        Me.tglSekarang.Name = "tglSekarang"
        Me.tglSekarang.Size = New System.Drawing.Size(71, 13)
        Me.tglSekarang.TabIndex = 52
        Me.tglSekarang.Text = "tgl and waktu"
        '
        'txtBayar
        '
        Me.txtBayar.Location = New System.Drawing.Point(371, 390)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(100, 20)
        Me.txtBayar.TabIndex = 53
        '
        'txtJumlah
        '
        Me.txtJumlah.AutoSize = True
        Me.txtJumlah.BackColor = System.Drawing.Color.Lime
        Me.txtJumlah.Location = New System.Drawing.Point(313, 367)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(42, 13)
        Me.txtJumlah.TabIndex = 48
        Me.txtJumlah.Text = "Jml Beli"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(307, 417)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "Kembalian"
        '
        'namaKasir
        '
        Me.namaKasir.AutoSize = True
        Me.namaKasir.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.namaKasir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namaKasir.Location = New System.Drawing.Point(601, 27)
        Me.namaKasir.Name = "namaKasir"
        Me.namaKasir.Size = New System.Drawing.Size(76, 16)
        Me.namaKasir.TabIndex = 48
        Me.namaKasir.Text = "Nama kasir"
        '
        'txtKembalian
        '
        Me.txtKembalian.AutoSize = True
        Me.txtKembalian.BackColor = System.Drawing.Color.Lime
        Me.txtKembalian.Location = New System.Drawing.Point(375, 417)
        Me.txtKembalian.Name = "txtKembalian"
        Me.txtKembalian.Size = New System.Drawing.Size(74, 13)
        Me.txtKembalian.TabIndex = 48
        Me.txtKembalian.Text = "Jml Kembalian"
        '
        'FormKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtBayar)
        Me.Controls.Add(Me.tglSekarang)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.btnBayar)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.namaKasir)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtKembalian)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tglResep)
        Me.Controls.Add(Me.typeResep)
        Me.Controls.Add(Me.btnKosongkan)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.quantity)
        Me.Controls.Add(Me.harga)
        Me.Controls.Add(Me.namaObat)
        Me.Controls.Add(Me.namaDokter)
        Me.Controls.Add(Me.noResep)
        Me.Controls.Add(Me.namaPasien)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormKasir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormKasir"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents typeResep As ComboBox
    Friend WithEvents btnKosongkan As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents harga As TextBox
    Friend WithEvents namaObat As TextBox
    Friend WithEvents namaDokter As TextBox
    Friend WithEvents noResep As TextBox
    Friend WithEvents namaPasien As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tglResep As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents quantity As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnBayar As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents tglSekarang As Label
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents txtJumlah As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents namaKasir As Label
    Friend WithEvents txtKembalian As Label
End Class
