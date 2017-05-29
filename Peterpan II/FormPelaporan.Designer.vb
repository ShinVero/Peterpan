<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPelaporan
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
        Me.DTP_awal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTP_Ahkir = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_Rumah_Sakit = New System.Windows.Forms.TextBox()
        Me.Txt_Idaman_Parkir = New System.Windows.Forms.TextBox()
        Me.Btn_Proses = New System.Windows.Forms.Button()
        Me.Btn_Restart = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_Total = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTP_awal
        '
        Me.DTP_awal.Location = New System.Drawing.Point(16, 45)
        Me.DTP_awal.Name = "DTP_awal"
        Me.DTP_awal.Size = New System.Drawing.Size(200, 22)
        Me.DTP_awal.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tanggal Awal"
        '
        'DTP_Ahkir
        '
        Me.DTP_Ahkir.Location = New System.Drawing.Point(261, 45)
        Me.DTP_Ahkir.Name = "DTP_Ahkir"
        Me.DTP_Ahkir.Size = New System.Drawing.Size(200, 22)
        Me.DTP_Ahkir.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(258, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal Ahkir"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 88)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(445, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Rumah Sakit : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Idaman Parkir: "
        '
        'Txt_Rumah_Sakit
        '
        Me.Txt_Rumah_Sakit.Location = New System.Drawing.Point(138, 283)
        Me.Txt_Rumah_Sakit.Name = "Txt_Rumah_Sakit"
        Me.Txt_Rumah_Sakit.Size = New System.Drawing.Size(100, 22)
        Me.Txt_Rumah_Sakit.TabIndex = 6
        '
        'Txt_Idaman_Parkir
        '
        Me.Txt_Idaman_Parkir.Location = New System.Drawing.Point(138, 326)
        Me.Txt_Idaman_Parkir.Name = "Txt_Idaman_Parkir"
        Me.Txt_Idaman_Parkir.Size = New System.Drawing.Size(100, 22)
        Me.Txt_Idaman_Parkir.TabIndex = 6
        '
        'Btn_Proses
        '
        Me.Btn_Proses.Location = New System.Drawing.Point(323, 283)
        Me.Btn_Proses.Name = "Btn_Proses"
        Me.Btn_Proses.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Proses.TabIndex = 7
        Me.Btn_Proses.Text = "Proses"
        Me.Btn_Proses.UseVisualStyleBackColor = True
        '
        'Btn_Restart
        '
        Me.Btn_Restart.Location = New System.Drawing.Point(323, 326)
        Me.Btn_Restart.Name = "Btn_Restart"
        Me.Btn_Restart.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Restart.TabIndex = 8
        Me.Btn_Restart.Text = "Restart"
        Me.Btn_Restart.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(229, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Pendapatan : "
        '
        'Txt_Total
        '
        Me.Txt_Total.Location = New System.Drawing.Point(361, 247)
        Me.Txt_Total.Name = "Txt_Total"
        Me.Txt_Total.Size = New System.Drawing.Size(100, 22)
        Me.Txt_Total.TabIndex = 6
        '
        'FormPelaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 389)
        Me.Controls.Add(Me.Btn_Restart)
        Me.Controls.Add(Me.Btn_Proses)
        Me.Controls.Add(Me.Txt_Idaman_Parkir)
        Me.Controls.Add(Me.Txt_Total)
        Me.Controls.Add(Me.Txt_Rumah_Sakit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTP_Ahkir)
        Me.Controls.Add(Me.DTP_awal)
        Me.Name = "FormPelaporan"
        Me.Text = "FormPelaporan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DTP_awal As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents DTP_Ahkir As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_Rumah_Sakit As TextBox
    Friend WithEvents Txt_Idaman_Parkir As TextBox
    Friend WithEvents Btn_Proses As Button
    Friend WithEvents Btn_Restart As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_Total As TextBox
End Class
