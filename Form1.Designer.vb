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
        Me.lblEnter = New System.Windows.Forms.Label()
        Me.cmdClick = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.lblPoliName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnter.Location = New System.Drawing.Point(32, 39)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(185, 26)
        Me.lblEnter.TabIndex = 0
        Me.lblEnter.Text = "Enter your name :"
        '
        'cmdClick
        '
        Me.cmdClick.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdClick.FlatAppearance.BorderSize = 2
        Me.cmdClick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdClick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClick.Location = New System.Drawing.Point(363, 154)
        Me.cmdClick.Name = "cmdClick"
        Me.cmdClick.Size = New System.Drawing.Size(166, 30)
        Me.cmdClick.TabIndex = 1
        Me.cmdClick.Text = "CLICK HERE"
        Me.cmdClick.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(246, 39)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(408, 29)
        Me.txtName.TabIndex = 2
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(131, 207)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(86, 26)
        Me.lblOutput.TabIndex = 3
        Me.lblOutput.Text = "Result :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter your state :"
        '
        'txtState
        '
        Me.txtState.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.Location = New System.Drawing.Point(246, 100)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(408, 29)
        Me.txtState.TabIndex = 5
        '
        'lblPoliName
        '
        Me.lblPoliName.AutoSize = True
        Me.lblPoliName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoliName.Location = New System.Drawing.Point(132, 261)
        Me.lblPoliName.Name = "lblPoliName"
        Me.lblPoliName.Size = New System.Drawing.Size(0, 24)
        Me.lblPoliName.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 310)
        Me.Controls.Add(Me.lblPoliName)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.cmdClick)
        Me.Controls.Add(Me.lblEnter)
        Me.Name = "Form1"
        Me.Text = "Input Box"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEnter As Label
    Friend WithEvents cmdClick As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents lblPoliName As Label
End Class
