<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNota
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtNota = New TextBox()
        pnlComandi = New Panel()
        lbl1 = New Label()
        btnSalva = New Button()
        pnlTesto = New Panel()
        pnlComandi.SuspendLayout()
        pnlTesto.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtNota
        ' 
        txtNota.BackColor = Color.SteelBlue
        txtNota.Dock = DockStyle.Fill
        txtNota.Location = New Point(0, 0)
        txtNota.Multiline = True
        txtNota.Name = "txtNota"
        txtNota.ScrollBars = ScrollBars.Vertical
        txtNota.Size = New Size(828, 486)
        txtNota.TabIndex = 0
        ' 
        ' pnlComandi
        ' 
        pnlComandi.BackColor = Color.LightSteelBlue
        pnlComandi.Controls.Add(lbl1)
        pnlComandi.Controls.Add(btnSalva)
        pnlComandi.Dock = DockStyle.Top
        pnlComandi.Location = New Point(0, 0)
        pnlComandi.Name = "pnlComandi"
        pnlComandi.Size = New Size(828, 76)
        pnlComandi.TabIndex = 1
        ' 
        ' lbl1
        ' 
        lbl1.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        lbl1.Location = New Point(12, 12)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(115, 47)
        lbl1.TabIndex = 1
        lbl1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnSalva
        ' 
        btnSalva.Anchor = AnchorStyles.None
        btnSalva.BackColor = Color.DarkTurquoise
        btnSalva.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnSalva.Location = New Point(334, 12)
        btnSalva.Name = "btnSalva"
        btnSalva.Size = New Size(152, 47)
        btnSalva.TabIndex = 0
        btnSalva.Text = "SALVA"
        btnSalva.UseVisualStyleBackColor = False
        ' 
        ' pnlTesto
        ' 
        pnlTesto.BackColor = Color.LightSteelBlue
        pnlTesto.Controls.Add(txtNota)
        pnlTesto.Dock = DockStyle.Fill
        pnlTesto.Location = New Point(0, 76)
        pnlTesto.Name = "pnlTesto"
        pnlTesto.Size = New Size(828, 486)
        pnlTesto.TabIndex = 2
        ' 
        ' frmNota
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(828, 562)
        Controls.Add(pnlTesto)
        Controls.Add(pnlComandi)
        Name = "frmNota"
        Text = "frmNota"
        pnlComandi.ResumeLayout(False)
        pnlTesto.ResumeLayout(False)
        pnlTesto.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtNota As TextBox
    Friend WithEvents pnlComandi As Panel
    Friend WithEvents btnSalva As Button
    Friend WithEvents lbl1 As Label
    Friend WithEvents pnlTesto As Panel
End Class
