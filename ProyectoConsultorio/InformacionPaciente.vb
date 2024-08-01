Imports Microsoft.VisualBasic.FileIO
Imports System.IO

Public Class InformacionPaciente

    Private _paciente As Paciente

    ' Método para establecer el objeto Paciente
    Public Sub SetPaciente(paciente As Paciente)
        _paciente = paciente
    End Sub


    Private Sub InformacionPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarInfoPaciente()
        cargarRadiografias()
        cargarTomografias()
        'cargarResonancias()
        'cargarOtros()
    End Sub

    Private Sub cargarInfoPaciente()
        nombre.Text = _paciente.Nombre
        apellido.Text = _paciente.Apellido
        cedula.Text = _paciente.Cedula
        fechaNacimiento.Text = _paciente.FechaNacimiento
        telefono.Text = _paciente.Telefono
        ocupacion.Text = _paciente.Ocupacion
        genero.Text = _paciente.ObtenerGeneroTexto()
        estadoCivil.Text = _paciente.ObtenerEstadoCivil()
    End Sub

    Private Sub cargarRadiografias()

        Dim btnVer As New DataGridViewButtonColumn
        btnVer.HeaderText = ""
        btnVer.Text = "Ver"
        btnVer.Name = "btnVer"
        btnVer.UseColumnTextForButtonValue = True

        Dim btnEliminar As New DataGridViewButtonColumn
        btnEliminar.HeaderText = ""
        btnEliminar.Text = "Eliminar"
        btnEliminar.Name = "btnEliminar"
        btnEliminar.UseColumnTextForButtonValue = True


        radiografiasDataGridView.Columns.AddRange(New DataGridViewColumn(3) _
                                    {
                                    New DataGridViewTextBoxColumn() With {.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, .HeaderText = "Nombre", .Name = "Nombre"},
                                     New DataGridViewTextBoxColumn() With {.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, .HeaderText = "Fecha de creación", .Name = "Fecha"},
                                     btnVer, btnEliminar})

        Dim parentPath As String = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(My.Application.Info.DirectoryPath)))
        Dim folderPath As String = String.Concat(parentPath, "\Documentos\Radiografias")

        If Directory.Exists(folderPath) Then
            'MessageBox.Show(String.Concat("Abriendo la carpeta... ", folderPath))
            Dim files() As String = Directory.GetFiles(folderPath)
            For Each filePath As String In files
                Dim fileName As String = Path.GetFileName(filePath)
                Dim creationDate As String = File.GetCreationTime(filePath).ToString()
                radiografiasDataGridView.Rows.Add({fileName, creationDate})
            Next
        Else
            MessageBox.Show("La carpeta especificada no existe.", folderPath)
        End If

    End Sub

    'Funcion para los botones 'Ver' y 'Eliminar de Radiografia'
    Private Sub radiografiasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        'Boton Ver
        If e.ColumnIndex = radiografiasDataGridView.Columns("btnVer").Index AndAlso e.RowIndex >= 0 Then
            Dim fileName As String = radiografiasDataGridView.Rows(e.RowIndex).Cells("Nombre").Value.ToString()
            Dim parentPath As String = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(My.Application.Info.DirectoryPath)))
            Dim folderPath As String = String.Concat(parentPath, "\Documentos\Radiografias")
            Dim filePath As String = Path.Combine(folderPath, fileName)

            ' Abre el archivo en el navegador Internet Explorer
            Try
                MessageBox.Show("Abriendo archivo.....")
                System.Diagnostics.Process.Start("IExplore.exe", filePath)
            Catch ex As Exception
                MessageBox.Show("Error al intentar abrir el archivo: " & ex.Message, "Error")
            End Try
        End If

        'Boton Eliminar
        If e.ColumnIndex = radiografiasDataGridView.Columns("btnEliminar").Index AndAlso e.RowIndex >= 0 Then
            Dim fileName As String = radiografiasDataGridView.Rows(e.RowIndex).Cells("Nombre").Value.ToString()
            Dim parentPath As String = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(My.Application.Info.DirectoryPath)))
            Dim folderPath As String = String.Concat(parentPath, "\Documentos\Radiografias")
            Dim filePath As String = Path.Combine(folderPath, fileName)
            Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este archivo?", "Eliminar archivo", MessageBoxButtons.YesNo)

            ' Si el usuario confirma la eliminación, eliminar el archivo
            If result = DialogResult.Yes Then
                Try
                    'System.IO.File.Delete(filePath)
                    FileSystem.DeleteFile(filePath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin)
                    MessageBox.Show("El archivo se ha eliminado correctamente.", "Eliminado")
                    radiografiasDataGridView.Rows.RemoveAt(e.RowIndex)
                    'File.Delete(filePath)

                Catch ex As Exception
                    MessageBox.Show("Error al eliminar el archivo: " & ex.Message, "Error")
                End Try
            End If
        End If
    End Sub

    'TOMOGRAFIAS
    Private Sub cargarTomografias()

        Dim btnVer As New DataGridViewButtonColumn
        btnVer.HeaderText = ""
        btnVer.Text = "Ver"
        btnVer.Name = "btnVer"
        btnVer.UseColumnTextForButtonValue = True

        Dim btnEliminar As New DataGridViewButtonColumn
        btnEliminar.HeaderText = ""
        btnEliminar.Text = "Eliminar"
        btnEliminar.Name = "btnEliminar"
        btnEliminar.UseColumnTextForButtonValue = True


        tomografiasDataGridView.Columns.AddRange(New DataGridViewColumn(3) _
                                    {
                                    New DataGridViewTextBoxColumn() With {.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, .HeaderText = "Nombre", .Name = "Nombre"},
                                     New DataGridViewTextBoxColumn() With {.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, .HeaderText = "Fecha de creación", .Name = "Fecha"},
                                     btnVer, btnEliminar})

        Dim parentPath As String = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(My.Application.Info.DirectoryPath)))
        Dim folderPath As String = String.Concat(parentPath, "\Documentos\Tomografias")

        If Directory.Exists(folderPath) Then
            'MessageBox.Show(String.Concat("Abriendo la carpeta... ", folderPath))
            Dim files() As String = Directory.GetFiles(folderPath)
            For Each filePath As String In files
                Dim fileName As String = Path.GetFileName(filePath)
                Dim creationDate As String = File.GetCreationTime(filePath).ToString()
                tomografiasDataGridView.Rows.Add({fileName, creationDate})
            Next
        Else
            MessageBox.Show("La carpeta especificada no existe.", folderPath)
        End If

    End Sub

    'Funcion para los botones 'Ver' y 'Eliminar de Radiografia'
    Private Sub tomografiasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        'Boton Ver
        If e.ColumnIndex = tomografiasDataGridView.Columns("btnVer").Index AndAlso e.RowIndex >= 0 Then
            Dim fileName As String = tomografiasDataGridView.Rows(e.RowIndex).Cells("Nombre").Value.ToString()
            Dim parentPath As String = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(My.Application.Info.DirectoryPath)))
            Dim folderPath As String = String.Concat(parentPath, "\Documentos\Tomografias")
            Dim filePath As String = Path.Combine(folderPath, fileName)

            ' Abre el archivo en el navegador Internet Explorer
            Try
                MessageBox.Show("Abriendo archivo.....")
                System.Diagnostics.Process.Start("IExplore.exe", filePath)
            Catch ex As Exception
                MessageBox.Show("Error al intentar abrir el archivo: " & ex.Message, "Error")
            End Try
        End If

        'Boton Eliminar
        If e.ColumnIndex = tomografiasDataGridView.Columns("btnEliminar").Index AndAlso e.RowIndex >= 0 Then
            Dim fileName As String = tomografiasDataGridView.Rows(e.RowIndex).Cells("Nombre").Value.ToString()
            Dim parentPath As String = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(My.Application.Info.DirectoryPath)))
            Dim folderPath As String = String.Concat(parentPath, "\Documentos\Tomografias")
            Dim filePath As String = Path.Combine(folderPath, fileName)
            Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este archivo?", "Eliminar archivo", MessageBoxButtons.YesNo)

            ' Si el usuario confirma la eliminación, eliminar el archivo
            If result = DialogResult.Yes Then
                Try
                    'System.IO.File.Delete(filePath)
                    FileSystem.DeleteFile(filePath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin)
                    MessageBox.Show("El archivo se ha eliminado correctamente.", "Eliminado")
                    tomografiasDataGridView.Rows.RemoveAt(e.RowIndex)
                    'File.Delete(filePath)

                Catch ex As Exception
                    MessageBox.Show("Error al eliminar el archivo: " & ex.Message, "Error")
                End Try
            End If
        End If
    End Sub
End Class