﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Btn_Clear = New System.Windows.Forms.Button()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.Btn_Proses = New System.Windows.Forms.Button()
        Me.Txt_Biaya = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Txt_No_Parkir = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Txt_JamMasuk = New System.Windows.Forms.TextBox()
        Me.Txt_JamKeluar = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Tanggal_Keluar = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btn_Clear
        '
        Me.Btn_Clear.Enabled = False
        Me.Btn_Clear.Location = New System.Drawing.Point(230, 195)
        Me.Btn_Clear.Name = "Btn_Clear"
        Me.Btn_Clear.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Clear.TabIndex = 31
        Me.Btn_Clear.Text = "Clear"
        Me.Btn_Clear.UseVisualStyleBackColor = True
        '
        'Btn_Save
        '
        Me.Btn_Save.Enabled = False
        Me.Btn_Save.Location = New System.Drawing.Point(117, 195)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Save.TabIndex = 30
        Me.Btn_Save.Text = "Save"
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'Btn_Proses
        '
        Me.Btn_Proses.Location = New System.Drawing.Point(11, 195)
        Me.Btn_Proses.Name = "Btn_Proses"
        Me.Btn_Proses.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Proses.TabIndex = 29
        Me.Btn_Proses.Text = "Proses"
        Me.Btn_Proses.UseVisualStyleBackColor = True
        '
        'Txt_Biaya
        '
        Me.Txt_Biaya.Enabled = False
        Me.Txt_Biaya.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Txt_Biaya.Location = New System.Drawing.Point(12, 63)
        Me.Txt_Biaya.Multiline = True
        Me.Txt_Biaya.Name = "Txt_Biaya"
        Me.Txt_Biaya.Size = New System.Drawing.Size(456, 50)
        Me.Txt_Biaya.TabIndex = 28
        Me.Txt_Biaya.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(199, 112)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(0, 17)
        Me.label6.TabIndex = 23
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(15, 43)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(92, 17)
        Me.label5.TabIndex = 22
        Me.label5.Text = "Biaya Parkir :"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(254, 141)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(95, 17)
        Me.label4.TabIndex = 21
        Me.label4.Text = "Jam_Keluar : "
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(5, 143)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(95, 17)
        Me.label3.TabIndex = 20
        Me.label3.Text = "Jam_Masuk : "
        '
        'Txt_No_Parkir
        '
        Me.Txt_No_Parkir.Location = New System.Drawing.Point(99, 15)
        Me.Txt_No_Parkir.Name = "Txt_No_Parkir"
        Me.Txt_No_Parkir.Size = New System.Drawing.Size(100, 22)
        Me.Txt_No_Parkir.TabIndex = 17
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(9, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(79, 17)
        Me.label1.TabIndex = 16
        Me.label1.Text = "No.Parkir : "
        '
        'Txt_JamMasuk
        '
        Me.Txt_JamMasuk.Enabled = False
        Me.Txt_JamMasuk.Location = New System.Drawing.Point(119, 138)
        Me.Txt_JamMasuk.Name = "Txt_JamMasuk"
        Me.Txt_JamMasuk.Size = New System.Drawing.Size(100, 22)
        Me.Txt_JamMasuk.TabIndex = 26
        '
        'Txt_JamKeluar
        '
        Me.Txt_JamKeluar.Enabled = False
        Me.Txt_JamKeluar.Location = New System.Drawing.Point(368, 140)
        Me.Txt_JamKeluar.Name = "Txt_JamKeluar"
        Me.Txt_JamKeluar.Size = New System.Drawing.Size(100, 22)
        Me.Txt_JamKeluar.TabIndex = 27
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(241, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Tanggal Keluar : "
        '
        'Txt_Tanggal_Keluar
        '
        Me.Txt_Tanggal_Keluar.Enabled = False
        Me.Txt_Tanggal_Keluar.Location = New System.Drawing.Point(355, 12)
        Me.Txt_Tanggal_Keluar.Name = "Txt_Tanggal_Keluar"
        Me.Txt_Tanggal_Keluar.Size = New System.Drawing.Size(100, 22)
        Me.Txt_Tanggal_Keluar.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 250)
        Me.Controls.Add(Me.Btn_Clear)
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.Btn_Proses)
        Me.Controls.Add(Me.Txt_Biaya)
        Me.Controls.Add(Me.Txt_JamKeluar)
        Me.Controls.Add(Me.Txt_JamMasuk)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.Txt_Tanggal_Keluar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_No_Parkir)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "Form_Keluar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Btn_Clear As Button
    Private WithEvents Btn_Save As Button
    Private WithEvents Btn_Proses As Button
    Private WithEvents Txt_Biaya As TextBox
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents Txt_No_Parkir As TextBox
    Private WithEvents label1 As Label
    Private WithEvents Txt_JamMasuk As TextBox
    Private WithEvents Txt_JamKeluar As TextBox
    Friend WithEvents Timer1 As Timer
    Public WithEvents Timer2 As Timer
    Private WithEvents Label2 As Label
    Private WithEvents Txt_Tanggal_Keluar As TextBox
End Class
