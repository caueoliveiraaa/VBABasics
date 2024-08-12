Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim stFirstName As String
        Dim stLastName As String
        Dim stGender As String
        Dim stOccupation As String

        ' Extracting values from components in the form
        stFirstName = txtFirstName.Text
        stLastName = txtLastName.Text
        stGender = txtGender.Text
        stOccupation = lstOccupation.SelectedItem

        MsgBox(
            "First name: " & stFirstName & vbNewLine &
            "Last name: " & stLastName & vbNewLine &
            "Gender: " & stGender & vbNewLine &
            "Occupation: " & stOccupation
        )
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Adding items to the list of occupations before the form loads
        lstOccupation.Items.Add("Writer")
        lstOccupation.Items.Add("Actor")
        lstOccupation.Items.Add("Painter")
    End Sub
End Class
