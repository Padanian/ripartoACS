<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formRipartizione
    Inherits MetroFramework.Forms.MetroForm

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formRipartizione))
        Me.tabellaRipartizione = New MetroFramework.Controls.MetroGrid()
        Me.Unità_immobiliare = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuotaMM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quota_consumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Totale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.tabellaRipartizioneARERA = New MetroFramework.Controls.MetroGrid()
        Me.Quota_fissa_ARERA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quota_agevolata_ARERA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quota_base_ARERA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quota_Eccedenza_ARERA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quota_eccedenza1_ARERA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Totale_ARERA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEsportaCSV = New MetroFramework.Controls.MetroTile()
        Me.btnClose = New MetroFramework.Controls.MetroTile()
        CType(Me.tabellaRipartizione, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabellaRipartizioneARERA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabellaRipartizione
        '
        Me.tabellaRipartizione.AllowUserToAddRows = False
        Me.tabellaRipartizione.AllowUserToDeleteRows = False
        Me.tabellaRipartizione.AllowUserToResizeColumns = False
        Me.tabellaRipartizione.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tabellaRipartizione.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.tabellaRipartizione.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabellaRipartizione.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tabellaRipartizione.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.tabellaRipartizione.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabellaRipartizione.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.tabellaRipartizione.ColumnHeadersHeight = 25
        Me.tabellaRipartizione.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Unità_immobiliare, Me.QuotaMM, Me.Quota_consumo, Me.Totale})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabellaRipartizione.DefaultCellStyle = DataGridViewCellStyle7
        Me.tabellaRipartizione.EnableHeadersVisualStyles = False
        Me.tabellaRipartizione.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tabellaRipartizione.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabellaRipartizione.Location = New System.Drawing.Point(8, 42)
        Me.tabellaRipartizione.Name = "tabellaRipartizione"
        Me.tabellaRipartizione.ReadOnly = True
        Me.tabellaRipartizione.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabellaRipartizione.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.tabellaRipartizione.RowHeadersVisible = False
        Me.tabellaRipartizione.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.tabellaRipartizione.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabellaRipartizione.Size = New System.Drawing.Size(453, 243)
        Me.tabellaRipartizione.TabIndex = 3
        '
        'Unità_immobiliare
        '
        Me.Unità_immobiliare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Unità_immobiliare.DefaultCellStyle = DataGridViewCellStyle3
        Me.Unità_immobiliare.HeaderText = "Unità immobiliare"
        Me.Unità_immobiliare.Name = "Unità_immobiliare"
        Me.Unità_immobiliare.ReadOnly = True
        Me.Unità_immobiliare.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'QuotaMM
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.QuotaMM.DefaultCellStyle = DataGridViewCellStyle4
        Me.QuotaMM.HeaderText = "Quota a mm"
        Me.QuotaMM.Name = "QuotaMM"
        Me.QuotaMM.ReadOnly = True
        Me.QuotaMM.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.QuotaMM.Width = 80
        '
        'Quota_consumo
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Quota_consumo.DefaultCellStyle = DataGridViewCellStyle5
        Me.Quota_consumo.HeaderText = "Q. consumo"
        Me.Quota_consumo.Name = "Quota_consumo"
        Me.Quota_consumo.ReadOnly = True
        Me.Quota_consumo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Quota_consumo.Width = 80
        '
        'Totale
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Totale.DefaultCellStyle = DataGridViewCellStyle6
        Me.Totale.HeaderText = "Totale"
        Me.Totale.Name = "Totale"
        Me.Totale.ReadOnly = True
        Me.Totale.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Totale.Width = 80
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(243, 14)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(145, 19)
        Me.MetroLabel1.TabIndex = 4
        Me.MetroLabel1.Text = "Ripartizione a millesimi"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(703, 14)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(154, 19)
        Me.MetroLabel2.TabIndex = 5
        Me.MetroLabel2.Text = "Ripartizione ARERA 2018"
        '
        'tabellaRipartizioneARERA
        '
        Me.tabellaRipartizioneARERA.AllowUserToAddRows = False
        Me.tabellaRipartizioneARERA.AllowUserToDeleteRows = False
        Me.tabellaRipartizioneARERA.AllowUserToResizeColumns = False
        Me.tabellaRipartizioneARERA.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tabellaRipartizioneARERA.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.tabellaRipartizioneARERA.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabellaRipartizioneARERA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tabellaRipartizioneARERA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.tabellaRipartizioneARERA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabellaRipartizioneARERA.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.tabellaRipartizioneARERA.ColumnHeadersHeight = 25
        Me.tabellaRipartizioneARERA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Quota_fissa_ARERA, Me.Quota_agevolata_ARERA, Me.Quota_base_ARERA, Me.Quota_Eccedenza_ARERA, Me.Quota_eccedenza1_ARERA, Me.Totale_ARERA})
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabellaRipartizioneARERA.DefaultCellStyle = DataGridViewCellStyle17
        Me.tabellaRipartizioneARERA.EnableHeadersVisualStyles = False
        Me.tabellaRipartizioneARERA.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tabellaRipartizioneARERA.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabellaRipartizioneARERA.Location = New System.Drawing.Point(465, 42)
        Me.tabellaRipartizioneARERA.Name = "tabellaRipartizioneARERA"
        Me.tabellaRipartizioneARERA.ReadOnly = True
        Me.tabellaRipartizioneARERA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabellaRipartizioneARERA.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.tabellaRipartizioneARERA.RowHeadersVisible = False
        Me.tabellaRipartizioneARERA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.tabellaRipartizioneARERA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabellaRipartizioneARERA.Size = New System.Drawing.Size(547, 243)
        Me.tabellaRipartizioneARERA.TabIndex = 3
        '
        'Quota_fissa_ARERA
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Quota_fissa_ARERA.DefaultCellStyle = DataGridViewCellStyle11
        Me.Quota_fissa_ARERA.HeaderText = "Quota fissa"
        Me.Quota_fissa_ARERA.Name = "Quota_fissa_ARERA"
        Me.Quota_fissa_ARERA.ReadOnly = True
        Me.Quota_fissa_ARERA.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Quota_fissa_ARERA.Width = 80
        '
        'Quota_agevolata_ARERA
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Quota_agevolata_ARERA.DefaultCellStyle = DataGridViewCellStyle12
        Me.Quota_agevolata_ARERA.HeaderText = "Q.ta agevol."
        Me.Quota_agevolata_ARERA.Name = "Quota_agevolata_ARERA"
        Me.Quota_agevolata_ARERA.ReadOnly = True
        Me.Quota_agevolata_ARERA.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Quota_agevolata_ARERA.Width = 80
        '
        'Quota_base_ARERA
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Quota_base_ARERA.DefaultCellStyle = DataGridViewCellStyle13
        Me.Quota_base_ARERA.HeaderText = "Quota base"
        Me.Quota_base_ARERA.Name = "Quota_base_ARERA"
        Me.Quota_base_ARERA.ReadOnly = True
        Me.Quota_base_ARERA.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Quota_base_ARERA.Width = 80
        '
        'Quota_Eccedenza_ARERA
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Quota_Eccedenza_ARERA.DefaultCellStyle = DataGridViewCellStyle14
        Me.Quota_Eccedenza_ARERA.HeaderText = "Q.ta eccedenza"
        Me.Quota_Eccedenza_ARERA.Name = "Quota_Eccedenza_ARERA"
        Me.Quota_Eccedenza_ARERA.ReadOnly = True
        Me.Quota_Eccedenza_ARERA.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Quota_eccedenza1_ARERA
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Quota_eccedenza1_ARERA.DefaultCellStyle = DataGridViewCellStyle15
        Me.Quota_eccedenza1_ARERA.HeaderText = "Q.ta eccedenza 1"
        Me.Quota_eccedenza1_ARERA.Name = "Quota_eccedenza1_ARERA"
        Me.Quota_eccedenza1_ARERA.ReadOnly = True
        '
        'Totale_ARERA
        '
        Me.Totale_ARERA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Totale_ARERA.DefaultCellStyle = DataGridViewCellStyle16
        Me.Totale_ARERA.HeaderText = "Totale"
        Me.Totale_ARERA.Name = "Totale_ARERA"
        Me.Totale_ARERA.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(462, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(2, 285)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'btnEsportaCSV
        '
        Me.btnEsportaCSV.ActiveControl = Nothing
        Me.btnEsportaCSV.Location = New System.Drawing.Point(814, 315)
        Me.btnEsportaCSV.Name = "btnEsportaCSV"
        Me.btnEsportaCSV.Size = New System.Drawing.Size(96, 48)
        Me.btnEsportaCSV.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEsportaCSV.TabIndex = 7
        Me.btnEsportaCSV.Text = "Esporta CSV"
        Me.btnEsportaCSV.UseSelectable = True
        '
        'btnClose
        '
        Me.btnClose.ActiveControl = Nothing
        Me.btnClose.Location = New System.Drawing.Point(916, 315)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(96, 48)
        Me.btnClose.Style = MetroFramework.MetroColorStyle.Red
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Chiudi"
        Me.btnClose.UseSelectable = True
        '
        'formRipartizione
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 386)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnEsportaCSV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.tabellaRipartizioneARERA)
        Me.Controls.Add(Me.tabellaRipartizione)
        Me.DisplayHeader = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "formRipartizione"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        CType(Me.tabellaRipartizione, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabellaRipartizioneARERA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tabellaRipartizione As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tabellaRipartizioneARERA As MetroFramework.Controls.MetroGrid
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Quota_fissa_ARERA As DataGridViewTextBoxColumn
    Friend WithEvents Quota_agevolata_ARERA As DataGridViewTextBoxColumn
    Friend WithEvents Quota_base_ARERA As DataGridViewTextBoxColumn
    Friend WithEvents Quota_Eccedenza_ARERA As DataGridViewTextBoxColumn
    Friend WithEvents Quota_eccedenza1_ARERA As DataGridViewTextBoxColumn
    Friend WithEvents Totale_ARERA As DataGridViewTextBoxColumn
    Friend WithEvents btnEsportaCSV As MetroFramework.Controls.MetroTile
    Friend WithEvents btnClose As MetroFramework.Controls.MetroTile
    Friend WithEvents Unità_immobiliare As DataGridViewTextBoxColumn
    Friend WithEvents QuotaMM As DataGridViewTextBoxColumn
    Friend WithEvents Quota_consumo As DataGridViewTextBoxColumn
    Friend WithEvents Totale As DataGridViewTextBoxColumn
End Class
