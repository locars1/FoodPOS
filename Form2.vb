Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Services
Imports Google.Apis.Sheets.v4
Imports Google.Apis.Sheets.v4.Data
Imports System.IO

Public Class Form2
    ' Variables to hold the stock count for each item
    Dim burgerStock As Integer = 50
    Dim cheeseBurgerStock As Integer = 50
    Dim beefBurgerStock As Integer = 50
    Dim doublePattyStock As Integer = 50
    Dim hotCheeseStock As Integer = 50
    Dim spicyBurgerStock As Integer = 50

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateStockDisplay()
    End Sub

    ' Method to update the stock display
    Private Sub UpdateStockDisplay()
        txtBurgerStock.Text = burgerStock.ToString()
        txtCheeseBurgerStock.Text = cheeseBurgerStock.ToString()
        txtBeefBurgerStock.Text = beefBurgerStock.ToString()
        txtDoublePattyStock.Text = doublePattyStock.ToString()
        txtHotCheeseStock.Text = hotCheeseStock.ToString()
        txtSpicyBurgerStock.Text = spicyBurgerStock.ToString()
    End Sub

    ' Method to update stock counts in Google Sheets
    Private Sub UpdateStockInGoogleSheets()
        Try
            ' Load the service account credentials from the JSON file
            Dim credential As GoogleCredential
            Using stream = New FileStream("C:\Users\Acer\Downloads\polished-parser-440612-b5-0b84eb45b14c.json", FileMode.Open, FileAccess.Read)
                credential = GoogleCredential.FromStream(stream).CreateScoped(SheetsService.Scope.Spreadsheets)
            End Using

            ' Create the Sheets API service
            Dim service As New SheetsService(New BaseClientService.Initializer() With {
            .HttpClientInitializer = credential,
            .ApplicationName = "DatabasePOS"
        })

            ' Specify the ID of your Google Sheet and the range where you want to update stock data
            Dim spreadsheetId As String = "1rX0NrOZxRRJm1hMg0VJCrvn4HctLh-I_ykEh8h_0Dfk"
            Dim range As String = "Sheet1!H2:M2" ' Adjust the range as needed

            ' Prepare the data to update
            Dim values As New List(Of IList(Of Object)) From {
            New List(Of Object) From {
                burgerStock,
                cheeseBurgerStock,
                beefBurgerStock,
                doublePattyStock,
                hotCheeseStock,
                spicyBurgerStock
            }
        }

            Dim body As New ValueRange() With {
            .Values = values
        }

            ' Update the data in the specified range
            Dim request As SpreadsheetsResource.ValuesResource.UpdateRequest = service.Spreadsheets.Values.Update(body, spreadsheetId, range)
            request.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.USERENTERED
            Dim response As UpdateValuesResponse = request.Execute()


        Catch ex As Exception
            ' Display error message for troubleshooting
            MessageBox.Show("Error updating stock in Google Sheets: " & ex.Message)
        End Try
    End Sub
    Public Sub DeductStock(burger As Integer, cheeseBurger As Integer, beefBurger As Integer, doublePatty As Integer, hotCheese As Integer, spicyBurger As Integer)
        burgerStock -= burger
        cheeseBurgerStock -= cheeseBurger
        beefBurgerStock -= beefBurger
        doublePattyStock -= doublePatty
        hotCheeseStock -= hotCheese
        spicyBurgerStock -= spicyBurger

        ' Ensure stock doesn’t go below zero
        If burgerStock < 0 Then burgerStock = 0
        If cheeseBurgerStock < 0 Then cheeseBurgerStock = 0
        If beefBurgerStock < 0 Then beefBurgerStock = 0
        If doublePattyStock < 0 Then doublePattyStock = 0
        If hotCheeseStock < 0 Then hotCheeseStock = 0
        If spicyBurgerStock < 0 Then spicyBurgerStock = 0

        UpdateStockDisplay()
        UpdateStockInGoogleSheets()
    End Sub


    ' Event handler for each "+" button to increase stock
    Private Sub btnBurgerAdd_Click(sender As Object, e As EventArgs) Handles btnBurgerAdd.Click
        burgerStock += 1
        UpdateStockDisplay()
        UpdateStockInGoogleSheets()
    End Sub

    Private Sub btnCheeseBurgerAdd_Click(sender As Object, e As EventArgs) Handles btnCheeseBurgerAdd.Click
        cheeseBurgerStock += 1
        UpdateStockDisplay()
        UpdateStockInGoogleSheets()
    End Sub

    Private Sub btnBeefBurgerAdd_Click(sender As Object, e As EventArgs) Handles btnBeefBurgerAdd.Click
        beefBurgerStock += 1
        UpdateStockDisplay()
        UpdateStockInGoogleSheets()
    End Sub

    Private Sub btnDoublePattyAdd_Click(sender As Object, e As EventArgs) Handles btnDoublePattyAdd.Click
        doublePattyStock += 1
        UpdateStockDisplay()
        UpdateStockInGoogleSheets()
    End Sub

    Private Sub btnHotCheeseAdd_Click(sender As Object, e As EventArgs) Handles btnHotCheeseAdd.Click
        hotCheeseStock += 1
        UpdateStockDisplay()
        UpdateStockInGoogleSheets()
    End Sub

    Private Sub btnSpicyBurgerAdd_Click(sender As Object, e As EventArgs) Handles btnSpicyBurgerAdd.Click
        spicyBurgerStock += 1
        UpdateStockDisplay()
        UpdateStockInGoogleSheets()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ' Hide the current form (Form2)
        Me.Hide()
        ' Show the main form (Form1)
        Dim homeForm As New Form1()
        homeForm.Show()
    End Sub

    ' Event handler for the "Exit" button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Confirm before exiting
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit() ' Close the entire application
        End If
    End Sub
End Class
