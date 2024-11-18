Public Class frmNota

    Private Sub frmNota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(600, 100)

        If lbl1.Text = "EveryDay" Then
            txtNota.BackColor = Color.PaleGoldenrod
            Me.Size = New Size(850, 620)
        Else
            txtNota.BackColor = Color.SteelBlue
            Me.Size = New Size(450, 520)
        End If
    End Sub

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