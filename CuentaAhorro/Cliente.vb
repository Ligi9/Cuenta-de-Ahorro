Public Class Cliente
    Protected nombres As String
    Protected numIdentificacion As String
    Protected direccion As String
    Protected telefono As String

    Public Sub New(nom As String, nId As String, dire As String, tel As String)
        nombres = nom
        numIdentificacion = nId
        direccion = dire
        telefono = tel
    End Sub

    Public Sub New()

    End Sub

    Public Property NombreCliente() As String
        Get
            Return nombres
        End Get
        Set(ByVal value As String)
            nombres = value
        End Set
    End Property

    Public Property NumIdCliente() As String
        Get
            Return numIdentificacion
        End Get
        Set(ByVal value As String)
            numIdentificacion = value
        End Set
    End Property

    Public Property DireccionCliente() As String
        Get
            Return direccion
        End Get
        Set(ByVal value As String)
            direccion = value
        End Set
    End Property

    Public Property TelefonoCliente() As String
        Get
            Return telefono
        End Get
        Set(ByVal value As String)
            telefono = value
        End Set
    End Property

End Class
