Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Imports System.Data.SqlClient
Imports System.Reflection

Public Class Pacientes

    Dim conexion As New SqlConnection
    Dim comando As New SqlCommand

    Private Sub Pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Conecta con el servidor local
        Dim nombrePC = Environ("computername")
        Dim rutaConexion As String = "server=" & nombrePC & "\SQLEXPRESS;database=cenature; integrated security=true"
        conexion = New SqlConnection(rutaConexion)
        llenar_grid()

        Me.ControlBox = False
        Me.MdiParent = Form1
    End Sub
    Private Sub llenar_grid()

        Dim btnVerMas As New DataGridViewButtonColumn
        btnVerMas.HeaderText = ""
        btnVerMas.Text = "Ver Más"
        btnVerMas.Name = "btnVerMas"
        btnVerMas.UseColumnTextForButtonValue = True

        Dim consulta As String = "SELECT * FROM paciente"
        Dim adaptador As New SqlDataAdapter(consulta, conexion)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        pacientesDataGridView.DataSource = dt

        pacientesDataGridView.Columns.Add(btnVerMas)
        AddHandler pacientesDataGridView.CellContentClick, AddressOf pacientesDataGridView_CellContentClick

    End Sub
    Private Sub pacientesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        ' Verifica si el clic fue en una celda de la columna del botón
        If e.ColumnIndex = pacientesDataGridView.Columns("btnVerMas").Index AndAlso e.RowIndex >= 0 Then
            ' Obtén el ID del paciente u otra información relevante
            Dim pacienteNombre As String = pacientesDataGridView.Rows(e.RowIndex).Cells("nombre").Value.ToString()
            Dim pacienteApellido As String = pacientesDataGridView.Rows(e.RowIndex).Cells("apellido").Value.ToString()
            Dim pacienteCedula As String = pacientesDataGridView.Rows(e.RowIndex).Cells("cedula").Value.ToString()
            Dim pacienteFechaNacimiento As String = pacientesDataGridView.Rows(e.RowIndex).Cells("fechaNacimiento").Value.ToString()
            Dim pacienteTelefono As String = pacientesDataGridView.Rows(e.RowIndex).Cells("telefono").Value.ToString()
            Dim pacienteId As Integer = Convert.ToInt32(pacientesDataGridView.Rows(e.RowIndex).Cells("idPaciente").Value)
            If pacienteId Then
                ' Crea una nueva instancia del formulario de detalles
                Dim detallesForm As New InformacionPaciente()

                ' Pasa los datos del paciente al nuevo formulario
                InformacionPaciente.Nombre = pacienteNombre
                detallesForm.Apellido = pacienteApellido
                detallesForm.Cedula = pacienteCedula
                detallesForm.FechaNacimiento = pacienteFechaNacimiento
                detallesForm.Telefono = pacienteTelefono

                ' Muestra el formulario de detalles
                detallesForm.ShowDialog()
            Else
                MessageBox.Show("El paciente especificado no existe.")
            End If
        End If
    End Sub



End Class