Public Class AdminLogin

    Private student As New Student
    Private counter As Integer = 0
    Private Sub btnLoginCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoginCommit.Click
        ' 3 tries to login
        Dim success As New StudentMgt
        Dim result As DialogResult
        student.LoginName = txtLoginId.Text
        student.LoginPw = txtLoginPass.Text

        If counter < 3 Then
            If DatabaseServices.AdminLogin(student) Then
                MessageBox.Show("Successful Login")
                counter = 0
                Me.Hide()
                result = success.ShowDialog()
            Else
                counter += 1
                MessageBox.Show("Invalid login information")
            End If
        End If
    End Sub

    Private Sub btnLoginCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoginCancel.Click
        txtLoginId.Text = ""
        txtLoginPass.Text = ""
        Me.Hide()
    End Sub

    Private Sub AdminLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class