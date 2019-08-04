<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LabelClientName = New System.Windows.Forms.Label()
        Me.ComboBoxClientName = New System.Windows.Forms.ComboBox()
        Me.LabelStartTime = New System.Windows.Forms.Label()
        Me.LabelStopTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.ButtonStop = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelBilling = New System.Windows.Forms.Label()
        Me.LabelStart = New System.Windows.Forms.Label()
        Me.LabelStop = New System.Windows.Forms.Label()
        Me.LabelBillableHrs = New System.Windows.Forms.Label()
        Me.TimerTimeClock = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LabelClientName
        '
        Me.LabelClientName.AutoSize = True
        Me.LabelClientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClientName.Location = New System.Drawing.Point(221, 52)
        Me.LabelClientName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelClientName.Name = "LabelClientName"
        Me.LabelClientName.Size = New System.Drawing.Size(125, 25)
        Me.LabelClientName.TabIndex = 0
        Me.LabelClientName.Text = "Client Name:"
        '
        'ComboBoxClientName
        '
        Me.ComboBoxClientName.FormattingEnabled = True
        Me.ComboBoxClientName.Location = New System.Drawing.Point(361, 54)
        Me.ComboBoxClientName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxClientName.Name = "ComboBoxClientName"
        Me.ComboBoxClientName.Size = New System.Drawing.Size(339, 24)
        Me.ComboBoxClientName.TabIndex = 1
        '
        'LabelStartTime
        '
        Me.LabelStartTime.AutoSize = True
        Me.LabelStartTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStartTime.Location = New System.Drawing.Point(447, 143)
        Me.LabelStartTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelStartTime.Name = "LabelStartTime"
        Me.LabelStartTime.Size = New System.Drawing.Size(80, 18)
        Me.LabelStartTime.TabIndex = 2
        Me.LabelStartTime.Text = "Start Time:"
        '
        'LabelStopTime
        '
        Me.LabelStopTime.AutoSize = True
        Me.LabelStopTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStopTime.Location = New System.Drawing.Point(447, 194)
        Me.LabelStopTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelStopTime.Name = "LabelStopTime"
        Me.LabelStopTime.Size = New System.Drawing.Size(80, 18)
        Me.LabelStopTime.TabIndex = 3
        Me.LabelStopTime.Text = "Stop Time:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(355, 247)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Billable hours, minutes:"
        '
        'ButtonStart
        '
        Me.ButtonStart.Location = New System.Drawing.Point(161, 309)
        Me.ButtonStart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(100, 28)
        Me.ButtonStart.TabIndex = 5
        Me.ButtonStart.Text = "Start"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'ButtonStop
        '
        Me.ButtonStop.Enabled = False
        Me.ButtonStop.Location = New System.Drawing.Point(323, 309)
        Me.ButtonStop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonStop.Name = "ButtonStop"
        Me.ButtonStop.Size = New System.Drawing.Size(100, 28)
        Me.ButtonStop.TabIndex = 6
        Me.ButtonStop.Text = "Stop"
        Me.ButtonStop.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(485, 309)
        Me.ButtonExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(100, 28)
        Me.ButtonExit.TabIndex = 7
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Location = New System.Drawing.Point(16, 101)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(704, 2)
        Me.Panel1.TabIndex = 8
        '
        'LabelBilling
        '
        Me.LabelBilling.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBilling.Location = New System.Drawing.Point(49, 143)
        Me.LabelBilling.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelBilling.Name = "LabelBilling"
        Me.LabelBilling.Size = New System.Drawing.Size(243, 28)
        Me.LabelBilling.TabIndex = 9
        Me.LabelBilling.Text = "Billing in progress..."
        Me.LabelBilling.Visible = False
        '
        'LabelStart
        '
        Me.LabelStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelStart.Location = New System.Drawing.Point(543, 143)
        Me.LabelStart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelStart.Name = "LabelStart"
        Me.LabelStart.Size = New System.Drawing.Size(133, 28)
        Me.LabelStart.TabIndex = 10
        '
        'LabelStop
        '
        Me.LabelStop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelStop.Location = New System.Drawing.Point(543, 194)
        Me.LabelStop.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelStop.Name = "LabelStop"
        Me.LabelStop.Size = New System.Drawing.Size(133, 28)
        Me.LabelStop.TabIndex = 11
        '
        'LabelBillableHrs
        '
        Me.LabelBillableHrs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelBillableHrs.Location = New System.Drawing.Point(543, 247)
        Me.LabelBillableHrs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelBillableHrs.Name = "LabelBillableHrs"
        Me.LabelBillableHrs.Size = New System.Drawing.Size(133, 28)
        Me.LabelBillableHrs.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 409)
        Me.Controls.Add(Me.LabelBillableHrs)
        Me.Controls.Add(Me.LabelStop)
        Me.Controls.Add(Me.LabelStart)
        Me.Controls.Add(Me.LabelBilling)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonStop)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelStopTime)
        Me.Controls.Add(Me.LabelStartTime)
        Me.Controls.Add(Me.ComboBoxClientName)
        Me.Controls.Add(Me.LabelClientName)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Lance'sLab Consulting Time Clock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelClientName As System.Windows.Forms.Label
    Friend WithEvents ComboBoxClientName As System.Windows.Forms.ComboBox
    Friend WithEvents LabelStartTime As System.Windows.Forms.Label
    Friend WithEvents LabelStopTime As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonStart As System.Windows.Forms.Button
    Friend WithEvents ButtonStop As System.Windows.Forms.Button
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelBilling As System.Windows.Forms.Label
    Friend WithEvents LabelStart As System.Windows.Forms.Label
    Friend WithEvents LabelStop As System.Windows.Forms.Label
    Friend WithEvents LabelBillableHrs As System.Windows.Forms.Label
    Friend WithEvents TimerTimeClock As System.Windows.Forms.Timer

End Class
