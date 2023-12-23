Imports System.Windows.Forms

Public Class dlgAssignment
    Private mTitle As String = String.Empty
    Private mDescription As String = String.Empty
    Private mDateStarted As String = String.Empty
    Private mDateCompleted As String = String.Empty

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If String.IsNullOrWhiteSpace(tbxTitle.Text) Then
            MsgBox("Please enter a title for this assignment", MsgBoxStyle.Information)
            Exit Sub
        End If
        mTitle = tbxTitle.Text
        mDescription = tbxDescription.Text

        If dtpStartDate.Checked Then
            mDateStarted = dtpStartDate.Value.ToShortDateString
        Else
            mDateStarted = "TBD"
        End If

        If dtpEndDate.Checked Then
            mDateCompleted = dtpEndDate.Value.ToShortDateString
        Else
            mDateCompleted = "TBD"
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
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
