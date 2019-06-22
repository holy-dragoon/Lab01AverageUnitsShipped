<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AverageUnitsShippedForm
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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtUserInput = New System.Windows.Forms.TextBox()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblDayNumber = New System.Windows.Forms.Label()
        Me.ToolipTipUnitAverages = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtDayUnits = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(25, 212)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 5
        Me.btnEnter.Text = "&Enter"
        Me.ToolipTipUnitAverages.SetToolTip(Me.btnEnter, "Add the Days' Units and Average all the entries")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(106, 212)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.ToolipTipUnitAverages.SetToolTip(Me.btnReset, "Clear All entried and Results")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(187, 212)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.ToolipTipUnitAverages.SetToolTip(Me.btnExit, "Exit the Applciation")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(52, 186)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(181, 23)
        Me.lblResult.TabIndex = 4
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolipTipUnitAverages.SetToolTip(Me.lblResult, "Displays the aveage units shipped per day.")
        '
        'txtUserInput
        '
        Me.txtUserInput.Location = New System.Drawing.Point(95, 21)
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(86, 20)
        Me.txtUserInput.TabIndex = 1
        Me.ToolipTipUnitAverages.SetToolTip(Me.txtUserInput, "Enter the Day's Units.  Values must be from 0 to 1000")
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(49, 21)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(31, 13)
        Me.lblUnits.TabIndex = 0
        Me.lblUnits.Text = "Unit&s"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDayNumber
        '
        Me.lblDayNumber.Location = New System.Drawing.Point(187, 21)
        Me.lblDayNumber.Name = "lblDayNumber"
        Me.lblDayNumber.Size = New System.Drawing.Size(46, 13)
        Me.lblDayNumber.TabIndex = 2
        Me.lblDayNumber.Text = "Day: 1 "
        Me.lblDayNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDayUnits
        '
        Me.txtDayUnits.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtDayUnits.Location = New System.Drawing.Point(52, 47)
        Me.txtDayUnits.Multiline = True
        Me.txtDayUnits.Name = "txtDayUnits"
        Me.txtDayUnits.ReadOnly = True
        Me.txtDayUnits.Size = New System.Drawing.Size(181, 136)
        Me.txtDayUnits.TabIndex = 3
        Me.ToolipTipUnitAverages.SetToolTip(Me.txtDayUnits, "Displays the units entered for each day of the week.")
        '
        'AverageUnitsShippedForm
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(287, 251)
        Me.Controls.Add(Me.txtDayUnits)
        Me.Controls.Add(Me.lblDayNumber)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.txtUserInput)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(303, 290)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(303, 290)
        Me.Name = "AverageUnitsShippedForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents txtUserInput As TextBox
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblDayNumber As Label
    Friend WithEvents ToolipTipUnitAverages As ToolTip
    Friend WithEvents txtDayUnits As TextBox
End Class
