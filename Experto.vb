Public Class Experto
    Dim c As New codigo2
    Dim nGanador As Integer = -1
    Dim nTablero(4, 4) As Integer
    Private Sub Experto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c.empezarPartida()
        nTablero = c.getTablero
    End Sub
    Private Sub checkGanador()
        Dim ub(2) As Integer
        ub = c.getUltimoBoton
        If ub(0) = 0 And ub(1) = 0 Then
            e1.Text = "O"
        End If
        If ub(0) = 0 And ub(1) = 1 Then
            e2.Text = "O"
        End If
        If ub(0) = 0 And ub(1) = 2 Then
            e3.Text = "O"
        End If
        If ub(0) = 0 And ub(1) = 3 Then
            e34.Text = "O"
        End If
        If ub(0) = 0 And ub(1) = 4 Then
            e344.Text = "O"
        End If
        If ub(0) = 1 And ub(1) = 0 Then
            e4.Text = "O"
        End If
        If ub(0) = 1 And ub(1) = 1 Then
            e5.Text = "O"
        End If
        If ub(0) = 1 And ub(1) = 2 Then
            e6.Text = "O"
        End If
        If ub(0) = 1 And ub(1) = 3 Then
            e64.Text = "O"
        End If
        If ub(0) = 1 And ub(1) = 4 Then
            e644.Text = "O"
        End If
        If ub(0) = 2 And ub(1) = 0 Then
            e7.Text = "O"
        End If
        If ub(0) = 2 And ub(1) = 1 Then
            e8.Text = "O"
        End If
        If ub(0) = 2 And ub(1) = 2 Then
            e9.Text = "O"
        End If
        If ub(0) = 2 And ub(1) = 3 Then
            e94.Text = "O"
        End If
        If ub(0) = 2 And ub(1) = 4 Then
            e944.Text = "O"
        End If
        If ub(0) = 3 And ub(1) = 0 Then
            e10.Text = "O"
        End If
        If ub(0) = 3 And ub(1) = 1 Then
            e11.Text = "O"
        End If
        If ub(0) = 3 And ub(1) = 2 Then
            e12.Text = "O"
        End If
        If ub(0) = 3 And ub(1) = 3 Then
            e124.Text = "O"
        End If
        If ub(0) = 3 And ub(1) = 4 Then
            e1244.Text = "O"
        End If
        If ub(0) = 4 And ub(1) = 0 Then
            e13.Text = "O"
        End If
        If ub(0) = 4 And ub(1) = 1 Then
            e14.Text = "O"
        End If
        If ub(0) = 4 And ub(1) = 2 Then
            e15.Text = "O"
        End If
        If ub(0) = 4 And ub(1) = 3 Then
            e154.Text = "O"
        End If
        If ub(0) = 4 And ub(1) = 4 Then
            e1544.Text = "O"
        End If
        If nGanador = 0 Then
            mensaje.Text = "Felicidades has ganado"
        End If
        If nGanador = 1 Then
            mensaje.Text = "Que lo siento has perdido :("

        End If
        If nGanador = -1 Then
            If c.tableroCompleto() = True Then
                mensaje.Text = "Empate"
            End If
        End If
    End Sub


    Private Sub e1_Click(sender As Object, e As EventArgs) Handles e1.Click
        If nTablero(0, 0) = -1 Then
            e1.Text = "X"
            c.pulsaBoton(0, 0)
            nGanador = c.ganarPartida()
            Call checkGanador()
            e1.ForeColor = Color.Red
        End If
    End Sub

    Private Sub e2_Click(sender As Object, e As EventArgs) Handles e2.Click
        If nTablero(0, 1) = -1 Then
            e2.Text = "X"
            c.pulsaBoton(0, 1)
            nGanador = c.ganarPartida()
            Call checkGanador()
            e1.ForeColor = Color.Red
        End If
    End Sub

    Private Sub e3_Click(sender As Object, e As EventArgs) Handles e3.Click
        If nTablero(0, 2) = -1 Then
            e3.Text = "X"
            c.pulsaBoton(0, 2)
            nGanador = c.ganarPartida()
            Call checkGanador()
            e3.ForeColor = Color.Red
        End If
    End Sub
    Private Sub e34_Click(sender As Object, e As EventArgs) Handles e34.Click
        If nTablero(0, 3) = -1 Then
            e34.Text = "X"
            c.pulsaBoton(0, 3)
            nGanador = c.ganarPartida()
            Call checkGanador()
            e34.ForeColor = Color.Red
        End If
    End Sub
    Private Sub e344_Click(sender As Object, e As EventArgs) Handles e344.Click
        If nTablero(0, 4) = -1 Then
            e344.Text = "X"
            c.pulsaBoton(0, 4)
            nGanador = c.ganarPartida()
            Call checkGanador()
            e344.ForeColor = Color.Red
        End If
    End Sub

    Private Sub e4_Click(sender As Object, e As EventArgs) Handles e4.Click
        If nTablero(1, 0) = -1 Then
            e4.Text = "X"
            c.pulsaBoton(1, 0)
            nGanador = c.ganarPartida()
            Call checkGanador()
            e4.ForeColor = Color.Red
        End If
    End Sub



    Private Sub e5_Click(sender As Object, e As EventArgs) Handles e5.Click
        If nTablero(1, 1) = -1 Then
            e5.Text = "X"
            c.pulsaBoton(1, 1)
            nGanador = c.ganarPartida()
            Call checkGanador()
            e5.ForeColor = Color.Red
        End If
    End Sub

    Private Sub e6_Click(sender As Object, e As EventArgs) Handles e6.Click
        If nTablero(1, 2) = -1 Then
            e6.Text = "X"
            c.pulsaBoton(1, 2)
            nGanador = c.ganarPartida()
            Call checkGanador()
            e6.ForeColor = Color.Red
        End If
    End Sub
    Private Sub e64_Click(sender As Object, e As EventArgs) Handles e64.Click
        If nTablero(1, 3) = -1 Then
            e64.Text = "X"
            c.pulsaBoton(1, 3)
            nGanador = c.ganarPartida()
            Call checkGanador()
            e64.ForeColor = Color.Red
        End If
    End Sub
    Private Sub e644_Click(sender As Object, e As EventArgs) Handles e644.Click
        If nTablero(1, 4) = -1 Then
            e644.Text = "X"
            c.pulsaBoton(1, 4)
            nGanador = c.ganarPartida()
            Call checkGanador()
            e644.ForeColor = Color.Red
        End If
    End Sub

    Private Sub e7_Click(sender As Object, e As EventArgs) Handles e7.Click
        If nTablero(2, 0) = -1 Then
            e7.Text = "X"
            c.pulsaBoton(2, 0)
            nGanador = c.ganarPartida()
            Call checkGanador()
            e7.ForeColor = Color.Red
        End If
    End Sub

    Private Sub e8_Click(sender As Object, e As EventArgs) Handles e8.Click
        If nTablero(2, 1) = -1 Then
            e8.Text = "X"
            c.pulsaBoton(2, 1)
            nGanador = c.ganarPartida()
            Call checkGanador()
            e8.ForeColor = Color.Red
        End If
    End Sub

    Private Sub e9_Click(sender As Object, e As EventArgs) Handles e9.Click
        If nTablero(2, 2) = -1 Then
            e9.Text = "X"
            c.pulsaBoton(2, 2)
            nGanador = c.ganarPartida()
            Call checkGanador()
            e9.ForeColor = Color.Red
        End If
    End Sub
    Private Sub e94_Click(sender As Object, e As EventArgs) Handles e94.Click
        If nTablero(2, 3) = -1 Then
            e94.Text = "X"
            c.pulsaBoton(2, 3)
            nGanador = c.ganarPartida()
            Call checkGanador()
            e94.ForeColor = Color.Red
        End If
    End Sub
    Private Sub e944_Click(sender As Object, e As EventArgs) Handles e944.Click
        If nTablero(2, 4) = -1 Then
            e944.Text = "X"
            c.pulsaBoton(2, 4)
            nGanador = c.ganarPartida()
            Call checkGanador()
            e944.ForeColor = Color.Red
        End If
    End Sub
    Private Sub b10_Click(sender As Object, e As EventArgs) Handles e10.Click
        If nTablero(3, 0) = -1 Then
            e10.Text = "X"
            c.pulsaBoton(3, 0)
            nGanador = c.ganarPartida()
            Call checkGanador()
            e10.ForeColor = Color.Red
        End If
    End Sub
    Private Sub e11_Click(sender As Object, e As EventArgs) Handles e11.Click
        If nTablero(3, 1) = -1 Then
            e11.Text = "X"
            c.pulsaBoton(3, 1)
            nGanador = c.ganarPartida()
            Call checkGanador()
            e11.ForeColor = Color.Red
        End If
    End Sub
    Private Sub e12_Click(sender As Object, e As EventArgs) Handles e12.Click
        If nTablero(3, 2) = -1 Then
            e12.Text = "X"
            c.pulsaBoton(3, 2)
            nGanador = c.ganarPartida()
            Call checkGanador()
            e12.ForeColor = Color.Red
        End If
    End Sub
    Private Sub e124_Click(sender As Object, e As EventArgs) Handles e124.Click
        If nTablero(3, 3) = -1 Then
            e124.Text = "X"
            c.pulsaBoton(3, 3)
            nGanador = c.ganarPartida()
            Call checkGanador()
            e124.ForeColor = Color.Red
        End If
    End Sub
    Private Sub e1244_Click(sender As Object, e As EventArgs) Handles e1244.Click
        If nTablero(3, 4) = -1 Then
            e1244.Text = "X"
            c.pulsaBoton(3, 4)
            nGanador = c.ganarPartida()
            Call checkGanador()
            e1244.ForeColor = Color.Red
        End If
    End Sub

    Private Sub e13_Click(sender As Object, e As EventArgs) Handles e13.Click
        If nTablero(4, 0) = -1 Then
            e13.Text = "X"
            c.pulsaBoton(4, 0)
            nGanador = c.ganarPartida()
            Call checkGanador()
            e13.ForeColor = Color.Red
        End If
    End Sub

    Private Sub e14_Click(sender As Object, e As EventArgs) Handles e14.Click
        If nTablero(4, 1) = -1 Then
            e14.Text = "X"
            c.pulsaBoton(4, 1)
            nGanador = c.ganarPartida()
            Call checkGanador()
            e14.ForeColor = Color.Red
        End If
    End Sub

    Private Sub e15_Click(sender As Object, e As EventArgs) Handles e15.Click
        If nTablero(4, 2) = -1 Then
            e15.Text = "X"
            c.pulsaBoton(4, 2)
            nGanador = c.ganarPartida()
            Call checkGanador()
            e15.ForeColor = Color.Red
        End If
    End Sub

    Private Sub e154_Click(sender As Object, e As EventArgs) Handles e154.Click
        If nTablero(4, 3) = -1 Then
            e154.Text = "X"
            c.pulsaBoton(4, 3)
            nGanador = c.ganarPartida()
            Call checkGanador()
            e154.ForeColor = Color.Red
        End If
    End Sub

    Private Sub e1544_Click(sender As Object, e As EventArgs) Handles e1544.Click
        If nTablero(4, 4) = -1 Then
            e1544.Text = "X"
            c.pulsaBoton(4, 4)
            nGanador = c.ganarPartida()
            Call checkGanador()
            e1544.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        c = New codigo2
        c.empezarPartida()
        nTablero = c.getTablero
        nGanador = -1
        'limpio los text de los botones los dejo vacios
        e1.Text = ""
        e2.Text = ""
        e3.Text = ""
        e34.Text = ""
        e4.Text = ""
        e5.Text = ""
        e6.Text = ""
        e64.Text = ""
        e7.Text = ""
        e8.Text = ""
        e9.Text = ""
        e94.Text = ""
        e10.Text = ""
        e11.Text = ""
        e12.Text = ""
        e124.Text = ""
        Label1.Text = ""
        'limpio los colores de cada boton, los regreso a negro
        e1.ForeColor = Color.Black
        e2.ForeColor = Color.Black
        e3.ForeColor = Color.Black
        e34.ForeColor = Color.Black
        e4.ForeColor = Color.Black
        e5.ForeColor = Color.Black
        e6.ForeColor = Color.Black
        e64.ForeColor = Color.Black
        e7.ForeColor = Color.Black
        e8.ForeColor = Color.Black
        e9.ForeColor = Color.Black
        e94.ForeColor = Color.Black
        e10.ForeColor = Color.Black
        e11.ForeColor = Color.Black
        e12.ForeColor = Color.Black
        e124.ForeColor = Color.Black
    End Sub

End Class