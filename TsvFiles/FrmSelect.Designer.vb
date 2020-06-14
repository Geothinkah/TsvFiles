<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelect
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.LstAccounts = New System.Windows.Forms.ListBox()
        Me.LblSelected = New System.Windows.Forms.Label()
        Me.LblSelectAccount = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblDueDate = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblAmountDue = New System.Windows.Forms.Label()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'LstAccounts
        '
        Me.LstAccounts.FormattingEnabled = True
        Me.LstAccounts.ItemHeight = 20
        Me.LstAccounts.Location = New System.Drawing.Point(46, 90)
        Me.LstAccounts.Name = "LstAccounts"
        Me.LstAccounts.Size = New System.Drawing.Size(120, 204)
        Me.LstAccounts.TabIndex = 1
        '
        'LblSelected
        '
        Me.LblSelected.AutoSize = True
        Me.LblSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSelected.Location = New System.Drawing.Point(250, 62)
        Me.LblSelected.Name = "LblSelected"
        Me.LblSelected.Size = New System.Drawing.Size(151, 20)
        Me.LblSelected.TabIndex = 2
        Me.LblSelected.Text = "Selected Account"
        Me.LblSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSelectAccount
        '
        Me.LblSelectAccount.AutoSize = True
        Me.LblSelectAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSelectAccount.Location = New System.Drawing.Point(42, 62)
        Me.LblSelectAccount.Name = "LblSelectAccount"
        Me.LblSelectAccount.Size = New System.Drawing.Size(131, 20)
        Me.LblSelectAccount.TabIndex = 3
        Me.LblSelectAccount.Text = "Select Account"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LblAmountDue)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.LblDueDate)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.LblName)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.LblID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(224, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 160)
        Me.Panel1.TabIndex = 5
        Me.Panel1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Location = New System.Drawing.Point(111, 15)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(26, 20)
        Me.LblID.TabIndex = 2
        Me.LblID.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(111, 46)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(51, 20)
        Me.LblName.TabIndex = 6
        Me.LblName.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Due Date"
        '
        'LblDueDate
        '
        Me.LblDueDate.AutoSize = True
        Me.LblDueDate.Location = New System.Drawing.Point(111, 82)
        Me.LblDueDate.Name = "LblDueDate"
        Me.LblDueDate.Size = New System.Drawing.Size(78, 20)
        Me.LblDueDate.TabIndex = 10
        Me.LblDueDate.Text = "Due Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Amount Due"
        '
        'LblAmountDue
        '
        Me.LblAmountDue.AutoSize = True
        Me.LblAmountDue.Location = New System.Drawing.Point(111, 118)
        Me.LblAmountDue.Name = "LblAmountDue"
        Me.LblAmountDue.Size = New System.Drawing.Size(99, 20)
        Me.LblAmountDue.TabIndex = 14
        Me.LblAmountDue.Text = "Amount Due"
        '
        'FrmSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblSelectAccount)
        Me.Controls.Add(Me.LblSelected)
        Me.Controls.Add(Me.LstAccounts)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 500)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "FrmSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TsvFile - Select Record"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents LblSelected As Label
    Friend WithEvents LstAccounts As ListBox
    Friend WithEvents LblSelectAccount As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblAmountDue As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LblDueDate As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblID As Label
    Friend WithEvents Label1 As Label
End Class
