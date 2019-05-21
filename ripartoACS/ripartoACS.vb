Public Class ripartoACS

    Public mySender As String
    Public tariffaResidentiAcquedotto(,) As Double = {
    {0, 0.538, 0.004, 0.009, 0.005},
    {16.813, 0.672, 0.004, 0.009, 0.005},
    {0, 1.21, 0.004, 0.009, 0.005},
    {0, 1.815, 0.004, 0.009, 0.005}
    }
    Public tariffaResidentiFognatura(,) As Double = {
    {0, 0.336, 0.004, 0.009, 0},
    {6.725, 0.336, 0.004, 0.009, 0},
    {0, 0.336, 0.004, 0.009, 0},
    {0, 0.336, 0.004, 0.009, 0}
    }
    Public tariffaResidentiDepurazione(,) As Double = {
    {0, 0.632, 0.004, 0.009, 0},
    {10.088, 0.632, 0.004, 0.009, 0},
    {0, 0.632, 0.004, 0.009, 0},
    {0, 0.632, 0.004, 0.009, 0}
    }
    Public tariffaNonResidentiAcquedotto(,) As Double = {
    {0, 0, 0, 0, 0},
    {33.625, 0.672, 0.004, 0.009, 0.005},
    {0, 1.815, 0.004, 0.009, 0.005},
    {0, 0, 0, 0, 0}
    }
    Public tariffaNonResidentiFognatura(,) As Double = {
    {0, 0, 0, 0, 0},
    {13.45, 0.336, 0.004, 0.009, 0},
    {0, 0.336, 0.004, 0.009, 0},
    {0, 0, 0, 0, 0}
    }
    Public tariffaNonResidentiDepurazione(,) As Double = {
    {0, 0, 0, 0, 0},
    {20.175, 0.632, 0.004, 0.009, 0},
    {0, 0.632, 0.004, 0.009, 0},
    {0, 0, 0, 0, 0}
    }

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
            Next
            For i = nupQTAUnitaImmobiliari.Value + 1 To nupQTAUnitaImmobiliari.Maximum
                DirectCast(Controls.Find("gbUnitaImmobiliare" & i.ToString, True)(0), GroupBox).Visible = False
                DirectCast(Controls.Find("gbConsumo" & i.ToString, True)(0), GroupBox).Visible = False
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

    Private Sub btnTariffaAcquedottoResidenti_Click(sender As Object, e As EventArgs) Handles btnTariffaAcquedottoResidenti.Click
        If formTariffe.Visible = False Then
            formTariffe.Show()
            mySender = btnTariffaAcquedottoResidenti.Name
            For i As Integer = 0 To 3
                Dim x As String() = {tariffaResidentiAcquedotto(i, 0),
                    tariffaResidentiAcquedotto(i, 1),
                    tariffaResidentiAcquedotto(i, 2),
                    tariffaResidentiAcquedotto(i, 3),
                    tariffaResidentiAcquedotto(i, 4)}
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
                    tariffaResidentiDepurazione(i, 4)}
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
                    tariffaResidentiFognatura(i, 4)}
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
                    tariffaNonResidentiAcquedotto(i, 4)}
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
                    tariffaNonResidentiDepurazione(i, 4)}
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
                    tariffaNonResidentiFognatura(i, 4)}
                formTariffe.MetroGrid.Rows.Add(x)
            Next
            formTariffe.BringToFront()
        End If
    End Sub

End Class
