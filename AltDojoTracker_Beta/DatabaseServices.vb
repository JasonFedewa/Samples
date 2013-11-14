Public Class DatabaseServices

    Public Shared DojoContext As New DojoTrackDBEntities
    Private Shared adultHourSet As New Setting
    Private Shared kidHourSet As New Setting

    'Static constructor for DojoContext Object
    Shared Sub New()
        Try
            DojoContext = New DojoTrackDBEntities
        Catch ex As Exception
            Throw New Exception("Could not establish connection to Database")
        End Try
    End Sub
    'Saves changes done to a student object.
    Public Shared Sub EditStudent(ByVal student As Student)
        DojoContext.SaveChanges()
    End Sub
    'Function that is called by the Adult login form.
    Public Shared Function Login(ByVal student As Student, ByVal chk As Boolean) As Boolean
        Try
            Dim teaching As Boolean = chk
            If student.LoginName Is Nothing Then
                MessageBox.Show("That is not a valid Login name")
            End If
            Dim theLogin As Student = DojoContext.Students.Single(Function(s As Student) s.LoginName = student.LoginName)
            'Since I am seperateingthe login's I might not need this logic.
            If theLogin.Adult = True Then
                'Hard coded atm, once I have settings working this will pull from the settings table
                theLogin.HoursEarned += 1.5
                If teaching = True Then
                    theLogin.HoursTaught += 1.5
                End If
            ElseIf theLogin.Adult = False Then
                theLogin.HoursEarned += 0
                MessageBox.Show("You used the wrong login button, please click the Little Dragons login button.")
                Return False
            End If
            Dim activeChk As Boolean = ActivityChk(theLogin)
            Dim paidChk As Boolean = PaymentChk(theLogin)
            If activeChk = True Then
                MessageBox.Show("Welcome back!")
            End If
            If paidChk = False Then
                MessageBox.Show("A friendly reminder, membership fees are due.")
            End If
            theLogin.Active = True
            theLogin.LastLogin = Date.Now
            Return True
        Catch ive As InvalidOperationException
            MessageBox.Show("Invalid Student number")
            Return False
        End Try
    End Function
    'Function that is called by the Littedragons login form
    Public Shared Function LoginKid(ByVal student As Student, ByVal chk As Boolean) As Boolean
        Try
            Dim teaching As Boolean = chk
            If Student.LoginName Is Nothing Then
                MessageBox.Show("That is not a valid Login name")
            End If
            Dim theLogin As Student = DojoContext.Students.Single(Function(s As Student) s.LoginName = Student.LoginName)
            'Since I am seperateingthe login's I might not need this logic.
            theLogin.HoursEarned += 1
            If teaching = True Then
                theLogin.HoursTaught += 1
            End If
            Dim activeChk As Boolean = ActivityChk(theLogin)
            Dim paidChk As Boolean = PaymentChk(theLogin)
            If activeChk = True Then
                MessageBox.Show("Welcome back!")
            End If
            If paidChk = False Then
                MessageBox.Show("Please talk to Sensei about membership dues.")
            End If
            theLogin.Active = True
            theLogin.LastLogin = Date.Now
            Return True
        Catch ive As InvalidOperationException
            MessageBox.Show("Invalid Student number")
            Return False
        End Try
    End Function

    'Function for checking if a student has paid.
    Public Shared Function PaymentChk(ByVal passedStd As Student) As Boolean
        Dim truthChk As Boolean = passedStd.Paid.Value
        Dim dayTemp As Date = Date.Today
        Dim dayPassed As Date = passedStd.LastLogin
        'Dim dayChk As TimeSpan = 
        If passedStd.Paid = False Then
            truthChk = False
        Else
            truthChk = True
        End If
        Return truthChk
    End Function

    'Function for checking if a student has been active.
    Public Shared Function ActivityChk(ByVal passedStd As Student) As Boolean
        Dim day As Date = Date.Now
        Dim day2 As Date = passedStd.LastLogin
        Dim dTime As TimeSpan = day.Subtract(day2)
        Dim truthChk As Boolean = False 'A value of true means the student has not logged in for 60+ days.
        If dTime.TotalDays >= 60 Then
            truthChk = True
            passedStd.Active = False 'Here to set students activity column at load.
            passedStd.Paid = False
        ElseIf dTime.TotalDays > 30 Then
            passedStd.Active = True
            passedStd.Paid = False
            truthChk = False
        Else
            truthChk = False
        End If
        Return truthChk
    End Function

    'Function for accessing Admin forms
    Public Shared Function AdminLogin(ByVal student As Student) As Boolean
        Try
            If student.LoginName Is Nothing Then
                MessageBox.Show("That is not a valid Login name")
            ElseIf student.LoginPw Is Nothing Then
                MessageBox.Show("That is not a valid Login pw")
            End If
            Dim theLogin As Student = DojoContext.Students.Single(Function(s As Student) s.LoginName = student.LoginName)
            Dim thePass As Student = DojoContext.Students.Single(Function(s As Student) s.LoginPw = student.LoginPw)
            If theLogin.Admin = True Then
                Return True
            End If
            MessageBox.Show("You do not have sufficent access")
            Return False
        Catch ive As InvalidOperationException
            MessageBox.Show("Invalid login or Password")
            Return False
        End Try
    End Function
    'Function for saving a new student object.
    Public Shared Function SaveStudent(ByVal student As Student) As Boolean
        Try
            Dim theStudent As Student = DojoContext.Students.Single(Function(s As Student) s.StudentId = student.StudentId)
            Return False
        Catch ive As InvalidOperationException
            Try
                DojoContext.Students.AddObject(student)
                DojoContext.SaveChanges()
                Return True
            Catch ex As Exception
                Throw New Exception("Error saving Student to database.")
            End Try
        Catch ex As Exception
            Throw New Exception("Error accessing database(Add Student).")
        End Try
    End Function
    'Sub for removing a student object from the Database
    Public Shared Sub DeleteStudent(ByVal student As Student)
        Try
            Dim theStudent As Student = DojoContext.Students.Single(Function(s As Student) s.StudentId = student.StudentId)
            DojoContext.Students.DeleteObject(theStudent)
            DojoContext.SaveChanges()
        Catch ive As InvalidOperationException
            ' Student does not exist
            Throw New Exception("The Student cannot be deleted because it does not exist.")
        Catch ex As Exception
            Throw New Exception("The Student cannot be deleted.")
        End Try
    End Sub
    'A Sub that allows the forced update of the Database.
    Public Shared Sub UpdateDB()
        Try
            DojoContext.SaveChanges()
        Catch ex As Exception
            Throw New Exception("The Student cannot be updated.")
        End Try
    End Sub

    '***Might not be need any more....
    'Function for populating the Student list box via a Linq Query.
    Public Shared Function RetrieveStudents() As List(Of Student)

        Dim query As IQueryable(Of Student) = From students In DojoContext.Students
        Order By (students.LoginName)
        Select students

        Return query.ToList()
    End Function
    'Filters to be applied to the student list
    'I might be able to get them all into the retrievestudents function and improve efficiency
    Public Shared Function FilterByActiveAdult() As List(Of Student)
        Dim query As IQueryable(Of Student) = From students In DojoContext.Students
        Where (students.Active = True)
        Where (students.Adult = True)
        Order By (students.LoginName)
        Select students

        Return query.ToList()
    End Function
    Public Shared Function FilterByActiveKid() As List(Of Student)
        Dim query As IQueryable(Of Student) = From students In DojoContext.Students
        Where (students.Active = True)
        Where (students.Adult = False)
        Order By (students.LoginName)
        Select students

        Return query.ToList()
    End Function
    Public Shared Function FilterByAdult() As List(Of Student)
        Dim query As IQueryable(Of Student) = From students In DojoContext.Students
        Where (students.Adult = True)
        Order By (students.LoginName)
        Select students

        Return query.ToList()
    End Function
    Public Shared Function FilterByKid() As List(Of Student)

        Dim query As IQueryable(Of Student) = From students In DojoContext.Students
        Where (students.Adult = False)
        Order By (students.LoginName)
        Select students

        Return query.ToList()
    End Function
    Public Shared Function FilterByNonActAdult() As List(Of Student)
        Dim query As IQueryable(Of Student) = From students In DojoContext.Students
        Where (students.Active = False)
        Where (students.Adult = True)
        Order By (students.LoginName)
        Select students

        Return query.ToList()
    End Function
    Public Shared Function FilterByNonActKid() As List(Of Student)
        Dim query As IQueryable(Of Student) = From students In DojoContext.Students
        Where (students.Active = False)
        Where (students.Adult = False)
        Order By (students.LoginName)
        Select students

        Return query.ToList()
    End Function
End Class
