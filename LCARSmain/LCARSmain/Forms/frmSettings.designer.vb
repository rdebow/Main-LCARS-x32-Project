<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
    Inherits LCARS.LCARSForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.tbTitle = New LCARS.Controls.TextButton
        Me.sbExitMyComp = New LCARS.Controls.StandardButton
        Me.ltcSettings = New LCARS.Controls.x32TabControl
        Me.tabScreenSpecific = New LCARS.Controls.x32TabPage
        Me.pnlScreenSpecific = New System.Windows.Forms.Panel
        Me.pnlMainScreen = New System.Windows.Forms.Panel
        Me.gridScreens = New LCARS.Controls.ButtonGrid
        Me.tglAutoHide = New LCARS.Controls.ToggleButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.FlatButton1 = New LCARS.Controls.FlatButton
        Me.pnlLanguage = New System.Windows.Forms.Panel
        Me.txtLanguagePreview = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.sbUseLanguage = New LCARS.Controls.StandardButton
        Me.Label13 = New System.Windows.Forms.Label
        Me.lstLanguages = New LCARS.Controls.LCARSList
        Me.pnlWallpaper = New System.Windows.Forms.Panel
        Me.lstSizeMode = New LCARS.Controls.LCARSList
        Me.picWallpaper = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.sbChangeWallpaper = New LCARS.Controls.StandardButton
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.sbDefault = New LCARS.Controls.StandardButton
        Me.fbBack = New LCARS.Controls.FlatButton
        Me.fbLanguage = New LCARS.Controls.FlatButton
        Me.fbMainScreen = New LCARS.Controls.FlatButton
        Me.fbWallpaper = New LCARS.Controls.FlatButton
        Me.lblClickScreen = New System.Windows.Forms.Label
        Me.pnlScreens = New System.Windows.Forms.Panel
        Me.LcarsTabPage1 = New LCARS.Controls.x32TabPage
        Me.sbSoundTest = New LCARS.Controls.StandardButton
        Me.lstSoundResources = New LCARS.Controls.LCARSList
        Me.lblSoundResource = New LCARS.Controls.LCARSLabel
        Me.sbSoundEnabled = New LCARS.Controls.StandardButton
        Me.lblSoundName = New LCARS.Controls.LCARSLabel
        Me.lstSounds = New LCARS.Controls.LCARSList
        Me.fbChangeSound = New LCARS.Controls.FlatButton
        Me.txtSoundPath = New System.Windows.Forms.Label
        Me.LcarsTabPage2 = New LCARS.Controls.x32TabPage
        Me.tglDates = New LCARS.Controls.ToggleButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.sbUseScheme = New LCARS.Controls.StandardButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.lstColors = New LCARS.Controls.LCARSList
        Me.pnlPreview = New System.Windows.Forms.Panel
        Me.ComplexButton2 = New LCARS.Controls.ComplexButton
        Me.StandardButton5 = New LCARS.Controls.StandardButton
        Me.StandardButton3 = New LCARS.Controls.StandardButton
        Me.StandardButton2 = New LCARS.Controls.StandardButton
        Me.FlatButton12 = New LCARS.Controls.FlatButton
        Me.Elbow6 = New LCARS.Controls.Elbow
        Me.FlatButton11 = New LCARS.Controls.FlatButton
        Me.StandardButton1 = New LCARS.Controls.StandardButton
        Me.Elbow5 = New LCARS.Controls.Elbow
        Me.LcarsTabPage3 = New LCARS.Controls.x32TabPage
        Me.hpbLCARS = New LCARS.Controls.HalfPillButton
        Me.hpbExplorer = New LCARS.Controls.HalfPillButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.fbShellSelect = New LCARS.Controls.FlatButton
        Me.LcarsTabPage5 = New LCARS.Controls.x32TabPage
        Me.tglVoiceTimeout = New LCARS.Controls.ToggleButton
        Me.sbExternal = New LCARS.Controls.StandardButton
        Me.sbInternal = New LCARS.Controls.StandardButton
        Me.fbSaveChanges = New LCARS.Controls.FlatButton
        Me.txtCommandTimeout = New System.Windows.Forms.TextBox
        Me.txtLanguageCode = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.tglVoice = New LCARS.Controls.ToggleButton
        Me.pnlExternal = New System.Windows.Forms.Panel
        Me.pnlAdd = New System.Windows.Forms.Panel
        Me.txtCommandName = New System.Windows.Forms.TextBox
        Me.txtCommandPath = New System.Windows.Forms.TextBox
        Me.sbOK = New LCARS.Controls.StandardButton
        Me.sbCancel = New LCARS.Controls.StandardButton
        Me.Label18 = New System.Windows.Forms.Label
        Me.lblError = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.sbEdit = New LCARS.Controls.StandardButton
        Me.sbAdd = New LCARS.Controls.StandardButton
        Me.sbRemove = New LCARS.Controls.StandardButton
        Me.lstExternalCommands = New LCARS.Controls.LCARSList
        Me.lstInternalCommands = New LCARS.Controls.LCARSList
        Me.pnlInternal = New System.Windows.Forms.Panel
        Me.txtAlias = New System.Windows.Forms.TextBox
        Me.lblIntCommandName = New System.Windows.Forms.Label
        Me.lblAlias = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.Label
        Me.tabAlerts = New LCARS.Controls.x32TabPage
        Me.hpAlertFiller = New LCARS.Controls.HalfPillButton
        Me.lblAlertSound = New System.Windows.Forms.Label
        Me.lblID = New System.Windows.Forms.Label
        Me.lblAlertName = New System.Windows.Forms.Label
        Me.fbDeleteAlert = New LCARS.Controls.FlatButton
        Me.hpAddAlert = New LCARS.Controls.HalfPillButton
        Me.fbAlertColor = New LCARS.Controls.FlatButton
        Me.fbBrowseSound = New LCARS.Controls.FlatButton
        Me.lstAlerts = New LCARS.Controls.LCARSList
        Me.tabUpdate = New LCARS.Controls.x32TabPage
        Me.fbChannelDot = New LCARS.Controls.FlatButton
        Me.txtCustom = New System.Windows.Forms.TextBox
        Me.hpCustom = New LCARS.Controls.HalfPillButton
        Me.hpExperimental = New LCARS.Controls.HalfPillButton
        Me.hpRelease = New LCARS.Controls.HalfPillButton
        Me.sbCheck = New LCARS.Controls.StandardButton
        Me.tglAutoUpdates = New LCARS.Controls.ToggleButton
        Me.Label19 = New System.Windows.Forms.Label
        Me.lblVersion = New System.Windows.Forms.Label
        Me.tabExperimental = New LCARS.Controls.x32TabPage
        Me.tglDDE = New LCARS.Controls.ToggleButton
        Me.tglDebug = New LCARS.Controls.ToggleButton
        Me.lblDDESwitch = New System.Windows.Forms.Label
        Me.lblDebugSwitch = New System.Windows.Forms.Label
        Me.lblWarning = New System.Windows.Forms.Label
        Me.tabAbout = New LCARS.Controls.x32TabPage
        Me.lblAbout = New System.Windows.Forms.Label
        Me.ltcSettings.SuspendLayout()
        Me.tabScreenSpecific.SuspendLayout()
        Me.pnlScreenSpecific.SuspendLayout()
        Me.pnlMainScreen.SuspendLayout()
        Me.pnlLanguage.SuspendLayout()
        Me.pnlWallpaper.SuspendLayout()
        CType(Me.picWallpaper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LcarsTabPage1.SuspendLayout()
        Me.LcarsTabPage2.SuspendLayout()
        Me.pnlPreview.SuspendLayout()
        Me.LcarsTabPage3.SuspendLayout()
        Me.LcarsTabPage5.SuspendLayout()
        Me.pnlExternal.SuspendLayout()
        Me.pnlAdd.SuspendLayout()
        Me.pnlInternal.SuspendLayout()
        Me.tabAlerts.SuspendLayout()
        Me.tabUpdate.SuspendLayout()
        Me.tabExperimental.SuspendLayout()
        Me.tabAbout.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbTitle
        '
        Me.tbTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTitle.ButtonText = "SETTINGS"
        Me.tbTitle.ButtonTextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.tbTitle.ButtonTextHeight = 32
        Me.tbTitle.Location = New System.Drawing.Point(3, 4)
        Me.tbTitle.Name = "tbTitle"
        Me.tbTitle.Size = New System.Drawing.Size(756, 32)
        Me.tbTitle.TabIndex = 61
        Me.tbTitle.Text = "SETTINGS"
        '
        'sbExitMyComp
        '
        Me.sbExitMyComp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sbExitMyComp.ButtonStyle = LCARS.Controls.StandardButton.LCARSbuttonStyles.RoundedSquare
        Me.sbExitMyComp.ButtonText = "X"
        Me.sbExitMyComp.ButtonTextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.sbExitMyComp.Color = LCARS.LCARScolorStyles.FunctionOffline
        Me.sbExitMyComp.Location = New System.Drawing.Point(765, 4)
        Me.sbExitMyComp.Name = "sbExitMyComp"
        Me.sbExitMyComp.Size = New System.Drawing.Size(33, 32)
        Me.sbExitMyComp.TabIndex = 57
        Me.sbExitMyComp.Text = "X"
        '
        'ltcSettings
        '
        Me.ltcSettings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ltcSettings.BackColor = System.Drawing.Color.Black
        Me.ltcSettings.Controls.Add(Me.tabScreenSpecific)
        Me.ltcSettings.Controls.Add(Me.tabAbout)
        Me.ltcSettings.Controls.Add(Me.tabExperimental)
        Me.ltcSettings.Controls.Add(Me.tabUpdate)
        Me.ltcSettings.Controls.Add(Me.tabAlerts)
        Me.ltcSettings.Controls.Add(Me.LcarsTabPage5)
        Me.ltcSettings.Controls.Add(Me.LcarsTabPage3)
        Me.ltcSettings.Controls.Add(Me.LcarsTabPage2)
        Me.ltcSettings.Controls.Add(Me.LcarsTabPage1)
        Me.ltcSettings.Location = New System.Drawing.Point(12, 41)
        Me.ltcSettings.Name = "ltcSettings"
        Me.ltcSettings.SelectedTab = Me.tabScreenSpecific
        Me.ltcSettings.Size = New System.Drawing.Size(776, 547)
        Me.ltcSettings.TabIndex = 60
        Me.ltcSettings.TabPages.Add(Me.LcarsTabPage1)
        Me.ltcSettings.TabPages.Add(Me.LcarsTabPage2)
        Me.ltcSettings.TabPages.Add(Me.tabScreenSpecific)
        Me.ltcSettings.TabPages.Add(Me.LcarsTabPage3)
        Me.ltcSettings.TabPages.Add(Me.LcarsTabPage5)
        Me.ltcSettings.TabPages.Add(Me.tabAlerts)
        Me.ltcSettings.TabPages.Add(Me.tabUpdate)
        Me.ltcSettings.TabPages.Add(Me.tabExperimental)
        Me.ltcSettings.TabPages.Add(Me.tabAbout)
        Me.ltcSettings.Text = "LcarStabControl1"
        '
        'tabScreenSpecific
        '
        Me.tabScreenSpecific.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabScreenSpecific.BackColor = System.Drawing.Color.Black
        Me.tabScreenSpecific.Color = LCARS.LCARScolorStyles.MiscFunction
        Me.tabScreenSpecific.Controls.Add(Me.pnlScreenSpecific)
        Me.tabScreenSpecific.Controls.Add(Me.lblClickScreen)
        Me.tabScreenSpecific.Controls.Add(Me.pnlScreens)
        Me.tabScreenSpecific.Location = New System.Drawing.Point(0, 26)
        Me.tabScreenSpecific.Name = "tabScreenSpecific"
        Me.tabScreenSpecific.Size = New System.Drawing.Size(666, 521)
        Me.tabScreenSpecific.TabIndex = 18
        Me.tabScreenSpecific.Text = "SCREEN-SPECIFIC"
        '
        'pnlScreenSpecific
        '
        Me.pnlScreenSpecific.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlScreenSpecific.Controls.Add(Me.pnlWallpaper)
        Me.pnlScreenSpecific.Controls.Add(Me.pnlMainScreen)
        Me.pnlScreenSpecific.Controls.Add(Me.FlatButton1)
        Me.pnlScreenSpecific.Controls.Add(Me.pnlLanguage)
        Me.pnlScreenSpecific.Controls.Add(Me.fbBack)
        Me.pnlScreenSpecific.Controls.Add(Me.fbLanguage)
        Me.pnlScreenSpecific.Controls.Add(Me.fbMainScreen)
        Me.pnlScreenSpecific.Controls.Add(Me.fbWallpaper)
        Me.pnlScreenSpecific.Location = New System.Drawing.Point(0, 0)
        Me.pnlScreenSpecific.Name = "pnlScreenSpecific"
        Me.pnlScreenSpecific.Size = New System.Drawing.Size(662, 514)
        Me.pnlScreenSpecific.TabIndex = 3
        Me.pnlScreenSpecific.Visible = False
        '
        'pnlMainScreen
        '
        Me.pnlMainScreen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMainScreen.Controls.Add(Me.gridScreens)
        Me.pnlMainScreen.Controls.Add(Me.tglAutoHide)
        Me.pnlMainScreen.Controls.Add(Me.Label4)
        Me.pnlMainScreen.Location = New System.Drawing.Point(112, 3)
        Me.pnlMainScreen.Name = "pnlMainScreen"
        Me.pnlMainScreen.Size = New System.Drawing.Size(547, 452)
        Me.pnlMainScreen.TabIndex = 2
        Me.pnlMainScreen.Visible = False
        '
        'gridScreens
        '
        Me.gridScreens.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridScreens.ControlAddingDirection = LCARS.Controls.ButtonGrid.ControlDirection.Horizontal
        Me.gridScreens.ControlSize = New System.Drawing.Size(210, 150)
        Me.gridScreens.Location = New System.Drawing.Point(0, 35)
        Me.gridScreens.MinimumSize = New System.Drawing.Size(215, 155)
        Me.gridScreens.Name = "gridScreens"
        Me.gridScreens.Size = New System.Drawing.Size(544, 267)
        Me.gridScreens.TabIndex = 52
        Me.gridScreens.Text = "ButtonGrid1"
        '
        'tglAutoHide
        '
        Me.tglAutoHide.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tglAutoHide.ButtonText = "AUTOHIDE"
        Me.tglAutoHide.ButtonTextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.tglAutoHide.Lit = False
        Me.tglAutoHide.Location = New System.Drawing.Point(33, 317)
        Me.tglAutoHide.Name = "tglAutoHide"
        Me.tglAutoHide.SideText = "OFF"
        Me.tglAutoHide.Size = New System.Drawing.Size(174, 30)
        Me.tglAutoHide.State = False
        Me.tglAutoHide.TabIndex = 51
        Me.tglAutoHide.Text = "AUTOHIDE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("LCARS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 24)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Main Screen:"
        '
        'FlatButton1
        '
        Me.FlatButton1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FlatButton1.ButtonText = ""
        Me.FlatButton1.Color = LCARS.LCARScolorStyles.StaticTan
        Me.FlatButton1.Location = New System.Drawing.Point(0, 116)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Size = New System.Drawing.Size(102, 356)
        Me.FlatButton1.TabIndex = 3
        '
        'pnlLanguage
        '
        Me.pnlLanguage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlLanguage.Controls.Add(Me.txtLanguagePreview)
        Me.pnlLanguage.Controls.Add(Me.Label14)
        Me.pnlLanguage.Controls.Add(Me.sbUseLanguage)
        Me.pnlLanguage.Controls.Add(Me.Label13)
        Me.pnlLanguage.Controls.Add(Me.lstLanguages)
        Me.pnlLanguage.Location = New System.Drawing.Point(112, 3)
        Me.pnlLanguage.Name = "pnlLanguage"
        Me.pnlLanguage.Size = New System.Drawing.Size(547, 452)
        Me.pnlLanguage.TabIndex = 2
        Me.pnlLanguage.Visible = False
        '
        'txtLanguagePreview
        '
        Me.txtLanguagePreview.AcceptsReturn = True
        Me.txtLanguagePreview.BackColor = System.Drawing.Color.Black
        Me.txtLanguagePreview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLanguagePreview.Font = New System.Drawing.Font("LCARS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLanguagePreview.ForeColor = System.Drawing.Color.Orange
        Me.txtLanguagePreview.Location = New System.Drawing.Point(15, 44)
        Me.txtLanguagePreview.Multiline = True
        Me.txtLanguagePreview.Name = "txtLanguagePreview"
        Me.txtLanguagePreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLanguagePreview.Size = New System.Drawing.Size(303, 154)
        Me.txtLanguagePreview.TabIndex = 37
        Me.txtLanguagePreview.Text = "Test Text"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("LCARS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Orange
        Me.Label14.Location = New System.Drawing.Point(8, 201)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(212, 32)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Choose a Language:"
        '
        'sbUseLanguage
        '
        Me.sbUseLanguage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.sbUseLanguage.ButtonText = "USE LANGUAGE"
        Me.sbUseLanguage.ButtonTextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.sbUseLanguage.Color = LCARS.LCARScolorStyles.PrimaryFunction
        Me.sbUseLanguage.Location = New System.Drawing.Point(235, 404)
        Me.sbUseLanguage.Name = "sbUseLanguage"
        Me.sbUseLanguage.Size = New System.Drawing.Size(110, 28)
        Me.sbUseLanguage.TabIndex = 35
        Me.sbUseLanguage.Text = "USE LANGUAGE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("LCARS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Orange
        Me.Label13.Location = New System.Drawing.Point(8, 1)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 37)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Language Files"
        '
        'lstLanguages
        '
        Me.lstLanguages.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstLanguages.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstLanguages.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lstLanguages.FormattingEnabled = True
        Me.lstLanguages.ItemHeight = 28
        Me.lstLanguages.Location = New System.Drawing.Point(15, 236)
        Me.lstLanguages.Name = "lstLanguages"
        Me.lstLanguages.Size = New System.Drawing.Size(330, 140)
        Me.lstLanguages.TabIndex = 34
        Me.lstLanguages.TabStops = New Single(-1) {}
        '
        'pnlWallpaper
        '
        Me.pnlWallpaper.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlWallpaper.Controls.Add(Me.lstSizeMode)
        Me.pnlWallpaper.Controls.Add(Me.picWallpaper)
        Me.pnlWallpaper.Controls.Add(Me.Label5)
        Me.pnlWallpaper.Controls.Add(Me.sbChangeWallpaper)
        Me.pnlWallpaper.Controls.Add(Me.PictureBox2)
        Me.pnlWallpaper.Controls.Add(Me.sbDefault)
        Me.pnlWallpaper.Location = New System.Drawing.Point(112, 3)
        Me.pnlWallpaper.Name = "pnlWallpaper"
        Me.pnlWallpaper.Size = New System.Drawing.Size(547, 452)
        Me.pnlWallpaper.TabIndex = 2
        '
        'lstSizeMode
        '
        Me.lstSizeMode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstSizeMode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstSizeMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lstSizeMode.FormattingEnabled = True
        Me.lstSizeMode.ItemHeight = 28
        Me.lstSizeMode.Items.AddRange(New Object() {"ZOOM", "STRETCH", "CENTER", "TILE"})
        Me.lstSizeMode.Location = New System.Drawing.Point(207, 160)
        Me.lstSizeMode.Name = "lstSizeMode"
        Me.lstSizeMode.Size = New System.Drawing.Size(149, 168)
        Me.lstSizeMode.TabIndex = 44
        Me.lstSizeMode.TabStops = New Single(-1) {}
        '
        'picWallpaper
        '
        Me.picWallpaper.Image = Global.LCARSmain.My.Resources.Resources.federationLogo
        Me.picWallpaper.Location = New System.Drawing.Point(54, 100)
        Me.picWallpaper.Name = "picWallpaper"
        Me.picWallpaper.Size = New System.Drawing.Size(126, 104)
        Me.picWallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWallpaper.TabIndex = 39
        Me.picWallpaper.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("LCARS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Orange
        Me.Label5.Location = New System.Drawing.Point(43, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(493, 30)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "CURRENT WALLPAPER:"
        '
        'sbChangeWallpaper
        '
        Me.sbChangeWallpaper.ButtonText = "CHANGE WALLPAPER"
        Me.sbChangeWallpaper.ButtonTextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.sbChangeWallpaper.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.sbChangeWallpaper.Location = New System.Drawing.Point(207, 92)
        Me.sbChangeWallpaper.Name = "sbChangeWallpaper"
        Me.sbChangeWallpaper.Size = New System.Drawing.Size(149, 28)
        Me.sbChangeWallpaper.TabIndex = 42
        Me.sbChangeWallpaper.Text = "CHANGE WALLPAPER"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(33, 89)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(168, 127)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 41
        Me.PictureBox2.TabStop = False
        '
        'sbDefault
        '
        Me.sbDefault.ButtonText = "USE FEDERATION LOGO"
        Me.sbDefault.ButtonTextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.sbDefault.Location = New System.Drawing.Point(207, 126)
        Me.sbDefault.Name = "sbDefault"
        Me.sbDefault.Size = New System.Drawing.Size(149, 28)
        Me.sbDefault.TabIndex = 43
        Me.sbDefault.Text = "USE FEDERATION LOGO"
        '
        'fbBack
        '
        Me.fbBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.fbBack.ButtonText = "BACK"
        Me.fbBack.Color = LCARS.LCARScolorStyles.NavigationFunction
        Me.fbBack.Location = New System.Drawing.Point(0, 478)
        Me.fbBack.Name = "fbBack"
        Me.fbBack.Size = New System.Drawing.Size(103, 33)
        Me.fbBack.TabIndex = 1
        Me.fbBack.Text = "BACK"
        '
        'fbLanguage
        '
        Me.fbLanguage.ButtonText = "LANGUAGE FILE"
        Me.fbLanguage.Location = New System.Drawing.Point(-1, 77)
        Me.fbLanguage.Name = "fbLanguage"
        Me.fbLanguage.Size = New System.Drawing.Size(103, 33)
        Me.fbLanguage.TabIndex = 1
        Me.fbLanguage.Text = "LANGUAGE FILE"
        '
        'fbMainScreen
        '
        Me.fbMainScreen.ButtonText = "MAIN SCREEN"
        Me.fbMainScreen.Location = New System.Drawing.Point(0, 38)
        Me.fbMainScreen.Name = "fbMainScreen"
        Me.fbMainScreen.Size = New System.Drawing.Size(103, 33)
        Me.fbMainScreen.TabIndex = 1
        Me.fbMainScreen.Text = "MAIN SCREEN"
        '
        'fbWallpaper
        '
        Me.fbWallpaper.ButtonText = "WALLPAPER"
        Me.fbWallpaper.Location = New System.Drawing.Point(0, -1)
        Me.fbWallpaper.Name = "fbWallpaper"
        Me.fbWallpaper.RedAlert = LCARS.LCARSalert.White
        Me.fbWallpaper.Size = New System.Drawing.Size(103, 33)
        Me.fbWallpaper.TabIndex = 1
        Me.fbWallpaper.Text = "WALLPAPER"
        '
        'lblClickScreen
        '
        Me.lblClickScreen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblClickScreen.AutoSize = True
        Me.lblClickScreen.Font = New System.Drawing.Font("LCARS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClickScreen.Location = New System.Drawing.Point(0, 481)
        Me.lblClickScreen.Name = "lblClickScreen"
        Me.lblClickScreen.Size = New System.Drawing.Size(218, 28)
        Me.lblClickScreen.TabIndex = 2
        Me.lblClickScreen.Text = "Click a screen to adjust its settings."
        '
        'pnlScreens
        '
        Me.pnlScreens.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlScreens.Location = New System.Drawing.Point(5, 4)
        Me.pnlScreens.Name = "pnlScreens"
        Me.pnlScreens.Size = New System.Drawing.Size(657, 471)
        Me.pnlScreens.TabIndex = 1
        '
        'LcarsTabPage1
        '
        Me.LcarsTabPage1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LcarsTabPage1.BackColor = System.Drawing.Color.Black
        Me.LcarsTabPage1.Color = LCARS.LCARScolorStyles.MiscFunction
        Me.LcarsTabPage1.Controls.Add(Me.sbSoundTest)
        Me.LcarsTabPage1.Controls.Add(Me.lstSoundResources)
        Me.LcarsTabPage1.Controls.Add(Me.lblSoundResource)
        Me.LcarsTabPage1.Controls.Add(Me.sbSoundEnabled)
        Me.LcarsTabPage1.Controls.Add(Me.lblSoundName)
        Me.LcarsTabPage1.Controls.Add(Me.lstSounds)
        Me.LcarsTabPage1.Controls.Add(Me.fbChangeSound)
        Me.LcarsTabPage1.Controls.Add(Me.txtSoundPath)
        Me.LcarsTabPage1.Location = New System.Drawing.Point(0, 26)
        Me.LcarsTabPage1.Name = "LcarsTabPage1"
        Me.LcarsTabPage1.Size = New System.Drawing.Size(666, 521)
        Me.LcarsTabPage1.TabIndex = 3
        Me.LcarsTabPage1.Text = "SOUNDS"
        '
        'sbSoundTest
        '
        Me.sbSoundTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.sbSoundTest.ButtonText = "TEST SOUND"
        Me.sbSoundTest.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.sbSoundTest.Color = LCARS.LCARScolorStyles.PrimaryFunction
        Me.sbSoundTest.Location = New System.Drawing.Point(211, 269)
        Me.sbSoundTest.Name = "sbSoundTest"
        Me.sbSoundTest.Size = New System.Drawing.Size(94, 28)
        Me.sbSoundTest.TabIndex = 9
        Me.sbSoundTest.Text = "TEST SOUND"
        '
        'lstSoundResources
        '
        Me.lstSoundResources.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstSoundResources.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lstSoundResources.FormattingEnabled = True
        Me.lstSoundResources.ItemHeight = 25
        Me.lstSoundResources.Location = New System.Drawing.Point(91, 304)
        Me.lstSoundResources.Name = "lstSoundResources"
        Me.lstSoundResources.Size = New System.Drawing.Size(222, 152)
        Me.lstSoundResources.TabIndex = 8
        Me.lstSoundResources.TabStops = New Single(-1) {}
        '
        'lblSoundResource
        '
        Me.lblSoundResource.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSoundResource.AutoSize = True
        Me.lblSoundResource.Color = LCARS.LCARScolorStyles.Orange
        Me.lblSoundResource.Location = New System.Drawing.Point(3, 303)
        Me.lblSoundResource.Name = "lblSoundResource"
        Me.lblSoundResource.Size = New System.Drawing.Size(73, 28)
        Me.lblSoundResource.TabIndex = 7
        Me.lblSoundResource.Text = "Resource:"
        Me.lblSoundResource.TextHeight = 18
        '
        'sbSoundEnabled
        '
        Me.sbSoundEnabled.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.sbSoundEnabled.ButtonText = "ENABLED"
        Me.sbSoundEnabled.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.sbSoundEnabled.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.sbSoundEnabled.Location = New System.Drawing.Point(95, 269)
        Me.sbSoundEnabled.Name = "sbSoundEnabled"
        Me.sbSoundEnabled.Size = New System.Drawing.Size(110, 28)
        Me.sbSoundEnabled.TabIndex = 6
        Me.sbSoundEnabled.Text = "ENABLED"
        '
        'lblSoundName
        '
        Me.lblSoundName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSoundName.AutoSize = True
        Me.lblSoundName.Color = LCARS.LCARScolorStyles.Orange
        Me.lblSoundName.Location = New System.Drawing.Point(0, 269)
        Me.lblSoundName.Name = "lblSoundName"
        Me.lblSoundName.Size = New System.Drawing.Size(84, 28)
        Me.lblSoundName.TabIndex = 5
        Me.lblSoundName.Text = "Sound Name"
        Me.lblSoundName.TextHeight = 18
        '
        'lstSounds
        '
        Me.lstSounds.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstSounds.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lstSounds.FormattingEnabled = True
        Me.lstSounds.ItemHeight = 25
        Me.lstSounds.Location = New System.Drawing.Point(4, 14)
        Me.lstSounds.Name = "lstSounds"
        Me.lstSounds.Size = New System.Drawing.Size(650, 252)
        Me.lstSounds.TabIndex = 4
        Me.lstSounds.TabStops = New Single() {150.0!, 70.0!}
        '
        'fbChangeSound
        '
        Me.fbChangeSound.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.fbChangeSound.ButtonText = "CHANGE"
        Me.fbChangeSound.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.fbChangeSound.Location = New System.Drawing.Point(20, 470)
        Me.fbChangeSound.Name = "fbChangeSound"
        Me.fbChangeSound.Size = New System.Drawing.Size(64, 31)
        Me.fbChangeSound.TabIndex = 3
        Me.fbChangeSound.Text = "CHANGE"
        '
        'txtSoundPath
        '
        Me.txtSoundPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSoundPath.AutoSize = True
        Me.txtSoundPath.Font = New System.Drawing.Font("LCARS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoundPath.ForeColor = System.Drawing.Color.Orange
        Me.txtSoundPath.Location = New System.Drawing.Point(90, 470)
        Me.txtSoundPath.Name = "txtSoundPath"
        Me.txtSoundPath.Size = New System.Drawing.Size(115, 28)
        Me.txtSoundPath.TabIndex = 0
        Me.txtSoundPath.Text = "Button Sound Path"
        '
        'LcarsTabPage2
        '
        Me.LcarsTabPage2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LcarsTabPage2.BackColor = System.Drawing.Color.Black
        Me.LcarsTabPage2.Color = LCARS.LCARScolorStyles.MiscFunction
        Me.LcarsTabPage2.Controls.Add(Me.tglDates)
        Me.LcarsTabPage2.Controls.Add(Me.Label3)
        Me.LcarsTabPage2.Controls.Add(Me.sbUseScheme)
        Me.LcarsTabPage2.Controls.Add(Me.Label2)
        Me.LcarsTabPage2.Controls.Add(Me.lstColors)
        Me.LcarsTabPage2.Controls.Add(Me.pnlPreview)
        Me.LcarsTabPage2.Location = New System.Drawing.Point(0, 26)
        Me.LcarsTabPage2.Name = "LcarsTabPage2"
        Me.LcarsTabPage2.Size = New System.Drawing.Size(666, 521)
        Me.LcarsTabPage2.TabIndex = 5
        Me.LcarsTabPage2.Text = "APPEARANCE"
        '
        'tglDates
        '
        Me.tglDates.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tglDates.ButtonText = "USE STARDATE"
        Me.tglDates.Location = New System.Drawing.Point(28, 473)
        Me.tglDates.Name = "tglDates"
        Me.tglDates.SideText = "On"
        Me.tglDates.Size = New System.Drawing.Size(200, 34)
        Me.tglDates.TabIndex = 31
        Me.tglDates.Text = "USE STARDATE"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("LCARS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(3, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 32)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Choose a Scheme:"
        '
        'sbUseScheme
        '
        Me.sbUseScheme.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.sbUseScheme.ButtonText = "USE SCHEME"
        Me.sbUseScheme.ButtonTextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.sbUseScheme.Color = LCARS.LCARScolorStyles.PrimaryFunction
        Me.sbUseScheme.Location = New System.Drawing.Point(223, 427)
        Me.sbUseScheme.Name = "sbUseScheme"
        Me.sbUseScheme.Size = New System.Drawing.Size(110, 28)
        Me.sbUseScheme.TabIndex = 29
        Me.sbUseScheme.Text = "USE SCHEME"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("LCARS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(3, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(328, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Color Schemes"
        '
        'lstColors
        '
        Me.lstColors.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstColors.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstColors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lstColors.FormattingEnabled = True
        Me.lstColors.ItemHeight = 28
        Me.lstColors.Location = New System.Drawing.Point(3, 262)
        Me.lstColors.Name = "lstColors"
        Me.lstColors.Size = New System.Drawing.Size(330, 140)
        Me.lstColors.TabIndex = 4
        Me.lstColors.TabStops = New Single(-1) {}
        '
        'pnlPreview
        '
        Me.pnlPreview.Controls.Add(Me.ComplexButton2)
        Me.pnlPreview.Controls.Add(Me.StandardButton5)
        Me.pnlPreview.Controls.Add(Me.StandardButton3)
        Me.pnlPreview.Controls.Add(Me.StandardButton2)
        Me.pnlPreview.Controls.Add(Me.FlatButton12)
        Me.pnlPreview.Controls.Add(Me.Elbow6)
        Me.pnlPreview.Controls.Add(Me.FlatButton11)
        Me.pnlPreview.Controls.Add(Me.StandardButton1)
        Me.pnlPreview.Controls.Add(Me.Elbow5)
        Me.pnlPreview.Location = New System.Drawing.Point(3, 67)
        Me.pnlPreview.Name = "pnlPreview"
        Me.pnlPreview.Size = New System.Drawing.Size(330, 148)
        Me.pnlPreview.TabIndex = 3
        '
        'ComplexButton2
        '
        Me.ComplexButton2.Beeping = True
        Me.ComplexButton2.ButtonText = "SYSTEM"
        Me.ComplexButton2.Clickable = False
        Me.ComplexButton2.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.ComplexButton2.Location = New System.Drawing.Point(88, 84)
        Me.ComplexButton2.Name = "ComplexButton2"
        Me.ComplexButton2.SideText = "47"
        Me.ComplexButton2.SideTextColor = LCARS.LCARScolorStyles.StaticBlue
        Me.ComplexButton2.Size = New System.Drawing.Size(177, 25)
        Me.ComplexButton2.TabIndex = 9
        Me.ComplexButton2.Text = "SYSTEM"
        '
        'StandardButton5
        '
        Me.StandardButton5.Beeping = True
        Me.StandardButton5.ButtonText = "NAVIGATION"
        Me.StandardButton5.ButtonTextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.StandardButton5.Clickable = False
        Me.StandardButton5.Color = LCARS.LCARScolorStyles.NavigationFunction
        Me.StandardButton5.Location = New System.Drawing.Point(159, 3)
        Me.StandardButton5.Name = "StandardButton5"
        Me.StandardButton5.Size = New System.Drawing.Size(94, 26)
        Me.StandardButton5.TabIndex = 8
        Me.StandardButton5.Text = "NAVIGATION"
        '
        'StandardButton3
        '
        Me.StandardButton3.Beeping = True
        Me.StandardButton3.ButtonText = "CRITICAL"
        Me.StandardButton3.ButtonTextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.StandardButton3.Clickable = False
        Me.StandardButton3.Color = LCARS.LCARScolorStyles.CriticalFunction
        Me.StandardButton3.Location = New System.Drawing.Point(142, 116)
        Me.StandardButton3.Name = "StandardButton3"
        Me.StandardButton3.Size = New System.Drawing.Size(83, 26)
        Me.StandardButton3.TabIndex = 6
        Me.StandardButton3.Text = "CRITICAL"
        '
        'StandardButton2
        '
        Me.StandardButton2.Beeping = True
        Me.StandardButton2.ButtonText = "PRIMARY"
        Me.StandardButton2.ButtonTextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.StandardButton2.Clickable = False
        Me.StandardButton2.Color = LCARS.LCARScolorStyles.PrimaryFunction
        Me.StandardButton2.Location = New System.Drawing.Point(231, 116)
        Me.StandardButton2.Name = "StandardButton2"
        Me.StandardButton2.Size = New System.Drawing.Size(88, 26)
        Me.StandardButton2.TabIndex = 5
        Me.StandardButton2.Text = "PRIMARY"
        '
        'FlatButton12
        '
        Me.FlatButton12.Beeping = True
        Me.FlatButton12.ButtonText = "UNAVAILABLE"
        Me.FlatButton12.ButtonTextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.FlatButton12.Clickable = False
        Me.FlatButton12.Color = LCARS.LCARScolorStyles.FunctionUnavailable
        Me.FlatButton12.Location = New System.Drawing.Point(69, 6)
        Me.FlatButton12.Name = "FlatButton12"
        Me.FlatButton12.Size = New System.Drawing.Size(84, 26)
        Me.FlatButton12.TabIndex = 4
        Me.FlatButton12.Text = "UNAVAILABLE"
        '
        'Elbow6
        '
        Me.Elbow6.Beeping = True
        Me.Elbow6.ButtonHeight = 10
        Me.Elbow6.ButtonText = "DISPLAY"
        Me.Elbow6.ButtonWidth = 50
        Me.Elbow6.Clickable = False
        Me.Elbow6.Color = LCARS.LCARScolorStyles.LCARSDisplayOnly
        Me.Elbow6.ElbowStyle = LCARS.Controls.Elbow.LCARSelbowStyles.LowerRight
        Me.Elbow6.Location = New System.Drawing.Point(3, 6)
        Me.Elbow6.Name = "Elbow6"
        Me.Elbow6.Size = New System.Drawing.Size(316, 49)
        Me.Elbow6.TabIndex = 3
        Me.Elbow6.Text = "DISPLAY"
        '
        'FlatButton11
        '
        Me.FlatButton11.Beeping = True
        Me.FlatButton11.ButtonText = "STATIC"
        Me.FlatButton11.Clickable = False
        Me.FlatButton11.Color = LCARS.LCARScolorStyles.StaticTan
        Me.FlatButton11.Location = New System.Drawing.Point(3, 116)
        Me.FlatButton11.Name = "FlatButton11"
        Me.FlatButton11.Size = New System.Drawing.Size(50, 26)
        Me.FlatButton11.TabIndex = 2
        Me.FlatButton11.Text = "STATIC"
        '
        'StandardButton1
        '
        Me.StandardButton1.Beeping = True
        Me.StandardButton1.ButtonText = "MISC"
        Me.StandardButton1.ButtonTextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.StandardButton1.Clickable = False
        Me.StandardButton1.Location = New System.Drawing.Point(7, 83)
        Me.StandardButton1.Name = "StandardButton1"
        Me.StandardButton1.Size = New System.Drawing.Size(77, 26)
        Me.StandardButton1.TabIndex = 0
        Me.StandardButton1.Text = "MISC"
        '
        'Elbow5
        '
        Me.Elbow5.Beeping = True
        Me.Elbow5.ButtonHeight = 10
        Me.Elbow5.ButtonText = "STATIC"
        Me.Elbow5.ButtonTextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Elbow5.ButtonWidth = 50
        Me.Elbow5.Clickable = False
        Me.Elbow5.Color = LCARS.LCARScolorStyles.StaticTan
        Me.Elbow5.Location = New System.Drawing.Point(3, 61)
        Me.Elbow5.Name = "Elbow5"
        Me.Elbow5.Size = New System.Drawing.Size(316, 49)
        Me.Elbow5.TabIndex = 1
        Me.Elbow5.Text = "STATIC"
        '
        'LcarsTabPage3
        '
        Me.LcarsTabPage3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LcarsTabPage3.BackColor = System.Drawing.Color.Black
        Me.LcarsTabPage3.Color = LCARS.LCARScolorStyles.MiscFunction
        Me.LcarsTabPage3.Controls.Add(Me.hpbLCARS)
        Me.LcarsTabPage3.Controls.Add(Me.hpbExplorer)
        Me.LcarsTabPage3.Controls.Add(Me.Label6)
        Me.LcarsTabPage3.Controls.Add(Me.fbShellSelect)
        Me.LcarsTabPage3.Location = New System.Drawing.Point(0, 26)
        Me.LcarsTabPage3.Name = "LcarsTabPage3"
        Me.LcarsTabPage3.Size = New System.Drawing.Size(666, 521)
        Me.LcarsTabPage3.TabIndex = 6
        Me.LcarsTabPage3.Text = "STARTUP"
        '
        'hpbLCARS
        '
        Me.hpbLCARS.ButtonText = "LCARS X32"
        Me.hpbLCARS.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.hpbLCARS.Location = New System.Drawing.Point(36, 36)
        Me.hpbLCARS.Name = "hpbLCARS"
        Me.hpbLCARS.Size = New System.Drawing.Size(138, 30)
        Me.hpbLCARS.TabIndex = 40
        Me.hpbLCARS.Text = "LCARS X32"
        '
        'hpbExplorer
        '
        Me.hpbExplorer.ButtonText = "WINDOWS EXPLORER"
        Me.hpbExplorer.Color = LCARS.LCARScolorStyles.PrimaryFunction
        Me.hpbExplorer.Location = New System.Drawing.Point(36, 72)
        Me.hpbExplorer.Name = "hpbExplorer"
        Me.hpbExplorer.Size = New System.Drawing.Size(138, 30)
        Me.hpbExplorer.TabIndex = 41
        Me.hpbExplorer.Text = "WINDOWS EXPLORER"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("LCARS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 24)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Default Shell:"
        '
        'fbShellSelect
        '
        Me.fbShellSelect.ButtonText = ""
        Me.fbShellSelect.Clickable = False
        Me.fbShellSelect.Color = LCARS.LCARScolorStyles.CriticalFunction
        Me.fbShellSelect.Location = New System.Drawing.Point(0, 72)
        Me.fbShellSelect.Name = "fbShellSelect"
        Me.fbShellSelect.Size = New System.Drawing.Size(30, 30)
        Me.fbShellSelect.TabIndex = 42
        '
        'LcarsTabPage5
        '
        Me.LcarsTabPage5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LcarsTabPage5.BackColor = System.Drawing.Color.Black
        Me.LcarsTabPage5.Color = LCARS.LCARScolorStyles.MiscFunction
        Me.LcarsTabPage5.Controls.Add(Me.tglVoiceTimeout)
        Me.LcarsTabPage5.Controls.Add(Me.sbExternal)
        Me.LcarsTabPage5.Controls.Add(Me.sbInternal)
        Me.LcarsTabPage5.Controls.Add(Me.fbSaveChanges)
        Me.LcarsTabPage5.Controls.Add(Me.txtCommandTimeout)
        Me.LcarsTabPage5.Controls.Add(Me.txtLanguageCode)
        Me.LcarsTabPage5.Controls.Add(Me.Label15)
        Me.LcarsTabPage5.Controls.Add(Me.Label16)
        Me.LcarsTabPage5.Controls.Add(Me.tglVoice)
        Me.LcarsTabPage5.Controls.Add(Me.pnlExternal)
        Me.LcarsTabPage5.Controls.Add(Me.lstExternalCommands)
        Me.LcarsTabPage5.Controls.Add(Me.lstInternalCommands)
        Me.LcarsTabPage5.Controls.Add(Me.pnlInternal)
        Me.LcarsTabPage5.Location = New System.Drawing.Point(0, 26)
        Me.LcarsTabPage5.Name = "LcarsTabPage5"
        Me.LcarsTabPage5.Size = New System.Drawing.Size(666, 521)
        Me.LcarsTabPage5.TabIndex = 8
        Me.LcarsTabPage5.Text = "VOICE COMMANDS"
        '
        'tglVoiceTimeout
        '
        Me.tglVoiceTimeout.ButtonText = "TIMEOUT"
        Me.tglVoiceTimeout.Location = New System.Drawing.Point(31, 38)
        Me.tglVoiceTimeout.Name = "tglVoiceTimeout"
        Me.tglVoiceTimeout.SideText = "ON"
        Me.tglVoiceTimeout.Size = New System.Drawing.Size(197, 30)
        Me.tglVoiceTimeout.TabIndex = 11
        Me.tglVoiceTimeout.Text = "TIMEOUT"
        '
        'sbExternal
        '
        Me.sbExternal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sbExternal.ButtonText = "EXTERNAL COMMANDS"
        Me.sbExternal.ButtonTextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.sbExternal.Location = New System.Drawing.Point(518, 137)
        Me.sbExternal.Name = "sbExternal"
        Me.sbExternal.Size = New System.Drawing.Size(148, 34)
        Me.sbExternal.TabIndex = 9
        Me.sbExternal.Text = "EXTERNAL COMMANDS"
        '
        'sbInternal
        '
        Me.sbInternal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sbInternal.ButtonText = "INTERNAL COMMANDS"
        Me.sbInternal.ButtonTextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.sbInternal.Location = New System.Drawing.Point(516, 97)
        Me.sbInternal.Name = "sbInternal"
        Me.sbInternal.Size = New System.Drawing.Size(150, 33)
        Me.sbInternal.TabIndex = 9
        Me.sbInternal.Text = "INTERNAL COMMANDS"
        '
        'fbSaveChanges
        '
        Me.fbSaveChanges.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fbSaveChanges.ButtonText = "SAVE CHANGES"
        Me.fbSaveChanges.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.fbSaveChanges.Color = LCARS.LCARScolorStyles.PrimaryFunction
        Me.fbSaveChanges.Location = New System.Drawing.Point(577, 487)
        Me.fbSaveChanges.Name = "fbSaveChanges"
        Me.fbSaveChanges.Size = New System.Drawing.Size(86, 31)
        Me.fbSaveChanges.TabIndex = 6
        Me.fbSaveChanges.Text = "SAVE CHANGES"
        '
        'txtCommandTimeout
        '
        Me.txtCommandTimeout.BackColor = System.Drawing.Color.Black
        Me.txtCommandTimeout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCommandTimeout.Font = New System.Drawing.Font("LCARS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommandTimeout.ForeColor = System.Drawing.Color.Orange
        Me.txtCommandTimeout.Location = New System.Drawing.Point(343, 39)
        Me.txtCommandTimeout.Name = "txtCommandTimeout"
        Me.txtCommandTimeout.Size = New System.Drawing.Size(100, 31)
        Me.txtCommandTimeout.TabIndex = 5
        '
        'txtLanguageCode
        '
        Me.txtLanguageCode.BackColor = System.Drawing.Color.Black
        Me.txtLanguageCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLanguageCode.Font = New System.Drawing.Font("LCARS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLanguageCode.ForeColor = System.Drawing.Color.Orange
        Me.txtLanguageCode.Location = New System.Drawing.Point(343, 2)
        Me.txtLanguageCode.Name = "txtLanguageCode"
        Me.txtLanguageCode.Size = New System.Drawing.Size(100, 31)
        Me.txtLanguageCode.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("LCARS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Orange
        Me.Label15.Location = New System.Drawing.Point(229, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 28)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Timeout Interval:"
        '
        'Label16
        '
        Me.Label16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("LCARS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Orange
        Me.Label16.Location = New System.Drawing.Point(229, 4)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 28)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Language Code:"
        '
        'tglVoice
        '
        Me.tglVoice.ButtonText = "VOICE COMMANDS"
        Me.tglVoice.Lit = False
        Me.tglVoice.Location = New System.Drawing.Point(31, 3)
        Me.tglVoice.Name = "tglVoice"
        Me.tglVoice.SideText = "OFF"
        Me.tglVoice.Size = New System.Drawing.Size(197, 30)
        Me.tglVoice.State = False
        Me.tglVoice.TabIndex = 2
        Me.tglVoice.Text = "VOICE COMMANDS"
        '
        'pnlExternal
        '
        Me.pnlExternal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlExternal.Controls.Add(Me.pnlAdd)
        Me.pnlExternal.Controls.Add(Me.sbEdit)
        Me.pnlExternal.Controls.Add(Me.sbAdd)
        Me.pnlExternal.Controls.Add(Me.sbRemove)
        Me.pnlExternal.Location = New System.Drawing.Point(6, 372)
        Me.pnlExternal.Name = "pnlExternal"
        Me.pnlExternal.Size = New System.Drawing.Size(659, 109)
        Me.pnlExternal.TabIndex = 9
        Me.pnlExternal.Visible = False
        '
        'pnlAdd
        '
        Me.pnlAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAdd.Controls.Add(Me.txtCommandName)
        Me.pnlAdd.Controls.Add(Me.txtCommandPath)
        Me.pnlAdd.Controls.Add(Me.sbOK)
        Me.pnlAdd.Controls.Add(Me.sbCancel)
        Me.pnlAdd.Controls.Add(Me.Label18)
        Me.pnlAdd.Controls.Add(Me.lblError)
        Me.pnlAdd.Controls.Add(Me.Label17)
        Me.pnlAdd.Location = New System.Drawing.Point(94, 3)
        Me.pnlAdd.Name = "pnlAdd"
        Me.pnlAdd.Size = New System.Drawing.Size(565, 106)
        Me.pnlAdd.TabIndex = 3
        Me.pnlAdd.Visible = False
        '
        'txtCommandName
        '
        Me.txtCommandName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCommandName.BackColor = System.Drawing.Color.Black
        Me.txtCommandName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCommandName.Font = New System.Drawing.Font("LCARS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommandName.ForeColor = System.Drawing.Color.Orange
        Me.txtCommandName.Location = New System.Drawing.Point(109, 3)
        Me.txtCommandName.Name = "txtCommandName"
        Me.txtCommandName.Size = New System.Drawing.Size(453, 31)
        Me.txtCommandName.TabIndex = 11
        '
        'txtCommandPath
        '
        Me.txtCommandPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCommandPath.BackColor = System.Drawing.Color.Black
        Me.txtCommandPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCommandPath.Font = New System.Drawing.Font("LCARS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommandPath.ForeColor = System.Drawing.Color.Orange
        Me.txtCommandPath.Location = New System.Drawing.Point(109, 36)
        Me.txtCommandPath.Name = "txtCommandPath"
        Me.txtCommandPath.Size = New System.Drawing.Size(453, 31)
        Me.txtCommandPath.TabIndex = 12
        '
        'sbOK
        '
        Me.sbOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sbOK.ButtonText = "OK"
        Me.sbOK.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.sbOK.Color = LCARS.LCARScolorStyles.PrimaryFunction
        Me.sbOK.Location = New System.Drawing.Point(476, 73)
        Me.sbOK.Name = "sbOK"
        Me.sbOK.Size = New System.Drawing.Size(86, 30)
        Me.sbOK.TabIndex = 0
        Me.sbOK.Text = "OK"
        '
        'sbCancel
        '
        Me.sbCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sbCancel.ButtonText = "CANCEL"
        Me.sbCancel.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.sbCancel.Color = LCARS.LCARScolorStyles.CriticalFunction
        Me.sbCancel.Location = New System.Drawing.Point(384, 73)
        Me.sbCancel.Name = "sbCancel"
        Me.sbCancel.Size = New System.Drawing.Size(86, 30)
        Me.sbCancel.TabIndex = 0
        Me.sbCancel.Text = "CANCEL"
        '
        'Label18
        '
        Me.Label18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("LCARS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Orange
        Me.Label18.Location = New System.Drawing.Point(3, 35)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 28)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Path"
        '
        'lblError
        '
        Me.lblError.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("LCARS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Orange
        Me.lblError.Location = New System.Drawing.Point(3, 70)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(47, 28)
        Me.lblError.TabIndex = 4
        Me.lblError.Text = "Error"
        '
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("LCARS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Orange
        Me.Label17.Location = New System.Drawing.Point(3, 2)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(105, 28)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Command Name"
        '
        'sbEdit
        '
        Me.sbEdit.ButtonText = "EDIT"
        Me.sbEdit.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.sbEdit.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.sbEdit.Location = New System.Drawing.Point(0, 41)
        Me.sbEdit.Name = "sbEdit"
        Me.sbEdit.Size = New System.Drawing.Size(86, 30)
        Me.sbEdit.TabIndex = 2
        Me.sbEdit.Text = "EDIT"
        '
        'sbAdd
        '
        Me.sbAdd.ButtonText = "ADD"
        Me.sbAdd.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.sbAdd.Color = LCARS.LCARScolorStyles.PrimaryFunction
        Me.sbAdd.Location = New System.Drawing.Point(0, 5)
        Me.sbAdd.Name = "sbAdd"
        Me.sbAdd.Size = New System.Drawing.Size(86, 30)
        Me.sbAdd.TabIndex = 2
        Me.sbAdd.Text = "ADD"
        '
        'sbRemove
        '
        Me.sbRemove.ButtonText = "REMOVE"
        Me.sbRemove.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.sbRemove.Color = LCARS.LCARScolorStyles.FunctionOffline
        Me.sbRemove.Location = New System.Drawing.Point(0, 77)
        Me.sbRemove.Name = "sbRemove"
        Me.sbRemove.Size = New System.Drawing.Size(86, 30)
        Me.sbRemove.TabIndex = 1
        Me.sbRemove.Text = "REMOVE"
        '
        'lstExternalCommands
        '
        Me.lstExternalCommands.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstExternalCommands.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lstExternalCommands.FormattingEnabled = True
        Me.lstExternalCommands.ItemHeight = 28
        Me.lstExternalCommands.Location = New System.Drawing.Point(8, 84)
        Me.lstExternalCommands.Name = "lstExternalCommands"
        Me.lstExternalCommands.Size = New System.Drawing.Size(502, 282)
        Me.lstExternalCommands.TabIndex = 10
        Me.lstExternalCommands.TabStops = New Single(-1) {}
        Me.lstExternalCommands.Visible = False
        '
        'lstInternalCommands
        '
        Me.lstInternalCommands.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstInternalCommands.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lstInternalCommands.FormattingEnabled = True
        Me.lstInternalCommands.ItemHeight = 28
        Me.lstInternalCommands.Location = New System.Drawing.Point(8, 84)
        Me.lstInternalCommands.Name = "lstInternalCommands"
        Me.lstInternalCommands.Size = New System.Drawing.Size(502, 282)
        Me.lstInternalCommands.TabIndex = 7
        Me.lstInternalCommands.TabStops = New Single(-1) {}
        Me.lstInternalCommands.Visible = False
        '
        'pnlInternal
        '
        Me.pnlInternal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlInternal.Controls.Add(Me.txtAlias)
        Me.pnlInternal.Controls.Add(Me.lblIntCommandName)
        Me.pnlInternal.Controls.Add(Me.lblAlias)
        Me.pnlInternal.Controls.Add(Me.lblDescription)
        Me.pnlInternal.Location = New System.Drawing.Point(4, 372)
        Me.pnlInternal.Name = "pnlInternal"
        Me.pnlInternal.Size = New System.Drawing.Size(644, 106)
        Me.pnlInternal.TabIndex = 8
        Me.pnlInternal.Visible = False
        '
        'txtAlias
        '
        Me.txtAlias.BackColor = System.Drawing.Color.Black
        Me.txtAlias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlias.Font = New System.Drawing.Font("LCARS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlias.ForeColor = System.Drawing.Color.Orange
        Me.txtAlias.Location = New System.Drawing.Point(96, 36)
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(545, 31)
        Me.txtAlias.TabIndex = 11
        '
        'lblIntCommandName
        '
        Me.lblIntCommandName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIntCommandName.AutoSize = True
        Me.lblIntCommandName.Font = New System.Drawing.Font("LCARS", 16.0!)
        Me.lblIntCommandName.ForeColor = System.Drawing.Color.Orange
        Me.lblIntCommandName.Location = New System.Drawing.Point(3, 5)
        Me.lblIntCommandName.Name = "lblIntCommandName"
        Me.lblIntCommandName.Size = New System.Drawing.Size(98, 25)
        Me.lblIntCommandName.TabIndex = 12
        Me.lblIntCommandName.Text = "Command Name:"
        '
        'lblAlias
        '
        Me.lblAlias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAlias.AutoSize = True
        Me.lblAlias.Font = New System.Drawing.Font("LCARS", 16.0!)
        Me.lblAlias.ForeColor = System.Drawing.Color.Orange
        Me.lblAlias.Location = New System.Drawing.Point(3, 38)
        Me.lblAlias.Name = "lblAlias"
        Me.lblAlias.Size = New System.Drawing.Size(94, 25)
        Me.lblAlias.TabIndex = 11
        Me.lblAlias.Text = "Command Alias:"
        '
        'lblDescription
        '
        Me.lblDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("LCARS", 16.0!)
        Me.lblDescription.ForeColor = System.Drawing.Color.Orange
        Me.lblDescription.Location = New System.Drawing.Point(200, 5)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(74, 25)
        Me.lblDescription.TabIndex = 11
        Me.lblDescription.Text = "Description:"
        '
        'tabAlerts
        '
        Me.tabAlerts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabAlerts.BackColor = System.Drawing.Color.Black
        Me.tabAlerts.Color = LCARS.LCARScolorStyles.MiscFunction
        Me.tabAlerts.Controls.Add(Me.hpAlertFiller)
        Me.tabAlerts.Controls.Add(Me.lblAlertSound)
        Me.tabAlerts.Controls.Add(Me.lblID)
        Me.tabAlerts.Controls.Add(Me.lblAlertName)
        Me.tabAlerts.Controls.Add(Me.fbDeleteAlert)
        Me.tabAlerts.Controls.Add(Me.hpAddAlert)
        Me.tabAlerts.Controls.Add(Me.fbAlertColor)
        Me.tabAlerts.Controls.Add(Me.fbBrowseSound)
        Me.tabAlerts.Controls.Add(Me.lstAlerts)
        Me.tabAlerts.Location = New System.Drawing.Point(0, 26)
        Me.tabAlerts.Name = "tabAlerts"
        Me.tabAlerts.Size = New System.Drawing.Size(666, 521)
        Me.tabAlerts.TabIndex = 16
        Me.tabAlerts.Text = "ALERTS"
        '
        'hpAlertFiller
        '
        Me.hpAlertFiller.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hpAlertFiller.ButtonStyle = LCARS.Controls.HalfPillButton.LCARSbuttonStyles.PillLeft
        Me.hpAlertFiller.ButtonText = ""
        Me.hpAlertFiller.Clickable = False
        Me.hpAlertFiller.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.hpAlertFiller.Location = New System.Drawing.Point(0, 320)
        Me.hpAlertFiller.Name = "hpAlertFiller"
        Me.hpAlertFiller.Size = New System.Drawing.Size(469, 30)
        Me.hpAlertFiller.TabIndex = 7
        '
        'lblAlertSound
        '
        Me.lblAlertSound.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAlertSound.Font = New System.Drawing.Font("LCARS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlertSound.ForeColor = System.Drawing.Color.Orange
        Me.lblAlertSound.Location = New System.Drawing.Point(-6, 410)
        Me.lblAlertSound.Name = "lblAlertSound"
        Me.lblAlertSound.Size = New System.Drawing.Size(609, 28)
        Me.lblAlertSound.TabIndex = 6
        Me.lblAlertSound.Text = "Sound Path:"
        '
        'lblID
        '
        Me.lblID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("LCARS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.Orange
        Me.lblID.Location = New System.Drawing.Point(304, 353)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(52, 28)
        Me.lblID.TabIndex = 6
        Me.lblID.Text = "AlertID"
        '
        'lblAlertName
        '
        Me.lblAlertName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAlertName.AutoSize = True
        Me.lblAlertName.Font = New System.Drawing.Font("LCARS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlertName.ForeColor = System.Drawing.Color.Orange
        Me.lblAlertName.Location = New System.Drawing.Point(-5, 353)
        Me.lblAlertName.Name = "lblAlertName"
        Me.lblAlertName.Size = New System.Drawing.Size(73, 28)
        Me.lblAlertName.TabIndex = 6
        Me.lblAlertName.Text = "AlertName"
        '
        'fbDeleteAlert
        '
        Me.fbDeleteAlert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fbDeleteAlert.ButtonText = "DELETE"
        Me.fbDeleteAlert.Color = LCARS.LCARScolorStyles.FunctionOffline
        Me.fbDeleteAlert.Location = New System.Drawing.Point(475, 320)
        Me.fbDeleteAlert.Name = "fbDeleteAlert"
        Me.fbDeleteAlert.Size = New System.Drawing.Size(90, 30)
        Me.fbDeleteAlert.TabIndex = 5
        Me.fbDeleteAlert.Text = "DELETE"
        '
        'hpAddAlert
        '
        Me.hpAddAlert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hpAddAlert.ButtonText = "ADD"
        Me.hpAddAlert.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.hpAddAlert.Location = New System.Drawing.Point(571, 320)
        Me.hpAddAlert.Name = "hpAddAlert"
        Me.hpAddAlert.Size = New System.Drawing.Size(91, 30)
        Me.hpAddAlert.TabIndex = 4
        Me.hpAddAlert.Text = "ADD"
        '
        'fbAlertColor
        '
        Me.fbAlertColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.fbAlertColor.ButtonText = "#FF00FF"
        Me.fbAlertColor.Location = New System.Drawing.Point(76, 447)
        Me.fbAlertColor.Name = "fbAlertColor"
        Me.fbAlertColor.RedAlert = LCARS.LCARSalert.Custom
        Me.fbAlertColor.Size = New System.Drawing.Size(107, 28)
        Me.fbAlertColor.TabIndex = 3
        Me.fbAlertColor.Text = "#FF00FF"
        '
        'fbBrowseSound
        '
        Me.fbBrowseSound.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fbBrowseSound.ButtonText = "..."
        Me.fbBrowseSound.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.fbBrowseSound.Location = New System.Drawing.Point(608, 407)
        Me.fbBrowseSound.Name = "fbBrowseSound"
        Me.fbBrowseSound.Size = New System.Drawing.Size(54, 31)
        Me.fbBrowseSound.TabIndex = 2
        Me.fbBrowseSound.Text = "..."
        '
        'lstAlerts
        '
        Me.lstAlerts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstAlerts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstAlerts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lstAlerts.FormattingEnabled = True
        Me.lstAlerts.ItemHeight = 24
        Me.lstAlerts.Location = New System.Drawing.Point(0, 0)
        Me.lstAlerts.Name = "lstAlerts"
        Me.lstAlerts.Size = New System.Drawing.Size(650, 312)
        Me.lstAlerts.TabIndex = 0
        Me.lstAlerts.TabStops = New Single() {30.0!, 100.0!, 30.0!}
        '
        'tabUpdate
        '
        Me.tabUpdate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabUpdate.BackColor = System.Drawing.Color.Black
        Me.tabUpdate.Color = LCARS.LCARScolorStyles.MiscFunction
        Me.tabUpdate.Controls.Add(Me.fbChannelDot)
        Me.tabUpdate.Controls.Add(Me.txtCustom)
        Me.tabUpdate.Controls.Add(Me.hpCustom)
        Me.tabUpdate.Controls.Add(Me.hpExperimental)
        Me.tabUpdate.Controls.Add(Me.hpRelease)
        Me.tabUpdate.Controls.Add(Me.sbCheck)
        Me.tabUpdate.Controls.Add(Me.tglAutoUpdates)
        Me.tabUpdate.Controls.Add(Me.Label19)
        Me.tabUpdate.Controls.Add(Me.lblVersion)
        Me.tabUpdate.Location = New System.Drawing.Point(0, 26)
        Me.tabUpdate.Name = "tabUpdate"
        Me.tabUpdate.Size = New System.Drawing.Size(666, 521)
        Me.tabUpdate.TabIndex = 12
        Me.tabUpdate.Text = "UPDATE"
        '
        'fbChannelDot
        '
        Me.fbChannelDot.ButtonText = ""
        Me.fbChannelDot.Clickable = False
        Me.fbChannelDot.Color = LCARS.LCARScolorStyles.CriticalFunction
        Me.fbChannelDot.Location = New System.Drawing.Point(274, 65)
        Me.fbChannelDot.Name = "fbChannelDot"
        Me.fbChannelDot.Size = New System.Drawing.Size(31, 31)
        Me.fbChannelDot.TabIndex = 10
        '
        'txtCustom
        '
        Me.txtCustom.BackColor = System.Drawing.Color.Black
        Me.txtCustom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustom.Font = New System.Drawing.Font("LCARS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustom.ForeColor = System.Drawing.Color.Orange
        Me.txtCustom.Location = New System.Drawing.Point(309, 176)
        Me.txtCustom.Name = "txtCustom"
        Me.txtCustom.Size = New System.Drawing.Size(339, 31)
        Me.txtCustom.TabIndex = 9
        Me.txtCustom.Text = "Custom URL"
        Me.txtCustom.Visible = False
        '
        'hpCustom
        '
        Me.hpCustom.ButtonText = "CUSTOM"
        Me.hpCustom.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.hpCustom.Location = New System.Drawing.Point(309, 139)
        Me.hpCustom.Name = "hpCustom"
        Me.hpCustom.Size = New System.Drawing.Size(134, 31)
        Me.hpCustom.TabIndex = 8
        Me.hpCustom.Text = "CUSTOM"
        '
        'hpExperimental
        '
        Me.hpExperimental.ButtonText = "EXPERIMENTAL"
        Me.hpExperimental.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.hpExperimental.Location = New System.Drawing.Point(309, 102)
        Me.hpExperimental.Name = "hpExperimental"
        Me.hpExperimental.Size = New System.Drawing.Size(134, 31)
        Me.hpExperimental.TabIndex = 8
        Me.hpExperimental.Text = "EXPERIMENTAL"
        '
        'hpRelease
        '
        Me.hpRelease.ButtonText = "RELEASE"
        Me.hpRelease.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.hpRelease.Location = New System.Drawing.Point(309, 65)
        Me.hpRelease.Name = "hpRelease"
        Me.hpRelease.Size = New System.Drawing.Size(134, 31)
        Me.hpRelease.TabIndex = 8
        Me.hpRelease.Text = "RELEASE"
        '
        'sbCheck
        '
        Me.sbCheck.ButtonText = "MANUAL CHECK"
        Me.sbCheck.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.sbCheck.Color = LCARS.LCARScolorStyles.PrimaryFunction
        Me.sbCheck.Location = New System.Drawing.Point(5, 102)
        Me.sbCheck.Name = "sbCheck"
        Me.sbCheck.Size = New System.Drawing.Size(194, 31)
        Me.sbCheck.TabIndex = 7
        Me.sbCheck.Text = "MANUAL CHECK"
        '
        'tglAutoUpdates
        '
        Me.tglAutoUpdates.ButtonText = "AUTOMATIC UPDATES"
        Me.tglAutoUpdates.Lit = False
        Me.tglAutoUpdates.Location = New System.Drawing.Point(6, 65)
        Me.tglAutoUpdates.Name = "tglAutoUpdates"
        Me.tglAutoUpdates.SideText = "OFF"
        Me.tglAutoUpdates.Size = New System.Drawing.Size(200, 31)
        Me.tglAutoUpdates.State = False
        Me.tglAutoUpdates.TabIndex = 6
        Me.tglAutoUpdates.Text = "AUTOMATIC UPDATES"
        '
        'Label19
        '
        Me.Label19.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("LCARS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Orange
        Me.Label19.Location = New System.Drawing.Point(252, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(101, 28)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Update Channel"
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("LCARS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.Orange
        Me.lblVersion.Location = New System.Drawing.Point(-2, 24)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(171, 28)
        Me.lblVersion.TabIndex = 5
        Me.lblVersion.Text = "Program Version: 3-31-11"
        '
        'tabExperimental
        '
        Me.tabExperimental.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabExperimental.BackColor = System.Drawing.Color.Black
        Me.tabExperimental.Color = LCARS.LCARScolorStyles.MiscFunction
        Me.tabExperimental.Controls.Add(Me.tglDDE)
        Me.tabExperimental.Controls.Add(Me.tglDebug)
        Me.tabExperimental.Controls.Add(Me.lblDDESwitch)
        Me.tabExperimental.Controls.Add(Me.lblDebugSwitch)
        Me.tabExperimental.Controls.Add(Me.lblWarning)
        Me.tabExperimental.Location = New System.Drawing.Point(0, 26)
        Me.tabExperimental.Name = "tabExperimental"
        Me.tabExperimental.Size = New System.Drawing.Size(666, 521)
        Me.tabExperimental.TabIndex = 14
        Me.tabExperimental.Text = "EXPERIMENTAL"
        '
        'tglDDE
        '
        Me.tglDDE.ButtonText = "DYNAMIC DATA EXCHANGE"
        Me.tglDDE.Lit = False
        Me.tglDDE.Location = New System.Drawing.Point(17, 216)
        Me.tglDDE.Name = "tglDDE"
        Me.tglDDE.SideText = "OFF"
        Me.tglDDE.Size = New System.Drawing.Size(232, 32)
        Me.tglDDE.State = False
        Me.tglDDE.TabIndex = 9
        Me.tglDDE.Text = "DYNAMIC DATA EXCHANGE"
        '
        'tglDebug
        '
        Me.tglDebug.ButtonText = "DEBUG SWITCH"
        Me.tglDebug.Lit = False
        Me.tglDebug.Location = New System.Drawing.Point(17, 90)
        Me.tglDebug.Name = "tglDebug"
        Me.tglDebug.SideText = "OFF"
        Me.tglDebug.Size = New System.Drawing.Size(232, 32)
        Me.tglDebug.State = False
        Me.tglDebug.TabIndex = 8
        Me.tglDebug.Text = "DEBUG SWITCH"
        '
        'lblDDESwitch
        '
        Me.lblDDESwitch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDDESwitch.AutoSize = True
        Me.lblDDESwitch.Font = New System.Drawing.Font("LCARS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDDESwitch.ForeColor = System.Drawing.Color.Orange
        Me.lblDDESwitch.Location = New System.Drawing.Point(31, 254)
        Me.lblDDESwitch.Name = "lblDDESwitch"
        Me.lblDDESwitch.Size = New System.Drawing.Size(512, 56)
        Me.lblDDESwitch.TabIndex = 6
        Me.lblDDESwitch.Text = "Only functions in Shell mode. Should enable shell DDE services at a minimally fun" & _
            "ctional" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "level."
        '
        'lblDebugSwitch
        '
        Me.lblDebugSwitch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDebugSwitch.AutoSize = True
        Me.lblDebugSwitch.Font = New System.Drawing.Font("LCARS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebugSwitch.ForeColor = System.Drawing.Color.Orange
        Me.lblDebugSwitch.Location = New System.Drawing.Point(40, 129)
        Me.lblDebugSwitch.Name = "lblDebugSwitch"
        Me.lblDebugSwitch.Size = New System.Drawing.Size(465, 84)
        Me.lblDebugSwitch.TabIndex = 6
        Me.lblDebugSwitch.Text = "Will enable several features helpful for debugging purposes, but potentially" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dan" & _
            "gerous to have on at all times. Read the manual before enabling, or unless" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "told" & _
            " to enable for debugging purposes."
        '
        'lblWarning
        '
        Me.lblWarning.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Font = New System.Drawing.Font("LCARS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarning.ForeColor = System.Drawing.Color.Orange
        Me.lblWarning.Location = New System.Drawing.Point(-5, 4)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(331, 84)
        Me.lblWarning.TabIndex = 6
        Me.lblWarning.Text = "Warning: Features enabled on this page may not work," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or may work with unintended" & _
            " results. Do not use them" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "unless absolutely neccesary."
        '
        'tabAbout
        '
        Me.tabAbout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabAbout.BackColor = System.Drawing.Color.Black
        Me.tabAbout.Color = LCARS.LCARScolorStyles.MiscFunction
        Me.tabAbout.Controls.Add(Me.lblAbout)
        Me.tabAbout.Location = New System.Drawing.Point(0, 26)
        Me.tabAbout.Name = "tabAbout"
        Me.tabAbout.Size = New System.Drawing.Size(666, 521)
        Me.tabAbout.TabIndex = 10
        Me.tabAbout.Text = "ABOUT"
        '
        'lblAbout
        '
        Me.lblAbout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAbout.Font = New System.Drawing.Font("LCARS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.Location = New System.Drawing.Point(0, 15)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(648, 506)
        Me.lblAbout.TabIndex = 0
        Me.lblAbout.Text = "About Message"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.tbTitle)
        Me.Controls.Add(Me.sbExitMyComp)
        Me.Controls.Add(Me.ltcSettings)
        Me.ForeColor = System.Drawing.Color.Orange
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSettings"
        Me.Text = "SETTINGS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ltcSettings.ResumeLayout(False)
        Me.ltcSettings.PerformLayout()
        Me.tabScreenSpecific.ResumeLayout(False)
        Me.tabScreenSpecific.PerformLayout()
        Me.pnlScreenSpecific.ResumeLayout(False)
        Me.pnlMainScreen.ResumeLayout(False)
        Me.pnlMainScreen.PerformLayout()
        Me.pnlLanguage.ResumeLayout(False)
        Me.pnlLanguage.PerformLayout()
        Me.pnlWallpaper.ResumeLayout(False)
        Me.pnlWallpaper.PerformLayout()
        CType(Me.picWallpaper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LcarsTabPage1.ResumeLayout(False)
        Me.LcarsTabPage1.PerformLayout()
        Me.LcarsTabPage2.ResumeLayout(False)
        Me.pnlPreview.ResumeLayout(False)
        Me.LcarsTabPage3.ResumeLayout(False)
        Me.LcarsTabPage3.PerformLayout()
        Me.LcarsTabPage5.ResumeLayout(False)
        Me.LcarsTabPage5.PerformLayout()
        Me.pnlExternal.ResumeLayout(False)
        Me.pnlAdd.ResumeLayout(False)
        Me.pnlAdd.PerformLayout()
        Me.pnlInternal.ResumeLayout(False)
        Me.pnlInternal.PerformLayout()
        Me.tabAlerts.ResumeLayout(False)
        Me.tabAlerts.PerformLayout()
        Me.tabUpdate.ResumeLayout(False)
        Me.tabUpdate.PerformLayout()
        Me.tabExperimental.ResumeLayout(False)
        Me.tabExperimental.PerformLayout()
        Me.tabAbout.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlPreview As System.Windows.Forms.Panel
    Friend WithEvents Elbow6 As LCARS.Controls.Elbow
    Friend WithEvents FlatButton11 As LCARS.Controls.FlatButton
    Friend WithEvents Elbow5 As LCARS.Controls.Elbow
    Friend WithEvents StandardButton1 As LCARS.Controls.StandardButton
    Friend WithEvents FlatButton12 As LCARS.Controls.FlatButton
    Friend WithEvents ComplexButton2 As LCARS.Controls.ComplexButton
    Friend WithEvents StandardButton5 As LCARS.Controls.StandardButton
    Friend WithEvents StandardButton3 As LCARS.Controls.StandardButton
    Friend WithEvents StandardButton2 As LCARS.Controls.StandardButton
    Friend WithEvents sbUseScheme As LCARS.Controls.StandardButton
    Friend WithEvents lstColors As LCARS.Controls.LCARSList
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents sbExitMyComp As LCARS.Controls.StandardButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents fbShellSelect As LCARS.Controls.FlatButton
    Friend WithEvents hpbExplorer As LCARS.Controls.HalfPillButton
    Friend WithEvents hpbLCARS As LCARS.Controls.HalfPillButton
    Friend WithEvents tglVoice As LCARS.Controls.ToggleButton
    Friend WithEvents ltcSettings As LCARS.Controls.x32TabControl
    Friend WithEvents LcarsTabPage1 As LCARS.Controls.x32TabPage
    Friend WithEvents LcarsTabPage2 As LCARS.Controls.x32TabPage
    Friend WithEvents LcarsTabPage3 As LCARS.Controls.x32TabPage
    Friend WithEvents LcarsTabPage5 As LCARS.Controls.x32TabPage
    Friend WithEvents tbTitle As LCARS.Controls.TextButton
    Friend WithEvents tglDates As LCARS.Controls.ToggleButton
    Friend WithEvents fbChangeSound As LCARS.Controls.FlatButton
    Friend WithEvents tabAbout As LCARS.Controls.x32TabPage
    Friend WithEvents lblAbout As System.Windows.Forms.Label
    Friend WithEvents txtSoundPath As System.Windows.Forms.Label
    Friend WithEvents txtLanguageCode As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents fbSaveChanges As LCARS.Controls.FlatButton
    Friend WithEvents lstInternalCommands As LCARS.Controls.LCARSList
    Friend WithEvents sbExternal As LCARS.Controls.StandardButton
    Friend WithEvents sbInternal As LCARS.Controls.StandardButton
    Friend WithEvents pnlInternal As System.Windows.Forms.Panel
    Friend WithEvents pnlExternal As System.Windows.Forms.Panel
    Friend WithEvents lstExternalCommands As LCARS.Controls.LCARSList
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblIntCommandName As System.Windows.Forms.Label
    Friend WithEvents txtAlias As System.Windows.Forms.TextBox
    Friend WithEvents lblAlias As System.Windows.Forms.Label
    Friend WithEvents sbOK As LCARS.Controls.StandardButton
    Friend WithEvents sbCancel As LCARS.Controls.StandardButton
    Friend WithEvents sbAdd As LCARS.Controls.StandardButton
    Friend WithEvents sbRemove As LCARS.Controls.StandardButton
    Friend WithEvents pnlAdd As System.Windows.Forms.Panel
    Friend WithEvents txtCommandName As System.Windows.Forms.TextBox
    Friend WithEvents txtCommandPath As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents tabUpdate As LCARS.Controls.x32TabPage
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents tglAutoUpdates As LCARS.Controls.ToggleButton
    Friend WithEvents sbCheck As LCARS.Controls.StandardButton
    Friend WithEvents tabExperimental As LCARS.Controls.x32TabPage
    Friend WithEvents lblWarning As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents hpExperimental As LCARS.Controls.HalfPillButton
    Friend WithEvents hpRelease As LCARS.Controls.HalfPillButton
    Friend WithEvents hpCustom As LCARS.Controls.HalfPillButton
    Friend WithEvents fbChannelDot As LCARS.Controls.FlatButton
    Friend WithEvents txtCustom As System.Windows.Forms.TextBox
    Friend WithEvents tabAlerts As LCARS.Controls.x32TabPage
    Friend WithEvents lstAlerts As LCARS.Controls.LCARSList
    Friend WithEvents fbAlertColor As LCARS.Controls.FlatButton
    Friend WithEvents fbBrowseSound As LCARS.Controls.FlatButton
    Friend WithEvents hpAddAlert As LCARS.Controls.HalfPillButton
    Friend WithEvents fbDeleteAlert As LCARS.Controls.FlatButton
    Friend WithEvents lblAlertName As System.Windows.Forms.Label
    Friend WithEvents lblAlertSound As System.Windows.Forms.Label
    Friend WithEvents hpAlertFiller As LCARS.Controls.HalfPillButton
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents tglDebug As LCARS.Controls.ToggleButton
    Friend WithEvents lblDebugSwitch As System.Windows.Forms.Label
    Friend WithEvents tabScreenSpecific As LCARS.Controls.x32TabPage
    Friend WithEvents pnlScreens As System.Windows.Forms.Panel
    Friend WithEvents lblClickScreen As System.Windows.Forms.Label
    Friend WithEvents pnlScreenSpecific As System.Windows.Forms.Panel
    Friend WithEvents fbLanguage As LCARS.Controls.FlatButton
    Friend WithEvents fbMainScreen As LCARS.Controls.FlatButton
    Friend WithEvents fbWallpaper As LCARS.Controls.FlatButton
    Friend WithEvents pnlWallpaper As System.Windows.Forms.Panel
    Friend WithEvents lstSizeMode As LCARS.Controls.LCARSList
    Friend WithEvents picWallpaper As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents sbChangeWallpaper As LCARS.Controls.StandardButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents sbDefault As LCARS.Controls.StandardButton
    Friend WithEvents FlatButton1 As LCARS.Controls.FlatButton
    Friend WithEvents fbBack As LCARS.Controls.FlatButton
    Friend WithEvents pnlMainScreen As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tglAutoHide As LCARS.Controls.ToggleButton
    Friend WithEvents pnlLanguage As System.Windows.Forms.Panel
    Friend WithEvents txtLanguagePreview As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents sbUseLanguage As LCARS.Controls.StandardButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lstLanguages As LCARS.Controls.LCARSList
    Friend WithEvents sbEdit As LCARS.Controls.StandardButton
    Friend WithEvents tglVoiceTimeout As LCARS.Controls.ToggleButton
    Friend WithEvents txtCommandTimeout As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lstSounds As LCARS.Controls.LCARSList
    Friend WithEvents lblSoundResource As LCARS.Controls.LCARSLabel
    Friend WithEvents sbSoundEnabled As LCARS.Controls.StandardButton
    Friend WithEvents lblSoundName As LCARS.Controls.LCARSLabel
    Friend WithEvents lstSoundResources As LCARS.Controls.LCARSList
    Friend WithEvents sbSoundTest As LCARS.Controls.StandardButton
    Friend WithEvents tglDDE As LCARS.Controls.ToggleButton
    Friend WithEvents lblDDESwitch As System.Windows.Forms.Label
    Friend WithEvents gridScreens As LCARS.Controls.ButtonGrid
End Class
