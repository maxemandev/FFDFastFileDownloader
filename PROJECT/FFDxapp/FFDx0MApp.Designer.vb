﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FFDx0MApp))
        Me.FFDx0SHADOW = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.FFDx0DRAG = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.FFDx0APPxPANEL = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.FFDx0DOWNLOADSPANEL = New Guna.UI2.WinForms.Guna2Panel()
        Me.FFDx0DOWNLOADPATH = New Guna.UI2.WinForms.Guna2TextBox()
        Me.FFDx0DOWNLOADURL = New Guna.UI2.WinForms.Guna2TextBox()
        Me.FFDx0CREATEDOWNLOAD = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.FFDx0CREATEDOWNLOADTITLE = New System.Windows.Forms.Label()
        Me.FFDx0SPLITBOX = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.FFDx0PANELCONTROLS = New Guna.UI2.WinForms.Guna2Panel()
        Me.FFDx0APPTITLE = New System.Windows.Forms.Label()
        Me.FFDx1MINIMIZEAPP = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.FFDx1CLOSEAPP = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.FFDx0LOCALDLPATH = New System.Windows.Forms.FolderBrowserDialog()
        Me.FFDx0DOWNLOADNAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.FFDx0DOWNLOADPROGRESS = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.FFDx0DOWNLOADLABEL = New System.Windows.Forms.TextBox()
        Me.FDDx0DONETITLE = New System.Windows.Forms.Label()
        Me.FDDx9APPICONNOTIFY = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.FDDx9NOTIPAINT = New Guna.UI2.WinForms.Guna2NotificationPaint(Me.components)
        Me.FDDx9CONTEXTMENU = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADMINxFDDxPROCESS = New System.Diagnostics.Process()
        Me.FFDx0APPxPANEL.SuspendLayout()
        Me.FFDx0DOWNLOADSPANEL.SuspendLayout()
        CType(Me.FFDx0SPLITBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FFDx0PANELCONTROLS.SuspendLayout()
        Me.FDDx9CONTEXTMENU.SuspendLayout()
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
        'FFDx0DOWNLOADSPANEL
        '
        Me.FFDx0DOWNLOADSPANEL.BackColor = System.Drawing.Color.Transparent
        Me.FFDx0DOWNLOADSPANEL.BorderColor = System.Drawing.Color.Orange
        Me.FFDx0DOWNLOADSPANEL.BorderRadius = 5
        Me.FFDx0DOWNLOADSPANEL.Controls.Add(Me.FDDx0DONETITLE)
        Me.FFDx0DOWNLOADSPANEL.Controls.Add(Me.FFDx0DOWNLOADLABEL)
        Me.FFDx0DOWNLOADSPANEL.Controls.Add(Me.FFDx0DOWNLOADPROGRESS)
        Me.FFDx0DOWNLOADSPANEL.Controls.Add(Me.FFDx0DOWNLOADNAME)
        Me.FFDx0DOWNLOADSPANEL.Controls.Add(Me.FFDx0DOWNLOADPATH)
        Me.FFDx0DOWNLOADSPANEL.Controls.Add(Me.FFDx0DOWNLOADURL)
        Me.FFDx0DOWNLOADSPANEL.Controls.Add(Me.FFDx0CREATEDOWNLOAD)
        Me.FFDx0DOWNLOADSPANEL.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.FFDx0DOWNLOADSPANEL.Location = New System.Drawing.Point(20, 240)
        Me.FFDx0DOWNLOADSPANEL.Name = "FFDx0DOWNLOADSPANEL"
        Me.FFDx0DOWNLOADSPANEL.ShadowDecoration.Parent = Me.FFDx0DOWNLOADSPANEL
        Me.FFDx0DOWNLOADSPANEL.Size = New System.Drawing.Size(1240, 460)
        Me.FFDx0DOWNLOADSPANEL.TabIndex = 5
        Me.FFDx0DOWNLOADSPANEL.UseTransparentBackground = True
        '
        'FFDx0DOWNLOADPATH
        '
        Me.FFDx0DOWNLOADPATH.Animated = True
        Me.FFDx0DOWNLOADPATH.BorderColor = System.Drawing.Color.Peru
        Me.FFDx0DOWNLOADPATH.BorderRadius = 5
        Me.FFDx0DOWNLOADPATH.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FFDx0DOWNLOADPATH.DefaultText = ""
        Me.FFDx0DOWNLOADPATH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FFDx0DOWNLOADPATH.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FFDx0DOWNLOADPATH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FFDx0DOWNLOADPATH.DisabledState.Parent = Me.FFDx0DOWNLOADPATH
        Me.FFDx0DOWNLOADPATH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FFDx0DOWNLOADPATH.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.FFDx0DOWNLOADPATH.FocusedState.BorderColor = System.Drawing.Color.Orange
        Me.FFDx0DOWNLOADPATH.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.FFDx0DOWNLOADPATH.FocusedState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.FFDx0DOWNLOADPATH.FocusedState.Parent = Me.FFDx0DOWNLOADPATH
        Me.FFDx0DOWNLOADPATH.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 12.0!)
        Me.FFDx0DOWNLOADPATH.ForeColor = System.Drawing.Color.White
        Me.FFDx0DOWNLOADPATH.HoverState.BorderColor = System.Drawing.Color.Orange
        Me.FFDx0DOWNLOADPATH.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.FFDx0DOWNLOADPATH.HoverState.Parent = Me.FFDx0DOWNLOADPATH
        Me.FFDx0DOWNLOADPATH.HoverState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue
        Me.FFDx0DOWNLOADPATH.Location = New System.Drawing.Point(20, 80)
        Me.FFDx0DOWNLOADPATH.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FFDx0DOWNLOADPATH.Name = "FFDx0DOWNLOADPATH"
        Me.FFDx0DOWNLOADPATH.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FFDx0DOWNLOADPATH.PlaceholderText = "D O W N L O A D  P A T H"
        Me.FFDx0DOWNLOADPATH.SelectedText = ""
        Me.FFDx0DOWNLOADPATH.ShadowDecoration.Parent = Me.FFDx0DOWNLOADPATH
        Me.FFDx0DOWNLOADPATH.Size = New System.Drawing.Size(1200, 46)
        Me.FFDx0DOWNLOADPATH.TabIndex = 7
        Me.FFDx0DOWNLOADPATH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.FFDx0DOWNLOADURL.Location = New System.Drawing.Point(20, 20)
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
        'FFDx0CREATEDOWNLOAD
        '
        Me.FFDx0CREATEDOWNLOAD.Animated = True
        Me.FFDx0CREATEDOWNLOAD.BackColor = System.Drawing.Color.Transparent
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
        Me.FFDx0CREATEDOWNLOAD.Location = New System.Drawing.Point(20, 200)
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
        'FFDx0LOCALDLPATH
        '
        Me.FFDx0LOCALDLPATH.Description = "Select the path where the download should end up."
        '
        'FFDx0DOWNLOADNAME
        '
        Me.FFDx0DOWNLOADNAME.Animated = True
        Me.FFDx0DOWNLOADNAME.BorderColor = System.Drawing.Color.Peru
        Me.FFDx0DOWNLOADNAME.BorderRadius = 5
        Me.FFDx0DOWNLOADNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FFDx0DOWNLOADNAME.DefaultText = ""
        Me.FFDx0DOWNLOADNAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FFDx0DOWNLOADNAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FFDx0DOWNLOADNAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FFDx0DOWNLOADNAME.DisabledState.Parent = Me.FFDx0DOWNLOADNAME
        Me.FFDx0DOWNLOADNAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FFDx0DOWNLOADNAME.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.FFDx0DOWNLOADNAME.FocusedState.BorderColor = System.Drawing.Color.Orange
        Me.FFDx0DOWNLOADNAME.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.FFDx0DOWNLOADNAME.FocusedState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.FFDx0DOWNLOADNAME.FocusedState.Parent = Me.FFDx0DOWNLOADNAME
        Me.FFDx0DOWNLOADNAME.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 12.0!)
        Me.FFDx0DOWNLOADNAME.ForeColor = System.Drawing.Color.White
        Me.FFDx0DOWNLOADNAME.HoverState.BorderColor = System.Drawing.Color.Orange
        Me.FFDx0DOWNLOADNAME.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.FFDx0DOWNLOADNAME.HoverState.Parent = Me.FFDx0DOWNLOADNAME
        Me.FFDx0DOWNLOADNAME.HoverState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue
        Me.FFDx0DOWNLOADNAME.Location = New System.Drawing.Point(20, 140)
        Me.FFDx0DOWNLOADNAME.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FFDx0DOWNLOADNAME.Name = "FFDx0DOWNLOADNAME"
        Me.FFDx0DOWNLOADNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FFDx0DOWNLOADNAME.PlaceholderText = "D O W N L O A D  N A M E"
        Me.FFDx0DOWNLOADNAME.SelectedText = ""
        Me.FFDx0DOWNLOADNAME.ShadowDecoration.Parent = Me.FFDx0DOWNLOADNAME
        Me.FFDx0DOWNLOADNAME.Size = New System.Drawing.Size(1200, 46)
        Me.FFDx0DOWNLOADNAME.TabIndex = 8
        Me.FFDx0DOWNLOADNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FFDx0DOWNLOADPROGRESS
        '
        Me.FFDx0DOWNLOADPROGRESS.BorderRadius = 5
        Me.FFDx0DOWNLOADPROGRESS.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.FFDx0DOWNLOADPROGRESS.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.FFDx0DOWNLOADPROGRESS.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.FFDx0DOWNLOADPROGRESS.Location = New System.Drawing.Point(20, 400)
        Me.FFDx0DOWNLOADPROGRESS.Name = "FFDx0DOWNLOADPROGRESS"
        Me.FFDx0DOWNLOADPROGRESS.ProgressColor = System.Drawing.Color.Peru
        Me.FFDx0DOWNLOADPROGRESS.ProgressColor2 = System.Drawing.Color.Orange
        Me.FFDx0DOWNLOADPROGRESS.ShadowDecoration.Parent = Me.FFDx0DOWNLOADPROGRESS
        Me.FFDx0DOWNLOADPROGRESS.ShowPercentage = True
        Me.FFDx0DOWNLOADPROGRESS.Size = New System.Drawing.Size(1200, 30)
        Me.FFDx0DOWNLOADPROGRESS.TabIndex = 9
        Me.FFDx0DOWNLOADPROGRESS.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.FFDx0DOWNLOADPROGRESS.UseTransparentBackground = True
        '
        'FFDx0DOWNLOADLABEL
        '
        Me.FFDx0DOWNLOADLABEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.FFDx0DOWNLOADLABEL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FFDx0DOWNLOADLABEL.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.FFDx0DOWNLOADLABEL.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 14.0!)
        Me.FFDx0DOWNLOADLABEL.ForeColor = System.Drawing.Color.White
        Me.FFDx0DOWNLOADLABEL.Location = New System.Drawing.Point(20, 360)
        Me.FFDx0DOWNLOADLABEL.Name = "FFDx0DOWNLOADLABEL"
        Me.FFDx0DOWNLOADLABEL.ReadOnly = True
        Me.FFDx0DOWNLOADLABEL.Size = New System.Drawing.Size(1200, 23)
        Me.FFDx0DOWNLOADLABEL.TabIndex = 6
        Me.FFDx0DOWNLOADLABEL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FDDx0DONETITLE
        '
        Me.FDDx0DONETITLE.AutoSize = True
        Me.FDDx0DONETITLE.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 20.0!)
        Me.FDDx0DONETITLE.Location = New System.Drawing.Point(20, 280)
        Me.FDDx0DONETITLE.Name = "FDDx0DONETITLE"
        Me.FDDx0DONETITLE.Size = New System.Drawing.Size(86, 33)
        Me.FDDx0DONETITLE.TabIndex = 6
        Me.FDDx0DONETITLE.Text = "D O N E. "
        Me.FDDx0DONETITLE.Visible = False
        '
        'FDDx9APPICONNOTIFY
        '
        Me.FDDx9APPICONNOTIFY.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.FDDx9APPICONNOTIFY.BalloonTipText = "FDD - Running."
        Me.FDDx9APPICONNOTIFY.BalloonTipTitle = "FDD - Running."
        Me.FDDx9APPICONNOTIFY.ContextMenuStrip = Me.FDDx9CONTEXTMENU
        Me.FDDx9APPICONNOTIFY.Icon = CType(resources.GetObject("FDDx9APPICONNOTIFY.Icon"), System.Drawing.Icon)
        Me.FDDx9APPICONNOTIFY.Text = "FDD - Running."
        Me.FDDx9APPICONNOTIFY.Visible = True
        '
        'FDDx9NOTIPAINT
        '
        Me.FDDx9NOTIPAINT.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'FDDx9CONTEXTMENU
        '
        Me.FDDx9CONTEXTMENU.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EXITToolStripMenuItem})
        Me.FDDx9CONTEXTMENU.Name = "FDDx9CONTEXTMENU"
        Me.FDDx9CONTEXTMENU.Size = New System.Drawing.Size(105, 26)
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.EXITToolStripMenuItem.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXITToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.EXITToolStripMenuItem.Text = "E X I T"
        '
        'ADMINxFDDxPROCESS
        '
        Me.ADMINxFDDxPROCESS.StartInfo.Domain = ""
        Me.ADMINxFDDxPROCESS.StartInfo.LoadUserProfile = False
        Me.ADMINxFDDxPROCESS.StartInfo.Password = Nothing
        Me.ADMINxFDDxPROCESS.StartInfo.StandardErrorEncoding = Nothing
        Me.ADMINxFDDxPROCESS.StartInfo.StandardOutputEncoding = Nothing
        Me.ADMINxFDDxPROCESS.StartInfo.UserName = ""
        Me.ADMINxFDDxPROCESS.SynchronizingObject = Me
        '
        'FFDx0MApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.FFDx0APPxPANEL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FFDx0MApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FFD | Downloads."
        Me.FFDx0APPxPANEL.ResumeLayout(False)
        Me.FFDx0APPxPANEL.PerformLayout()
        Me.FFDx0DOWNLOADSPANEL.ResumeLayout(False)
        Me.FFDx0DOWNLOADSPANEL.PerformLayout()
        CType(Me.FFDx0SPLITBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FFDx0PANELCONTROLS.ResumeLayout(False)
        Me.FFDx0PANELCONTROLS.PerformLayout()
        Me.FDDx9CONTEXTMENU.ResumeLayout(False)
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
    Friend WithEvents FFDx0CREATEDOWNLOAD As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents FFDx0DOWNLOADURL As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FFDx0LOCALDLPATH As FolderBrowserDialog
    Friend WithEvents FFDx0DOWNLOADPATH As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FFDx0DOWNLOADNAME As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FFDx0DOWNLOADPROGRESS As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents FFDx0DOWNLOADLABEL As TextBox
    Friend WithEvents FDDx0DONETITLE As Label
    Friend WithEvents FDDx9APPICONNOTIFY As NotifyIcon
    Friend WithEvents FDDx9NOTIPAINT As Guna.UI2.WinForms.Guna2NotificationPaint
    Friend WithEvents FDDx9CONTEXTMENU As ContextMenuStrip
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ADMINxFDDxPROCESS As Process
End Class
