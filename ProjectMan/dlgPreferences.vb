Imports System.Windows.Forms

Public Class dlgPreferences
    Private mRootPath As String
    Public ReadOnly Property RootPath() As String
        Get
            Return mRootPath
        End Get
    End Property



    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dlgPreferences_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' FUTURE: Load all default values from a file here
        mRootPath = My.Settings.DefaultRootPath
        tbxRootPath.Text = My.Settings.DefaultRootPath
        fbdRootPath.SelectedPath = My.Settings.DefaultRootPath
    End Sub

    Private Sub btnBrowseRootPath_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowseRootPath.Click
        Dim result As DialogResult = fbdRootPath.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then
            mRootPath = fbdRootPath.SelectedPath.ToString()
            tbxRootPath.Text = mRootPath
        End If
    End Sub
End Class
