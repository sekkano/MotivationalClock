<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MotivationalForm
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
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.lstEntry = New System.Windows.Forms.ListBox()
        Me.lblPreviousTimes = New System.Windows.Forms.Label()
        Me.txtSeconds = New System.Windows.Forms.TextBox()
        Me.txtMinutes = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.btnRangeSixtyNinety = New System.Windows.Forms.Button()
        Me.btnRangeThirtySixty = New System.Windows.Forms.Button()
        Me.btnRangeZeroThirty = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblCountDown = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnSetTime = New System.Windows.Forms.Button()
        Me.btnAddTime = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblNotes.Location = New System.Drawing.Point(266, 58)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(157, 17)
        Me.lblNotes.TabIndex = 47
        Me.lblNotes.Text = "Click an entry for notes:"
        '
        'lstEntry
        '
        Me.lstEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lstEntry.FormattingEnabled = True
        Me.lstEntry.ItemHeight = 20
        Me.lstEntry.Location = New System.Drawing.Point(269, 78)
        Me.lstEntry.Name = "lstEntry"
        Me.lstEntry.Size = New System.Drawing.Size(246, 204)
        Me.lstEntry.TabIndex = 46
        '
        'lblPreviousTimes
        '
        Me.lblPreviousTimes.AutoSize = True
        Me.lblPreviousTimes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreviousTimes.Location = New System.Drawing.Point(265, 23)
        Me.lblPreviousTimes.Name = "lblPreviousTimes"
        Me.lblPreviousTimes.Size = New System.Drawing.Size(115, 20)
        Me.lblPreviousTimes.TabIndex = 45
        Me.lblPreviousTimes.Text = "Previous Times"
        '
        'txtSeconds
        '
        Me.txtSeconds.Location = New System.Drawing.Point(156, 195)
        Me.txtSeconds.Name = "txtSeconds"
        Me.txtSeconds.Size = New System.Drawing.Size(33, 20)
        Me.txtSeconds.TabIndex = 44
        Me.txtSeconds.Text = "0"
        '
        'txtMinutes
        '
        Me.txtMinutes.Location = New System.Drawing.Point(156, 161)
        Me.txtMinutes.Name = "txtMinutes"
        Me.txtMinutes.Size = New System.Drawing.Size(33, 20)
        Me.txtMinutes.TabIndex = 43
        Me.txtMinutes.Text = "0"
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(156, 126)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(33, 20)
        Me.txtHours.TabIndex = 42
        Me.txtHours.Text = "0"
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconds.Location = New System.Drawing.Point(74, 193)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(76, 20)
        Me.lblSeconds.TabIndex = 41
        Me.lblSeconds.Text = "Seconds:"
        '
        'lblMinutes
        '
        Me.lblMinutes.AutoSize = True
        Me.lblMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutes.Location = New System.Drawing.Point(81, 159)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(69, 20)
        Me.lblMinutes.TabIndex = 40
        Me.lblMinutes.Text = "Minutes:"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.Location = New System.Drawing.Point(94, 124)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(56, 20)
        Me.lblHours.TabIndex = 39
        Me.lblHours.Text = "Hours:"
        '
        'btnRangeSixtyNinety
        '
        Me.btnRangeSixtyNinety.Location = New System.Drawing.Point(188, 77)
        Me.btnRangeSixtyNinety.Name = "btnRangeSixtyNinety"
        Me.btnRangeSixtyNinety.Size = New System.Drawing.Size(75, 23)
        Me.btnRangeSixtyNinety.TabIndex = 38
        Me.btnRangeSixtyNinety.Text = "60 - 90 min"
        Me.btnRangeSixtyNinety.UseVisualStyleBackColor = True
        '
        'btnRangeThirtySixty
        '
        Me.btnRangeThirtySixty.Location = New System.Drawing.Point(107, 77)
        Me.btnRangeThirtySixty.Name = "btnRangeThirtySixty"
        Me.btnRangeThirtySixty.Size = New System.Drawing.Size(75, 23)
        Me.btnRangeThirtySixty.TabIndex = 37
        Me.btnRangeThirtySixty.Text = "30 - 60 min"
        Me.btnRangeThirtySixty.UseVisualStyleBackColor = True
        '
        'btnRangeZeroThirty
        '
        Me.btnRangeZeroThirty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRangeZeroThirty.Location = New System.Drawing.Point(26, 77)
        Me.btnRangeZeroThirty.Name = "btnRangeZeroThirty"
        Me.btnRangeZeroThirty.Size = New System.Drawing.Size(75, 23)
        Me.btnRangeZeroThirty.TabIndex = 36
        Me.btnRangeZeroThirty.Text = "0 - 30 min"
        Me.btnRangeZeroThirty.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(188, 259)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 35
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(107, 259)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 34
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(26, 259)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 33
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblCountDown
        '
        Me.lblCountDown.AutoSize = True
        Me.lblCountDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountDown.Location = New System.Drawing.Point(80, 23)
        Me.lblCountDown.Name = "lblCountDown"
        Me.lblCountDown.Size = New System.Drawing.Size(130, 39)
        Me.lblCountDown.TabIndex = 32
        Me.lblCountDown.Text = "0:00:00"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(354, 288)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 48
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(440, 288)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 49
        Me.btnDelete.Text = "Delete Entry"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'tmrTimer
        '
        Me.tmrTimer.Interval = 1000
        '
        'btnSetTime
        '
        Me.btnSetTime.Location = New System.Drawing.Point(107, 230)
        Me.btnSetTime.Name = "btnSetTime"
        Me.btnSetTime.Size = New System.Drawing.Size(75, 23)
        Me.btnSetTime.TabIndex = 51
        Me.btnSetTime.Text = "Set Time"
        Me.btnSetTime.UseVisualStyleBackColor = True
        '
        'btnAddTime
        '
        Me.btnAddTime.Location = New System.Drawing.Point(269, 288)
        Me.btnAddTime.Name = "btnAddTime"
        Me.btnAddTime.Size = New System.Drawing.Size(75, 23)
        Me.btnAddTime.TabIndex = 52
        Me.btnAddTime.Text = "Add Time"
        Me.btnAddTime.UseVisualStyleBackColor = True
        '
        'MotivationalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 320)
        Me.Controls.Add(Me.btnAddTime)
        Me.Controls.Add(Me.btnSetTime)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.lstEntry)
        Me.Controls.Add(Me.lblPreviousTimes)
        Me.Controls.Add(Me.txtSeconds)
        Me.Controls.Add(Me.txtMinutes)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.lblMinutes)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.btnRangeSixtyNinety)
        Me.Controls.Add(Me.btnRangeThirtySixty)
        Me.Controls.Add(Me.btnRangeZeroThirty)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblCountDown)
        Me.Name = "MotivationalForm"
        Me.Text = "Motivational Clock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNotes As Label
    Friend WithEvents lstEntry As ListBox
    Friend WithEvents lblPreviousTimes As Label
    Friend WithEvents txtSeconds As TextBox
    Friend WithEvents txtMinutes As TextBox
    Friend WithEvents txtHours As TextBox
    Friend WithEvents lblSeconds As Label
    Friend WithEvents lblMinutes As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents btnRangeSixtyNinety As Button
    Friend WithEvents btnRangeThirtySixty As Button
    Friend WithEvents btnRangeZeroThirty As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents lblCountDown As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents tmrTimer As Timer
    Friend WithEvents btnSetTime As System.Windows.Forms.Button
    Friend WithEvents btnAddTime As System.Windows.Forms.Button
End Class
