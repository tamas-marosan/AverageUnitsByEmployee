Option Strict On
Public Class AverageUnitsByEmployeeForm
    ' Define constants to be used by the application
    Private Const lastEmpIndex As Integer = 2
    Private Const lastDayIndex As Integer = 6
    Private Const indexReset As Integer = 0
    Private Const indexStep As Integer = 1

    ' Define units as an integer to store how many units the user entered
    Private units As Integer

    ' Create a variable for the employee index
    Private empIndex As Integer = indexReset

    Private empUnits(lastEmpIndex, lastDayIndex) As Integer

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' Define an index for the current day
        Static Dim dayIndex As Integer = indexReset

        ' Define arrays for textboxes and labels
        Static Dim empTextBoxArray() As Control = {txtEmpOne, txtEmpTwo, txtEmpThree}
        Static Dim empLabelArray() As Control = {lblEmpOne, lblEmpTwo, lblEmpThree}
        Static Dim empLabelAverageArray() As Control = {lblAvgOne, lblAvgTwo, lblAvgThree}

        ' If the input textbox is valid then...
        If TryValidEntry(txtUnits) Then

            empUnits(empIndex, dayIndex) = units                 ' Set the current emp,day array index value with the input
            empTextBoxArray(empIndex).Text += $"{units}{vbCrLf}" ' Add the input to that employee's sales box

            txtUnits.ResetText()                                 ' Clear the input field
            txtUnits.Focus()                                     ' Focus the input field

            dayIndex += indexStep                                ' Move onto the next day
            lblCurrentDay.Text = $"Day {dayIndex + indexStep}"   ' Update the current day label

            ' If the current employee has 7 days worth of information already then
            If dayIndex > lastDayIndex Then
                ' Set the employee's average label using EmployeeAverage(), and round to 2 decimal points
                empLabelAverageArray(empIndex).Text = EmployeeAverage(empIndex).ToString("n2")

                dayIndex = indexReset ' Reset the day index to 0
                empIndex += indexStep ' Increment the employee index

                ' Make the font of the previous employee normal
                empLabelArray(empIndex - indexStep).Font = New Font(empLabelArray(empIndex - indexStep).Font, FontStyle.Regular)

                ' If the current employee exists, make it's label bold
                If Not empIndex > lastEmpIndex Then empLabelArray(empIndex).Font = New Font(empLabelArray(empIndex).Font, FontStyle.Bold)

                ' Reset the label for the current day
                lblCurrentDay.Text = $"Day {dayIndex + indexStep}"
            End If

            ' If the last employee has been processed
            If empIndex > lastEmpIndex Then
                ' Set the overall average label using TotalAverage(), and round to 2 decimal points
                lblAvgTotal.Text = TotalAverage().ToString("n2")

                lblCurrentDay.Text = "Done" ' Change the current day label to say "Done"

                txtUnits.Enabled = False ' Disable the input textbox
                btnEnter.Enabled = False ' Disable the Enter button
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm() ' Call ResetForm()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Exit the application
    End Sub

    Private Function TryValidEntry(ByVal entryTextbox As TextBox) As Boolean
        Const rangeMinimum As Integer = 0    ' Define a constant for the minimum value (0)
        Const rangeMaximum As Integer = 1000 ' Define a constant for the maximum value (1000)

        Dim isValid = False ' Define a boolean to use as the return value (initialize to false, if the input is valid, set to true)

        If entryTextbox.Text = String.Empty Then ' Show a message box if the input is empty
            MessageBox.Show($"Units cannot be empty!", "Empty Input")
            txtUnits.Focus()
        ElseIf Not Integer.TryParse(entryTextbox.Text, units) Then ' Show a message box if the input is not an integer
            MessageBox.Show($"Units must be a whole number!", "Invalid Input")
            txtUnits.Focus()
            txtUnits.SelectAll()
        ElseIf units < rangeMinimum Or units > rangeMaximum Then ' Show a message box if the input isn't in range
            MessageBox.Show($"Units must be between {rangeMinimum} and {rangeMaximum}!", "Out of Range")
            txtUnits.Focus()
            txtUnits.SelectAll()
        Else
            isValid = True ' If input is valid, change the boolean variable to true
        End If

        Return isValid ' Return the boolean
    End Function

    Private Function EmployeeAverage(empIndex As Integer) As Double
        Dim averageEmp As Double = 0.0 ' Define the employees average as a double

        ' For each day of the array, add the current value/7 to the average variable
        For indexDay As Integer = 0 To lastDayIndex
            averageEmp += empUnits(empIndex, indexDay) / (lastDayIndex + 1)
        Next

        Return averageEmp ' Return the average
    End Function

    Private Function TotalAverage() As Double
        Dim averageAll As Double = 0.0 ' Define the average of all inputs as a double

        ' For each day for each employee in the array, add the current value/21
        For indexEmp As Integer = indexReset To lastEmpIndex
            For indexDay As Integer = indexReset To lastDayIndex
                averageAll += empUnits(indexEmp, indexDay) / empUnits.Length
            Next
        Next

        Return averageAll ' Return the total average
    End Function

    Private Sub ResetForm()
        For Each formObject As Object In Me.Controls ' Search through all objects in the form
            If TypeOf (formObject) Is TextBox Then ' If the object is a textbox
                CType(formObject, TextBox).ResetText() ' Reset the textbox's text
                CType(formObject, TextBox).Enabled = True ' Enable the textbox
            ElseIf TypeOf (formObject) Is Label AndAlso CType(formObject, Label).BorderStyle = BorderStyle.Fixed3D Then ' If the object is a label with a Fixed3D border
                CType(formObject, Label).ResetText() ' Reset the label's text
            End If
        Next ' Move onto the next object
        empIndex = indexReset ' Reset the empIndex
        btnEnter.Enabled = True ' Enable the calculate button
        lblEmpOne.Font = New Font(lblEmpOne.Font, FontStyle.Bold) ' Set Employee 1's label to bold
        txtUnits.Focus() ' Set the focus to the first textbox
    End Sub
End Class