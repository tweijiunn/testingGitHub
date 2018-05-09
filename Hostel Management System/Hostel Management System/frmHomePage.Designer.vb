<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHomePage
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHomePage))
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnReportIcon = New System.Windows.Forms.Button()
        Me.btnPaymentIcon = New System.Windows.Forms.Button()
        Me.btnUpdateIcon = New System.Windows.Forms.Button()
        Me.btnRegistrationIcon = New System.Windows.Forms.Button()
        Me.picLogoHomePage = New System.Windows.Forms.PictureBox()
        Me.btnExtendMenu2 = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblTimeHomePage = New System.Windows.Forms.Label()
        Me.lblDateHomePage = New System.Windows.Forms.Label()
        Me.lblTPNumberBottomLabel = New System.Windows.Forms.Label()
        Me.lblNameBottomLabel = New System.Windows.Forms.Label()
        Me.pnlExtendedMenu = New System.Windows.Forms.Panel()
        Me.btnEditEntry = New System.Windows.Forms.Button()
        Me.btnNewEntry = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.picDropDown = New System.Windows.Forms.PictureBox()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnRegistration = New System.Windows.Forms.Button()
        Me.tmrTimeHomePage = New System.Windows.Forms.Timer(Me.components)
        Me.btnMinimizeHomePage = New System.Windows.Forms.Button()
        Me.btnExitHomePage = New System.Windows.Forms.Button()
        Me.pnlMenu.SuspendLayout()
        CType(Me.picLogoHomePage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlExtendedMenu.SuspendLayout()
        CType(Me.picDropDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.btnReportIcon)
        Me.pnlMenu.Controls.Add(Me.btnPaymentIcon)
        Me.pnlMenu.Controls.Add(Me.btnUpdateIcon)
        Me.pnlMenu.Controls.Add(Me.btnRegistrationIcon)
        Me.pnlMenu.Controls.Add(Me.picLogoHomePage)
        Me.pnlMenu.Controls.Add(Me.btnExtendMenu2)
        Me.pnlMenu.Location = New System.Drawing.Point(0, 2)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(87, 689)
        Me.pnlMenu.TabIndex = 9
        '
        'btnReportIcon
        '
        Me.btnReportIcon.FlatAppearance.BorderSize = 0
        Me.btnReportIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportIcon.Image = CType(resources.GetObject("btnReportIcon.Image"), System.Drawing.Image)
        Me.btnReportIcon.Location = New System.Drawing.Point(14, 358)
        Me.btnReportIcon.Name = "btnReportIcon"
        Me.btnReportIcon.Size = New System.Drawing.Size(65, 71)
        Me.btnReportIcon.TabIndex = 11
        Me.btnReportIcon.UseVisualStyleBackColor = True
        '
        'btnPaymentIcon
        '
        Me.btnPaymentIcon.FlatAppearance.BorderSize = 0
        Me.btnPaymentIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaymentIcon.Image = CType(resources.GetObject("btnPaymentIcon.Image"), System.Drawing.Image)
        Me.btnPaymentIcon.Location = New System.Drawing.Point(14, 274)
        Me.btnPaymentIcon.Name = "btnPaymentIcon"
        Me.btnPaymentIcon.Size = New System.Drawing.Size(65, 71)
        Me.btnPaymentIcon.TabIndex = 10
        Me.btnPaymentIcon.UseVisualStyleBackColor = True
        '
        'btnUpdateIcon
        '
        Me.btnUpdateIcon.FlatAppearance.BorderSize = 0
        Me.btnUpdateIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateIcon.Image = CType(resources.GetObject("btnUpdateIcon.Image"), System.Drawing.Image)
        Me.btnUpdateIcon.Location = New System.Drawing.Point(14, 185)
        Me.btnUpdateIcon.Name = "btnUpdateIcon"
        Me.btnUpdateIcon.Size = New System.Drawing.Size(65, 71)
        Me.btnUpdateIcon.TabIndex = 9
        Me.btnUpdateIcon.UseVisualStyleBackColor = True
        '
        'btnRegistrationIcon
        '
        Me.btnRegistrationIcon.FlatAppearance.BorderSize = 0
        Me.btnRegistrationIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrationIcon.Image = CType(resources.GetObject("btnRegistrationIcon.Image"), System.Drawing.Image)
        Me.btnRegistrationIcon.Location = New System.Drawing.Point(14, 96)
        Me.btnRegistrationIcon.Name = "btnRegistrationIcon"
        Me.btnRegistrationIcon.Size = New System.Drawing.Size(70, 69)
        Me.btnRegistrationIcon.TabIndex = 8
        Me.btnRegistrationIcon.UseVisualStyleBackColor = True
        '
        'picLogoHomePage
        '
        Me.picLogoHomePage.BackgroundImage = CType(resources.GetObject("picLogoHomePage.BackgroundImage"), System.Drawing.Image)
        Me.picLogoHomePage.Location = New System.Drawing.Point(3, 10)
        Me.picLogoHomePage.Name = "picLogoHomePage"
        Me.picLogoHomePage.Size = New System.Drawing.Size(81, 65)
        Me.picLogoHomePage.TabIndex = 7
        Me.picLogoHomePage.TabStop = False
        '
        'btnExtendMenu2
        '
        Me.btnExtendMenu2.FlatAppearance.BorderSize = 0
        Me.btnExtendMenu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExtendMenu2.Image = CType(resources.GetObject("btnExtendMenu2.Image"), System.Drawing.Image)
        Me.btnExtendMenu2.Location = New System.Drawing.Point(12, 599)
        Me.btnExtendMenu2.Name = "btnExtendMenu2"
        Me.btnExtendMenu2.Size = New System.Drawing.Size(66, 68)
        Me.btnExtendMenu2.TabIndex = 0
        Me.btnExtendMenu2.UseVisualStyleBackColor = True
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.Cyan
        Me.lblWelcome.Location = New System.Drawing.Point(158, 229)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(352, 110)
        Me.lblWelcome.TabIndex = 22
        Me.lblWelcome.Text = "Welcome back," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " (Name)!"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimeHomePage
        '
        Me.lblTimeHomePage.AutoSize = True
        Me.lblTimeHomePage.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeHomePage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.lblTimeHomePage.Location = New System.Drawing.Point(352, 60)
        Me.lblTimeHomePage.Name = "lblTimeHomePage"
        Me.lblTimeHomePage.Size = New System.Drawing.Size(88, 40)
        Me.lblTimeHomePage.TabIndex = 26
        Me.lblTimeHomePage.Text = "Time"
        '
        'lblDateHomePage
        '
        Me.lblDateHomePage.AutoSize = True
        Me.lblDateHomePage.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateHomePage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.lblDateHomePage.Location = New System.Drawing.Point(334, 126)
        Me.lblDateHomePage.Name = "lblDateHomePage"
        Me.lblDateHomePage.Size = New System.Drawing.Size(63, 29)
        Me.lblDateHomePage.TabIndex = 27
        Me.lblDateHomePage.Text = "Date"
        '
        'lblTPNumberBottomLabel
        '
        Me.lblTPNumberBottomLabel.AutoSize = True
        Me.lblTPNumberBottomLabel.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTPNumberBottomLabel.ForeColor = System.Drawing.Color.White
        Me.lblTPNumberBottomLabel.Location = New System.Drawing.Point(445, 642)
        Me.lblTPNumberBottomLabel.Name = "lblTPNumberBottomLabel"
        Me.lblTPNumberBottomLabel.Size = New System.Drawing.Size(97, 19)
        Me.lblTPNumberBottomLabel.TabIndex = 28
        Me.lblTPNumberBottomLabel.Text = "TP Number"
        '
        'lblNameBottomLabel
        '
        Me.lblNameBottomLabel.AutoSize = True
        Me.lblNameBottomLabel.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameBottomLabel.ForeColor = System.Drawing.Color.White
        Me.lblNameBottomLabel.Location = New System.Drawing.Point(113, 642)
        Me.lblNameBottomLabel.Name = "lblNameBottomLabel"
        Me.lblNameBottomLabel.Size = New System.Drawing.Size(60, 19)
        Me.lblNameBottomLabel.TabIndex = 29
        Me.lblNameBottomLabel.Text = "Name"
        '
        'pnlExtendedMenu
        '
        Me.pnlExtendedMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.pnlExtendedMenu.Controls.Add(Me.btnEditEntry)
        Me.pnlExtendedMenu.Controls.Add(Me.btnNewEntry)
        Me.pnlExtendedMenu.Controls.Add(Me.btnReport)
        Me.pnlExtendedMenu.Controls.Add(Me.picDropDown)
        Me.pnlExtendedMenu.Controls.Add(Me.btnPayment)
        Me.pnlExtendedMenu.Controls.Add(Me.btnUpdate)
        Me.pnlExtendedMenu.Controls.Add(Me.btnRegistration)
        Me.pnlExtendedMenu.Location = New System.Drawing.Point(84, -4)
        Me.pnlExtendedMenu.Name = "pnlExtendedMenu"
        Me.pnlExtendedMenu.Size = New System.Drawing.Size(222, 689)
        Me.pnlExtendedMenu.TabIndex = 33
        '
        'btnEditEntry
        '
        Me.btnEditEntry.FlatAppearance.BorderSize = 0
        Me.btnEditEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditEntry.Font = New System.Drawing.Font("Century Gothic", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditEntry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEditEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditEntry.Location = New System.Drawing.Point(20, 387)
        Me.btnEditEntry.Name = "btnEditEntry"
        Me.btnEditEntry.Size = New System.Drawing.Size(199, 54)
        Me.btnEditEntry.TabIndex = 11
        Me.btnEditEntry.Text = "Edit Entry"
        Me.btnEditEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditEntry.UseVisualStyleBackColor = True
        '
        'btnNewEntry
        '
        Me.btnNewEntry.FlatAppearance.BorderSize = 0
        Me.btnNewEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewEntry.Font = New System.Drawing.Font("Century Gothic", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewEntry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNewEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewEntry.Location = New System.Drawing.Point(20, 343)
        Me.btnNewEntry.Name = "btnNewEntry"
        Me.btnNewEntry.Size = New System.Drawing.Size(202, 54)
        Me.btnNewEntry.TabIndex = 10
        Me.btnNewEntry.Text = "New Entry"
        Me.btnNewEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewEntry.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.Location = New System.Drawing.Point(20, 374)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(199, 54)
        Me.btnReport.TabIndex = 9
        Me.btnReport.Text = "Report"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'picDropDown
        '
        Me.picDropDown.Image = CType(resources.GetObject("picDropDown.Image"), System.Drawing.Image)
        Me.picDropDown.Location = New System.Drawing.Point(177, 307)
        Me.picDropDown.Name = "picDropDown"
        Me.picDropDown.Size = New System.Drawing.Size(30, 30)
        Me.picDropDown.TabIndex = 6
        Me.picDropDown.TabStop = False
        '
        'btnPayment
        '
        Me.btnPayment.FlatAppearance.BorderSize = 0
        Me.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayment.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.ForeColor = System.Drawing.Color.White
        Me.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayment.Location = New System.Drawing.Point(17, 290)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(205, 54)
        Me.btnPayment.TabIndex = 5
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(16, 203)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(241, 54)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnRegistration
        '
        Me.btnRegistration.FlatAppearance.BorderSize = 0
        Me.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistration.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistration.ForeColor = System.Drawing.Color.White
        Me.btnRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistration.Location = New System.Drawing.Point(17, 115)
        Me.btnRegistration.Name = "btnRegistration"
        Me.btnRegistration.Size = New System.Drawing.Size(241, 54)
        Me.btnRegistration.TabIndex = 3
        Me.btnRegistration.Text = "Registration"
        Me.btnRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistration.UseVisualStyleBackColor = True
        '
        'tmrTimeHomePage
        '
        '
        'btnMinimizeHomePage
        '
        Me.btnMinimizeHomePage.FlatAppearance.BorderSize = 0
        Me.btnMinimizeHomePage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnMinimizeHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizeHomePage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimizeHomePage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnMinimizeHomePage.Location = New System.Drawing.Point(554, 1)
        Me.btnMinimizeHomePage.Name = "btnMinimizeHomePage"
        Me.btnMinimizeHomePage.Size = New System.Drawing.Size(37, 38)
        Me.btnMinimizeHomePage.TabIndex = 35
        Me.btnMinimizeHomePage.Text = "_"
        Me.btnMinimizeHomePage.UseVisualStyleBackColor = True
        '
        'btnExitHomePage
        '
        Me.btnExitHomePage.FlatAppearance.BorderSize = 0
        Me.btnExitHomePage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnExitHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExitHomePage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitHomePage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnExitHomePage.Location = New System.Drawing.Point(597, 6)
        Me.btnExitHomePage.Name = "btnExitHomePage"
        Me.btnExitHomePage.Size = New System.Drawing.Size(37, 38)
        Me.btnExitHomePage.TabIndex = 34
        Me.btnExitHomePage.Text = "X"
        Me.btnExitHomePage.UseVisualStyleBackColor = True
        '
        'frmHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(638, 681)
        Me.Controls.Add(Me.btnMinimizeHomePage)
        Me.Controls.Add(Me.btnExitHomePage)
        Me.Controls.Add(Me.pnlExtendedMenu)
        Me.Controls.Add(Me.lblNameBottomLabel)
        Me.Controls.Add(Me.lblTPNumberBottomLabel)
        Me.Controls.Add(Me.lblDateHomePage)
        Me.Controls.Add(Me.lblTimeHomePage)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.pnlMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHomePage"
        Me.Text = "frmHomePage3"
        Me.pnlMenu.ResumeLayout(False)
        CType(Me.picLogoHomePage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlExtendedMenu.ResumeLayout(False)
        CType(Me.picDropDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btnUpdateIcon As Button
    Friend WithEvents btnRegistrationIcon As Button
    Friend WithEvents picLogoHomePage As PictureBox
    Friend WithEvents btnExtendMenu2 As Button
    Friend WithEvents btnPaymentIcon As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblTimeHomePage As Label
    Friend WithEvents lblDateHomePage As Label
    Friend WithEvents lblTPNumberBottomLabel As Label
    Friend WithEvents lblNameBottomLabel As Label
    Friend WithEvents pnlExtendedMenu As Panel
    Friend WithEvents btnPayment As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnRegistration As Button
    Friend WithEvents tmrTimeHomePage As Timer
    Friend WithEvents btnMinimizeHomePage As Button
    Friend WithEvents btnExitHomePage As Button
    Friend WithEvents picDropDown As PictureBox
    Friend WithEvents btnReportIcon As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnEditEntry As Button
    Friend WithEvents btnNewEntry As Button
End Class
