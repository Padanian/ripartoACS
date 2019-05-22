Imports System.IO

Public Class ripartoACS

    Public NomeUnitaImmobiliare As String
    Public mySender As String
    Public tariffaResidentiAcquedotto(,) As Double = {
    {0, 19, 16.813, 0.538, 0.004, 0.009, 0.005},
    {20, 55, 0, 0.672, 0.004, 0.009, 0.005},
    {56, 75, 0, 1.21, 0.004, 0.009, 0.005},
    {76, 9999, 0, 1.815, 0.004, 0.009, 0.005}
    }
    Public tariffaResidentiFognatura(,) As Double = {
    {0, 19, 6.725, 0.336, 0.004, 0.009, 0},
    {20, 55, 0, 0.336, 0.004, 0.009, 0},
    {56, 75, 0, 0.336, 0.004, 0.009, 0},
    {76, 9999, 0, 0.336, 0.004, 0.009, 0}
    }
    Public tariffaResidentiDepurazione(,) As Double = {
    {0, 19, 10.088, 0.632, 0.004, 0.009, 0},
    {20, 55, 0, 0.632, 0.004, 0.009, 0},
    {56, 75, 0, 0.632, 0.004, 0.009, 0},
    {76, 9999, 0, 0.632, 0.004, 0.009, 0}
    }
    Public tariffaNonResidentiAcquedotto(,) As Double = {
    {0, 0, 0, 0, 0, 0, 0},
    {0, 38, 33.625, 0.672, 0.004, 0.009, 0.005},
    {39, 9999, 0, 1.815, 0.004, 0.009, 0.005},
    {0, 0, 0, 0, 0, 0, 0}
    }
    Public tariffaNonResidentiFognatura(,) As Double = {
    {0, 0, 0, 0, 0, 0, 0},
    {0, 38, 13.45, 0.336, 0.004, 0.009, 0},
    {39, 9999, 0, 0.336, 0.004, 0.009, 0},
    {0, 0, 0, 0, 0, 0, 0}
    }
    Public tariffaNonResidentiDepurazione(,) As Double = {
    {0, 0, 0, 0, 0, 0, 0},
    {0, 38, 20.175, 0.632, 0.004, 0.009, 0},
    {39, 9999, 0, 0.632, 0.004, 0.009, 0},
    {0, 0, 0, 0, 0, 0, 0}
    }
    Private Sub MetroTile5_Click(sender As Object, e As EventArgs) Handles MetroTile5.Click

        Dim sfd As New SaveFileDialog
        sfd.Filter = "File di riparto (*.racs)|*.racs|Tutti i file|*.*"
#If DEBUG Then
        'sfd.InitialDirectory = Path.GetTempPath
#End If
        Dim result As DialogResult = sfd.ShowDialog()

        If result = DialogResult.Cancel Then Exit Sub

        Dim fStream As New FileStream(sfd.FileName, FileMode.OpenOrCreate)

        Try
            Dim bf As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter


            bf.Serialize(fStream, tariffaResidentiAcquedotto)
            bf.Serialize(fStream, tariffaResidentiFognatura)
            bf.Serialize(fStream, tariffaResidentiDepurazione)
            bf.Serialize(fStream, tariffaNonResidentiAcquedotto)
            bf.Serialize(fStream, tariffaNonResidentiFognatura)
            bf.Serialize(fStream, tariffaNonResidentiDepurazione)
            bf.Serialize(fStream, nupPercentualeConsumo.Value)
            bf.Serialize(fStream, nupPercentualeMillesimi.Value)
            bf.Serialize(fStream, nupQTAUnitaImmobiliari.Value)


            For i = nupQTAUnitaImmobiliari.Minimum To nupQTAUnitaImmobiliari.Maximum
                Dim mmtemp As Double = DirectCast(Controls.Find("nupMillesimi" & i.ToString, True)(0), NumericUpDown).Value
                bf.Serialize(fStream, mmtemp)
                Dim chktemp As Boolean = DirectCast(Controls.Find("chkResidente" & i.ToString, True)(0), MetroFramework.Controls.MetroCheckBox).Checked
                bf.Serialize(fStream, chktemp)
                Dim consumotemp As Double = DirectCast(Controls.Find("nupConsumo" & i.ToString, True)(0), NumericUpDown).Value
                bf.Serialize(fStream, consumotemp)
                Dim nupPersonetemp As Integer = DirectCast(Controls.Find("cbNumPersone" & i.ToString, True)?(0), ComboBox).SelectedIndex
                bf.Serialize(fStream, nupPersonetemp)
                Dim gbUnitatemp As String = DirectCast(Controls.Find("gbUnitaImmobiliare" & i.ToString, True)?(0), GroupBox).Text
                bf.Serialize(fStream, gbUnitatemp)
                Dim gbConsumotemp As String = DirectCast(Controls.Find("gbconsumo" & i.ToString, True)?(0), GroupBox).Text
                bf.Serialize(fStream, gbConsumotemp)
            Next

            bf.Serialize(fStream, nupImportoDaRipartire.Value)


            mlStatusBar.Text = "File salvato correttamente."

        Catch ex As Exception
            MsgBox(ex.Message)
            mlStatusBar.Text = "Il file non è stato salvato correttamente."

            Exit Sub
        Finally
            fStream.Close()
        End Try

    End Sub
    Private Sub MetroTile4_Click(sender As Object, e As EventArgs) Handles MetroTile4.Click


        Dim ofd As New OpenFileDialog
        ofd.Filter = "File di riparto (*.racs)|*.racs|Tutti i file|*.*"
