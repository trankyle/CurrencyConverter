Imports System.Net.Http

Public Class Form1
    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click


    End Sub
    Private Async Function GetExchangeRate(fromCurrency As String, toCurrency As String) As Task(Of Decimal)

        Dim apiUrl As String = $"https://api.exchangerate.host/live?access_key=YOUR_ACCESS_KEY&from={fromCurrency}&to={toCurrency}&access_key=2a7d90775edab2cf621b8d0d6ecbfae3"
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)
            If response.IsSuccessStatusCode Then
                Dim json = Await response.Content.ReadAsStringAsync()
                Dim jsonObject = Newtonsoft.Json.Linq.JObject.Parse(json)

                Return Convert.ToDecimal(jsonObject("quotes")(fromCurrency & toCurrency))
            Else
                Throw New Exception("Error fetching exchange rate.")
            End If
        End Using
    End Function
    Private Sub LoadCurrencies()
        Dim currencies As String() = {"USD", "EUR", "GBP", "CAD", "AUD", "JPY", "INR"}
        cmbFromCurrency.Items.AddRange(currencies)
        cmbToCurrency.Items.AddRange(currencies)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCurrencies()
    End Sub
    Private Async Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Try
            lblStatus.Text = "Status: Fetching exchange rate..."
            Dim fromCurrency = cmbFromCurrency.SelectedItem.ToString()
            Dim toCurrency = cmbToCurrency.SelectedItem.ToString()
            Dim amount As Decimal = Convert.ToDecimal(txtAmount.Text)


            Dim rate As Decimal = Await GetExchangeRate(fromCurrency, toCurrency)


            Dim result As Decimal = amount * rate
            txtResult.Text = result.ToString("F2")
            lblStatus.Text = "Status: Conversion successful."
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            lblStatus.Text = "Status: Error occurred."
        End Try
    End Sub




End Class
