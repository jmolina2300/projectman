Imports System.Windows.Forms

Public Class dlgProject
    Private mTitle As String = String.Empty
    Private mDescription As String = String.Empty
    Private mDateStarted As String = String.Empty
    Private mDateCompleted As String = String.Empty
    Private DEFAULT_TIME As String = "TBD"



    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

    End Sub
    ' Create this dialog using a pre-defined ProjectInfo object
    Public Sub New(ByRef pi As ProjectInfo)
        mTitle = pi.Title
        mDescription = pi.Description
        mDateCompleted = pi.DateCompleted
        mDateStarted = pi.DateStarted
        InitializeComponent()
    End Sub

    Public Sub New(ByVal title As String, ByVal description As String, ByVal dateStarted As String, ByVal dateCompleted As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Initialize form controls with project info
        tbxTitle.Text = title
        tbxDescription.Text = description
        If Not UCase(dateStarted) = DEFAULT_TIME Then
            dtpStartDate.Value = GetDateFromString(dateStarted)
            dtpStartDate.Checked = True
        Else
            dtpStartDate.Value = DateTime.Now
            dtpStartDate.Checked = False
        End If

        If Not UCase(dateCompleted) = DEFAULT_TIME Then
            dtpEndDate.Value = GetDateFromString(dateCompleted)
            dtpEndDate.Checked = True
        Else
            dtpEndDate.Value = DateTime.Now
            dtpEndDate.Checked = False
        End If

    End Sub

    ' Try to parse the date string into a date object
    Private Function GetDateFromString(ByRef dateString As String) As DateTime
        Dim dateParsed As DateTime
        Try
            dateParsed = DateTime.Parse(dateString)
            dateParsed = GetClampedDate(dateParsed)
        Catch ex As Exception
            dateParsed = DateTime.Now
        End Try
        Return dateParsed
    End Function


    Private Function GetClampedDate(ByVal dateDesired As DateTime) As DateTime
        If dateDesired < dtpStartDate.MinDate Then
            Return dtpStartDate.MinDate
        ElseIf dateDesired > dtpStartDate.MaxDate Then
            Return dtpStartDate.MaxDate
        Else
            Return dateDesired
        End If
    End Function


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If String.IsNullOrWhiteSpace(tbxTitle.Text) Then
            MsgBox("Please enter a title for this project", MsgBoxStyle.Information)
            Exit Sub
        End If
        mTitle = tbxTitle.Text
        mDescription = tbxDescription.Text

        If dtpStartDate.Checked Then
            mDateStarted = dtpStartDate.Value.ToShortDateString
        Else
            mDateStarted = DEFAULT_TIME
        End If

        If dtpEndDate.Checked Then
            mDateCompleted = dtpEndDate.Value.ToShortDateString
        Else
            mDateCompleted = DEFAULT_TIME
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dlgNewProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
#Region "Public Properties"
    Property Title() As String
        Get
            Return mTitle
        End Get
        Set(value As String)
            mTitle = value
        End Set
    End Property
    Property Description() As String
        Get
            Return mDescription
        End Get
        Set(value As String)
            mDescription = value
        End Set
    End Property
    Property DateStarted() As String
        Get
            Return mDateStarted
        End Get
        Set(value As String)
            mDateStarted = value
        End Set
    End Property
    Property DateCompleted() As String
        Get
            Return mDateCompleted
        End Get
        Set(value As String)
            mDateCompleted = value
        End Set
    End Property
#End Region


End Class
