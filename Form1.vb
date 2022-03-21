Public Class Form1
    Const poliName As String = "Politeknik Seberang Perai"
    Private Sub cmdClick_Click(sender As Object, e As EventArgs) Handles cmdClick.Click
        Dim strName As String = txtName.Text
        Dim strState As String = txtState.Text
        Dim strOutput As String = "Hello " + strName + " from " + strState

        lblOutput.Text = strOutput
        lblPoliName.Text = "Welcome to " + poliName
    End Sub

End Class
