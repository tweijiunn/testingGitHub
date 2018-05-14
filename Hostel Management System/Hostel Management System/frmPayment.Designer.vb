<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Me.txtSearchPayment = New System.Windows.Forms.TextBox()
        Me.lblStudentIDPayment = New System.Windows.Forms.Label()
        Me.lblUnitID = New System.Windows.Forms.Label()
        Me.lblEntryDate = New System.Windows.Forms.Label()
        Me.dtpPaymentDate = New System.Windows.Forms.DateTimePicker()
        Me.lblLoggedBy = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblAmountDue = New System.Windows.Forms.Label()
        Me.lblAmountPaid = New System.Windows.Forms.Label()
        Me.lblPaymentDate = New System.Windows.Forms.Label()
        Me.dtpEntryDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDatePayment = New System.Windows.Forms.Label()
        Me.lblTimePayment = New System.Windows.Forms.Label()
        Me.tmrTimePayment = New System.Windows.Forms.Timer(Me.components)
        Me.txtAmountPaid = New System.Windows.Forms.TextBox()
        Me.txtLoggedBy = New System.Windows.Forms.TextBox()
        Me.txtUnitID = New System.Windows.Forms.TextBox()
        Me.txtStudentIDPayment = New System.Windows.Forms.TextBox()
        Me.txtAmountDue = New System.Windows.Forms.TextBox()
        Me.lblRMAmountPaid = New System.Windows.Forms.Label()
        Me.lblRMAmountDue = New System.Windows.Forms.Label()
        Me.btnExitPayment = New System.Windows.Forms.Button()
        Me.btnSearchPayment = New System.Windows.Forms.Button()
        Me.btnSavePayment = New System.Windows.Forms.Button()
        Me.btnCancelPayment = New System.Windows.Forms.Button()
        Me.lblTitlePayment = New System.Windows.Forms.Label()
        Me.lblPaymentID = New System.Windows.Forms.Label()
        Me.txtPaymentID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtSearchPayment
        '
        Me.txtSearchPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtSearchPayment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchPayment.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchPayment.ForeColor = System.Drawing.Color.DarkGray
        Me.txtSearchPayment.Location = New System.Drawing.Point(25, 214)
        Me.txtSearchPayment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSearchPayment.Name = "txtSearchPayment"
        Me.txtSearchPayment.Size = New System.Drawing.Size(323, 45)
        Me.txtSearchPayment.TabIndex = 0
        Me.txtSearchPayment.Text = "TP Number"
        Me.txtSearchPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblStudentIDPayment
        '
        Me.lblStudentIDPayment.AutoSize = True
        Me.lblStudentIDPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentIDPayment.ForeColor = System.Drawing.Color.White
        Me.lblStudentIDPayment.Location = New System.Drawing.Point(590, 289)
        Me.lblStudentIDPayment.Name = "lblStudentIDPayment"
        Me.lblStudentIDPayment.Size = New System.Drawing.Size(156, 32)
        Me.lblStudentIDPayment.TabIndex = 3
        Me.lblStudentIDPayment.Text = "Student ID:"
        '
        'lblUnitID
        '
        Me.lblUnitID.AutoSize = True
        Me.lblUnitID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitID.ForeColor = System.Drawing.Color.White
        Me.lblUnitID.Location = New System.Drawing.Point(21, 366)
        Me.lblUnitID.Name = "lblUnitID"
        Me.lblUnitID.Size = New System.Drawing.Size(108, 32)
        Me.lblUnitID.TabIndex = 4
        Me.lblUnitID.Text = "Unit ID:"
        '
        'lblEntryDate
        '
        Me.lblEntryDate.AutoSize = True
        Me.lblEntryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntryDate.ForeColor = System.Drawing.Color.White
        Me.lblEntryDate.Location = New System.Drawing.Point(21, 521)
        Me.lblEntryDate.Name = "lblEntryDate"
        Me.lblEntryDate.Size = New System.Drawing.Size(156, 32)
        Me.lblEntryDate.TabIndex = 5
        Me.lblEntryDate.Text = "Entry Date:"
        '
        'dtpPaymentDate
        '
        Me.dtpPaymentDate.CalendarFont = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPaymentDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.dtpPaymentDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.dtpPaymentDate.CalendarTitleForeColor = System.Drawing.Color.LightGray
        Me.dtpPaymentDate.CalendarTrailingForeColor = System.Drawing.Color.LightGray
        Me.dtpPaymentDate.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPaymentDate.Location = New System.Drawing.Point(217, 846)
        Me.dtpPaymentDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpPaymentDate.Name = "dtpPaymentDate"
        Me.dtpPaymentDate.Size = New System.Drawing.Size(282, 41)
        Me.dtpPaymentDate.TabIndex = 6
        '
        'lblLoggedBy
        '
        Me.lblLoggedBy.AutoSize = True
        Me.lblLoggedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoggedBy.ForeColor = System.Drawing.Color.White
        Me.lblLoggedBy.Location = New System.Drawing.Point(21, 444)
        Me.lblLoggedBy.Name = "lblLoggedBy"
        Me.lblLoggedBy.Size = New System.Drawing.Size(159, 32)
        Me.lblLoggedBy.TabIndex = 7
        Me.lblLoggedBy.Text = "Logged By:"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.White
        Me.lblDescription.Location = New System.Drawing.Point(20, 599)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(166, 32)
        Me.lblDescription.TabIndex = 8
        Me.lblDescription.Text = "Description:"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(217, 602)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(849, 125)
        Me.txtDescription.TabIndex = 9
        '
        'lblAmountDue
        '
        Me.lblAmountDue.AutoSize = True
        Me.lblAmountDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountDue.ForeColor = System.Drawing.Color.White
        Me.lblAmountDue.Location = New System.Drawing.Point(590, 366)
        Me.lblAmountDue.Name = "lblAmountDue"
        Me.lblAmountDue.Size = New System.Drawing.Size(180, 32)
        Me.lblAmountDue.TabIndex = 10
        Me.lblAmountDue.Text = "Amount Due:"
        '
        'lblAmountPaid
        '
        Me.lblAmountPaid.AutoSize = True
        Me.lblAmountPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountPaid.ForeColor = System.Drawing.Color.White
        Me.lblAmountPaid.Location = New System.Drawing.Point(21, 774)
        Me.lblAmountPaid.Name = "lblAmountPaid"
        Me.lblAmountPaid.Size = New System.Drawing.Size(186, 32)
        Me.lblAmountPaid.TabIndex = 11
        Me.lblAmountPaid.Text = "Amount Paid:"
        '
        'lblPaymentDate
        '
        Me.lblPaymentDate.AutoSize = True
        Me.lblPaymentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentDate.ForeColor = System.Drawing.Color.White
        Me.lblPaymentDate.Location = New System.Drawing.Point(21, 851)
        Me.lblPaymentDate.Name = "lblPaymentDate"
        Me.lblPaymentDate.Size = New System.Drawing.Size(202, 32)
        Me.lblPaymentDate.TabIndex = 12
        Me.lblPaymentDate.Text = "Payment Date:"
        '
        'dtpEntryDate
        '
        Me.dtpEntryDate.CalendarFont = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEntryDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.dtpEntryDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.dtpEntryDate.CalendarTitleForeColor = System.Drawing.Color.LightGray
        Me.dtpEntryDate.CalendarTrailingForeColor = System.Drawing.Color.LightGray
        Me.dtpEntryDate.Enabled = False
        Me.dtpEntryDate.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEntryDate.Location = New System.Drawing.Point(217, 518)
        Me.dtpEntryDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpEntryDate.Name = "dtpEntryDate"
        Me.dtpEntryDate.Size = New System.Drawing.Size(282, 41)
        Me.dtpEntryDate.TabIndex = 13
        '
        'lblDatePayment
        '
        Me.lblDatePayment.AutoSize = True
        Me.lblDatePayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatePayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.lblDatePayment.Location = New System.Drawing.Point(770, 135)
        Me.lblDatePayment.Name = "lblDatePayment"
        Me.lblDatePayment.Size = New System.Drawing.Size(75, 32)
        Me.lblDatePayment.TabIndex = 29
        Me.lblDatePayment.Text = "Date"
        '
        'lblTimePayment
        '
        Me.lblTimePayment.AutoSize = True
        Me.lblTimePayment.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimePayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.lblTimePayment.Location = New System.Drawing.Point(789, 45)
        Me.lblTimePayment.Name = "lblTimePayment"
        Me.lblTimePayment.Size = New System.Drawing.Size(112, 49)
        Me.lblTimePayment.TabIndex = 28
        Me.lblTimePayment.Text = "Time"
        '
        'tmrTimePayment
        '
        '
        'txtAmountPaid
        '
        Me.txtAmountPaid.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtAmountPaid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAmountPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountPaid.Location = New System.Drawing.Point(268, 771)
        Me.txtAmountPaid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAmountPaid.Name = "txtAmountPaid"
        Me.txtAmountPaid.Size = New System.Drawing.Size(232, 32)
        Me.txtAmountPaid.TabIndex = 30
        '
        'txtLoggedBy
        '
        Me.txtLoggedBy.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtLoggedBy.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLoggedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoggedBy.Location = New System.Drawing.Point(217, 444)
        Me.txtLoggedBy.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLoggedBy.Name = "txtLoggedBy"
        Me.txtLoggedBy.Size = New System.Drawing.Size(849, 32)
        Me.txtLoggedBy.TabIndex = 31
        '
        'txtUnitID
        '
        Me.txtUnitID.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtUnitID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUnitID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitID.Location = New System.Drawing.Point(217, 366)
        Me.txtUnitID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUnitID.Name = "txtUnitID"
        Me.txtUnitID.Size = New System.Drawing.Size(282, 32)
        Me.txtUnitID.TabIndex = 32
        '
        'txtStudentIDPayment
        '
        Me.txtStudentIDPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtStudentIDPayment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudentIDPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentIDPayment.Location = New System.Drawing.Point(784, 289)
        Me.txtStudentIDPayment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStudentIDPayment.Name = "txtStudentIDPayment"
        Me.txtStudentIDPayment.Size = New System.Drawing.Size(282, 32)
        Me.txtStudentIDPayment.TabIndex = 34
        '
        'txtAmountDue
        '
        Me.txtAmountDue.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAmountDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountDue.Location = New System.Drawing.Point(834, 366)
        Me.txtAmountDue.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAmountDue.Name = "txtAmountDue"
        Me.txtAmountDue.Size = New System.Drawing.Size(233, 32)
        Me.txtAmountDue.TabIndex = 35
        '
        'lblRMAmountPaid
        '
        Me.lblRMAmountPaid.AutoSize = True
        Me.lblRMAmountPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRMAmountPaid.ForeColor = System.Drawing.Color.White
        Me.lblRMAmountPaid.Location = New System.Drawing.Point(212, 772)
        Me.lblRMAmountPaid.Name = "lblRMAmountPaid"
        Me.lblRMAmountPaid.Size = New System.Drawing.Size(58, 32)
        Me.lblRMAmountPaid.TabIndex = 36
        Me.lblRMAmountPaid.Text = "RM"
        '
        'lblRMAmountDue
        '
        Me.lblRMAmountDue.AutoSize = True
        Me.lblRMAmountDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRMAmountDue.ForeColor = System.Drawing.Color.White
        Me.lblRMAmountDue.Location = New System.Drawing.Point(778, 366)
        Me.lblRMAmountDue.Name = "lblRMAmountDue"
        Me.lblRMAmountDue.Size = New System.Drawing.Size(58, 32)
        Me.lblRMAmountDue.TabIndex = 37
        Me.lblRMAmountDue.Text = "RM"
        '
        'btnExitPayment
        '
        Me.btnExitPayment.FlatAppearance.BorderSize = 0
        Me.btnExitPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnExitPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExitPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitPayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnExitPayment.Location = New System.Drawing.Point(1098, 0)
        Me.btnExitPayment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExitPayment.Name = "btnExitPayment"
        Me.btnExitPayment.Size = New System.Drawing.Size(42, 48)
        Me.btnExitPayment.TabIndex = 38
        Me.btnExitPayment.Text = "X"
        Me.btnExitPayment.UseVisualStyleBackColor = True
        '
        'btnSearchPayment
        '
        Me.btnSearchPayment.FlatAppearance.BorderSize = 0
        Me.btnSearchPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchPayment.Image = Global.Hostel_Management_System.My.Resources.Resources.SearchIcon2
        Me.btnSearchPayment.Location = New System.Drawing.Point(354, 216)
        Me.btnSearchPayment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSearchPayment.Name = "btnSearchPayment"
        Me.btnSearchPayment.Size = New System.Drawing.Size(45, 42)
        Me.btnSearchPayment.TabIndex = 1
        Me.btnSearchPayment.UseVisualStyleBackColor = True
        '
        'btnSavePayment
        '
        Me.btnSavePayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnSavePayment.FlatAppearance.BorderSize = 3
        Me.btnSavePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSavePayment.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavePayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnSavePayment.Location = New System.Drawing.Point(916, 935)
        Me.btnSavePayment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSavePayment.Name = "btnSavePayment"
        Me.btnSavePayment.Size = New System.Drawing.Size(151, 54)
        Me.btnSavePayment.TabIndex = 39
        Me.btnSavePayment.Text = "Save"
        Me.btnSavePayment.UseVisualStyleBackColor = True
        '
        'btnCancelPayment
        '
        Me.btnCancelPayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnCancelPayment.FlatAppearance.BorderSize = 3
        Me.btnCancelPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelPayment.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelPayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnCancelPayment.Location = New System.Drawing.Point(25, 935)
        Me.btnCancelPayment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancelPayment.Name = "btnCancelPayment"
        Me.btnCancelPayment.Size = New System.Drawing.Size(151, 54)
        Me.btnCancelPayment.TabIndex = 40
        Me.btnCancelPayment.Text = "Cancel"
        Me.btnCancelPayment.UseVisualStyleBackColor = True
        '
        'lblTitlePayment
        '
        Me.lblTitlePayment.AutoSize = True
        Me.lblTitlePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitlePayment.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitlePayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblTitlePayment.Location = New System.Drawing.Point(17, 70)
        Me.lblTitlePayment.Name = "lblTitlePayment"
        Me.lblTitlePayment.Size = New System.Drawing.Size(392, 58)
        Me.lblTitlePayment.TabIndex = 41
        Me.lblTitlePayment.Text = "Rental Payment"
        '
        'lblPaymentID
        '
        Me.lblPaymentID.AutoSize = True
        Me.lblPaymentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentID.ForeColor = System.Drawing.Color.White
        Me.lblPaymentID.Location = New System.Drawing.Point(21, 289)
        Me.lblPaymentID.Name = "lblPaymentID"
        Me.lblPaymentID.Size = New System.Drawing.Size(169, 32)
        Me.lblPaymentID.TabIndex = 2
        Me.lblPaymentID.Text = "Payment ID:"
        '
        'txtPaymentID
        '
        Me.txtPaymentID.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtPaymentID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPaymentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentID.Location = New System.Drawing.Point(217, 289)
        Me.txtPaymentID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPaymentID.Name = "txtPaymentID"
        Me.txtPaymentID.Size = New System.Drawing.Size(282, 32)
        Me.txtPaymentID.TabIndex = 33
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1141, 1016)
        Me.Controls.Add(Me.lblTitlePayment)
        Me.Controls.Add(Me.btnCancelPayment)
        Me.Controls.Add(Me.btnSavePayment)
        Me.Controls.Add(Me.btnExitPayment)
        Me.Controls.Add(Me.lblRMAmountDue)
        Me.Controls.Add(Me.lblRMAmountPaid)
        Me.Controls.Add(Me.txtAmountDue)
        Me.Controls.Add(Me.txtStudentIDPayment)
        Me.Controls.Add(Me.txtPaymentID)
        Me.Controls.Add(Me.txtUnitID)
        Me.Controls.Add(Me.txtLoggedBy)
        Me.Controls.Add(Me.txtAmountPaid)
        Me.Controls.Add(Me.lblDatePayment)
        Me.Controls.Add(Me.lblTimePayment)
        Me.Controls.Add(Me.dtpEntryDate)
        Me.Controls.Add(Me.lblPaymentDate)
        Me.Controls.Add(Me.lblAmountPaid)
        Me.Controls.Add(Me.lblAmountDue)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblLoggedBy)
        Me.Controls.Add(Me.dtpPaymentDate)
        Me.Controls.Add(Me.lblEntryDate)
        Me.Controls.Add(Me.lblUnitID)
        Me.Controls.Add(Me.lblStudentIDPayment)
        Me.Controls.Add(Me.lblPaymentID)
        Me.Controls.Add(Me.btnSearchPayment)
        Me.Controls.Add(Me.txtSearchPayment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmPayment"
        Me.Text = "frmPayment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearchPayment As TextBox
    Friend WithEvents btnSearchPayment As Button
    Friend WithEvents lblStudentIDPayment As Label
    Friend WithEvents lblUnitID As Label
    Friend WithEvents lblEntryDate As Label
    Friend WithEvents dtpPaymentDate As DateTimePicker
    Friend WithEvents lblLoggedBy As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblAmountDue As Label
    Friend WithEvents lblAmountPaid As Label
    Friend WithEvents lblPaymentDate As Label
    Friend WithEvents dtpEntryDate As DateTimePicker
    Friend WithEvents lblDatePayment As Label
    Friend WithEvents lblTimePayment As Label
    Friend WithEvents tmrTimePayment As Timer
    Friend WithEvents txtAmountPaid As TextBox
    Friend WithEvents txtLoggedBy As TextBox
    Friend WithEvents txtUnitID As TextBox
    Friend WithEvents txtStudentIDPayment As TextBox
    Friend WithEvents txtAmountDue As TextBox
    Friend WithEvents lblRMAmountPaid As Label
    Friend WithEvents lblRMAmountDue As Label
    Friend WithEvents btnExitPayment As Button
    Friend WithEvents btnSavePayment As Button
    Friend WithEvents btnCancelPayment As Button
    Friend WithEvents lblTitlePayment As Label
    Friend WithEvents lblPaymentID As Label
    Friend WithEvents txtPaymentID As TextBox
End Class
