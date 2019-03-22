<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClient
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtPrenomC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomC = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCidt = New System.Windows.Forms.ComboBox()
        Me.txtCPC = New System.Windows.Forms.TextBox()
        Me.txtAdresseC = New System.Windows.Forms.TextBox()
        Me.txtVilleC = New System.Windows.Forms.TextBox()
        Me.txtTelephoneC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdEnr = New System.Windows.Forms.Button()
        Me.txtDateNaissanceC = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNomJeuneFilleC = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtProfessionC = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRevenuC = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdBien = New System.Windows.Forms.Button()
        Me.cmdCredit = New System.Windows.Forms.Button()
        Me.cmdIntroduction = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPrenomC
        '
        Me.txtPrenomC.Location = New System.Drawing.Point(28, 130)
        Me.txtPrenomC.Name = "txtPrenomC"
        Me.txtPrenomC.Size = New System.Drawing.Size(121, 20)
        Me.txtPrenomC.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Prenom"
        '
        'txtNomC
        '
        Me.txtNomC.Location = New System.Drawing.Point(28, 82)
        Me.txtNomC.Name = "txtNomC"
        Me.txtNomC.Size = New System.Drawing.Size(121, 20)
        Me.txtNomC.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Je m'appelle"
        '
        'cboCidt
        '
        Me.cboCidt.FormattingEnabled = True
        Me.cboCidt.Items.AddRange(New Object() {"Madame", "Mademoiselle", "Monsieur"})
        Me.cboCidt.Location = New System.Drawing.Point(28, 28)
        Me.cboCidt.Name = "cboCidt"
        Me.cboCidt.Size = New System.Drawing.Size(121, 21)
        Me.cboCidt.TabIndex = 6
        '
        'txtCPC
        '
        Me.txtCPC.Location = New System.Drawing.Point(28, 231)
        Me.txtCPC.Name = "txtCPC"
        Me.txtCPC.Size = New System.Drawing.Size(121, 20)
        Me.txtCPC.TabIndex = 12
        '
        'txtAdresseC
        '
        Me.txtAdresseC.Location = New System.Drawing.Point(28, 178)
        Me.txtAdresseC.Name = "txtAdresseC"
        Me.txtAdresseC.Size = New System.Drawing.Size(121, 20)
        Me.txtAdresseC.TabIndex = 13
        '
        'txtVilleC
        '
        Me.txtVilleC.Location = New System.Drawing.Point(28, 281)
        Me.txtVilleC.Name = "txtVilleC"
        Me.txtVilleC.Size = New System.Drawing.Size(121, 20)
        Me.txtVilleC.TabIndex = 14
        '
        'txtTelephoneC
        '
        Me.txtTelephoneC.Location = New System.Drawing.Point(28, 329)
        Me.txtTelephoneC.Name = "txtTelephoneC"
        Me.txtTelephoneC.Size = New System.Drawing.Size(121, 20)
        Me.txtTelephoneC.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Téléphone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Code Postal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Ville"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Adresse"
        '
        'cmdEnr
        '
        Me.cmdEnr.Location = New System.Drawing.Point(176, 389)
        Me.cmdEnr.Name = "cmdEnr"
        Me.cmdEnr.Size = New System.Drawing.Size(75, 23)
        Me.cmdEnr.TabIndex = 20
        Me.cmdEnr.Text = "J'enregistre"
        Me.cmdEnr.UseVisualStyleBackColor = True
        '
        'txtDateNaissanceC
        '
        Me.txtDateNaissanceC.Location = New System.Drawing.Point(176, 130)
        Me.txtDateNaissanceC.Name = "txtDateNaissanceC"
        Me.txtDateNaissanceC.Size = New System.Drawing.Size(121, 20)
        Me.txtDateNaissanceC.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(173, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Date de Naissance"
        '
        'txtNomJeuneFilleC
        '
        Me.txtNomJeuneFilleC.Location = New System.Drawing.Point(176, 82)
        Me.txtNomJeuneFilleC.Name = "txtNomJeuneFilleC"
        Me.txtNomJeuneFilleC.Size = New System.Drawing.Size(121, 20)
        Me.txtNomJeuneFilleC.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(173, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Nom de jeune fille"
        '
        'txtProfessionC
        '
        Me.txtProfessionC.Location = New System.Drawing.Point(176, 226)
        Me.txtProfessionC.Name = "txtProfessionC"
        Me.txtProfessionC.Size = New System.Drawing.Size(121, 20)
        Me.txtProfessionC.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(173, 210)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Profession"
        '
        'txtRevenuC
        '
        Me.txtRevenuC.Location = New System.Drawing.Point(176, 178)
        Me.txtRevenuC.Name = "txtRevenuC"
        Me.txtRevenuC.Size = New System.Drawing.Size(121, 20)
        Me.txtRevenuC.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(173, 162)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Revenu annuel"
        '
        'cmdBien
        '
        Me.cmdBien.Location = New System.Drawing.Point(392, 389)
        Me.cmdBien.Name = "cmdBien"
        Me.cmdBien.Size = New System.Drawing.Size(75, 23)
        Me.cmdBien.TabIndex = 29
        Me.cmdBien.Text = "Voiture"
        Me.cmdBien.UseVisualStyleBackColor = True
        '
        'cmdCredit
        '
        Me.cmdCredit.Location = New System.Drawing.Point(510, 389)
        Me.cmdCredit.Name = "cmdCredit"
        Me.cmdCredit.Size = New System.Drawing.Size(75, 23)
        Me.cmdCredit.TabIndex = 30
        Me.cmdCredit.Text = "Crédit"
        Me.cmdCredit.UseVisualStyleBackColor = True
        '
        'cmdIntroduction
        '
        Me.cmdIntroduction.Location = New System.Drawing.Point(286, 389)
        Me.cmdIntroduction.Name = "cmdIntroduction"
        Me.cmdIntroduction.Size = New System.Drawing.Size(75, 23)
        Me.cmdIntroduction.TabIndex = 31
        Me.cmdIntroduction.Text = "Introduction"
        Me.cmdIntroduction.UseVisualStyleBackColor = True
        '
        'frmClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdIntroduction)
        Me.Controls.Add(Me.cmdCredit)
        Me.Controls.Add(Me.cmdBien)
        Me.Controls.Add(Me.txtRevenuC)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtProfessionC)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtNomJeuneFilleC)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDateNaissanceC)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmdEnr)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTelephoneC)
        Me.Controls.Add(Me.txtVilleC)
        Me.Controls.Add(Me.txtAdresseC)
        Me.Controls.Add(Me.txtCPC)
        Me.Controls.Add(Me.txtPrenomC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNomC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboCidt)
        Me.Name = "frmClient"
        Me.Text = "frmClient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPrenomC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNomC As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboCidt As ComboBox
    Friend WithEvents txtCPC As TextBox
    Friend WithEvents txtAdresseC As TextBox
    Friend WithEvents txtVilleC As TextBox
    Friend WithEvents txtTelephoneC As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdEnr As Button
    Friend WithEvents txtDateNaissanceC As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNomJeuneFilleC As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtProfessionC As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtRevenuC As TextBox
    Friend WithEvents Label11 As Label
    Public Class frmClient

        Dim nom As String

    End Class
    Private Sub frmClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdEnr_Click(sender As Object, e As EventArgs) Handles cmdEnr.Click

        unClientVoit.setnomClient(txtNomC.Text)
        unClientVoit.setprenomClient(txtPrenomC.Text)
        unClientVoit.setadresseClient(txtAdresseC.Text)

        MsgBox("Enregistrer")
    End Sub

    Friend WithEvents cmdBien As Button

    Private Sub cmdBien_Click(sender As Object, e As EventArgs) Handles cmdBien.Click

        If fenBien Is Nothing Then
            fenBien = New frmSaisieBien 'Design pattern : singleton
        ElseIf fenBien.IsDisposed Then
            fenBien = New frmSaisieBien
        End If


        fenBien.Show()  'affichage objet
        fenBien.BringToFront()
        Me.Close()

    End Sub

    Friend WithEvents cmdCredit As Button

    Private Sub cmdCredit_Click(sender As Object, e As EventArgs) Handles cmdCredit.Click

        If fenCredit Is Nothing Then
            fenCredit = New frmCredit 'Design pattern : singleton
        ElseIf fenCredit.IsDisposed Then
            fenCredit = New frmCredit
        End If


        fenCredit.Show()  'affichage objet
        fenCredit.BringToFront()
        Me.Close()
    End Sub

    Friend WithEvents cmdIntroduction As Button

    Private Sub cmdIntroduction_Click(sender As Object, e As EventArgs) Handles cmdIntroduction.Click
        If fenIntro Is Nothing Then
            fenIntro = New frmIntroduction 'Design pattern : singleton
        ElseIf fenIntro.IsDisposed Then
            fenIntro = New frmIntroduction
        End If


        fenIntro.Show()  'affichage objet
        fenIntro.BringToFront()
        Me.Close()
    End Sub
End Class
