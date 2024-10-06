<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnLink = New Button()
        btnDo_It = New Button()
        btnPosti = New Button()
        btnSNicolò = New Button()
        btnParole = New Button()
        btnMemo = New Button()
        btnCose = New Button()
        btnMusica = New Button()
        btnVB_Prog = New Button()
        SuspendLayout()
        ' 
        ' btnLink
        ' 
        btnLink.BackColor = Color.YellowGreen
        btnLink.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnLink.Location = New Point(21, 30)
        btnLink.Name = "btnLink"
        btnLink.Size = New Size(112, 34)
        btnLink.TabIndex = 0
        btnLink.Text = "Link"
        btnLink.UseVisualStyleBackColor = False
        ' 
        ' btnDo_It
        ' 
        btnDo_It.BackColor = Color.YellowGreen
        btnDo_It.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnDo_It.Location = New Point(21, 70)
        btnDo_It.Name = "btnDo_It"
        btnDo_It.Size = New Size(112, 34)
        btnDo_It.TabIndex = 0
        btnDo_It.Text = "Do It"
        btnDo_It.UseVisualStyleBackColor = False
        ' 
        ' btnPosti
        ' 
        btnPosti.BackColor = Color.YellowGreen
        btnPosti.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnPosti.Location = New Point(21, 110)
        btnPosti.Name = "btnPosti"
        btnPosti.Size = New Size(112, 34)
        btnPosti.TabIndex = 0
        btnPosti.Text = "Posti"
        btnPosti.UseVisualStyleBackColor = False
        ' 
        ' btnSNicolò
        ' 
        btnSNicolò.BackColor = Color.YellowGreen
        btnSNicolò.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnSNicolò.Location = New Point(21, 150)
        btnSNicolò.Name = "btnSNicolò"
        btnSNicolò.Size = New Size(112, 34)
        btnSNicolò.TabIndex = 0
        btnSNicolò.Text = "SNicolò"
        btnSNicolò.UseVisualStyleBackColor = False
        ' 
        ' btnParole
        ' 
        btnParole.BackColor = Color.YellowGreen
        btnParole.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnParole.Location = New Point(21, 190)
        btnParole.Name = "btnParole"
        btnParole.Size = New Size(112, 34)
        btnParole.TabIndex = 0
        btnParole.Text = "Parole"
        btnParole.UseVisualStyleBackColor = False
        ' 
        ' btnMemo
        ' 
        btnMemo.BackColor = Color.Aquamarine
        btnMemo.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnMemo.Location = New Point(172, 110)
        btnMemo.Name = "btnMemo"
        btnMemo.Size = New Size(112, 34)
        btnMemo.TabIndex = 0
        btnMemo.Text = "MEMO"
        btnMemo.UseVisualStyleBackColor = False
        ' 
        ' btnCose
        ' 
        btnCose.BackColor = Color.YellowGreen
        btnCose.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnCose.Location = New Point(21, 230)
        btnCose.Name = "btnCose"
        btnCose.Size = New Size(112, 34)
        btnCose.TabIndex = 0
        btnCose.Text = "Cose"
        btnCose.UseVisualStyleBackColor = False
        ' 
        ' btnMusica
        ' 
        btnMusica.BackColor = Color.YellowGreen
        btnMusica.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnMusica.Location = New Point(172, 30)
        btnMusica.Name = "btnMusica"
        btnMusica.Size = New Size(112, 34)
        btnMusica.TabIndex = 0
        btnMusica.Text = "Musica"
        btnMusica.UseVisualStyleBackColor = False
        ' 
        ' btnVB_Prog
        ' 
        btnVB_Prog.BackColor = Color.YellowGreen
        btnVB_Prog.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnVB_Prog.Location = New Point(172, 70)
        btnVB_Prog.Name = "btnVB_Prog"
        btnVB_Prog.Size = New Size(112, 34)
        btnVB_Prog.TabIndex = 0
        btnVB_Prog.Text = "VB_Prog"
        btnVB_Prog.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(360, 325)
        Controls.Add(btnMemo)
        Controls.Add(btnCose)
        Controls.Add(btnParole)
        Controls.Add(btnSNicolò)
        Controls.Add(btnPosti)
        Controls.Add(btnMusica)
        Controls.Add(btnVB_Prog)
        Controls.Add(btnDo_It)
        Controls.Add(btnLink)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Notes"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnLink As Button
    Friend WithEvents btnDo_It As Button
    Friend WithEvents btnPosti As Button
    Friend WithEvents btnSNicolò As Button
    Friend WithEvents btnParole As Button
    Friend WithEvents btnMemo As Button
    Friend WithEvents btnCose As Button
    Friend WithEvents btnMusica As Button
    Friend WithEvents btnVB_Prog As Button

End Class
