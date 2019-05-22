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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabellaRipartizione = New MetroFramework.Controls.MetroGrid()
        Me.Unità_immobiliare = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuotaMM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quota_consumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Totale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.tabellaRipartizione, System.ComponentModel.ISupportInitialize).BeginInit()
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabellaRipartizione.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tabellaRipartizione.ColumnHeadersHeight = 25
        Me.tabellaRipartizione.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Unità_immobiliare, Me.QuotaMM, Me.Quota_consumo, Me.Totale})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabellaRipartizione.DefaultCellStyle = DataGridViewCellStyle6
        Me.tabellaRipartizione.EnableHeadersVisualStyles = False
        Me.tabellaRipartizione.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tabellaRipartizione.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabellaRipartizione.Location = New System.Drawing.Point(6, 42)
        Me.tabellaRipartizione.Name = "tabellaRipartizione"
        Me.tabellaRipartizione.ReadOnly = True
        Me.tabellaRipartizione.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabellaRipartizione.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.tabellaRipartizione.RowHeadersVisible = False
        Me.tabellaRipartizione.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.tabellaRipartizione.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabellaRipartizione.Size = New System.Drawing.Size(521, 243)
        Me.tabellaRipartizione.TabIndex = 3
        '
        'Unità_immobiliare
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Unità_immobiliare.DefaultCellStyle = DataGridViewCellStyle2
        Me.Unità_immobiliare.HeaderText = "Unità immobiliare"
        Me.Unità_immobiliare.Name = "Unità_immobiliare"
        Me.Unità_immobiliare.ReadOnly = True
        Me.Unità_immobiliare.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Unità_immobiliare.Width = 200
        '
        'QuotaMM
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.QuotaMM.DefaultCellStyle = DataGridViewCellStyle3
        Me.QuotaMM.HeaderText = "Quota a mm"
        Me.QuotaMM.Name = "QuotaMM"
        Me.QuotaMM.ReadOnly = True
        Me.QuotaMM.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Quota_consumo
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Quota_consumo.DefaultCellStyle = DataGridViewCellStyle4
        Me.Quota_consumo.HeaderText = "Quota a consumo"
        Me.Quota_consumo.Name = "Quota_consumo"
        Me.Quota_consumo.ReadOnly = True
        Me.Quota_consumo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Quota_consumo.Width = 110
        '
        'Totale
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Totale.DefaultCellStyle = DataGridViewCellStyle5
        Me.Totale.HeaderText = "Totale"
        Me.Totale.Name = "Totale"
        Me.Totale.ReadOnly = True
        Me.Totale.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Totale.Width = 110
        '
        'formRipartizione
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 308)
        Me.Controls.Add(Me.tabellaRipartizione)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.Name = "formRipartizione"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        CType(Me.tabellaRipartizione, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabellaRipartizione As MetroFramework.Controls.MetroGrid
    Friend WithEvents Unità_immobiliare As DataGridViewTextBoxColumn
    Friend WithEvents QuotaMM As DataGridViewTextBoxColumn
    Friend WithEvents Quota_consumo As DataGridViewTextBoxColumn
    Friend WithEvents Totale As DataGridViewTextBoxColumn
End Class
