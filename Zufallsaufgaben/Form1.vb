Public Class Zufallsaufgaben

    Public Function Zufallszahl(Array As Array, min As Integer, max As Integer)
        Dim Zahl As Integer = CInt(Int((max * Rnd()) + min))

        For k = 0 To Array.GetUpperBound(0)
            If Zahl = Array(k) Then
                Zahl = Zufallszahl(Array, min, max)
                Exit For
            End If
        Next
        Return Zahl
    End Function

    Private Sub check_Unterpunkte_CheckedChanged(sender As Object, e As EventArgs) Handles check_Unterpunkte.CheckedChanged
        If check_Unterpunkte.Checked = True Then
            grp_Unterpunkte.Visible = True
        Else
            grp_Unterpunkte.Visible = False
        End If
    End Sub

    Private Sub num_AufgabeVon_ValueChanged(sender As Object, e As EventArgs) Handles num_AufgabeVon.ValueChanged
        If num_AufgabeBis.Value < num_AufgabeVon.Value Then
            num_AufgabeBis.Value = num_AufgabeVon.Value
        End If

        num_AnzahlAufgaben.Maximum = num_AufgabeBis.Value - num_AufgabeVon.Value + 1
    End Sub

    Private Sub Zufallsaufgaben_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        lbl_start.Text = "Viel Erfolg beim lernen!"
    End Sub

    Private Sub num_AufgabeBis_ValueChanged(sender As Object, e As EventArgs) Handles num_AufgabeBis.ValueChanged
        num_AnzahlAufgaben.Maximum = num_AufgabeBis.Value - num_AufgabeVon.Value + 1
    End Sub

    Private Sub btn_Generieren_Click(sender As Object, e As EventArgs) Handles btn_Generieren.Click
        Dim AnzahlAufgaben As Integer = num_AnzahlAufgaben.Value - 1
        Dim ZufallsAufgaben(AnzahlAufgaben) As Integer

        lbl_start.Visible = False
        lstBox_Ausgabe.Items.Clear()

        For i = 0 To ZufallsAufgaben.GetUpperBound(0)
            ZufallsAufgaben(i) = Zufallszahl(ZufallsAufgaben, num_AufgabeVon.Value, num_AufgabeBis.Value)
        Next
        Array.Sort(ZufallsAufgaben)

        If check_Unterpunkte.Checked Then
            For j = 0 To ZufallsAufgaben.GetUpperBound(0)
                lstBox_Ausgabe.Items.Add(ZufallsAufgaben(j) & ChrW(97 + CInt(Int((num_Unterpunkte.Value * Rnd()) + 1))))
            Next
        Else
            For j = 0 To ZufallsAufgaben.GetUpperBound(0)
                lstBox_Ausgabe.Items.Add(ZufallsAufgaben(j))
            Next
        End If
    End Sub

End Class
