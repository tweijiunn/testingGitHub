<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblSysName = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnExitLogin = New System.Windows.Forms.Button()
        Me.btnMinimizeLogin = New System.Windows.Forms.Button()
        Me.tipLogin = New System.Windows.Forms.ToolTip(Me.components)
        Me.picPasswordIcon = New System.Windows.Forms.PictureBox()
        Me.picUserIcon = New System.Windows.Forms.PictureBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        CType(Me.picPasswordIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUserIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSysName
        '
        Me.lblSysName.AutoSize = True
        Me.lblSysName.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSysName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.lblSysName.Location = New System.Drawing.Point(50, 334)
        Me.lblSysName.Name = "lblSysName"
        Me.lblSysName.Size = New System.Drawing.Size(376, 49)
        Me.lblSysName.TabIndex = 16
        Me.lblSysName.Text = "APU Hostel System"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.DarkGray
        Me.txtPassword.Location = New System.Drawing.Point(115, 507)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(301, 41)
        Me.txtPassword.TabIndex = 12
        Me.txtPassword.Text = "Password"
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tipLogin.SetToolTip(Me.txtPassword, "Please Enter Your Password")
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUser.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.DarkGray
        Me.txtUser.Location = New System.Drawing.Point(115, 420)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(301, 41)
        Me.txtUser.TabIndex = 11
        Me.txtUser.Text = "Username"
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tipLogin.SetToolTip(Me.txtUser, "Please Enter Your TP Number")
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnLogin.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(0, 609)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(483, 89)
        Me.btnLogin.TabIndex = 10
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnExitLogin
        '
        Me.btnExitLogin.FlatAppearance.BorderSize = 0
        Me.btnExitLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnExitLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExitLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnExitLogin.Location = New System.Drawing.Point(434, 17)
        Me.btnExitLogin.Name = "btnExitLogin"
        Me.btnExitLogin.Size = New System.Drawing.Size(37, 38)
        Me.btnExitLogin.TabIndex = 17
        Me.btnExitLogin.Text = "X"
        Me.btnExitLogin.UseVisualStyleBackColor = True
        '
        'btnMinimizeLogin
        '
        Me.btnMinimizeLogin.FlatAppearance.BorderSize = 0
        Me.btnMinimizeLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnMinimizeLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizeLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimizeLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnMinimizeLogin.Location = New System.Drawing.Point(391, 12)
        Me.btnMinimizeLogin.Name = "btnMinimizeLogin"
        Me.btnMinimizeLogin.Size = New System.Drawing.Size(37, 38)
        Me.btnMinimizeLogin.TabIndex = 18
        Me.btnMinimizeLogin.Text = "_"
        Me.btnMinimizeLogin.UseVisualStyleBackColor = True
        '
        'tipLogin
        '
        Me.tipLogin.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'picPasswordIcon
        '
        Me.picPasswordIcon.Image = CType(resources.GetObject("picPasswordIcon.Image"), System.Drawing.Image)
        Me.picPasswordIcon.Location = New System.Drawing.Point(49, 500)
        Me.picPasswordIcon.Name = "picPasswordIcon"
        Me.picPasswordIcon.Size = New System.Drawing.Size(60, 52)
        Me.picPasswordIcon.TabIndex = 15
        Me.picPasswordIcon.TabStop = False
        '
        'picUserIcon
        '
        Me.picUserIcon.Image = CType(resources.GetObject("picUserIcon.Image"), System.Drawing.Image)
        Me.picUserIcon.Location = New System.Drawing.Point(49, 413)
        Me.picUserIcon.Name = "picUserIcon"
        Me.picUserIcon.Size = New System.Drawing.Size(60, 53)
        Me.picUserIcon.TabIndex = 14
        Me.picUserIcon.TabStop = False
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(25, 56)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(401, 264)
        Me.picLogo.TabIndex = 13
        Me.picLogo.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(483, 698)
        Me.Controls.Add(Me.btnMinimizeLogin)
        Me.Controls.Add(Me.btnExitLogin)
        Me.Controls.Add(Me.lblSysName)
        Me.Controls.Add(Me.picPasswordIcon)
        Me.Controls.Add(Me.picUserIcon)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.btnLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.Text = "Form1"
        CType(Me.picPasswordIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUserIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSysName As Label
    Friend WithEvents picPasswordIcon As PictureBox
    Friend WithEvents picUserIcon As PictureBox
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExitLogin As Button
    Friend WithEvents btnMinimizeLogin As Button
    Friend WithEvents tipLogin As ToolTip
End Class
