Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decPrice As Decimal
        Dim iQuantity As Integer
        Dim decDiscount As Decimal
        Dim decPostage As Decimal
        Dim decTotalCost As Decimal
        Dim decTotalCostWithDiscount As Decimal

        decPrice = txtPrice.Text
        iQuantity = txtQuantity.Text
        decPostage = txtPostage.Text
        decDiscount = txtDiscount.Text

        'Order of prioritiees when doing arithmetic operations:

        'BO(DM)(AS) - Brackets (Parenthesis), Order (Exponentiation), 
        'Division, Multiplication (same priority As Division),
        'Addition, Subtraction (same priority As Addition)

        'PE(MD)(AS) - Parenthesis, Exponentiation, 
        ' Multiplication, Division
        ' Addition, Subtraction

        decTotalCost = decPrice * iQuantity
        decTotalCostWithDiscount = (decPrice - decDiscount) * iQuantity

        MsgBox(
            "Total cost: " & decTotalCost & vbNewLine &
            "Total cost with discount: " & decTotalCostWithDiscount & vbNewLine &
            "Total cost with discount and postage: " & decTotalCostWithDiscount
        )
    End Sub
End Class
