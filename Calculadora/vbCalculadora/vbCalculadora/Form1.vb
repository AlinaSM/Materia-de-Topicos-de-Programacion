Public Class Form1

    Private ultimaEntrada As Entrada
    Private puntoDecimal As Boolean
    Private operador As Char
    Private numOperandos As Byte
    Private operando1 As Double
    Private operando2 As Double

    Private Sub btDigito_Click(sender As Object, e As EventArgs) Handles bt9.Click, bt8.Click, bt7.Click, bt6.Click, bt5.Click, bt4.Click, bt3.Click, bt2.Click, bt1.Click, bt0.Click

        Dim objButton As Button = CType(sender, Button)

        If (ultimaEntrada <> Entrada.DIGITO) Then
            If (objButton.Text = "0") Then Return
            etPantalla.Text = ""
            ultimaEntrada = Entrada.DIGITO
            puntoDecimal = False
        End If
        etPantalla.Text += objButton.Text

    End Sub



    Private Enum Entrada
        NINGUNA
        DIGITO
        OPERADOR
        CE
    End Enum



    Private Sub btPuntoDecimal_Click(sender As Object, e As EventArgs) Handles btPuntoDecimal.Click
        If (ultimaEntrada <> Entrada.DIGITO) Then
            etPantalla.Text = "0."
            ultimaEntrada = Entrada.DIGITO
        ElseIf (puntoDecimal = False) Then
            etPantalla.Text = etPantalla.Text + "."
        End If
        puntoDecimal = True
    End Sub



    Private Sub btOperaciones_Click(sender As Object, e As EventArgs) Handles MyBase.Click, btPor.Click, btMenos.Click, btMas.Click, btIgual.Click, btDividir.Click

        'Obtener el id del boton que genero el evento
        Dim objButton As Button = CType(sender, Button)

        'Obtener el texto del boton pulsado
        Dim textoBoton As String = objButton.Text

        If ((numOperandos = 0) And (textoBoton(0) = " "c)) Then
            ultimaEntrada = Entrada.DIGITO
        End If


        ' operador = textoBoton(0)
        If (ultimaEntrada = Entrada.DIGITO) Then
            numOperandos += 1
        End If

        If (numOperandos = 1) Then
            operando1 = Double.Parse(etPantalla.Text)
        ElseIf (numOperandos = 2) Then
            operando2 = Double.Parse(etPantalla.Text)
            Select Case (operador)
                Case "+"c : operando1 += operando2
                Case "-"c : operando1 -= operando2
                Case "x"c : operando1 *= operando2
                Case "/"c : operando1 /= operando2
                Case "="c : operando1 = operando2
            End Select

            'Visualizar resultado
            etPantalla.Text = operando1.ToString()
            numOperandos = 1
        End If
        operador = textoBoton(0) 'Carácter de la posicion 0
        ultimaEntrada = Entrada.OPERADOR
    End Sub



    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ultimaEntrada = Entrada.NINGUNA
        puntoDecimal = False
        operador = Convert.ToChar(0)
        numOperandos = 0
        operando1 = 0
        operando2 = 0

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub btTantoPorCiento_Click(sender As Object, e As EventArgs) Handles btTantoPorCiento.Click
        Dim resultado As Double

        If (ultimaEntrada = Entrada.DIGITO) Then
            resultado = operando1 * Double.Parse(etPantalla.Text) / 100
            'Visualizar resultado
            etPantalla.Text = resultado.ToString
            'simular que se ha hecho click "="
            btIgual.PerformClick()
            'enfocar la tecla %
            btTantoPorCiento.Focus()

        End If
    End Sub


    Private Sub btIniciar_Click(sender As Object, e As EventArgs) Handles btIniciar.Click
        etPantalla.Text = "0."
        ultimaEntrada = Entrada.NINGUNA
        puntoDecimal = False
        operador = Convert.ToChar(0)
        numOperandos = 0
        operando1 = 0
        operando2 = 0
    End Sub


    Private Sub btBorrarEntrada_Click(sender As Object, e As EventArgs) Handles btBorrarEntrada.Click
        etPantalla.Text = "0."
        ultimaEntrada = Entrada.CE
        puntoDecimal = False
    End Sub


End Class
