Module moduleVariable
    'accessible a tout le monde
    Public fenIntro As frmIntroduction
    Public fenBien As frmSaisieBien
    Public fenCredit As frmCredit
    Public fenClient As frmClient

    Public fenCreditBis As frmCreditBis



    Public uneConcession As New Concession 'dans tout les cas doit etre créee
    'ou Public uneConcession As Concession()

    Public uneVoiture As New Voiture ' la voiture appartient au client 
    Public unClientVoit As New ClientVoit
    Public unCredit As New Credit

    Public unCreditBis As New Credit

End Module
