﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.btnGreet = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(349, 200)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(147, 20)
        Me.txtCountry.TabIndex = 0
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(205, 203)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(138, 13)
        Me.lblCountry.TabIndex = 1
        Me.lblCountry.Text = "What country are you from?"
        '
        'btnGreet
        '
        Me.btnGreet.Location = New System.Drawing.Point(365, 243)
        Me.btnGreet.Name = "btnGreet"
        Me.btnGreet.Size = New System.Drawing.Size(113, 38)
        Me.btnGreet.TabIndex = 2
        Me.btnGreet.Text = "Greetings"
        Me.btnGreet.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnGreet)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.txtCountry)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCountry As TextBox
    Friend WithEvents lblCountry As Label
    Friend WithEvents btnGreet As Button
End Class
