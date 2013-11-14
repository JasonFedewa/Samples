<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnAdultLogin = New System.Windows.Forms.Button()
        Me.btnLittleDrgLogin = New System.Windows.Forms.Button()
        Me.lblDrgonFireHeader = New System.Windows.Forms.Label()
        Me.picDragonFireBushido = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportDBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentMgtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picDragonFireBushido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdultLogin
        '
        Me.btnAdultLogin.BackColor = System.Drawing.Color.Black
        Me.btnAdultLogin.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdultLogin.ForeColor = System.Drawing.Color.White
        Me.btnAdultLogin.Location = New System.Drawing.Point(26, 113)
        Me.btnAdultLogin.Name = "btnAdultLogin"
        Me.btnAdultLogin.Size = New System.Drawing.Size(130, 40)
        Me.btnAdultLogin.TabIndex = 12
        Me.btnAdultLogin.Text = "Adult Login"
        Me.btnAdultLogin.UseVisualStyleBackColor = False
        '
        'btnLittleDrgLogin
        '
        Me.btnLittleDrgLogin.BackColor = System.Drawing.Color.Black
        Me.btnLittleDrgLogin.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLittleDrgLogin.ForeColor = System.Drawing.Color.White
        Me.btnLittleDrgLogin.Location = New System.Drawing.Point(26, 57)
        Me.btnLittleDrgLogin.Name = "btnLittleDrgLogin"
        Me.btnLittleDrgLogin.Size = New System.Drawing.Size(151, 50)
        Me.btnLittleDrgLogin.TabIndex = 11
        Me.btnLittleDrgLogin.Text = "Little Dragons" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Login"
        Me.btnLittleDrgLogin.UseVisualStyleBackColor = False
        '
        'lblDrgonFireHeader
        '
        Me.lblDrgonFireHeader.AutoSize = True
        Me.lblDrgonFireHeader.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrgonFireHeader.Location = New System.Drawing.Point(134, 9)
        Me.lblDrgonFireHeader.Name = "lblDrgonFireHeader"
        Me.lblDrgonFireHeader.Size = New System.Drawing.Size(402, 36)
        Me.lblDrgonFireHeader.TabIndex = 10
        Me.lblDrgonFireHeader.Text = "Dragonfire Karate Association"
        '
        'picDragonFireBushido
        '
        Me.picDragonFireBushido.Image = CType(resources.GetObject("picDragonFireBushido.Image"), System.Drawing.Image)
        Me.picDragonFireBushido.Location = New System.Drawing.Point(140, 48)
        Me.picDragonFireBushido.Name = "picDragonFireBushido"
        Me.picDragonFireBushido.Size = New System.Drawing.Size(387, 346)
        Me.picDragonFireBushido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDragonFireBushido.TabIndex = 9
        Me.picDragonFireBushido.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(637, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportDBToolStripMenuItem, Me.StudentMgtToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExportDBToolStripMenuItem
        '
        Me.ExportDBToolStripMenuItem.Name = "ExportDBToolStripMenuItem"
        Me.ExportDBToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExportDBToolStripMenuItem.Text = "Export DB"
        '
        'StudentMgtToolStripMenuItem
        '
        Me.StudentMgtToolStripMenuItem.Name = "StudentMgtToolStripMenuItem"
        Me.StudentMgtToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StudentMgtToolStripMenuItem.Text = "Student Mgt"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 426)
        Me.Controls.Add(Me.btnAdultLogin)
        Me.Controls.Add(Me.btnLittleDrgLogin)
        Me.Controls.Add(Me.lblDrgonFireHeader)
        Me.Controls.Add(Me.picDragonFireBushido)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Dojo Tracker"
        CType(Me.picDragonFireBushido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdultLogin As System.Windows.Forms.Button
    Friend WithEvents btnLittleDrgLogin As System.Windows.Forms.Button
    Friend WithEvents lblDrgonFireHeader As System.Windows.Forms.Label
    Friend WithEvents picDragonFireBushido As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportDBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentMgtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
