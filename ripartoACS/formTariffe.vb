Public Class formTariffe
    Private Sub mtSalvaTariffe_Click(sender As Object, e As EventArgs) Handles mtSalvaTariffe.Click
        If ripartoAS.mySender = "btnTariffaAcquedottoResidenti" Then
            For i As Integer = 0 To 3
                For j As Integer = 0 To 6
                    MetroGrid.Rows(i).Cells(j).Value = sostOltrecon9999(MetroGrid.Rows(i).Cells(j).Value)
                    ripartoAS.tariffaResidentiAcquedotto(i, j) = CDbl(MetroGrid.Rows(i).Cells(j).Value)
                Next
            Next
        ElseIf ripartoAS.mySender = "btnTariffaFognaturaResidenti" Then
            For i As Integer = 0 To 3
                For j As Integer = 0 To 6
                    MetroGrid.Rows(i).Cells(j).Value = sostOltrecon9999(MetroGrid.Rows(i).Cells(j).Value)
                    ripartoAS.tariffaResidentiFognatura(i, j) = CDbl(MetroGrid.Rows(i).Cells(j).Value)
                Next
            Next
        ElseIf ripartoAS.mySender = "btnTariffaDepurazioneResidenti" Then
            For i As Integer = 0 To 3
                For j As Integer = 0 To 6
                    MetroGrid.Rows(i).Cells(j).Value = sostOltrecon9999(MetroGrid.Rows(i).Cells(j).Value)
                    ripartoAS.tariffaResidentiDepurazione(i, j) = CDbl(MetroGrid.Rows(i).Cells(j).Value)
                Next
            Next
        ElseIf ripartoAS.mySender = "btnTariffaAcquedottoNonResidenti" Then
            For i As Integer = 0 To 3
                For j As Integer = 0 To 6
                    MetroGrid.Rows(i).Cells(j).Value = sostOltrecon9999(MetroGrid.Rows(i).Cells(j).Value)
                    ripartoAS.tariffaNonResidentiAcquedotto(i, j) = CDbl(MetroGrid.Rows(i).Cells(j).Value)
                Next
            Next
        ElseIf ripartoAS.mySender = "btnTariffaFognaturaNonResidenti" Then
            For i As Integer = 0 To 3
                For j As Integer = 0 To 6
                    MetroGrid.Rows(i).Cells(j).Value = sostOltrecon9999(MetroGrid.Rows(i).Cells(j).Value)
                    ripartoAS.tariffaNonResidentiFognatura(i, j) = CDbl(MetroGrid.Rows(i).Cells(j).Value)
                Next
            Next
        ElseIf ripartoAS.mySender = "btnTariffaDepurazioneNonResidenti" Then
            For i As Integer = 0 To 3
                For j As Integer = 0 To 6
                    MetroGrid.Rows(i).Cells(j).Value = sostOltrecon9999(MetroGrid.Rows(i).Cells(j).Value)
                    ripartoAS.tariffaNonResidentiDepurazione(i, j) = CDbl(MetroGrid.Rows(i).Cells(j).Value)
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
        ripartoAS.Focus()
    End Sub

End Class