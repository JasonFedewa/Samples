<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinterSportsRentals
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
        Me.components = New System.ComponentModel.Container()
        Me.lblSelectEquip = New System.Windows.Forms.Label()
        Me.lstEquip = New System.Windows.Forms.ListBox()
        Me.lblRentalDuration = New System.Windows.Forms.Label()
        Me.lblDisplayDate = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblDeposit = New System.Windows.Forms.Label()
        Me.lblBalDue = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.txtBalDue = New System.Windows.Forms.TextBox()
        Me.lklblWeather = New System.Windows.Forms.LinkLabel()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.chkDamageInsur = New System.Windows.Forms.CheckBox()
        Me.chkLiabilityWaiver = New System.Windows.Forms.CheckBox()
        Me.cmbDuration = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.errDeposit = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errDeposit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSelectEquip
        '
        Me.lblSelectEquip.AutoSize = True
        Me.lblSelectEquip.Location = New System.Drawing.Point(38, 19)
        Me.lblSelectEquip.Name = "lblSelectEquip"
        Me.lblSelectEquip.Size = New System.Drawing.Size(115, 26)
        Me.lblSelectEquip.TabIndex = 0
        Me.lblSelectEquip.Text = "Select all Equipment to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "          be Rented"
        '
        'lstEquip
        '
        Me.lstEquip.FormattingEnabled = True
        Me.lstEquip.Location = New System.Drawing.Point(41, 58)
        Me.lstEquip.Name = "lstEquip"
        Me.lstEquip.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstEquip.Size = New System.Drawing.Size(125, 134)
        Me.lstEquip.TabIndex = 1
        '
        'lblRentalDuration
        '
        Me.lblRentalDuration.AutoSize = True
        Me.lblRentalDuration.Location = New System.Drawing.Point(246, 41)
        Me.lblRentalDuration.Name = "lblRentalDuration"
        Me.lblRentalDuration.Size = New System.Drawing.Size(79, 13)
        Me.lblRentalDuration.TabIndex = 2
        Me.lblRentalDuration.Text = "Rental duration"
        '
        'lblDisplayDate
        '
        Me.lblDisplayDate.AutoSize = True
        Me.lblDisplayDate.Location = New System.Drawing.Point(430, 19)
        Me.lblDisplayDate.Name = "lblDisplayDate"
        Me.lblDisplayDate.Size = New System.Drawing.Size(111, 13)
        Me.lblDisplayDate.TabIndex = 3
        Me.lblDisplayDate.Text = "<DateDisplayedHere>"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Location = New System.Drawing.Point(378, 62)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(46, 13)
        Me.lblSubTotal.TabIndex = 4
        Me.lblSubTotal.Text = "Subtotal"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(399, 88)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(25, 13)
        Me.lblTax.TabIndex = 5
        Me.lblTax.Text = "Tax"
        '
        'lblDeposit
        '
        Me.lblDeposit.AutoSize = True
        Me.lblDeposit.Location = New System.Drawing.Point(381, 114)
        Me.lblDeposit.Name = "lblDeposit"
        Me.lblDeposit.Size = New System.Drawing.Size(43, 13)
        Me.lblDeposit.TabIndex = 6
        Me.lblDeposit.Text = "Deposit"
        '
        'lblBalDue
        '
        Me.lblBalDue.AutoSize = True
        Me.lblBalDue.Location = New System.Drawing.Point(381, 140)
        Me.lblBalDue.Name = "lblBalDue"
        Me.lblBalDue.Size = New System.Drawing.Size(43, 13)
        Me.lblBalDue.TabIndex = 7
        Me.lblBalDue.Text = "Bal due"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(430, 59)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubtotal.TabIndex = 8
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(430, 85)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.ReadOnly = True
        Me.txtTax.Size = New System.Drawing.Size(100, 20)
        Me.txtTax.TabIndex = 9
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(430, 111)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(100, 20)
        Me.txtDeposit.TabIndex = 10
        '
        'txtBalDue
        '
        Me.txtBalDue.Location = New System.Drawing.Point(430, 137)
        Me.txtBalDue.Name = "txtBalDue"
        Me.txtBalDue.ReadOnly = True
        Me.txtBalDue.Size = New System.Drawing.Size(100, 20)
        Me.txtBalDue.TabIndex = 11
        '
        'lklblWeather
        '
        Me.lklblWeather.AutoSize = True
        Me.lklblWeather.Location = New System.Drawing.Point(12, 220)
        Me.lklblWeather.Name = "lklblWeather"
        Me.lklblWeather.Size = New System.Drawing.Size(89, 13)
        Me.lklblWeather.TabIndex = 12
        Me.lklblWeather.TabStop = True
        Me.lklblWeather.Text = "Weather forecast"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(183, 215)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 13
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(325, 215)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'chkDamageInsur
        '
        Me.chkDamageInsur.AutoSize = True
        Me.chkDamageInsur.Location = New System.Drawing.Point(213, 98)
        Me.chkDamageInsur.Name = "chkDamageInsur"
        Me.chkDamageInsur.Size = New System.Drawing.Size(115, 17)
        Me.chkDamageInsur.TabIndex = 15
        Me.chkDamageInsur.Text = "Damage insurance"
        Me.chkDamageInsur.UseVisualStyleBackColor = True
        '
        'chkLiabilityWaiver
        '
        Me.chkLiabilityWaiver.AutoSize = True
        Me.chkLiabilityWaiver.Location = New System.Drawing.Point(213, 136)
        Me.chkLiabilityWaiver.Name = "chkLiabilityWaiver"
        Me.chkLiabilityWaiver.Size = New System.Drawing.Size(94, 17)
        Me.chkLiabilityWaiver.TabIndex = 16
        Me.chkLiabilityWaiver.Text = "Liability waiver"
        Me.chkLiabilityWaiver.UseVisualStyleBackColor = True
        '
        'cmbDuration
        '
        Me.cmbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDuration.FormattingEnabled = True
        Me.cmbDuration.Location = New System.Drawing.Point(213, 58)
        Me.cmbDuration.Name = "cmbDuration"
        Me.cmbDuration.Size = New System.Drawing.Size(121, 21)
        Me.cmbDuration.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(353, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Todays Date:"
        '
        'errDeposit
        '
        Me.errDeposit.ContainerControl = Me
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'WinterSportsRentals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 273)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbDuration)
        Me.Controls.Add(Me.chkLiabilityWaiver)
        Me.Controls.Add(Me.chkDamageInsur)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lklblWeather)
        Me.Controls.Add(Me.txtBalDue)
        Me.Controls.Add(Me.txtDeposit)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.lblBalDue)
        Me.Controls.Add(Me.lblDeposit)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.lblDisplayDate)
        Me.Controls.Add(Me.lblRentalDuration)
        Me.Controls.Add(Me.lstEquip)
        Me.Controls.Add(Me.lblSelectEquip)
        Me.Name = "WinterSportsRentals"
        Me.Text = "Winter Sports Rentals"
        CType(Me.errDeposit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSelectEquip As System.Windows.Forms.Label
    Friend WithEvents lstEquip As System.Windows.Forms.ListBox
    Friend WithEvents lblRentalDuration As System.Windows.Forms.Label
    Friend WithEvents lblDisplayDate As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblDeposit As System.Windows.Forms.Label
    Friend WithEvents lblBalDue As System.Windows.Forms.Label
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents txtDeposit As System.Windows.Forms.TextBox
    Friend WithEvents txtBalDue As System.Windows.Forms.TextBox
    Friend WithEvents lklblWeather As System.Windows.Forms.LinkLabel
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents chkDamageInsur As System.Windows.Forms.CheckBox
    Friend WithEvents chkLiabilityWaiver As System.Windows.Forms.CheckBox
    Friend WithEvents cmbDuration As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents errDeposit As System.Windows.Forms.ErrorProvider
    Friend WithEvents errProvider As System.Windows.Forms.ErrorProvider

End Class
