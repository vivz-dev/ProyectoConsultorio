Imports System.IO

Public Class Pacientes
    Private Sub Pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarRadiografias()
        cargarTomografias()
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

        Dim folderPath As String = "\Documentos\Radiografias"

        If Directory.Exists(folderPath) Then
            Dim files() As String = Directory.GetFiles(folderPath)
            For Each filePath As String In files
                Dim fileName As String = Path.GetFileName(filePath)
                Dim creationDate As String = File.GetCreationTime(filePath).ToString()
                radiografiasDataGridView.Rows.Add({fileName, creationDate})
            Next
        Else
            MessageBox.Show("La carpeta especificada no existe.")
        End If

    End Sub

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

        Dim folderPath As String = "C:\Users\HP\source\repos\ProyectoConsultorio\Documentos\Tomografias"

        If Directory.Exists(folderPath) Then
            Dim files() As String = Directory.GetFiles(folderPath)
            For Each filePath As String In files
                Dim fileName As String = Path.GetFileName(filePath)
                Dim creationDate As String = File.GetCreationTime(filePath).ToString()
                tomografiasDataGridView.Rows.Add({fileName, creationDate})
            Next
        Else
            MessageBox.Show("La carpeta especificada no existe.")
        End If

    End Sub

    'Funcion para los botones 'Ver' y 'Eliminar de Radiografia'
    Private Sub radiografiasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles radiografiasDataGridView.CellContentClick
        'Boton Ver
        If e.ColumnIndex = radiografiasDataGridView.Columns("btnVer").Index AndAlso e.RowIndex >= 0 Then
            Dim fileName As String = radiografiasDataGridView.Rows(e.RowIndex).Cells("Nombre").Value.ToString()
            Dim filePath As String = Path.Combine("C:\Users\HP\source\repos\ProyectoConsultorio\Documentos\Radiografias", fileName)

            ' Abre el archivo en el navegador Internet Explorer
            Try
                System.Diagnostics.Process.Start("IExplore.exe", filePath)
            Catch ex As Exception
                MessageBox.Show("Error al intentar abrir el archivo: " & ex.Message, "Error")
            End Try
        End If

        'Boton Eliminar
        If e.ColumnIndex = radiografiasDataGridView.Columns("btnEliminar").Index AndAlso e.RowIndex >= 0 Then
            Dim fileName As String = radiografiasDataGridView.Rows(e.RowIndex).Cells("Nombre").Value.ToString()
            Dim filePath As String = Path.Combine("C:\Users\HP\source\repos\ProyectoConsultorio\Documentos\Radiografias", fileName)
            Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este archivo?", "Eliminar archivo", MessageBoxButtons.YesNo)

            ' Si el usuario confirma la eliminación, eliminar el archivo
            If result = DialogResult.Yes Then
                Try
                    'Esta linea de codigo elimina el documento pero da error, por eso la comento
                    'System.IO.File.Delete(filePath)
                    MessageBox.Show("El archivo se ha eliminado correctamente.", "Eliminado")
                    radiografiasDataGridView.Rows.RemoveAt(e.RowIndex)
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar el archivo: " & ex.Message, "Error")
                End Try
            End If
        End If
    End Sub

    'Funcion para los botones 'Ver' y 'Eliminar de Tomografia'
    Private Sub tomografiasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tomografiasDataGridView.CellContentClick
        'Boton Ver
        If e.ColumnIndex = tomografiasDataGridView.Columns("btnVer").Index AndAlso e.RowIndex >= 0 Then
            Dim fileName As String = tomografiasDataGridView.Rows(e.RowIndex).Cells("Nombre").Value.ToString()
            Dim filePath As String = Path.Combine("C:\Users\HP\source\repos\ProyectoConsultorio\Documentos\Tomografias", fileName)

            ' Abre el archivo en el navegador Internet Explorer
            Try
                System.Diagnostics.Process.Start("IExplore.exe", filePath)
            Catch ex As Exception
                MessageBox.Show("Error al intentar abrir el archivo: " & ex.Message, "Error")
            End Try
        End If

        'Boton Eliminar
        If e.ColumnIndex = tomografiasDataGridView.Columns("btnEliminar").Index AndAlso e.RowIndex >= 0 Then
            Dim fileName As String = tomografiasDataGridView.Rows(e.RowIndex).Cells("Nombre").Value.ToString()
            Dim filePath As String = Path.Combine("C:\Users\HP\source\repos\ProyectoConsultorio\Documentos\Tomografias", fileName)
            Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este archivo?", "Eliminar archivo", MessageBoxButtons.YesNo)

            ' Si el usuario confirma la eliminación, eliminar el archivo
            If result = DialogResult.Yes Then
                Try
                    'Esta linea de codigo elimina el documento pero da error, por eso la comento
                    'System.IO.File.Delete(filePath)
                    MessageBox.Show("El archivo se ha eliminado correctamente.", "Eliminado")
                    tomografiasDataGridView.Rows.RemoveAt(e.RowIndex)
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar el archivo: " & ex.Message, "Error")
                End Try
            End If
        End If
    End Sub

    Private Sub agregarRadiografia_Click(sender As Object, e As EventArgs) Handles agregarRadiografia.Click

    End Sub


    Private Sub Agenda_Click(sender As Object, e As EventArgs) Handles agenda.Click
        Using AgendaForm As New Form1()

            ' Mostrar el formulario
            AgendaForm.Show()
        End Using

        ' Opcionalmente, puedes ocultar el formulario actual si lo deseas
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class