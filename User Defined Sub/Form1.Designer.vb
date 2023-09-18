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
        Button1 = New Button()
        txtA = New TextBox()
        txtB = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(227, 262)
        Button1.Name = "Button1"
        Button1.Size = New Size(287, 80)
        Button1.TabIndex = 0
        Button1.Text = "Execute SUB"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtA
        ' 
        txtA.Location = New Point(140, 67)
        txtA.Name = "txtA"
        txtA.Size = New Size(150, 31)
        txtA.TabIndex = 1
        ' 
        ' txtB
        ' 
        txtB.Location = New Point(384, 60)
        txtB.Name = "txtB"
        txtB.Size = New Size(150, 31)
        txtB.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtB)
        Controls.Add(txtA)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
End Class
