Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If (TxtUsuario.Text = "" Or TxtContraseña.Text = "") Then

            MsgBox("Verifique su usuario o contraseña", vbQuestion, "")

        Else
            Me.Hide()
            Form1.Show()

        End If

        TxtUsuario.Text = ""
        TxtContraseña.Text = ""

    End Sub


End Class