Public Class Form1
    Private Sub btnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click
        Dim stCountry As String
        stCountry = txtCountry.Text

        ' One liner if statement :
        ' If stCountry = "Australia" Then MsgBox("G'day mate!") 

        ' Nested if statements:
        If stCountry.ToLower = "australia" Then
            MsgBox("G'day mate!")
            MsgBox("No worries...")
        ElseIf stCountry.ToLower = "france" Then
            MsgBox("Bonjour.")
            MsgBox("Comment allez-vous?")
        ElseIf stCountry.ToLower = "mexico" Then
            MsgBox("Hola, ¿qué tal?")
            MsgBox("¿Qué pasa, tío?")
        ElseIf stCountry.ToLower = "brazil" Then
            MsgBox("Fala cidadão.")
            MsgBox("Como andam as coisas?")
        ElseIf stCountry.ToLower = "italy" Then
            MsgBox("Ciao!")
            MsgBox("Come stai?")
        ElseIf stCountry.ToLower = "germany" Then
            MsgBox("Hallo, wie geht's dir?")
            MsgBox("Tschüss")
        Else
            MsgBox("Hello there person from " & stCountry)
            MsgBox("Unfortunately, we do not poses your country in our database.")
        End If

        MsgBox("You have entered " & stCountry)
    End Sub
End Class
