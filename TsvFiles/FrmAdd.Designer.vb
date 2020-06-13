<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdd
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
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblDataDue = New System.Windows.Forms.Label()
        Me.LblAmount = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.DtpDateDue = New System.Windows.Forms.DateTimePicker()
        Me.TxtAmount = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExit.Location = New System.Drawing.Point(397, 415)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 34)
        Me.BtnExit.TabIndex = 0
        Me.BtnExit.Text = "Save"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(12, 40)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(51, 20)
        Me.LblName.TabIndex = 1
        Me.LblName.Text = "Name"
        '
        'LblDataDue
        '
        Me.LblDataDue.AutoSize = True
        Me.LblDataDue.Location = New System.Drawing.Point(12, 89)
        Me.LblDataDue.Name = "LblDataDue"
        Me.LblDataDue.Size = New System.Drawing.Size(78, 20)
        Me.LblDataDue.TabIndex = 2
        Me.LblDataDue.Text = "Date Due"
        '
        'LblAmount
        '
        Me.LblAmount.AutoSize = True
        Me.LblAmount.Location = New System.Drawing.Point(12, 143)
        Me.LblAmount.Name = "LblAmount"
        Me.LblAmount.Size = New System.Drawing.Size(99, 20)
        Me.LblAmount.TabIndex = 3
        Me.LblAmount.Text = "Amount Due"
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(69, 37)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtName.Size = New System.Drawing.Size(232, 26)
        Me.TxtName.TabIndex = 4
        '
        'DtpDateDue
        '
        Me.DtpDateDue.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDateDue.Location = New System.Drawing.Point(96, 84)
        Me.DtpDateDue.Name = "DtpDateDue"
        Me.DtpDateDue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DtpDateDue.Size = New System.Drawing.Size(130, 26)
        Me.DtpDateDue.TabIndex = 5
        '
        'TxtAmount
        '
        Me.TxtAmount.Location = New System.Drawing.Point(117, 140)
        Me.TxtAmount.Name = "TxtAmount"
        Me.TxtAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtAmount.Size = New System.Drawing.Size(100, 26)
        Me.TxtAmount.TabIndex = 6
        '
        'FrmAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.TxtAmount)
        Me.Controls.Add(Me.DtpDateDue)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.LblAmount)
        Me.Controls.Add(Me.LblDataDue)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.BtnExit)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 500)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "FrmAdd"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TSV File Add"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnExit As Button
    Friend WithEvents LblName As Label
    Friend WithEvents LblDataDue As Label
    Friend WithEvents LblAmount As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents DtpDateDue As DateTimePicker
    Friend WithEvents TxtAmount As TextBox
End Class
