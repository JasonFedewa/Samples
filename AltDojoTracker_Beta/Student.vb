Partial Public Class Student
    Public Overrides Function ToString() As String
        Return "Student: " & Me.LoginName & "  | " & Me.Lname & ", " & Me.Fname & " | " & Me.Rank & " | " & Me.HoursEarned & " | " & "Paid: " & Me.Paid
    End Function
End Class
