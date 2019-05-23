Public NotInheritable Class formAboutBox

    Private Sub formAboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Imposta il titolo del form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("Informazioni su {0}", ApplicationTitle)
        ' Inizializza tutto il testo visualizzato nella finestra di dialogo Informazioni su.
        ' TODO: Personalizzare le informazioni sull'assembly dell'applicazione nel riquadro "Applicazione" 
        '    della finestra delle proprietà del progetto (accessibile dal menu "Progetto").
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Versione {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = "Software per la ripartizione dell'acqua sanitaria nei condomini fino a 12 unità immobiliari." & vbCrLf &
            "" & vbCrLf &
            "Funzioni principali: " & vbCrLf &
            "- Ripartizione a quote fisse/consumo a percentuale" & vbCrLf &
            "- Ripartizione secondo tariffe ARERA 2018" & vbCrLf &
            "- Tariffazione separata per residenti e non residenti e numero di occupanti" & vbCrLf &
            "- Tariffazione separata per oneri acquedotto/depurazione/fognatura" & vbCrLf &
            "- Titolazione unità immobiliari" & vbCrLf &
            "- Salvataggio/apertura ripartizioni e esportazione verso .csv"

    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

End Class
