<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtRadius = New TextBox()
        Label3 = New Label()
        txtVolume = New TextBox()
        btnCalculate = New Button()
        btnClear = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(150, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(267, 26)
        Label1.TabIndex = 0
        Label1.Text = "Sphere Volume Calculator"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(100, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 24)
        Label2.TabIndex = 1
        Label2.Text = "Radius"
        ' 
        ' txtRadius
        ' 
        txtRadius.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txtRadius.Location = New Point(200, 150)
        txtRadius.Name = "txtRadius"
        txtRadius.Size = New Size(217, 29)
        txtRadius.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(100, 200)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 24)
        Label3.TabIndex = 3
        Label3.Text = "Volume"
        ' 
        ' txtVolume
        ' 
        txtVolume.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txtVolume.Location = New Point(200, 200)
        txtVolume.Name = "txtVolume"
        txtVolume.ReadOnly = True
        txtVolume.Size = New Size(217, 29)
        txtVolume.TabIndex = 4
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnCalculate.Location = New Point(125, 300)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(100, 35)
        btnCalculate.TabIndex = 5
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnClear.Location = New Point(325, 300)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 35)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 361)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(txtVolume)
        Controls.Add(Label3)
        Controls.Add(txtRadius)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Sphere Volume Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRadius As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtVolume As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
