<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LittleDragonsLogin
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
        Me.chkTeaching = New System.Windows.Forms.CheckBox()
        Me.btnLoginCancel = New System.Windows.Forms.Button()
        Me.btnLoginCommit = New System.Windows.Forms.Button()
        Me.txtLoginId = New System.Windows.Forms.TextBox()
        Me.lblLoginName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chkTeaching
        '
        Me.chkTeaching.AutoSize = True
        Me.chkTeaching.Location = New System.Drawing.Point(15, 37)
        Me.chkTeaching.Name = "chkTeaching"
        Me.chkTeaching.Size = New System.Drawing.Size(109, 17)
        Me.chkTeaching.TabIndex = 16
        Me.chkTeaching.Text = "Check if teaching"
        Me.chkTeaching.UseVisualStyleBackColor = True
        '
        'btnLoginCancel
        '
        Me.btnLoginCancel.Location = New System.Drawing.Point(132, 60)
        Me.btnLoginCancel.Name = "btnLoginCancel"
        Me.btnLoginCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnLoginCancel.TabIndex = 15
        Me.btnLoginCancel.Text = "Cancel"
        Me.btnLoginCancel.UseVisualStyleBackColor = True
        '
        'btnLoginCommit
        '
        Me.btnLoginCommit.Location = New System.Drawing.Point(15, 60)
        Me.btnLoginCommit.Name = "btnLoginCommit"
        Me.btnLoginCommit.Size = New System.Drawing.Size(75, 23)
        Me.btnLoginCommit.TabIndex = 14
        Me.btnLoginCommit.Text = "Login"
        Me.btnLoginCommit.UseVisualStyleBackColor = True
        '
        'txtLoginId
        '
        Me.txtLoginId.Location = New System.Drawing.Point(103, 6)
        Me.txtLoginId.Name = "txtLoginId"
        Me.txtLoginId.Size = New System.Drawing.Size(100, 20)
        Me.txtLoginId.TabIndex = 13
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
        'LittleDragonsLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 96)
        Me.Controls.Add(Me.chkTeaching)
        Me.Controls.Add(Me.btnLoginCancel)
        Me.Controls.Add(Me.btnLoginCommit)
        Me.Controls.Add(Me.txtLoginId)
        Me.Controls.Add(Me.lblLoginName)
        Me.Name = "LittleDragonsLogin"
        Me.Text = "LittleDragonsLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkTeaching As System.Windows.Forms.CheckBox
    Friend WithEvents btnLoginCancel As System.Windows.Forms.Button
    Friend WithEvents btnLoginCommit As System.Windows.Forms.Button
    Friend WithEvents txtLoginId As System.Windows.Forms.TextBox
    Friend WithEvents lblLoginName As System.Windows.Forms.Label
End Class
