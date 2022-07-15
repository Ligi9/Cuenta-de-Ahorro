Public Class CuentaAhorro
    Private NumCuenta As Integer
    Private Saldo As Double
    Private historialIngresos As List(Of String)
    Private historialRetiros As List(Of String)
    Private Cliente As Cliente
    Private Shared contadorNumCuenta As Integer = 1

    Public Sub New(cte As Cliente, saldoInicial As Double)
        NumCuenta = contadorNumCuenta
        Cliente = cte
        historialIngresos = New List(Of String)
        historialRetiros = New List(Of String)

        If saldoInicial > 0 Then
            Saldo = saldoInicial
        Else
            Saldo = 0
        End If

        contadorNumCuenta += 1
    End Sub

    Public ReadOnly Property NumCuentaAhorros() As Integer
        Get
            Return NumCuenta
        End Get
    End Property

    Public Property ClienteCuentaAhorros() As Cliente
        Get
            Return Cliente
        End Get
        Set(ByVal value As Cliente)
            Cliente = value
        End Set
    End Property

    Public ReadOnly Property ListaHistorialIngresos() As List(Of String)
        Get
            Return historialIngresos
        End Get
    End Property

    Public ReadOnly Property ListaHistorialRetiros() As List(Of String)
        Get
            Return historialRetiros
        End Get
    End Property

    Public Function getSaldo() As Double

        Return Saldo

    End Function

    Public Sub ingresarDinero(ingresar As Double)

        If ingresar > 0 Then

            Saldo += ingresar

            MsgBox("Los $" & ingresar & " COP fueron agregados al saldo de la cuenta correctamente")
            MsgBox("Su nuevo saldo es $" & Saldo)

            historialIngresos.Add("Valor Ingresado: $" & ingresar & " Fecha Transacción: " & Date.Now.ToString)

        Else
            MsgBox("No Puede ingresar un valor menor o igual a 0")

        End If
    End Sub

    Public Sub retirarDinero(retirar As Double)

        If retirar <= Saldo Then

            Saldo -= retirar
            MsgBox("Los $" & retirar & " COP fueron retirados de la cuenta correctamente")
            MsgBox("Su nuevo saldo es $" & Saldo)

            historialRetiros.Add("Valor Retirado: $" & retirar & " Fecha Transacción: " & Date.Now.ToString)

        Else
            MsgBox("No Puede retirar un valor menor o igual a 0")

        End If
    End Sub

End Class
