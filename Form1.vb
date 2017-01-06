Public Class Form1
    Dim c As New codigo
    Dim nGanador As Integer = -1
    Dim nTablero(3, 3) As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c.empezarPartida()
        nTablero = c.getTablero
    End Sub
    Private Sub checkGanador()
        Dim ub(2) As Integer
        ub = c.getUltimoBoton
        If ub(0) = 0 And ub(1) = 0 Then
            b1.Text = "O"
        End If
        If ub(0) = 0 And ub(1) = 1 Then
            b2.Text = "O"
        End If
        If ub(0) = 0 And ub(1) = 2 Then
            b3.Text = "O"
        End If
        If ub(0) = 0 And ub(1) = 3 Then
            b34.Text = "O"
        End If
        If ub(0) = 1 And ub(1) = 0 Then
            b4.Text = "O"
        End If
        If ub(0) = 1 And ub(1) = 1 Then
            b5.Text = "O"
        End If
        If ub(0) = 1 And ub(1) = 2 Then
            b6.Text = "O"
        End If
        If ub(0) = 1 And ub(1) = 3 Then
            b64.Text = "O"
        End If
        If ub(0) = 2 And ub(1) = 0 Then
            b7.Text = "O"
        End If
        If ub(0) = 2 And ub(1) = 1 Then
            b8.Text = "O"
        End If
        If ub(0) = 2 And ub(1) = 2 Then
            b9.Text = "O"
        End If
        If ub(0) = 2 And ub(1) = 3 Then
            b94.Text = "O"
        End If
        If ub(0) = 3 And ub(1) = 0 Then
            b10.Text = "O"
        End If
        If ub(0) = 3 And ub(1) = 1 Then
            b11.Text = "O"
        End If
        If ub(0) = 3 And ub(1) = 2 Then
            b12.Text = "O"
        End If
        If ub(0) = 3 And ub(1) = 3 Then
            b124.Text = "O"
        End If
        If nGanador = 0 Then
            ' Label1.Text = "Felicidades has ganado!!!"
            SplashScreen2.Show()
            Me.Hide()
        End If
        If nGanador = 1 Then
            Label1.Text = "Que lo siento has perdido :("

        End If
        If nGanador = -1 Then
            If c.tableroCompleto() = True Then
                Label1.Text = "Empate"
            End If
        End If
    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        If nTablero(0, 0) = -1 Then
            b1.Text = "X"
            c.pulsaBoton(0, 0)
            nGanador = c.ganarPartida()
            Call checkGanador()
            b1.ForeColor = Color.Red
        End If
    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        If nTablero(0, 1) = -1 Then
            b2.Text = "X"
            c.pulsaBoton(0, 1)
            nGanador = c.ganarPartida()
            Call checkGanador()
            b1.ForeColor = Color.Red
        End If
    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        If nTablero(0, 2) = -1 Then
            b3.Text = "X"
            c.pulsaBoton(0, 2)
            nGanador = c.ganarPartida()
            Call checkGanador()
            b3.ForeColor = Color.Red
        End If
    End Sub
    Private Sub b34_Click(sender As Object, e As EventArgs) Handles b34.Click
        If nTablero(0, 3) = -1 Then
            b34.Text = "X"
            c.pulsaBoton(0, 3)
            nGanador = c.ganarPartida()
            Call checkGanador()
            b34.ForeColor = Color.Red
        End If
    End Sub
    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        If nTablero(1, 0) = -1 Then
            b4.Text = "X"
            c.pulsaBoton(1, 0)
            nGanador = c.ganarPartida()
            Call checkGanador()
            b4.ForeColor = Color.Red
        End If
    End Sub



    Private Sub b5_Click(sender As Object, e As EventArgs) Handles b5.Click
        If nTablero(1, 1) = -1 Then
            b5.Text = "X"
            c.pulsaBoton(1, 1)
            nGanador = c.ganarPartida()
            Call checkGanador()
            b5.ForeColor = Color.Red
        End If
    End Sub

    Private Sub b6_Click(sender As Object, e As EventArgs) Handles b6.Click
        If nTablero(1, 2) = -1 Then
            b6.Text = "X"
            c.pulsaBoton(1, 2)
            nGanador = c.ganarPartida()
            Call checkGanador()
            b6.ForeColor = Color.Red
        End If
    End Sub
    Private Sub b64_Click(sender As Object, e As EventArgs) Handles b64.Click
        If nTablero(1, 3) = -1 Then
            b64.Text = "X"
            c.pulsaBoton(1, 3)
            nGanador = c.ganarPartida()
            Call checkGanador()
            b64.ForeColor = Color.Red
        End If
    End Sub

    Private Sub b7_Click(sender As Object, e As EventArgs) Handles b7.Click
        If nTablero(2, 0) = -1 Then
            b7.Text = "X"
            c.pulsaBoton(2, 0)
            nGanador = c.ganarPartida()
            Call checkGanador()
            b7.ForeColor = Color.Red
        End If
    End Sub

    Private Sub b8_Click(sender As Object, e As EventArgs) Handles b8.Click
        If nTablero(2, 1) = -1 Then
            b8.Text = "X"
            c.pulsaBoton(2, 1)
            nGanador = c.ganarPartida()
            Call checkGanador()
            b8.ForeColor = Color.Red
        End If
    End Sub

    Private Sub b9_Click(sender As Object, e As EventArgs) Handles b9.Click
        If nTablero(2, 2) = -1 Then
            b9.Text = "X"
            c.pulsaBoton(2, 2)
            nGanador = c.ganarPartida()
            Call checkGanador()
            b9.ForeColor = Color.Red
        End If
    End Sub
    Private Sub b94_Click(sender As Object, e As EventArgs) Handles b94.Click
        If nTablero(2, 3) = -1 Then
            b94.Text = "X"
            c.pulsaBoton(2, 3)
            nGanador = c.ganarPartida()
            Call checkGanador()
            b94.ForeColor = Color.Red
        End If
    End Sub
    Private Sub b10_Click(sender As Object, e As EventArgs) Handles b10.Click
        If nTablero(3, 0) = -1 Then
            b10.Text = "X"
            c.pulsaBoton(3, 0)
            nGanador = c.ganarPartida()
            Call checkGanador()
            b10.ForeColor = Color.Red
        End If
    End Sub
    Private Sub b11_Click(sender As Object, e As EventArgs) Handles b11.Click
        If nTablero(3, 1) = -1 Then
            b11.Text = "X"
            c.pulsaBoton(3, 1)
            nGanador = c.ganarPartida()
            Call checkGanador()
            b11.ForeColor = Color.Red
        End If
    End Sub
    Private Sub b12_Click(sender As Object, e As EventArgs) Handles b12.Click
        If nTablero(3, 2) = -1 Then
            b12.Text = "X"
            c.pulsaBoton(3, 2)
            nGanador = c.ganarPartida()
            Call checkGanador()
            b12.ForeColor = Color.Red
        End If
    End Sub
    Private Sub b124_Click(sender As Object, e As EventArgs) Handles b124.Click
        If nTablero(3, 3) = -1 Then
            b124.Text = "X"
            c.pulsaBoton(3, 3)
            nGanador = c.ganarPartida()
            Call checkGanador()
            b124.ForeColor = Color.Red
        End If
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        c = New codigo
        c.empezarPartida()
        nTablero = c.getTablero
        nGanador = -1
        'limpio los text de los botones los dejo vacios
        b1.Text = ""
        b2.Text = ""
        b3.Text = ""
        b34.Text = ""
        b4.Text = ""
        b5.Text = ""
        b6.Text = ""
        b64.Text = ""
        b7.Text = ""
        b8.Text = ""
        b9.Text = ""
        b94.Text = ""
        b10.Text = ""
        b11.Text = ""
        b12.Text = ""
        b124.Text = ""
        Label1.Text = ""
        'limpio los colores de cada boton, los regreso a negro
        b1.ForeColor = Color.Black
        b2.ForeColor = Color.Black
        b3.ForeColor = Color.Black
        b34.ForeColor = Color.Black
        b4.ForeColor = Color.Black
        b5.ForeColor = Color.Black
        b6.ForeColor = Color.Black
        b64.ForeColor = Color.Black
        b7.ForeColor = Color.Black
        b8.ForeColor = Color.Black
        b9.ForeColor = Color.Black
        b94.ForeColor = Color.Black
        b10.ForeColor = Color.Black
        b11.ForeColor = Color.Black
        b12.ForeColor = Color.Black
        b124.ForeColor = Color.Black
    End Sub


End Class
