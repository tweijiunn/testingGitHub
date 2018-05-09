<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistration
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
        Me.btnSaveRegistration = New System.Windows.Forms.Button()
        Me.lblTitleRegistration = New System.Windows.Forms.Label()
        Me.lblUnitID = New System.Windows.Forms.Label()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblIntakeCode = New System.Windows.Forms.Label()
        Me.lblStudentIDRegistration = New System.Windows.Forms.Label()
        Me.txtIntakeCode = New System.Windows.Forms.TextBox()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtStudentIDRegistration = New System.Windows.Forms.TextBox()
        Me.btnCancelRegistration = New System.Windows.Forms.Button()
        Me.btnExitRegistration = New System.Windows.Forms.Button()
        Me.cmbUnitID = New System.Windows.Forms.ComboBox()
        Me.lblUnitType = New System.Windows.Forms.Label()
        Me.cmbUnitType = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnSaveRegistration
        '
        Me.btnSaveRegistration.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveRegistration.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnSaveRegistration.FlatAppearance.BorderSize = 3
        Me.btnSaveRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveRegistration.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveRegistration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnSaveRegistration.Location = New System.Drawing.Point(487, 553)
        Me.btnSaveRegistration.Name = "btnSaveRegistration"
        Me.btnSaveRegistration.Size = New System.Drawing.Size(134, 43)
        Me.btnSaveRegistration.TabIndex = 29
        Me.btnSaveRegistration.Text = "Save"
        Me.btnSaveRegistration.UseVisualStyleBackColor = True
        '
        'lblTitleRegistration
        '
        Me.lblTitleRegistration.AutoSize = True
        Me.lblTitleRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitleRegistration.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleRegistration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblTitleRegistration.Location = New System.Drawing.Point(56, 65)
        Me.lblTitleRegistration.Name = "lblTitleRegistration"
        Me.lblTitleRegistration.Size = New System.Drawing.Size(437, 49)
        Me.lblTitleRegistration.TabIndex = 28
        Me.lblTitleRegistration.Text = "Register New Student"
        '
        'lblUnitID
        '
        Me.lblUnitID.AutoSize = True
        Me.lblUnitID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUnitID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitID.ForeColor = System.Drawing.Color.White
        Me.lblUnitID.Location = New System.Drawing.Point(56, 473)
        Me.lblUnitID.Name = "lblUnitID"
        Me.lblUnitID.Size = New System.Drawing.Size(90, 29)
        Me.lblUnitID.TabIndex = 27
        Me.lblUnitID.Text = "Unit ID:"
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailAddress.ForeColor = System.Drawing.Color.White
        Me.lblEmailAddress.Location = New System.Drawing.Point(56, 367)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(183, 29)
        Me.lblEmailAddress.TabIndex = 26
        Me.lblEmailAddress.Text = "E-mail Address:"
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblContactNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNumber.ForeColor = System.Drawing.Color.White
        Me.lblContactNumber.Location = New System.Drawing.Point(56, 314)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(193, 29)
        Me.lblContactNumber.TabIndex = 25
        Me.lblContactNumber.Text = "Contact Number:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(56, 261)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(84, 29)
        Me.lblName.TabIndex = 24
        Me.lblName.Text = "Name:"
        '
        'lblIntakeCode
        '
        Me.lblIntakeCode.AutoSize = True
        Me.lblIntakeCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblIntakeCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntakeCode.ForeColor = System.Drawing.Color.White
        Me.lblIntakeCode.Location = New System.Drawing.Point(56, 206)
        Me.lblIntakeCode.Name = "lblIntakeCode"
        Me.lblIntakeCode.Size = New System.Drawing.Size(148, 29)
        Me.lblIntakeCode.TabIndex = 23
        Me.lblIntakeCode.Text = "Intake Code:"
        '
        'lblStudentIDRegistration
        '
        Me.lblStudentIDRegistration.AutoSize = True
        Me.lblStudentIDRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblStudentIDRegistration.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentIDRegistration.ForeColor = System.Drawing.Color.White
        Me.lblStudentIDRegistration.Location = New System.Drawing.Point(56, 153)
        Me.lblStudentIDRegistration.Name = "lblStudentIDRegistration"
        Me.lblStudentIDRegistration.Size = New System.Drawing.Size(130, 29)
        Me.lblStudentIDRegistration.TabIndex = 22
        Me.lblStudentIDRegistration.Text = "Student ID:"
        '
        'txtIntakeCode
        '
        Me.txtIntakeCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtIntakeCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIntakeCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntakeCode.ForeColor = System.Drawing.Color.DarkGray
        Me.txtIntakeCode.Location = New System.Drawing.Point(255, 206)
        Me.txtIntakeCode.Name = "txtIntakeCode"
        Me.txtIntakeCode.Size = New System.Drawing.Size(366, 27)
        Me.txtIntakeCode.TabIndex = 21
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailAddress.ForeColor = System.Drawing.Color.DarkGray
        Me.txtEmailAddress.Location = New System.Drawing.Point(255, 369)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(366, 27)
        Me.txtEmailAddress.TabIndex = 20
        '
        'txtContactNumber
        '
        Me.txtContactNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContactNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber.ForeColor = System.Drawing.Color.DarkGray
        Me.txtContactNumber.Location = New System.Drawing.Point(255, 316)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(366, 27)
        Me.txtContactNumber.TabIndex = 18
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirstName.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.DarkGray
        Me.txtFirstName.Location = New System.Drawing.Point(255, 261)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(173, 29)
        Me.txtFirstName.TabIndex = 17
        Me.txtFirstName.Text = "First Name"
        Me.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLastName.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.DarkGray
        Me.txtLastName.Location = New System.Drawing.Point(444, 261)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(177, 29)
        Me.txtLastName.TabIndex = 16
        Me.txtLastName.Text = "Last Name"
        Me.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStudentIDRegistration
        '
        Me.txtStudentIDRegistration.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtStudentIDRegistration.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudentIDRegistration.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentIDRegistration.ForeColor = System.Drawing.Color.DarkGray
        Me.txtStudentIDRegistration.Location = New System.Drawing.Point(255, 153)
        Me.txtStudentIDRegistration.Name = "txtStudentIDRegistration"
        Me.txtStudentIDRegistration.Size = New System.Drawing.Size(366, 27)
        Me.txtStudentIDRegistration.TabIndex = 15
        '
        'btnCancelRegistration
        '
        Me.btnCancelRegistration.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelRegistration.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnCancelRegistration.FlatAppearance.BorderSize = 3
        Me.btnCancelRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelRegistration.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelRegistration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnCancelRegistration.Location = New System.Drawing.Point(61, 553)
        Me.btnCancelRegistration.Name = "btnCancelRegistration"
        Me.btnCancelRegistration.Size = New System.Drawing.Size(134, 43)
        Me.btnCancelRegistration.TabIndex = 30
        Me.btnCancelRegistration.Text = "Cancel"
        Me.btnCancelRegistration.UseVisualStyleBackColor = True
        '
        'btnExitRegistration
        '
        Me.btnExitRegistration.FlatAppearance.BorderSize = 0
        Me.btnExitRegistration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnExitRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExitRegistration.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitRegistration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnExitRegistration.Location = New System.Drawing.Point(665, 6)
        Me.btnExitRegistration.Name = "btnExitRegistration"
        Me.btnExitRegistration.Size = New System.Drawing.Size(37, 38)
        Me.btnExitRegistration.TabIndex = 32
        Me.btnExitRegistration.Text = "X"
        Me.btnExitRegistration.UseVisualStyleBackColor = True
        '
        'cmbUnitID
        '
        Me.cmbUnitID.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.cmbUnitID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbUnitID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnitID.FormattingEnabled = True
        Me.cmbUnitID.Location = New System.Drawing.Point(255, 475)
        Me.cmbUnitID.Name = "cmbUnitID"
        Me.cmbUnitID.Size = New System.Drawing.Size(121, 28)
        Me.cmbUnitID.TabIndex = 33
        '
        'lblUnitType
        '
        Me.lblUnitType.AutoSize = True
        Me.lblUnitType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUnitType.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitType.ForeColor = System.Drawing.Color.White
        Me.lblUnitType.Location = New System.Drawing.Point(56, 420)
        Me.lblUnitType.Name = "lblUnitType"
        Me.lblUnitType.Size = New System.Drawing.Size(122, 29)
        Me.lblUnitType.TabIndex = 34
        Me.lblUnitType.Text = "Unit Type:"
        '
        'cmbUnitType
        '
        Me.cmbUnitType.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.cmbUnitType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbUnitType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnitType.FormattingEnabled = True
        Me.cmbUnitType.Location = New System.Drawing.Point(255, 422)
        Me.cmbUnitType.Name = "cmbUnitType"
        Me.cmbUnitType.Size = New System.Drawing.Size(147, 28)
        Me.cmbUnitType.TabIndex = 35
        '
        'frmRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(704, 649)
        Me.Controls.Add(Me.cmbUnitType)
        Me.Controls.Add(Me.lblUnitType)
        Me.Controls.Add(Me.cmbUnitID)
        Me.Controls.Add(Me.btnExitRegistration)
        Me.Controls.Add(Me.btnCancelRegistration)
        Me.Controls.Add(Me.btnSaveRegistration)
        Me.Controls.Add(Me.lblTitleRegistration)
        Me.Controls.Add(Me.lblUnitID)
        Me.Controls.Add(Me.lblEmailAddress)
        Me.Controls.Add(Me.lblContactNumber)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblIntakeCode)
        Me.Controls.Add(Me.lblStudentIDRegistration)
        Me.Controls.Add(Me.txtIntakeCode)
        Me.Controls.Add(Me.txtEmailAddress)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtStudentIDRegistration)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistration"
        Me.Text = "frmRegistration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSaveRegistration As Button
    Friend WithEvents lblTitleRegistration As Label
    Friend WithEvents lblUnitID As Label
    Friend WithEvents lblEmailAddress As Label
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblIntakeCode As Label
    Friend WithEvents lblStudentIDRegistration As Label
    Friend WithEvents txtIntakeCode As TextBox
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtStudentIDRegistration As TextBox
    Friend WithEvents btnCancelRegistration As Button
    Friend WithEvents btnExitRegistration As Button
    Friend WithEvents cmbUnitID As ComboBox
    Friend WithEvents lblUnitType As Label
    Friend WithEvents cmbUnitType As ComboBox
End Class
