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


    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click


        ' "i" is used for integer variables
        ' "b" is used for boolean variables
        ' "dec" is used for decimal variables
        ' "dt" is used for date variables
        Dim stMake As String
        Dim stModel As String
        Dim stColor As String
        Dim iDoors As Integer
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim bTaxed As Boolean
        Dim dtDateRegistered As Date

        ' Use # to assign a date value to a date variable
        stMake = "Ford"
        stModel = "Escort"
        stColor = "Red"
        iDoors = 5
        bTaxed = True
        iEngineSize = 1200
        decPrice = 999.99
        dtDateRegistered = #08/10/2024# ' American format

        ' use vbNewLine constant to break lines
        MsgBox(
            "Make: " & stMake & vbNewLine &
            "Model: " & stModel & vbNewLine &
            "Doors: " & iDoors & vbNewLine &
            "Engine Size:" & iEngineSize & vbNewLine &
            "Color: " & stColor & vbNewLine &
            "Taxed: " & bTaxed & vbNewLine &
            "Price: " & decPrice & vbNewLine &
            "Date Registration: " & dtDateRegistered
        )


    End Sub


End Class
