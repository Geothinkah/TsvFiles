
Imports System.IO
Imports Microsoft.VisualBasic.Devices

Public Class FrmTsvFiles

#Region "***** Declarations *****"
    'Public DataPath As String = Application.UserAppDataPath
    'Public TsvFileName As String = "TsvFile.tsv"
    'Public FullPath As String = DataPath & "\" & TsvFileName
    'Public TsvFile As String
    'Public TsvRecord As String


#End Region

#Region "***** Appends a new record to the file. *****"

    Private Sub AddRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddRecordToolStripMenuItem.Click
        Enabled = False
        FrmAdd.Enabled = True
        FrmAdd.Show()

    End Sub


    'Public Sub SubAddEvent()
    '    ReadSettings()
    '    TsvCounter += 1
    '    Dim unused = WriteToFile(FullPath, CStr(TsvCounter), "Capital One", Date.Now.ToShortDateString, CStr(55.55))
    '    TsvCounter += 1
    '    unused = WriteToFile(FullPath, CStr(TsvCounter), "MMerrick Bank", Date.Now.ToShortDateString, CStr(55.55))
    '    TsvCounter += 1
    '    unused = WriteToFile(FullPath, CStr(TsvCounter), "Merrick Bank", Date.Now.ToShortDateString, CStr(55.55))
    '    TsvCounter += 1
    '    unused = WriteToFile(FullPath, CStr(TsvCounter), "Discover", Date.Now.ToShortDateString, CStr(55.55))
    '    TsvCounter += 1
    '    unused = WriteToFile(FullPath, CStr(TsvCounter), "First Citizens Bank", Date.Now.ToShortDateString, CStr(55.55))
    '    TsvCounter += 1
    '    unused = WriteToFile(FullPath, CStr(TsvCounter), "Child Support", Date.Now.ToShortDateString, CStr(55.55))
    '    TsvCounter += 1
    '    unused = WriteToFile(FullPath, CStr(TsvCounter), "Cremation", Date.Now.ToShortDateString, CStr(55.55))
    '    LblOutPut.Text = "Record Counter is now at " & CStr(TsvCounter)
    '    SaveSettings()
    'End Sub



    '''' <summary>
    '''' This appends a record to the file
    '''' </summary>
    '''' <param name="fullpath"></param>
    '''' <param name="recordnumber"></param>
    '''' <param name="name"></param>
    '''' <param name="shortduedate"></param>
    '''' <param name="amount"></param>
    '''' <returns></returns>
    'Public Function WriteToFile(ByVal fullpath As String, recordnumber As String, ByVal name As String,
    '                            shortduedate As String, amount As String) As Boolean
    '    Try
    '        Dim filewriter As New StreamWriter(fullpath, True) 'True appends the record to the file. False replaces the file.
    '        Dim record As String = recordnumber & delimiter & name & delimiter & shortduedate & delimiter & amount
    '        filewriter.WriteLine(record)
    '        filewriter.Close()
    '        Return True
    '    Catch ex As Exception
    '        Dim unused = MsgBox("Failed in the WriteToFile routine...")
    '    End Try
    '    Return False
    'End Function
#End Region

#Region "***** Searches for a given value and returns it's record. *****"

    Private Sub SelectRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectRecordToolStripMenuItem.Click
        Enabled = False
        FrmSelect.Show()
        'SelectEvent()
    End Sub

    Public Sub SelectEvent()
        Dim unused = ReadRecord(FullPath, "Capital One", 1) 'The last value is the column to be searched
    End Sub


    ''' <summary>
    ''' This searches for and gets the first record that matches the given search term
    ''' </summary>
    ''' <param name="fullpath"></param>
    ''' <param name="searchTerm"></param>
    ''' <param name="searchTermPosition"></param>
    ''' <returns></returns>
    Public Function ReadRecord(ByVal fullpath As String, ByVal searchTerm As String,
                               ByVal searchTermPosition As Integer) As String


        'searchTermPosition -= 1
        'searchTermPosition 
        Dim currentline As String

        Try
            Dim fileReader As New System.IO.StreamReader(fullpath)
            Do While fileReader.Peek <> -1
                currentline = fileReader.ReadLine()
                Dim currentRecord() As String = Split(currentline, delimiter)
                If String.Compare(currentRecord(searchTermPosition), searchTerm) = 0 Then
                    fileReader.Close()
                    Return currentline
                End If
            Loop

            fileReader.Close()
            MsgBox("fileReader closed")
        Catch ex As Exception
            Dim unused = MsgBox("Error in the ReadRecord Routine...")
        End Try
        Return "Not Found"
    End Function
#End Region

#Region "***** Deletes a record *****"

    Private Sub DeleteRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRecordToolStripMenuItem.Click
        DeleteEvent()
    End Sub

    Public Sub DeleteEvent()
        Dim unused = DeleteRecord(FullPath, "MMerrick Bank", 1) 'The last number is the column you want to search for the record
    End Sub

    Public Function DeleteRecord(ByVal fulldatapath As String, ByVal deleteterm As String, deletetermposition As Integer) As Boolean
        Dim deletedrecorded As Boolean = False
        Dim tempfile As String = "\tempfile.tsv"
        Dim currentline As String
        Try
            Dim filereader As New StreamReader(fulldatapath)
            Dim filewriter As New StreamWriter(DataPath & tempfile, True)
            Do While filereader.Peek() <> -1
                currentline = filereader.ReadLine()
                Dim currentrecord() As String = Split(currentline, delimiter)
                If Not String.Compare(currentrecord(deletetermposition), deleteterm) = 0 Then
                    filewriter.WriteLine(currentline)
                Else
                    deletedrecorded = True
                End If
            Loop
            filewriter.Close()
            filereader.Close()

            My.Computer.FileSystem.DeleteFile(fulldatapath)
            My.Computer.FileSystem.RenameFile(DataPath & tempfile, TsvFileName)

        Catch ex As Exception
            Dim unused = MsgBox("Failed in the delete proceedure")
        End Try
        Return deletedrecorded
    End Function
#End Region

#Region "***** Exits the program *****"
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub FrmTsvFiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LblDate_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LblName_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

End Class
