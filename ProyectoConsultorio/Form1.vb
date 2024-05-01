Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
    End Sub

    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        buscarPaciente.Show()
        nuevoPaciente.Hide()
        Pacientes.Hide()
        configuracionForm.Hide()
    End Sub

    Private Sub nuevo_Click(sender As Object, e As EventArgs) Handles nuevo.Click
        nuevoPaciente.Show()
        buscarPaciente.Hide()
        Pacientes.Hide()
        configuracionForm.Hide()
    End Sub

    Private Sub agenda_Click(sender As Object, e As EventArgs) Handles agenda.Click

    End Sub

    Private Sub pacientesButton_Click(sender As Object, e As EventArgs) Handles pacientesButton.Click
        Pacientes.Show()
        buscarPaciente.Hide()
        nuevoPaciente.Hide()
        configuracionForm.Hide()
    End Sub

    Private Sub configuracion_Click(sender As Object, e As EventArgs) Handles configuracion.Click
        configuracionForm.Show()
        buscarPaciente.Hide()
        nuevoPaciente.Hide()
        Pacientes.Hide()
    End Sub
End Class