#If DEBUG Then
        'ofd.InitialDirectory = Path.GetTempPath
#End If
        Dim result As DialogResult = ofd.ShowDialog()

        If result = DialogResult.Cancel Then Exit Sub

        Dim fStream As New FileStream(ofd.FileName, FileMode.Open)

        Try
            Dim bf As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter


            tariffaResidentiAcquedotto = bf.Deserialize(fStream)
            tariffaResidentiFognatura = bf.Deserialize(fStream)
            tariffaResidentiDepurazione = bf.Deserialize(fStream)
            tariffaNonResidentiAcquedotto = bf.Deserialize(fStream)
            tariffaNonResidentiFognatura = bf.Deserialize(fStream)
            tariffaNonResidentiDepurazione = bf.Deserialize(fStream)
            nupPercentualeConsumo.Value = bf.Deserialize(fStream)
            nupPercentualeMillesimi.Value = bf.Deserialize(fStream)
            nupQTAUnitaImmobiliari.Value = bf.Deserialize(fStream)

            For i = nupQTAUnitaImmobiliari.Minimum To nupQTAUnitaImmobiliari.Maximum
                DirectCast(Controls.Find("nupMillesimi" & i.ToString, True)(0), NumericUpDown).Value = bf.Deserialize(fStream)
                DirectCast(Controls.Find("chkResidente" & i.ToString, True)(0), MetroFramework.Controls.MetroCheckBox).Checked = bf.Deserialize(fStream)
                DirectCast(Controls.Find("nupConsumo" & i.ToString, True)(0), NumericUpDown).Value = bf.Deserialize(fStream)
                DirectCast(Controls.Find("cbNumPersone" & i.ToString, True)?(0), ComboBox).SelectedIndex = bf.Deserialize(fStream)
                DirectCast(Controls.Find("gbUnitaImmobiliare" & i.ToString, True)?(0), GroupBox).Text = bf.Deserialize(fStream)
                DirectCast(Controls.Find("gbconsumo" & i.ToString, True)?(0), GroupBox).Text = bf.Deserialize(fStream)

            Next

            nupImportoDaRipartire.Value = bf.Deserialize(fStream)

            mlStatusBar.Text = "File aperto correttamente."

        Catch ex As Exception
            MsgBox(ex.Message)
            mlStatusBar.Text = "Il file non è stato aperto correttamente."

            Exit Sub
        Finally
            fStream.Close()
        End Try


    End Sub
    Private Sub NupQTAUnitaImmobiliari_ValueChanged(sender As Object, e As EventArgs) Handles nupQTAUnitaImmobiliari.ValueChanged

        Try

            If nupQTAUnitaImmobiliari.Value > 6 Then
                btnCambiaPagina.Visible = True
                mpPagina2.Visible = True
                mpPagina1.Visible = False
                btnCambiaPagina.Text = "Pagina 1"
            Else
                btnCambiaPagina.Visible = False
                mpPagina2.Visible = False
                mpPagina1.Visible = True
                btnCambiaPagina.Text = "Pagina 2"
            End If

            For i = nupQTAUnitaImmobiliari.Minimum To nupQTAUnitaImmobiliari.Value
                DirectCast(Controls.Find("gbUnitaImmobiliare" & i.ToString, True)(0), GroupBox).Visible = True
                DirectCast(Controls.Find("gbConsumo" & i.ToString, True)(0), GroupBox).Visible = True
                DirectCast(Controls.Find("chkResidente" & i.ToString, True)(0), MetroFramework.Controls.MetroCheckBox).Checked = True
            Next
            For i = nupQTAUnitaImmobiliari.Value + 1 To nupQTAUnitaImmobiliari.Maximum
                DirectCast(Controls.Find("gbUnitaImmobiliare" & i.ToString, True)(0), GroupBox).Visible = False
                DirectCast(Controls.Find("gbConsumo" & i.ToString, True)(0), GroupBox).Visible = False
            Next

            For Each mpanel In Me.Controls
                If TypeOf (mpanel) Is MetroFramework.Controls.MetroPanel Then
                    For Each gbox In mpanel.controls
                        If TypeOf (gbox) Is GroupBox Then
                            For Each nupdown In gbox.controls
                                If TypeOf (nupdown) Is NumericUpDown And nupdown.name.tolower.contains("nupmillesimi") Then
                                    nupdown.value = 1000 / nupQTAUnitaImmobiliari.Value
                                End If
                            Next
                        End If
                    Next
                End If
            Next

        Catch ex As Exception

        End Try

    End Sub
    Private Sub BtnCambiaPagina_Click(sender As Object, e As EventArgs) Handles btnCambiaPagina.Click
        If btnCambiaPagina.Text = "Pagina 2" Then
            btnCambiaPagina.Text = "Pagina 1"
            mpPagina2.Visible = True
            mpPagina1.Visible = False
        Else
            btnCambiaPagina.Text = "Pagina 2"
            mpPagina2.Visible = False
            mpPagina1.Visible = True
        End If

    End Sub
    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        mpConfigurazioneRiparto.Visible = True
        mpConfigurazioneRiparto.BringToFront()

    End Sub
    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        mpConfigurazioneRiparto.Visible = False

    End Sub
    Private Function sost9999conOltre(ByVal tariffa As String()) As String()

        Dim newarray As String() = tariffa.[Select](Function(str)
                                                        If str.Equals("9999") Then str = "Oltre"
                                                        Return str
                                                    End Function).ToArray()



        Return newarray
    End Function
    Private Sub btnTariffaAcquedottoResidenti_Click(sender As Object, e As EventArgs) Handles btnTariffaAcquedottoResidenti.Click
        If formTariffe.Visible = False Then
            formTariffe.Show()
            mySender = btnTariffaAcquedottoResidenti.Name
            For i As Integer = 0 To 3
                Dim x As String() = {tariffaResidentiAcquedotto(i, 0),
                    tariffaResidentiAcquedotto(i, 1),
                    tariffaResidentiAcquedotto(i, 2),
                    tariffaResidentiAcquedotto(i, 3),
                    tariffaResidentiAcquedotto(i, 4),
                    tariffaResidentiAcquedotto(i, 5),
                    tariffaResidentiAcquedotto(i, 6)}
                x = sost9999conOltre(x)
                formTariffe.MetroGrid.Rows.Add(x)
            Next
            formTariffe.BringToFront()
        End If
    End Sub
    Private Sub BtnTariffaDepurazioneResidenti_Click(sender As Object, e As EventArgs) Handles btnTariffaDepurazioneResidenti.Click
        If formTariffe.Visible = False Then
            formTariffe.Show()
            mySender = btnTariffaDepurazioneResidenti.Name
            For i As Integer = 0 To 3
                Dim x As String() = {tariffaResidentiDepurazione(i, 0),
                    tariffaResidentiDepurazione(i, 1),
                    tariffaResidentiDepurazione(i, 2),
                    tariffaResidentiDepurazione(i, 3),
                    tariffaResidentiDepurazione(i, 4),
                    tariffaResidentiDepurazione(i, 5),
                    tariffaResidentiDepurazione(i, 6)}
                x = sost9999conOltre(x)
                formTariffe.MetroGrid.Rows.Add(x)
            Next
            formTariffe.BringToFront()
        End If

    End Sub
    Private Sub BtnTariffaFognaturaResidenti_Click(sender As Object, e As EventArgs) Handles btnTariffaFognaturaResidenti.Click
        If formTariffe.Visible = False Then
            formTariffe.Show()
            mySender = btnTariffaFognaturaResidenti.Name
            For i As Integer = 0 To 3
                Dim x As String() = {tariffaResidentiFognatura(i, 0),
                    tariffaResidentiFognatura(i, 1),
                    tariffaResidentiFognatura(i, 2),
                    tariffaResidentiFognatura(i, 3),
                    tariffaResidentiFognatura(i, 4),
                    tariffaResidentiFognatura(i, 5),
                    tariffaResidentiFognatura(i, 6)}
                x = sost9999conOltre(x)
                formTariffe.MetroGrid.Rows.Add(x)
            Next
            formTariffe.BringToFront()
        End If
    End Sub
    Private Sub btnTariffaAcquedottoNonResidenti_Click(sender As Object, e As EventArgs) Handles btnTariffaAcquedottoNonResidenti.Click
        If formTariffe.Visible = False Then
            formTariffe.Show()
            mySender = btnTariffaAcquedottoNonResidenti.Name
            For i As Integer = 0 To 3
                Dim x As String() = {tariffaNonResidentiAcquedotto(i, 0),
                    tariffaNonResidentiAcquedotto(i, 1),
                    tariffaNonResidentiAcquedotto(i, 2),
                    tariffaNonResidentiAcquedotto(i, 3),
                    tariffaNonResidentiAcquedotto(i, 4),
                    tariffaNonResidentiAcquedotto(i, 5),
                    tariffaNonResidentiAcquedotto(i, 6)}
                x = sost9999conOltre(x)
                formTariffe.MetroGrid.Rows.Add(x)
            Next
            formTariffe.BringToFront()
        End If
    End Sub
    Private Sub BtnTariffaDepurazioneNonResidenti_Click(sender As Object, e As EventArgs) Handles btnTariffaDepurazioneNonResidenti.Click
        If formTariffe.Visible = False Then
            formTariffe.Show()
            mySender = btnTariffaDepurazioneNonResidenti.Name
            For i As Integer = 0 To 3
                Dim x As String() = {tariffaNonResidentiDepurazione(i, 0),
                    tariffaNonResidentiDepurazione(i, 1),
                    tariffaNonResidentiDepurazione(i, 2),
                    tariffaNonResidentiDepurazione(i, 3),
                    tariffaNonResidentiDepurazione(i, 4),
                    tariffaNonResidentiDepurazione(i, 5),
                    tariffaNonResidentiDepurazione(i, 6)}
                x = sost9999conOltre(x)
                formTariffe.MetroGrid.Rows.Add(x)
            Next
            formTariffe.BringToFront()
        End If

    End Sub
    Private Sub BtnTariffaFognaturaNonResidenti_Click(sender As Object, e As EventArgs) Handles btnTariffaFognaturaNonResidenti.Click
        If formTariffe.Visible = False Then
            formTariffe.Show()
            mySender = btnTariffaFognaturaNonResidenti.Name
            For i As Integer = 0 To 3
                Dim x As String() = {tariffaNonResidentiFognatura(i, 0),
                    tariffaNonResidentiFognatura(i, 1),
                    tariffaNonResidentiFognatura(i, 2),
                    tariffaNonResidentiFognatura(i, 3),
                    tariffaNonResidentiFognatura(i, 4),
                    tariffaNonResidentiFognatura(i, 5),
                    tariffaNonResidentiFognatura(i, 6)}
                x = sost9999conOltre(x)
                formTariffe.MetroGrid.Rows.Add(x)
            Next
            formTariffe.BringToFront()
        End If
    End Sub
    Private Sub MetroTile3_Click(sender As Object, e As EventArgs) Handles MetroTile3.Click

        Dim sommaMillesimi As Double
        For i = nupQTAUnitaImmobiliari.Minimum To nupQTAUnitaImmobiliari.Value
            sommaMillesimi += DirectCast(Controls.Find("nupMillesimi" & i.ToString, True)(0), NumericUpDown).Value
        Next
        If sommaMillesimi < 999 Then
            MsgBox("La somma millesimi è inferiore a 999. Verificare.")
            Exit Sub
        End If
        If sommaMillesimi > 1001 Then
            MsgBox("La somma millesimi è superiore a 1001. Verificare.")
            Exit Sub
        End If

        Dim newRipartizione = New formRipartizione
        newRipartizione.Show()

