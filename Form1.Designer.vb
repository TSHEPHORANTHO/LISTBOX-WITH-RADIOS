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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.rdToUpper = New System.Windows.Forms.RadioButton()
        Me.rdToLower = New System.Windows.Forms.RadioButton()
        Me.rdPurple = New System.Windows.Forms.RadioButton()
        Me.rdBlue = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(124, 92)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(112, 34)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(96, 132)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(180, 129)
        Me.ListBox1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(-1, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(436, 31)
        Me.TextBox1.TabIndex = 2
        '
        'rdToUpper
        '
        Me.rdToUpper.AutoSize = True
        Me.rdToUpper.Location = New System.Drawing.Point(60, 369)
        Me.rdToUpper.Name = "rdToUpper"
        Me.rdToUpper.Size = New System.Drawing.Size(109, 29)
        Me.rdToUpper.TabIndex = 3
        Me.rdToUpper.TabStop = True
        Me.rdToUpper.Text = "To Upper"
        Me.rdToUpper.UseVisualStyleBackColor = True
        '
        'rdToLower
        '
        Me.rdToLower.AutoSize = True
        Me.rdToLower.Location = New System.Drawing.Point(60, 404)
        Me.rdToLower.Name = "rdToLower"
        Me.rdToLower.Size = New System.Drawing.Size(107, 29)
        Me.rdToLower.TabIndex = 3
        Me.rdToLower.TabStop = True
        Me.rdToLower.Text = "To Lower"
        Me.rdToLower.UseVisualStyleBackColor = True
        '
        'rdPurple
        '
        Me.rdPurple.AutoSize = True
        Me.rdPurple.Location = New System.Drawing.Point(238, 369)
        Me.rdPurple.Name = "rdPurple"
        Me.rdPurple.Size = New System.Drawing.Size(87, 29)
        Me.rdPurple.TabIndex = 3
        Me.rdPurple.TabStop = True
        Me.rdPurple.Text = "Purple"
        Me.rdPurple.UseVisualStyleBackColor = True
        '
        'rdBlue
        '
        Me.rdBlue.AutoSize = True
        Me.rdBlue.Location = New System.Drawing.Point(238, 404)
        Me.rdBlue.Name = "rdBlue"
        Me.rdBlue.Size = New System.Drawing.Size(70, 29)
        Me.rdBlue.TabIndex = 3
        Me.rdBlue.TabStop = True
        Me.rdBlue.Text = "Blue"
        Me.rdBlue.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(142, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter Words"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(243, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Colour"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(96, 332)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Case"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rdBlue)
        Me.Controls.Add(Me.rdToLower)
        Me.Controls.Add(Me.rdPurple)
        Me.Controls.Add(Me.rdToUpper)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Form1"
        Me.Text = "Word"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents rdToUpper As RadioButton
    Friend WithEvents rdToLower As RadioButton
    Friend WithEvents rdPurple As RadioButton
    Friend WithEvents rdBlue As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
