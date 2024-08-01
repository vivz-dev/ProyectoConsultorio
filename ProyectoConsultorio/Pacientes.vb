Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Text

Public Class Pacientes

    Private Sub Pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ReadCSV()
        Catch ex As Exception
            MessageBox.Show("No se ha podido leer la base de datos.")
        End Try


        'No tocar
        Me.ControlBox = False
        Me.MdiParent = Form1
    End Sub

    Private Sub pacientesDataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        ' Verifica si el clic fue en una celda de la columna del botón
        If e.ColumnIndex = pacientesDataGridView2.Columns("btnVerMas").Index AndAlso e.RowIndex >= 0 Then
            ' Obtén el ID del paciente u otra información relevante
            Dim pacienteNombre As String = pacientesDataGridView2.Rows(e.RowIndex).Cells("Nombre").Value.ToString()
            Dim pacienteApellido As String = pacientesDataGridView2.Rows(e.RowIndex).Cells("Apellido").Value.ToString()
            Dim pacienteCedula As String = pacientesDataGridView2.Rows(e.RowIndex).Cells("Cedula").Value.ToString()
            Dim pacienteFechaNacimiento As String = pacientesDataGridView2.Rows(e.RowIndex).Cells("Fecha").Value.ToString()
            Dim pacienteTelefono As String = pacientesDataGridView2.Rows(e.RowIndex).Cells("Telefono").Value.ToString()
            Dim pacienteId As Integer = Convert.ToInt32(pacientesDataGridView2.Rows(e.RowIndex).Cells("idPaciente").Value)
            If pacienteId Then
                Dim paciente As New Paciente()
                paciente.Nombre = pacientesDataGridView2.Rows(e.RowIndex).Cells("Nombre").Value.ToString()
                paciente.Apellido = pacientesDataGridView2.Rows(e.RowIndex).Cells("Apellido").Value.ToString()
                paciente.Cedula = pacientesDataGridView2.Rows(e.RowIndex).Cells("Cedula").Value.ToString()
                paciente.FechaNacimiento = Convert.ToDateTime(pacientesDataGridView2.Rows(e.RowIndex).Cells("Fecha").Value)
                paciente.Telefono = pacientesDataGridView2.Rows(e.RowIndex).Cells("Telefono").Value.ToString()
                paciente.Sexo = pacientesDataGridView2.Rows(e.RowIndex).Cells("Sexo").Value.ToString()
                paciente.estadoCivil = pacientesDataGridView2.Rows(e.RowIndex).Cells("EstadoCivil").Value.ToString()
                paciente.Ocupacion = pacientesDataGridView2.Rows(e.RowIndex).Cells("Ocupacion").Value.ToString()
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
    '    pacientesDataGridView2.DataSource = dt

    '    pacientesDataGridView2.Columns.Add(btnVerMas)
    '    AddHandler pacientesDataGridView2.CellContentClick, AddressOf pacientesDataGridView2_CellContentClick
    'End Sub

    Private Sub ReadCSV()
        'Boton Ver Mas
        Dim btnVerMas As New DataGridViewButtonColumn
        btnVerMas.HeaderText = ""
        btnVerMas.Text = "Ver Más"
        btnVerMas.Name = "btnVerMas"
        btnVerMas.UseColumnTextForButtonValue = True

        pacientesDataGridView2.Columns.Add(btnVerMas)
        AddHandler pacientesDataGridView2.CellContentClick, AddressOf pacientesDataGridView2_CellContentClick

        'Leer CSV
        pacientesDataGridView2.Rows.Clear()

        Dim FilaSexo As Integer = 5
        Dim FilaCivil As Integer = 6
        Dim FilaFecha As Integer = 4

        Dim parentPath As String = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(My.Application.Info.DirectoryPath)))
        Dim folderPath As String = String.Concat(parentPath, "\Database\")
        Dim fName As String = String.Concat(folderPath, "pacientes.csv")
        Dim enc As System.Text.Encoding = System.Text.Encoding.Default

        Try
            For I = 1 To IO.File.ReadLines(fName).Count - 1
                Dim Fila As String() = IO.File.ReadLines(fName, enc)(I).Split(",")

                ' Convertir el valor de "Sexo" a su representación textual
                Select Case Fila(FilaSexo)
                    Case "1"
                        Fila(FilaSexo) = "Mujer"
                    Case "2"
                        Fila(FilaSexo) = "Hombre"
                    Case "3"
                        Fila(FilaSexo) = "Otro"
                End Select

                ' Convertir el valor de "estadoCivil" a su representación textual
                Select Case Fila(FilaCivil)
                    Case "1"
                        Fila(FilaCivil) = "Soltero"
                    Case "2"
                        Fila(FilaCivil) = "Casado"
                    Case "3"
                        Fila(FilaCivil) = "Divorciado"
                    Case "4"
                        Fila(FilaCivil) = "Unión Libre"
                    Case "5"
                        Fila(FilaCivil) = "Otro"
                    Case "6"
                        Fila(FilaCivil) = "Viudo"
                End Select

                ' Convertir la fecha de dd/mm/yyyy a dd-mmm-yyyy (con el mes en texto)
                Dim fechaOriginal As String = Fila(FilaFecha)
                Dim fechaConvertida As DateTime = DateTime.ParseExact(fechaOriginal, "dd/MM/yyyy", Nothing)
                Fila(FilaFecha) = fechaConvertida.ToString("dd/MMM/yyyy")

                pacientesDataGridView2.Rows.Add(Fila)
            Next
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al abrir el archivo.")
        End Try

    End Sub
End Class