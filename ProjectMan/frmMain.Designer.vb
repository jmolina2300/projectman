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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.splitContainerMain = New System.Windows.Forms.SplitContainer()
        Me.tvProject = New System.Windows.Forms.TreeView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblFolderStructure = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExplore = New System.Windows.Forms.Button()
        Me.dgvProjectList = New System.Windows.Forms.DataGridView()
        Me.colTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateStarted = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateCompleted = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFullPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnNewProject = New System.Windows.Forms.Button()
        Me.btnNewAssignment = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.menuTopMain = New System.Windows.Forms.MenuStrip()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmPreferences = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxRootDirectory = New System.Windows.Forms.TextBox()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.splitContainerMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainerMain.Panel1.SuspendLayout()
        Me.splitContainerMain.Panel2.SuspendLayout()
        Me.splitContainerMain.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvProjectList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.menuTopMain.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splitContainerMain
        '
        Me.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitContainerMain.Location = New System.Drawing.Point(0, 58)
        Me.splitContainerMain.Name = "splitContainerMain"
        '
        'splitContainerMain.Panel1
        '
        Me.splitContainerMain.Panel1.Controls.Add(Me.tvProject)
        Me.splitContainerMain.Panel1.Controls.Add(Me.Panel3)
        Me.splitContainerMain.Panel1.Controls.Add(Me.Panel1)
        Me.splitContainerMain.Panel1MinSize = 200
        '
        'splitContainerMain.Panel2
        '
        Me.splitContainerMain.Panel2.Controls.Add(Me.dgvProjectList)
        Me.splitContainerMain.Panel2.Controls.Add(Me.Panel4)
        Me.splitContainerMain.Panel2.Controls.Add(Me.Panel2)
        Me.splitContainerMain.Panel2MinSize = 500
        Me.splitContainerMain.Size = New System.Drawing.Size(958, 500)
        Me.splitContainerMain.SplitterDistance = 200
        Me.splitContainerMain.TabIndex = 5
        '
        'tvProject
        '
        Me.tvProject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvProject.Location = New System.Drawing.Point(0, 21)
        Me.tvProject.Name = "tvProject"
        Me.tvProject.Size = New System.Drawing.Size(196, 434)
        Me.tvProject.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblFolderStructure)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(196, 21)
        Me.Panel3.TabIndex = 7
        '
        'lblFolderStructure
        '
        Me.lblFolderStructure.AutoSize = True
        Me.lblFolderStructure.Location = New System.Drawing.Point(4, 5)
        Me.lblFolderStructure.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFolderStructure.Name = "lblFolderStructure"
        Me.lblFolderStructure.Size = New System.Drawing.Size(82, 13)
        Me.lblFolderStructure.TabIndex = 6
        Me.lblFolderStructure.Text = "Folder Structure"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnExplore)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 455)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(196, 41)
        Me.Panel1.TabIndex = 5
        '
        'btnExplore
        '
        Me.btnExplore.Image = CType(resources.GetObject("btnExplore.Image"), System.Drawing.Image)
        Me.btnExplore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExplore.Location = New System.Drawing.Point(3, 3)
        Me.btnExplore.Name = "btnExplore"
        Me.btnExplore.Size = New System.Drawing.Size(75, 35)
        Me.btnExplore.TabIndex = 4
        Me.btnExplore.Text = "Explore"
        Me.btnExplore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExplore.UseVisualStyleBackColor = True
        '
        'dgvProjectList
        '
        Me.dgvProjectList.AllowUserToAddRows = False
        Me.dgvProjectList.AllowUserToDeleteRows = False
        Me.dgvProjectList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvProjectList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvProjectList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProjectList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvProjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjectList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTitle, Me.colDescription, Me.colDateStarted, Me.colDateCompleted, Me.colFullPath})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProjectList.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvProjectList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProjectList.Location = New System.Drawing.Point(0, 76)
        Me.dgvProjectList.Margin = New System.Windows.Forms.Padding(3, 3, 3, 50)
        Me.dgvProjectList.Name = "dgvProjectList"
        Me.dgvProjectList.ReadOnly = True
        Me.dgvProjectList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProjectList.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvProjectList.RowHeadersVisible = False
        Me.dgvProjectList.RowHeadersWidth = 23
        Me.dgvProjectList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProjectList.Size = New System.Drawing.Size(750, 379)
        Me.dgvProjectList.TabIndex = 0
        '
        'colTitle
        '
        Me.colTitle.HeaderText = "Title"
        Me.colTitle.MinimumWidth = 100
        Me.colTitle.Name = "colTitle"
        Me.colTitle.ReadOnly = True
        '
        'colDescription
        '
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.MinimumWidth = 100
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        Me.colDescription.Width = 200
        '
        'colDateStarted
        '
        Me.colDateStarted.HeaderText = "Date Started"
        Me.colDateStarted.MinimumWidth = 110
        Me.colDateStarted.Name = "colDateStarted"
        Me.colDateStarted.ReadOnly = True
        Me.colDateStarted.Width = 110
        '
        'colDateCompleted
        '
        Me.colDateCompleted.HeaderText = "Date Completed"
        Me.colDateCompleted.MinimumWidth = 110
        Me.colDateCompleted.Name = "colDateCompleted"
        Me.colDateCompleted.ReadOnly = True
        Me.colDateCompleted.Width = 110
        '
        'colFullPath
        '
        Me.colFullPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colFullPath.HeaderText = "Full Path"
        Me.colFullPath.Name = "colFullPath"
        Me.colFullPath.ReadOnly = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btnNewProject)
        Me.Panel4.Controls.Add(Me.btnNewAssignment)
        Me.Panel4.Controls.Add(Me.btnEdit)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(750, 76)
        Me.Panel4.TabIndex = 3
        '
        'btnNewProject
        '
        Me.btnNewProject.Image = CType(resources.GetObject("btnNewProject.Image"), System.Drawing.Image)
        Me.btnNewProject.Location = New System.Drawing.Point(3, 6)
        Me.btnNewProject.Name = "btnNewProject"
        Me.btnNewProject.Size = New System.Drawing.Size(75, 64)
        Me.btnNewProject.TabIndex = 4
        Me.btnNewProject.Text = "Add"
        Me.btnNewProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNewProject.UseVisualStyleBackColor = True
        '
        'btnNewAssignment
        '
        Me.btnNewAssignment.Image = CType(resources.GetObject("btnNewAssignment.Image"), System.Drawing.Image)
        Me.btnNewAssignment.Location = New System.Drawing.Point(355, 6)
        Me.btnNewAssignment.Name = "btnNewAssignment"
        Me.btnNewAssignment.Size = New System.Drawing.Size(77, 64)
        Me.btnNewAssignment.TabIndex = 5
        Me.btnNewAssignment.Text = "New Assignment"
        Me.btnNewAssignment.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNewAssignment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNewAssignment.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(84, 6)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(68, 64)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(648, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 64)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Delete Project"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 455)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(750, 41)
        Me.Panel2.TabIndex = 2
        '
        'menuTopMain
        '
        Me.menuTopMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menuTopMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.menuTopMain.Location = New System.Drawing.Point(0, 0)
        Me.menuTopMain.Name = "menuTopMain"
        Me.menuTopMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.menuTopMain.Size = New System.Drawing.Size(958, 24)
        Me.menuTopMain.TabIndex = 2
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmNew, Me.itmPreferences, Me.itmExit})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ToolsToolStripMenuItem.Text = "File"
        '
        'itmNew
        '
        Me.itmNew.Name = "itmNew"
        Me.itmNew.Size = New System.Drawing.Size(138, 22)
        Me.itmNew.Text = "New Project"
        '
        'itmPreferences
        '
        Me.itmPreferences.Name = "itmPreferences"
        Me.itmPreferences.Size = New System.Drawing.Size(138, 22)
        Me.itmPreferences.Text = "Preferences"
        '
        'itmExit
        '
        Me.itmExit.Name = "itmExit"
        Me.itmExit.Size = New System.Drawing.Size(138, 22)
        Me.itmExit.Text = "Exit"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.tbxRootDirectory)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 24)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(958, 34)
        Me.Panel5.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Root Directory: "
        '
        'tbxRootDirectory
        '
        Me.tbxRootDirectory.Location = New System.Drawing.Point(110, 6)
        Me.tbxRootDirectory.Name = "tbxRootDirectory"
        Me.tbxRootDirectory.Size = New System.Drawing.Size(836, 20)
        Me.tbxRootDirectory.TabIndex = 1
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.IncludeSubdirectories = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 558)
        Me.Controls.Add(Me.splitContainerMain)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.menuTopMain)
        Me.MainMenuStrip = Me.menuTopMain
        Me.MinimumSize = New System.Drawing.Size(559, 426)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProjectMan"
        Me.splitContainerMain.Panel1.ResumeLayout(False)
        Me.splitContainerMain.Panel2.ResumeLayout(False)
        CType(Me.splitContainerMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainerMain.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvProjectList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.menuTopMain.ResumeLayout(False)
        Me.menuTopMain.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuTopMain As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmPreferences As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tvProject As System.Windows.Forms.TreeView
    Friend WithEvents dgvProjectList As System.Windows.Forms.DataGridView
    Friend WithEvents btnNewProject As System.Windows.Forms.Button
    Friend WithEvents splitContainerMain As System.Windows.Forms.SplitContainer
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblFolderStructure As System.Windows.Forms.Label
    Friend WithEvents btnNewAssignment As System.Windows.Forms.Button
    Friend WithEvents itmExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExplore As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents itmNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents tbxRootDirectory As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents colTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateStarted As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateCompleted As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFullPath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
