<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormApoteker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormApoteker))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.noResep = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.namaPasien = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pencarian = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.tglResep = New System.Windows.Forms.DateTimePicker()
        Me.namaDokter = New System.Windows.Forms.TextBox()
        Me.namaObat = New System.Windows.Forms.TextBox()
        Me.quantity = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
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
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 450)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(31, 103)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Peru
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(41, 354)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(119, 29)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "LOG OUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(42, 281)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 21)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "RESEP"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(42, 260)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 21)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "KELOLA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(27, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 24)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "APOTEKER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(246, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No Resep"
        '
        'noResep
        '
        Me.noResep.Location = New System.Drawing.Point(332, 82)
        Me.noResep.Name = "noResep"
        Me.noResep.Size = New System.Drawing.Size(138, 20)
        Me.noResep.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(274, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(527, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(233, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Kelola Resep"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(246, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tgl Resep"
        '
        'namaPasien
        '
        Me.namaPasien.Location = New System.Drawing.Point(332, 160)
        Me.namaPasien.Name = "namaPasien"
        Me.namaPasien.Size = New System.Drawing.Size(138, 20)
        Me.namaPasien.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(527, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Nama Dokter"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(246, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Nama Pasien"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(527, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Cari"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(527, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Nama Obat"
        '
        'pencarian
        '
        Me.pencarian.Location = New System.Drawing.Point(569, 212)
        Me.pencarian.Name = "pencarian"
        Me.pencarian.Size = New System.Drawing.Size(177, 20)
        Me.pencarian.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(395, 210)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Hapus"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(236, 268)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(529, 150)
        Me.dgv.TabIndex = 4
        '
        'tglResep
        '
        Me.tglResep.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tglResep.Location = New System.Drawing.Point(332, 122)
        Me.tglResep.Name = "tglResep"
        Me.tglResep.Size = New System.Drawing.Size(138, 20)
        Me.tglResep.TabIndex = 5
        Me.tglResep.Value = New Date(2024, 4, 7, 0, 0, 0, 0)
        '
        'namaDokter
        '
        Me.namaDokter.Location = New System.Drawing.Point(604, 82)
        Me.namaDokter.Name = "namaDokter"
        Me.namaDokter.Size = New System.Drawing.Size(142, 20)
        Me.namaDokter.TabIndex = 2
        '
        'namaObat
        '
        Me.namaObat.Location = New System.Drawing.Point(604, 122)
        Me.namaObat.Name = "namaObat"
        Me.namaObat.Size = New System.Drawing.Size(142, 20)
        Me.namaObat.TabIndex = 2
        '
        'quantity
        '
        Me.quantity.Location = New System.Drawing.Point(604, 160)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(142, 20)
        Me.quantity.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Peru
        Me.Panel2.Location = New System.Drawing.Point(496, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 137)
        Me.Panel2.TabIndex = 6
        '
        'FormApoteker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.tglResep)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pencarian)
        Me.Controls.Add(Me.namaPasien)
        Me.Controls.Add(Me.quantity)
        Me.Controls.Add(Me.namaObat)
        Me.Controls.Add(Me.namaDokter)
        Me.Controls.Add(Me.noResep)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormApoteker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormApoteker"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents noResep As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents namaPasien As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents pencarian As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents tglResep As DateTimePicker
    Friend WithEvents namaDokter As TextBox
    Friend WithEvents namaObat As TextBox
    Friend WithEvents quantity As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
End Class
