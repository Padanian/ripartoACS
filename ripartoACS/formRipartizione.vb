Imports System.IO

Public Class formRipartizione

    Private Sub dataGridView2_Scroll(ByVal sender As Object, ByVal e As ScrollEventArgs)
        tabellaRipartizione.FirstDisplayedScrollingRowIndex = tabellaRipartizioneARERA.FirstDisplayedScrollingRowIndex
    End Sub

    Private Sub dataGridView1_Scroll(ByVal sender As Object, ByVal e As ScrollEventArgs)
        tabellaRipartizioneARERA.FirstDisplayedScrollingRowIndex = tabellaRipartizione.FirstDisplayedScrollingRowIndex
    End Sub

    Private Sub FormRipartizione_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler tabellaRipartizione.Scroll, AddressOf dataGridView1_Scroll
        AddHandler tabellaRipartizioneARERA.Scroll, AddressOf dataGridView2_Scroll

        btnClose.Select()
        btnClose.Focus()

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ripartoACS.Select()
        ripartoACS.Focus()
        Me.Close()
    End Sub

    Private Sub TabellaRipartizione_CellContentClick(sender As Object, e As MouseEventArgs) Handles tabellaRipartizione.Click
        Dim index As Integer = tabellaRipartizione.CurrentCell.RowIndex
        tabellaRipartizioneARERA.ClearSelection()
        tabellaRipartizioneARERA.Rows(index).Selected = True
    End Sub
    Private Sub TabellaRipartizioneARERA_CellContentClick(sender As Object, e As MouseEventArgs) Handles tabellaRipartizioneARERA.Click
        Dim index As Integer = tabellaRipartizioneARERA.CurrentCell.RowIndex
        tabellaRipartizione.ClearSelection()
        tabellaRipartizione.Rows(index).Selected = True
    End Sub

    Private Sub BtnEsportaCSV_Click(sender As Object, e As EventArgs) Handles btnEsportaCSV.Click

        Dim dgvTemp As New DataGridView
        For i = 1 To tabellaRipartizione.Columns.Count + tabellaRipartizioneARERA.Columns.Count
            dgvTemp.Columns.Add(New DataGridViewColumn(New DataGridViewTextBoxCell()))
        Next
        For Each column In dgvTemp.Columns
            If column.index < tabellaRipartizione.Columns.Count Then
                column.headertext = tabellaRipartizione.Columns(column.index).headertext
                column.name = tabellaRipartizione.Columns(column.index).name
            Else
                column.headertext = tabellaRipartizioneARERA.Columns(column.index - tabellaRipartizione.Columns.Count).HeaderText
                column.name = tabellaRipartizioneARERA.Columns(column.index - tabellaRipartizione.Columns.Count).name
            End If
        Next

        Dim dummy As Double

        For Each row1 In tabellaRipartizione.Rows
            Dim row2 As New DataGridViewRow
            dgvTemp.Rows.Add()
            For Each column1 In tabellaRipartizione.Columns
                row2 = tabellaRipartizioneARERA.Rows(row1.index)
                dgvTemp.CurrentCell = dgvTemp(column1.index, row1.index)
                If Double.TryParse(tabellaRipartizione(column1.index, row1.index).value, dummy) Then
                    dgvTemp.CurrentCell.Value = Math.Round(tabellaRipartizione(column1.index, row1.index).value, 2)
                Else
                    dgvTemp.CurrentCell.Value = tabellaRipartizione(column1.index, row1.index).value
                End If

            Next
            For Each column2 In tabellaRipartizioneARERA.Columns
                row2 = tabellaRipartizioneARERA.Rows(row1.index)
                dgvTemp.CurrentCell = dgvTemp(tabellaRipartizione.Columns.Count + column2.index, row1.index)
                dgvTemp.CurrentCell.Value = Math.Round(tabellaRipartizioneARERA(column2.index, row1.index).value, 2)
            Next
        Next

        Dim sfd As New SaveFileDialog
        sfd.Filter = "File CSV (*.csv)|*.csv|Tutti i file|*.*"

        Dim result As DialogResult = sfd.ShowDialog()

        If result = DialogResult.Cancel Then Exit Sub

        subExportDGVToCSV(sfd.FileName, dgvTemp, True, ";")

    End Sub
    Private Sub subExportDGVToCSV(ByVal strExportFileName As String, ByVal DataGridView As DataGridView, Optional ByVal blnWriteColumnHeaderNames As Boolean = False, Optional ByVal strDelimiterType As String = ",")

        Dim sr As StreamWriter = File.CreateText(strExportFileName)
        Dim strDelimiter As String = strDelimiterType
        Dim intColumnCount As Integer = DataGridView.Columns.Count - 1
        Dim strRowData As String = ""

        If blnWriteColumnHeaderNames Then
            For intX As Integer = 0 To intColumnCount
                strRowData += Replace(DataGridView.Columns(intX).HeaderText, strDelimiter, "") & IIf(intX < intColumnCount, strDelimiter, "")
            Next intX
            sr.WriteLine(strRowData)
        End If

        For intX As Integer = 0 To DataGridView.Rows.Count - 1
            strRowData = ""
            For intRowData As Integer = 0 To intColumnCount
                strRowData += Replace(DataGridView.Rows(intX).Cells(intRowData).Value?.ToString, strDelimiter, "") & IIf(intRowData < intColumnCount, strDelimiter, "") '''''''''highlights this row
            Next intRowData
            sr.WriteLine(strRowData)
        Next intX
        sr.Close()

    End Sub

End Class