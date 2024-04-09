<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKelolaLaporan
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKelolaLaporan))
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.kelolaLaporan = New System.Windows.Forms.Button()
        Me.kelolaObat = New System.Windows.Forms.Button()
        Me.kelolaUser = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(240, 121)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(523, 150)
        Me.dgv.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(329, 69)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(95, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(257, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Dari Tgl."
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderlineColor = System.Drawing.Color.Transparent
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(206, 289)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Omset"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(496, 149)
        Me.Chart1.TabIndex = 4
        Me.Chart1.Text = "Chart1"
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(688, 354)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 28)
        Me.btnGenerate.TabIndex = 5
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(549, 69)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(95, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(460, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sampai Tgl."
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(688, 66)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 28)
        Me.btnLoad.TabIndex = 5
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(223, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Kelola Laporan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(441, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Laporan Penjualan"
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
        Me.Panel1.TabIndex = 28
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
        'FormKelolaLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.dgv)
        Me.Name = "FormKelolaLaporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormKelolaLaporan"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents btnGenerate As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLoad As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents kelolaLaporan As Button
    Friend WithEvents kelolaObat As Button
    Friend WithEvents kelolaUser As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
