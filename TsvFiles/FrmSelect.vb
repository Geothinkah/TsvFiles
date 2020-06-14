Public Class FrmSelect
    Public AccountArray(100) As String
    Private Sub FrmSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillListBox()
    End Sub


    Private Sub FrmSelect_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FrmTsvFiles.Enabled = True
    End Sub

    Private Sub LstAccounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstAccounts.SelectedIndexChanged
        'LblSelected.Text = LstAccounts.SelectedItem.ToString
        Panel1.Visible = True
        Dim currentRecord() As String = Split(AccountArray(LstAccounts.SelectedIndex), delimiter)
        LblID.Text = currentRecord(0)
        LblName.Text = currentRecord(1)
        LblDueDate.Text = currentRecord(2)
        LblAmountDue.Text = currentRecord(3)
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

End Class