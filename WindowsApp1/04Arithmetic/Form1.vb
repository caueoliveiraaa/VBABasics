Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblNumber1 As Double
        Dim dblNumber2 As Double
        Dim dblResult As Double

        dblNumber1 = txtNumber1.Text
        dblNumber2 = txtNumber2.Text

        dblResult = dblNumber1 + dblNumber2
        MsgBox("Sum: " & dblResult)

        dblResult = dblNumber1 - dblNumber2
        MsgBox("Subtraction: " & dblResult)

        dblResult = dblNumber1 * dblNumber2
        MsgBox("Multiplication: " & dblResult)

        dblResult = dblNumber1 / dblNumber2
        MsgBox("Division: " & dblResult)

        ' "^" raise to the power of
        dblResult = dblNumber1 ^ dblNumber2
        MsgBox("Exponentiation: " & dblResult)

        ' "\" ignores the ramainder 
        dblResult = dblNumber1 \ dblNumber2
        MsgBox("Division with no ramainder: " & dblResult)

        ' "Mod " gets the ramainder 
        dblResult = dblNumber1 Mod dblNumber2
        MsgBox("Division's ramainder: " & dblResult)
    End Sub
End Class
