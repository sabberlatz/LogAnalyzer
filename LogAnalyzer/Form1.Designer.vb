<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DruckenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeitenansichtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BearbeitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AusschneidenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KopierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinfügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AlleauswählenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HTMLFileGenerierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InhaltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuchenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pgb1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.MyApplicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DocsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalzmannDataSet = New WindowsApplication1.SalzmannDataSet()
        Me.DocsTableAdapter = New WindowsApplication1.SalzmannDataSetTableAdapters.docsTableAdapter()
        Me.tpFI = New System.Windows.Forms.TabPage()
        Me.tbFI1 = New System.Windows.Forms.TextBox()
        Me.tpMM = New System.Windows.Forms.TabPage()
        Me.tbMM1 = New System.Windows.Forms.TextBox()
        Me.tpFehleranalyse = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbFehlertext1 = New System.Windows.Forms.TextBox()
        Me.tbvorFehler1 = New System.Windows.Forms.TextBox()
        Me.tpGrunddaten = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbFilename1 = New System.Windows.Forms.TextBox()
        Me.tbVersion1 = New System.Windows.Forms.TextBox()
        Me.tbStartzeit1 = New System.Windows.Forms.TextBox()
        Me.tbEndzeit1 = New System.Windows.Forms.TextBox()
        Me.tbLaufzeit1 = New System.Windows.Forms.TextBox()
        Me.tbZeilenzahl1 = New System.Windows.Forms.TextBox()
        Me.tbSAPConnStr1 = New System.Windows.Forms.TextBox()
        Me.tbDBConnStr1 = New System.Windows.Forms.TextBox()
        Me.tbDoc_ID1 = New System.Windows.Forms.TextBox()
        Me.tbErrorzeit1 = New System.Windows.Forms.TextBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.tpParameter = New System.Windows.Forms.TabPage()
        Me.dgParameter1 = New System.Windows.Forms.DataGridView()
        Me.tpSQLStat1 = New System.Windows.Forms.TabPage()
        Me.dgSQLStat1 = New System.Windows.Forms.DataGridView()
        Me.tpTransaktionen = New System.Windows.Forms.TabPage()
        Me.dgTransaktionen1 = New System.Windows.Forms.DataGridView()
        Me.tpVariablen = New System.Windows.Forms.TabPage()
        Me.dgVariablen1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.tb3 = New System.Windows.Forms.TextBox()
        Me.tb4 = New System.Windows.Forms.TextBox()
        Me.tb5 = New System.Windows.Forms.TextBox()
        Me.tb6 = New System.Windows.Forms.TextBox()
        Me.tb8 = New System.Windows.Forms.TextBox()
        Me.tb9 = New System.Windows.Forms.TextBox()
        Me.tb10 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.lbDBDaten1 = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dgDBDaten1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tpDBdaten = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tbSupplier1 = New System.Windows.Forms.TextBox()
        Me.tbRechDat1 = New System.Windows.Forms.TextBox()
        Me.tbSkonto1 = New System.Windows.Forms.TextBox()
        Me.tbZahldat1 = New System.Windows.Forms.TextBox()
        Me.tbZahlbed1 = New System.Windows.Forms.TextBox()
        Me.tbBestNr1 = New System.Windows.Forms.TextBox()
        Me.tbRechNr1 = New System.Windows.Forms.TextBox()
        Me.tbWaehrung1 = New System.Windows.Forms.TextBox()
        Me.tbBetragBrutto1 = New System.Windows.Forms.TextBox()
        Me.tbBetraNetto1 = New System.Windows.Forms.TextBox()
        Me.tbSteuerbetrag1 = New System.Windows.Forms.TextBox()
        Me.tbDoc_ID2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.DataGridView6 = New System.Windows.Forms.DataGridView()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tpIPdaten = New System.Windows.Forms.TabPage()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.MyApplicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalzmannDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpFI.SuspendLayout()
        Me.tpMM.SuspendLayout()
        Me.tpFehleranalyse.SuspendLayout()
        Me.tpGrunddaten.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.tpParameter.SuspendLayout()
        CType(Me.dgParameter1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpSQLStat1.SuspendLayout()
        CType(Me.dgSQLStat1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpTransaktionen.SuspendLayout()
        CType(Me.dgTransaktionen1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpVariablen.SuspendLayout()
        CType(Me.dgVariablen1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        CType(Me.dgDBDaten1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpDBdaten.SuspendLayout()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpIPdaten.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.BearbeitenToolStripMenuItem, Me.ToolsToolStripMenuItem1, Me.ExtrasToolStripMenuItem, Me.HilfeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(978, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÖffnenToolStripMenuItem, Me.toolStripSeparator, Me.toolStripSeparator1, Me.DruckenToolStripMenuItem, Me.SeitenansichtToolStripMenuItem, Me.toolStripSeparator2, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(69, 29)
        Me.DateiToolStripMenuItem.Text = "&Datei"
        '
        'ÖffnenToolStripMenuItem
        '
        Me.ÖffnenToolStripMenuItem.Image = CType(resources.GetObject("ÖffnenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ÖffnenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ÖffnenToolStripMenuItem.Name = "ÖffnenToolStripMenuItem"
        Me.ÖffnenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ÖffnenToolStripMenuItem.Size = New System.Drawing.Size(292, 34)
        Me.ÖffnenToolStripMenuItem.Text = "Logfile Ö&ffnen"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(289, 6)
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(289, 6)
        '
        'DruckenToolStripMenuItem
        '
        Me.DruckenToolStripMenuItem.Image = CType(resources.GetObject("DruckenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DruckenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DruckenToolStripMenuItem.Name = "DruckenToolStripMenuItem"
        Me.DruckenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.DruckenToolStripMenuItem.Size = New System.Drawing.Size(292, 34)
        Me.DruckenToolStripMenuItem.Text = "&Drucken"
        '
        'SeitenansichtToolStripMenuItem
        '
        Me.SeitenansichtToolStripMenuItem.Image = CType(resources.GetObject("SeitenansichtToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SeitenansichtToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SeitenansichtToolStripMenuItem.Name = "SeitenansichtToolStripMenuItem"
        Me.SeitenansichtToolStripMenuItem.Size = New System.Drawing.Size(292, 34)
        Me.SeitenansichtToolStripMenuItem.Text = "&Seitenansicht"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(289, 6)
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(292, 34)
        Me.BeendenToolStripMenuItem.Text = "&Beenden"
        '
        'BearbeitenToolStripMenuItem
        '
        Me.BearbeitenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AusschneidenToolStripMenuItem, Me.KopierenToolStripMenuItem, Me.EinfügenToolStripMenuItem, Me.toolStripSeparator4, Me.AlleauswählenToolStripMenuItem})
        Me.BearbeitenToolStripMenuItem.Name = "BearbeitenToolStripMenuItem"
        Me.BearbeitenToolStripMenuItem.Size = New System.Drawing.Size(111, 29)
        Me.BearbeitenToolStripMenuItem.Text = "&Bearbeiten"
        '
        'AusschneidenToolStripMenuItem
        '
        Me.AusschneidenToolStripMenuItem.Image = CType(resources.GetObject("AusschneidenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AusschneidenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AusschneidenToolStripMenuItem.Name = "AusschneidenToolStripMenuItem"
        Me.AusschneidenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.AusschneidenToolStripMenuItem.Size = New System.Drawing.Size(293, 34)
        Me.AusschneidenToolStripMenuItem.Text = "&Ausschneiden"
        '
        'KopierenToolStripMenuItem
        '
        Me.KopierenToolStripMenuItem.Image = CType(resources.GetObject("KopierenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KopierenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.KopierenToolStripMenuItem.Name = "KopierenToolStripMenuItem"
        Me.KopierenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.KopierenToolStripMenuItem.Size = New System.Drawing.Size(293, 34)
        Me.KopierenToolStripMenuItem.Text = "&Kopieren"
        '
        'EinfügenToolStripMenuItem
        '
        Me.EinfügenToolStripMenuItem.Image = CType(resources.GetObject("EinfügenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EinfügenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EinfügenToolStripMenuItem.Name = "EinfügenToolStripMenuItem"
        Me.EinfügenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.EinfügenToolStripMenuItem.Size = New System.Drawing.Size(293, 34)
        Me.EinfügenToolStripMenuItem.Text = "&Einfügen"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(290, 6)
        '
        'AlleauswählenToolStripMenuItem
        '
        Me.AlleauswählenToolStripMenuItem.Name = "AlleauswählenToolStripMenuItem"
        Me.AlleauswählenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AlleauswählenToolStripMenuItem.Size = New System.Drawing.Size(293, 34)
        Me.AlleauswählenToolStripMenuItem.Text = "&Alle auswählen"
        '
        'ToolsToolStripMenuItem1
        '
        Me.ToolsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HTMLFileGenerierenToolStripMenuItem})
        Me.ToolsToolStripMenuItem1.Name = "ToolsToolStripMenuItem1"
        Me.ToolsToolStripMenuItem1.Size = New System.Drawing.Size(69, 29)
        Me.ToolsToolStripMenuItem1.Text = "Tools"
        '
        'HTMLFileGenerierenToolStripMenuItem
        '
        Me.HTMLFileGenerierenToolStripMenuItem.Name = "HTMLFileGenerierenToolStripMenuItem"
        Me.HTMLFileGenerierenToolStripMenuItem.Size = New System.Drawing.Size(281, 34)
        Me.HTMLFileGenerierenToolStripMenuItem.Text = "HTML-File generieren"
        '
        'ExtrasToolStripMenuItem
        '
        Me.ExtrasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionenToolStripMenuItem})
        Me.ExtrasToolStripMenuItem.Name = "ExtrasToolStripMenuItem"
        Me.ExtrasToolStripMenuItem.Size = New System.Drawing.Size(74, 29)
        Me.ExtrasToolStripMenuItem.Text = "E&xtras"
        '
        'OptionenToolStripMenuItem
        '
        Me.OptionenToolStripMenuItem.Name = "OptionenToolStripMenuItem"
        Me.OptionenToolStripMenuItem.Size = New System.Drawing.Size(189, 34)
        Me.OptionenToolStripMenuItem.Text = "&Optionen"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InhaltToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SuchenToolStripMenuItem, Me.toolStripSeparator5, Me.InfoToolStripMenuItem})
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(64, 29)
        Me.HilfeToolStripMenuItem.Text = "&Hilfe"
        '
        'InhaltToolStripMenuItem
        '
        Me.InhaltToolStripMenuItem.Name = "InhaltToolStripMenuItem"
        Me.InhaltToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.InhaltToolStripMenuItem.Text = "I&nhalt"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SuchenToolStripMenuItem
        '
        Me.SuchenToolStripMenuItem.Name = "SuchenToolStripMenuItem"
        Me.SuchenToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.SuchenToolStripMenuItem.Text = "&Suchen"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(267, 6)
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.InfoToolStripMenuItem.Text = "Inf&o..."
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.pgb1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 723)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(978, 32)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 25)
        '
        'pgb1
        '
        Me.pgb1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pgb1.Name = "pgb1"
        Me.pgb1.Size = New System.Drawing.Size(100, 24)
        Me.pgb1.Step = 1
        Me.pgb1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgb1.Visible = False
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(24, 25)
        Me.ToolStripStatusLabel2.Text = "..."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "log"
        Me.OpenFileDialog1.Filter = "anyERP-Logfiles|*.log"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'MyApplicationBindingSource
        '
        Me.MyApplicationBindingSource.DataSource = GetType(WindowsApplication1.My.MyApplication)
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DocsBindingSource
        '
        Me.DocsBindingSource.DataMember = "docs"
        Me.DocsBindingSource.DataSource = Me.SalzmannDataSet
        '
        'SalzmannDataSet
        '
        Me.SalzmannDataSet.DataSetName = "SalzmannDataSet"
        Me.SalzmannDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DocsTableAdapter
        '
        Me.DocsTableAdapter.ClearBeforeFill = True
        '
        'tpFI
        '
        Me.tpFI.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.tpFI.Controls.Add(Me.tbFI1)
        Me.tpFI.Location = New System.Drawing.Point(4, 22)
        Me.tpFI.Name = "tpFI"
        Me.tpFI.Size = New System.Drawing.Size(964, 679)
        Me.tpFI.TabIndex = 3
        Me.tpFI.Text = "FI-Aufbereitung"
        '
        'tbFI1
        '
        Me.tbFI1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFI1.Location = New System.Drawing.Point(10, 7)
        Me.tbFI1.Multiline = True
        Me.tbFI1.Name = "tbFI1"
        Me.tbFI1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbFI1.Size = New System.Drawing.Size(944, 669)
        Me.tbFI1.TabIndex = 1
        '
        'tpMM
        '
        Me.tpMM.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tpMM.Controls.Add(Me.tbMM1)
        Me.tpMM.Location = New System.Drawing.Point(4, 22)
        Me.tpMM.Name = "tpMM"
        Me.tpMM.Size = New System.Drawing.Size(964, 679)
        Me.tpMM.TabIndex = 2
        Me.tpMM.Text = "MM-Aufbereitung"
        '
        'tbMM1
        '
        Me.tbMM1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMM1.Location = New System.Drawing.Point(8, 8)
        Me.tbMM1.Multiline = True
        Me.tbMM1.Name = "tbMM1"
        Me.tbMM1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbMM1.Size = New System.Drawing.Size(944, 671)
        Me.tbMM1.TabIndex = 0
        '
        'tpFehleranalyse
        '
        Me.tpFehleranalyse.BackColor = System.Drawing.Color.Red
        Me.tpFehleranalyse.Controls.Add(Me.tbvorFehler1)
        Me.tpFehleranalyse.Controls.Add(Me.tbFehlertext1)
        Me.tpFehleranalyse.Controls.Add(Me.Label10)
        Me.tpFehleranalyse.Controls.Add(Me.Label9)
        Me.tpFehleranalyse.Location = New System.Drawing.Point(4, 22)
        Me.tpFehleranalyse.Name = "tpFehleranalyse"
        Me.tpFehleranalyse.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFehleranalyse.Size = New System.Drawing.Size(964, 679)
        Me.tpFehleranalyse.TabIndex = 1
        Me.tpFehleranalyse.Text = "Fehleranalyse"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 362)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Fehlertext"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Auftreten des Fehlers"
        '
        'tbFehlertext1
        '
        Me.tbFehlertext1.Location = New System.Drawing.Point(8, 378)
        Me.tbFehlertext1.Multiline = True
        Me.tbFehlertext1.Name = "tbFehlertext1"
        Me.tbFehlertext1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbFehlertext1.Size = New System.Drawing.Size(936, 301)
        Me.tbFehlertext1.TabIndex = 1
        '
        'tbvorFehler1
        '
        Me.tbvorFehler1.Location = New System.Drawing.Point(8, 32)
        Me.tbvorFehler1.Multiline = True
        Me.tbvorFehler1.Name = "tbvorFehler1"
        Me.tbvorFehler1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbvorFehler1.Size = New System.Drawing.Size(936, 310)
        Me.tbvorFehler1.TabIndex = 3
        '
        'tpGrunddaten
        '
        Me.tpGrunddaten.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.tpGrunddaten.Controls.Add(Me.Button3)
        Me.tpGrunddaten.Controls.Add(Me.tb10)
        Me.tpGrunddaten.Controls.Add(Me.tb9)
        Me.tpGrunddaten.Controls.Add(Me.tb8)
        Me.tpGrunddaten.Controls.Add(Me.tb6)
        Me.tpGrunddaten.Controls.Add(Me.tb5)
        Me.tpGrunddaten.Controls.Add(Me.tb4)
        Me.tpGrunddaten.Controls.Add(Me.tb3)
        Me.tpGrunddaten.Controls.Add(Me.tb2)
        Me.tpGrunddaten.Controls.Add(Me.tbErrorzeit1)
        Me.tpGrunddaten.Controls.Add(Me.tbDoc_ID1)
        Me.tpGrunddaten.Controls.Add(Me.tbDBConnStr1)
        Me.tpGrunddaten.Controls.Add(Me.tbSAPConnStr1)
        Me.tpGrunddaten.Controls.Add(Me.tbZeilenzahl1)
        Me.tpGrunddaten.Controls.Add(Me.tbLaufzeit1)
        Me.tpGrunddaten.Controls.Add(Me.tbEndzeit1)
        Me.tpGrunddaten.Controls.Add(Me.tbStartzeit1)
        Me.tpGrunddaten.Controls.Add(Me.tbVersion1)
        Me.tpGrunddaten.Controls.Add(Me.tbFilename1)
        Me.tpGrunddaten.Controls.Add(Me.PictureBox1)
        Me.tpGrunddaten.Controls.Add(Me.TabControl2)
        Me.tpGrunddaten.Controls.Add(Me.Label11)
        Me.tpGrunddaten.Controls.Add(Me.Label8)
        Me.tpGrunddaten.Location = New System.Drawing.Point(4, 22)
        Me.tpGrunddaten.Name = "tpGrunddaten"
        Me.tpGrunddaten.Padding = New System.Windows.Forms.Padding(3)
        Me.tpGrunddaten.Size = New System.Drawing.Size(964, 679)
        Me.tpGrunddaten.TabIndex = 0
        Me.tpGrunddaten.Text = "Datenanalyse"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Connectionstring"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(724, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "DOC_ID"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbFilename1
        '
        Me.tbFilename1.Location = New System.Drawing.Point(106, 16)
        Me.tbFilename1.Name = "tbFilename1"
        Me.tbFilename1.Size = New System.Drawing.Size(580, 20)
        Me.tbFilename1.TabIndex = 6
        '
        'tbVersion1
        '
        Me.tbVersion1.Location = New System.Drawing.Point(106, 42)
        Me.tbVersion1.Name = "tbVersion1"
        Me.tbVersion1.Size = New System.Drawing.Size(115, 20)
        Me.tbVersion1.TabIndex = 7
        '
        'tbStartzeit1
        '
        Me.tbStartzeit1.Location = New System.Drawing.Point(106, 68)
        Me.tbStartzeit1.Name = "tbStartzeit1"
        Me.tbStartzeit1.Size = New System.Drawing.Size(115, 20)
        Me.tbStartzeit1.TabIndex = 8
        '
        'tbEndzeit1
        '
        Me.tbEndzeit1.Location = New System.Drawing.Point(295, 68)
        Me.tbEndzeit1.Name = "tbEndzeit1"
        Me.tbEndzeit1.Size = New System.Drawing.Size(115, 20)
        Me.tbEndzeit1.TabIndex = 9
        '
        'tbLaufzeit1
        '
        Me.tbLaufzeit1.Location = New System.Drawing.Point(533, 42)
        Me.tbLaufzeit1.Name = "tbLaufzeit1"
        Me.tbLaufzeit1.Size = New System.Drawing.Size(153, 20)
        Me.tbLaufzeit1.TabIndex = 10
        '
        'tbZeilenzahl1
        '
        Me.tbZeilenzahl1.Location = New System.Drawing.Point(295, 42)
        Me.tbZeilenzahl1.Name = "tbZeilenzahl1"
        Me.tbZeilenzahl1.Size = New System.Drawing.Size(115, 20)
        Me.tbZeilenzahl1.TabIndex = 11
        '
        'tbSAPConnStr1
        '
        Me.tbSAPConnStr1.Location = New System.Drawing.Point(106, 94)
        Me.tbSAPConnStr1.Name = "tbSAPConnStr1"
        Me.tbSAPConnStr1.Size = New System.Drawing.Size(832, 20)
        Me.tbSAPConnStr1.TabIndex = 13
        '
        'tbDBConnStr1
        '
        Me.tbDBConnStr1.Location = New System.Drawing.Point(106, 120)
        Me.tbDBConnStr1.Name = "tbDBConnStr1"
        Me.tbDBConnStr1.Size = New System.Drawing.Size(832, 20)
        Me.tbDBConnStr1.TabIndex = 15
        '
        'tbDoc_ID1
        '
        Me.tbDoc_ID1.Location = New System.Drawing.Point(777, 39)
        Me.tbDoc_ID1.Name = "tbDoc_ID1"
        Me.tbDoc_ID1.Size = New System.Drawing.Size(161, 20)
        Me.tbDoc_ID1.TabIndex = 17
        '
        'tbErrorzeit1
        '
        Me.tbErrorzeit1.Location = New System.Drawing.Point(533, 68)
        Me.tbErrorzeit1.Name = "tbErrorzeit1"
        Me.tbErrorzeit1.Size = New System.Drawing.Size(153, 20)
        Me.tbErrorzeit1.TabIndex = 18
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.tpVariablen)
        Me.TabControl2.Controls.Add(Me.tpTransaktionen)
        Me.TabControl2.Controls.Add(Me.tpSQLStat1)
        Me.TabControl2.Controls.Add(Me.tpParameter)
        Me.TabControl2.Location = New System.Drawing.Point(19, 160)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(919, 519)
        Me.TabControl2.TabIndex = 23
        '
        'tpParameter
        '
        Me.tpParameter.Controls.Add(Me.dgParameter1)
        Me.tpParameter.Location = New System.Drawing.Point(4, 22)
        Me.tpParameter.Name = "tpParameter"
        Me.tpParameter.Padding = New System.Windows.Forms.Padding(3)
        Me.tpParameter.Size = New System.Drawing.Size(911, 493)
        Me.tpParameter.TabIndex = 3
        Me.tpParameter.Text = "Parameter"
        Me.tpParameter.UseVisualStyleBackColor = True
        '
        'dgParameter1
        '
        Me.dgParameter1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgParameter1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgParameter1.Location = New System.Drawing.Point(0, 0)
        Me.dgParameter1.Name = "dgParameter1"
        Me.dgParameter1.RowHeadersWidth = 62
        Me.dgParameter1.Size = New System.Drawing.Size(911, 497)
        Me.dgParameter1.TabIndex = 0
        '
        'tpSQLStat1
        '
        Me.tpSQLStat1.Controls.Add(Me.dgSQLStat1)
        Me.tpSQLStat1.Location = New System.Drawing.Point(4, 22)
        Me.tpSQLStat1.Name = "tpSQLStat1"
        Me.tpSQLStat1.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSQLStat1.Size = New System.Drawing.Size(911, 493)
        Me.tpSQLStat1.TabIndex = 2
        Me.tpSQLStat1.Text = "SQL-Statements"
        Me.tpSQLStat1.UseVisualStyleBackColor = True
        '
        'dgSQLStat1
        '
        Me.dgSQLStat1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgSQLStat1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSQLStat1.Location = New System.Drawing.Point(0, 0)
        Me.dgSQLStat1.Name = "dgSQLStat1"
        Me.dgSQLStat1.RowHeadersWidth = 62
        Me.dgSQLStat1.Size = New System.Drawing.Size(911, 497)
        Me.dgSQLStat1.TabIndex = 0
        '
        'tpTransaktionen
        '
        Me.tpTransaktionen.Controls.Add(Me.dgTransaktionen1)
        Me.tpTransaktionen.Location = New System.Drawing.Point(4, 22)
        Me.tpTransaktionen.Name = "tpTransaktionen"
        Me.tpTransaktionen.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTransaktionen.Size = New System.Drawing.Size(911, 493)
        Me.tpTransaktionen.TabIndex = 1
        Me.tpTransaktionen.Text = "Transaktionen"
        Me.tpTransaktionen.UseVisualStyleBackColor = True
        '
        'dgTransaktionen1
        '
        Me.dgTransaktionen1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgTransaktionen1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTransaktionen1.Location = New System.Drawing.Point(0, 0)
        Me.dgTransaktionen1.Name = "dgTransaktionen1"
        Me.dgTransaktionen1.RowHeadersWidth = 62
        Me.dgTransaktionen1.Size = New System.Drawing.Size(911, 497)
        Me.dgTransaktionen1.TabIndex = 0
        '
        'tpVariablen
        '
        Me.tpVariablen.Controls.Add(Me.dgVariablen1)
        Me.tpVariablen.Location = New System.Drawing.Point(4, 22)
        Me.tpVariablen.Name = "tpVariablen"
        Me.tpVariablen.Padding = New System.Windows.Forms.Padding(3)
        Me.tpVariablen.Size = New System.Drawing.Size(911, 493)
        Me.tpVariablen.TabIndex = 0
        Me.tpVariablen.Text = "Variablen"
        Me.tpVariablen.UseVisualStyleBackColor = True
        '
        'dgVariablen1
        '
        Me.dgVariablen1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgVariablen1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVariablen1.Location = New System.Drawing.Point(0, 0)
        Me.dgVariablen1.Name = "dgVariablen1"
        Me.dgVariablen1.RowHeadersWidth = 62
        Me.dgVariablen1.Size = New System.Drawing.Size(911, 497)
        Me.dgVariablen1.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(434, 141)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 35)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'tb2
        '
        Me.tb2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.tb2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb2.Location = New System.Drawing.Point(0, 19)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(100, 13)
        Me.tb2.TabIndex = 25
        Me.tb2.Text = "Filename"
        Me.tb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb3
        '
        Me.tb3.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.tb3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb3.Location = New System.Drawing.Point(227, 42)
        Me.tb3.Name = "tb3"
        Me.tb3.Size = New System.Drawing.Size(65, 13)
        Me.tb3.TabIndex = 26
        Me.tb3.Text = "Zeilen"
        Me.tb3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb4
        '
        Me.tb4.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.tb4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb4.Location = New System.Drawing.Point(7, 94)
        Me.tb4.Name = "tb4"
        Me.tb4.Size = New System.Drawing.Size(95, 13)
        Me.tb4.TabIndex = 29
        Me.tb4.Text = "SAP-Verbindung"
        Me.tb4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb5
        '
        Me.tb5.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.tb5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb5.Location = New System.Drawing.Point(35, 68)
        Me.tb5.Name = "tb5"
        Me.tb5.Size = New System.Drawing.Size(65, 13)
        Me.tb5.TabIndex = 30
        Me.tb5.Text = "Startzeit"
        Me.tb5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb6
        '
        Me.tb6.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.tb6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb6.Location = New System.Drawing.Point(6, 42)
        Me.tb6.Name = "tb6"
        Me.tb6.Size = New System.Drawing.Size(96, 13)
        Me.tb6.TabIndex = 31
        Me.tb6.Text = "anyERP Version"
        Me.tb6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb8
        '
        Me.tb8.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.tb8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb8.Location = New System.Drawing.Point(466, 68)
        Me.tb8.Name = "tb8"
        Me.tb8.Size = New System.Drawing.Size(65, 13)
        Me.tb8.TabIndex = 33
        Me.tb8.Text = "Fehlerzeit"
        Me.tb8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb9
        '
        Me.tb9.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.tb9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb9.Location = New System.Drawing.Point(227, 69)
        Me.tb9.Name = "tb9"
        Me.tb9.Size = New System.Drawing.Size(65, 13)
        Me.tb9.TabIndex = 34
        Me.tb9.Text = "Endzeit"
        Me.tb9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb10
        '
        Me.tb10.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.tb10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb10.Location = New System.Drawing.Point(466, 42)
        Me.tb10.Name = "tb10"
        Me.tb10.Size = New System.Drawing.Size(65, 13)
        Me.tb10.TabIndex = 35
        Me.tb10.Text = "Laufzeit"
        Me.tb10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Window
        Me.Button3.Location = New System.Drawing.Point(689, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(30, 20)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpGrunddaten)
        Me.TabControl1.Controls.Add(Me.tpFehleranalyse)
        Me.TabControl1.Controls.Add(Me.tpMM)
        Me.TabControl1.Controls.Add(Me.tpFI)
        Me.TabControl1.Controls.Add(Me.tpIPdaten)
        Me.TabControl1.Controls.Add(Me.tpDBdaten)
        Me.TabControl1.Location = New System.Drawing.Point(12, 43)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(972, 705)
        Me.TabControl1.TabIndex = 2
        '
        'lbDBDaten1
        '
        Me.lbDBDaten1.FormattingEnabled = True
        Me.lbDBDaten1.Items.AddRange(New Object() {"acc_data", "acc_list_1", "acc_list_2", "acc_list_3", "acc_list_4", "acc_list_5", "acc_list_6", "acc_list_7", "acc_list_8", "acc_list_9", "acc_list_10", "acc_list_11", "acc_list_12", "acc_list_13", "acc_list_14", "acc_list_15", "acc_list_16", "acc_list_17", "acc_list_18", "acc_list_19", "acc_list_20", "companies", "currencies", "doc_datalist_1", "doc_datalist_2", "doc_datalist_3", "doc_datalist_4", "doc_datalist_5", "doc_datalist_6", "doc_datalist_7", "doc_datalist_8", "doc_datalist_9", "doc_datalist_10", "languages", "payments", "supplier", "vatcodes"})
        Me.lbDBDaten1.Location = New System.Drawing.Point(56, 14)
        Me.lbDBDaten1.Name = "lbDBDaten1"
        Me.lbDBDaten1.Size = New System.Drawing.Size(136, 43)
        Me.lbDBDaten1.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 13)
        Me.Label13.TabIndex = 1
        '
        'dgDBDaten1
        '
        Me.dgDBDaten1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDBDaten1.Location = New System.Drawing.Point(8, 82)
        Me.dgDBDaten1.Name = "dgDBDaten1"
        Me.dgDBDaten1.RowHeadersWidth = 62
        Me.dgDBDaten1.Size = New System.Drawing.Size(952, 597)
        Me.dgDBDaten1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(212, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Daten lesen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tpDBdaten
        '
        Me.tpDBdaten.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tpDBdaten.Controls.Add(Me.Button1)
        Me.tpDBdaten.Controls.Add(Me.dgDBDaten1)
        Me.tpDBdaten.Controls.Add(Me.Label13)
        Me.tpDBdaten.Controls.Add(Me.lbDBDaten1)
        Me.tpDBdaten.Location = New System.Drawing.Point(4, 22)
        Me.tpDBdaten.Name = "tpDBdaten"
        Me.tpDBdaten.Size = New System.Drawing.Size(964, 679)
        Me.tpDBdaten.TabIndex = 6
        Me.tpDBdaten.Text = "DB-Daten"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(56, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 13)
        Me.Label12.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 13)
        Me.Label14.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(232, 52)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(0, 13)
        Me.Label15.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(440, 52)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 13)
        Me.Label16.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(632, 52)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(0, 13)
        Me.Label17.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(240, 85)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 13)
        Me.Label18.TabIndex = 6
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(24, 85)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(0, 13)
        Me.Label19.TabIndex = 7
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(440, 85)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(0, 13)
        Me.Label20.TabIndex = 8
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(517, 128)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(0, 13)
        Me.Label21.TabIndex = 9
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(18, 128)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(0, 13)
        Me.Label22.TabIndex = 10
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(299, 128)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(0, 13)
        Me.Label23.TabIndex = 11
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(448, 20)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(0, 13)
        Me.Label24.TabIndex = 22
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(684, 85)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(0, 13)
        Me.Label26.TabIndex = 24
        '
        'tbSupplier1
        '
        Me.tbSupplier1.Location = New System.Drawing.Point(104, 16)
        Me.tbSupplier1.Name = "tbSupplier1"
        Me.tbSupplier1.Size = New System.Drawing.Size(300, 20)
        Me.tbSupplier1.TabIndex = 1
        '
        'tbRechDat1
        '
        Me.tbRechDat1.Location = New System.Drawing.Point(104, 48)
        Me.tbRechDat1.Name = "tbRechDat1"
        Me.tbRechDat1.Size = New System.Drawing.Size(100, 20)
        Me.tbRechDat1.TabIndex = 12
        '
        'tbSkonto1
        '
        Me.tbSkonto1.Location = New System.Drawing.Point(304, 48)
        Me.tbSkonto1.Name = "tbSkonto1"
        Me.tbSkonto1.Size = New System.Drawing.Size(100, 20)
        Me.tbSkonto1.TabIndex = 13
        '
        'tbZahldat1
        '
        Me.tbZahldat1.Location = New System.Drawing.Point(496, 48)
        Me.tbZahldat1.Name = "tbZahldat1"
        Me.tbZahldat1.Size = New System.Drawing.Size(100, 20)
        Me.tbZahldat1.TabIndex = 14
        '
        'tbZahlbed1
        '
        Me.tbZahlbed1.Location = New System.Drawing.Point(736, 48)
        Me.tbZahlbed1.Name = "tbZahlbed1"
        Me.tbZahlbed1.Size = New System.Drawing.Size(216, 20)
        Me.tbZahlbed1.TabIndex = 15
        '
        'tbBestNr1
        '
        Me.tbBestNr1.Location = New System.Drawing.Point(104, 81)
        Me.tbBestNr1.Name = "tbBestNr1"
        Me.tbBestNr1.Size = New System.Drawing.Size(100, 20)
        Me.tbBestNr1.TabIndex = 16
        '
        'tbRechNr1
        '
        Me.tbRechNr1.Location = New System.Drawing.Point(304, 81)
        Me.tbRechNr1.Name = "tbRechNr1"
        Me.tbRechNr1.Size = New System.Drawing.Size(100, 20)
        Me.tbRechNr1.TabIndex = 17
        '
        'tbWaehrung1
        '
        Me.tbWaehrung1.Location = New System.Drawing.Point(496, 81)
        Me.tbWaehrung1.Name = "tbWaehrung1"
        Me.tbWaehrung1.Size = New System.Drawing.Size(100, 20)
        Me.tbWaehrung1.TabIndex = 18
        '
        'tbBetragBrutto1
        '
        Me.tbBetragBrutto1.Location = New System.Drawing.Point(637, 121)
        Me.tbBetragBrutto1.Name = "tbBetragBrutto1"
        Me.tbBetragBrutto1.Size = New System.Drawing.Size(128, 20)
        Me.tbBetragBrutto1.TabIndex = 19
        '
        'tbBetraNetto1
        '
        Me.tbBetraNetto1.Location = New System.Drawing.Point(138, 121)
        Me.tbBetraNetto1.Name = "tbBetraNetto1"
        Me.tbBetraNetto1.Size = New System.Drawing.Size(128, 20)
        Me.tbBetraNetto1.TabIndex = 20
        '
        'tbSteuerbetrag1
        '
        Me.tbSteuerbetrag1.Location = New System.Drawing.Point(371, 121)
        Me.tbSteuerbetrag1.Name = "tbSteuerbetrag1"
        Me.tbSteuerbetrag1.Size = New System.Drawing.Size(128, 20)
        Me.tbSteuerbetrag1.TabIndex = 21
        '
        'tbDoc_ID2
        '
        Me.tbDoc_ID2.Location = New System.Drawing.Point(496, 16)
        Me.tbDoc_ID2.Name = "tbDoc_ID2"
        Me.tbDoc_ID2.Size = New System.Drawing.Size(240, 20)
        Me.tbDoc_ID2.TabIndex = 23
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(736, 81)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 25
        '
        'TabControl3
        '
        Me.TabControl3.Location = New System.Drawing.Point(19, 165)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(942, 482)
        Me.TabControl3.TabIndex = 26
        '
        'TabPage9
        '
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(934, 456)
        Me.TabPage9.TabIndex = 5
        Me.TabPage9.Text = "doc_attachments"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'DataGridView6
        '
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.RowHeadersWidth = 62
        Me.DataGridView6.Size = New System.Drawing.Size(938, 456)
        Me.DataGridView6.TabIndex = 1
        '
        'TabPage8
        '
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(934, 456)
        Me.TabPage8.TabIndex = 4
        Me.TabPage8.Text = "doc_files"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'DataGridView5
        '
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.RowHeadersWidth = 62
        Me.DataGridView5.Size = New System.Drawing.Size(938, 456)
        Me.DataGridView5.TabIndex = 1
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(934, 456)
        Me.TabPage5.TabIndex = 3
        Me.TabPage5.Text = "flow_log"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersWidth = 62
        Me.DataGridView4.Size = New System.Drawing.Size(938, 456)
        Me.DataGridView4.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(934, 456)
        Me.TabPage4.TabIndex = 2
        Me.TabPage4.Text = "action_log"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 62
        Me.DataGridView3.Size = New System.Drawing.Size(838, 456)
        Me.DataGridView3.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(934, 456)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "doc_data"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 62
        Me.DataGridView2.Size = New System.Drawing.Size(938, 456)
        Me.DataGridView2.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(934, 456)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "docs"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(938, 456)
        Me.DataGridView1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(761, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Datenbank verbinden"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'tpIPdaten
        '
        Me.tpIPdaten.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tpIPdaten.Controls.Add(Me.Button2)
        Me.tpIPdaten.Controls.Add(Me.TabControl3)
        Me.tpIPdaten.Controls.Add(Me.TextBox1)
        Me.tpIPdaten.Controls.Add(Me.tbDoc_ID2)
        Me.tpIPdaten.Controls.Add(Me.tbSteuerbetrag1)
        Me.tpIPdaten.Controls.Add(Me.tbBetraNetto1)
        Me.tpIPdaten.Controls.Add(Me.tbBetragBrutto1)
        Me.tpIPdaten.Controls.Add(Me.tbWaehrung1)
        Me.tpIPdaten.Controls.Add(Me.tbRechNr1)
        Me.tpIPdaten.Controls.Add(Me.tbBestNr1)
        Me.tpIPdaten.Controls.Add(Me.tbZahlbed1)
        Me.tpIPdaten.Controls.Add(Me.tbZahldat1)
        Me.tpIPdaten.Controls.Add(Me.tbSkonto1)
        Me.tpIPdaten.Controls.Add(Me.tbRechDat1)
        Me.tpIPdaten.Controls.Add(Me.tbSupplier1)
        Me.tpIPdaten.Controls.Add(Me.Label26)
        Me.tpIPdaten.Controls.Add(Me.Label24)
        Me.tpIPdaten.Controls.Add(Me.Label23)
        Me.tpIPdaten.Controls.Add(Me.Label22)
        Me.tpIPdaten.Controls.Add(Me.Label21)
        Me.tpIPdaten.Controls.Add(Me.Label20)
        Me.tpIPdaten.Controls.Add(Me.Label19)
        Me.tpIPdaten.Controls.Add(Me.Label18)
        Me.tpIPdaten.Controls.Add(Me.Label17)
        Me.tpIPdaten.Controls.Add(Me.Label16)
        Me.tpIPdaten.Controls.Add(Me.Label15)
        Me.tpIPdaten.Controls.Add(Me.Label14)
        Me.tpIPdaten.Controls.Add(Me.Label12)
        Me.tpIPdaten.Location = New System.Drawing.Point(4, 22)
        Me.tpIPdaten.Name = "tpIPdaten"
        Me.tpIPdaten.Size = New System.Drawing.Size(964, 679)
        Me.tpIPdaten.TabIndex = 5
        Me.tpIPdaten.Text = "IP-Daten"
        '
        'frmMain
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(978, 755)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(1000, 811)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LogAnalyzer 1.00"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.MyApplicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalzmannDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpFI.ResumeLayout(False)
        Me.tpFI.PerformLayout()
        Me.tpMM.ResumeLayout(False)
        Me.tpMM.PerformLayout()
        Me.tpFehleranalyse.ResumeLayout(False)
        Me.tpFehleranalyse.PerformLayout()
        Me.tpGrunddaten.ResumeLayout(False)
        Me.tpGrunddaten.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.tpParameter.ResumeLayout(False)
        CType(Me.dgParameter1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpSQLStat1.ResumeLayout(False)
        CType(Me.dgSQLStat1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpTransaktionen.ResumeLayout(False)
        CType(Me.dgTransaktionen1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpVariablen.ResumeLayout(False)
        CType(Me.dgVariablen1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.dgDBDaten1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpDBdaten.ResumeLayout(False)
        Me.tpDBdaten.PerformLayout()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpIPdaten.ResumeLayout(False)
        Me.tpIPdaten.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÖffnenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DruckenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeitenansichtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BearbeitenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AusschneidenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KopierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EinfügenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExtrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HilfeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InhaltToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuchenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HTMLFileGenerierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AlleauswählenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents MyApplicationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents pgb1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents SalzmannDataSet As WindowsApplication1.SalzmannDataSet
    Friend WithEvents DocsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DocsTableAdapter As WindowsApplication1.SalzmannDataSetTableAdapters.docsTableAdapter
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpGrunddaten As TabPage
    Friend WithEvents Button3 As Button
    Friend WithEvents tb10 As TextBox
    Friend WithEvents tb9 As TextBox
    Friend WithEvents tb8 As TextBox
    Friend WithEvents tb6 As TextBox
    Friend WithEvents tb5 As TextBox
    Friend WithEvents tb4 As TextBox
    Friend WithEvents tb3 As TextBox
    Friend WithEvents tb2 As TextBox
    Friend WithEvents tbErrorzeit1 As TextBox
    Friend WithEvents tbDoc_ID1 As TextBox
    Friend WithEvents tbDBConnStr1 As TextBox
    Friend WithEvents tbSAPConnStr1 As TextBox
    Friend WithEvents tbZeilenzahl1 As TextBox
    Friend WithEvents tbLaufzeit1 As TextBox
    Friend WithEvents tbEndzeit1 As TextBox
    Friend WithEvents tbStartzeit1 As TextBox
    Friend WithEvents tbVersion1 As TextBox
    Friend WithEvents tbFilename1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents tpVariablen As TabPage
    Friend WithEvents dgVariablen1 As DataGridView
    Friend WithEvents tpTransaktionen As TabPage
    Friend WithEvents dgTransaktionen1 As DataGridView
    Friend WithEvents tpSQLStat1 As TabPage
    Friend WithEvents dgSQLStat1 As DataGridView
    Friend WithEvents tpParameter As TabPage
    Friend WithEvents dgParameter1 As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tpFehleranalyse As TabPage
    Friend WithEvents tbvorFehler1 As TextBox
    Friend WithEvents tbFehlertext1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tpMM As TabPage
    Friend WithEvents tbMM1 As TextBox
    Friend WithEvents tpFI As TabPage
    Friend WithEvents tbFI1 As TextBox
    Friend WithEvents tpIPdaten As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents tbDoc_ID2 As TextBox
    Friend WithEvents tbSteuerbetrag1 As TextBox
    Friend WithEvents tbBetraNetto1 As TextBox
    Friend WithEvents tbBetragBrutto1 As TextBox
    Friend WithEvents tbWaehrung1 As TextBox
    Friend WithEvents tbRechNr1 As TextBox
    Friend WithEvents tbBestNr1 As TextBox
    Friend WithEvents tbZahlbed1 As TextBox
    Friend WithEvents tbZahldat1 As TextBox
    Friend WithEvents tbSkonto1 As TextBox
    Friend WithEvents tbRechDat1 As TextBox
    Friend WithEvents tbSupplier1 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents tpDBdaten As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents dgDBDaten1 As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents lbDBDaten1 As ListBox
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents DataGridView6 As DataGridView
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
End Class