#Region "ripartizione tradizionale"
        newRipartizione.tabellaRipartizione.Columns(1).DefaultCellStyle.Format = "€ #.#0"
        newRipartizione.tabellaRipartizione.Columns(2).DefaultCellStyle.Format = "€ #.#0"
        newRipartizione.tabellaRipartizione.Columns(3).DefaultCellStyle.Format = "€ #.#0"

        Dim totaleMetriCubi As Double

        For i = nupQTAUnitaImmobiliari.Minimum To nupQTAUnitaImmobiliari.Maximum
            totaleMetriCubi += DirectCast(Controls.Find("nupConsumo" & i.ToString, True)?(0), NumericUpDown).Value
        Next

        Dim totaleRipartizioneMillesimi As Double
        Dim totaleRipartizioneConsumo As Double
        Dim totaleRipartizione As Double


        For i = nupQTAUnitaImmobiliari.Minimum To nupQTAUnitaImmobiliari.Maximum

            Dim cell1 As String = DirectCast(Controls.Find("gbUnitaImmobiliare" & i.ToString, True)?(0), GroupBox).Text
            Dim cell2 As Double = nupImportoDaRipartire.Value * (nupPercentualeMillesimi.Value / 100) * (DirectCast(Controls.Find("nupMillesimi" & i.ToString, True)?(0), NumericUpDown).Value / 1000)
            Dim cell3 As Double = nupImportoDaRipartire.Value * (nupPercentualeConsumo.Value / 100) * (DirectCast(Controls.Find("nupConsumo" & i.ToString, True)?(0), NumericUpDown).Value / totaleMetriCubi)
            Dim cell4 As Double = cell2 + cell3

            totaleRipartizioneMillesimi += cell2
            totaleRipartizioneConsumo += cell3
            totaleRipartizione += cell4

            newRipartizione.tabellaRipartizione.Rows.Add({cell1, cell2, cell3, cell4})

        Next

        newRipartizione.tabellaRipartizione.Rows.Add({"Totali", totaleRipartizioneMillesimi, totaleRipartizioneConsumo, totaleRipartizione})
