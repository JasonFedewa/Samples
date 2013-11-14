<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentMgt
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
        Me.lblLastLogin = New System.Windows.Forms.Label()
        Me.chkPaid = New System.Windows.Forms.CheckBox()
        Me.radNonActLD = New System.Windows.Forms.RadioButton()
        Me.radNonActAdult = New System.Windows.Forms.RadioButton()
        Me.radKidStudents = New System.Windows.Forms.RadioButton()
        Me.radAdultStudents = New System.Windows.Forms.RadioButton()
        Me.radActiveKids = New System.Windows.Forms.RadioButton()
        Me.radActiveAdult = New System.Windows.Forms.RadioButton()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lstStudents = New System.Windows.Forms.ListBox()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.chkAdult = New System.Windows.Forms.CheckBox()
        Me.chkTeacher = New System.Windows.Forms.CheckBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtLoginName = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.chkAdmin = New System.Windows.Forms.CheckBox()
        Me.btnExitForm = New System.Windows.Forms.Button()
        Me.txtPhoneNum = New System.Windows.Forms.TextBox()
        Me.lblPhoneNum = New System.Windows.Forms.Label()
        Me.btnSaveStudent = New System.Windows.Forms.Button()
        Me.txtHoursTaught = New System.Windows.Forms.TextBox()
        Me.txtHoursEarned = New System.Windows.Forms.TextBox()
        Me.txtKyu = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.lblDuesDate = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.lblHoursTaught = New System.Windows.Forms.Label()
        Me.chkActiveStudent = New System.Windows.Forms.CheckBox()
        Me.lblHoursEarned = New System.Windows.Forms.Label()
        Me.lblRank = New System.Windows.Forms.Label()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblLastLogin
        '
        Me.lblLastLogin.AutoSize = True
        Me.lblLastLogin.Location = New System.Drawing.Point(94, 179)
        Me.lblLastLogin.Name = "lblLastLogin"
        Me.lblLastLogin.Size = New System.Drawing.Size(49, 13)
        Me.lblLastLogin.TabIndex = 80
        Me.lblLastLogin.Text = "XXXXXX"
        '
        'chkPaid
        '
        Me.chkPaid.AutoSize = True
        Me.chkPaid.Location = New System.Drawing.Point(218, 119)
        Me.chkPaid.Name = "chkPaid"
        Me.chkPaid.Size = New System.Drawing.Size(47, 17)
        Me.chkPaid.TabIndex = 62
        Me.chkPaid.Text = "Paid"
        Me.chkPaid.UseVisualStyleBackColor = True
        '
        'radNonActLD
        '
        Me.radNonActLD.AutoSize = True
        Me.radNonActLD.Location = New System.Drawing.Point(256, 274)
        Me.radNonActLD.Name = "radNonActLD"
        Me.radNonActLD.Size = New System.Drawing.Size(135, 17)
        Me.radNonActLD.TabIndex = 73
        Me.radNonActLD.TabStop = True
        Me.radNonActLD.Text = "Non Act. Little Dragons"
        Me.radNonActLD.UseVisualStyleBackColor = True
        '
        'radNonActAdult
        '
        Me.radNonActAdult.AutoSize = True
        Me.radNonActAdult.Location = New System.Drawing.Point(256, 251)
        Me.radNonActAdult.Name = "radNonActAdult"
        Me.radNonActAdult.Size = New System.Drawing.Size(94, 17)
        Me.radNonActAdult.TabIndex = 71
        Me.radNonActAdult.TabStop = True
        Me.radNonActAdult.Text = "Non Act. Adult"
        Me.radNonActAdult.UseVisualStyleBackColor = True
        '
        'radKidStudents
        '
        Me.radKidStudents.AutoSize = True
        Me.radKidStudents.Location = New System.Drawing.Point(133, 274)
        Me.radKidStudents.Name = "radKidStudents"
        Me.radKidStudents.Size = New System.Drawing.Size(90, 17)
        Me.radKidStudents.TabIndex = 70
        Me.radKidStudents.TabStop = True
        Me.radKidStudents.Text = "Little Dragons"
        Me.radKidStudents.UseVisualStyleBackColor = True
        '
        'radAdultStudents
        '
        Me.radAdultStudents.AutoSize = True
        Me.radAdultStudents.Location = New System.Drawing.Point(133, 251)
        Me.radAdultStudents.Name = "radAdultStudents"
        Me.radAdultStudents.Size = New System.Drawing.Size(94, 17)
        Me.radAdultStudents.TabIndex = 69
        Me.radAdultStudents.TabStop = True
        Me.radAdultStudents.Text = "Adult Students"
        Me.radAdultStudents.UseVisualStyleBackColor = True
        '
        'radActiveKids
        '
        Me.radActiveKids.AutoSize = True
        Me.radActiveKids.Location = New System.Drawing.Point(15, 274)
        Me.radActiveKids.Name = "radActiveKids"
        Me.radActiveKids.Size = New System.Drawing.Size(112, 17)
        Me.radActiveKids.TabIndex = 68
        Me.radActiveKids.TabStop = True
        Me.radActiveKids.Text = "Act. Little Dragons"
        Me.radActiveKids.UseVisualStyleBackColor = True
        '
        'radActiveAdult
        '
        Me.radActiveAdult.AutoSize = True
        Me.radActiveAdult.Location = New System.Drawing.Point(15, 251)
        Me.radActiveAdult.Name = "radActiveAdult"
        Me.radActiveAdult.Size = New System.Drawing.Size(71, 17)
        Me.radActiveAdult.TabIndex = 66
        Me.radActiveAdult.TabStop = True
        Me.radActiveAdult.Text = "Act. Adult"
        Me.radActiveAdult.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.Location = New System.Drawing.Point(15, 424)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(79, 23)
        Me.btnSettings.TabIndex = 75
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        Me.btnSettings.Visible = False
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(313, 115)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 65
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(313, 220)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 77
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(313, 174)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 64
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'lstStudents
        '
        Me.lstStudents.FormattingEnabled = True
        Me.lstStudents.Location = New System.Drawing.Point(15, 297)
        Me.lstStudents.Name = "lstStudents"
        Me.lstStudents.Size = New System.Drawing.Size(373, 121)
        Me.lstStudents.TabIndex = 79
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(91, 149)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpStartDate.TabIndex = 78
        '
        'chkAdult
        '
        Me.chkAdult.AutoSize = True
        Me.chkAdult.Location = New System.Drawing.Point(218, 91)
        Me.chkAdult.Name = "chkAdult"
        Me.chkAdult.Size = New System.Drawing.Size(50, 17)
        Me.chkAdult.TabIndex = 60
        Me.chkAdult.Text = "Adult"
        Me.chkAdult.UseVisualStyleBackColor = True
        '
        'chkTeacher
        '
        Me.chkTeacher.AutoSize = True
        Me.chkTeacher.Location = New System.Drawing.Point(296, 64)
        Me.chkTeacher.Name = "chkTeacher"
        Me.chkTeacher.Size = New System.Drawing.Size(66, 17)
        Me.chkTeacher.TabIndex = 59
        Me.chkTeacher.Text = "Teacher"
        Me.chkTeacher.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(288, 34)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 57
        '
        'txtLoginName
        '
        Me.txtLoginName.Location = New System.Drawing.Point(288, 6)
        Me.txtLoginName.Name = "txtLoginName"
        Me.txtLoginName.Size = New System.Drawing.Size(100, 20)
        Me.txtLoginName.TabIndex = 56
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(215, 37)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 74
        Me.lblPassword.Text = "Password:"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(215, 9)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(59, 13)
        Me.lblID.TabIndex = 72
        Me.lblID.Text = "Student Id:"
        '
        'chkAdmin
        '
        Me.chkAdmin.AutoSize = True
        Me.chkAdmin.Location = New System.Drawing.Point(296, 91)
        Me.chkAdmin.Name = "chkAdmin"
        Me.chkAdmin.Size = New System.Drawing.Size(55, 17)
        Me.chkAdmin.TabIndex = 61
        Me.chkAdmin.Text = "Admin"
        Me.chkAdmin.UseVisualStyleBackColor = True
        '
        'btnExitForm
        '
        Me.btnExitForm.Location = New System.Drawing.Point(313, 424)
        Me.btnExitForm.Name = "btnExitForm"
        Me.btnExitForm.Size = New System.Drawing.Size(75, 23)
        Me.btnExitForm.TabIndex = 76
        Me.btnExitForm.Text = "Exit"
        Me.btnExitForm.UseVisualStyleBackColor = True
        '
        'txtPhoneNum
        '
        Me.txtPhoneNum.Location = New System.Drawing.Point(91, 208)
        Me.txtPhoneNum.Name = "txtPhoneNum"
        Me.txtPhoneNum.Size = New System.Drawing.Size(100, 20)
        Me.txtPhoneNum.TabIndex = 53
        '
        'lblPhoneNum
        '
        Me.lblPhoneNum.AutoSize = True
        Me.lblPhoneNum.Location = New System.Drawing.Point(12, 211)
        Me.lblPhoneNum.Name = "lblPhoneNum"
        Me.lblPhoneNum.Size = New System.Drawing.Size(51, 13)
        Me.lblPhoneNum.TabIndex = 67
        Me.lblPhoneNum.Text = "Phone #:"
        '
        'btnSaveStudent
        '
        Me.btnSaveStudent.Location = New System.Drawing.Point(313, 145)
        Me.btnSaveStudent.Name = "btnSaveStudent"
        Me.btnSaveStudent.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveStudent.TabIndex = 63
        Me.btnSaveStudent.Text = "Save"
        Me.btnSaveStudent.UseVisualStyleBackColor = True
        '
        'txtHoursTaught
        '
        Me.txtHoursTaught.Location = New System.Drawing.Point(91, 122)
        Me.txtHoursTaught.Name = "txtHoursTaught"
        Me.txtHoursTaught.Size = New System.Drawing.Size(100, 20)
        Me.txtHoursTaught.TabIndex = 51
        '
        'txtHoursEarned
        '
        Me.txtHoursEarned.Location = New System.Drawing.Point(91, 92)
        Me.txtHoursEarned.Name = "txtHoursEarned"
        Me.txtHoursEarned.Size = New System.Drawing.Size(100, 20)
        Me.txtHoursEarned.TabIndex = 50
        '
        'txtKyu
        '
        Me.txtKyu.Location = New System.Drawing.Point(91, 61)
        Me.txtKyu.Name = "txtKyu"
        Me.txtKyu.Size = New System.Drawing.Size(100, 20)
        Me.txtKyu.TabIndex = 49
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(91, 34)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(100, 20)
        Me.txtLname.TabIndex = 46
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(91, 6)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(100, 20)
        Me.txtFname.TabIndex = 44
        '
        'lblDuesDate
        '
        Me.lblDuesDate.AutoSize = True
        Me.lblDuesDate.Location = New System.Drawing.Point(12, 180)
        Me.lblDuesDate.Name = "lblDuesDate"
        Me.lblDuesDate.Size = New System.Drawing.Size(76, 13)
        Me.lblDuesDate.TabIndex = 55
        Me.lblDuesDate.Text = "Last Attended:"
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Location = New System.Drawing.Point(12, 155)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(58, 13)
        Me.lblStartDate.TabIndex = 54
        Me.lblStartDate.Text = "Start Date:"
        '
        'lblHoursTaught
        '
        Me.lblHoursTaught.AutoSize = True
        Me.lblHoursTaught.Location = New System.Drawing.Point(12, 125)
        Me.lblHoursTaught.Name = "lblHoursTaught"
        Me.lblHoursTaught.Size = New System.Drawing.Size(75, 13)
        Me.lblHoursTaught.TabIndex = 52
        Me.lblHoursTaught.Text = "Hours Taught:"
        '
        'chkActiveStudent
        '
        Me.chkActiveStudent.AutoSize = True
        Me.chkActiveStudent.Location = New System.Drawing.Point(218, 64)
        Me.chkActiveStudent.Name = "chkActiveStudent"
        Me.chkActiveStudent.Size = New System.Drawing.Size(56, 17)
        Me.chkActiveStudent.TabIndex = 58
        Me.chkActiveStudent.Text = "Active"
        Me.chkActiveStudent.UseVisualStyleBackColor = True
        '
        'lblHoursEarned
        '
        Me.lblHoursEarned.AutoSize = True
        Me.lblHoursEarned.Location = New System.Drawing.Point(12, 95)
        Me.lblHoursEarned.Name = "lblHoursEarned"
        Me.lblHoursEarned.Size = New System.Drawing.Size(75, 13)
        Me.lblHoursEarned.TabIndex = 48
        Me.lblHoursEarned.Text = "Hours Earned:"
        '
        'lblRank
        '
        Me.lblRank.AutoSize = True
        Me.lblRank.Location = New System.Drawing.Point(12, 64)
        Me.lblRank.Name = "lblRank"
        Me.lblRank.Size = New System.Drawing.Size(36, 13)
        Me.lblRank.TabIndex = 47
        Me.lblRank.Text = "Rank:"
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Location = New System.Drawing.Point(12, 37)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(61, 13)
        Me.lblLname.TabIndex = 45
        Me.lblLname.Text = "Last Name:"
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Location = New System.Drawing.Point(12, 9)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(60, 13)
        Me.lblFname.TabIndex = 43
        Me.lblFname.Text = "First Name:"
        '
        'StudentMgt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 453)
        Me.Controls.Add(Me.lblLastLogin)
        Me.Controls.Add(Me.chkPaid)
        Me.Controls.Add(Me.radNonActLD)
        Me.Controls.Add(Me.radNonActAdult)
        Me.Controls.Add(Me.radKidStudents)
        Me.Controls.Add(Me.radAdultStudents)
        Me.Controls.Add(Me.radActiveKids)
        Me.Controls.Add(Me.radActiveAdult)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lstStudents)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.chkAdult)
        Me.Controls.Add(Me.chkTeacher)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtLoginName)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.chkAdmin)
        Me.Controls.Add(Me.btnExitForm)
        Me.Controls.Add(Me.txtPhoneNum)
        Me.Controls.Add(Me.lblPhoneNum)
        Me.Controls.Add(Me.btnSaveStudent)
        Me.Controls.Add(Me.txtHoursTaught)
        Me.Controls.Add(Me.txtHoursEarned)
        Me.Controls.Add(Me.txtKyu)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.lblDuesDate)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.lblHoursTaught)
        Me.Controls.Add(Me.chkActiveStudent)
        Me.Controls.Add(Me.lblHoursEarned)
        Me.Controls.Add(Me.lblRank)
        Me.Controls.Add(Me.lblLname)
        Me.Controls.Add(Me.lblFname)
        Me.Name = "StudentMgt"
        Me.Text = "StudentMgt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLastLogin As System.Windows.Forms.Label
    Friend WithEvents chkPaid As System.Windows.Forms.CheckBox
    Friend WithEvents radNonActLD As System.Windows.Forms.RadioButton
    Friend WithEvents radNonActAdult As System.Windows.Forms.RadioButton
    Friend WithEvents radKidStudents As System.Windows.Forms.RadioButton
    Friend WithEvents radAdultStudents As System.Windows.Forms.RadioButton
    Friend WithEvents radActiveKids As System.Windows.Forms.RadioButton
    Friend WithEvents radActiveAdult As System.Windows.Forms.RadioButton
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents lstStudents As System.Windows.Forms.ListBox
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkAdult As System.Windows.Forms.CheckBox
    Friend WithEvents chkTeacher As System.Windows.Forms.CheckBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtLoginName As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents chkAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents btnExitForm As System.Windows.Forms.Button
    Friend WithEvents txtPhoneNum As System.Windows.Forms.TextBox
    Friend WithEvents lblPhoneNum As System.Windows.Forms.Label
    Friend WithEvents btnSaveStudent As System.Windows.Forms.Button
    Friend WithEvents txtHoursTaught As System.Windows.Forms.TextBox
    Friend WithEvents txtHoursEarned As System.Windows.Forms.TextBox
    Friend WithEvents txtKyu As System.Windows.Forms.TextBox
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents lblDuesDate As System.Windows.Forms.Label
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents lblHoursTaught As System.Windows.Forms.Label
    Friend WithEvents chkActiveStudent As System.Windows.Forms.CheckBox
    Friend WithEvents lblHoursEarned As System.Windows.Forms.Label
    Friend WithEvents lblRank As System.Windows.Forms.Label
    Friend WithEvents lblLname As System.Windows.Forms.Label
    Friend WithEvents lblFname As System.Windows.Forms.Label
End Class
