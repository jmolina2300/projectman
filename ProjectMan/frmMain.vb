Imports System.IO
Imports System.Xml

Public Class frmMain
    ']] Preferences Dialog: Read properties from it after ShowDialog 
    Private dlgPreferences As dlgPreferences = New dlgPreferences()
    Private selectedProject As String = String.Empty
    Private editingProject As Boolean = False
    Private infoFileName As String = "info.xml"
    Private COL_PATH As String = "colFullPath"
    Private COL_TITLE As String = "colTitle"
    Private COL_DESCRIPTION As String = "colDescription"
    Private COL_DATE_STARTED As String = "colDateStarted"
    Private COL_DATE_COMPLETED As String = "colDateCompleted"

    Private DEFAULT_FOLDER_NAME As String = "MyProjects"




    ''' <summary>
    ''' Updates My.Settings with preferences from dlgPreferences Dialog
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub updatePreferences()
        My.Settings.DefaultRootPath = Me.dlgPreferences.RootPath
        refreshProjectDisplays()
    End Sub

    Private Sub setupProjectPath()
        Dim defaultRootPath As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & DEFAULT_FOLDER_NAME
        My.Settings.DefaultRootPath = defaultRootPath

        ' Ask user if the default path is OK to use
        Dim defaultPathIsFine As DialogResult = MessageBox.Show(
            "Default project path set to " & My.Settings.DefaultRootPath & ".  Continue?",
            "Notice",
            MessageBoxButtons.YesNo
            ) = Windows.Forms.DialogResult.Yes
        If Not defaultPathIsFine Then
            dlgPreferences.ShowDialog()
            If dlgPreferences.DialogResult = Windows.Forms.DialogResult.OK Then
                updatePreferences()
            Else
                MessageBox.Show("Cannot start without a project directory!",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Application.Exit()
            End If
        End If

        ' Create default root path
        If Not Directory.Exists(My.Settings.DefaultRootPath) Then
            Try
                Directory.CreateDirectory(My.Settings.DefaultRootPath)
            Catch ex As IOException
                Console.WriteLine("Unable to create directory at " + My.Settings.DefaultRootPath)
                Application.Exit()
            End Try
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'My.Settings.IsFirstLaunch = True
        If My.Settings.IsFirstLaunch Then
            My.Settings.IsFirstLaunch = False
            setupProjectPath()
        End If

        tbxRootDirectory.Text = My.Settings.DefaultRootPath
        refreshProjectDisplays()
    End Sub

    Private Sub changePreferences()
        dlgPreferences.ShowDialog()
        If dlgPreferences.DialogResult = Windows.Forms.DialogResult.OK Then
            updatePreferences()
        End If
    End Sub

    Private Sub itmPreferences_Click(sender As System.Object, e As System.EventArgs) Handles itmPreferences.Click
        changePreferences()
    End Sub
#Region "Data Views"
    Private Sub refreshProjectDisplays()
        fillTreeView()
        fillProjectList()
    End Sub

    Private Sub fillTreeView()
        tvProject.Nodes.Clear()
        Try
            Dim folderNum As Integer = 0
            Dim folders = From folder In New DirectoryInfo(My.Settings.DefaultRootPath).EnumerateDirectories() Select folder
            Dim fullPathColumnNum As Integer = dgvProjectList.Columns.Item("colFullPath").Index
            For Each folder In folders
                Dim rootDirectory As String = folder.Name
                tvProject.Nodes.Add(folder.Name)
                populateTreeNode(folder.FullName, tvProject.Nodes(folderNum))  'Populate this root node using its full path
                folderNum += 1
            Next
        Catch ex As System.ArgumentNullException
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Function FolderIsProject(ByRef projectPath As String)
        Dim actualFilePath As String = projectPath & "\" & infoFileName
        If Not File.Exists(actualFilePath) Then
            Return False
        End If

        If Not ProjectInfo.IsValidProject(projectPath) Then
            Return False
        End If

        Return True

    End Function

    Private Sub fillProjectList()
        dgvProjectList.Rows.Clear()
        Try
            Dim folderNum As Integer = 0
            Dim folders = From folder In New DirectoryInfo(My.Settings.DefaultRootPath).EnumerateDirectories() Select folder
            Dim fullPathColumnNum As Integer = dgvProjectList.Columns.Item("colFullPath").Index
            For Each folder In folders
                dgvProjectList.Rows.Add(folder)                                                 ' Add the name
                dgvProjectList.Rows(folderNum).Cells(fullPathColumnNum).Value = folder.FullName ' Add the full path

                ' Find out if this folder is a "project" -- if it is, fill in the details
                If FolderIsProject(folder.FullName) Then
                    Try
                        Dim currentProject As New ProjectInfo(folder)
                        dgvProjectList.Rows(folderNum).Cells(COL_TITLE).Value = currentProject.Title
                        dgvProjectList.Rows(folderNum).Cells(COL_DESCRIPTION).Value = currentProject.Description
                        dgvProjectList.Rows(folderNum).Cells(COL_DATE_STARTED).Value = currentProject.DateStarted
                        dgvProjectList.Rows(folderNum).Cells(COL_DATE_COMPLETED).Value = currentProject.DateCompleted
                    Catch ex As Exception
                        Console.WriteLine("fillProjectList:  FAILED TO LOAD PROJECT  " & folder.Name)
                    End Try
                Else
                    dgvProjectList.Rows(folderNum).DefaultCellStyle.ForeColor = Color.Red
                End If

                folderNum += 1
            Next
        Catch ex As Exception
            MsgBox("Unable to fill Project list: " & ex.Message)
        End Try

    End Sub
#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fillTreeView()
        fillProjectList()
    End Sub

    ''' <summary>
    ''' Populates the TreeNode with nodes for each sub folder
    ''' </summary>
    ''' <param name="directory"></param>
    ''' <param name="parentNode"></param>
    ''' <remarks></remarks>
    Private Sub populateTreeNode(ByVal directory As String, ByVal parentNode As TreeNode)
        Dim dirInfo As DirectoryInfo = Nothing
        Try
            dirInfo = New DirectoryInfo(directory)
            dirInfo.GetDirectories()
        Catch ex As System.UnauthorizedAccessException
            If My.Settings.WarnFolderAccess Then
                MsgBox("Unable to access folder '" & dirInfo.Name & "'", MsgBoxStyle.Critical)
            End If
            Exit Sub
        End Try
        Dim currentFolder As String = String.Empty
        Dim folders = From folder In dirInfo.EnumerateDirectories() Select folder
        Try
            If folders.Count <> 0 Then
                Dim childNode As TreeNode = Nothing
                For Each folder In folders
                    currentFolder = folder.Name
                    childNode = New TreeNode(currentFolder)
                    parentNode.Nodes.Add(childNode)
                    populateTreeNode(folder.FullName, childNode)
                Next
            End If
        Catch ex As UnauthorizedAccessException
            parentNode.Nodes.Add(currentFolder & ": Access Denied")
        End Try
    End Sub

    Private Sub FileSystemWatcher1_Changed(sender As System.Object, e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Changed
        If Not editingProject Then
            refreshProjectDisplays()
        End If
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If dgvProjectList.RowCount <= 0 Then
            Exit Sub
        End If
        For i As Integer = 1 To dgvProjectList.Rows.Count - 1
            Dim projectPath As String = dgvProjectList.Rows(i).Cells("colFullPath").Value
            ' Save all projects in the grid (?) 
        Next
    End Sub




    Private Sub CreateNewProject()
        Dim projectInfo As ProjectInfo
        Dim result As DialogResult
        Dim dlg As New dlgProject

        ' Get title, description, and dates from user
        result = dlg.ShowDialog()
        If result = DialogResult.OK Then
            If Not String.IsNullOrWhiteSpace(dlg.Title) Then
                projectInfo = New ProjectInfo(
                    dlg.Title,
                    dlg.Description,
                    My.Settings.DefaultRootPath,
                    dlg.DateStarted,
                    dlg.DateCompleted)
            Else
                Exit Sub
            End If
            ' Try to create the project directory
            Try
                Directory.CreateDirectory(projectInfo.Path)
            Catch ex As Exception
                MsgBox("Unable to create new project in root " + My.Settings.DefaultRootPath)
                Exit Sub
            End Try
            ' Generate the info text file
            projectInfo.Save()
            refreshProjectDisplays()
        End If
    End Sub

    ''' <summary>
    ''' Creates a new project using the NewProject Dialog
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnNewProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewProject.Click
        CreateNewProject()
    End Sub

    Private Sub btnNewAssignment_Click(sender As System.Object, e As System.EventArgs) Handles btnNewAssignment.Click
        '------------------------------------------------
        '------------------------------------------------
        If dgvProjectList.SelectedRows.Count > 0 Then
            Dim title As String = String.Empty
            Dim description As String = String.Empty
            Dim selectedProjectPath As String = dgvProjectList.SelectedRows(0).Cells("colFullPath").Value
            Dim dlg As New dlgAssignment
            dlg.ShowDialog()
            If dlg.DialogResult = DialogResult.OK Then
                title = dlg.Title
                description = dlg.Description
                Try
                    Directory.CreateDirectory(selectedProjectPath + "\" + title)
                    fillTreeView()
                Catch ex As Exception
                    MsgBox("Could not create new assignment in " + selectedProjectPath)
                End Try
            End If
        End If

    End Sub

    Private Sub itmExit_Click(sender As System.Object, e As System.EventArgs) Handles itmExit.Click
        Application.Exit()
    End Sub

    Private Sub btnExplore_Click(sender As System.Object, e As System.EventArgs) Handles btnExplore.Click
        If Not tvProject.SelectedNode Is Nothing Then
            Dim nodePath As String = My.Settings.DefaultRootPath & "\" & tvProject.SelectedNode.FullPath
            Process.Start("explorer.exe", nodePath)
        End If
    End Sub


    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        editingProject = True
        If dgvProjectList.SelectedRows.Count > 0 Then
            Dim projectDirectory As New DirectoryInfo(dgvProjectList.SelectedRows(0).Cells(COL_PATH).Value)
            Dim newProjectInfo As ProjectInfo

            ' The selected folder isnt actually a project yet
            If Not FolderIsProject(projectDirectory.FullName) Then
                Dim shouldCreateProject As Boolean = MsgBox(
                    "This folder is not a project!" & vbNewLine & "Would you like to create one here?",
                    MsgBoxStyle.YesNo) = MsgBoxResult.Yes
                If Not shouldCreateProject Then
                    Exit Sub
                End If
            End If
            Dim oldProjectInfo As New ProjectInfo(projectDirectory)

            Dim dlgEditProject As New dlgProject(
                oldProjectInfo.Title,
                oldProjectInfo.Description,
                oldProjectInfo.DateStarted,
                oldProjectInfo.DateCompleted)
            Dim result As DialogResult = dlgEditProject.ShowDialog()
            If result = DialogResult.OK Then

                If Not String.IsNullOrWhiteSpace(dlgEditProject.Title) Then
                    newProjectInfo = New ProjectInfo(
                        dlgEditProject.Title,
                        dlgEditProject.Description,
                        My.Settings.DefaultRootPath,
                        dlgEditProject.DateStarted,
                        dlgEditProject.DateCompleted)
                Else
                    editingProject = False
                    Exit Sub
                End If
                ' Move the project directory if it was renamed
                If Not newProjectInfo.Path.Equals(oldProjectInfo.Path) Then
                    Try
                        Directory.Move(oldProjectInfo.Path, newProjectInfo.Path)
                    Catch ex As Exception
                        MsgBox("Unable to move project " & oldProjectInfo.Title & vbNewLine &
                               "  Source: " & oldProjectInfo.Path & vbNewLine &
                               "  Destination: " & newProjectInfo.Path)
                        editingProject = False
                        Exit Sub
                    End Try
                End If
                newProjectInfo.Save()
                refreshProjectDisplays()
            End If
        End If
        editingProject = False
    End Sub

    Private Sub itmNew_Click(sender As System.Object, e As System.EventArgs) Handles itmNew.Click
        CreateNewProject()
    End Sub

    Private Sub dgvProjectList_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles dgvProjectList.SelectionChanged
        If editingProject Then
            Exit Sub
        End If
        If sender.SelectedRows.Count = 0 Then
            Exit Sub
        End If

        ' Get the selected project
        Try
            Dim path = sender.SelectedRows(0).Cells(COL_PATH).Value.ToString
            Dim project As ProjectInfo = New ProjectInfo(path)
            'PropertyGrid1.SelectedObject = project
        Catch ex As Exception

        End Try

    End Sub


    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub dgvProjectList_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProjectList.CellContentDoubleClick
        Dim projectPath = dgvProjectList.Rows(e.RowIndex).Cells(COL_PATH).Value.ToString()
        Process.Start("explorer.exe", projectPath)
    End Sub
End Class
