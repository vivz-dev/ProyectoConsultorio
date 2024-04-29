Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub agregarRadiografia_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        Dim BuscarForm As New buscarPaciente()

        ' Mostrar el formulario
        BuscarForm.Show()

        ' Opcionalmente, puedes ocultar el formulario actual si lo deseas
        Me.Hide()
    End Sub

    Private Sub agenda_Click(sender As Object, e As EventArgs) Handles agenda.Click
        Dim AgendaForm As New Form1()

        ' Mostrar el formulario
        AgendaForm.Show()

        ' Opcionalmente, puedes ocultar el formulario actual si lo deseas
        Me.Hide()
    End Sub

    Private Sub pacientes_Click(sender As Object, e As EventArgs) Handles pacientes.Click
        Dim PacientesForm As New Pacientes()

        ' Mostrar el formulario
        PacientesForm.Show()

        ' Opcionalmente, puedes ocultar el formulario actual si lo deseas
        Me.Hide()
    End Sub

    Private Sub crear_Click(sender As Object, e As EventArgs) Handles crear.Click
        Dim nuevoPacienteForm As New nuevoPaciente()

        ' Mostrar el formulario
        nuevoPacienteForm.Show()

        ' Opcionalmente, puedes ocultar el formulario actual si lo deseas
        Me.Hide()
    End Sub

    Private Sub configuracion_Click(sender As Object, e As EventArgs) Handles configuracion.Click
        Dim configuracionForm As New configuracion()

        ' Mostrar el formulario
        configuracionForm.Show()

        ' Opcionalmente, puedes ocultar el formulario actual si lo deseas
        Me.Hide()
    End Sub
End Class
