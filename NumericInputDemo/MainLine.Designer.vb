<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainLine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainLine))
        Me.StandardTBLabel = New System.Windows.Forms.Label()
        Me.StandardTextBox = New System.Windows.Forms.TextBox()
        Me.KeyPressTextBox = New System.Windows.Forms.TextBox()
        Me.KeyPressTBLabel = New System.Windows.Forms.Label()
        Me.ValidatingTextBox = New System.Windows.Forms.TextBox()
        Me.ValidatingTBLabel = New System.Windows.Forms.Label()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.MyStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NumericMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTBLabel = New System.Windows.Forms.Label()
        Me.MyNumericUpDwn = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDwnLabel = New System.Windows.Forms.Label()
        Me.MyStatusStrip.SuspendLayout()
        CType(Me.MyNumericUpDwn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StandardTBLabel
        '
        Me.StandardTBLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StandardTBLabel.AutoSize = True
        Me.StandardTBLabel.Location = New System.Drawing.Point(10, 15)
        Me.StandardTBLabel.Name = "StandardTBLabel"
        Me.StandardTBLabel.Size = New System.Drawing.Size(100, 15)
        Me.StandardTBLabel.TabIndex = 0
        Me.StandardTBLabel.Text = "&Standard TextBox:"
        '
        'StandardTextBox
        '
        Me.StandardTextBox.Location = New System.Drawing.Point(126, 12)
        Me.StandardTextBox.Name = "StandardTextBox"
        Me.StandardTextBox.Size = New System.Drawing.Size(112, 23)
        Me.StandardTextBox.TabIndex = 1
        '
        'KeyPressTextBox
        '
        Me.KeyPressTextBox.Location = New System.Drawing.Point(126, 56)
        Me.KeyPressTextBox.Name = "KeyPressTextBox"
        Me.KeyPressTextBox.Size = New System.Drawing.Size(112, 23)
        Me.KeyPressTextBox.TabIndex = 3
        '
        'KeyPressTBLabel
        '
        Me.KeyPressTBLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KeyPressTBLabel.AutoSize = True
        Me.KeyPressTBLabel.Location = New System.Drawing.Point(10, 59)
        Me.KeyPressTBLabel.Name = "KeyPressTBLabel"
        Me.KeyPressTBLabel.Size = New System.Drawing.Size(102, 15)
        Me.KeyPressTBLabel.TabIndex = 2
        Me.KeyPressTBLabel.Text = "&Key Press TextBox:"
        '
        'ValidatingTextBox
        '
        Me.ValidatingTextBox.Location = New System.Drawing.Point(126, 100)
        Me.ValidatingTextBox.Name = "ValidatingTextBox"
        Me.ValidatingTextBox.Size = New System.Drawing.Size(112, 23)
        Me.ValidatingTextBox.TabIndex = 5
        '
        'ValidatingTBLabel
        '
        Me.ValidatingTBLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ValidatingTBLabel.AutoSize = True
        Me.ValidatingTBLabel.Location = New System.Drawing.Point(10, 103)
        Me.ValidatingTBLabel.Name = "ValidatingTBLabel"
        Me.ValidatingTBLabel.Size = New System.Drawing.Size(105, 15)
        Me.ValidatingTBLabel.TabIndex = 4
        Me.ValidatingTBLabel.Text = "&Validating TextBox:"
        '
        'SubmitButton
        '
        Me.SubmitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubmitButton.Location = New System.Drawing.Point(409, 103)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SubmitButton.TabIndex = 10
        Me.SubmitButton.Text = "&Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'MyStatusStrip
        '
        Me.MyStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.MyStatusStrip.Location = New System.Drawing.Point(0, 146)
        Me.MyStatusStrip.Name = "MyStatusStrip"
        Me.MyStatusStrip.Size = New System.Drawing.Size(498, 22)
        Me.MyStatusStrip.TabIndex = 11
        Me.MyStatusStrip.Text = "StatusStrip1"
        '
        'StatusLabel
        '
        Me.StatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'NumericMaskedTextBox
        '
        Me.NumericMaskedTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericMaskedTextBox.Location = New System.Drawing.Point(372, 14)
        Me.NumericMaskedTextBox.Name = "NumericMaskedTextBox"
        Me.NumericMaskedTextBox.Size = New System.Drawing.Size(112, 23)
        Me.NumericMaskedTextBox.TabIndex = 7
        '
        'MaskedTBLabel
        '
        Me.MaskedTBLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaskedTBLabel.AutoSize = True
        Me.MaskedTBLabel.Location = New System.Drawing.Point(257, 17)
        Me.MaskedTBLabel.Name = "MaskedTBLabel"
        Me.MaskedTBLabel.Size = New System.Drawing.Size(94, 15)
        Me.MaskedTBLabel.TabIndex = 6
        Me.MaskedTBLabel.Text = "&Masked TextBox:"
        '
        'MyNumericUpDwn
        '
        Me.MyNumericUpDwn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyNumericUpDwn.Location = New System.Drawing.Point(372, 57)
        Me.MyNumericUpDwn.Name = "MyNumericUpDwn"
        Me.MyNumericUpDwn.Size = New System.Drawing.Size(112, 23)
        Me.MyNumericUpDwn.TabIndex = 9
        '
        'NumericUpDwnLabel
        '
        Me.NumericUpDwnLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDwnLabel.AutoSize = True
        Me.NumericUpDwnLabel.Location = New System.Drawing.Point(257, 59)
        Me.NumericUpDwnLabel.Name = "NumericUpDwnLabel"
        Me.NumericUpDwnLabel.Size = New System.Drawing.Size(108, 15)
        Me.NumericUpDwnLabel.TabIndex = 8
        Me.NumericUpDwnLabel.Text = "&Numeric Up Down:"
        '
        'MainLine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(498, 168)
        Me.Controls.Add(Me.NumericUpDwnLabel)
        Me.Controls.Add(Me.MyNumericUpDwn)
        Me.Controls.Add(Me.MaskedTBLabel)
        Me.Controls.Add(Me.NumericMaskedTextBox)
        Me.Controls.Add(Me.MyStatusStrip)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.ValidatingTextBox)
        Me.Controls.Add(Me.ValidatingTBLabel)
        Me.Controls.Add(Me.KeyPressTextBox)
        Me.Controls.Add(Me.KeyPressTBLabel)
        Me.Controls.Add(Me.StandardTextBox)
        Me.Controls.Add(Me.StandardTBLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainLine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Numeric Input Demo"
        Me.MyStatusStrip.ResumeLayout(False)
        Me.MyStatusStrip.PerformLayout()
        CType(Me.MyNumericUpDwn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StandardTBLabel As Label
    Friend WithEvents StandardTextBox As TextBox
    Friend WithEvents KeyPressTextBox As TextBox
    Friend WithEvents KeyPressTBLabel As Label
    Friend WithEvents ValidatingTextBox As TextBox
    Friend WithEvents ValidatingTBLabel As Label
    Friend WithEvents SubmitButton As Button
    Friend WithEvents MyStatusStrip As StatusStrip
    Friend WithEvents StatusLabel As ToolStripStatusLabel
    Friend WithEvents NumericMaskedTextBox As MaskedTextBox
    Friend WithEvents MaskedTBLabel As Label
    Friend WithEvents MyNumericUpDwn As NumericUpDown
    Friend WithEvents NumericUpDwnLabel As Label
End Class
