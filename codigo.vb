Public Class codigo
    Private nTablero(2, 2) As Integer
    Private nGanador As Integer = -1
    Private nContar As Integer = 0
    Private ub(2) As Integer

    Public Function getTablero()
        Return nTablero
    End Function

    Public Function empezarPartida()
        For x As Integer = 0 To 2
            For y As Integer = 0 To 2
                nTablero(x, y) = -1
            Next
        Next
        nGanador = -1
        Return ""
    End Function

    Public Function pulsaBoton(ByVal n, ByVal m)
        If n >= 0 And n < 3 And m < 3 And nTablero(n, m) = -1 Then
            If nGanador = -1 Then
                nTablero(n, m) = 0
                nGanador = ganarPartida()
                ponerFichaCompu()
            End If
        End If
    End Function

    Public Function ganarPartida()
        'verficando diagonal \
        If nTablero(0, 0) <> -1 And nTablero(0, 0) = nTablero(1, 1) And nTablero(0, 0) = nTablero(2, 2) Then
            'si retorna 0,0 gana usuario 
            'si retorna 0,1 gana la compucita
            Return nTablero(0, 0)
        End If
        'verficando diagonal /
        If nTablero(0, 2) <> -1 And nTablero(0, 2) = nTablero(1, 1) And nTablero(0, 2) = nTablero(2, 0) Then
            'si retorna 0,0 gana usuario 
            'si retorna 0,2 gana la compucita
            Return nTablero(0, 2)
        End If
        'verficando filas horizontales y las verticales
        For n As Integer = 0 To 2
            If nTablero(n, 0) <> -1 And nTablero(n, 0) = nTablero(n, 1) And nTablero(n, 0) = nTablero(n, 2) Then
                'si retorna 0,0 gana usuario 
                'si retorna n, 0 gana la compucita
                Return nTablero(n, 0)
            End If
            If nTablero(0, n) <> -1 And nTablero(0, n) = nTablero(1, n) And nTablero(0, n) = nTablero(2, n) Then
                'si retorna 0,0 gana usuario 
                'si retorna 0,n gana la compucita
                Return nTablero(0, n)
            End If
        Next
        Return -1

    End Function
    'retorna el numero del ganador 
    Public Function getGanador()
        Return nGanador
    End Function
    'retorna la ultima posicion que la computadora puso su ultima casilla
    Public Function getUltimoBoton()
        Return ub
    End Function

    'algoritmo minimax, se encarga de generar maximos y minimos, pone valores en casilllas aleatorias valores, 
    'luego que el jugador puso su ficha

    Public Function tableroCompleto()
        For x As Integer = 0 To 2
            For y As Integer = 0 To 2
                If nTablero(x, y) = -1 Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    Public Function finPartida()
        Return tableroCompleto() Or ganarPartida() <> -1
    End Function

    Public Function ponerFichaCompu()
        If Not finPartida() Then
            Dim f As Integer = 0
            Dim c As Integer = 0
            'numero minimo que la computadora pueda retornar
            Dim v As Integer = Integer.MinValue
            Dim aux As Integer

            For x As Integer = 0 To 2
                For y As Integer = 0 To 2
                    If nTablero(x, y) = -1 Then
                        nTablero(x, y) = 1
                        aux = min()
                        If aux > v Then
                            v = aux
                            f = x
                            c = y
                        End If
                        nTablero(x, y) = -1
                    End If
                Next
            Next
            nTablero(f, c) = 1
            ub(0) = f
            ub(1) = c
        End If
    End Function

    'recursividad del max
    Private Function max()
        If finPartida() Then
            If ganarPartida() <> -1 Then
                Return -1
            Else
                Return 0
            End If
        End If

        Dim v As Integer = Integer.MinValue
        Dim aux As Integer
        For x As Integer = 0 To 2
            For y As Integer = 0 To 2
                If nTablero(x, y) = -1 Then
                    nTablero(x, y) = 1
                    aux = min()
                    If aux > v Then
                        v = aux
                    End If
                    nTablero(x, y) = -1
                End If
            Next
        Next
            Return v

    End Function

    Public Function min()
        If finPartida() Then
            If ganarPartida() <> -1 Then
                Return 1
            Else
                Return 0
            End If
        End If

        Dim v As Integer = Integer.MaxValue
        Dim aux As Integer
        For x As Integer = 0 To 2
            For y As Integer = 0 To 2
                If nTablero(x, y) = -1 Then
                    nTablero(x, y) = 0
                    aux = min()
                    If aux < v Then
                        v = aux
                    End If
                    nTablero(x, y) = -1
                End If
            Next
        Next
        Return v
    End Function

End Class
