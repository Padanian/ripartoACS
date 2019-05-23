<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTariffe
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formTariffe))
        Me.MetroGrid = New MetroFramework.Controls.MetroGrid()
        Me.daMC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.aMC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quota_Fissa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tariffa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Componente_U1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Componente_U2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Componente_U3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroLabel31 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel30 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel29 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel28 = New MetroFramework.Controls.MetroLabel()
        Me.RipartoACSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mtSalvaTariffe = New MetroFramework.Controls.MetroTile()
        CType(Me.MetroGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RipartoACSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroGrid
        '
        Me.MetroGrid.AllowUserToAddRows = False
        Me.MetroGrid.AllowUserToDeleteRows = False
        Me.MetroGrid.AllowUserToResizeColumns = False
        Me.MetroGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MetroGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.MetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.MetroGrid.ColumnHeadersHeight = 25
        Me.MetroGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.daMC, Me.aMC, Me.Quota_Fissa, Me.Tariffa, Me.Componente_U1, Me.Componente_U2, Me.Componente_U3})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid.DefaultCellStyle = DataGridViewCellStyle7
        Me.MetroGrid.EnableHeadersVisualStyles = False
        Me.MetroGrid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid.Location = New System.Drawing.Point(176, 38)
        Me.MetroGrid.Name = "MetroGrid"
        Me.MetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.MetroGrid.RowHeadersVisible = False
        Me.MetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid.Size = New System.Drawing.Size(449, 118)
        Me.MetroGrid.TabIndex = 2
        '
        'daMC
        '
        Me.daMC.HeaderText = "Da mc/anno"
        Me.daMC.Name = "daMC"
        Me.daMC.Width = 75
        '
        'aMC
        '
        Me.aMC.HeaderText = "A mc/anno"
        Me.aMC.Name = "aMC"
        Me.aMC.Width = 70
        '
        'Quota_Fissa
        '
        Me.Quota_Fissa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Quota_Fissa.HeaderText = "Q.ta Fissa"
        Me.Quota_Fissa.Name = "Quota_Fissa"
        Me.Quota_Fissa.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Quota_Fissa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Tariffa
        '
        Me.Tariffa.HeaderText = "Tariffa"
        Me.Tariffa.Name = "Tariffa"
        Me.Tariffa.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Tariffa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Tariffa.Width = 60
        '
        'Componente_U1
        '
        Me.Componente_U1.HeaderText = "U1"
        Me.Componente_U1.Name = "Componente_U1"
        Me.Componente_U1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Componente_U1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Componente_U1.Width = 60
        '
        'Componente_U2
        '
        Me.Componente_U2.HeaderText = "U2"
        Me.Componente_U2.Name = "Componente_U2"
        Me.Componente_U2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Componente_U2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Componente_U2.Width = 60
        '
        'Componente_U3
        '
        Me.Componente_U3.HeaderText = "U3"
        Me.Componente_U3.Name = "Componente_U3"
        Me.Componente_U3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Componente_U3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Componente_U3.Width = 60
        '
        'MetroLabel31
        '
        Me.MetroLabel31.AutoSize = True
        Me.MetroLabel31.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel31.Location = New System.Drawing.Point(103, 132)
        Me.MetroLabel31.Name = "MetroLabel31"
        Me.MetroLabel31.Size = New System.Drawing.Size(67, 15)
        Me.MetroLabel31.TabIndex = 3
        Me.MetroLabel31.Text = "Eccedenza 1"
        '
        'MetroLabel30
        '
        Me.MetroLabel30.AutoSize = True
        Me.MetroLabel30.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel30.Location = New System.Drawing.Point(110, 112)
        Me.MetroLabel30.Name = "MetroLabel30"
        Me.MetroLabel30.Size = New System.Drawing.Size(60, 15)
        Me.MetroLabel30.TabIndex = 4
        Me.MetroLabel30.Text = "Eccedenza"
        '
        'MetroLabel29
        '
        Me.MetroLabel29.AutoSize = True
        Me.MetroLabel29.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel29.Location = New System.Drawing.Point(139, 92)
        Me.MetroLabel29.Name = "MetroLabel29"
        Me.MetroLabel29.Size = New System.Drawing.Size(31, 15)
        Me.MetroLabel29.TabIndex = 5
        Me.MetroLabel29.Text = "Base"
        '
        'MetroLabel28
        '
        Me.MetroLabel28.AutoSize = True
        Me.MetroLabel28.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel28.Location = New System.Drawing.Point(112, 72)
        Me.MetroLabel28.Name = "MetroLabel28"
        Me.MetroLabel28.Size = New System.Drawing.Size(58, 15)
        Me.MetroLabel28.TabIndex = 6
        Me.MetroLabel28.Text = "Agevolata"
        '
        'mtSalvaTariffe
        '
        Me.mtSalvaTariffe.ActiveControl = Nothing
        Me.mtSalvaTariffe.Location = New System.Drawing.Point(23, 80)
        Me.mtSalvaTariffe.Name = "mtSalvaTariffe"
        Me.mtSalvaTariffe.Size = New System.Drawing.Size(64, 64)
        Me.mtSalvaTariffe.Style = MetroFramework.MetroColorStyle.Magenta
        Me.mtSalvaTariffe.TabIndex = 7
        Me.mtSalvaTariffe.Text = "Salva"
        Me.mtSalvaTariffe.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtSalvaTariffe.UseSelectable = True
        '
        'formTariffe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 178)
        Me.Controls.Add(Me.mtSalvaTariffe)
        Me.Controls.Add(Me.MetroLabel31)
        Me.Controls.Add(Me.MetroLabel30)
        Me.Controls.Add(Me.MetroLabel29)
        Me.Controls.Add(Me.MetroLabel28)
        Me.Controls.Add(Me.MetroGrid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formTariffe"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Tariffe"
        CType(Me.MetroGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RipartoACSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroGrid As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroLabel31 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel30 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel29 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel28 As MetroFramework.Controls.MetroLabel
    Friend WithEvents RipartoACSBindingSource As BindingSource
    Friend WithEvents mtSalvaTariffe As MetroFramework.Controls.MetroTile
    Friend WithEvents daMC As DataGridViewTextBoxColumn
    Friend WithEvents aMC As DataGridViewTextBoxColumn
    Friend WithEvents Quota_Fissa As DataGridViewTextBoxColumn
    Friend WithEvents Tariffa As DataGridViewTextBoxColumn
    Friend WithEvents Componente_U1 As DataGridViewTextBoxColumn
    Friend WithEvents Componente_U2 As DataGridViewTextBoxColumn
    Friend WithEvents Componente_U3 As DataGridViewTextBoxColumn
End Class
