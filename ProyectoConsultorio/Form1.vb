Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
        With agenda
            .TopLevel = False
            Panel3.Controls.Add(agenda)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        nuevoPaciente.Hide()
        Pacientes.Hide()
        configuracionForm.Hide()
        With buscarPaciente
            .TopLevel = False
            Panel3.Controls.Add(buscarPaciente)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub nuevo_Click(sender As Object, e As EventArgs) Handles nuevo.Click
        buscarPaciente.Hide()
        Pacientes.Hide()
        configuracionForm.Hide()
        agenda.Hide()
        With nuevoPaciente
            .TopLevel = False
            Panel3.Controls.Add(nuevoPaciente)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub agendaBtn_Click(sender As Object, e As EventArgs) Handles agendaBtn.Click
        buscarPaciente.Hide()
        nuevoPaciente.Hide()
        configuracionForm.Hide()
        Pacientes.Hide()
        With agenda
            .TopLevel = False
            Panel3.Controls.Add(agenda)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub pacientesButton_Click(sender As Object, e As EventArgs) Handles pacientesButton.Click
        With Pacientes
            .TopLevel = False
            Panel3.Controls.Add(Pacientes)
            .BringToFront()
            .Show()
        End With
        buscarPaciente.Hide()
        nuevoPaciente.Hide()
        configuracionForm.Hide()
        agenda.Hide()

    End Sub

    Private Sub configuracion_Click(sender As Object, e As EventArgs) Handles configuracion.Click
        buscarPaciente.Hide()
        nuevoPaciente.Hide()
        Pacientes.Hide()
        agenda.Hide()
        With configuracionForm
            .TopLevel = False
            Panel3.Controls.Add(configuracionForm)
            .BringToFront()
            .Show()

        End With
    End Sub
End Class
