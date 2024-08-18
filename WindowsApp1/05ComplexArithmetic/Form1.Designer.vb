<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.lblPostage = New System.Windows.Forms.Label()
        Me.txtPostage = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(283, 253)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(233, 85)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(348, 106)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(168, 20)
        Me.txtQuantity.TabIndex = 1
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(348, 142)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(168, 20)
        Me.txtPrice.TabIndex = 2
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(280, 106)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(46, 13)
        Me.lblQuantity.TabIndex = 3
        Me.lblQuantity.Text = "Quantity"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(280, 145)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblPrice.TabIndex = 4
        Me.lblPrice.Text = "Price"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Location = New System.Drawing.Point(280, 180)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(49, 13)
        Me.lblDiscount.TabIndex = 6
        Me.lblDiscount.Text = "Discount"
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(348, 177)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(168, 20)
        Me.txtDiscount.TabIndex = 5
        '
        'lblPostage
        '
        Me.lblPostage.AutoSize = True
        Me.lblPostage.Location = New System.Drawing.Point(282, 218)
        Me.lblPostage.Name = "lblPostage"
        Me.lblPostage.Size = New System.Drawing.Size(46, 13)
        Me.lblPostage.TabIndex = 8
        Me.lblPostage.Text = "Postage"
        '
        'txtPostage
        '
        Me.txtPostage.Location = New System.Drawing.Point(350, 215)
        Me.txtPostage.Name = "txtPostage"
        Me.txtPostage.Size = New System.Drawing.Size(168, 20)
        Me.txtPostage.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblPostage)
        Me.Controls.Add(Me.txtPostage)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents lblPostage As Label
    Friend WithEvents txtPostage As TextBox
End Class
