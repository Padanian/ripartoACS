Public Class formNomeUnitaImm

    ' TODO: inserire il codice per l'esecuzione dell'autenticazione personalizzata tramite il nome utente e la password forniti 
    ' Vedere https://go.microsoft.com/fwlink/?LinkId=35339.  
    ' L'entità personalizzata può essere quindi collegata all'entità del thread corrente nel modo seguente: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' dove CustomPrincipal è l'implementazione di IPrincipal utilizzata per eseguire l'autenticazione. 
    ' My.User restituirà quindi informazioni sull'identità incapsulate nell'oggetto CustomPrincipal,
    ' quali il nome utente, il nome visualizzato e così via.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        ripartoAS.NomeUnitaImmobiliare = tbNomeUnitaImm.Text
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        ripartoAS.NomeUnitaImmobiliare = ""
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        If e.KeyChar = Chr(Keys.Enter) Then OK.PerformClick()

    End Sub
End Class
