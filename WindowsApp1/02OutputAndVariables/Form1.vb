Public Class Form1


    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click


        MessageBox.Show("Go")


    End Sub

    Private Sub BntVariables_Click(sender As Object, e As EventArgs) Handles BntVariables.Click


        ' Dim stands for "dimension"
        ' It is used to declare variables
        ' It is a convention to use "st" for the String type
        Dim stFirstName As String
        Dim stSecondName As String

        ' Assigning a value to the variable
        ' In the past, "let" was used for assigning values
        stFirstName = "Agent"
        stSecondName = "Smith"

        ' "&" is used for concatenation
        MsgBox("Hello, " & stFirstName & " " & stSecondName & " welcome.")

        stFirstName = "Neo"
        stSecondName = "Smith"

        MsgBox("Hello, " & stFirstName & " " & stSecondName & " welcome.")


    End Sub


End Class
