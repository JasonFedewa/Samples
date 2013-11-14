'Author:  Jason Fedewa
'Purpose: To craft an application that allows a user to price out equipment for rent
'Date:    Feb / 12/ 2012
'TO-DO:   All reqs of the assignment completed

Public Class WinterSportsRentals

    Private Sub WinterSportsRentals_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkDamageInsur.Checked = True 'Default this check box should be set.
        lblDisplayDate.Text = DateAndTime.Today() 'Loads in the current date.

        'Adds the equipment items into the list box
        Dim skiEquip() As String = {"Skis, beginner", "Skis, advanced", "Snowboard, beginner", "Snowboard, advanced", "Ski-boots", "Snowboard boots", "Helmet standard", "Helmet deluxe"}

        lstEquip.Items.AddRange(skiEquip)
        lstEquip.SelectedIndex = 0 'Make sure at least one item is selected to begin

        Dim rentTime() As String = {"1 Day", "2 Days", "3 Days", "1 Week", "2 Weeks"}
        cmbDuration.Items.AddRange(rentTime)
        cmbDuration.SelectedIndex = 0 'Default

        txtDeposit.Text = 0

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        'Exits the application
        Close()

    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' This button Calculates the costs of equipment.

        Dim RentalRate(3, 4) As Single
        'Ski & Snowboard Beginner rates, also Ski boot & Std Helmet rates
        RentalRate(0, 0) = 35
        RentalRate(0, 1) = 45
        RentalRate(0, 2) = 80
        RentalRate(0, 3) = 150
        RentalRate(0, 4) = 280
        'Ski & Snowboard Advanced rates, also 'Deluxe Helmet rates
        RentalRate(1, 0) = 55
        RentalRate(1, 1) = 75
        RentalRate(1, 2) = 100
        RentalRate(1, 3) = 200
        RentalRate(1, 4) = 300
        'Snowboard Boots rates
        RentalRate(2, 0) = 25
        RentalRate(2, 1) = 35
        RentalRate(2, 2) = 80
        RentalRate(2, 3) = 120
        RentalRate(2, 4) = 200

        Dim subtotal As Single = 0
        Dim total As Single = 0

        If lstEquip.SelectedIndex < 0 Then
            MessageBox.Show("You have to select at least one piece of equipment to rent")
        End If

        For Each index As String In lstEquip.SelectedItems
            If index.Equals("Helmet deluxe") Then 'Helmet deluxe
                If cmbDuration.SelectedIndex >= 0 And cmbDuration.SelectedIndex <= 4 Then
                    subtotal += RentalRate(1, cmbDuration.SelectedIndex)
                End If
            ElseIf index.Equals("Helmet standard") Then 'Standard Helmets
                If cmbDuration.SelectedIndex >= 0 And cmbDuration.SelectedIndex <= 4 Then
                    subtotal += RentalRate(0, cmbDuration.SelectedIndex)
                End If
            ElseIf index.Equals("Snowboard boots") Then 'Snowboard boots
                If cmbDuration.SelectedIndex >= 0 And cmbDuration.SelectedIndex <= 4 Then
                    subtotal += RentalRate(2, cmbDuration.SelectedIndex)
                End If
            ElseIf index.Equals("Ski-boots") Then 'Ski - Boots
                If cmbDuration.SelectedIndex >= 0 And cmbDuration.SelectedIndex <= 4 Then
                    subtotal += RentalRate(0, cmbDuration.SelectedIndex)
                End If
            ElseIf index.Equals("Snowboard, advanced") Then 'Snowboard Advanced Lessons
                If cmbDuration.SelectedIndex >= 0 And cmbDuration.SelectedIndex <= 4 Then
                    subtotal += RentalRate(1, cmbDuration.SelectedIndex)
                End If
            ElseIf index.Equals("Snowboard, beginner") Then 'Snowboard Beginner lessons
                If cmbDuration.SelectedIndex >= 0 And cmbDuration.SelectedIndex <= 4 Then
                    subtotal += RentalRate(0, cmbDuration.SelectedIndex)
                End If
            ElseIf index.Equals("Skis, advanced") Then 'Ski Advanced lessons
                If cmbDuration.SelectedIndex >= 0 And cmbDuration.SelectedIndex <= 4 Then
                    subtotal += RentalRate(1, cmbDuration.SelectedIndex)
                End If
            ElseIf index.Equals("Skis, beginner") Then 'Ski beginner lessons
                If cmbDuration.SelectedIndex >= 0 And cmbDuration.SelectedIndex <= 4 Then
                    subtotal += RentalRate(0, cmbDuration.SelectedIndex)
                End If
            End If
        Next

        If chkLiabilityWaiver.Checked = False Then
            errProvider.SetError(chkLiabilityWaiver, "The Liability waiver must be signed and checked off")
        Else
            errProvider.SetError(chkLiabilityWaiver, String.Empty)
        End If

        Try
            If Convert.ToSingle(txtDeposit.Text) < 0 Then
                errDeposit.SetError(txtDeposit, "The Deposit field needs to be 0 or higher.")
            Else
                errDeposit.SetError(txtDeposit, String.Empty)
            End If
            If chkDamageInsur.Checked = True Then
                subtotal += subtotal * 0.1
            End If
            txtSubtotal.Text = subtotal
            txtTax.Text = subtotal * 0.06
            total = subtotal + Convert.ToSingle(txtTax.Text)
            txtBalDue.Text = total - Convert.ToSingle(txtDeposit.Text)
        Catch ex As Exception
            If txtDeposit.Text = "" Then
                MessageBox.Show("The Deposit field can not be left blank.")
            End If
        End Try
    End Sub

    Private Sub lklblWeather_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lklblWeather.LinkClicked
        System.Diagnostics.Process.Start("http://www.google.com/#hl=en&sugexp=lttmoc&cp=16&gs_id=2z&xhr=t&q=grand+rapids+mi+weather&pf=p&sclient=psy-ab&pbx=1&oq=grand+rapids+mi+&aq=0&aqi=g4&aql=&gs_sm=&gs_upl=&bav=on.2,or.r_gc.r_pw.r_qf.,cf.osb&fp=bb30518a1a45f2ba&biw=942&bih=958")
    End Sub

End Class
