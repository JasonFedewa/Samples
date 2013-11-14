Public Class StudentMgt


    Private currentStudent As Student
    '??
    Private Sub StudentMgt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'On form load the student list gets populated
        'This might be altered to accomidate Kid students only and then adults
        radActiveAdult.Checked = True
        txtFname.Focus()
    End Sub
    '(Done)
    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        'When the New button is clicked it clears the form and sets the current student to nothing
        ClearFields()
        currentStudent = Nothing
    End Sub
    '??
    Private Sub btnSaveStudent_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveStudent.Click
        Try
            Dim s As New Student
            s.StudentId = Guid.NewGuid()
            s.Fname = txtFname.Text
            s.Lname = txtLname.Text
            s.Phone = txtPhoneNum.Text
            s.Rank = txtKyu.Text
            s.HoursEarned = Convert.ToInt32(txtHoursEarned.Text)
            s.HoursTaught = Convert.ToInt32(txtHoursTaught.Text)
            s.StartDate = dtpStartDate.Value
            s.LastLogin = dtpStartDate.Value 'Change this to the new login once it is working
            s.Phone = txtPhoneNum.Text
            s.LoginName = txtLoginName.Text
            s.LoginPw = txtPassword.Text
            s.Active = chkActiveStudent.Checked
            s.Admin = chkAdmin.Checked
            s.Teacher = chkTeacher.Checked
            s.Adult = chkAdult.Checked
            s.Paid = chkPaid.Checked
            If DatabaseServices.SaveStudent(s) Then
                MessageBox.Show("Student Successfully Added!")
                ListFill()
            Else
                MessageBox.Show("The Student could not be added.")
            End If
        Catch ex As Exception
            MessageBox.Show("You can not edit or save a blank student")
        End Try
        ClearFields()
    End Sub
    '??
    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        'Takes the current fields and then saves them to the database
        Try
            currentStudent.Fname = txtFname.Text
            currentStudent.Lname = txtLname.Text
            currentStudent.Phone = txtPhoneNum.Text
            currentStudent.Rank = txtKyu.Text
            currentStudent.HoursEarned = Convert.ToDouble(txtHoursEarned.Text)
            currentStudent.HoursTaught = Convert.ToDouble(txtHoursTaught.Text)
            currentStudent.StartDate = dtpStartDate.Value
            currentStudent.LastLogin = dtpStartDate.Value ' Temporary until I get the lastlogin working
            currentStudent.Phone = txtPhoneNum.Text
            currentStudent.LoginName = txtLoginName.Text
            currentStudent.LoginPw = txtPassword.Text
            currentStudent.Active = chkActiveStudent.Checked
            currentStudent.Admin = chkAdmin.Checked
            currentStudent.Teacher = chkTeacher.Checked
            currentStudent.Adult = chkAdult.Checked
            currentStudent.Paid = chkPaid.Checked
            DatabaseServices.EditStudent(currentStudent)
            MessageBox.Show("Changes made were successfull")
            ListFill()
        Catch ex As Exception
            MessageBox.Show("You can not edit or save a blank student")
        End Try

    End Sub
    '(Done)
    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        'Sub that is called when the user clicks the delete button.
        'Waring to make sure user really wants to delete a student
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this Student?", "Confirm", MessageBoxButtons.YesNo)
        'If result comes back as yes it will equal true and then proceed with the delete
        'Nothing happens if the user clicks No
        If result = Windows.Forms.DialogResult.Yes Then
            DatabaseServices.DeleteStudent(currentStudent)
            ClearFields()
            currentStudent = Nothing
            ListFill()
        End If
    End Sub
    '(Done)
    Public Sub ClearFields()
        'Clears all fields and chk Boxes

        txtFname.Text = ""
        txtLname.Text = ""
        txtHoursEarned.Text = ""
        txtHoursTaught.Text = ""
        txtKyu.Text = ""
        txtLoginName.Text = ""
        txtPassword.Text = ""
        txtPhoneNum.Text = ""
        lblLastLogin.Text = ""
        chkActiveStudent.Checked = False
        chkAdmin.Checked = False
        chkAdult.Checked = False
        chkTeacher.Checked = False
        chkPaid.Checked = False
        txtFname.Focus()
    End Sub
    '(Done)
    Public Sub ListFill()
        'Sub for filling lstStudents with all known students.
        lstStudents.Items.Clear()
        Dim studentlist As New List(Of Student)
        If radActiveAdult.Checked = True Then
            studentlist = DatabaseServices.FilterByActiveAdult()
        ElseIf radActiveKids.Checked = True Then
            studentlist = DatabaseServices.FilterByActiveKid()
        ElseIf radAdultStudents.Checked = True Then
            studentlist = DatabaseServices.FilterByAdult()
        ElseIf radKidStudents.Checked = True Then
            studentlist = DatabaseServices.FilterByKid()
        ElseIf radNonActAdult.Checked = True Then
            studentlist = DatabaseServices.FilterByNonActAdult()
        ElseIf radNonActLD.Checked = True Then
            studentlist = DatabaseServices.FilterByNonActKid()
        End If

        For Each s As Student In studentlist
            lstStudents.Items.Add(s)
        Next
    End Sub
    '(Done)
    Private Sub lstStudents_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstStudents.SelectedIndexChanged
        'Sub for updating lstStudents when changes occur. This is called each time a student is added, edited, or deleted.
        ClearFields()
        currentStudent = lstStudents.SelectedItem

        txtFname.Text = currentStudent.Fname
        txtLname.Text = currentStudent.Lname
        txtKyu.Text = currentStudent.Rank
        txtHoursEarned.Text = currentStudent.HoursEarned
        txtHoursTaught.Text = currentStudent.HoursTaught
        dtpStartDate.Value = currentStudent.StartDate
        lblLastLogin.Text = Convert.ToString(currentStudent.LastLogin)
        txtPhoneNum.Text = currentStudent.Phone
        txtLoginName.Text = currentStudent.LoginName
        txtPassword.Text = currentStudent.LoginPw
        chkActiveStudent.Checked = currentStudent.Active
        chkAdmin.Checked = currentStudent.Admin
        chkTeacher.Checked = currentStudent.Teacher
        chkAdult.Checked = currentStudent.Adult
        chkPaid.Checked = currentStudent.Paid
    End Sub
    '(Done)
    Private Sub btnExitForm_Click(sender As System.Object, e As System.EventArgs) Handles btnExitForm.Click
        'Allows the user to exit the Student Mgt form.
        Me.Hide()
    End Sub

    'Radial buttons that are used to filter the list
    Private Sub radActiveAdult_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radActiveAdult.CheckedChanged
        lstStudents.Items.Clear()
        Dim studentlist As List(Of Student) = DatabaseServices.FilterByActiveAdult()
        For Each s As Student In studentlist
            lstStudents.Items.Add(s)
        Next
    End Sub
    Private Sub radActiveKids_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radActiveKids.CheckedChanged
        lstStudents.Items.Clear()
        Dim studentlist As List(Of Student) = DatabaseServices.FilterByActiveKid()
        For Each s As Student In studentlist
            lstStudents.Items.Add(s)
        Next

    End Sub
    Private Sub radAdultStudents_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radAdultStudents.CheckedChanged
        lstStudents.Items.Clear()
        Dim studentlist As List(Of Student) = DatabaseServices.FilterByAdult()
        For Each s As Student In studentlist
            lstStudents.Items.Add(s)
        Next
    End Sub
    Private Sub radKidStudents_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radKidStudents.CheckedChanged
        lstStudents.Items.Clear()
        Dim studentlist As List(Of Student) = DatabaseServices.FilterByKid()
        For Each s As Student In studentlist
            lstStudents.Items.Add(s)
        Next
    End Sub
    Private Sub radNonActAdult_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radNonActAdult.CheckedChanged
        lstStudents.Items.Clear()
        Dim studentlist As List(Of Student) = DatabaseServices.FilterByNonActAdult()
        For Each s As Student In studentlist
            lstStudents.Items.Add(s)
        Next
    End Sub
    Private Sub radNonActLD_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radNonActLD.CheckedChanged
        lstStudents.Items.Clear()
        Dim studentlist As List(Of Student) = DatabaseServices.FilterByNonActKid()
        For Each s As Student In studentlist
            lstStudents.Items.Add(s)
        Next
    End Sub
End Class