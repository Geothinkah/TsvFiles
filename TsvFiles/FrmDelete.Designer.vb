<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDelete
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
        Me.LstAccounts = New System.Windows.Forms.ListBox()
        Me.LblDelete = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RbtnYes = New System.Windows.Forms.RadioButton()
        Me.RbtnNo = New System.Windows.Forms.RadioButton()
        Me.LblID = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblDueDate = New System.Windows.Forms.Label()
        Me.LblAmountDue = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LstAccounts
        '
        Me.LstAccounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstAccounts.FormattingEnabled = True
        Me.LstAccounts.ItemHeight = 20
        Me.LstAccounts.Location = New System.Drawing.Point(23, 60)
        Me.LstAccounts.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LstAccounts.Name = "LstAccounts"
        Me.LstAccounts.Size = New System.Drawing.Size(170, 284)
        Me.LstAccounts.TabIndex = 0
        '
        'LblDelete
        '
        Me.LblDelete.AutoSize = True
        Me.LblDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDelete.Location = New System.Drawing.Point(44, 24)
        Me.LblDelete.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDelete.Name = "LblDelete"
        Me.LblDelete.Size = New System.Drawing.Size(131, 20)
        Me.LblDelete.TabIndex = 1
        Me.LblDelete.Text = "Select Account"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LblAmountDue)
        Me.Panel1.Controls.Add(Me.LblDueDate)
        Me.Panel1.Controls.Add(Me.LblName)
        Me.Panel1.Controls.Add(Me.LblID)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(215, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(257, 210)
        Me.Panel1.TabIndex = 2
        Me.Panel1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(281, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Delete Account"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Due Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Amount Due"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Bisque
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.RbtnNo)
        Me.Panel2.Controls.Add(Me.RbtnYes)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(-1, 159)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(258, 48)
        Me.Panel2.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Delete"
        '
        'RbtnYes
        '
        Me.RbtnYes.AutoSize = True
        Me.RbtnYes.Location = New System.Drawing.Point(108, 13)
        Me.RbtnYes.Name = "RbtnYes"
        Me.RbtnYes.Size = New System.Drawing.Size(55, 24)
        Me.RbtnYes.TabIndex = 1
        Me.RbtnYes.Text = "Yes"
        Me.RbtnYes.UseVisualStyleBackColor = True
        '
        'RbtnNo
        '
        Me.RbtnNo.AutoSize = True
        Me.RbtnNo.Location = New System.Drawing.Point(169, 13)
        Me.RbtnNo.Name = "RbtnNo"
        Me.RbtnNo.Size = New System.Drawing.Size(47, 24)
        Me.RbtnNo.TabIndex = 2
        Me.RbtnNo.Text = "No"
        Me.RbtnNo.UseVisualStyleBackColor = True
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Location = New System.Drawing.Point(120, 17)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(57, 20)
        Me.LblID.TabIndex = 8
        Me.LblID.Text = "Label7"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(120, 53)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(57, 20)
        Me.LblName.TabIndex = 10
        Me.LblName.Text = "Label8"
        '
        'LblDueDate
        '
        Me.LblDueDate.AutoSize = True
        Me.LblDueDate.Location = New System.Drawing.Point(120, 87)
        Me.LblDueDate.Name = "LblDueDate"
        Me.LblDueDate.Size = New System.Drawing.Size(57, 20)
        Me.LblDueDate.TabIndex = 12
        Me.LblDueDate.Text = "Label9"
        '
        'LblAmountDue
        '
        Me.LblAmountDue.AutoSize = True
        Me.LblAmountDue.Location = New System.Drawing.Point(120, 122)
        Me.LblAmountDue.Name = "LblAmountDue"
        Me.LblAmountDue.Size = New System.Drawing.Size(66, 20)
        Me.LblAmountDue.TabIndex = 14
        Me.LblAmountDue.Text = "Label10"
        '
        'FrmDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblDelete)
        Me.Controls.Add(Me.LstAccounts)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximumSize = New System.Drawing.Size(500, 500)
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "FrmDelete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TSVFiles - Delete"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LstAccounts As ListBox
    Friend WithEvents LblDelete As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RbtnNo As RadioButton
    Friend WithEvents RbtnYes As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblAmountDue As Label
    Friend WithEvents LblDueDate As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblID As Label
End Class
