<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdatePayment
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
        Me.dgvUpdatePayment = New System.Windows.Forms.DataGridView()
        Me.lblTitleUpdatePayment = New System.Windows.Forms.Label()
        Me.btnCancelUpdatePayment = New System.Windows.Forms.Button()
        Me.btnSaveUpdatePayment = New System.Windows.Forms.Button()
        Me.btnExitUpdatePayment = New System.Windows.Forms.Button()
        Me.btnEditUpdatePayment = New System.Windows.Forms.Button()
        CType(Me.dgvUpdatePayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvUpdatePayment
        '
        Me.dgvUpdatePayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUpdatePayment.Location = New System.Drawing.Point(72, 119)
        Me.dgvUpdatePayment.Name = "dgvUpdatePayment"
        Me.dgvUpdatePayment.RowTemplate.Height = 24
        Me.dgvUpdatePayment.Size = New System.Drawing.Size(847, 381)
        Me.dgvUpdatePayment.TabIndex = 0
        '
        'lblTitleUpdatePayment
        '
        Me.lblTitleUpdatePayment.AutoSize = True
        Me.lblTitleUpdatePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitleUpdatePayment.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleUpdatePayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblTitleUpdatePayment.Location = New System.Drawing.Point(63, 39)
        Me.lblTitleUpdatePayment.Name = "lblTitleUpdatePayment"
        Me.lblTitleUpdatePayment.Size = New System.Drawing.Size(300, 49)
        Me.lblTitleUpdatePayment.TabIndex = 29
        Me.lblTitleUpdatePayment.Text = "Payment Entry"
        '
        'btnCancelUpdatePayment
        '
        Me.btnCancelUpdatePayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnCancelUpdatePayment.FlatAppearance.BorderSize = 3
        Me.btnCancelUpdatePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelUpdatePayment.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelUpdatePayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnCancelUpdatePayment.Location = New System.Drawing.Point(72, 531)
        Me.btnCancelUpdatePayment.Name = "btnCancelUpdatePayment"
        Me.btnCancelUpdatePayment.Size = New System.Drawing.Size(134, 43)
        Me.btnCancelUpdatePayment.TabIndex = 32
        Me.btnCancelUpdatePayment.Text = "Cancel"
        Me.btnCancelUpdatePayment.UseVisualStyleBackColor = True
        '
        'btnSaveUpdatePayment
        '
        Me.btnSaveUpdatePayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnSaveUpdatePayment.FlatAppearance.BorderSize = 3
        Me.btnSaveUpdatePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveUpdatePayment.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveUpdatePayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnSaveUpdatePayment.Location = New System.Drawing.Point(785, 531)
        Me.btnSaveUpdatePayment.Name = "btnSaveUpdatePayment"
        Me.btnSaveUpdatePayment.Size = New System.Drawing.Size(134, 43)
        Me.btnSaveUpdatePayment.TabIndex = 31
        Me.btnSaveUpdatePayment.Text = "Save"
        Me.btnSaveUpdatePayment.UseVisualStyleBackColor = True
        '
        'btnExitUpdatePayment
        '
        Me.btnExitUpdatePayment.FlatAppearance.BorderSize = 0
        Me.btnExitUpdatePayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnExitUpdatePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExitUpdatePayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitUpdatePayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnExitUpdatePayment.Location = New System.Drawing.Point(977, 0)
        Me.btnExitUpdatePayment.Name = "btnExitUpdatePayment"
        Me.btnExitUpdatePayment.Size = New System.Drawing.Size(37, 38)
        Me.btnExitUpdatePayment.TabIndex = 33
        Me.btnExitUpdatePayment.Text = "X"
        Me.btnExitUpdatePayment.UseVisualStyleBackColor = True
        '
        'btnEditUpdatePayment
        '
        Me.btnEditUpdatePayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnEditUpdatePayment.FlatAppearance.BorderSize = 3
        Me.btnEditUpdatePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditUpdatePayment.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditUpdatePayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnEditUpdatePayment.Location = New System.Drawing.Point(418, 531)
        Me.btnEditUpdatePayment.Name = "btnEditUpdatePayment"
        Me.btnEditUpdatePayment.Size = New System.Drawing.Size(134, 43)
        Me.btnEditUpdatePayment.TabIndex = 34
        Me.btnEditUpdatePayment.Text = "Edit"
        Me.btnEditUpdatePayment.UseVisualStyleBackColor = True
        '
        'frmUpdatePayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 627)
        Me.Controls.Add(Me.btnEditUpdatePayment)
        Me.Controls.Add(Me.btnExitUpdatePayment)
        Me.Controls.Add(Me.btnCancelUpdatePayment)
        Me.Controls.Add(Me.btnSaveUpdatePayment)
        Me.Controls.Add(Me.lblTitleUpdatePayment)
        Me.Controls.Add(Me.dgvUpdatePayment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUpdatePayment"
        Me.Text = "frmUpdatePayment"
        CType(Me.dgvUpdatePayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvUpdatePayment As DataGridView
    Friend WithEvents lblTitleUpdatePayment As Label
    Friend WithEvents btnCancelUpdatePayment As Button
    Friend WithEvents btnSaveUpdatePayment As Button
    Friend WithEvents btnExitUpdatePayment As Button
    Friend WithEvents btnEditUpdatePayment As Button
End Class
