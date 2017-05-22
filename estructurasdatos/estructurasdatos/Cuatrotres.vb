Module Cuatrotres
    Sub main()
        Dim can_alumno, can_notas As Integer
        Dim notas, promedio, T_nota As Single
        Dim nombre As String
        can_alumno = L_Maximo("Ingrese la cantidad de alumnos 'MAX=40': ", 40)
        can_notas = L_Maximo("Ingrese la cantidad de notas por alumno 'Max=4': ", 4)
        Dim Nombres_Alum(can_alumno) As String
        Dim Notas_alum(can_notas) As UShort
        Dim M_Promedio(can_alumno) As Single
        For x = 0 To can_alumno - 1
            T_nota = 0
            Do
                Console.WriteLine("Ingrese nombre: ")
                nombre = Console.ReadLine()
            Loop Until ValidarNombre(nombre, Nombres_Alum)
            Nombres_Alum(x) = nombre
            For y = 0 To can_notas - 1
                notas = L_Maximo("Ingrese nota: ", 10)
                Notas_alum(y) = notas
                T_nota += notas
            Next
            promedio = T_nota / can_notas
            M_Promedio(x) = promedio
            Console.WriteLine("El alumno: '{0}' tiene promedio de: '{1}' y esta: '{2}'", Nombres_Alum(x), promedio, Aprobado(promedio))
        Next
        Mejor_Promedio(M_Promedio, Nombres_Alum)
        Console.ReadKey()
    End Sub
    Private Function ValidarNombre(name As String, array_Alum() As String)
        For Each index As String In array_Alum
            If name = index Then
                Console.WriteLine("Nombre existente")
                Return False
            End If
        Next
        Return True
    End Function
    Private Function Aprobado(promedio As Single) As String
        Return If(promedio >= 6, "Aprobado", "Desaprobado")
    End Function
    Private Sub Mejor_Promedio(array_promedio() As Single, Nombre_alum() As String)
        Dim max As Single = 1
        Dim valor As UShort
        For i = 0 To array_promedio.Length - 1
            If max <= array_promedio(i) Then
                max = array_promedio(i)
                valor = i
            End If
        Next
        Console.WriteLine("El promedio mas alto es: '{0}' y le pertenece a: '{1}'", max, Nombre_alum(valor))
    End Sub
    Private Function L_Maximo(mensaje As String, limite As UShort) As UShort
        Dim valor As Short
        Dim fallo As Boolean
        Do
            Console.WriteLine(mensaje)
            valor = Console.ReadLine()
            If valor > limite Or valor <= 0 Then
                Console.WriteLine("Fuera de Rango")
                fallo = True
            Else
                fallo = False
            End If
        Loop Until fallo = False
        Return valor
    End Function
End Module
