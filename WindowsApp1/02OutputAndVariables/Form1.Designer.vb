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
        Me.btnGo = New System.Windows.Forms.Button()
        Me.BntVariables = New System.Windows.Forms.Button()
        Me.btnDataTypes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnGo.Location = New System.Drawing.Point(259, 26)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(248, 105)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'BntVariables
        '
        Me.BntVariables.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BntVariables.Location = New System.Drawing.Point(259, 151)
        Me.BntVariables.Name = "BntVariables"
        Me.BntVariables.Size = New System.Drawing.Size(248, 104)
        Me.BntVariables.TabIndex = 1
        Me.BntVariables.Text = "Variables Demonstration"
        Me.BntVariables.UseVisualStyleBackColor = False
        '
        'btnDataTypes
        '
        Me.btnDataTypes.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnDataTypes.Location = New System.Drawing.Point(259, 277)
        Me.btnDataTypes.Name = "btnDataTypes"
        Me.btnDataTypes.Size = New System.Drawing.Size(248, 104)
        Me.btnDataTypes.TabIndex = 2
        Me.btnDataTypes.Text = "Data Types"
        Me.btnDataTypes.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDataTypes)
        Me.Controls.Add(Me.BntVariables)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGo As Button
    Friend WithEvents BntVariables As Button
    Friend WithEvents btnDataTypes As Button
End Class
