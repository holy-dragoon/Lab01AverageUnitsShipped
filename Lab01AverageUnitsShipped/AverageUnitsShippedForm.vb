'@name: Lab 01 : Averaging Shipped Units'
'description: Form to receive a the number of units shipped per day'
' and output the average units shipped per week. The form can be reset or the application can be quit.'
'@author: Shaun McCrum'
'@since: 5 May 2019'
Option Strict On
Public Class AverageUnitsShippedForm

#Region "DECLARATIONS"
    Public Const DAYS_OF_THE_WEEK As Integer = 7    'days in a week based the first day being day 1'
    Public Const MINIMUM_UNIT As Integer = 0        'minimum value that can be entered'
    Public Const MAXIMUM_UNIT As Integer = 1000     'minimum value that can be entered'
    'dayCounter used as an array index counter. Alternatively add 1 to this value when output requires Day Number. '
    Dim dayCounter As Integer = 0
    Dim dayUnitsArray(dayCounter) As Integer        'array to hold integers the user inputs.'
    Dim averageUnits As Double = 0                  'holds final average calculation'
    Dim sumUnits As Integer = 0                     'incrememting sum value when input is entered'
#End Region

#Region "FORM & CONTROLS"
    ''' <summary>
    ''' AverageUnitsShippedForm_Load handles properties and settings defined when the form loads
    ''' </summary>
    Private Sub AverageUnitsShippedForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserInput.Select()   'select the txtUserInput textbox'
    End Sub

    ''' <summary>
    ''' btnExit_Click Exits the application
    ''' </summary>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()      'exit the application'
    End Sub

    ''' <summary>
    ''' btnEnter_Click performs adds values to an array if they are valid and performs average calculations
    ''' </summary>
    Public Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ReDim dayUnitsArray(dayCounter)     'redifne the size of the array to the dayCounter variable.
        If IsNumeric(txtUserInput.Text) Then    'if the user input is a number value'
            'If text string value can be parsed as an Integer, it is a whole number and will be added userInput to the array'
            If Integer.TryParse(txtUserInput.Text, dayUnitsArray(dayCounter)) Then
                'if the user input falls within range'
                If dayUnitsArray(dayCounter) >= MINIMUM_UNIT And dayUnitsArray(dayCounter) <= MAXIMUM_UNIT Then
                    txtDayUnits.Text += dayUnitsArray(dayCounter).ToString & vbCrLf     'add the value '
                    sumUnits += dayUnitsArray(dayCounter)   'add the current value of the array to the sum'

                    'Debug.WriteLine added as an alternate method to see values at specific stages in the code.'
                    Debug.WriteLine("array length " & dayUnitsArray.Length)
                    Debug.WriteLine("current arrayIndex value " & dayUnitsArray(dayCounter).ToString)
                    Debug.WriteLine("current sum " & sumUnits.ToString)

                    averageUnits = (sumUnits / dayUnitsArray.Count)     'calculate the average based on the size of the array'
                    Debug.WriteLine("current index counter " & dayCounter.ToString & vbCrLf)
                    lblResult.Text = "Average per day: " & Math.Round(averageUnits, 2).ToString     'output the result and format to two decimal places'
                    'If the dayCounter() is greater than or equal to the '
                    'DAYS_OF_THE_WEEK less one to account for a possible indexOutOfRange error'
                    If (dayCounter >= DAYS_OF_THE_WEEK - 1) Then
                        txtUserInput.ReadOnly = True    'Disable user input'
                        btnEnter.Enabled = False        'Disable processing more input'
                        btnReset.Select()               'change the highlighted button'
                        ActiveForm.AcceptButton = btnReset 'change the Accept button to reset the form'
                    Else    'increment the day counter and the form'
                        dayCounter += 1
                        lblDayNumber.Text = "Day: " & (dayCounter + 1).ToString
                        ReDim dayUnitsArray(dayCounter) 'redefine the arraysize to the current counter'
                    End If
                    'clear the user input and set the cursor to txtUserInput'
                    txtUserInput.Clear()
                    txtUserInput.Select()
                Else    'Out of range numbers were entered into the form'
                    lblResult.Text = "Unit number is out of range."
                    txtUserInput.SelectAll()    'select all text for easy replacement of input'
                End If
            Else
                lblResult.Text = "Unit number is not a whole number."
                txtUserInput.SelectAll()    'select all text for easy replacement of input'
            End If
        Else    'Text was entered into the form'
            lblResult.Text = "Text entries are invalid."
            txtUserInput.SelectAll()    'select all text for easy replacement of input'
        End If
    End Sub

    ''' <summary>
    ''' btnReset_Click handles clearing the form if Reset button is pressed
    ''' </summary>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearForm()     'call subroutine to clear form'
    End Sub
#End Region

#Region "SUBROUTINES AND FUNCTIONS"
    ''' <summary>
    ''' ClearForm subroutine empties out all inputs and resets the form to default states.
    ''' </summary>
    Private Sub ClearForm()
        txtDayUnits.Clear()             'clear the text boxes'
        txtUserInput.Clear()
        btnEnter.Enabled = True         'Enable enter button'
        txtUserInput.ReadOnly = False   'Enable user input'
        txtUserInput.Select()           'set the cursor to the user input'
        ActiveForm.AcceptButton = btnEnter  'change the accept button back to default state'
        lblResult.Text = ""             'reset the labels'
        lblDayNumber.Text = "Day: 1"
        Erase dayUnitsArray     'release array elements. see https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/statements/erase-statement'
        'Conditional statements to reset day counter, sum and average variables'
        If dayCounter > 0 Then dayCounter = 0
        If sumUnits > 0 Then sumUnits = 0
        If averageUnits > 0 Then averageUnits = 0
    End Sub
#End Region

End Class
