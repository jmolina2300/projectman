Imports System.Xml
Imports System.IO
Imports System.ComponentModel

Public Class ProjectInfo
    ' Member variables
    Private mTitle As String = String.Empty
    Private mDescription As String = String.Empty
    Private mDateStarted As String = Nothing
    Private mDateCompleted As String = Nothing
    Private mFullPath As String = String.Empty
    Private mReadSuccess As Boolean = False
    Private mWriteSuccess As Boolean = False
    Private infoFileName As String = "info.xml"

    Private MSG_XML_READ_FAILURE As String = "Project has malformed XML file. Unable to read: "
    Private MSG_XML_WRITE_FAILURE As String = "Project could not be serialized to XML: "
    Private DATE_TIME_DEFAULT As String = "TBD"


#Region "Constructors"

    Public Sub New()

    End Sub
    Public Sub New(ByVal title As String,
                   ByVal description As String)
        mTitle = title
        mDescription = description
    End Sub
    Public Sub New(ByVal title As String,
                   ByVal description As String,
                   ByVal rootPath As String)
        mTitle = title
        mDescription = description
        If rootPath.EndsWith("\") Then
            mFullPath = rootPath & title
        Else
            mFullPath = rootPath & "\" & title
        End If
        mDateStarted = System.DateTime.Now
    End Sub

    Public Sub New(ByVal title As String,
               ByVal description As String,
               ByVal rootPath As String,
               ByVal dateStarted As String,
               ByVal dateCompleted As String)
        mTitle = title
        mDescription = description
        If rootPath.EndsWith("\") Then
            mFullPath = rootPath & title
        Else
            mFullPath = rootPath & "\" & title
        End If

        mDateStarted = dateStarted
        mDateCompleted = dateCompleted
    End Sub
    ' Constructor that takes a DirectoryInfo object
    Public Sub New(ByVal dirInfo As DirectoryInfo)
        mTitle = dirInfo.Name
        mFullPath = dirInfo.FullName

        Dim infoFile As String = dirInfo.FullName & "\" & infoFileName
        If File.Exists(infoFile) Then
            Load(dirInfo)
        Else
            Save(dirInfo)
        End If

    End Sub
    ' Constructor that takes a path to a project folder
    Sub New(selectedProjectPath As String)
        Load(selectedProjectPath)
    End Sub

#End Region

    Private Sub HideFile(ByVal filePath As String)
        File.SetAttributes(filePath, IO.FileAttributes.Hidden Or IO.FileAttributes.System)
    End Sub

    ' Read and Write the ProjectInfo to an XML file
    Public Sub Load(ByVal dirInfo As DirectoryInfo)
        Dim infoFile As String = dirInfo.FullName & "\" & infoFileName
        XmlDeserializeFile(infoFile)
    End Sub

    'Overloaded version that takes just a path
    Public Sub Load(ByVal path As String)
        Dim infoFile As String = path & "\" & infoFileName
        XmlDeserializeFile(infoFile)
    End Sub

    ''' <summary>
    ''' Write that takes a path as an argument.
    ''' This is used when a project is not fully initialized
    ''' </summary>
    ''' <param name="path"></param>
    ''' <remarks></remarks>
    Public Sub Save(ByVal path As String)
        Dim infoFile As String = path & "\" & infoFileName
        XmlSerializeFile(infoFile)
    End Sub
    ' Save that takes no parameters
    Public Sub Save()
        Dim infoFile As String = mFullPath & "\" & infoFileName
        XmlSerializeFile(infoFile)
    End Sub
    ' Save that takes a DirectoryInfo object
    Public Sub Save(ByVal dirInfo As DirectoryInfo)
        Dim infoFile As String = dirInfo.FullName & "\" & infoFileName
        XmlSerializeFile(infoFile)
    End Sub



    ' XML SERIALIZE
    Private Sub XmlSerializeFile(ByVal infoFile As String)
        Dim serializer As New System.Xml.Serialization.XmlSerializer(GetType(ProjectInfo))
        Using writer As New System.IO.StreamWriter(infoFile)
            Try
                serializer.Serialize(writer, Me)
                mWriteSuccess = True
            Catch ex As Exception
                mWriteSuccess = False
            End Try
        End Using
    End Sub
    ' XML DESERIALIZE
    Private Sub XmlDeserializeFile(ByVal infoFile As String)
        Dim serializer As New System.Xml.Serialization.XmlSerializer(GetType(ProjectInfo))
        Using reader As New System.IO.StreamReader(infoFile)
            Try
                Dim info As ProjectInfo = serializer.Deserialize(reader)
                mTitle = info.Title
                mDescription = info.Description
                mDateStarted = info.DateStarted
                mDateCompleted = info.DateCompleted
                mReadSuccess = True
            Catch ex As Exception
                mReadSuccess = False
            End Try
        End Using
    End Sub

    Public Shared Function IsValidProject(path As String) As Boolean
        Dim testProject As New ProjectInfo(path)
        Return testProject.ReadSuccess()
    End Function

    <Category("Basic Info")>
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
    <Category("Time")>
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

    Property Path() As String
        Get
            Return mFullPath
        End Get
        Set(value As String)
            mFullPath = value
        End Set
    End Property

    Private ReadOnly Property ReadSuccess() As String
        Get
            Return mReadSuccess
        End Get
    End Property
    Private ReadOnly Property WriteSuccess() As String
        Get
            Return mWriteSuccess
        End Get
    End Property





End Class
