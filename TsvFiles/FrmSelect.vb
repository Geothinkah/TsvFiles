Public Class FrmSelect
    Private Sub FrmSelect_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FrmTsvFiles.Enabled = True
    End Sub
End Class