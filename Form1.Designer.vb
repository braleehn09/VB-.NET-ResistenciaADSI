<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Tolerancia = New System.Windows.Forms.ComboBox()
        Me.Multiplicador = New System.Windows.Forms.ComboBox()
        Me.SegundaBanda = New System.Windows.Forms.ComboBox()
        Me.PrimeraBanda = New System.Windows.Forms.ComboBox()
        Me.Tolerance4Band = New System.Windows.Forms.Label()
        Me.Multiplier4Band = New System.Windows.Forms.Label()
        Me.SecondBand = New System.Windows.Forms.Label()
        Me.FirstBand = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuArchive = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeCalcuNormal = New System.Windows.Forms.ToolStripMenuItem()
        Me.Language = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpanishLanguage = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnglishLanguage = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.RadioCuatroBandas = New System.Windows.Forms.RadioButton()
        Me.RadioCincoBandas = New System.Windows.Forms.RadioButton()
        Me.BtnReiniciar = New System.Windows.Forms.Button()
        Me.ToleranceAnswer = New System.Windows.Forms.Label()
        Me.ResistorAnswer = New System.Windows.Forms.Label()
        Me.TxtResultadoTolerancia = New System.Windows.Forms.TextBox()
        Me.TxtResultado = New System.Windows.Forms.TextBox()
        Me.MinToleranceAnswer = New System.Windows.Forms.Label()
        Me.TxtResultadoToleranciaMinima = New System.Windows.Forms.TextBox()
        Me.MaxToleranceAnswer = New System.Windows.Forms.Label()
        Me.TxtResultadoToleranciaMaxima = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BandaUno = New System.Windows.Forms.TextBox()
        Me.BandaTolerancia = New System.Windows.Forms.TextBox()
        Me.BandaSegunda = New System.Windows.Forms.TextBox()
        Me.BandaTercera = New System.Windows.Forms.TextBox()
        Me.BandaMultiplicador = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.BtnCerrarSesion = New System.Windows.Forms.PictureBox()
        Me.FirstBand5 = New System.Windows.Forms.Label()
        Me.PrimeraBandaCinco = New System.Windows.Forms.ComboBox()
        Me.SecondBand5 = New System.Windows.Forms.Label()
        Me.SegundaBandaCinco = New System.Windows.Forms.ComboBox()
        Me.Multiplier5Band = New System.Windows.Forms.Label()
        Me.TerceraBandaCinco = New System.Windows.Forms.ComboBox()
        Me.Tolerance5Band = New System.Windows.Forms.Label()
        Me.ThirdBand = New System.Windows.Forms.Label()
        Me.ToleranciaCinco = New System.Windows.Forms.ComboBox()
        Me.MultiplicadorCinco = New System.Windows.Forms.ComboBox()
        Me.BoxCuatroB = New System.Windows.Forms.Panel()
        Me.BoxCincoB = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCerrarSesion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BoxCuatroB.SuspendLayout()
        Me.BoxCincoB.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tolerancia
        '
        Me.Tolerancia.Cursor = System.Windows.Forms.Cursors.Default
        Me.Tolerancia.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Tolerancia.FormattingEnabled = True
        Me.Tolerancia.Items.AddRange(New Object() {"2% - Rojo", "5% - Oro", "10% - Plata"})
        Me.Tolerancia.Location = New System.Drawing.Point(4, 208)
        Me.Tolerancia.Name = "Tolerancia"
        Me.Tolerancia.Size = New System.Drawing.Size(121, 23)
        Me.Tolerancia.TabIndex = 27
        Me.Tolerancia.Text = "Seleccionar"
        '
        'Multiplicador
        '
        Me.Multiplicador.FormattingEnabled = True
        Me.Multiplicador.Items.AddRange(New Object() {"x1 - Negro", "x10 - Marrón", "x100 - Rojo", "x1k - Naranja", "x10k - Amarillo", "x100k - Verde", "x1M - Azul", "x10M- Violeta", "x100M - Gris", "x1G - Blanco", "x0.1 - Oro", "x0.01 - Plata"})
        Me.Multiplicador.Location = New System.Drawing.Point(4, 148)
        Me.Multiplicador.Name = "Multiplicador"
        Me.Multiplicador.Size = New System.Drawing.Size(121, 23)
        Me.Multiplicador.TabIndex = 26
        Me.Multiplicador.Text = "Seleccionar"
        '
        'SegundaBanda
        '
        Me.SegundaBanda.FormattingEnabled = True
        Me.SegundaBanda.Items.AddRange(New Object() {"0 - Negro", "1 - Marrón", "2 - Rojo", "3 - Naranja", "4 - Amarillo", "5 - Verde", "6 - Azul", "7- Violeta", "8 - Gris", "9- Blanco"})
        Me.SegundaBanda.Location = New System.Drawing.Point(4, 94)
        Me.SegundaBanda.Name = "SegundaBanda"
        Me.SegundaBanda.Size = New System.Drawing.Size(121, 23)
        Me.SegundaBanda.TabIndex = 25
        Me.SegundaBanda.Text = "Seleccionar"
        '
        'PrimeraBanda
        '
        Me.PrimeraBanda.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.PrimeraBanda.FormattingEnabled = True
        Me.PrimeraBanda.Items.AddRange(New Object() {"0 - Negro", "1 - Marrón", "2 - Rojo", "3 - Naranja", "4 - Amarillo", "5 - Verde", "6 - Azul", "7- Violeta", "8 - Gris", "9- Blanco"})
        Me.PrimeraBanda.Location = New System.Drawing.Point(5, 35)
        Me.PrimeraBanda.Name = "PrimeraBanda"
        Me.PrimeraBanda.Size = New System.Drawing.Size(121, 23)
        Me.PrimeraBanda.TabIndex = 24
        Me.PrimeraBanda.Text = "Seleccionar"
        '
        'Tolerance4Band
        '
        Me.Tolerance4Band.AutoSize = True
        Me.Tolerance4Band.ForeColor = System.Drawing.SystemColors.Control
        Me.Tolerance4Band.Location = New System.Drawing.Point(5, 189)
        Me.Tolerance4Band.Name = "Tolerance4Band"
        Me.Tolerance4Band.Size = New System.Drawing.Size(60, 15)
        Me.Tolerance4Band.TabIndex = 8
        Me.Tolerance4Band.Text = "Tolerancia"
        '
        'Multiplier4Band
        '
        Me.Multiplier4Band.AutoSize = True
        Me.Multiplier4Band.ForeColor = System.Drawing.SystemColors.Control
        Me.Multiplier4Band.Location = New System.Drawing.Point(5, 129)
        Me.Multiplier4Band.Name = "Multiplier4Band"
        Me.Multiplier4Band.Size = New System.Drawing.Size(78, 15)
        Me.Multiplier4Band.TabIndex = 7
        Me.Multiplier4Band.Text = "Multiplicador"
        '
        'SecondBand
        '
        Me.SecondBand.AutoSize = True
        Me.SecondBand.ForeColor = System.Drawing.SystemColors.Control
        Me.SecondBand.Location = New System.Drawing.Point(5, 74)
        Me.SecondBand.Name = "SecondBand"
        Me.SecondBand.Size = New System.Drawing.Size(89, 15)
        Me.SecondBand.TabIndex = 6
        Me.SecondBand.Text = "Segunda Banda"
        '
        'FirstBand
        '
        Me.FirstBand.AutoSize = True
        Me.FirstBand.ForeColor = System.Drawing.SystemColors.Control
        Me.FirstBand.Location = New System.Drawing.Point(5, 16)
        Me.FirstBand.Name = "FirstBand"
        Me.FirstBand.Size = New System.Drawing.Size(84, 15)
        Me.FirstBand.TabIndex = 1
        Me.FirstBand.Text = "Primera Banda"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuArchive, Me.BtnAyuda})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(612, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuArchive
        '
        Me.MenuArchive.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeCalcuNormal, Me.Language})
        Me.MenuArchive.ForeColor = System.Drawing.SystemColors.Control
        Me.MenuArchive.Name = "MenuArchive"
        Me.MenuArchive.Size = New System.Drawing.Size(104, 20)
        Me.MenuArchive.Text = "HERRAMIENTAS"
        '
        'ChangeCalcuNormal
        '
        Me.ChangeCalcuNormal.Name = "ChangeCalcuNormal"
        Me.ChangeCalcuNormal.Size = New System.Drawing.Size(205, 22)
        Me.ChangeCalcuNormal.Text = "Calculadora de Windows"
        '
        'Language
        '
        Me.Language.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpanishLanguage, Me.EnglishLanguage})
        Me.Language.Name = "Language"
        Me.Language.Size = New System.Drawing.Size(205, 22)
        Me.Language.Text = "Idioma"
        '
        'SpanishLanguage
        '
        Me.SpanishLanguage.Name = "SpanishLanguage"
        Me.SpanishLanguage.Size = New System.Drawing.Size(115, 22)
        Me.SpanishLanguage.Text = "Español"
        '
        'EnglishLanguage
        '
        Me.EnglishLanguage.Name = "EnglishLanguage"
        Me.EnglishLanguage.Size = New System.Drawing.Size(115, 22)
        Me.EnglishLanguage.Text = "Ingles"
        '
        'BtnAyuda
        '
        Me.BtnAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAcercaDe})
        Me.BtnAyuda.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnAyuda.ImageTransparentColor = System.Drawing.Color.Gray
        Me.BtnAyuda.Name = "BtnAyuda"
        Me.BtnAyuda.Size = New System.Drawing.Size(57, 20)
        Me.BtnAyuda.Text = "AYUDA"
        '
        'BtnAcercaDe
        '
        Me.BtnAcercaDe.Name = "BtnAcercaDe"
        Me.BtnAcercaDe.Size = New System.Drawing.Size(198, 22)
        Me.BtnAcercaDe.Text = "Acerca de ADSI Resistor"
        '
        'RadioCuatroBandas
        '
        Me.RadioCuatroBandas.AutoSize = True
        Me.RadioCuatroBandas.Checked = True
        Me.RadioCuatroBandas.ForeColor = System.Drawing.SystemColors.Control
        Me.RadioCuatroBandas.Location = New System.Drawing.Point(73, 58)
        Me.RadioCuatroBandas.Name = "RadioCuatroBandas"
        Me.RadioCuatroBandas.Size = New System.Drawing.Size(72, 19)
        Me.RadioCuatroBandas.TabIndex = 11
        Me.RadioCuatroBandas.TabStop = True
        Me.RadioCuatroBandas.Text = "4 bandas"
        Me.RadioCuatroBandas.UseVisualStyleBackColor = True
        '
        'RadioCincoBandas
        '
        Me.RadioCincoBandas.AutoSize = True
        Me.RadioCincoBandas.ForeColor = System.Drawing.SystemColors.Control
        Me.RadioCincoBandas.Location = New System.Drawing.Point(73, 92)
        Me.RadioCincoBandas.Name = "RadioCincoBandas"
        Me.RadioCincoBandas.Size = New System.Drawing.Size(72, 19)
        Me.RadioCincoBandas.TabIndex = 12
        Me.RadioCincoBandas.Text = "5 bandas"
        Me.RadioCincoBandas.UseVisualStyleBackColor = True
        '
        'BtnReiniciar
        '
        Me.BtnReiniciar.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReiniciar.Location = New System.Drawing.Point(275, 442)
        Me.BtnReiniciar.Name = "BtnReiniciar"
        Me.BtnReiniciar.Size = New System.Drawing.Size(75, 23)
        Me.BtnReiniciar.TabIndex = 13
        Me.BtnReiniciar.Text = "Reiniciar"
        Me.BtnReiniciar.UseVisualStyleBackColor = False
        '
        'ToleranceAnswer
        '
        Me.ToleranceAnswer.AutoSize = True
        Me.ToleranceAnswer.ForeColor = System.Drawing.SystemColors.Control
        Me.ToleranceAnswer.Location = New System.Drawing.Point(369, 244)
        Me.ToleranceAnswer.Name = "ToleranceAnswer"
        Me.ToleranceAnswer.Size = New System.Drawing.Size(60, 15)
        Me.ToleranceAnswer.TabIndex = 12
        Me.ToleranceAnswer.Text = "Tolerancia"
        '
        'ResistorAnswer
        '
        Me.ResistorAnswer.AutoSize = True
        Me.ResistorAnswer.ForeColor = System.Drawing.SystemColors.Control
        Me.ResistorAnswer.Location = New System.Drawing.Point(369, 185)
        Me.ResistorAnswer.Name = "ResistorAnswer"
        Me.ResistorAnswer.Size = New System.Drawing.Size(65, 15)
        Me.ResistorAnswer.TabIndex = 11
        Me.ResistorAnswer.Text = "Resistencia"
        '
        'TxtResultadoTolerancia
        '
        Me.TxtResultadoTolerancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtResultadoTolerancia.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtResultadoTolerancia.Location = New System.Drawing.Point(369, 265)
        Me.TxtResultadoTolerancia.Name = "TxtResultadoTolerancia"
        Me.TxtResultadoTolerancia.ReadOnly = True
        Me.TxtResultadoTolerancia.Size = New System.Drawing.Size(173, 23)
        Me.TxtResultadoTolerancia.TabIndex = 10
        '
        'TxtResultado
        '
        Me.TxtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtResultado.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtResultado.Location = New System.Drawing.Point(369, 206)
        Me.TxtResultado.Name = "TxtResultado"
        Me.TxtResultado.ReadOnly = True
        Me.TxtResultado.Size = New System.Drawing.Size(173, 23)
        Me.TxtResultado.TabIndex = 9
        '
        'MinToleranceAnswer
        '
        Me.MinToleranceAnswer.AutoSize = True
        Me.MinToleranceAnswer.ForeColor = System.Drawing.SystemColors.Control
        Me.MinToleranceAnswer.Location = New System.Drawing.Point(369, 305)
        Me.MinToleranceAnswer.Name = "MinToleranceAnswer"
        Me.MinToleranceAnswer.Size = New System.Drawing.Size(104, 15)
        Me.MinToleranceAnswer.TabIndex = 15
        Me.MinToleranceAnswer.Text = "Tolerancia Minima"
        '
        'TxtResultadoToleranciaMinima
        '
        Me.TxtResultadoToleranciaMinima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtResultadoToleranciaMinima.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtResultadoToleranciaMinima.Location = New System.Drawing.Point(369, 325)
        Me.TxtResultadoToleranciaMinima.Name = "TxtResultadoToleranciaMinima"
        Me.TxtResultadoToleranciaMinima.ReadOnly = True
        Me.TxtResultadoToleranciaMinima.Size = New System.Drawing.Size(173, 23)
        Me.TxtResultadoToleranciaMinima.TabIndex = 14
        '
        'MaxToleranceAnswer
        '
        Me.MaxToleranceAnswer.AutoSize = True
        Me.MaxToleranceAnswer.ForeColor = System.Drawing.SystemColors.Control
        Me.MaxToleranceAnswer.Location = New System.Drawing.Point(369, 358)
        Me.MaxToleranceAnswer.Name = "MaxToleranceAnswer"
        Me.MaxToleranceAnswer.Size = New System.Drawing.Size(106, 15)
        Me.MaxToleranceAnswer.TabIndex = 17
        Me.MaxToleranceAnswer.Text = "Tolerancia Maxima"
        '
        'TxtResultadoToleranciaMaxima
        '
        Me.TxtResultadoToleranciaMaxima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtResultadoToleranciaMaxima.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtResultadoToleranciaMaxima.Location = New System.Drawing.Point(369, 379)
        Me.TxtResultadoToleranciaMaxima.Name = "TxtResultadoToleranciaMaxima"
        Me.TxtResultadoToleranciaMaxima.ReadOnly = True
        Me.TxtResultadoToleranciaMaxima.Size = New System.Drawing.Size(173, 23)
        Me.TxtResultadoToleranciaMaxima.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(177, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(325, 92)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'BandaUno
        '
        Me.BandaUno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BandaUno.Location = New System.Drawing.Point(206, 55)
        Me.BandaUno.Multiline = True
        Me.BandaUno.Name = "BandaUno"
        Me.BandaUno.ReadOnly = True
        Me.BandaUno.Size = New System.Drawing.Size(16, 70)
        Me.BandaUno.TabIndex = 19
        '
        'BandaTolerancia
        '
        Me.BandaTolerancia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BandaTolerancia.Location = New System.Drawing.Point(452, 55)
        Me.BandaTolerancia.Multiline = True
        Me.BandaTolerancia.Name = "BandaTolerancia"
        Me.BandaTolerancia.ReadOnly = True
        Me.BandaTolerancia.Size = New System.Drawing.Size(16, 70)
        Me.BandaTolerancia.TabIndex = 20
        '
        'BandaSegunda
        '
        Me.BandaSegunda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BandaSegunda.Location = New System.Drawing.Point(249, 64)
        Me.BandaSegunda.Multiline = True
        Me.BandaSegunda.Name = "BandaSegunda"
        Me.BandaSegunda.ReadOnly = True
        Me.BandaSegunda.Size = New System.Drawing.Size(16, 52)
        Me.BandaSegunda.TabIndex = 21
        '
        'BandaTercera
        '
        Me.BandaTercera.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BandaTercera.Location = New System.Drawing.Point(275, 64)
        Me.BandaTercera.Multiline = True
        Me.BandaTercera.Name = "BandaTercera"
        Me.BandaTercera.ReadOnly = True
        Me.BandaTercera.Size = New System.Drawing.Size(16, 52)
        Me.BandaTercera.TabIndex = 22
        '
        'BandaMultiplicador
        '
        Me.BandaMultiplicador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BandaMultiplicador.Location = New System.Drawing.Point(339, 64)
        Me.BandaMultiplicador.Multiline = True
        Me.BandaMultiplicador.Name = "BandaMultiplicador"
        Me.BandaMultiplicador.ReadOnly = True
        Me.BandaMultiplicador.Size = New System.Drawing.Size(16, 52)
        Me.BandaMultiplicador.TabIndex = 23
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(29, 46)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(0, 15)
        Me.LinkLabel1.TabIndex = 24
        '
        'BtnCerrarSesion
        '
        Me.BtnCerrarSesion.Image = CType(resources.GetObject("BtnCerrarSesion.Image"), System.Drawing.Image)
        Me.BtnCerrarSesion.Location = New System.Drawing.Point(574, 46)
        Me.BtnCerrarSesion.Name = "BtnCerrarSesion"
        Me.BtnCerrarSesion.Size = New System.Drawing.Size(26, 31)
        Me.BtnCerrarSesion.TabIndex = 25
        Me.BtnCerrarSesion.TabStop = False
        '
        'FirstBand5
        '
        Me.FirstBand5.AutoSize = True
        Me.FirstBand5.ForeColor = System.Drawing.SystemColors.Control
        Me.FirstBand5.Location = New System.Drawing.Point(4, 6)
        Me.FirstBand5.Name = "FirstBand5"
        Me.FirstBand5.Size = New System.Drawing.Size(84, 15)
        Me.FirstBand5.TabIndex = 1
        Me.FirstBand5.Text = "Primera Banda"
        '
        'PrimeraBandaCinco
        '
        Me.PrimeraBandaCinco.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PrimeraBandaCinco.FormattingEnabled = True
        Me.PrimeraBandaCinco.Items.AddRange(New Object() {"0 - Negro", "1 - Marrón", "2 - Rojo", "3 - Naranja", "4 - Amarillo", "5 - Verde", "6 - Azul", "7- Violeta", "8 - Gris", "9- Blanco"})
        Me.PrimeraBandaCinco.Location = New System.Drawing.Point(4, 24)
        Me.PrimeraBandaCinco.Name = "PrimeraBandaCinco"
        Me.PrimeraBandaCinco.Size = New System.Drawing.Size(121, 23)
        Me.PrimeraBandaCinco.TabIndex = 28
        Me.PrimeraBandaCinco.Text = "Seleccionar"
        '
        'SecondBand5
        '
        Me.SecondBand5.AutoSize = True
        Me.SecondBand5.ForeColor = System.Drawing.SystemColors.Control
        Me.SecondBand5.Location = New System.Drawing.Point(4, 59)
        Me.SecondBand5.Name = "SecondBand5"
        Me.SecondBand5.Size = New System.Drawing.Size(89, 15)
        Me.SecondBand5.TabIndex = 6
        Me.SecondBand5.Text = "Segunda Banda"
        '
        'SegundaBandaCinco
        '
        Me.SegundaBandaCinco.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SegundaBandaCinco.FormattingEnabled = True
        Me.SegundaBandaCinco.Items.AddRange(New Object() {"0 - Negro", "1 - Marrón", "2 - Rojo", "3 - Naranja", "4 - Amarillo", "5 - Verde", "6 - Azul", "7- Violeta", "8 - Gris", "9- Blanco"})
        Me.SegundaBandaCinco.Location = New System.Drawing.Point(3, 78)
        Me.SegundaBandaCinco.Name = "SegundaBandaCinco"
        Me.SegundaBandaCinco.Size = New System.Drawing.Size(121, 23)
        Me.SegundaBandaCinco.TabIndex = 29
        Me.SegundaBandaCinco.Text = "Seleccionar"
        '
        'Multiplier5Band
        '
        Me.Multiplier5Band.AutoSize = True
        Me.Multiplier5Band.ForeColor = System.Drawing.SystemColors.Control
        Me.Multiplier5Band.Location = New System.Drawing.Point(4, 164)
        Me.Multiplier5Band.Name = "Multiplier5Band"
        Me.Multiplier5Band.Size = New System.Drawing.Size(78, 15)
        Me.Multiplier5Band.TabIndex = 7
        Me.Multiplier5Band.Text = "Multiplicador"
        '
        'TerceraBandaCinco
        '
        Me.TerceraBandaCinco.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TerceraBandaCinco.FormattingEnabled = True
        Me.TerceraBandaCinco.Items.AddRange(New Object() {"0 - Negro", "1 - Marrón", "2 - Rojo", "3 - Naranja", "4 - Amarillo", "5 - Verde", "6 - Azul", "7- Violeta", "8 - Gris", "9- Blanco"})
        Me.TerceraBandaCinco.Location = New System.Drawing.Point(3, 130)
        Me.TerceraBandaCinco.Name = "TerceraBandaCinco"
        Me.TerceraBandaCinco.Size = New System.Drawing.Size(121, 23)
        Me.TerceraBandaCinco.TabIndex = 30
        Me.TerceraBandaCinco.Text = "Seleccionar"
        '
        'Tolerance5Band
        '
        Me.Tolerance5Band.AutoSize = True
        Me.Tolerance5Band.ForeColor = System.Drawing.SystemColors.Control
        Me.Tolerance5Band.Location = New System.Drawing.Point(3, 220)
        Me.Tolerance5Band.Name = "Tolerance5Band"
        Me.Tolerance5Band.Size = New System.Drawing.Size(60, 15)
        Me.Tolerance5Band.TabIndex = 8
        Me.Tolerance5Band.Text = "Tolerancia"
        '
        'ThirdBand
        '
        Me.ThirdBand.AutoSize = True
        Me.ThirdBand.ForeColor = System.Drawing.SystemColors.Control
        Me.ThirdBand.Location = New System.Drawing.Point(4, 109)
        Me.ThirdBand.Name = "ThirdBand"
        Me.ThirdBand.Size = New System.Drawing.Size(80, 15)
        Me.ThirdBand.TabIndex = 10
        Me.ThirdBand.Text = "Tercera Banda"
        '
        'ToleranciaCinco
        '
        Me.ToleranciaCinco.FormattingEnabled = True
        Me.ToleranciaCinco.Items.AddRange(New Object() {"2% - Rojo", "5% - Oro", "10% - Plata"})
        Me.ToleranciaCinco.Location = New System.Drawing.Point(3, 238)
        Me.ToleranciaCinco.Name = "ToleranciaCinco"
        Me.ToleranciaCinco.Size = New System.Drawing.Size(121, 23)
        Me.ToleranciaCinco.TabIndex = 31
        Me.ToleranciaCinco.Text = "Seleccionar"
        '
        'MultiplicadorCinco
        '
        Me.MultiplicadorCinco.FormattingEnabled = True
        Me.MultiplicadorCinco.Items.AddRange(New Object() {"x1 - Negro", "x10 - Marrón", "x100 - Rojo", "x1k - Naranja", "x10k - Amarillo", "x100k - Verde", "x1M - Azul", "x10M- Violeta", "x100M - Gris", "x1G - Blanco", "x0.1 - Oro", "x0.01 - Plata"})
        Me.MultiplicadorCinco.Location = New System.Drawing.Point(3, 182)
        Me.MultiplicadorCinco.Name = "MultiplicadorCinco"
        Me.MultiplicadorCinco.Size = New System.Drawing.Size(121, 23)
        Me.MultiplicadorCinco.TabIndex = 32
        Me.MultiplicadorCinco.Text = "Seleccionar"
        '
        'BoxCuatroB
        '
        Me.BoxCuatroB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BoxCuatroB.Controls.Add(Me.SegundaBanda)
        Me.BoxCuatroB.Controls.Add(Me.PrimeraBanda)
        Me.BoxCuatroB.Controls.Add(Me.Multiplier4Band)
        Me.BoxCuatroB.Controls.Add(Me.Tolerance4Band)
        Me.BoxCuatroB.Controls.Add(Me.SecondBand)
        Me.BoxCuatroB.Controls.Add(Me.Multiplicador)
        Me.BoxCuatroB.Controls.Add(Me.FirstBand)
        Me.BoxCuatroB.Controls.Add(Me.Tolerancia)
        Me.BoxCuatroB.Location = New System.Drawing.Point(73, 168)
        Me.BoxCuatroB.Name = "BoxCuatroB"
        Me.BoxCuatroB.Size = New System.Drawing.Size(151, 253)
        Me.BoxCuatroB.TabIndex = 26
        '
        'BoxCincoB
        '
        Me.BoxCincoB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BoxCincoB.Controls.Add(Me.SegundaBandaCinco)
        Me.BoxCincoB.Controls.Add(Me.MultiplicadorCinco)
        Me.BoxCincoB.Controls.Add(Me.FirstBand5)
        Me.BoxCincoB.Controls.Add(Me.ToleranciaCinco)
        Me.BoxCincoB.Controls.Add(Me.PrimeraBandaCinco)
        Me.BoxCincoB.Controls.Add(Me.SecondBand5)
        Me.BoxCincoB.Controls.Add(Me.ThirdBand)
        Me.BoxCincoB.Controls.Add(Me.Multiplier5Band)
        Me.BoxCincoB.Controls.Add(Me.TerceraBandaCinco)
        Me.BoxCincoB.Controls.Add(Me.Tolerance5Band)
        Me.BoxCincoB.Location = New System.Drawing.Point(72, 168)
        Me.BoxCincoB.Name = "BoxCincoB"
        Me.BoxCincoB.Size = New System.Drawing.Size(150, 278)
        Me.BoxCincoB.TabIndex = 33
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(612, 504)
        Me.Controls.Add(Me.BoxCincoB)
        Me.Controls.Add(Me.BoxCuatroB)
        Me.Controls.Add(Me.MinToleranceAnswer)
        Me.Controls.Add(Me.BtnCerrarSesion)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.BandaMultiplicador)
        Me.Controls.Add(Me.BandaTercera)
        Me.Controls.Add(Me.BandaSegunda)
        Me.Controls.Add(Me.BandaTolerancia)
        Me.Controls.Add(Me.BandaUno)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MaxToleranceAnswer)
        Me.Controls.Add(Me.ResistorAnswer)
        Me.Controls.Add(Me.TxtResultadoToleranciaMaxima)
        Me.Controls.Add(Me.TxtResultado)
        Me.Controls.Add(Me.TxtResultadoToleranciaMinima)
        Me.Controls.Add(Me.ToleranceAnswer)
        Me.Controls.Add(Me.BtnReiniciar)
        Me.Controls.Add(Me.RadioCincoBandas)
        Me.Controls.Add(Me.TxtResultadoTolerancia)
        Me.Controls.Add(Me.RadioCuatroBandas)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Calculadora de Resistencia"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCerrarSesion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BoxCuatroB.ResumeLayout(False)
        Me.BoxCuatroB.PerformLayout()
        Me.BoxCincoB.ResumeLayout(False)
        Me.BoxCincoB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Tolerance4Band As Label
    Friend WithEvents Multiplier4Band As Label
    Friend WithEvents SecondBand As Label
    Friend WithEvents FirstBand As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuArchive As ToolStripMenuItem
    Friend WithEvents CalculadoraDeWindowsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Language As ToolStripMenuItem
    Friend WithEvents EspañolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InglesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents BtnReiniciar As Button
    Friend WithEvents ToleranceAnswer As Label
    Friend WithEvents ResistorAnswer As Label
    Friend WithEvents TxtResultadoTolerancia As TextBox
    Friend WithEvents TxtResultado As TextBox
    Friend WithEvents MinToleranceAnswer As Label
    Friend WithEvents TxtResultadoToleranciaMinima As TextBox
    Friend WithEvents MaxToleranceAnswer As Label
    Friend WithEvents TxtResultadoToleranciaMaxima As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BandaUno As TextBox
    Friend WithEvents BandaTolerancia As TextBox
    Friend WithEvents BandaSegunda As TextBox
    Friend WithEvents BandaTercera As TextBox
    Friend WithEvents BandaMultiplicador As TextBox
    Friend WithEvents Tolerancia As ComboBox
    Friend WithEvents Multiplicador As ComboBox
    Friend WithEvents SegundaBanda As ComboBox
    Friend WithEvents PrimeraBanda As ComboBox
    Friend WithEvents SpanishLanguage As ToolStripMenuItem
    Friend WithEvents EnglishLanguage As ToolStripMenuItem
    Friend WithEvents ChangeCalcuNormal As ToolStripMenuItem
    Friend WithEvents RadioCuatroBandas As RadioButton
    Friend WithEvents RadioCincoBandas As RadioButton
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnCerrarSesion As PictureBox
    Friend WithEvents FirstBand5 As Label
    Friend WithEvents PrimeraBandaCinco As ComboBox
    Friend WithEvents SecondBand5 As Label
    Friend WithEvents SegundaBandaCinco As ComboBox
    Friend WithEvents Multiplier5Band As Label
    Friend WithEvents TerceraBandaCinco As ComboBox
    Friend WithEvents Tolerance5Band As Label
    Friend WithEvents ThirdBand As Label
    Friend WithEvents ToleranciaCinco As ComboBox
    Friend WithEvents MultiplicadorCinco As ComboBox
    Friend WithEvents BoxCuatroB As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BoxCincoB As Panel
    Friend WithEvents BtnAyuda As ToolStripMenuItem
    Friend WithEvents BtnAcercaDe As ToolStripMenuItem
End Class
