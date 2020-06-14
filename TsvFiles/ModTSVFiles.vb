
Imports System.IO
Module ModTSVFiles
    Public DataPath As String = Application.UserAppDataPath
    Public TsvFileName As String = "TsvFile.tsv"
    Public FullPath As String = DataPath & "\" & TsvFileName
    Public TsvFile As String
    Public TsvRecord As String
    Public delimiter As String = ControlChars.Tab
    Public TsvCounter As Integer = 0
    Public AccountArray(100) As String

#Region "***** Write to file *****"
    ''' <summary>
    ''' This appends a record to the file
    ''' </summary>
    ''' <param name="fullpath"></param>
    ''' <param name="recordnumber"></param>
    ''' <param name="name"></param>
    ''' <param name="shortduedate"></param>
    ''' <param name="amount"></param>
    ''' <returns></returns>
    Public Function WriteToFile(ByVal fullpath As String, recordnumber As String, ByVal name As String,
                                shortduedate As String, amount As String) As Boolean
        Try
            Dim filewriter As New StreamWriter(fullpath, True) 'True appends the record to the file. False replaces the file.
            Dim record As String = recordnumber & delimiter & name & delimiter & shortduedate & delimiter & amount
            filewriter.WriteLine(record)
            filewriter.Close()
            Return True
        Catch ex As Exception
            Dim unused = MsgBox("Failed in the WriteToFile routine...")
        End Try
        Return False
    End Function
#End Region

#Region "***** Read and Write Setting.tsv file *****"

    Public Sub ReadSettings()
        Dim SplitLine() As String
        If File.Exists(DataPath & "\Settings.tsv") = True Then
            'Open the StreamReader
            Dim objReader As New StreamReader(DataPath & "\Settings.tsv", System.Text.Encoding.Default)
            Do While objReader.Peek() <> -1                     'Peek to see if there is another line of data to process
                Dim TextLine As String = objReader.ReadLine()   'Read the next line of data
                SplitLine = Split(TextLine, ControlChars.Tab) 'Separate the line into the SplitLine array
                TsvCounter = CInt(SplitLine(0)) ' (0) = Record Counter "TsvCounter"
            Loop
            'Close the StreamReader
            objReader.Close()
        End If
    End Sub

    Public Sub SaveSettings()
        Dim tsv As String = CStr(TsvCounter)
        File.WriteAllText(DataPath & "\Settings.tsv", tsv)
    End Sub

#End Region
End Module
