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
        Me.tmrTrigger = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTimeLeft = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lblInterval = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tmrTrigger
        '
        Me.tmrTrigger.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Next call on"
        '
        'lblTimeLeft
        '
        Me.lblTimeLeft.AutoSize = True
        Me.lblTimeLeft.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeLeft.Location = New System.Drawing.Point(70, 75)
        Me.lblTimeLeft.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTimeLeft.Name = "lblTimeLeft"
        Me.lblTimeLeft.Size = New System.Drawing.Size(96, 39)
        Me.lblTimeLeft.TabIndex = 1
        Me.lblTimeLeft.Text = "00:00"
        Me.lblTimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 55)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "This program requires AutoIt v3 installed, otherwise it won't work."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Roblox Anti-AFK"
        '
        'btnStart
        '
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Location = New System.Drawing.Point(200, 5)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 35)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Location = New System.Drawing.Point(200, 45)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 35)
        Me.btnStop.TabIndex = 5
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'lblInterval
        '
        Me.lblInterval.AutoSize = True
        Me.lblInterval.Location = New System.Drawing.Point(5, 200)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(146, 19)
        Me.lblInterval.TabIndex = 6
        Me.lblInterval.Text = "Interval: N minutes"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(281, 234)
        Me.Controls.Add(Me.lblInterval)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTimeLeft)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Roblox Anti-AFK - By Hevanafa 07-05-2023"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrTrigger As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTimeLeft As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents lblInterval As Label
End Class
