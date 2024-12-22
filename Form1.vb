Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.IO
Public Class Form1
    Private connectionString As String = "Server=localhost;Database=burgeru_db;Uid=root;Pwd=;"

    ' Prices for each item
    Private prices As New Dictionary(Of String, Decimal) From {
        {"Burger", 50},
        {"CheeseBurger", 59},
        {"BeefBurger", 69},
        {"DoublePatty", 79},
        {"HotCheese", 79},
        {"SpicyBurger", 79},
        {"Sisig", 119},
        {"PorkGravy", 147},
        {"SizzlingChix", 157},
        {"PorkSweets", 169},
        {"Beefsteak", 195},
        {"BeefTeppanyaki", 199}
    }

    ' Prices for size and drinks
    Private sizePrices As New Dictionary(Of String, Decimal) From {
        {"Small", 30D},
        {"Medium", 40D},
        {"Large", 50D}
    }

    Private drinkPrices As New Dictionary(Of String, Decimal) From {
        {"Water", 15D},
        {"Coke", 25D},
        {"Royal", 20D}
    }
    ' Add this list to store the dynamic drink summary
    Private drinkSelections As New List(Of String)()

    Private Sub UpdateOrderSummary()
        Dim summary As String = "Order Summary:" & Environment.NewLine
        Dim total As Decimal = 0

        ' Add food items to summary (only if they are greater than zero)
        If nudBurger.Value > 0 Then
            Dim itemTotal = nudBurger.Value * prices("Burger")
            summary &= $"Burger: {nudBurger.Value} x {prices("Burger"):C} = {itemTotal:C}" & Environment.NewLine
            total += itemTotal
        End If

        If nudCheeseBurger.Value > 0 Then
            Dim itemTotal = nudCheeseBurger.Value * prices("CheeseBurger")
            summary &= $"CheeseBurger: {nudCheeseBurger.Value} x {prices("CheeseBurger"):C} = {itemTotal:C}" & Environment.NewLine
            total += itemTotal
        End If

        If nudBeefBurger.Value > 0 Then
            Dim itemTotal = nudBeefBurger.Value * prices("BeefBurger")
            summary &= $"BeefBurger: {nudBeefBurger.Value} x {prices("BeefBurger"):C} = {itemTotal:C}" & Environment.NewLine
            total += itemTotal
        End If

        If nudDoublePatty.Value > 0 Then
            Dim itemTotal = nudDoublePatty.Value * prices("DoublePatty")
            summary &= $"DoublePatty: {nudDoublePatty.Value} x {prices("DoublePatty"):C} = {itemTotal:C}" & Environment.NewLine
            total += itemTotal
        End If

        If nudHotCheese.Value > 0 Then
            Dim itemTotal = nudHotCheese.Value * prices("HotCheese")
            summary &= $"HotCheese: {nudHotCheese.Value} x {prices("HotCheese"):C} = {itemTotal:C}" & Environment.NewLine
            total += itemTotal
        End If

        If nudSpicyburger.Value > 0 Then
            Dim itemTotal = nudSpicyburger.Value * prices("SpicyBurger")
            summary &= $"SpicyBurger: {nudSpicyburger.Value} x {prices("SpicyBurger"):C} = {itemTotal:C}" & Environment.NewLine
            total += itemTotal
        End If

        If nudSisig.Value > 0 Then
            Dim itemTotal = nudSisig.Value * prices("Sisig")
            summary &= $"Sisig: {nudSisig.Value} x {prices("Sisig"):C} = {itemTotal:C}" & Environment.NewLine
            total += itemTotal
        End If

        If nudPorkGravy.Value > 0 Then
            Dim itemTotal = nudPorkGravy.Value * prices("PorkGravy")
            summary &= $"PorkGravy: {nudPorkGravy.Value} x {prices("PorkGravy"):C} = {itemTotal:C}" & Environment.NewLine
            total += itemTotal
        End If

        If nudSizzlingChix.Value > 0 Then
            Dim itemTotal = nudSizzlingChix.Value * prices("SizzlingChix")
            summary &= $"SizzlingChix: {nudSizzlingChix.Value} x {prices("SizzlingChix"):C} = {itemTotal:C}" & Environment.NewLine
            total += itemTotal
        End If

        If nudPorkSweets.Value > 0 Then
            Dim itemTotal = nudPorkSweets.Value * prices("PorkSweets")
            summary &= $"PorkSweets: {nudPorkSweets.Value} x {prices("PorkSweets"):C} = {itemTotal:C}" & Environment.NewLine
            total += itemTotal
        End If

        If nudBeefsteak.Value > 0 Then
            Dim itemTotal = nudBeefsteak.Value * prices("Beefsteak")
            summary &= $"Beefsteak: {nudBeefsteak.Value} x {prices("Beefsteak"):C} = {itemTotal:C}" & Environment.NewLine
            total += itemTotal
        End If

        If nudBeefTeppanyaki.Value > 0 Then
            Dim itemTotal = nudBeefTeppanyaki.Value * prices("BeefTeppanyaki")
            summary &= $"BeefTeppanyaki: {nudBeefTeppanyaki.Value} x {prices("BeefTeppanyaki"):C} = {itemTotal:C}" & Environment.NewLine
            total += itemTotal
        End If

        ' ... (Repeat for other items)

        ' Add size and dynamic drinks to the summary from drinkSelections
        summary &= $"Size: {txtSize.Text}" & Environment.NewLine

        ' Combine the drinks from the dynamic list (drinkSelections)
        Dim drinkSummary As String = String.Join(", ", drinkSelections)

        If String.IsNullOrWhiteSpace(drinkSummary) Then
            summary &= "No drinks selected." & Environment.NewLine
        Else
            summary &= $"Drink(s): {drinkSummary}" & Environment.NewLine
        End If

        ' Update size and drink cost
        Dim sizeCost As Decimal = 0
        Dim drinkCost As Decimal = 0

        ' Handle size cost
        If txtSize.Text = "Small" Then
            sizeCost = 30D
        ElseIf txtSize.Text = "Medium" Then
            sizeCost = 40D
        ElseIf txtSize.Text = "Large" Then
            sizeCost = 50D
        End If

        ' Handle drink cost
        For Each drink In drinkSelections
            If drink.Contains("Water") Then
                drinkCost += 15D
            ElseIf drink.Contains("Coke") Then
                drinkCost += 25D
            ElseIf drink.Contains("Royal") Then
                drinkCost += 20D
            End If
        Next

        ' Add size and drink cost to total
        total += sizeCost + drinkCost

        ' Append size and drink costs to the summary
        summary &= $"Size Price: {sizeCost:C}, Drink Price: {drinkCost:C}" & Environment.NewLine
        summary &= $"Total: {total:C}" & Environment.NewLine

        ' Update the RichTextBox and Total amount
        RichTextBox1.Text = summary
        txtTotal.Text = total.ToString("F2")
    End Sub





    ' Button to go to Form3 (Size and Drink Selection)
    Private Sub btnSelectSizeAndDrink_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Clear previous drink selections when opening the size and drink form
        drinkSelections.Clear()

        ' Create Form3 and show it as a modal
        Dim nextForm As New Form3(Me)
        nextForm.ShowDialog() ' Use ShowDialog instead of Show
    End Sub


    Public Sub UpdateSummaryFromForm3(size As String, drink As String)
        ' Update size
        txtSize.Text = size

        ' Append the new drink(s) to the drinkSelections list
        If Not String.IsNullOrWhiteSpace(drink) Then
            drinkSelections.AddRange(drink.Split(","c)) ' Add each drink to the list
        End If

        ' Update the drink list display (txtDrink.Text)
        txtDrink.Text = String.Join(", ", drinkSelections) ' Join the drinks with commas and display

        ' Now call the method to update the entire summary (including prices)
        UpdateOrderSummary()
    End Sub





    ' Compute Change
    Private Sub btnComputeChange_Click(sender As Object, e As EventArgs) Handles btnComputeChange.Click
        Dim receivedMoney As Decimal
        Dim totalAmount As Decimal
        Dim change As Decimal

        If Decimal.TryParse(txtReceiveMoney.Text, receivedMoney) AndAlso Decimal.TryParse(txtTotal.Text, totalAmount) Then
            change = receivedMoney - totalAmount
            txtChange.Text = change.ToString("F2")
        Else
            MessageBox.Show("Please enter valid numbers for Received Money and Total.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub OpenForm3ForProduct(sender As Object, e As EventArgs) _
    Handles Button2.Click, Button3.Click, Button4.Click, Button5.Click,
            Button6.Click, Button7.Click, Button8.Click, Button9.Click,
            Button10.Click, Button11.Click, Button12.Click
        Dim nextForm As New Form3(Me)
        nextForm.ShowDialog()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        ' Reset all numeric up-down controls to 0
        nudBurger.Value = 0
        nudCheeseBurger.Value = 0
        nudBeefBurger.Value = 0
        nudDoublePatty.Value = 0
        nudHotCheese.Value = 0
        nudSpicyburger.Value = 0
        nudSisig.Value = 0
        nudPorkGravy.Value = 0
        nudSizzlingChix.Value = 0
        nudPorkSweets.Value = 0
        nudBeefsteak.Value = 0
        nudBeefTeppanyaki.Value = 0

        ' Reset drink selections
        drinkSelections.Clear()
        txtDrink.Text = String.Empty

        ' Reset size selection
        txtSize.Text = String.Empty

        ' Clear the order summary
        RichTextBox1.Text = String.Empty

        ' Reset total and change
        txtTotal.Text = "0.00"
        txtReceiveMoney.Text = String.Empty
        txtChange.Text = String.Empty

        ' Provide feedback to the user
        MessageBox.Show("The order has been reset. You can start a new order.", "Order Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Dim burgerQuantity As Integer = Convert.ToInt32(nudBurger.Value) ' Assuming you use a NumericUpDown for quantity

        ' Check if the quantity is greater than 0
        If burgerQuantity > 0 Then
            ' Update stock in database
            UpdateStock("Burger", burgerQuantity)
        End If

        Dim cheeseBurgerQuantity As Integer = Convert.ToInt32(nudCheeseBurger.Value)
        If cheeseBurgerQuantity > 0 Then
            UpdateStock("CheeseBurger", cheeseBurgerQuantity)
        End If

        ' Example for BeefBurger order
        Dim beefBurgerQuantity As Integer = Convert.ToInt32(nudBeefBurger.Value)
        If beefBurgerQuantity > 0 Then
            UpdateStock("BeefBurger", beefBurgerQuantity)
        End If

        ' Example for DoublePatty order
        Dim doublePattyQuantity As Integer = Convert.ToInt32(nudDoublePatty.Value)
        If doublePattyQuantity > 0 Then
            UpdateStock("DoublePatty", doublePattyQuantity)
        End If

        ' Example for HotCheese order
        Dim hotCheeseQuantity As Integer = Convert.ToInt32(nudHotCheese.Value)
        If hotCheeseQuantity > 0 Then
            UpdateStock("HotCheese", hotCheeseQuantity)
        End If

        ' Example for SpicyBurger order
        Dim spicyBurgerQuantity As Integer = Convert.ToInt32(nudSpicyburger.Value)
        If spicyBurgerQuantity > 0 Then
            UpdateStock("SpicyBurger", spicyBurgerQuantity)
        End If

        ' Example for Sisig order
        Dim sisigQuantity As Integer = Convert.ToInt32(nudSisig.Value)
        If sisigQuantity > 0 Then
            UpdateStock("Sisig", sisigQuantity)
        End If

        ' Example for PorkGravy order
        Dim porkGravyQuantity As Integer = Convert.ToInt32(nudPorkGravy.Value)
        If porkGravyQuantity > 0 Then
            UpdateStock("PorkGravy", porkGravyQuantity)
        End If

        ' Example for SizzlingChix order
        Dim sizzlingChixQuantity As Integer = Convert.ToInt32(nudSizzlingChix.Value)
        If sizzlingChixQuantity > 0 Then
            UpdateStock("SizzlingChix", sizzlingChixQuantity)
        End If

        ' Example for PorkSweets order
        Dim porkSweetsQuantity As Integer = Convert.ToInt32(nudPorkSweets.Value)
        If porkSweetsQuantity > 0 Then
            UpdateStock("PorkSweets", porkSweetsQuantity)
        End If

        ' Example for Beefsteak order
        Dim beefsteakQuantity As Integer = Convert.ToInt32(nudBeefsteak.Value)
        If beefsteakQuantity > 0 Then
            UpdateStock("Beefsteak", beefsteakQuantity)
        End If

        ' Example for BeefTeppanyaki order
        Dim beefTeppanyakiQuantity As Integer = Convert.ToInt32(nudBeefTeppanyaki.Value)
        If beefTeppanyakiQuantity > 0 Then
            UpdateStock("BeefTeppanyaki", beefTeppanyakiQuantity)
        End If
        ' Display receipt
        Dim receipt As String = "==== RECEIPT ====" & Environment.NewLine
        receipt &= RichTextBox1.Text & Environment.NewLine
        receipt &= "-------------------" & Environment.NewLine
        receipt &= $"Total Amount: {txtTotal.Text:C}" & Environment.NewLine
        receipt &= $"Received Money: {txtReceiveMoney.Text:C}" & Environment.NewLine
        receipt &= $"Change: {txtChange.Text:C}" & Environment.NewLine
        If radDineIn.Checked Then
            receipt &= "Service Type: Dine-in" & Environment.NewLine
        ElseIf radTakeOut.Checked Then
            receipt &= "Service Type: Take-out" & Environment.NewLine
        End If
        receipt &= "===================" & Environment.NewLine
        receipt &= "Thank you for your order!" & Environment.NewLine
        receipt &= "Visit us again!" & Environment.NewLine
        MessageBox.Show(receipt, "Order Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Insert into database
        Try
            Dim customerName As String = txtCustomerName.Text ' Assuming you have a textbox for customer name
            Dim food As String = RichTextBox1.Text.Split(":"c)(1).Trim() ' Example of parsing food summary
            Dim drinks As String = txtDrink.Text
            Dim size As String = txtSize.Text
            Dim orderDate As Date = DateTime.Now
            Dim total As Decimal = Decimal.Parse(txtTotal.Text)
            Dim receiveMoney As Decimal = Decimal.Parse(txtReceiveMoney.Text)
            Dim changeAmount As Decimal = Decimal.Parse(txtChange.Text)

            ' Call InsertOrder method
            InsertOrder(customerName, food, drinks, size, orderDate, total, receiveMoney, changeAmount)
        Catch ex As Exception
            MessageBox.Show("Error processing order: " & ex.Message, "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
    Private Sub rbDineIn_CheckedChanged(sender As Object, e As EventArgs) Handles radDineIn.CheckedChanged
        If radDineIn.Checked Then
            UpdateOrderSummary("Dine-in")
        End If
    End Sub

    Private Sub rbTakeOut_CheckedChanged(sender As Object, e As EventArgs) Handles radTakeOut.CheckedChanged
        If radTakeOut.Checked Then
            UpdateOrderSummary("Take-out")
        End If
    End Sub

    Private Sub UpdateOrderSummary(serviceType As String)
        ' Assuming your RichTextBox is named rtbOrderSummary
        Dim currentText As String = RichTextBox1.Text

        ' Find and replace the line that starts with "Service Type:"
        Dim newSummary As String = ""
        Dim lines = currentText.Split(Environment.NewLine)
        Dim serviceTypeUpdated = False

        For Each line In lines
            If line.StartsWith("Service Type:") Then
                newSummary &= "Service Type: " & serviceType & Environment.NewLine
                serviceTypeUpdated = True
            Else
                newSummary &= line & Environment.NewLine
            End If
        Next

        ' If the "Service Type:" line wasn't found, append it to the summary
        If Not serviceTypeUpdated Then
            newSummary &= "Service Type: " & serviceType & Environment.NewLine
        End If

        RichTextBox1.Text = newSummary.Trim()
    End Sub



    Public Sub InsertOrder(name As String, food As String, drinks As String, size As String, orderDate As Date, total As Decimal, receiveMoney As Decimal, changeAmount As Decimal)
        Dim query As String = "INSERT INTO orders (name, food, drinks, sizes, order_date, total, receive_money, change_amount) " &
                              "VALUES (@name, @food, @drinks, @sizes, @orderDate, @total, @receiveMoney, @changeAmount)"
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@food", food)
                    cmd.Parameters.AddWithValue("@drinks", drinks)
                    cmd.Parameters.AddWithValue("@sizes", size)
                    cmd.Parameters.AddWithValue("@orderDate", orderDate)
                    cmd.Parameters.AddWithValue("@total", total)
                    cmd.Parameters.AddWithValue("@receiveMoney", receiveMoney)
                    cmd.Parameters.AddWithValue("@changeAmount", changeAmount)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Order successfully added to the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error inserting data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub FetchOrders()
        Dim query As String = "SELECT * FROM orders"
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using cmd As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Console.WriteLine("Name: " & reader("name").ToString())
                            Console.WriteLine("Food: " & reader("food").ToString())
                            Console.WriteLine("Drinks: " & reader("drinks").ToString())
                            Console.WriteLine("Size: " & reader("sizes").ToString())
                            Console.WriteLine("Date: " & reader("order_date").ToString())
                            Console.WriteLine("Total: " & reader("total").ToString())
                            Console.WriteLine("Received: " & reader("receive_money").ToString())
                            Console.WriteLine("Change: " & reader("change_amount").ToString())
                            Console.WriteLine("---------------------")
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateStock(productName As String, quantity As Integer)
        ' Check if there is enough stock before updating
        Dim query As String = "SELECT stock_quantity FROM inventory WHERE product_name = @productName"
        Dim currentStock As Integer

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@productName", productName)
                    currentStock = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using

            ' Ensure there's enough stock
            If currentStock >= quantity Then
                ' Update stock by subtracting the ordered quantity
                Dim updateQuery As String = "UPDATE inventory SET stock_quantity = stock_quantity - @quantity WHERE product_name = @productName"
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    Using cmd As New MySqlCommand(updateQuery, connection)
                        cmd.Parameters.AddWithValue("@productName", productName)
                        cmd.Parameters.AddWithValue("@quantity", quantity)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Stock updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Not enough stock available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating stock: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btninv_Click(sender As Object, e As EventArgs) Handles btninv.Click
        Dim inventoryForm As New Form4() ' Create an instance of Form4
        inventoryForm.Show() ' Show the form
    End Sub

End Class