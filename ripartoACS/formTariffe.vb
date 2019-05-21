Public Class formTariffe
    Private Sub mtSalvaTariffe_Click(sender As Object, e As EventArgs) Handles mtSalvaTariffe.Click
        If ripartoACS.mySender = "btnTariffaAcquedottoResidenti" Then
            For i As Integer = 0 To 3
                For j As Integer = 0 To 4
                    ripartoACS.tariffaResidentiAcquedotto(i, j) = CDbl(MetroGrid.Rows(i).Cells(j).Value)
                Next
            Next
        ElseIf ripartoACS.mySender = "btnTariffaFognaturaResidenti" Then
            For i As Integer = 0 To 3
                For j As Integer = 0 To 4
                    ripartoACS.tariffaResidentiFognatura(i, j) = CDbl(MetroGrid.Rows(i).Cells(j).Value)
                Next
            Next
        ElseIf ripartoACS.mySender = "btnTariffaDepurazioneResidenti" Then
            For i As Integer = 0 To 3
                For j As Integer = 0 To 4
                    ripartoACS.tariffaResidentiDepurazione(i, j) = CDbl(MetroGrid.Rows(i).Cells(j).Value)
                Next
            Next
        ElseIf ripartoACS.mySender = "btnTariffaAcquedottoNonResidenti" Then
            For i As Integer = 0 To 3
                For j As Integer = 0 To 4
                    ripartoACS.tariffaNonResidentiAcquedotto(i, j) = CDbl(MetroGrid.Rows(i).Cells(j).Value)
                Next
            Next
        ElseIf ripartoACS.mySender = "btnTariffaFognaturaNonResidenti" Then
            For i As Integer = 0 To 3
                For j As Integer = 0 To 4
                    ripartoACS.tariffaNonResidentiFognatura(i, j) = CDbl(MetroGrid.Rows(i).Cells(j).Value)
                Next
            Next
        ElseIf ripartoACS.mySender = "btnTariffaDepurazioneNonResidenti" Then
            For i As Integer = 0 To 3
                For j As Integer = 0 To 4
                    ripartoACS.tariffaNonResidentiDepurazione(i, j) = CDbl(MetroGrid.Rows(i).Cells(j).Value)
                Next
            Next
        End If
    End Sub
    Private Sub frmClosing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        ripartoACS.Focus()
    End Sub

End Class