Imports System.IO
Public Class FrmDelete
    Public recordtodelete As String

    Private Sub FrmDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillListBox()
    End Sub

    Private Sub FrmDelete_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FrmTsvFiles.Enabled = True
    End Sub

    Public Sub FillListBox()
        Dim currentline As String
        Try
            Dim fileReader As New System.IO.StreamReader(FullPath)
            Dim cnt As Integer = 0
            Do While fileReader.Peek <> -1
                currentline = fileReader.ReadLine()
                AccountArray(cnt) = currentline
                cnt += 1
                Dim currentRecord() As String = Split(currentline, delimiter)
                LstAccounts.Items.Add(currentRecord(1))
            Loop
            fileReader.Close()
        Catch ex As Exception
            Dim unused = MsgBox("Error in the ReadRecord Routine...")
        End Try
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnNo.CheckedChanged
        Panel1.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub LstAccounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstAccounts.SelectedIndexChanged
        Panel1.Visible = True
        Label1.Visible = True
        RbtnNo.Checked = False
        RbtnYes.Checked = False
        Dim currentRecord() As String = Split(AccountArray(LstAccounts.SelectedIndex), delimiter)
        LblID.Text = currentRecord(0)
        recordtodelete = CStr(currentRecord(0))
        LblName.Text = currentRecord(1)
        LblDueDate.Text = currentRecord(2)
        LblAmountDue.Text = currentRecord(3)
    End Sub

    Private Sub RbtnYes_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnYes.CheckedChanged
        Dim unused = DeleteRecord(FullPath, recordtodelete, 0) 'The last number is the column you want to search for the record
        Panel1.Visible = False
        Label1.Visible = False
        LstAccounts.Items.Clear()
        FillListBox()
    End Sub


#Region "***** Deletes a record *****"

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

End Class