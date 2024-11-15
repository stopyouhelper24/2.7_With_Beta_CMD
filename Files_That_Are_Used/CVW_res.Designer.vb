<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CVW_res
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CVW_res))
        Me.close1 = New System.Windows.Forms.PictureBox()
        Me.maxi = New System.Windows.Forms.PictureBox()
        Me.mini1 = New System.Windows.Forms.PictureBox()
        Me.mini2 = New System.Windows.Forms.PictureBox()
        Me.Maxi2 = New System.Windows.Forms.PictureBox()
        Me.Close2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.close1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maxi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mini1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mini2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Maxi2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Close2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'close1
        '
        Me.close1.Image = CType(resources.GetObject("close1.Image"), System.Drawing.Image)
        Me.close1.Location = New System.Drawing.Point(224, 12)
        Me.close1.Name = "close1"
        Me.close1.Size = New System.Drawing.Size(100, 92)
        Me.close1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.close1.TabIndex = 0
        Me.close1.TabStop = False
        '
        'maxi
        '
        Me.maxi.Image = CType(resources.GetObject("maxi.Image"), System.Drawing.Image)
        Me.maxi.Location = New System.Drawing.Point(118, 12)
        Me.maxi.Name = "maxi"
        Me.maxi.Size = New System.Drawing.Size(100, 92)
        Me.maxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.maxi.TabIndex = 1
        Me.maxi.TabStop = False
        '
        'mini1
        '
        Me.mini1.Image = CType(resources.GetObject("mini1.Image"), System.Drawing.Image)
        Me.mini1.Location = New System.Drawing.Point(12, 12)
        Me.mini1.Name = "mini1"
        Me.mini1.Size = New System.Drawing.Size(100, 92)
        Me.mini1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mini1.TabIndex = 2
        Me.mini1.TabStop = False
        '
        'mini2
        '
        Me.mini2.Image = CType(resources.GetObject("mini2.Image"), System.Drawing.Image)
        Me.mini2.Location = New System.Drawing.Point(12, 126)
        Me.mini2.Name = "mini2"
        Me.mini2.Size = New System.Drawing.Size(100, 92)
        Me.mini2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mini2.TabIndex = 5
        Me.mini2.TabStop = False
        '
        'Maxi2
        '
        Me.Maxi2.Image = CType(resources.GetObject("Maxi2.Image"), System.Drawing.Image)
        Me.Maxi2.Location = New System.Drawing.Point(118, 126)
        Me.Maxi2.Name = "Maxi2"
        Me.Maxi2.Size = New System.Drawing.Size(100, 92)
        Me.Maxi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Maxi2.TabIndex = 4
        Me.Maxi2.TabStop = False
        '
        'Close2
        '
        Me.Close2.Image = CType(resources.GetObject("Close2.Image"), System.Drawing.Image)
        Me.Close2.Location = New System.Drawing.Point(224, 126)
        Me.Close2.Name = "Close2"
        Me.Close2.Size = New System.Drawing.Size(100, 92)
        Me.Close2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Close2.TabIndex = 3
        Me.Close2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(12, 110)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(312, 10)
        Me.Panel1.TabIndex = 6
        '
        'CVW_res
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.mini2)
        Me.Controls.Add(Me.Maxi2)
        Me.Controls.Add(Me.Close2)
        Me.Controls.Add(Me.mini1)
        Me.Controls.Add(Me.maxi)
        Me.Controls.Add(Me.close1)
        Me.Name = "CVW_res"
        Me.Text = "CVW_res"
        CType(Me.close1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maxi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mini1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mini2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Maxi2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Close2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents close1 As PictureBox
    Friend WithEvents maxi As PictureBox
    Friend WithEvents mini1 As PictureBox
    Friend WithEvents mini2 As PictureBox
    Friend WithEvents Maxi2 As PictureBox
    Friend WithEvents Close2 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
