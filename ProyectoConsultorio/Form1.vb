Public Class Form1
    Private Sub Boton_Click(sender As Object, e As EventArgs) Handles Boton.Click
        ' Buscar la fila correspondiente al ID 3
        Dim fila As DataGridViewRow = DataGridView1.Rows _
            .Cast(Of DataGridViewRow)() _
            .FirstOrDefault(Function(r) Convert.ToInt32(r.Cells("IdDataGridViewTextBoxColumn").Value) = 3)

        ' Verificar si se encontró la fila
        If fila IsNot Nothing Then
            ' Obtener los valores de las celdas de la fila
            Dim nombre As String = fila.Cells("NombreDataGridViewTextBoxColumn").Value.ToString()
            Dim apellido As String = fila.Cells("ApellidoDataGridViewTextBoxColumn").Value.ToString()
            Dim direccion As String = fila.Cells("DireccionDataGridViewTextBoxColumn").Value.ToString()

            ' Mostrar la información en el Label
            Resultado.Text = $"Nombre: {nombre}, Apellido: {apellido}, Dirección: {direccion}"
        Else
            ' Si no se encontró la fila con el ID 3
            Resultado.Text = "No se encontró información para el ID 3"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar datos en el DataGridView
        Me.PersonasTableAdapter.Fill(Me.PACIENTESDataSet.Personas)
    End Sub

    Private Sub FIESTA_Click(sender As Object, e As EventArgs) Handles FIESTA.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
