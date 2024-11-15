Imports System.Runtime.InteropServices

Public Class cmdpad
    Public opened As String = "0"
    Dim mouse_move As System.Drawing.Point
    Private Sub WindowsCMDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsCMDToolStripMenuItem.Click
        Process.Start("cmd.exe")
    End Sub

    Private Sub MenuStrip1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuStrip1.MouseDown
        'mouse_move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub MenuStrip1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuStrip1.MouseMove
        'If (e.Button = Windows.Forms.MouseButtons.Left) Then
        'Dim mposition As Point
        'mposition = Control.MousePosition
        'mposition.Offset(mouse_move.X, mouse_move.Y)
        'Me.Location = mposition
        'If RichTextBox1.Text = "Friday" Then
        ''SettingsToolStripMenuItem.DropDownItems
        'Else
        'SettingsToolStripMenuItem.HideDropDown()
        'End If
        'End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub SebsSWCV20CMDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SebsSWCV20CMDToolStripMenuItem.Click

    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        Old_New_CMDTab = "N"
        tools()
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub
    'Drag Form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Public S As New UserControl1
    Public S2 As New UserControl2
    Private Sub cmdpad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button1.BackgroundImage = CVW_res.close1.Image
        Button2.BackgroundImage = CVW_res.maxi.Image
        Button3.BackgroundImage = CVW_res.mini1.Image
        Me.Panel2.Controls.Add(S)
        Me.Panel2.Controls.Add(S2)
        S.Dock = DockStyle.Fill
        S2.Dock = DockStyle.Fill
        S.Hide()
        S2.Hide()
        Old_New_CMDTab = "N"
        tools()


        Panel1.BackColor = Color.Silver

    End Sub

    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        'S.Hide()
    End Sub

    Private Sub ShowToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem1.Click
        Old_New_CMDTab = "O"
        tools()
    End Sub

    Private Sub HideToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem1.Click
        'S2.Hide()
    End Sub
    Public tabnum As Integer = 1
    Public Old_New_CMDTab As String = "N"
    Public Sub tools()
        If tabnum = 11 Then
        Else

            Dim ss As New TabPage
            Dim WEBB As New UserControl1
            Dim WEBB2 As New UserControl2
            With ss
                .Text = "TAB " & tabnum
                '.Controls.Add(WEBB)
                If Old_New_CMDTab = "N" Then
                    .Controls.Add(WEBB)
                    WEBB.Dock = DockStyle.Fill
                    WEBB.RichTextBox1.Font = S22
                ElseIf Old_New_CMDTab = "O" Then
                    .Controls.Add(WEBB2)
                    WEBB2.Dock = DockStyle.Fill
                    WEBB2.RichTextBox1.Font = S22
                End If


            End With


            TabControl1.Controls.Add(ss)
            tabnum = tabnum + 1
        End If
        'MsgBox(tabnum.ToString)
    End Sub
    Public S22 As Font
    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        If FontDialog1.ShowDialog = DialogResult.OK Then
            S22 = FontDialog1.Font
        End If
    End Sub

    Private Sub FontDialog1_Apply(sender As Object, e As EventArgs) Handles FontDialog1.Apply

    End Sub

    Private Sub cmdpad_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Form15.Show()
        About2.Show()
        About2.LabelProductName.Text = "Product CMD"
        About2.LabelVersion.Text = "Version 2.5.0.1"

        'About2.PictureBox1.Image = Form_1pad.Button11.BackgroundImage
        About2.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        About2.LabelCopyright.Text = My.Application.Info.Copyright
        About2.LabelCompanyName.Text = My.Application.Info.CompanyName
        About2.TextBoxDescription.Text = "Description:
CMD can open Forms, Apps and install Apps.

You Can use the New or Old CMD Commands."
        Form15.Close()
    End Sub
End Class