#End Region


#Region "ripartizione ARERA"

        For Each col In newRipartizione.tabellaRipartizioneARERA.Columns
            col.DefaultCellStyle.Format = "€ #.#0"
        Next

        Dim totaliQuoteFisse As Double
        Dim totaliAgevolata As Double
        Dim totaliBase As Double
        Dim totaliEccedenza As Double
        Dim totaliEccedenza1 As Double
        Dim totale As Double

        For i = nupQTAUnitaImmobiliari.Minimum To nupQTAUnitaImmobiliari.Maximum

            Dim cell1, cell2, cell3, cell4, cell5, cell6 As Double
            Dim numpersone As Integer = CInt(DirectCast(Controls.Find("cbNumPersone" & i.ToString, True)?(0), ComboBox).Text)


            If DirectCast(Controls.Find("chkResidente" & i.ToString, True)?(0), CheckBox).Checked Then

                cell1 = tariffaResidentiAcquedotto(0, 2) + tariffaResidentiDepurazione(0, 2) + tariffaResidentiFognatura(0, 2)
                Dim consumo As Double = DirectCast(Controls.Find("nupConsumo" & i.ToString, True)?(0), NumericUpDown).Value
                Dim consumoAgevolato, consumoBase, consumoEccedenza, consumoEccedenza1 As Double

                If consumo > tariffaResidentiAcquedotto(0, 1) * numpersone Then
                    consumoAgevolato = tariffaResidentiAcquedotto(0, 1) * numpersone
                    If consumo > tariffaResidentiAcquedotto(1, 1) * numpersone Then
                        consumoBase = (tariffaResidentiAcquedotto(1, 1) - tariffaResidentiAcquedotto(0, 1)) * numpersone
                        If consumo > tariffaResidentiAcquedotto(2, 1) * numpersone Then
                            consumoEccedenza = (tariffaResidentiAcquedotto(2, 1) - tariffaResidentiAcquedotto(1, 1)) * numpersone
                            consumoEccedenza1 = consumo - tariffaResidentiAcquedotto(2, 1) * numpersone
                        Else
                            consumoEccedenza = consumo - tariffaResidentiAcquedotto(1, 1) * numpersone
                            consumoEccedenza1 = 0
                        End If
                    Else
                        consumoBase = consumo - tariffaResidentiAcquedotto(0, 1) * numpersone
                        consumoEccedenza = 0
                        consumoEccedenza1 = 0
                    End If
                Else
                    consumoAgevolato = consumo
                    consumoBase = 0
                    consumoEccedenza = 0
                    consumoEccedenza1 = 0
                End If



