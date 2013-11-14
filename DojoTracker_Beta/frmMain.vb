Public Class frmMain
    Public stdChk As New List(Of Student)

    Private Sub btnLittleDrgLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLittleDrgLogin.Click

        Dim loginTry As New LittleDragonsLogin
        Dim result As DialogResult
        result = loginTry.ShowDialog()
    End Sub

    Private Sub btnAdultLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnAdultLogin.Click

        Dim loginTry As New AdultLogin
        Dim result As DialogResult
        result = loginTry.ShowDialog()
    End Sub

    Private Sub StudentMgtToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StudentMgtToolStripMenuItem.Click
        'Accesses the Student Mgt screen to allow new students to be saved, edited, or deleted

        Dim loginTry As New AdminLogin
        Dim success As New StudentMgt
        Dim result As DialogResult
        result = loginTry.ShowDialog()
        If result = DialogResult.OK Then
            result = success.ShowDialog()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        DatabaseServices.UpdateDB()
        Close()
    End Sub

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Upon form load, this section of code calls the whole database is passed through
        'the ActivityChk function to determine if it is time for dues to paid and
        'if a student has been inactive.

        stdChk = DatabaseServices.RetrieveStudents()
        For Each item As Student In stdChk
            DatabaseServices.ActivityChk(item)
        Next
    End Sub
End Class
