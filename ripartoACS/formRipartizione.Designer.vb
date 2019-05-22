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
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabellaRipartizione = New MetroFramework.Controls.MetroGrid()
        Me.Unità_immobiliare = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuotaMM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quota_consumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Totale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.tabellaRipartizioneARERA = New MetroFramework.Controls.MetroGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Quota_fissa_ARERA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quota_agevolata_ARERA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quota_base_ARERA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quota_Eccedenza_ARERA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quota_eccedenza1_ARERA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Totale_ARERA = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.tabellaRipartizione.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabellaRipartizione.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tabellaRipartizione.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.tabellaRipartizione.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabellaRipartizione.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.tabellaRipartizione.ColumnHeadersHeight = 25
        Me.tabellaRipartizione.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Unità_immobiliare, Me.QuotaMM, Me.Quota_consumo, Me.Totale})
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabellaRipartizione.DefaultCellStyle = DataGridViewCellStyle20
        Me.tabellaRipartizione.EnableHeadersVisualStyles = False
        Me.tabellaRipartizione.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tabellaRipartizione.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabellaRipartizione.Location = New System.Drawing.Point(8, 42)
        Me.tabellaRipartizione.Name = "tabellaRipartizione"
        Me.tabellaRipartizione.ReadOnly = True
        Me.tabellaRipartizione.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabellaRipartizione.RowHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.tabellaRipartizione.RowHeadersVisible = False
        Me.tabellaRipartizione.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.tabellaRipartizione.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabellaRipartizione.Size = New System.Drawing.Size(453, 243)
        Me.tabellaRipartizione.TabIndex = 3
        '
        'Unità_immobiliare
        '
        Me.Unità_immobiliare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Unità_immobiliare.DefaultCellStyle = DataGridViewCellStyle16
        Me.Unità_immobiliare.HeaderText = "Unità immobiliare"
        Me.Unità_immobiliare.Name = "Unità_immobiliare"
        Me.Unità_immobiliare.ReadOnly = True
        Me.Unità_immobiliare.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'QuotaMM
        '
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.QuotaMM.DefaultCellStyle = DataGridViewCellStyle17
        Me.QuotaMM.HeaderText = "Quota a mm"
        Me.QuotaMM.Name = "QuotaMM"
        Me.QuotaMM.ReadOnly = True
        Me.QuotaMM.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.QuotaMM.Width = 85
        '
        'Quota_consumo
        '
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Quota_consumo.DefaultCellStyle = DataGridViewCellStyle18
        Me.Quota_consumo.HeaderText = "Q.ta consumo"
        Me.Quota_consumo.Name = "Quota_consumo"
        Me.Quota_consumo.ReadOnly = True
        Me.Quota_consumo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Quota_consumo.Width = 85
        '
        'Totale
        '
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Totale.DefaultCellStyle = DataGridViewCellStyle19
        Me.Totale.HeaderText = "Totale"
        Me.Totale.Name = "Totale"
        Me.Totale.ReadOnly = True
        Me.Totale.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Totale.Width = 85
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
        Me.tabellaRipartizioneARERA.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabellaRipartizioneARERA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tabellaRipartizioneARERA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.tabellaRipartizioneARERA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabellaRipartizioneARERA.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.tabellaRipartizioneARERA.ColumnHeadersHeight = 25
        Me.tabellaRipartizioneARERA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Quota_fissa_ARERA, Me.Quota_agevolata_ARERA, Me.Quota_base_ARERA, Me.Quota_Eccedenza_ARERA, Me.Quota_eccedenza1_ARERA, Me.Totale_ARERA})
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabellaRipartizioneARERA.DefaultCellStyle = DataGridViewCellStyle27
        Me.tabellaRipartizioneARERA.EnableHeadersVisualStyles = False
        Me.tabellaRipartizioneARERA.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tabellaRipartizioneARERA.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabellaRipartizioneARERA.Location = New System.Drawing.Point(465, 42)
        Me.tabellaRipartizioneARERA.Name = "tabellaRipartizioneARERA"
        Me.tabellaRipartizioneARERA.ReadOnly = True
        Me.tabellaRipartizioneARERA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabellaRipartizioneARERA.RowHeadersDefaultCellStyle = DataGridViewCellStyle28
        Me.tabellaRipartizioneARERA.RowHeadersVisible = False
        Me.tabellaRipartizioneARERA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.tabellaRipartizioneARERA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabellaRipartizioneARERA.Size = New System.Drawing.Size(547, 243)
        Me.tabellaRipartizioneARERA.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(462, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(2, 285)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Quota_fissa_ARERA
        '
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Quota_fissa_ARERA.DefaultCellStyle = DataGridViewCellStyle23
        Me.Quota_fissa_ARERA.HeaderText = "Quota fissa"
        Me.Quota_fissa_ARERA.Name = "Quota_fissa_ARERA"
        Me.Quota_fissa_ARERA.ReadOnly = True
        Me.Quota_fissa_ARERA.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Quota_fissa_ARERA.Width = 80
        '
        'Quota_agevolata_ARERA
        '
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Quota_agevolata_ARERA.DefaultCellStyle = DataGridViewCellStyle24
        Me.Quota_agevolata_ARERA.HeaderText = "Q.ta agevol."
        Me.Quota_agevolata_ARERA.Name = "Quota_agevolata_ARERA"
        Me.Quota_agevolata_ARERA.ReadOnly = True
        Me.Quota_agevolata_ARERA.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Quota_agevolata_ARERA.Width = 80
        '
        'Quota_base_ARERA
        '
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Quota_base_ARERA.DefaultCellStyle = DataGridViewCellStyle25
        Me.Quota_base_ARERA.HeaderText = "Quota base"
        Me.Quota_base_ARERA.Name = "Quota_base_ARERA"
        Me.Quota_base_ARERA.ReadOnly = True
        Me.Quota_base_ARERA.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Quota_base_ARERA.Width = 80
        '
        'Quota_Eccedenza_ARERA
        '
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Quota_Eccedenza_ARERA.DefaultCellStyle = DataGridViewCellStyle26
        Me.Quota_Eccedenza_ARERA.HeaderText = "Q.ta eccedenza"
        Me.Quota_Eccedenza_ARERA.Name = "Quota_Eccedenza_ARERA"
        Me.Quota_Eccedenza_ARERA.ReadOnly = True
        Me.Quota_Eccedenza_ARERA.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Quota_eccedenza1_ARERA
        '
        Me.Quota_eccedenza1_ARERA.HeaderText = "Q.ta eccedenza 1"
        Me.Quota_eccedenza1_ARERA.Name = "Quota_eccedenza1_ARERA"
        Me.Quota_eccedenza1_ARERA.ReadOnly = True
        '
        'Totale_ARERA
        '
        Me.Totale_ARERA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Totale_ARERA.HeaderText = "Totale"
        Me.Totale_ARERA.Name = "Totale_ARERA"
        Me.Totale_ARERA.ReadOnly = True
        '
        'formRipartizione
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 308)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.tabellaRipartizioneARERA)
        Me.Controls.Add(Me.tabellaRipartizione)
        Me.DisplayHeader = False
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
    Friend WithEvents Unità_immobiliare As DataGridViewTextBoxColumn
    Friend WithEvents QuotaMM As DataGridViewTextBoxColumn
    Friend WithEvents Quota_consumo As DataGridViewTextBoxColumn
    Friend WithEvents Totale As DataGridViewTextBoxColumn
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
End Class