#Region "agevolata residenti"
                Dim tariffaAcquedotto As Double = tariffaResidentiAcquedotto(0, 3) + tariffaResidentiAcquedotto(0, 4) + tariffaResidentiAcquedotto(0, 5) + tariffaResidentiAcquedotto(0, 6)
                Dim tariffaFognatura As Double = tariffaResidentiFognatura(0, 3) + tariffaResidentiFognatura(0, 4) + tariffaResidentiFognatura(0, 5) + tariffaResidentiFognatura(0, 6)
                Dim tariffaDepurazione As Double = tariffaResidentiDepurazione(0, 3) + tariffaResidentiDepurazione(0, 4) + tariffaResidentiDepurazione(0, 5) + tariffaResidentiDepurazione(0, 6)
                cell2 = consumoAgevolato * (tariffaAcquedotto + tariffaFognatura + tariffaDepurazione)
#End Region

#Region "base residenti"
                tariffaAcquedotto = tariffaResidentiAcquedotto(1, 3) + tariffaResidentiAcquedotto(1, 4) + tariffaResidentiAcquedotto(1, 5) + tariffaResidentiAcquedotto(1, 6)
                tariffaFognatura = tariffaResidentiFognatura(1, 3) + tariffaResidentiFognatura(1, 4) + tariffaResidentiFognatura(1, 5) + tariffaResidentiFognatura(1, 6)
                tariffaDepurazione = tariffaResidentiDepurazione(1, 3) + tariffaResidentiDepurazione(1, 4) + tariffaResidentiDepurazione(1, 5) + tariffaResidentiDepurazione(1, 6)
                cell3 = consumoBase * (tariffaAcquedotto + tariffaFognatura + tariffaDepurazione)
