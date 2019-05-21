Imports System.IO

Public Class ripartoACS

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
        sfd.InitialDirectory = Path.GetTempPath
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
                Dim chktemp As Double = DirectCast(Controls.Find("chkResidente" & i.ToString, True)(0), MetroFramework.Controls.MetroCheckBox).Checked
                bf.Serialize(fStream, chktemp)
                Dim consumotemp As Double = DirectCast(Controls.Find("nupConsumo" & i.ToString, True)(0), NumericUpDown).Value
                bf.Serialize(fStream, consumotemp)
            Next

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
        ofd.InitialDirectory = Path.GetTempPath
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
            Next

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
End Class
