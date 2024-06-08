Public Class Paciente
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Cedula As String
    Public Property FechaNacimiento As Date
    Public Property Sexo As String
    Public Property estadoCivil As String
    Public Property Ocupacion As String
    Public Property Telefono As String
    'Public Property patologicas As String
    'Public Property noPat As String
    'Public Property antFam As String
    'Public Property habitosTox As String
    'Public Property revision As String


    ' Constructor para inicializar el objeto Paciente
    Public Sub New(nombre As String, apellido As String, cedula As String, fechaNacimiento As Date, telefono As String)
        ', patologicas As String, noPat As String, antFam As String, habitosTox As String, revision As String
        ')
        Me.Nombre = nombre
        Me.Apellido = apellido
        Me.Cedula = cedula
        Me.FechaNacimiento = fechaNacimiento
        Me.Sexo = Sexo
        Me.estadoCivil = estadoCivil
        Me.Ocupacion = Ocupacion
        Me.Telefono = telefono
        '
        'Me.patologicas = patologicas
        'Me.noPat = noPat
        'Me.antFam = antFam
        'Me.habitosTox = habitosTox
        'Me.revision = revision
        '


    End Sub

    ' Constructor vacío
    Public Sub New()
    End Sub

    ' Método para obtener el texto del género
    Public Function ObtenerGeneroTexto() As String
        Select Case Sexo
            Case 1
                Return "Masculino"
            Case 2
                Return "Femenino"
            Case 3
                Return "Otro"
            Case Else
                Return "Desconocido"
        End Select
    End Function

    '1= hombre, 2= mujer, 3= otro

    '1=soltero, 2=casado, 3=divorciado, 4=unionLibre, 5=otro
    ' Método para obtener el estado civil
    Public Function ObtenerEstadoCivil() As String
        Select Case estadoCivil
            Case 1
                Return "Soltero"
            Case 2
                Return "Casado"
            Case 3
                Return "Divorciado"
            Case 4
                Return "Unión Libre"
            Case Else
                Return "Otro"
        End Select
    End Function

End Class
