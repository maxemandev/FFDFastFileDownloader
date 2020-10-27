<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FFDx0MApp
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
        Me.components = New System.ComponentModel.Container()
        Me.FFDx0SHADOW = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.FFDx0DRAG = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.FFDx0APPxPANEL = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.FFDx0PANELCONTROLS = New Guna.UI2.WinForms.Guna2Panel()
        Me.FFDx1CLOSEAPP = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.FFDx1MINIMIZEAPP = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.FFDx0APPTITLE = New System.Windows.Forms.Label()
        Me.FFDx0SPLITBOX = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.FFDx0CREATEDOWNLOADTITLE = New System.Windows.Forms.Label()
        Me.FFDx0DOWNLOADSPANEL = New Guna.UI2.WinForms.Guna2Panel()
        Me.FFDx0QUEDL = New System.Windows.Forms.ListBox()
        Me.FFDx0CREATEDOWNLOAD = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.FFDx0DOWNLOADURL = New Guna.UI2.WinForms.Guna2TextBox()
        Me.FFDx0APPxPANEL.SuspendLayout()
        Me.FFDx0PANELCONTROLS.SuspendLayout()
        CType(Me.FFDx0SPLITBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FFDx0DOWNLOADSPANEL.SuspendLayout()
        Me.SuspendLayout()
        '
        'FFDx0DRAG
        '
        Me.FFDx0DRAG.UseTransparentDrag = True
        '
        'FFDx0APPxPANEL
        '
        Me.FFDx0APPxPANEL.BorderColor = System.Drawing.Color.Orange
        Me.FFDx0APPxPANEL.BorderThickness = 1
        Me.FFDx0APPxPANEL.Controls.Add(Me.FFDx0DOWNLOADSPANEL)
        Me.FFDx0APPxPANEL.Controls.Add(Me.FFDx0CREATEDOWNLOADTITLE)
        Me.FFDx0APPxPANEL.Controls.Add(Me.FFDx0SPLITBOX)
        Me.FFDx0APPxPANEL.Controls.Add(Me.FFDx0PANELCONTROLS)
        Me.FFDx0APPxPANEL.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.FFDx0APPxPANEL.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.FFDx0APPxPANEL.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FFDx0APPxPANEL.ForeColor = System.Drawing.Color.White
        Me.FFDx0APPxPANEL.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.FFDx0APPxPANEL.Location = New System.Drawing.Point(0, 0)
        Me.FFDx0APPxPANEL.Name = "FFDx0APPxPANEL"
        Me.FFDx0APPxPANEL.ShadowDecoration.BorderRadius = 5
        Me.FFDx0APPxPANEL.ShadowDecoration.Color = System.Drawing.Color.Orange
        Me.FFDx0APPxPANEL.ShadowDecoration.Depth = 15
        Me.FFDx0APPxPANEL.ShadowDecoration.Enabled = True
        Me.FFDx0APPxPANEL.ShadowDecoration.Parent = Me.FFDx0APPxPANEL
        Me.FFDx0APPxPANEL.Size = New System.Drawing.Size(1280, 720)
        Me.FFDx0APPxPANEL.TabIndex = 0
        '
        'FFDx0PANELCONTROLS
        '
        Me.FFDx0PANELCONTROLS.Controls.Add(Me.FFDx0APPTITLE)
        Me.FFDx0PANELCONTROLS.Controls.Add(Me.FFDx1MINIMIZEAPP)
        Me.FFDx0PANELCONTROLS.Controls.Add(Me.FFDx1CLOSEAPP)
        Me.FFDx0PANELCONTROLS.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.FFDx0PANELCONTROLS.Location = New System.Drawing.Point(20, 20)
        Me.FFDx0PANELCONTROLS.Name = "FFDx0PANELCONTROLS"
        Me.FFDx0PANELCONTROLS.ShadowDecoration.Parent = Me.FFDx0PANELCONTROLS
        Me.FFDx0PANELCONTROLS.Size = New System.Drawing.Size(1240, 40)
        Me.FFDx0PANELCONTROLS.TabIndex = 0
        '
        'FFDx1CLOSEAPP
        '
        Me.FFDx1CLOSEAPP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FFDx1CLOSEAPP.Animated = True
        Me.FFDx1CLOSEAPP.BackColor = System.Drawing.Color.Transparent
        Me.FFDx1CLOSEAPP.BorderRadius = 5
        Me.FFDx1CLOSEAPP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FFDx1CLOSEAPP.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.FFDx1CLOSEAPP.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.FFDx1CLOSEAPP.HoverState.IconColor = System.Drawing.Color.Red
        Me.FFDx1CLOSEAPP.HoverState.Parent = Me.FFDx1CLOSEAPP
        Me.FFDx1CLOSEAPP.IconColor = System.Drawing.Color.Orange
        Me.FFDx1CLOSEAPP.Location = New System.Drawing.Point(1175, 5)
        Me.FFDx1CLOSEAPP.Name = "FFDx1CLOSEAPP"
        Me.FFDx1CLOSEAPP.PressedColor = System.Drawing.Color.Red
        Me.FFDx1CLOSEAPP.PressedDepth = 10
        Me.FFDx1CLOSEAPP.ShadowDecoration.Parent = Me.FFDx1CLOSEAPP
        Me.FFDx1CLOSEAPP.Size = New System.Drawing.Size(60, 30)
        Me.FFDx1CLOSEAPP.TabIndex = 1
        Me.FFDx1CLOSEAPP.UseTransparentBackground = True
        '
        'FFDx1MINIMIZEAPP
        '
        Me.FFDx1MINIMIZEAPP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FFDx1MINIMIZEAPP.Animated = True
        Me.FFDx1MINIMIZEAPP.BackColor = System.Drawing.Color.Transparent
        Me.FFDx1MINIMIZEAPP.BorderRadius = 5
        Me.FFDx1MINIMIZEAPP.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.FFDx1MINIMIZEAPP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FFDx1MINIMIZEAPP.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.FFDx1MINIMIZEAPP.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.FFDx1MINIMIZEAPP.HoverState.IconColor = System.Drawing.Color.Orange
        Me.FFDx1MINIMIZEAPP.HoverState.Parent = Me.FFDx1MINIMIZEAPP
        Me.FFDx1MINIMIZEAPP.IconColor = System.Drawing.Color.Orange
        Me.FFDx1MINIMIZEAPP.Location = New System.Drawing.Point(1115, 5)
        Me.FFDx1MINIMIZEAPP.Name = "FFDx1MINIMIZEAPP"
        Me.FFDx1MINIMIZEAPP.PressedColor = System.Drawing.Color.Orange
        Me.FFDx1MINIMIZEAPP.PressedDepth = 10
        Me.FFDx1MINIMIZEAPP.ShadowDecoration.Parent = Me.FFDx1MINIMIZEAPP
        Me.FFDx1MINIMIZEAPP.Size = New System.Drawing.Size(60, 30)
        Me.FFDx1MINIMIZEAPP.TabIndex = 2
        Me.FFDx1MINIMIZEAPP.UseTransparentBackground = True
        '
        'FFDx0APPTITLE
        '
        Me.FFDx0APPTITLE.AutoSize = True
        Me.FFDx0APPTITLE.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FFDx0APPTITLE.Location = New System.Drawing.Point(20, 10)
        Me.FFDx0APPTITLE.Name = "FFDx0APPTITLE"
        Me.FFDx0APPTITLE.Size = New System.Drawing.Size(134, 19)
        Me.FFDx0APPTITLE.TabIndex = 3
        Me.FFDx0APPTITLE.Text = "F F D - D O W N L O A D S"
        '
        'FFDx0SPLITBOX
        '
        Me.FFDx0SPLITBOX.BackColor = System.Drawing.Color.Transparent
        Me.FFDx0SPLITBOX.FillColor = System.Drawing.Color.Orange
        Me.FFDx0SPLITBOX.Location = New System.Drawing.Point(20, 100)
        Me.FFDx0SPLITBOX.Name = "FFDx0SPLITBOX"
        Me.FFDx0SPLITBOX.ShadowDecoration.Color = System.Drawing.Color.Orange
        Me.FFDx0SPLITBOX.ShadowDecoration.Depth = 10
        Me.FFDx0SPLITBOX.ShadowDecoration.Enabled = True
        Me.FFDx0SPLITBOX.ShadowDecoration.Parent = Me.FFDx0SPLITBOX
        Me.FFDx0SPLITBOX.Size = New System.Drawing.Size(1240, 3)
        Me.FFDx0SPLITBOX.TabIndex = 1
        Me.FFDx0SPLITBOX.TabStop = False
        Me.FFDx0SPLITBOX.UseTransparentBackground = True
        '
        'FFDx0CREATEDOWNLOADTITLE
        '
        Me.FFDx0CREATEDOWNLOADTITLE.AutoSize = True
        Me.FFDx0CREATEDOWNLOADTITLE.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 20.0!)
        Me.FFDx0CREATEDOWNLOADTITLE.Location = New System.Drawing.Point(20, 160)
        Me.FFDx0CREATEDOWNLOADTITLE.Name = "FFDx0CREATEDOWNLOADTITLE"
        Me.FFDx0CREATEDOWNLOADTITLE.Size = New System.Drawing.Size(179, 33)
        Me.FFDx0CREATEDOWNLOADTITLE.TabIndex = 4
        Me.FFDx0CREATEDOWNLOADTITLE.Text = "D O W N L O A D S : "
        '
        'FFDx0DOWNLOADSPANEL
        '
        Me.FFDx0DOWNLOADSPANEL.BackColor = System.Drawing.Color.Transparent
        Me.FFDx0DOWNLOADSPANEL.BorderColor = System.Drawing.Color.Orange
        Me.FFDx0DOWNLOADSPANEL.BorderRadius = 5
        Me.FFDx0DOWNLOADSPANEL.Controls.Add(Me.FFDx0DOWNLOADURL)
        Me.FFDx0DOWNLOADSPANEL.Controls.Add(Me.FFDx0CREATEDOWNLOAD)
        Me.FFDx0DOWNLOADSPANEL.Controls.Add(Me.FFDx0QUEDL)
        Me.FFDx0DOWNLOADSPANEL.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.FFDx0DOWNLOADSPANEL.Location = New System.Drawing.Point(20, 240)
        Me.FFDx0DOWNLOADSPANEL.Name = "FFDx0DOWNLOADSPANEL"
        Me.FFDx0DOWNLOADSPANEL.ShadowDecoration.Parent = Me.FFDx0DOWNLOADSPANEL
        Me.FFDx0DOWNLOADSPANEL.Size = New System.Drawing.Size(1240, 460)
        Me.FFDx0DOWNLOADSPANEL.TabIndex = 5
        Me.FFDx0DOWNLOADSPANEL.UseTransparentBackground = True
        '
        'FFDx0QUEDL
        '
        Me.FFDx0QUEDL.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.FFDx0QUEDL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FFDx0QUEDL.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.FFDx0QUEDL.ForeColor = System.Drawing.Color.White
        Me.FFDx0QUEDL.FormattingEnabled = True
        Me.FFDx0QUEDL.ItemHeight = 19
        Me.FFDx0QUEDL.Location = New System.Drawing.Point(20, 180)
        Me.FFDx0QUEDL.Name = "FFDx0QUEDL"
        Me.FFDx0QUEDL.Size = New System.Drawing.Size(1200, 95)
        Me.FFDx0QUEDL.TabIndex = 0
        '
        'FFDx0CREATEDOWNLOAD
        '
        Me.FFDx0CREATEDOWNLOAD.Animated = True
        Me.FFDx0CREATEDOWNLOAD.BorderColor = System.Drawing.Color.Peru
        Me.FFDx0CREATEDOWNLOAD.BorderRadius = 5
        Me.FFDx0CREATEDOWNLOAD.BorderThickness = 1
        Me.FFDx0CREATEDOWNLOAD.CheckedState.Parent = Me.FFDx0CREATEDOWNLOAD
        Me.FFDx0CREATEDOWNLOAD.CustomImages.Parent = Me.FFDx0CREATEDOWNLOAD
        Me.FFDx0CREATEDOWNLOAD.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.FFDx0CREATEDOWNLOAD.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.FFDx0CREATEDOWNLOAD.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 14.0!)
        Me.FFDx0CREATEDOWNLOAD.ForeColor = System.Drawing.Color.White
        Me.FFDx0CREATEDOWNLOAD.HoverState.BorderColor = System.Drawing.Color.Orange
        Me.FFDx0CREATEDOWNLOAD.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.FFDx0CREATEDOWNLOAD.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FFDx0CREATEDOWNLOAD.HoverState.Parent = Me.FFDx0CREATEDOWNLOAD
        Me.FFDx0CREATEDOWNLOAD.Location = New System.Drawing.Point(20, 400)
        Me.FFDx0CREATEDOWNLOAD.Name = "FFDx0CREATEDOWNLOAD"
        Me.FFDx0CREATEDOWNLOAD.ShadowDecoration.BorderRadius = 7
        Me.FFDx0CREATEDOWNLOAD.ShadowDecoration.Color = System.Drawing.Color.Orange
        Me.FFDx0CREATEDOWNLOAD.ShadowDecoration.Depth = 10
        Me.FFDx0CREATEDOWNLOAD.ShadowDecoration.Enabled = True
        Me.FFDx0CREATEDOWNLOAD.ShadowDecoration.Parent = Me.FFDx0CREATEDOWNLOAD
        Me.FFDx0CREATEDOWNLOAD.Size = New System.Drawing.Size(1200, 45)
        Me.FFDx0CREATEDOWNLOAD.TabIndex = 1
        Me.FFDx0CREATEDOWNLOAD.Text = "C R E A T E  D O W N L O A D"
        Me.FFDx0CREATEDOWNLOAD.UseTransparentBackground = True
        '
        'FFDx0DOWNLOADURL
        '
        Me.FFDx0DOWNLOADURL.Animated = True
        Me.FFDx0DOWNLOADURL.BorderColor = System.Drawing.Color.Peru
        Me.FFDx0DOWNLOADURL.BorderRadius = 5
        Me.FFDx0DOWNLOADURL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FFDx0DOWNLOADURL.DefaultText = ""
        Me.FFDx0DOWNLOADURL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FFDx0DOWNLOADURL.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FFDx0DOWNLOADURL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FFDx0DOWNLOADURL.DisabledState.Parent = Me.FFDx0DOWNLOADURL
        Me.FFDx0DOWNLOADURL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FFDx0DOWNLOADURL.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.FFDx0DOWNLOADURL.FocusedState.BorderColor = System.Drawing.Color.Orange
        Me.FFDx0DOWNLOADURL.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.FFDx0DOWNLOADURL.FocusedState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.FFDx0DOWNLOADURL.FocusedState.Parent = Me.FFDx0DOWNLOADURL
        Me.FFDx0DOWNLOADURL.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 12.0!)
        Me.FFDx0DOWNLOADURL.ForeColor = System.Drawing.Color.White
        Me.FFDx0DOWNLOADURL.HoverState.BorderColor = System.Drawing.Color.Orange
        Me.FFDx0DOWNLOADURL.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.FFDx0DOWNLOADURL.HoverState.Parent = Me.FFDx0DOWNLOADURL
        Me.FFDx0DOWNLOADURL.HoverState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue
        Me.FFDx0DOWNLOADURL.Location = New System.Drawing.Point(20, 320)
        Me.FFDx0DOWNLOADURL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FFDx0DOWNLOADURL.Name = "FFDx0DOWNLOADURL"
        Me.FFDx0DOWNLOADURL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FFDx0DOWNLOADURL.PlaceholderText = "D O W N L O A D  U R L"
        Me.FFDx0DOWNLOADURL.SelectedText = ""
        Me.FFDx0DOWNLOADURL.ShadowDecoration.Parent = Me.FFDx0DOWNLOADURL
        Me.FFDx0DOWNLOADURL.Size = New System.Drawing.Size(1200, 46)
        Me.FFDx0DOWNLOADURL.TabIndex = 6
        Me.FFDx0DOWNLOADURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FFDx0MApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.FFDx0APPxPANEL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FFDx0MApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FFD | Downloads."
        Me.FFDx0APPxPANEL.ResumeLayout(False)
        Me.FFDx0APPxPANEL.PerformLayout()
        Me.FFDx0PANELCONTROLS.ResumeLayout(False)
        Me.FFDx0PANELCONTROLS.PerformLayout()
        CType(Me.FFDx0SPLITBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FFDx0DOWNLOADSPANEL.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FFDx0SHADOW As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents FFDx0DRAG As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents FFDx0APPxPANEL As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents FFDx0PANELCONTROLS As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents FFDx1CLOSEAPP As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents FFDx1MINIMIZEAPP As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents FFDx0APPTITLE As Label
    Friend WithEvents FFDx0SPLITBOX As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents FFDx0CREATEDOWNLOADTITLE As Label
    Friend WithEvents FFDx0DOWNLOADSPANEL As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents FFDx0QUEDL As ListBox
    Friend WithEvents FFDx0CREATEDOWNLOAD As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents FFDx0DOWNLOADURL As Guna.UI2.WinForms.Guna2TextBox
End Class
