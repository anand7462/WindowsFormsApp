Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private WithEvents stopwatch As New Stopwatch()
    Private WithEvents Timer As New System.Windows.Forms.Timer()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnStartStop.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            btnStartStop.Text = "Resume"
        Else
            stopwatch.Start()
            btnStartStop.Text = "Pause"
        End If
        UpdateStopwatchDisplay()
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim name As String = txtName.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim phoneNumber As String = txtPhoneNumber.Text.Trim()
        Dim gitHubLink As String = txtGitHubLink.Text.Trim()

        If ValidateInputs(name, email, phoneNumber, gitHubLink) Then
            Dim submission As New Dictionary(Of String, String) From {
                {"name", name},
                {"email", email},
                {"phone", phoneNumber},
                {"github_link", gitHubLink},
                {"stopwatch_time", stopwatch.Elapsed.ToString("hh\:mm\:ss")}
            }

            Dim success As Boolean = Await SubmitDataAsync(submission)

            If success Then
                MessageBox.Show("Submission created successfully!")
                Me.Close()
            Else
                MessageBox.Show("Failed to submit the form.", "Submission Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Function ValidateInputs(name As String, email As String, phoneNumber As String, gitHubLink As String) As Boolean
        If String.IsNullOrEmpty(name) Then
            MessageBox.Show("Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If String.IsNullOrEmpty(email) OrElse Not email.Contains("@") Then
            MessageBox.Show("A valid Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If String.IsNullOrEmpty(phoneNumber) OrElse Not IsNumeric(phoneNumber) Then
            MessageBox.Show("A valid Phone Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If String.IsNullOrEmpty(gitHubLink) OrElse Not gitHubLink.StartsWith("https://github.com/") Then
            MessageBox.Show("A valid GitHub link is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Async Function SubmitDataAsync(submission As Dictionary(Of String, String)) As Task(Of Boolean)
        Using client As New HttpClient()
            client.BaseAddress = New Uri("http://localhost:3000/") ' Adjust the URL if needed
            client.DefaultRequestHeaders.Accept.Clear()
            client.DefaultRequestHeaders.Accept.Add(New Headers.MediaTypeWithQualityHeaderValue("application/json"))

            Dim json As String = JsonConvert.SerializeObject(submission)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PostAsync("submit", content)

            Return response.IsSuccessStatusCode
        End Using
    End Function

    Private Sub UpdateStopwatchDisplay()
        lblStopwatch.Text = String.Format("{0:hh\:mm\:ss}", stopwatch.Elapsed)
    End Sub

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formTimer.Interval = 1000 ' 1 second interval
        formTimer.Start()
        UpdateStopwatchDisplay()
    End Sub

    Private Sub formTimer_Tick(sender As Object, e As EventArgs) Handles formTimer.Tick
        If stopwatch.IsRunning Then
            UpdateStopwatchDisplay()
        End If
    End Sub
End Class
