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
    End Sub
End Class