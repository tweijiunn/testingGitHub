<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateStudent
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
        Me.dgvUpdateStudent = New System.Windows.Forms.DataGridView()
        Me.lblTitleUpdatePayment = New System.Windows.Forms.Label()
        Me.btnEditUpdateStudent = New System.Windows.Forms.Button()
        Me.btnCancelUpdateStudent = New System.Windows.Forms.Button()
        Me.lblTitleUpdateStudent = New System.Windows.Forms.Label()
        CType(Me.dgvUpdateStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvUpdateStudent
        '
        Me.dgvUpdateStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUpdateStudent.Location = New System.Drawing.Point(84, 123)
        Me.dgvUpdateStudent.Name = "dgvUpdateStudent"
        Me.dgvUpdateStudent.RowTemplate.Height = 24
        Me.dgvUpdateStudent.Size = New System.Drawing.Size(847, 381)
        Me.dgvUpdateStudent.TabIndex = 1
        '
        'lblTitleUpdatePayment
        '
        Me.lblTitleUpdatePayment.AutoSize = True
        Me.lblTitleUpdatePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitleUpdatePayment.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleUpdatePayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblTitleUpdatePayment.Location = New System.Drawing.Point(75, 42)
        Me.lblTitleUpdatePayment.Name = "lblTitleUpdatePayment"
        Me.lblTitleUpdatePayment.Size = New System.Drawing.Size(300, 49)
        Me.lblTitleUpdatePayment.TabIndex = 30
        Me.lblTitleUpdatePayment.Text = "Payment Entry"
        '
        'btnEditUpdateStudent
        '
        Me.btnEditUpdateStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnEditUpdateStudent.FlatAppearance.BorderSize = 3
        Me.btnEditUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditUpdateStudent.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditUpdateStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnEditUpdateStudent.Location = New System.Drawing.Point(797, 538)
        Me.btnEditUpdateStudent.Name = "btnEditUpdateStudent"
        Me.btnEditUpdateStudent.Size = New System.Drawing.Size(134, 43)
        Me.btnEditUpdateStudent.TabIndex = 38
        Me.btnEditUpdateStudent.Text = "Edit"
        Me.btnEditUpdateStudent.UseVisualStyleBackColor = True
        '
        'btnCancelUpdateStudent
        '
        Me.btnCancelUpdateStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnCancelUpdateStudent.FlatAppearance.BorderSize = 3
        Me.btnCancelUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelUpdateStudent.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelUpdateStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnCancelUpdateStudent.Location = New System.Drawing.Point(88, 538)
        Me.btnCancelUpdateStudent.Name = "btnCancelUpdateStudent"
        Me.btnCancelUpdateStudent.Size = New System.Drawing.Size(134, 43)
        Me.btnCancelUpdateStudent.TabIndex = 37
        Me.btnCancelUpdateStudent.Text = "Cancel"
        Me.btnCancelUpdateStudent.UseVisualStyleBackColor = True
        '
        'lblTitleUpdateStudent
        '
        Me.lblTitleUpdateStudent.AutoSize = True
        Me.lblTitleUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitleUpdateStudent.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleUpdateStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblTitleUpdateStudent.Location = New System.Drawing.Point(79, 46)
        Me.lblTitleUpdateStudent.Name = "lblTitleUpdateStudent"
        Me.lblTitleUpdateStudent.Size = New System.Drawing.Size(297, 49)
        Me.lblTitleUpdateStudent.TabIndex = 35
        Me.lblTitleUpdateStudent.Text = "Student Detail"
        '
        'frmUpdateStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 627)
        Me.Controls.Add(Me.btnEditUpdateStudent)
        Me.Controls.Add(Me.btnCancelUpdateStudent)
        Me.Controls.Add(Me.lblTitleUpdateStudent)
        Me.Controls.Add(Me.lblTitleUpdatePayment)
        Me.Controls.Add(Me.dgvUpdateStudent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUpdateStudent"
        Me.Text = "frmUpdateStudent"
        CType(Me.dgvUpdateStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvUpdateStudent As DataGridView
    Friend WithEvents lblTitleUpdatePayment As Label
    Friend WithEvents btnEditUpdateStudent As Button
    Friend WithEvents btnCancelUpdateStudent As Button
    Friend WithEvents lblTitleUpdateStudent As Label
End Class
