Public Class formTariffe
    Private Sub mtSalvaTariffe_Click(sender As Object, e As EventArgs) Handles mtSalvaTariffe.Click
        If ripartoACS.mySender = "btnTariffaAcquedottoResidenti" Then
            For i As Integer = 0 To 3
                For j As Integer = 0 To 6
                    MetroGrid.Rows(i).Cells(j).Value = sostOltrecon9999(MetroGrid.Rows(i).Cells(j).Value)
                    ripartoACS.tariffaResidentiAcquedotto(i, j) = CDbl(MetroGrid.Rows(i).Cells(j).Value)
                Next
            Next
        ElseIf ripartoACS.mySender = "btnTariffaFognaturaResidenti" Then
            For i As Integer = 0 To 3
                For j As Integer = 0 To 6
                    MetroGrid.Rows(i).Cells(j).Value = sostOltrecon9999(MetroGrid.Rows(i).Cells(j).Value)
                    ripartoACS.tariffaResidentiFognatura(i, j) = CDbl(MetroGrid.Rows(i).Cells(j).Value)
                Next
            Next
        ElseIf ripartoACS.mySender = "btnTariffaDepurazioneResidenti" Then
            For i As Integer = 0 To 3
                For j As Integer = 0 To 6
                    MetroGrid.Rows(i).Cells(j).Value = sostOltrecon9999(MetroGrid.Rows(i).Cells(j).Value)
                    ripartoACS.tariffaResidentiDepurazione(i, j) = CDbl(MetroGrid.Rows(i).Cells(j).Value)
                Next
            Next
        ElseIf ripartoACS.mySender = "btnTariffaAcquedottoNonResidenti" Then
            For i As Integer = 0 To 3
                For j As Integer = 0 To 6
                    MetroGrid.Rows(i).Cells(j).Value = sostOltrecon9999(MetroGrid.Rows(i).Cells(j).Value)
                    ripartoACS.tariffaNonResidentiAcquedotto(i, j) = CDbl(MetroGrid.Rows(i).Cells(j).Value)
                Next
            Next
        ElseIf ripartoACS.mySender = "btnTariffaFognaturaNonResidenti" Then
            For i As Integer = 0 To 3
                For j As Integer = 0 To 6
                    MetroGrid.Rows(i).Cells(j).Value = sostOltrecon9999(MetroGrid.Rows(i).Cells(j).Value)
                    ripartoACS.tariffaNonResidentiFognatura(i, j) = CDbl(MetroGrid.Rows(i).Cells(j).Value)
                Next
            Next
        ElseIf ripartoACS.mySender = "btnTariffaDepurazioneNonResidenti" Then
            For i As Integer = 0 To 3
                For j As Integer = 0 To 6
                    MetroGrid.Rows(i).Cells(j).Value = sostOltrecon9999(MetroGrid.Rows(i).Cells(j).Value)
                    ripartoACS.tariffaNonResidentiDepurazione(i, j) = CDbl(MetroGrid.Rows(i).Cells(j).Value)
                Next
            Next
        End If
        Me.Close()
    End Sub
    Private Function sostOltrecon9999(ByVal cell As String) As String
        If cell = "Oltre" Then
            cell = "9999"
        End If
        Return cell
    End Function
    Private Sub frmClosing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        ripartoACS.Focus()
    End Sub

End Class