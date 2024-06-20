Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private Submissions As List(Of Submission)
    Private currentIndex As Integer = 0
    Private ReadOnly httpClient As New HttpClient()

    Public Sub New()
        InitializeComponent()
        LoadSubmissions()
    End Sub

    Private Async Sub LoadSubmissions()
        Try
            Dim response = Await httpClient.GetStringAsync("http://localhost:3000/readAll")
            Submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(response)
            DisplaySubmission()
        Catch ex As Exception
            MessageBox.Show("Failed to load submissions: " & ex.Message)
        End Try
    End Sub

    Private Sub DisplaySubmission()
        If Submissions IsNot Nothing AndAlso Submissions.Count > 0 Then
            Dim submission = Submissions(currentIndex)
            txtName.Text = submission.Name
            txtEmail.Text = submission.Email
            txtPhoneNumber.Text = submission.Phone
            txtGitHubLink.Text = If(String.IsNullOrEmpty(submission.GitHubLink), "https://github.com/anand7462/", submission.GitHubLink)
            txtStopwatchTime.Text = If(String.IsNullOrEmpty(submission.StopwatchTime), "00:00:12", submission.StopwatchTime)
        Else
            txtName.Text = "No submissions available."
            txtEmail.Text = ""
            txtPhoneNumber.Text = ""
            txtGitHubLink.Text = ""
            txtStopwatchTime.Text = ""
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < Submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        End If
    End Sub
End Class

Public Class Submission
    Public Property Id As String ' Ensure you have an Id property that matches your backend
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GitHubLink As String
    Public Property StopwatchTime As String
End Class