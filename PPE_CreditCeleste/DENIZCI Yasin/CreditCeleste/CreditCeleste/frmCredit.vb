Imports ClscCalcul
Imports System.Data.SqlClient

Public Class frmCredit
    Private taux1 As Double
    Private duree1 As Double
    Private mensualite1 As Double
	Private montant1 As Double

	'---------TEST-----------'
	Private tauxApresComm As Double
	Private niveauComm As Double
	'---------TEST-----------'

	Private Sub frmCredit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub taux_TextChanged(sender As System.Object, e As System.EventArgs) Handles taux.TextChanged
        taux1 = Convert.ToDouble(taux.Text)

    End Sub

    Private Sub montant_TextChanged(sender As System.Object, e As System.EventArgs) Handles montant.TextChanged
        montant1 = Convert.ToDouble(montant.Text)
    End Sub

    Private Sub duree_TextChanged(sender As System.Object, e As System.EventArgs) Handles duree.TextChanged
        duree1 = Convert.ToDouble(duree.Text)

    End Sub

    Private Sub mensualite_TextChanged(sender As System.Object, e As System.EventArgs) Handles mensualite.TextChanged

    End Sub

    Private Sub Btn_Click(sender As System.Object, e As System.EventArgs) Handles Btn.Click
		Dim Credit = New ClscCalcul.Calcul(taux1, montant1, duree1)

		mensualite1 = Credit.calcmensualite()
		mensualite.Text = mensualite1


		'---------------------------------------------------------------------------'
		'-------------- TEST ------------------'


		'tauxApresComm = 10 - tauxAvecComm



		'Dim Credit = New ClscCalcul.Calcul(tauxApresComm, montant1, duree1)

		'mensualite1 = Credit.calcmensualite()
		'mensualite.Text = mensualite1



		' ----------------TEST ---------------'
		'---------------------------------------------------------------------------'




	End Sub

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

    Private Sub CmdEnrCredit_Click(sender As Object, e As EventArgs) Handles CmdEnrCredit.Click

        unCredit.setCredit(mensualite.Text, montant.Text, taux.Text)
		MsgBox("Enregistrement réussis")

		Dim strRequete As String = "INSERT INTO CREDIT(montantFinance,nombreMensualite,taucCommission) VALUES(mensualite.Text,montant.Text,tauxCommission)"

	End Sub
    Private Sub cmdConnexion_Click(sender As Object, e As EventArgs) Handles cmdConnexion.Click
        'unCredit.setCredit(mensualite.Text, montant.Text, taux.Text)

        ' Connexion à la base de données !!!!!! ===> A SAVOIR !!!!!!!
        lblConnexion.Text = "connecté"


		Dim strConnexion As String = "Data Source=10.129.187.108;User Id=connYasin;password=Artemis16v1;Initial Catalog=PPECreditCeleste"
		'Authentification sqlServeur


		'requete
		Dim strRequete As String = "SELECT NomVendeur, PrenomVendeur FROM VENDEUR"

        Try

            '//connexion à la BDD

            Dim oConnexion As SqlConnection = New SqlConnection(strConnexion)

            '//lancer ma commande
            Dim oCommand As SqlCommand = New SqlCommand(strRequete, oConnexion)

            '//ouvrir la BDD
            oConnexion.Open()
            '//
            '//se positionner sur le premier objet

            Dim oReader As SqlDataReader = oCommand.ExecuteReader()

            '//lire l'enregistrement
            '//
            '//Console.WriteLine(oReader.GetValue(0) + " " + oReader.GetValue(1));
            '//Console.WriteLine(oReader.Item(0) + " " + oReader.Item(1));  //selon version
            '//Console.WriteLine(oReader.GetString(0) + " " + oReader.GetString(1));
            '//Console.WriteLine(oReader(0) + " " + oReader(1));  // en vb
            'Console.WriteLine(oReader("NomVendeur") + " " + oReader("PrenomVendeur"))


            While (oReader.Read())

                '//affiche tout les lignes de la requete
                Console.WriteLine(oReader.GetValue(0) + " " + oReader.GetValue(1))

            End While

            oReader.Close()
            oConnexion.Close()

        Catch ex As Exception

            Console.WriteLine("Erreur : " + ex.Message)

        End Try





    End Sub

    Private Sub cmdClient_Click(sender As Object, e As EventArgs) Handles cmdClient.Click
        If fenClient Is Nothing Then
            fenClient = New frmClient 'Design pattern : singleton
        ElseIf fenClient.IsDisposed Then
            fenClient = New frmClient
        End If


        fenClient.Show()  'affichage objet
        fenClient.BringToFront()
        Me.Close()
    End Sub

    Private Sub cmdCreditBis_Click(sender As Object, e As EventArgs) Handles cmdCreditBis.Click
        If fenCreditBis Is Nothing Then
            fenCreditBis = New frmCreditBis 'Design pattern : singleton
        ElseIf fenCreditBis.IsDisposed Then
            fenCreditBis = New frmCreditBis
        End If


        fenCreditBis.Show()  'affichage objet
        fenCreditBis.BringToFront()
        Me.Close()
    End Sub

    Private Sub frmCredit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

		If IsNumeric(e.KeyChar) Then
			Exit Sub
		End If


        '---------------------------------------------------------------------------'
        ' TEST '



        'salut'


        ' TEST '
        '---------------------------------------------------------------------------'


        If (e.KeyChar = "p") Then
            e.Handled = True
            taux.Text = taux.Text + 1

        End If



        If (e.KeyChar = "m") Then
            e.Handled = True
            taux.Text = taux.Text - 1

        End If

    End Sub
End Class