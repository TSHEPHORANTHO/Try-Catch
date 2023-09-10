Public Class Form1
    Private Sub btnButton_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Try Catch
        Dim isNumber As String
        isNumber = txtCharecters.Text


        Try
            'If entered a numeric number
            Dim numericValue As Double
            numericValue = (isNumber)

            'If entered a numeric number display the results
            MsgBox("Valid: " & numericValue & " Is A Number")

        Catch ex As Exception
            'If entered a non-numeric number display results
            MsgBox("Invalid: " & isNumber & " Is Not a number")
        End Try

    End Sub
End Class


