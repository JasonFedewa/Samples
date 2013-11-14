<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogin
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
        Me.btnLoginCancel = New System.Windows.Forms.Button()
        Me.btnLoginCommit = New System.Windows.Forms.Button()
        Me.txtLoginPass = New System.Windows.Forms.TextBox()
        Me.txtLoginId = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblLoginName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLoginCancel
        '
        Me.btnLoginCancel.Location = New System.Drawing.Point(128, 62)
        Me.btnLoginCancel.Name = "btnLoginCancel"
        Me.btnLoginCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnLoginCancel.TabIndex = 17
        Me.btnLoginCancel.Text = "Cancel"
        Me.btnLoginCancel.UseVisualStyleBackColor = True
        '
        'btnLoginCommit
        '
        Me.btnLoginCommit.Location = New System.Drawing.Point(15, 62)
        Me.btnLoginCommit.Name = "btnLoginCommit"
        Me.btnLoginCommit.Size = New System.Drawing.Size(75, 23)
        Me.btnLoginCommit.TabIndex = 16
        Me.btnLoginCommit.Text = "Login"
        Me.btnLoginCommit.UseVisualStyleBackColor = True
        '
        'txtLoginPass
        '
        Me.txtLoginPass.Location = New System.Drawing.Point(103, 33)
        Me.txtLoginPass.Name = "txtLoginPass"
        Me.txtLoginPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtLoginPass.Size = New System.Drawing.Size(100, 20)
        Me.txtLoginPass.TabIndex = 15
        '
        'txtLoginId
        '
        Me.txtLoginId.Location = New System.Drawing.Point(103, 6)
        Me.txtLoginId.Name = "txtLoginId"
        Me.txtLoginId.Size = New System.Drawing.Size(100, 20)
        Me.txtLoginId.TabIndex = 14
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(11, 36)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 13
        Me.lblPassword.Text = "Password"
        '
        'lblLoginName
        '
        Me.lblLoginName.AutoSize = True
        Me.lblLoginName.Location = New System.Drawing.Point(12, 9)
        Me.lblLoginName.Name = "lblLoginName"
        Me.lblLoginName.Size = New System.Drawing.Size(64, 13)
        Me.lblLoginName.TabIndex = 12
        Me.lblLoginName.Text = "Login Name"
        '
        'AdminLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 94)
        Me.Controls.Add(Me.btnLoginCancel)
        Me.Controls.Add(Me.btnLoginCommit)
        Me.Controls.Add(Me.txtLoginPass)
        Me.Controls.Add(Me.txtLoginId)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblLoginName)
        Me.Name = "AdminLogin"
        Me.Text = "AdminLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLoginCancel As System.Windows.Forms.Button
    Friend WithEvents btnLoginCommit As System.Windows.Forms.Button
    Friend WithEvents txtLoginPass As System.Windows.Forms.TextBox
    Friend WithEvents txtLoginId As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblLoginName As System.Windows.Forms.Label
End Class