#End Region

#Region "eccedenza residenti"
                tariffaAcquedotto = tariffaResidentiAcquedotto(2, 3) + tariffaResidentiAcquedotto(2, 4) + tariffaResidentiAcquedotto(2, 5) + tariffaResidentiAcquedotto(2, 6)
                tariffaFognatura = tariffaResidentiFognatura(2, 3) + tariffaResidentiFognatura(2, 4) + tariffaResidentiFognatura(2, 5) + tariffaResidentiFognatura(2, 6)
                tariffaDepurazione = tariffaResidentiDepurazione(2, 3) + tariffaResidentiDepurazione(2, 4) + tariffaResidentiDepurazione(2, 5) + tariffaResidentiDepurazione(2, 6)
                cell4 = consumoEccedenza * (tariffaAcquedotto + tariffaFognatura + tariffaDepurazione)
#End Region

#Region "eccedenza 1 residenti"
                tariffaAcquedotto = tariffaResidentiAcquedotto(3, 3) + tariffaResidentiAcquedotto(3, 4) + tariffaResidentiAcquedotto(3, 5) + tariffaResidentiAcquedotto(3, 6)
                tariffaFognatura = tariffaResidentiFognatura(3, 3) + tariffaResidentiFognatura(3, 4) + tariffaResidentiFognatura(3, 5) + tariffaResidentiFognatura(3, 6)
                tariffaDepurazione = tariffaResidentiDepurazione(3, 3) + tariffaResidentiDepurazione(3, 4) + tariffaResidentiDepurazione(3, 5) + tariffaResidentiDepurazione(3, 6)
                cell5 = consumoEccedenza1 * (tariffaAcquedotto + tariffaFognatura + tariffaDepurazione)
#End Region

            Else

                cell1 = tariffaNonResidentiAcquedotto(0, 2) + tariffaNonResidentiDepurazione(0, 2) + tariffaNonResidentiFognatura(0, 2)

                '#####  Zona non residenti da completare

            End If


            totaliQuoteFisse += cell1
            totaliAgevolata += cell2
            totaliBase += cell3
            totaliEccedenza += cell4
            totaliEccedenza1 += cell5
            cell6 = cell1 + cell2 + cell3 + cell4 + cell5
            totale += cell6

            newRipartizione.tabellaRipartizioneARERA.Rows.Add({cell1, cell2, cell3, cell4, cell5, cell6})

        Next

        newRipartizione.tabellaRipartizioneARERA.Rows.Add({totaliQuoteFisse, totaliAgevolata, totaliBase, totaliEccedenza, totaliEccedenza1, totale})




