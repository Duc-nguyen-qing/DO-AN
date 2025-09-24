<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CHITIETHOADON
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TXTDOANHTHU = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNXUAT = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FloralWhite
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1490, 865)
        Me.DataGridView1.TabIndex = 20
        '
        'TXTDOANHTHU
        '
        Me.TXTDOANHTHU.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDOANHTHU.Location = New System.Drawing.Point(143, 915)
        Me.TXTDOANHTHU.Name = "TXTDOANHTHU"
        Me.TXTDOANHTHU.Size = New System.Drawing.Size(325, 28)
        Me.TXTDOANHTHU.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 915)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Doanh Thu :"
        '
        'BTNXUAT
        '
        Me.BTNXUAT.BorderRadius = 20
        Me.BTNXUAT.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNXUAT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNXUAT.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNXUAT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNXUAT.FillColor = System.Drawing.Color.AliceBlue
        Me.BTNXUAT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNXUAT.ForeColor = System.Drawing.Color.Black
        Me.BTNXUAT.Location = New System.Drawing.Point(886, 900)
        Me.BTNXUAT.Name = "BTNXUAT"
        Me.BTNXUAT.Size = New System.Drawing.Size(296, 43)
        Me.BTNXUAT.TabIndex = 22
        Me.BTNXUAT.Text = "Xuất Doanh Thu"
        '
        'CHITIETHOADON
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(1520, 1000)
        Me.Controls.Add(Me.TXTDOANHTHU)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTNXUAT)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CHITIETHOADON"
        Me.Text = "CHITIETHOADON"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TXTDOANHTHU As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BTNXUAT As Guna.UI2.WinForms.Guna2Button
End Class
