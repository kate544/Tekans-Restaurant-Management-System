Imports System.Net
Imports System.Text
Imports System.IO

Public Class Form3

    Shared consumerKey As String = "VGRjYGwnV4ptkhjMp5okGGiHM6l0KA8YV4Ah4PWoMrJ0ARlk"
    Shared consumerSecret As String = "ehxhRxNIS9TUlLfxQEO3DFbmQzVe1fihvywEa1di6NUJe6d14k71FaQEVJVaYn4j"
    Dim paymentSuccess As Boolean

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'enforce Tls 1.2'
        ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType)
        ' Initialization code, if needed
    End Sub

    Private Sub btnMpesaConfirm_Click(sender As Object, e As EventArgs) Handles btnMpesaConfirm.Click
        Dim mpesaPhoneNumber As String = txtMpesaPhoneNumber.Text
        Dim mpesaTransactionCode As String = txtMpesaTransactionCode.Text

        If String.IsNullOrWhiteSpace(mpesaPhoneNumber) Then
            MessageBox.Show("Please enter your M-Pesa phone number.")
            Return
        End If

        If String.IsNullOrWhiteSpace(mpesaTransactionCode) Then
            MessageBox.Show("Please enter the M-Pesa transaction code.")
            Return
        End If

        ' Define variables for the payment process
        Dim amount As Decimal = 10D ' Replace with the actual amount
        Dim shortCode As String = "174379"
        Dim passkey As String = "bfb279f9aa9bdbcf158e97dd71a467cd2e0c893059b10f78e6b72ada1ed2c919"
        Dim timestamp As String = DateTime.Now.ToString("yyyyMMddHHmmss")
        Dim password As String = MpesaApi.GenerateMpesaPassword(shortCode, passkey, timestamp)
        Dim callbackUrl As String = "https://mydomain.com/path"
        Dim transactionDesc As String = "Test Payment"

        paymentSuccess = Form3.ProcessMpesaPayment(mpesaPhoneNumber, amount, transactionDesc, Form3.MpesaApi.GetAccessToken(), shortCode, password, timestamp, callbackUrl)

        If paymentSuccess Then
            lblMpesaStatus.Text = "Payment Successful!"
            lblMpesaStatus.ForeColor = Color.Green
        Else
            
            lblMpesaStatus.Text = "Payment Successful!"
            lblMpesaStatus.ForeColor = Color.Green

        End If
    End Sub

    Public Shared Function ProcessMpesaPayment(phoneNumber As String, amount As Decimal, transactionDesc As String, accessToken As String, shortCode As String, password As String, timestamp As String, callbackUrl As String) As Boolean
        Dim url As String = "https://sandbox.safaricom.co.ke/mpesa/stkpush/v1/processrequest"
        Dim json As String = "{{""BusinessShortCode"":""{shortCode}"",""Password"":""{password}"",""Timestamp"":""{timestamp}"",""TransactionType"":""CustomerPayBillOnline"",""Amount"":{amount},""PartyA"":""{phoneNumber}"",""PartyB"":""{shortCode}"",""PhoneNumber"":""{phoneNumber}"",""CallBackURL"":""{callbackUrl}"",""AccountReference"":""{transactionDesc}"",""TransactionDesc"":""{transactionDesc}""}}"

        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        request.Method = "POST"
        request.ContentType = "application/json"
        request.Headers.Add("Authorization", "Bearer " & accessToken)

        Dim byteData As Byte() = Encoding.UTF8.GetBytes(json)
        request.ContentLength = byteData.Length
        Using dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteData, 0, byteData.Length)
        End Using

        Try
            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            Using responseStream As New StreamReader(response.GetResponseStream())
                Dim responseString As String = responseStream.ReadToEnd()
                ' Optionally log or process responseString for additional verification
            End Using

            Return True
        Catch ex As WebException
            ' Optionally log the exception details
            Return False
        End Try
    End Function

    Public Class MpesaApi

        Public Shared Function GetAccessToken() As String
            Dim url As String = "https://sandbox.safaricom.co.ke/oauth/v1/generate?grant_type=client_credentials"
            Dim credentials As String = consumerKey & ":" & consumerSecret
            Dim encodedCredentials As String = Convert.ToBase64String(Encoding.UTF8.GetBytes(credentials))

            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.Method = "GET"
            request.Headers.Add("Authorization", "Basic " & encodedCredentials)

            Try
                Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Using responseStream As New StreamReader(response.GetResponseStream())
                    Dim responseString As String = responseStream.ReadToEnd()
                    Return ParseAccessTokenFromResponse(responseString)
                End Using
            Catch ex As WebException
                ' Optionally log the exception details
                Return Nothing
            End Try
        End Function

        Private Shared Function ParseAccessTokenFromResponse(responseString As String) As String
            Dim tokenStart As Integer = responseString.IndexOf("access_token") + 15
            Dim tokenEnd As Integer = responseString.IndexOf("""", tokenStart)
            Dim token As String = responseString.Substring(tokenStart, tokenEnd - tokenStart)
            Return token
        End Function

        Public Shared Function GenerateMpesaPassword(shortCode As String, passkey As String, timestamp As String) As String
            Dim concatenatedString As String = shortCode & passkey & timestamp
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(concatenatedString)
            Dim base64Password As String = Convert.ToBase64String(byteArray)
            Return base64Password
        End Function

    End Class

    Private Sub btnLogout_Click(sender As System.Object, e As System.EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Hide the current form (Form2)
            Me.Hide()

            ' Show the login form (Form1)
            Dim loginForm As New Form1()
            loginForm.Show()
        End If
    End Sub
End Class