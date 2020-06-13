
Public Class FrmAdd
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        If TxtName.Text = Nothing Then
            Beep()
            MsgBox("Name is a required field.")
            Dim unused = TxtName.Focus()
            Return
        End If
        SubAddRecord()
        FrmTsvFiles.Enabled = True
        FrmTsvFiles.Show()
        Close()
    End Sub

    Public Sub SubAddRecord()
        ReadSettings()
        TsvCounter += 1
        Dim unused = WriteToFile(FullPath, CStr(TsvCounter), TxtName.Text, DtpDateDue.Value.ToString, TxtAmount.Text)
        SaveSettings()
    End Sub

    Private Sub TxtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAmount.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Then 'Allows only numbers
            e.KeyChar = e.KeyChar
        ElseIf Asc(e.KeyChar) = 8 Then 'Allows "Backspace" to be used
            e.KeyChar = e.KeyChar
        ElseIf e.KeyChar = "." Then
            If TxtAmount.Text.IndexOf(".") > -1 Then 'Allows " . " and prevents more than 1 " . "
                e.Handled = True
                Beep()
            End If
        Else
            e.Handled = True  'Disallows all other characters from being used on TxtAmount.Text
            Beep()
        End If
    End Sub

    Private Sub FrmAdd_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FrmTsvFiles.Enabled = True
        ' Close()
    End Sub
End Class