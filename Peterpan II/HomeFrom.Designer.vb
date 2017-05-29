<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeFrom
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
        Me.Btn_Form_Masuk = New System.Windows.Forms.Button()
        Me.Btn_Form_Keluar = New System.Windows.Forms.Button()
        Me.Btn_Form_Laporan = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btn_Form_Masuk
        '
        Me.Btn_Form_Masuk.Location = New System.Drawing.Point(26, 80)
        Me.Btn_Form_Masuk.Name = "Btn_Form_Masuk"
        Me.Btn_Form_Masuk.Size = New System.Drawing.Size(114, 23)
        Me.Btn_Form_Masuk.TabIndex = 0
        Me.Btn_Form_Masuk.Text = "Form Masuk"
        Me.Btn_Form_Masuk.UseVisualStyleBackColor = True
        '
        'Btn_Form_Keluar
        '
        Me.Btn_Form_Keluar.Location = New System.Drawing.Point(213, 80)
        Me.Btn_Form_Keluar.Name = "Btn_Form_Keluar"
        Me.Btn_Form_Keluar.Size = New System.Drawing.Size(113, 23)
        Me.Btn_Form_Keluar.TabIndex = 1
        Me.Btn_Form_Keluar.Text = "Form Keluar"
        Me.Btn_Form_Keluar.UseVisualStyleBackColor = True
        '
        'Btn_Form_Laporan
        '
        Me.Btn_Form_Laporan.Location = New System.Drawing.Point(388, 79)
        Me.Btn_Form_Laporan.Name = "Btn_Form_Laporan"
        Me.Btn_Form_Laporan.Size = New System.Drawing.Size(120, 23)
        Me.Btn_Form_Laporan.TabIndex = 2
        Me.Btn_Form_Laporan.Text = "Form Pelaporan"
        Me.Btn_Form_Laporan.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(26, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(482, 51)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "Welcome"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HomeFrom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 142)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Btn_Form_Laporan)
        Me.Controls.Add(Me.Btn_Form_Keluar)
        Me.Controls.Add(Me.Btn_Form_Masuk)
        Me.Name = "HomeFrom"
        Me.Text = "HomeFrom"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Form_Masuk As Button
    Friend WithEvents Btn_Form_Keluar As Button
    Friend WithEvents Btn_Form_Laporan As Button
    Friend WithEvents TextBox1 As TextBox
End Class
