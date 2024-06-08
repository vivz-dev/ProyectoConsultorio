Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Imports System.Data.SqlClient
Imports System.Reflection

Public Class Pacientes

    Dim conexion As New SqlConnection
    Dim comando As New SqlCommand

    Private Sub Pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Conecta con el servidor local
            Dim nombrePC = Environ("computername")
            Dim rutaConexion As String = "server=" & nombrePC & "\SQLEXPRESS;database=cenature; integrated security=true"
            conexion = New SqlConnection(rutaConexion)
            llenar_grid()
        Catch ex As Exception
            MessageBox.Show("No se ha podido conectar con la base de datos.")
        End Try


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
                Dim paciente As New Paciente()
                paciente.Nombre = pacientesDataGridView.Rows(e.RowIndex).Cells("nombre").Value.ToString()
                paciente.Apellido = pacientesDataGridView.Rows(e.RowIndex).Cells("apellido").Value.ToString()
                paciente.Cedula = pacientesDataGridView.Rows(e.RowIndex).Cells("cedula").Value.ToString()
                paciente.FechaNacimiento = Convert.ToDateTime(pacientesDataGridView.Rows(e.RowIndex).Cells("fechaNacimiento").Value)
                paciente.Telefono = pacientesDataGridView.Rows(e.RowIndex).Cells("telefono").Value.ToString()
                paciente.Sexo = pacientesDataGridView.Rows(e.RowIndex).Cells("sexo").Value.ToString()
                paciente.estadoCivil = pacientesDataGridView.Rows(e.RowIndex).Cells("estadoCivil").Value.ToString()
                paciente.Ocupacion = pacientesDataGridView.Rows(e.RowIndex).Cells("ocupacion").Value.ToString()
                '
                'paciente.patologicas


                ' Crea una nueva instancia del formulario de detalles y pasa el objeto Paciente
                Dim detallesForm As New InformacionPaciente()
                detallesForm.SetPaciente(paciente)

                ' Muestra el formulario de detalles
                detallesForm.ShowDialog()
            Else
                MessageBox.Show("El paciente especificado no existe.")
            End If
        End If
    End Sub

    'Private Sub obtenerAntecedentes()
    '    Dim consulta As String = "SELECT * FROM paciente"
    '    Dim adaptador As New SqlDataAdapter(consulta, conexion)
    '    Dim dt As New DataTable
    '    adaptador.Fill(dt)
    '    pacientesDataGridView.DataSource = dt

    '    pacientesDataGridView.Columns.Add(btnVerMas)
    '    AddHandler pacientesDataGridView.CellContentClick, AddressOf pacientesDataGridView_CellContentClick
    'End Sub




End Class