<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    ' Required method for Designer support - do not modify
    ' the contents of this method with the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblGitHubLink = New System.Windows.Forms.Label()
        Me.txtGitHubLink = New System.Windows.Forms.TextBox()
        Me.lblStopwatchTime = New System.Windows.Forms.Label()
        Me.txtStopwatchTime = New System.Windows.Forms.TextBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.pnlSubmissionDetails = New System.Windows.Forms.Panel()
        Me.pnlSubmissionDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe Script", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(101, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(315, 38)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "View Submissions Page"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(20, 20)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(47, 16)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(150, 17)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.BackColor = System.Drawing.Color.LightGray
        Me.txtName.Size = New System.Drawing.Size(200, 22)
        Me.txtName.TabIndex = 2
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(20, 60)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(44, 16)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(150, 57)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.BackColor = System.Drawing.Color.LightGray
        Me.txtEmail.Size = New System.Drawing.Size(200, 22)
        Me.txtEmail.TabIndex = 4
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(20, 100)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(100, 16)
        Me.lblPhoneNumber.TabIndex = 5
        Me.lblPhoneNumber.Text = "Phone Number:"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(150, 97)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.ReadOnly = True
        Me.txtPhoneNumber.BackColor = System.Drawing.Color.LightGray
        Me.txtPhoneNumber.Size = New System.Drawing.Size(200, 22)
        Me.txtPhoneNumber.TabIndex = 6
        '
        'lblGitHubLink
        '
        Me.lblGitHubLink.AutoSize = True
        Me.lblGitHubLink.Location = New System.Drawing.Point(20, 140)
        Me.lblGitHubLink.Name = "lblGitHubLink"
        Me.lblGitHubLink.Size = New System.Drawing.Size(78, 16)
        Me.lblGitHubLink.TabIndex = 7
        Me.lblGitHubLink.Text = "GitHub Link:"
        '
        'txtGitHubLink
        '
        Me.txtGitHubLink.Location = New System.Drawing.Point(150, 137)
        Me.txtGitHubLink.Name = "txtGitHubLink"
        Me.txtGitHubLink.ReadOnly = True
        Me.txtGitHubLink.BackColor = System.Drawing.Color.LightGray
        Me.txtGitHubLink.Size = New System.Drawing.Size(200, 22)
        Me.txtGitHubLink.TabIndex = 8
        '
        'lblStopwatchTime
        '
        Me.lblStopwatchTime.AutoSize = True
        Me.lblStopwatchTime.Location = New System.Drawing.Point(20, 180)
        Me.lblStopwatchTime.Name = "lblStopwatchTime"
        Me.lblStopwatchTime.Size = New System.Drawing.Size(106, 16)
        Me.lblStopwatchTime.TabIndex = 9
        Me.lblStopwatchTime.Text = "Stopwatch Time:"
        '
        'txtStopwatchTime
        '
        Me.txtStopwatchTime.Location = New System.Drawing.Point(150, 177)
        Me.txtStopwatchTime.Name = "txtStopwatchTime"
        Me.txtStopwatchTime.ReadOnly = True
        Me.txtStopwatchTime.BackColor = System.Drawing.Color.LightGray
        Me.txtStopwatchTime.Size = New System.Drawing.Size(200, 22)
        Me.txtStopwatchTime.TabIndex = 10
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.Yellow
        Me.btnPrevious.Location = New System.Drawing.Point(60, 398)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(163, 40)
        Me.btnPrevious.TabIndex = 11
        Me.btnPrevious.Text = "PREVIOUS (CTRL + P)"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.SkyBlue
        Me.btnNext.Location = New System.Drawing.Point(286, 398)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(163, 40)
        Me.btnNext.TabIndex = 12
        Me.btnNext.Text = "NEXT (CTRL + N)"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'pnlSubmissionDetails
        '
        Me.pnlSubmissionDetails.Controls.Add(Me.lblName)
        Me.pnlSubmissionDetails.Controls.Add(Me.txtName)
        Me.pnlSubmissionDetails.Controls.Add(Me.lblEmail)
        Me.pnlSubmissionDetails.Controls.Add(Me.txtEmail)
        Me.pnlSubmissionDetails.Controls.Add(Me.lblPhoneNumber)
        Me.pnlSubmissionDetails.Controls.Add(Me.txtPhoneNumber)
        Me.pnlSubmissionDetails.Controls.Add(Me.lblGitHubLink)
        Me.pnlSubmissionDetails.Controls.Add(Me.txtGitHubLink)
        Me.pnlSubmissionDetails.Controls.Add(Me.lblStopwatchTime)
        Me.pnlSubmissionDetails.Controls.Add(Me.txtStopwatchTime)
        Me.pnlSubmissionDetails.Location = New System.Drawing.Point(60, 76)
        Me.pnlSubmissionDetails.Name = "pnlSubmissionDetails"
        Me.pnlSubmissionDetails.Size = New System.Drawing.Size(389, 299)
        Me.pnlSubmissionDetails.TabIndex = 13
        '
        'ViewSubmissionsForm
        '
        Me.ClientSize = New System.Drawing.Size(530, 504)
        Me.Controls.Add(Me.pnlSubmissionDetails)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "View Submissions"
        Me.pnlSubmissionDetails.ResumeLayout(False)
        Me.pnlSubmissionDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblTitle As Label
    Private WithEvents lblName As Label
    Private WithEvents txtName As TextBox
    Private WithEvents lblEmail As Label
    Private WithEvents txtEmail As TextBox
    Private WithEvents lblPhoneNumber As Label
    Private WithEvents txtPhoneNumber As TextBox
    Private WithEvents lblGitHubLink As Label
    Private WithEvents txtGitHubLink As TextBox
    Private WithEvents lblStopwatchTime As Label
    Private WithEvents txtStopwatchTime As TextBox
    Private WithEvents btnPrevious As Button
    Private WithEvents btnNext As Button
    Private WithEvents pnlSubmissionDetails As Panel
End Class
