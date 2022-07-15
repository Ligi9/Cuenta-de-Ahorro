Public Class Form1

    Private banco As New Banco(1, "XYZ")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = banco.Nombre_Banco

    End Sub

    Private Sub BtnIngresarD_Click(sender As Object, e As EventArgs) Handles BtnIngresarD.Click
        Try
            Dim numeroCuenta As Integer = Integer.Parse(InputBox("Ingrese el número de cuenta", "Ingresa Dinero", "", 500, 200))

            Dim valorIngresar As Integer = Double.Parse(InputBox("Ingrese el valor a Ingresar", "Ingresa Dinero", "", 500, 200))

            banco.ingresarDineroCuenta(numeroCuenta, valorIngresar)

        Catch ex As Exception
            MsgBox("Ha ocurrido un error, se ha ingresado un valor incorrecto")
        End Try

    End Sub

    Public Sub limpiarCajas()

        TxtNombres.Clear()
        TxtNumIdent.Clear()
        TxtDireccion.Clear()
        TxtTelefono.Clear()
        TextSaldo.Clear()
        ListBox

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnSaldoD.Click
        Try
            Dim numeroCuenta As Integer = Integer.Parse(InputBox("Ingrese el número de cuenta", "Ver Saldo", "", 500, 200))
            MsgBox("Saldo Disponible $" & banco.getSaldoCuenta(numeroCuenta))
        Catch ex As Exception
            MsgBox("Ha ocurrido un error, se ha ingresado un valor incorrecto")
        End Try
    End Sub

    Private Sub BtnCrearCuenta_Click(sender As Object, e As EventArgs) Handles BtnCrearCuenta.Click
        If TxtNombres.Text <> "" And TxtNumIdent.Text <> "" And TxtDireccion.Text <> "" And TxtTelefono.Text <> "" And TextSaldo.Text <> "" Then

            Dim cte As New Cliente(TxtNombres.Text, TxtNumIdent.Text, TxtDireccion.Text, TxtTelefono.Text)

            Dim saldoInicial As Double = Double.Parse(TextSaldo.Text)

            banco.crearCuentaAhorro(cte, saldoInicial)

            limpiarCajas()

        Else
            MsgBox("No se pudo crear la cuenta de ahorros, porque faltaron datos en el formulario")
        End If

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        limpiarCajas()

    End Sub


    Private Sub BtnRetirarD_Click(sender As Object, e As EventArgs) Handles BtnRetirarD.Click

        Try
            Dim numeroCuenta As Integer = Integer.Parse(InputBox("Ingrese el número de cuenta", "Retira Dinero", "", 500, 200))

            Dim valorRetirar As Integer = Double.Parse(InputBox("Ingrese el valor a Retirar", "Retira Dinero", "", 500, 200))

            banco.retirarDineroCuenta(numeroCuenta, valorRetirar)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error, se ha ingresado un valor incorrecto")
        End Try

    End Sub

    Private Sub BtnDetalleTransaccion_Click(sender As Object, e As EventArgs) Handles BtnDetalleTransaccion.Click

        Try
            Dim numeroCuenta As Integer = Integer.Parse(InputBox("Ingrese el número de cuenta", "Ver Historial", "", 500, 200))

            Dim ingresosCuenta As List(Of String) = banco.getCuentaAhorro(numeroCuenta).ListaHistorialIngresos

            For i = 0 To ingresosCuenta.Count - 1 Step 1

                LiIngresos.Items.Add(ingresosCuenta.Item(i))
            Next

            Dim retirosCuenta As List(Of String) = banco.getCuentaAhorro(numeroCuenta).ListaHistorialRetiros

            For i = 0 To retirosCuenta.Count - 1 Step 1

                LiRetiros.Items.Add(retirosCuenta.Item(i))
            Next
        Catch ex As Exception
            MsgBox("Ha ocurrido un error, se ha ingresado un valor incorrecto")
        End Try

    End Sub
End Class
