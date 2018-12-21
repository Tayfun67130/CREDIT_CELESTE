<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCreditBis
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
		Me.cmdClient = New System.Windows.Forms.Button()
		Me.lblConnexion = New System.Windows.Forms.Label()
		Me.cmdConnexion = New System.Windows.Forms.Button()
		Me.CmdEnrCredit = New System.Windows.Forms.Button()
		Me.cmdIntroduction = New System.Windows.Forms.Button()
		Me.lbl2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.mensualite = New System.Windows.Forms.TextBox()
		Me.lbl4 = New System.Windows.Forms.Label()
		Me.duree = New System.Windows.Forms.TextBox()
		Me.lbl3 = New System.Windows.Forms.Label()
		Me.montant = New System.Windows.Forms.TextBox()
		Me.taux = New System.Windows.Forms.TextBox()
		Me.Btn = New System.Windows.Forms.Button()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'cmdClient
		'
		Me.cmdClient.Location = New System.Drawing.Point(322, 306)
		Me.cmdClient.Name = "cmdClient"
		Me.cmdClient.Size = New System.Drawing.Size(75, 23)
		Me.cmdClient.TabIndex = 38
		Me.cmdClient.Text = "Client"
		Me.cmdClient.UseVisualStyleBackColor = True
		'
		'lblConnexion
		'
		Me.lblConnexion.AutoSize = True
		Me.lblConnexion.Location = New System.Drawing.Point(35, 29)
		Me.lblConnexion.Name = "lblConnexion"
		Me.lblConnexion.Size = New System.Drawing.Size(68, 13)
		Me.lblConnexion.TabIndex = 37
		Me.lblConnexion.Text = "non Conecté"
		'
		'cmdConnexion
		'
		Me.cmdConnexion.Location = New System.Drawing.Point(19, 47)
		Me.cmdConnexion.Name = "cmdConnexion"
		Me.cmdConnexion.Size = New System.Drawing.Size(84, 23)
		Me.cmdConnexion.TabIndex = 36
		Me.cmdConnexion.Text = "Connexion"
		Me.cmdConnexion.UseVisualStyleBackColor = True
		'
		'CmdEnrCredit
		'
		Me.CmdEnrCredit.Location = New System.Drawing.Point(206, 133)
		Me.CmdEnrCredit.Name = "CmdEnrCredit"
		Me.CmdEnrCredit.Size = New System.Drawing.Size(75, 23)
		Me.CmdEnrCredit.TabIndex = 35
		Me.CmdEnrCredit.Text = "J'enregistre"
		Me.CmdEnrCredit.UseVisualStyleBackColor = True
		'
		'cmdIntroduction
		'
		Me.cmdIntroduction.Location = New System.Drawing.Point(194, 306)
		Me.cmdIntroduction.Name = "cmdIntroduction"
		Me.cmdIntroduction.Size = New System.Drawing.Size(75, 23)
		Me.cmdIntroduction.TabIndex = 34
		Me.cmdIntroduction.Text = "&Introduction"
		Me.cmdIntroduction.UseVisualStyleBackColor = True
		'
		'lbl2
		'
		Me.lbl2.AutoSize = True
		Me.lbl2.Location = New System.Drawing.Point(44, 91)
		Me.lbl2.Name = "lbl2"
		Me.lbl2.Size = New System.Drawing.Size(67, 13)
		Me.lbl2.TabIndex = 33
		Me.lbl2.Text = "MONTANT :"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(44, 37)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(42, 13)
		Me.Label1.TabIndex = 32
		Me.Label1.Text = "TAUX :"
		'
		'mensualite
		'
		Me.mensualite.Location = New System.Drawing.Point(40, 204)
		Me.mensualite.Name = "mensualite"
		Me.mensualite.Size = New System.Drawing.Size(100, 20)
		Me.mensualite.TabIndex = 31
		'
		'lbl4
		'
		Me.lbl4.AutoSize = True
		Me.lbl4.Location = New System.Drawing.Point(44, 180)
		Me.lbl4.Name = "lbl4"
		Me.lbl4.Size = New System.Drawing.Size(82, 13)
		Me.lbl4.TabIndex = 30
		Me.lbl4.Text = "MENSUALITE :"
		'
		'duree
		'
		Me.duree.Location = New System.Drawing.Point(40, 154)
		Me.duree.Name = "duree"
		Me.duree.Size = New System.Drawing.Size(100, 20)
		Me.duree.TabIndex = 29
		'
		'lbl3
		'
		Me.lbl3.AutoSize = True
		Me.lbl3.Location = New System.Drawing.Point(44, 133)
		Me.lbl3.Name = "lbl3"
		Me.lbl3.Size = New System.Drawing.Size(51, 13)
		Me.lbl3.TabIndex = 28
		Me.lbl3.Text = "DUREE :"
		'
		'montant
		'
		Me.montant.Location = New System.Drawing.Point(40, 112)
		Me.montant.Name = "montant"
		Me.montant.Size = New System.Drawing.Size(100, 20)
		Me.montant.TabIndex = 27
		'
		'taux
		'
		Me.taux.Location = New System.Drawing.Point(40, 63)
		Me.taux.Name = "taux"
		Me.taux.Size = New System.Drawing.Size(100, 20)
		Me.taux.TabIndex = 26
		'
		'Btn
		'
		Me.Btn.Location = New System.Drawing.Point(46, 240)
		Me.Btn.Name = "Btn"
		Me.Btn.Size = New System.Drawing.Size(75, 23)
		Me.Btn.TabIndex = 25
		Me.Btn.Text = "Validez"
		Me.Btn.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.lblConnexion)
		Me.GroupBox1.Controls.Add(Me.cmdConnexion)
		Me.GroupBox1.Location = New System.Drawing.Point(422, 76)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.GroupBox1.Size = New System.Drawing.Size(139, 95)
		Me.GroupBox1.TabIndex = 39
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Connexion"
		'
		'frmCreditBis
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(600, 366)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.cmdClient)
		Me.Controls.Add(Me.CmdEnrCredit)
		Me.Controls.Add(Me.cmdIntroduction)
		Me.Controls.Add(Me.lbl2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.mensualite)
		Me.Controls.Add(Me.lbl4)
		Me.Controls.Add(Me.duree)
		Me.Controls.Add(Me.lbl3)
		Me.Controls.Add(Me.montant)
		Me.Controls.Add(Me.taux)
		Me.Controls.Add(Me.Btn)
		Me.KeyPreview = True
		Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.Name = "frmCreditBis"
		Me.Text = "frmCreditBis"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents cmdClient As Button
    Friend WithEvents lblConnexion As Label
    Friend WithEvents cmdConnexion As Button
    Friend WithEvents CmdEnrCredit As Button
    Friend WithEvents cmdIntroduction As Button
    Friend WithEvents lbl2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents mensualite As TextBox
    Friend WithEvents lbl4 As Label
    Friend WithEvents duree As TextBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents montant As TextBox
    Friend WithEvents taux As TextBox
    Friend WithEvents Btn As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
