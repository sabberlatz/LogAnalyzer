<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options2
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RB_EN1 = New System.Windows.Forms.RadioButton()
        Me.RB_DE1 = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RB_klein1 = New System.Windows.Forms.RadioButton()
        Me.RB_gross1 = New System.Windows.Forms.RadioButton()
        Me.bn_file1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RB_EN1)
        Me.GroupBox1.Controls.Add(Me.RB_DE1)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(112, 60)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sprache"
        '
        'RB_EN1
        '
        Me.RB_EN1.AutoSize = True
        Me.RB_EN1.Location = New System.Drawing.Point(71, 29)
        Me.RB_EN1.Name = "RB_EN1"
        Me.RB_EN1.Size = New System.Drawing.Size(40, 17)
        Me.RB_EN1.TabIndex = 1
        Me.RB_EN1.Text = "EN"
        Me.RB_EN1.UseVisualStyleBackColor = True
        '
        'RB_DE1
        '
        Me.RB_DE1.AutoSize = True
        Me.RB_DE1.Checked = True
        Me.RB_DE1.Location = New System.Drawing.Point(7, 29)
        Me.RB_DE1.Name = "RB_DE1"
        Me.RB_DE1.Size = New System.Drawing.Size(40, 17)
        Me.RB_DE1.TabIndex = 0
        Me.RB_DE1.TabStop = True
        Me.RB_DE1.Text = "DE"
        Me.RB_DE1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(155, 103)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(508, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "anyERP-Logfile-Pfad"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(588, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(487, 192)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Abbruch"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RB_klein1)
        Me.GroupBox2.Controls.Add(Me.RB_gross1)
        Me.GroupBox2.Location = New System.Drawing.Point(166, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(129, 60)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Anzeige"
        '
        'RB_klein1
        '
        Me.RB_klein1.AutoSize = True
        Me.RB_klein1.Checked = True
        Me.RB_klein1.Location = New System.Drawing.Point(6, 29)
        Me.RB_klein1.Name = "RB_klein1"
        Me.RB_klein1.Size = New System.Drawing.Size(47, 17)
        Me.RB_klein1.TabIndex = 1
        Me.RB_klein1.TabStop = True
        Me.RB_klein1.Text = "klein"
        Me.RB_klein1.UseVisualStyleBackColor = True
        '
        'RB_gross1
        '
        Me.RB_gross1.AutoSize = True
        Me.RB_gross1.Location = New System.Drawing.Point(74, 29)
        Me.RB_gross1.Name = "RB_gross1"
        Me.RB_gross1.Size = New System.Drawing.Size(46, 17)
        Me.RB_gross1.TabIndex = 0
        Me.RB_gross1.Text = "groß"
        Me.RB_gross1.UseVisualStyleBackColor = True
        '
        'bn_file1
        '
        Me.bn_file1.Location = New System.Drawing.Point(670, 99)
        Me.bn_file1.Name = "bn_file1"
        Me.bn_file1.Size = New System.Drawing.Size(26, 23)
        Me.bn_file1.TabIndex = 6
        Me.bn_file1.Text = "..."
        Me.bn_file1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.CheckFileExists = False
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Options2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 235)
        Me.Controls.Add(Me.bn_file1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Options2"
        Me.Text = "Optionen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_EN1 As System.Windows.Forms.RadioButton
    Friend WithEvents RB_DE1 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_klein1 As System.Windows.Forms.RadioButton
    Friend WithEvents RB_gross1 As System.Windows.Forms.RadioButton
    Friend WithEvents bn_file1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
