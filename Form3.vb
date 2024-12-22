Public Class Form3

    ' Size and drink cost variables
    Private sizeCost As Decimal = 0
    Private drinkCost As Decimal = 0

    ' Reference to Form1
    Private CurrentItem As Form1

    ' Constructor to receive the selected item from Form1
    Public Sub New(selectedItem As Form1)
        InitializeComponent()
        CurrentItem = selectedItem
    End Sub

    ' Handle size checkbox change (Allow only one size to be selected)
    Private Sub Size_CheckedChanged(sender As Object, e As EventArgs) Handles SmallCheckBox.CheckedChanged, MediumCheckBox.CheckedChanged, LargeCheckBox.CheckedChanged
        ' Reset size cost
        sizeCost = 0

        ' Check which size is selected and update the cost accordingly
        If SmallCheckBox.Checked Then
            sizeCost = 30D
            MediumCheckBox.Checked = False
            LargeCheckBox.Checked = False
        ElseIf MediumCheckBox.Checked Then
            sizeCost = 40D
            SmallCheckBox.Checked = False
            LargeCheckBox.Checked = False
        ElseIf LargeCheckBox.Checked Then
            sizeCost = 50D
            SmallCheckBox.Checked = False
            MediumCheckBox.Checked = False
        End If
    End Sub

    ' Handle NumericUpDown value changes for drinks
    Private Sub Drink_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownWater.ValueChanged, NumericUpDownCoke.ValueChanged, NumericUpDownRoyal.ValueChanged
        ' Reset drink cost
        drinkCost = 0

        ' Add the cost of selected drinks based on their quantities
        drinkCost += NumericUpDownWater.Value * 15D
        drinkCost += NumericUpDownCoke.Value * 25D
        drinkCost += NumericUpDownRoyal.Value * 20D
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles AddToOrderButton.Click
        ' Determine selected size
        Dim size As String = "None"
        If SmallCheckBox.Checked Then
            size = "Small"
        ElseIf MediumCheckBox.Checked Then
            size = "Medium"
        ElseIf LargeCheckBox.Checked Then
            size = "Large"
        End If

        ' Ensure that a size is selected
        If size = "None" Then
            MessageBox.Show("Please select a size.", "Selection Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Prepare the drink summary (include only drinks with quantities > 0)
        Dim drinkSummary As New List(Of String)()

        If NumericUpDownWater.Value > 0 Then
            drinkSummary.Add($"Water x{NumericUpDownWater.Value}")
        End If
        If NumericUpDownCoke.Value > 0 Then
            drinkSummary.Add($"Coke x{NumericUpDownCoke.Value}")
        End If
        If NumericUpDownRoyal.Value > 0 Then
            drinkSummary.Add($"Royal x{NumericUpDownRoyal.Value}")
        End If

        ' Ensure that at least one drink is selected
        If drinkSummary.Count = 0 Then
            MessageBox.Show("Please select at least one drink.", "Selection Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Update Form1 with the selected size, drink summary, and their prices
        CurrentItem.UpdateSummaryFromForm3(size, String.Join(", ", drinkSummary))

        ' Close Form3 after updating
        Me.Close()
    End Sub

End Class
