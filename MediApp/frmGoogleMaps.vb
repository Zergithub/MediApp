Public Class frmGoogleMaps
    'Call when the forms Load
    Private Sub frmGoogleMaps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim quearyAddress As String = ""
        Try
            'Url for searching nearby pharamacy and hospitals
            quearyAddress = "https://www.google.com/search?rlz=1C1PRFI_enPK756PK756&sxsrf=ALeKk03wZq109h89nLhzLGdUS7SAXTuVzw:1595507104266&q=nearby%20pharmacy%20and%20hospital&npsic=0&rflfq=1&rldoc=1&rlha=0&rllag=33666964,73039576,4264&tbm=lcl&sa=X&ved=2ahUKEwjBrL6Rr-PqAhXCyKQKHU_NDFUQj5kEegQIDBAC&tbs=lrf:!1m4!1u3!2m2!3m1!1e1!2m1!1e3!3sIAE,lf:1,lf_ui:3&rlst=f#rlfi=hd:;si:;mv:[[33.706127699999996,73.12911509999999],[33.5487128,72.95388410000001]];tbs:lrf:!1m4!1u3!2m2!3m1!1e1!2m1!1e3!3sIAE,lf:1,lf_ui:3"
            'load web browser with above url
            WebBrowser1.Navigate(quearyAddress)
        Catch ex As Exception
            'Show Exception message if occured
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class