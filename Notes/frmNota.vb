Public Class frmNota
    Private Sub btnSalva_Click(sender As Object, e As EventArgs) Handles btnSalva.Click
        'Prima lo cancella
        My.Computer.FileSystem.DeleteFile(Percorso & lbl1.Text & ".txt")
        'Poi lo riscrive
        ff = FreeFile()
        FileOpen(ff, Percorso & lbl1.Text & ".txt", OpenMode.Append)
        Dim R As String = txtNota.Text
        WriteLine(ff, R)
        FileClose(ff)

        MessageBox.Show("Salvato", "Salvataggio")
    End Sub
End Class