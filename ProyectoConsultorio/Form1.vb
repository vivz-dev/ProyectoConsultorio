Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        radiografias2()
    End Sub

    Private Sub radiografias2()

        radiografiasDataGridView.Columns.AddRange(New DataGridViewColumn(3) _
                                    {New DataGridViewTextBoxColumn() With
                                     {.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, .HeaderText = "Nombre"},
                                     New DataGridViewTextBoxColumn() With
                                     {.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, .HeaderText = "Fecha de creación"},
                                     New DataGridViewButtonColumn() With
                                     {.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, .HeaderText = ""},
                                     New DataGridViewButtonColumn() With
                                     {.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, .HeaderText = ""}})

        Dim folderPath As String = "C:\Users\HP\source\repos\ProyectoConsultorio\Documentos\Radiografias"

        If Directory.Exists(folderPath) Then
            ' Borra cualquier elemento existente en el ListView
            'radiografiasListView.Items.Clear()

            ' Obtiene la lista de archivos en la carpeta
            Dim files() As String = Directory.GetFiles(folderPath)

            ' Itera a través de la lista de archivos y agrega sus nombres al ListView
            For Each filePath As String In files
                ' Agrega solo el nombre del archivo al ListView, no la ruta completa
                Dim fileName As String = Path.GetFileName(filePath)
                Dim creationDate As String = File.GetCreationTime(filePath).ToString()

                ' Agrega el nombre del archivo y los botones "Ver" y "Eliminar" al ListView
                radiografiasDataGridView.Rows.Add({fileName, creationDate, "Ver", "Eliminar"})

            Next
        Else
            MessageBox.Show("La carpeta especificada no existe.")
        End If

    End Sub

End Class