#End Region
    End Sub
    Private Sub MetroTile6_Click(sender As Object, e As EventArgs) Handles MetroTile6.Click
        tariffaResidentiAcquedotto = {
        {0, 19, 16.813, 0.538, 0.004, 0.009, 0.005},
        {20, 55, 0, 0.672, 0.004, 0.009, 0.005},
        {56, 75, 0, 1.21, 0.004, 0.009, 0.005},
        {76, 9999, 0, 1.815, 0.004, 0.009, 0.005}
        }
        tariffaResidentiFognatura = {
        {0, 19, 6.725, 0.336, 0.004, 0.009, 0},
        {20, 55, 0, 0.336, 0.004, 0.009, 0},
        {56, 75, 0, 0.336, 0.004, 0.009, 0},
        {76, 9999, 0, 0.336, 0.004, 0.009, 0}
        }
        tariffaResidentiDepurazione = {
        {0, 19, 10.088, 0.632, 0.004, 0.009, 0},
        {20, 55, 0, 0.632, 0.004, 0.009, 0},
        {56, 75, 0, 0.632, 0.004, 0.009, 0},
        {76, 9999, 0, 0.632, 0.004, 0.009, 0}
        }
        tariffaNonResidentiAcquedotto = {
        {0, 0, 0, 0, 0, 0, 0},
        {0, 38, 33.625, 0.672, 0.004, 0.009, 0.005},
        {39, 9999, 0, 1.815, 0.004, 0.009, 0.005},
        {0, 0, 0, 0, 0, 0, 0}
        }
        tariffaNonResidentiFognatura = {
        {0, 0, 0, 0, 0, 0, 0},
        {0, 38, 13.45, 0.336, 0.004, 0.009, 0},
        {39, 9999, 0, 0.336, 0.004, 0.009, 0},
        {0, 0, 0, 0, 0, 0, 0}
        }
        tariffaNonResidentiDepurazione = {
        {0, 0, 0, 0, 0, 0, 0},
        {0, 38, 20.175, 0.632, 0.004, 0.009, 0},
        {39, 9999, 0, 0.632, 0.004, 0.009, 0},
        {0, 0, 0, 0, 0, 0, 0}
        }
    End Sub
    Private Sub MlStatusBar_Click(sender As Object, e As EventArgs) Handles mlStatusBar.TextChanged

        If mlStatusBar.Text <> "" Then
            TimerStatusbar.Enabled = True
        End If

    End Sub
    Private Sub TimerStatusbar_Tick(sender As Object, e As EventArgs) Handles TimerStatusbar.Tick
        mlStatusBar.Text = ""
        TimerStatusbar.Enabled = False
    End Sub

    Private Sub RipartoACS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i = nupQTAUnitaImmobiliari.Minimum To nupQTAUnitaImmobiliari.Maximum
            If DirectCast(Controls.Find("cbNumPersone" & i.ToString, True)?(0), ComboBox).SelectedIndex = -1 Then
                DirectCast(Controls.Find("cbNumPersone" & i.ToString, True)?(0), ComboBox).SelectedIndex = 0
            End If

            AddHandler DirectCast(Controls.Find("gbUnitaImmobiliare" & i.ToString, True)?(0), GroupBox).DoubleClick, AddressOf GbUnitaImmobiliare_DoubleClick

        Next


    End Sub

    Private Sub GbUnitaImmobiliare_DoubleClick(sender As Object, e As EventArgs)
        Dim formNome As Form = New formNomeUnitaImm
        Dim result As DialogResult = formNome.ShowDialog()
        If result = DialogResult.OK And NomeUnitaImmobiliare <> "" Then
            'Dim NumeroUnitaImmobiliare As String = sender.text.ToString.Split(" ")(2)
            sender.text = "Unità immobiliare " & NomeUnitaImmobiliare
            For i = nupQTAUnitaImmobiliari.Minimum To nupQTAUnitaImmobiliari.Maximum
                If DirectCast(Controls.Find("gbUnitaImmobiliare" & i.ToString, True)?(0), GroupBox).Text.Contains(NomeUnitaImmobiliare) Then
                    DirectCast(Controls.Find("gbconsumo" & i.ToString, True)?(0), GroupBox).Text = "Consumo " & NomeUnitaImmobiliare
                End If
            Next
        End If
    End Sub
End Class
