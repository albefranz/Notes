Public Class Form1
    'Questo programma ha dei pulsanti (Note). Ognuno dei pulsanti apre una casella di
    'testo che si può leggere, salvare, modificare.
    'Se voglio aggiungere una Nota, basta aggiungere un pulsante, copiandone un
    'altro e modificandone il nome. Il programma farà il resto. Poi però devo
    'rifare il setup...
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Crea la directory Notes. Se c'è già non genera eccezioni
        My.Computer.FileSystem.CreateDirectory("C:\Users\Public\Documents\Notes")
        'NomeNota conterrà il nome di ogni pulsante della Form1, quindi delle Note
        Dim NomeNota As String
        'Apre/Chiude o crea tutti i file.txt di tutte le note
        For Each A As Control In Me.Controls
            If A IsNot Nothing Then
                NomeNota = Mid(A.Name, 4, Len(A.Name) - 3)
                ff = FreeFile()
                FileOpen(ff, Percorso & NomeNota & ".txt", OpenMode.Append)
                FileClose()
            End If
        Next
        btnEveryDay.PerformClick()
    End Sub

    Private Sub btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLink.Click, btnDo_It.Click, btnPosti.Click, btnSNicolò.Click, btnParole.Click, btnMemo.Click, btnCose.Click, btnMusica.Click, btnVB_Prog.Click, btnEveryDay.Click, Button1.Click, Button2.Click
        frmNota.Close()
        'Trova il Button cliccato nella Form1
        Dim A = CType(sender, Button)
        'Prende la parte del nome del Button che interessa
        Dim NomeNota = Mid(A.Name, 4, Len(A.Name) - 3)
        'Testo conterrà il testo del file desiderato
        Dim Testo As String
        'Legge il testo del file e lo mette in Testo
        Testo = My.Computer.FileSystem.ReadAllText(Percorso & NomeNota & ".txt")
        'Leva le virgolette
        Testo = Mid(Testo, 2, Len(Testo) - 4)
        'Mette il nome del file desiderato nella Label della frmNota
        frmNota.lbl1.Text = NomeNota
        'Mette il testo sulla casella di testo nella frmNota
        frmNota.txtNota.Text = Testo
        'Mostra frmNota
        frmNota.Show()
    End Sub

End Class
