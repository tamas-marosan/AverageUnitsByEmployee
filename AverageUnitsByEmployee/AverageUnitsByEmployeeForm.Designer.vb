<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AverageUnitsByEmployeeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AverageUnitsByEmployeeForm))
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.lblCurrentDay = New System.Windows.Forms.Label()
        Me.lblEmpOne = New System.Windows.Forms.Label()
        Me.txtEmpOne = New System.Windows.Forms.TextBox()
        Me.lblEmpTwo = New System.Windows.Forms.Label()
        Me.txtEmpTwo = New System.Windows.Forms.TextBox()
        Me.lblEmpThree = New System.Windows.Forms.Label()
        Me.txtEmpThree = New System.Windows.Forms.TextBox()
        Me.lblAvgOne = New System.Windows.Forms.Label()
        Me.lblAvgTwo = New System.Windows.Forms.Label()
        Me.lblAvgThree = New System.Windows.Forms.Label()
        Me.lblAvgTotal = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ttpAverageUnitsByEmployee = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(2, 22)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(37, 23)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "&Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttpAverageUnitsByEmployee.SetToolTip(Me.lblUnits, "The number of units sold on the day.")
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(45, 24)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(39, 20)
        Me.txtUnits.TabIndex = 2
        Me.ttpAverageUnitsByEmployee.SetToolTip(Me.txtUnits, "Enter the number of units shipped on this day.")
        '
        'lblCurrentDay
        '
        Me.lblCurrentDay.AutoSize = True
        Me.lblCurrentDay.Location = New System.Drawing.Point(5, 5)
        Me.lblCurrentDay.Name = "lblCurrentDay"
        Me.lblCurrentDay.Size = New System.Drawing.Size(35, 13)
        Me.lblCurrentDay.TabIndex = 0
        Me.lblCurrentDay.Text = "Day 1"
        Me.ttpAverageUnitsByEmployee.SetToolTip(Me.lblCurrentDay, "The current day for entry.")
        '
        'lblEmpOne
        '
        Me.lblEmpOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpOne.Location = New System.Drawing.Point(5, 47)
        Me.lblEmpOne.Name = "lblEmpOne"
        Me.lblEmpOne.Size = New System.Drawing.Size(76, 13)
        Me.lblEmpOne.TabIndex = 3
        Me.lblEmpOne.Text = "Employee 1"
        Me.lblEmpOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpAverageUnitsByEmployee.SetToolTip(Me.lblEmpOne, "the first employee.")
        '
        'txtEmpOne
        '
        Me.txtEmpOne.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmpOne.Location = New System.Drawing.Point(5, 63)
        Me.txtEmpOne.Multiline = True
        Me.txtEmpOne.Name = "txtEmpOne"
        Me.txtEmpOne.ReadOnly = True
        Me.txtEmpOne.Size = New System.Drawing.Size(76, 97)
        Me.txtEmpOne.TabIndex = 4
        Me.txtEmpOne.TabStop = False
        Me.ttpAverageUnitsByEmployee.SetToolTip(Me.txtEmpOne, "A record of the units sold on each day for the first employee.")
        '
        'lblEmpTwo
        '
        Me.lblEmpTwo.Location = New System.Drawing.Point(87, 47)
        Me.lblEmpTwo.Name = "lblEmpTwo"
        Me.lblEmpTwo.Size = New System.Drawing.Size(76, 13)
        Me.lblEmpTwo.TabIndex = 6
        Me.lblEmpTwo.Text = "Employee 2"
        Me.lblEmpTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpAverageUnitsByEmployee.SetToolTip(Me.lblEmpTwo, "The second employee.")
        '
        'txtEmpTwo
        '
        Me.txtEmpTwo.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmpTwo.Location = New System.Drawing.Point(87, 63)
        Me.txtEmpTwo.Multiline = True
        Me.txtEmpTwo.Name = "txtEmpTwo"
        Me.txtEmpTwo.ReadOnly = True
        Me.txtEmpTwo.Size = New System.Drawing.Size(76, 97)
        Me.txtEmpTwo.TabIndex = 7
        Me.txtEmpTwo.TabStop = False
        Me.ttpAverageUnitsByEmployee.SetToolTip(Me.txtEmpTwo, "A record of the units sold on each day for the second employee.")
        '
        'lblEmpThree
        '
        Me.lblEmpThree.Location = New System.Drawing.Point(169, 47)
        Me.lblEmpThree.Name = "lblEmpThree"
        Me.lblEmpThree.Size = New System.Drawing.Size(76, 13)
        Me.lblEmpThree.TabIndex = 9
        Me.lblEmpThree.Text = "Employee 3"
        Me.lblEmpThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpAverageUnitsByEmployee.SetToolTip(Me.lblEmpThree, "The third employee.")
        '
        'txtEmpThree
        '
        Me.txtEmpThree.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmpThree.Location = New System.Drawing.Point(169, 63)
        Me.txtEmpThree.Multiline = True
        Me.txtEmpThree.Name = "txtEmpThree"
        Me.txtEmpThree.ReadOnly = True
        Me.txtEmpThree.Size = New System.Drawing.Size(76, 97)
        Me.txtEmpThree.TabIndex = 10
        Me.txtEmpThree.TabStop = False
        Me.ttpAverageUnitsByEmployee.SetToolTip(Me.txtEmpThree, "A record of the units sold on each day for the third employee.")
        '
        'lblAvgOne
        '
        Me.lblAvgOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvgOne.Location = New System.Drawing.Point(5, 163)
        Me.lblAvgOne.Name = "lblAvgOne"
        Me.lblAvgOne.Size = New System.Drawing.Size(76, 16)
        Me.lblAvgOne.TabIndex = 5
        Me.lblAvgOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpAverageUnitsByEmployee.SetToolTip(Me.lblAvgOne, "The average units shipped by the first employee.")
        '
        'lblAvgTwo
        '
        Me.lblAvgTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvgTwo.Location = New System.Drawing.Point(87, 163)
        Me.lblAvgTwo.Name = "lblAvgTwo"
        Me.lblAvgTwo.Size = New System.Drawing.Size(76, 16)
        Me.lblAvgTwo.TabIndex = 8
        Me.lblAvgTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpAverageUnitsByEmployee.SetToolTip(Me.lblAvgTwo, "The average units shipped by the second employee.")
        '
        'lblAvgThree
        '
        Me.lblAvgThree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvgThree.Location = New System.Drawing.Point(169, 163)
        Me.lblAvgThree.Name = "lblAvgThree"
        Me.lblAvgThree.Size = New System.Drawing.Size(76, 16)
        Me.lblAvgThree.TabIndex = 11
        Me.lblAvgThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpAverageUnitsByEmployee.SetToolTip(Me.lblAvgThree, "The average units shipped by the third employee.")
        '
        'lblAvgTotal
        '
        Me.lblAvgTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvgTotal.Location = New System.Drawing.Point(5, 184)
        Me.lblAvgTotal.Name = "lblAvgTotal"
        Me.lblAvgTotal.Size = New System.Drawing.Size(240, 15)
        Me.lblAvgTotal.TabIndex = 12
        Me.lblAvgTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpAverageUnitsByEmployee.SetToolTip(Me.lblAvgTotal, "The average units shipped by each employee.")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(5, 203)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(76, 23)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.ttpAverageUnitsByEmployee.SetToolTip(Me.btnEnter, "Enter the current day's units for the current employee.")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(87, 203)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(76, 23)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.ttpAverageUnitsByEmployee.SetToolTip(Me.btnReset, "Reset the application to its original state.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(169, 203)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(76, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.ttpAverageUnitsByEmployee.SetToolTip(Me.btnExit, "Close the application.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'AverageUnitsByEmployeeForm
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(250, 231)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblAvgTotal)
        Me.Controls.Add(Me.lblAvgThree)
        Me.Controls.Add(Me.lblAvgTwo)
        Me.Controls.Add(Me.lblAvgOne)
        Me.Controls.Add(Me.txtEmpThree)
        Me.Controls.Add(Me.lblEmpThree)
        Me.Controls.Add(Me.txtEmpTwo)
        Me.Controls.Add(Me.lblEmpTwo)
        Me.Controls.Add(Me.txtEmpOne)
        Me.Controls.Add(Me.lblEmpOne)
        Me.Controls.Add(Me.lblCurrentDay)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.lblUnits)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AverageUnitsByEmployeeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units by Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUnits As Label
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents lblCurrentDay As Label
    Friend WithEvents lblEmpOne As Label
    Friend WithEvents txtEmpOne As TextBox
    Friend WithEvents lblEmpTwo As Label
    Friend WithEvents txtEmpTwo As TextBox
    Friend WithEvents lblEmpThree As Label
    Friend WithEvents txtEmpThree As TextBox
    Friend WithEvents lblAvgOne As Label
    Friend WithEvents lblAvgTwo As Label
    Friend WithEvents lblAvgThree As Label
    Friend WithEvents lblAvgTotal As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ttpAverageUnitsByEmployee As ToolTip
End Class
