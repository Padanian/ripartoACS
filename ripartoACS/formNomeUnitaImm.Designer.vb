<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class formNomeUnitaImm
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formNomeUnitaImm))
        Me.tbNomeUnitaImm = New MetroFramework.Controls.MetroTextBox()
        Me.OK = New MetroFramework.Controls.MetroTile()
        Me.Cancel = New MetroFramework.Controls.MetroTile()
        Me.SuspendLayout()
        '
        'tbNomeUnitaImm
        '
        '
        '
        '
        Me.tbNomeUnitaImm.CustomButton.Image = Nothing
        Me.tbNomeUnitaImm.CustomButton.Location = New System.Drawing.Point(233, 1)
        Me.tbNomeUnitaImm.CustomButton.Name = ""
        Me.tbNomeUnitaImm.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbNomeUnitaImm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbNomeUnitaImm.CustomButton.TabIndex = 1
        Me.tbNomeUnitaImm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbNomeUnitaImm.CustomButton.UseSelectable = True
        Me.tbNomeUnitaImm.CustomButton.Visible = False
        Me.tbNomeUnitaImm.Lines = New String(-1) {}
        Me.tbNomeUnitaImm.Location = New System.Drawing.Point(63, 57)
        Me.tbNomeUnitaImm.MaxLength = 32767
        Me.tbNomeUnitaImm.Name = "tbNomeUnitaImm"
        Me.tbNomeUnitaImm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNomeUnitaImm.WaterMark = "Inserire nome unità immobiliare..."
        Me.tbNomeUnitaImm.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbNomeUnitaImm.SelectedText = ""
        Me.tbNomeUnitaImm.SelectionLength = 0
        Me.tbNomeUnitaImm.SelectionStart = 0
        Me.tbNomeUnitaImm.ShortcutsEnabled = True
        Me.tbNomeUnitaImm.Size = New System.Drawing.Size(255, 23)
        Me.tbNomeUnitaImm.TabIndex = 6
        Me.tbNomeUnitaImm.UseSelectable = True
        Me.tbNomeUnitaImm.WaterMark = "Inserire nome unità immobiliare..."
        Me.tbNomeUnitaImm.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbNomeUnitaImm.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'OK
        '
        Me.OK.ActiveControl = Nothing
        Me.OK.Location = New System.Drawing.Point(162, 106)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(75, 75)
        Me.OK.Style = MetroFramework.MetroColorStyle.Green
        Me.OK.TabIndex = 7
        Me.OK.Text = "OK"
        Me.OK.UseSelectable = True
        '
        'Cancel
        '
        Me.Cancel.ActiveControl = Nothing
        Me.Cancel.Location = New System.Drawing.Point(243, 106)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 75)
        Me.Cancel.Style = MetroFramework.MetroColorStyle.Red
        Me.Cancel.TabIndex = 7
        Me.Cancel.Text = "Annulla"
        Me.Cancel.UseSelectable = True
        '
        'formNomeUnitaImm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(359, 202)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.tbNomeUnitaImm)
        Me.DisplayHeader = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formNomeUnitaImm"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nome unità immobiliare"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbNomeUnitaImm As MetroFramework.Controls.MetroTextBox
    Friend WithEvents OK As MetroFramework.Controls.MetroTile
    Friend WithEvents Cancel As MetroFramework.Controls.MetroTile
End Class
