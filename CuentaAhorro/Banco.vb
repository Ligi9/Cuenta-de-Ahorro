Public Class Banco
    Private numSucursal As Integer
    Private nombreBanco As String
    Private cuentasAhorros As List(Of CuentaAhorro)

    Public Sub New(numS As Integer, nomBanco As String)

        numSucursal = numS
        nombreBanco = nomBanco
        cuentasAhorros = New List(Of CuentaAhorro)

    End Sub

    Public ReadOnly Property NumeroSucursal As Integer
        Get
            Return numSucursal
        End Get
    End Property

    Public ReadOnly Property Nombre_Banco As String
        Get
            Return nombreBanco
        End Get
    End Property

    Public Sub crearCuentaAhorro(cte As Cliente, saldoInicial As Double)

        Dim existe As Boolean = False

        For i = 1 To cuentasAhorros.Count - 1 Step 1

            Dim clienteLista As Cliente = cuentasAhorros.Item(i).ClienteCuentaAhorros

            If clienteLista.NumIdCliente.Equals(cte.NumIdCliente) Then

                existe = True
                Exit For
            End If
        Next

        If existe = False Then

            Dim cuentaAhorros As New CuentaAhorro(cte, saldoInicial)

            cuentasAhorros.Add(cuentaAhorros)

            MsgBox("Cuenta de ahorros creada correctamente")

        End If

    End Sub

    Public Function getIndiceCuenta(numCuenta) As Integer

        Dim indice As Integer = -1

        'Busca el indice del numCuenta pasado por parámetro en el atributo lista de la clase Banco
        For i = 0 To cuentasAhorros.Count - 1 Step 1

            Dim cuentaLista As CuentaAhorro = cuentasAhorros.Item(i)

            If cuentaLista.NumCuentaAhorros = numCuenta Then

                indice = i
                Exit For
            End If
        Next

        Return indice

    End Function

    Public Function getCuentaAhorro(numCuenta As Integer) As CuentaAhorro

        Return cuentasAhorros.Item(getIndiceCuenta(numCuenta))
    End Function

    'Método que permite ingresar dinero a la cuenta de ahorros de un cliente teniendo en cuenta su número de cuenta
    Public Sub ingresarDineroCuenta(numCuenta As Integer, ingresar As Double)

        Dim indice As Integer = getIndiceCuenta(numCuenta)

        cuentasAhorros.Item(indice).ingresarDinero(ingresar)

    End Sub

    'Método que permite retirar dinero de la cuenta de ahorros de un cliente teniendo en cuenta su número de cuenta
    Public Sub retirarDineroCuenta(numCuenta As Integer, retirar As Double)

        Dim indice As Integer = getIndiceCuenta(numCuenta)

        cuentasAhorros.Item(indice).retirarDinero(retirar)

    End Sub

    'Método que permite obtener el saldo disponible de la cuenta de ahorros de un cliente teniendo en cuenta su número de cuenta
    Public Function getSaldoCuenta(numCuenta As Integer)

        Dim indice As Integer = getIndiceCuenta(numCuenta)

        Return cuentasAhorros.Item(indice).getSaldo()

    End Function


End Class
