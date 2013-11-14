Public Class AdultLogin

    Private student As New Student
    Private counter As Integer = 0

    Private Sub btnLoginCommit_Click(sender As System.Object, e As System.EventArgs) Handles btnLoginCommit.Click
        ' 3 tries to login
        student.LoginName = txtLoginId.Text
        Dim hours As Single = 0
        Dim teaching As Boolean = chkTeaching.Checked
        If counter < 3 Then
            If DatabaseServices.Login(student, teaching) Then
                counter = 0
                MessageBox.Show("Successful Login")
                txtLoginId.Text = ""
                chkTeaching.Checked = False
                Me.Hide()
            Else
                counter += 1
            End If
        End If
    End Sub

    Private Sub btnLoginCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnLoginCancel.Click
        txtLoginId.Text = ""
        chkTeaching.Checked = False
        Me.Hide()
    End Sub

    Private Sub DojoLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class