Module Cuatrouno
    Sub Main()
        Dim numero, contador As UShort
        Dim media, numero2(4) As Single
        For contador = 0 To 4
            ''Console.WriteLine("Ingrese un numero: ")
            numero2(contador) = Console.ReadLine
            media = media + numero2(contador)
        Next
        media = media / 5
        numero = 1
        For contador = 0 To 4
            Console.WriteLine("Numero: {0} = {1}, Desviacion: {2}", numero, numero2(contador), numero2(contador) - media)
            numero += 1
        Next
        Console.ReadKey()
    End Sub
End Module
