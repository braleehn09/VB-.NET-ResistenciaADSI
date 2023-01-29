Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SegundaBanda.Enabled = False
        Multiplicador.Enabled = False
        Tolerancia.Enabled = False
        MultiplicadorCinco.Enabled = False
        ToleranciaCinco.Enabled = False
        BandaUno.Enabled = False
        BandaSegunda.Enabled = False
        BandaTercera.Enabled = False
        BandaMultiplicador.Enabled = False
        BandaTolerancia.Enabled = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PrimeraBanda.SelectedIndexChanged
        Select Case PrimeraBanda.SelectedIndex
            Case 0
                BandaUno.BackColor = Color.Black
            Case 1
                TxtResultado.Text = "1"
                BandaUno.BackColor = Color.Maroon
            Case 2
                TxtResultado.Text = "2"
                BandaUno.BackColor = Color.Red
            Case 3
                TxtResultado.Text = "3"
                BandaUno.BackColor = Color.Orange
            Case 4
                TxtResultado.Text = "4"
                BandaUno.BackColor = Color.Yellow
            Case 5
                TxtResultado.Text = "5"
                BandaUno.BackColor = Color.Green
            Case 6
                TxtResultado.Text = "6"
                BandaUno.BackColor = Color.Blue
            Case 7
                TxtResultado.Text = "7"
                BandaUno.BackColor = Color.Violet
            Case 8
                TxtResultado.Text = "8"
                BandaUno.BackColor = Color.Gray
            Case 9
                TxtResultado.Text = "9"
                BandaUno.BackColor = Color.White
        End Select
        PrimeraBanda.Enabled = False
        SegundaBanda.Enabled = True
        SegundaBanda.Focus()
    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SegundaBanda.SelectedIndexChanged
        Select Case SegundaBanda.SelectedIndex
            Case 0
                TxtResultado.Text += "0"
                BandaSegunda.BackColor = Color.Black
            Case 1
                TxtResultado.Text += "1"
                BandaSegunda.BackColor = Color.Maroon
            Case 2
                TxtResultado.Text += "2"
                BandaSegunda.BackColor = Color.Red
            Case 3
                TxtResultado.Text += "3"
                BandaSegunda.BackColor = Color.Orange
            Case 4
                TxtResultado.Text += "4"
                BandaSegunda.BackColor = Color.Yellow
            Case 5
                TxtResultado.Text += "5"
                BandaSegunda.BackColor = Color.Green
            Case 6
                TxtResultado.Text += "6"
                BandaSegunda.BackColor = Color.Blue
            Case 7
                TxtResultado.Text += "7"
                BandaSegunda.BackColor = Color.Violet
            Case 8
                TxtResultado.Text += "8"
                BandaSegunda.BackColor = Color.Gray
            Case 9
                TxtResultado.Text += "9"
                BandaSegunda.BackColor = Color.White

        End Select
        SegundaBanda.Enabled = False
        Multiplicador.Enabled = True
        Multiplicador.Focus()
    End Sub


    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Multiplicador.SelectedIndexChanged

        Select Case Multiplicador.SelectedIndex
            Case 0
                BandaMultiplicador.BackColor = Color.Black
            Case 1
                TxtResultado.Text += "0"
                BandaMultiplicador.BackColor = Color.Maroon
            Case 2
                TxtResultado.Text += "00"
                BandaMultiplicador.BackColor = Color.Red
            Case 3
                TxtResultado.Text += "000"
                BandaMultiplicador.BackColor = Color.Orange
            Case 4
                TxtResultado.Text += "0000"
                BandaMultiplicador.BackColor = Color.Yellow
            Case 5
                TxtResultado.Text += "00000"
                BandaMultiplicador.BackColor = Color.Green
            Case 6
                TxtResultado.Text += "000000"
                BandaMultiplicador.BackColor = Color.Blue
            Case 7
                TxtResultado.Text += "0000000"
                BandaMultiplicador.BackColor = Color.Violet
            Case 8
                TxtResultado.Text += "00000000"
                BandaMultiplicador.BackColor = Color.Gray
            Case 9
                TxtResultado.Text += "000000000"
                BandaMultiplicador.BackColor = Color.White
            Case 10
                TxtResultado.Text = TxtResultado.Text * 0.1
                BandaMultiplicador.BackColor = Color.Gold
            Case 11
                TxtResultado.Text = TxtResultado.Text * 0.01
                BandaMultiplicador.BackColor = Color.Silver

        End Select
        Multiplicador.Enabled = False
        Tolerancia.Enabled = True
    End Sub



    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tolerancia.SelectedIndexChanged



        Select Case Tolerancia.SelectedIndex
            Case 0
                BandaTolerancia.BackColor = Color.Red
                TxtResultado.Text = TxtResultado.Text
                TxtResultadoTolerancia.Text = (TxtResultado.Text * 2 / 100)
            Case 1
                BandaTolerancia.BackColor = Color.Gold
                TxtResultado.Text = TxtResultado.Text
                TxtResultadoTolerancia.Text = (TxtResultado.Text * 5 / 100)
            Case 2
                BandaTolerancia.BackColor = Color.Silver
                TxtResultado.Text = TxtResultado.Text
                TxtResultadoTolerancia.Text = (TxtResultado.Text * 10 / 100)
        End Select

        Tolerancia.Enabled = False
        PrimeraBanda.Enabled = True
        SegundaBanda.Enabled = False
        Multiplicador.Enabled = False

        TxtResultadoToleranciaMinima.Text = TxtResultado.Text - TxtResultadoTolerancia.Text

        TxtResultadoToleranciaMaxima.Text = CDbl(TxtResultado.Text) + CDbl(TxtResultadoTolerancia.Text)

        If TxtResultadoToleranciaMinima.Text < 999 Then
            TxtResultadoToleranciaMinima.Text = TxtResultadoToleranciaMinima.Text * 1
            TxtResultadoToleranciaMinima.Text = TxtResultadoToleranciaMinima.Text & " Ohms"

        ElseIf TxtResultadoToleranciaMinima.Text >= 1000 And TxtResultadoToleranciaMinima.Text < 999999 Then

            TxtResultadoToleranciaMinima.Text = TxtResultadoToleranciaMinima.Text * 1 / 1000
            TxtResultadoToleranciaMinima.Text = TxtResultadoToleranciaMinima.Text & " K" & " Ohms"

        ElseIf TxtResultadoToleranciaMinima.Text > 999999 And TxtResultadoToleranciaMinima.Text < 999999999 Then

            TxtResultadoToleranciaMinima.Text = TxtResultadoToleranciaMinima.Text * 1 / 1000000
            TxtResultadoToleranciaMinima.Text = TxtResultadoToleranciaMinima.Text & " M" & " Ohms"

        ElseIf TxtResultadoToleranciaMinima.Text > 999999999 And TxtResultadoToleranciaMinima.Text < 999999999999999 Then
            TxtResultadoToleranciaMinima.Text = TxtResultadoToleranciaMinima.Text * 1 / 1000000000
            TxtResultadoToleranciaMinima.Text = TxtResultadoToleranciaMinima.Text & " G" & " Ohms"


        End If


        If TxtResultadoToleranciaMaxima.Text < 999 Then
            TxtResultadoToleranciaMaxima.Text = TxtResultadoToleranciaMaxima.Text * 1
            TxtResultadoToleranciaMaxima.Text = TxtResultadoToleranciaMaxima.Text & " Ohms"

        ElseIf TxtResultadoToleranciaMaxima.Text >= 1000 And TxtResultadoToleranciaMaxima.Text < 999999 Then

            TxtResultadoToleranciaMaxima.Text = TxtResultadoToleranciaMaxima.Text * 1 / 1000
            TxtResultadoToleranciaMaxima.Text = TxtResultadoToleranciaMaxima.Text & " K" & " Ohms"

        ElseIf TxtResultadoToleranciaMaxima.Text > 999999 And TxtResultadoToleranciaMaxima.Text < 999999999 Then

            TxtResultadoToleranciaMaxima.Text = TxtResultadoToleranciaMaxima.Text * 1 / 1000000
            TxtResultadoToleranciaMaxima.Text = TxtResultadoToleranciaMaxima.Text & " M" & " Ohms"

        ElseIf TxtResultadoToleranciaMaxima.Text > 999999999 And TxtResultadoToleranciaMaxima.Text < 999999999999999 Then
            TxtResultadoToleranciaMaxima.Text = TxtResultadoToleranciaMaxima.Text * 1 / 1000000000
            TxtResultadoToleranciaMaxima.Text = TxtResultadoToleranciaMaxima.Text & " G" & " Ohms"


        End If

        If TxtResultado.Text < 999 Then
            TxtResultado.Text = TxtResultado.Text * 1
            TxtResultado.Text = TxtResultado.Text & " Ohms"

        ElseIf TxtResultado.Text >= 1000 And TxtResultado.Text < 999999 Then

            TxtResultado.Text = TxtResultado.Text * 1 / 1000
            TxtResultado.Text = TxtResultado.Text & " K" & " Ohms"

        ElseIf TxtResultado.Text > 999999 And TxtResultado.Text < 999999999 Then

            TxtResultado.Text = TxtResultado.Text * 1 / 1000000
            TxtResultado.Text = TxtResultado.Text & " M" & " Ohms"

        ElseIf TxtResultado.Text > 999999999 And TxtResultado.Text < 999999999999999 Then
            TxtResultado.Text = TxtResultado.Text * 1 / 1000000000
            TxtResultado.Text = TxtResultado.Text & " G" & " Ohms"


        End If


        If TxtResultadoTolerancia.Text < 999 Then
            TxtResultadoTolerancia.Text = TxtResultadoTolerancia.Text * 1
            TxtResultadoTolerancia.Text = TxtResultadoTolerancia.Text & " Ohms"

        ElseIf TxtResultadoTolerancia.Text >= 1000 And TxtResultadoTolerancia.Text < 999999 Then

            TxtResultadoTolerancia.Text = TxtResultadoTolerancia.Text * 1 / 1000
            TxtResultadoTolerancia.Text = TxtResultadoTolerancia.Text & " K" & " Ohms"

        ElseIf TxtResultadoTolerancia.Text > 999999 And TxtResultadoTolerancia.Text < 999999999 Then

            TxtResultadoTolerancia.Text = TxtResultadoTolerancia.Text * 1 / 1000000
            TxtResultadoTolerancia.Text = TxtResultadoTolerancia.Text & " M" & " Ohms"

        ElseIf TxtResultadoTolerancia.Text > 999999999 And TxtResultadoTolerancia.Text < 999999999999999 Then
            TxtResultadoTolerancia.Text = TxtResultadoTolerancia.Text * 1 / 1000000000
            TxtResultadoTolerancia.Text = TxtResultadoTolerancia.Text & " G" & " Ohms"


        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnReiniciar.Click

        PrimeraBanda.Enabled = True
        PrimeraBanda.Text = "Seleccionar"
        SegundaBanda.Enabled = False
        SegundaBanda.Text = "Seleccionar"
        TerceraBandaCinco.Enabled = False
        TerceraBandaCinco.Text = "Seleccionar"
        Multiplicador.Enabled = False
        Multiplicador.Text = "Seleccionar"
        Tolerancia.Enabled = False
        Tolerancia.Text = "Seleccionar"
        PrimeraBandaCinco.Enabled = True
        PrimeraBandaCinco.Text = "Seleccionar"
        SegundaBandaCinco.Enabled = False
        SegundaBandaCinco.Text = "Seleccionar"
        MultiplicadorCinco.Enabled = False
        MultiplicadorCinco.Text = "Seleccionar"
        ToleranciaCinco.Enabled = False
        ToleranciaCinco.Text = "Seleccionar"
        TxtResultado.Text = ""
        TxtResultadoTolerancia.Text = ""
        TxtResultadoToleranciaMinima.Text = ""
        TxtResultadoToleranciaMaxima.Text = ""
        BandaUno.BackColor = Nothing
        BandaSegunda.BackColor = Nothing
        BandaTercera.BackColor = Nothing
        BandaMultiplicador.BackColor = Nothing
        BandaTolerancia.BackColor = Nothing

    End Sub

    Private Sub RadioCincoBandas_CheckedChanged(sender As Object, e As EventArgs) Handles RadioCuatroBandas.CheckedChanged
        If RadioCincoBandas.Checked = True Then
            BoxCuatroB.Hide()
            BoxCincoB.Show()
            BandaTercera.Show()
            PrimeraBanda.Enabled = True
            PrimeraBanda.Text = "Seleccionar"
            SegundaBanda.Enabled = False
            SegundaBanda.Text = "Seleccionar"
            Multiplicador.Enabled = False
            Multiplicador.Text = "Seleccionar"
            Tolerancia.Enabled = False
            Tolerancia.Text = "Seleccionar"
            TxtResultado.Text = ""
            TxtResultadoTolerancia.Text = ""
            TxtResultadoToleranciaMinima.Text = ""
            TxtResultadoToleranciaMaxima.Text = ""
            BandaUno.BackColor = Nothing
            BandaSegunda.BackColor = Nothing
            BandaTercera.BackColor = Nothing
            BandaMultiplicador.BackColor = Nothing
            BandaTolerancia.BackColor = Nothing
        End If

        If RadioCuatroBandas.Checked = True Then
            BoxCuatroB.Show()
            BoxCincoB.Hide()
            BandaTercera.Hide()

            PrimeraBandaCinco.Enabled = True
            PrimeraBandaCinco.Text = "Seleccionar"
            SegundaBandaCinco.Enabled = False
            SegundaBandaCinco.Text = "Seleccionar"
            TerceraBandaCinco.Enabled = False
            TerceraBandaCinco.Text = "Seleccionar"
            MultiplicadorCinco.Enabled = False
            MultiplicadorCinco.Text = "Seleccionar"
            ToleranciaCinco.Enabled = False
            ToleranciaCinco.Text = "Seleccionar"
            TxtResultado.Text = ""
            TxtResultadoTolerancia.Text = ""
            TxtResultadoToleranciaMinima.Text = ""
            TxtResultadoToleranciaMaxima.Text = ""
            BandaUno.BackColor = Nothing
            BandaSegunda.BackColor = Nothing
            BandaTercera.BackColor = Nothing
            BandaMultiplicador.BackColor = Nothing
            BandaTolerancia.BackColor = Nothing

        End If

    End Sub

    Private Sub PrimeraBandaCinco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PrimeraBandaCinco.SelectedIndexChanged
        Select Case PrimeraBandaCinco.SelectedIndex
            Case 0
                TxtResultado.Text = "0"
                BandaUno.BackColor = Color.Black
            Case 1
                TxtResultado.Text = "1"
                BandaUno.BackColor = Color.Maroon
            Case 2
                TxtResultado.Text = "2"
                BandaUno.BackColor = Color.Red
            Case 3
                TxtResultado.Text = "3"
                BandaUno.BackColor = Color.Orange
            Case 4
                TxtResultado.Text = "4"
                BandaUno.BackColor = Color.Yellow
            Case 5
                TxtResultado.Text = "5"
                BandaUno.BackColor = Color.Green
            Case 6
                TxtResultado.Text = "6"
                BandaUno.BackColor = Color.Blue
            Case 7
                TxtResultado.Text = "7"
                BandaUno.BackColor = Color.Violet
            Case 8
                TxtResultado.Text = "8"
                BandaUno.BackColor = Color.Gray
            Case 9
                TxtResultado.Text = "9"
                BandaUno.BackColor = Color.White

        End Select
        PrimeraBandaCinco.Enabled = False
        SegundaBandaCinco.Enabled = True
        SegundaBandaCinco.Focus()
    End Sub

    Private Sub SegundaBandaCinco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SegundaBandaCinco.SelectedIndexChanged
        Select Case SegundaBandaCinco.SelectedIndex
            Case 0
                TxtResultado.Text += "0"
                BandaSegunda.BackColor = Color.Black
            Case 1
                TxtResultado.Text += "1"
                BandaSegunda.BackColor = Color.Maroon
            Case 2
                TxtResultado.Text += "2"
                BandaSegunda.BackColor = Color.Red
            Case 3
                TxtResultado.Text += "3"
                BandaSegunda.BackColor = Color.Orange
            Case 4
                TxtResultado.Text += "4"
                BandaSegunda.BackColor = Color.Yellow
            Case 5
                TxtResultado.Text += "5"
                BandaSegunda.BackColor = Color.Green
            Case 6
                TxtResultado.Text += "6"
                BandaSegunda.BackColor = Color.Blue
            Case 7
                TxtResultado.Text += "7"
                BandaSegunda.BackColor = Color.Violet
            Case 8
                TxtResultado.Text += "8"
                BandaSegunda.BackColor = Color.Gray
            Case 9
                TxtResultado.Text += "9"
                BandaSegunda.BackColor = Color.White

        End Select
        SegundaBandaCinco.Enabled = False
        TerceraBandaCinco.Enabled = True
        TerceraBandaCinco.Focus()


    End Sub

    Private Sub TerceraBandaCinco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TerceraBandaCinco.SelectedIndexChanged
        Select Case TerceraBandaCinco.SelectedIndex
            Case 0
                TxtResultado.Text += "0"
                BandaTercera.BackColor = Color.Black
            Case 1
                TxtResultado.Text += "1"
                BandaTercera.BackColor = Color.Maroon
            Case 2
                TxtResultado.Text += "2"
                BandaTercera.BackColor = Color.Red
            Case 3
                TxtResultado.Text += "3"
                BandaTercera.BackColor = Color.Orange
            Case 4
                TxtResultado.Text += "4"
                BandaTercera.BackColor = Color.Yellow
            Case 5
                TxtResultado.Text += "5"
                BandaTercera.BackColor = Color.Green
            Case 6
                TxtResultado.Text += "6"
                BandaTercera.BackColor = Color.Blue
            Case 7
                TxtResultado.Text += "7"
                BandaTercera.BackColor = Color.Violet
            Case 8
                TxtResultado.Text += "8"
                BandaTercera.BackColor = Color.Gray
            Case 9
                TxtResultado.Text += "9"
                BandaTercera.BackColor = Color.White

        End Select
        TerceraBandaCinco.Enabled = False
        MultiplicadorCinco.Enabled = True
        MultiplicadorCinco.Focus()
    End Sub
    Private Sub MultiplicadorCinco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MultiplicadorCinco.SelectedIndexChanged

        Select Case MultiplicadorCinco.SelectedIndex
            Case 0
                BandaMultiplicador.BackColor = Color.Black
            Case 1
                TxtResultado.Text += "0"
                BandaMultiplicador.BackColor = Color.Maroon
            Case 2
                TxtResultado.Text += "00"
                BandaMultiplicador.BackColor = Color.Red
            Case 3
                TxtResultado.Text += "000"
                BandaMultiplicador.BackColor = Color.Orange
            Case 4
                TxtResultado.Text += "0000"
                BandaMultiplicador.BackColor = Color.Yellow
            Case 5
                TxtResultado.Text += "00000"
                BandaMultiplicador.BackColor = Color.Green
            Case 6
                TxtResultado.Text += "000000"
                BandaMultiplicador.BackColor = Color.Blue
            Case 7
                TxtResultado.Text += "0000000"
                BandaMultiplicador.BackColor = Color.Violet
            Case 8
                TxtResultado.Text += "00000000"
                BandaMultiplicador.BackColor = Color.Gray
            Case 9
                TxtResultado.Text += "000000000"
                BandaMultiplicador.BackColor = Color.White
            Case 10
                TxtResultado.Text = TxtResultado.Text * 0.1
                BandaMultiplicador.BackColor = Color.Gold
            Case 11
                TxtResultado.Text = TxtResultado.Text * 0.01
                BandaMultiplicador.BackColor = Color.Silver

        End Select
        MultiplicadorCinco.Enabled = False
        ToleranciaCinco.Enabled = True
        ToleranciaCinco.Focus()


    End Sub

    Private Sub ToleranciaCinco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToleranciaCinco.SelectedIndexChanged
        Select Case ToleranciaCinco.SelectedIndex
            Case 0
                BandaTolerancia.BackColor = Color.Red
                TxtResultado.Text = TxtResultado.Text
                TxtResultadoTolerancia.Text = (TxtResultado.Text * 2 / 100)
            Case 1
                BandaTolerancia.BackColor = Color.Gold
                TxtResultado.Text = TxtResultado.Text
                TxtResultadoTolerancia.Text = (TxtResultado.Text * 5 / 100)
            Case 2
                BandaTolerancia.BackColor = Color.Silver
                TxtResultado.Text = TxtResultado.Text
                TxtResultadoTolerancia.Text = (TxtResultado.Text * 10 / 100)


        End Select

        ToleranciaCinco.Enabled = False
        PrimeraBandaCinco.Enabled = True
        SegundaBandaCinco.Enabled = False
        TerceraBandaCinco.Enabled = False
        MultiplicadorCinco.Enabled = False
        BoxCincoB.Enabled = True

        TxtResultadoToleranciaMinima.Text = TxtResultado.Text - TxtResultadoTolerancia.Text

        TxtResultadoToleranciaMaxima.Text = CDbl(TxtResultado.Text) + CDbl(TxtResultadoTolerancia.Text)

        If TxtResultadoToleranciaMinima.Text < 999 Then
            TxtResultadoToleranciaMinima.Text = TxtResultadoToleranciaMinima.Text * 1
            TxtResultadoToleranciaMinima.Text = TxtResultadoToleranciaMinima.Text & " Ohms"

        ElseIf TxtResultadoToleranciaMinima.Text >= 1000 And TxtResultadoToleranciaMinima.Text < 999999 Then

            TxtResultadoToleranciaMinima.Text = TxtResultadoToleranciaMinima.Text * 1 / 1000
            TxtResultadoToleranciaMinima.Text = TxtResultadoToleranciaMinima.Text & " K" & " Ohms"

        ElseIf TxtResultadoToleranciaMinima.Text > 999999 And TxtResultadoToleranciaMinima.Text < 999999999 Then

            TxtResultadoToleranciaMinima.Text = TxtResultadoToleranciaMinima.Text * 1 / 1000000
            TxtResultadoToleranciaMinima.Text = TxtResultadoToleranciaMinima.Text & " M" & " Ohms"

        ElseIf TxtResultadoToleranciaMinima.Text > 999999999 And TxtResultadoToleranciaMinima.Text < 999999999999999 Then
            TxtResultadoToleranciaMinima.Text = TxtResultadoToleranciaMinima.Text * 1 / 1000000000
            TxtResultadoToleranciaMinima.Text = TxtResultadoToleranciaMinima.Text & " G" & " Ohms"


        End If


        If TxtResultadoToleranciaMaxima.Text < 999 Then
            TxtResultadoToleranciaMaxima.Text = TxtResultadoToleranciaMaxima.Text * 1
            TxtResultadoToleranciaMaxima.Text = TxtResultadoToleranciaMaxima.Text & " Ohms"

        ElseIf TxtResultadoToleranciaMaxima.Text >= 1000 And TxtResultadoToleranciaMaxima.Text < 999999 Then

            TxtResultadoToleranciaMaxima.Text = TxtResultadoToleranciaMaxima.Text * 1 / 1000
            TxtResultadoToleranciaMaxima.Text = TxtResultadoToleranciaMaxima.Text & " K" & " Ohms"

        ElseIf TxtResultadoToleranciaMaxima.Text > 999999 And TxtResultadoToleranciaMaxima.Text < 999999999 Then

            TxtResultadoToleranciaMaxima.Text = TxtResultadoToleranciaMaxima.Text * 1 / 1000000
            TxtResultadoToleranciaMaxima.Text = TxtResultadoToleranciaMaxima.Text & " M" & " Ohms"

        ElseIf TxtResultadoToleranciaMaxima.Text > 999999999 And TxtResultadoToleranciaMaxima.Text < 999999999999999 Then
            TxtResultadoToleranciaMaxima.Text = TxtResultadoToleranciaMaxima.Text * 1 / 1000000000
            TxtResultadoToleranciaMaxima.Text = TxtResultadoToleranciaMaxima.Text & " G" & " Ohms"


        End If

        If TxtResultado.Text < 999 Then
            TxtResultado.Text = TxtResultado.Text * 1
            TxtResultado.Text = TxtResultado.Text & " Ohms"

        ElseIf TxtResultado.Text >= 1000 And TxtResultado.Text < 999999 Then

            TxtResultado.Text = TxtResultado.Text * 1 / 1000
            TxtResultado.Text = TxtResultado.Text & " K" & " Ohms"

        ElseIf TxtResultado.Text > 999999 And TxtResultado.Text < 999999999 Then

            TxtResultado.Text = TxtResultado.Text * 1 / 1000000
            TxtResultado.Text = TxtResultado.Text & " M" & " Ohms"

        ElseIf TxtResultado.Text > 999999999 And TxtResultado.Text < 999999999999999 Then
            TxtResultado.Text = TxtResultado.Text * 1 / 1000000000
            TxtResultado.Text = TxtResultado.Text & " G" & " Ohms"



        End If

        If TxtResultadoTolerancia.Text < 999 Then
            TxtResultadoTolerancia.Text = TxtResultadoTolerancia.Text * 1
            TxtResultadoTolerancia.Text = TxtResultadoTolerancia.Text & " Ohms"

        ElseIf TxtResultadoTolerancia.Text >= 1000 And TxtResultadoTolerancia.Text < 999999 Then

            TxtResultadoTolerancia.Text = TxtResultadoTolerancia.Text * 1 / 1000
            TxtResultadoTolerancia.Text = TxtResultadoTolerancia.Text & " K" & " Ohms"

        ElseIf TxtResultadoTolerancia.Text > 999999 And TxtResultadoTolerancia.Text < 999999999 Then

            TxtResultadoTolerancia.Text = TxtResultadoTolerancia.Text * 1 / 1000000
            TxtResultadoTolerancia.Text = TxtResultadoTolerancia.Text & " M" & " Ohms"

        ElseIf TxtResultadoTolerancia.Text > 999999999 And TxtResultadoTolerancia.Text < 999999999999999 Then
            TxtResultadoTolerancia.Text = TxtResultadoTolerancia.Text * 1 / 1000000000
            TxtResultadoTolerancia.Text = TxtResultadoTolerancia.Text & " G" & " Ohms"


        End If

    End Sub

    Private Sub ChangeCalcuNormal_Click(sender As Object, e As EventArgs) Handles ChangeCalcuNormal.Click

        Dim CalculadoraWindows As New Process()
        CalculadoraWindows.StartInfo.FileName = "calc.exe"
        CalculadoraWindows.StartInfo.Arguments = ""
        CalculadoraWindows.Start()



    End Sub

    Private Sub InglesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnglishLanguage.Click

        FirstBand.Text = "First Band"
        SecondBand.Text = "Second Band"
        FirstBand5.Text = "First Band"
        SecondBand5.Text = "Second Band"
        ThirdBand.Text = "Third Band"
        Multiplier4Band.Text = "Multiplier"
        Multiplier5Band.Text = "Multiplier"
        Tolerance4Band.Text = "Tolerance"
        Tolerance5Band.Text = "Tolerance"
        ToleranceAnswer.Text = "Tolerance"
        ResistorAnswer.Text = "Resistor"

        PrimeraBanda.Text = "Select"
        SegundaBanda.Text = "Select"
        PrimeraBandaCinco.Text = "Select"
        SegundaBandaCinco.Text = "Select"
        TerceraBandaCinco.Text = "Select"
        PrimeraBanda.Text = "Select"
        Multiplicador.Text = "Select"
        MultiplicadorCinco.Text = "Select"
        Tolerancia.Text = "Select"
        ToleranciaCinco.Text = "Select"

        RadioCuatroBandas.Text = "4 bands"
        RadioCincoBandas.Text = "5 bands"

        Language.Text = "Language"
        SpanishLanguage.Text = "Spanish"
        EnglishLanguage.Text = "English"
        ChangeCalcuNormal.Text = "Windows Calculator"

        MenuArchive.Text = "TOOLS"
        BtnAyuda.Text = "HELP"
        BtnAcercaDe.Text = "ADSI Resistor INFO"
        MinToleranceAnswer.Text = "Minimum Tolerance"
        MaxToleranceAnswer.Text = "Maximum Tolerance"
        BtnReiniciar.Text = "Reset"

    End Sub

    Private Sub SpanishLanguage_Click(sender As Object, e As EventArgs) Handles SpanishLanguage.Click


        FirstBand.Text = "Primera Banda"
        SecondBand.Text = "Segunda Banda"
        FirstBand5.Text = "Primera Banda"
        SecondBand5.Text = "Segunda Banda"
        ThirdBand.Text = "Tercera Banda"
        Multiplier4Band.Text = "Multiplicador"
        Multiplier5Band.Text = "Multiplicador"
        Tolerance4Band.Text = "Tolerancia"
        Tolerance5Band.Text = "Tolerancia"
        ToleranceAnswer.Text = "Tolerancia"
        ResistorAnswer.Text = "Resistencia"
        BtnReiniciar.Text = "Reset"

        PrimeraBanda.Text = "Seleccionar"
        SegundaBanda.Text = "Seleccionar"
        PrimeraBandaCinco.Text = "Seleccionar"
        SegundaBandaCinco.Text = "Seleccionar"
        TerceraBandaCinco.Text = "Seleccionar"
        PrimeraBanda.Text = "Seleccionar"
        Multiplicador.Text = "Seleccionar"
        MultiplicadorCinco.Text = "Seleccionar"
        Tolerancia.Text = "Seleccionar"
        ToleranciaCinco.Text = "Seleccionar"

        RadioCuatroBandas.Text = "4 bandas"
        RadioCincoBandas.Text = "5 bandas"

        Language.Text = "Idioma"
        SpanishLanguage.Text = "Español"
        EnglishLanguage.Text = "Ingles"
        ChangeCalcuNormal.Text = "Calculadora de Windows"

        MenuArchive.Text = "HERRAMIENTAS"
        BtnAyuda.Text = "AYUDA"
        BtnAcercaDe.Text = "Acerca de ADSI Resistor"
        MinToleranceAnswer.Text = "Tolerancia Mínima"
        MaxToleranceAnswer.Text = "Tolerancia Máxima"

        BtnReiniciar.Text = "Reiniciar"

    End Sub

    Private Sub AcercaDeADSIResistorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BtnAcercaDe.Click
        Form3.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click, BtnCerrarSesion.Click


        Dim TxtConfirmacionCerrarSesion As String

        TxtConfirmacionCerrarSesion = MsgBox("¿Seguro que quieres cerrar sesion?", vbYesNo + vbQuestion, "")

        If TxtConfirmacionCerrarSesion = vbYes Then
            Me.Close()

            Form2.Show()

        End If

    End Sub




End Class
