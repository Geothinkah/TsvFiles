<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTsvFiles
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MnuTSVFiles = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerMain = New System.Windows.Forms.Timer(Me.components)
        Me.LblTimer = New System.Windows.Forms.Label()
        Me.MnuTSVFiles.SuspendLayout()
        Me.SuspendLayout()
        '
        'MnuTSVFiles
        '
        Me.MnuTSVFiles.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MnuTSVFiles.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MnuTSVFiles.Location = New System.Drawing.Point(0, 0)
        Me.MnuTSVFiles.Name = "MnuTSVFiles"
        Me.MnuTSVFiles.Size = New System.Drawing.Size(1877, 29)
        Me.MnuTSVFiles.TabIndex = 8
        Me.MnuTSVFiles.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddRecordToolStripMenuItem, Me.SelectRecordToolStripMenuItem, Me.DeleteRecordToolStripMenuItem, Me.EditRecordToolStripMenuItem, Me.SortRecordsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 25)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AddRecordToolStripMenuItem
        '
        Me.AddRecordToolStripMenuItem.Name = "AddRecordToolStripMenuItem"
        Me.AddRecordToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.AddRecordToolStripMenuItem.Text = "Add Record"
        '
        'SelectRecordToolStripMenuItem
        '
        Me.SelectRecordToolStripMenuItem.Name = "SelectRecordToolStripMenuItem"
        Me.SelectRecordToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.SelectRecordToolStripMenuItem.Text = "Select Record"
        '
        'DeleteRecordToolStripMenuItem
        '
        Me.DeleteRecordToolStripMenuItem.Name = "DeleteRecordToolStripMenuItem"
        Me.DeleteRecordToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.DeleteRecordToolStripMenuItem.Text = "Delete Record"
        '
        'EditRecordToolStripMenuItem
        '
        Me.EditRecordToolStripMenuItem.Enabled = False
        Me.EditRecordToolStripMenuItem.Name = "EditRecordToolStripMenuItem"
        Me.EditRecordToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.EditRecordToolStripMenuItem.Text = "Edit Record"
        '
        'SortRecordsToolStripMenuItem
        '
        Me.SortRecordsToolStripMenuItem.Enabled = False
        Me.SortRecordsToolStripMenuItem.Name = "SortRecordsToolStripMenuItem"
        Me.SortRecordsToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.SortRecordsToolStripMenuItem.Text = "Sort Records"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TimerMain
        '
        Me.TimerMain.Enabled = True
        '
        'LblTimer
        '
        Me.LblTimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTimer.Location = New System.Drawing.Point(12, 41)
        Me.LblTimer.Name = "LblTimer"
        Me.LblTimer.Size = New System.Drawing.Size(126, 80)
        Me.LblTimer.TabIndex = 9
        Me.LblTimer.Text = "Label1"
        Me.LblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmTsvFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(1877, 692)
        Me.Controls.Add(Me.LblTimer)
        Me.Controls.Add(Me.MnuTSVFiles)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MnuTSVFiles
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmTsvFiles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tsv Files"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MnuTSVFiles.ResumeLayout(False)
        Me.MnuTSVFiles.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MnuTSVFiles As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortRecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimerMain As Timer
    Friend WithEvents LblTimer As Label
End Class
