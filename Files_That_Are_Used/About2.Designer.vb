<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About2
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About2))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
		Me.TextBoxDescription = New System.Windows.Forms.TextBox()
		Me.LabelCompanyName = New System.Windows.Forms.Label()
		Me.LabelCopyright = New System.Windows.Forms.Label()
		Me.LabelVersion = New System.Windows.Forms.Label()
		Me.LabelProductName = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.Button1)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(754, 49)
		Me.Panel1.TabIndex = 0
		Me.Panel1.Visible = False
		'
		'Button1
		'
		Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Location = New System.Drawing.Point(707, 0)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(44, 46)
		Me.Button1.TabIndex = 1
		Me.Button1.UseVisualStyleBackColor = True
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(467, 74)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(91, 69)
		Me.PictureBox1.TabIndex = 8
		Me.PictureBox1.TabStop = False
		'
		'LogoPictureBox
		'
		Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
		Me.LogoPictureBox.Location = New System.Drawing.Point(12, 74)
		Me.LogoPictureBox.Name = "LogoPictureBox"
		Me.LogoPictureBox.Size = New System.Drawing.Size(305, 445)
		Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.LogoPictureBox.TabIndex = 2
		Me.LogoPictureBox.TabStop = False
		'
		'TextBoxDescription
		'
		Me.TextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBoxDescription.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxDescription.Location = New System.Drawing.Point(326, 292)
		Me.TextBoxDescription.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
		Me.TextBoxDescription.Multiline = True
		Me.TextBoxDescription.Name = "TextBoxDescription"
		Me.TextBoxDescription.ReadOnly = True
		Me.TextBoxDescription.Size = New System.Drawing.Size(416, 227)
		Me.TextBoxDescription.TabIndex = 3
		Me.TextBoxDescription.TabStop = False
		Me.TextBoxDescription.Text = "Description:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This Program is touch friendly And" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "has a good UI"
		'
		'LabelCompanyName
		'
		Me.LabelCompanyName.AutoSize = True
		Me.LabelCompanyName.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelCompanyName.Location = New System.Drawing.Point(321, 253)
		Me.LabelCompanyName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
		Me.LabelCompanyName.Name = "LabelCompanyName"
		Me.LabelCompanyName.Size = New System.Drawing.Size(153, 27)
		Me.LabelCompanyName.TabIndex = 4
		Me.LabelCompanyName.Text = "Company Name"
		Me.LabelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'LabelCopyright
		'
		Me.LabelCopyright.AutoSize = True
		Me.LabelCopyright.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelCopyright.Location = New System.Drawing.Point(321, 216)
		Me.LabelCopyright.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
		Me.LabelCopyright.Name = "LabelCopyright"
		Me.LabelCopyright.Size = New System.Drawing.Size(103, 27)
		Me.LabelCopyright.TabIndex = 5
		Me.LabelCopyright.Text = "Copyright"
		Me.LabelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'LabelVersion
		'
		Me.LabelVersion.AutoSize = True
		Me.LabelVersion.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelVersion.Location = New System.Drawing.Point(321, 181)
		Me.LabelVersion.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
		Me.LabelVersion.Name = "LabelVersion"
		Me.LabelVersion.Size = New System.Drawing.Size(80, 27)
		Me.LabelVersion.TabIndex = 6
		Me.LabelVersion.Text = "Version"
		Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'LabelProductName
		'
		Me.LabelProductName.AutoSize = True
		Me.LabelProductName.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelProductName.Location = New System.Drawing.Point(321, 146)
		Me.LabelProductName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
		Me.LabelProductName.Name = "LabelProductName"
		Me.LabelProductName.Size = New System.Drawing.Size(141, 27)
		Me.LabelProductName.TabIndex = 7
		Me.LabelProductName.Text = "Product Name"
		Me.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'About2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(754, 532)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.LogoPictureBox)
		Me.Controls.Add(Me.TextBoxDescription)
		Me.Controls.Add(Me.LabelCompanyName)
		Me.Controls.Add(Me.LabelCopyright)
		Me.Controls.Add(Me.LabelVersion)
		Me.Controls.Add(Me.LabelProductName)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "About2"
		Me.Text = "About2"
		Me.Panel1.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents TextBoxDescription As TextBox
    Friend WithEvents LabelCompanyName As Label
    Friend WithEvents LabelCopyright As Label
    Friend WithEvents LabelVersion As Label
    Friend WithEvents LabelProductName As Label
End Class
