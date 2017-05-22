Module Cuatrodos
    Sub main()
        Dim codigo = New Byte() {1, 2, 3}, nombre = New String() {"Mesa", "Silla", "Mantel"}
        Dim precio = New Single() {600, 250, 150}
        Dim opcion, cantidad, total As UShort
        While True
            Console.WriteLine("Ingrese codigo(1 a 3): ")
            opcion = Console.ReadLine()
            If opcion = 0 Then
                Exit While
            End If
            opcion = opcion - 1
            Console.WriteLine("Descripcion: {0}, Precio: ${1}", nombre(opcion), precio(opcion))
            Console.WriteLine("Ingrese cantidad: ")
            cantidad = Console.ReadLine()
            cantidad = cantidad * precio(opcion)
            total += cantidad
            Console.WriteLine("Total de este producto: ${0} ", cantidad)
            Console.WriteLine("total general: ${0}", total)
        End While
    End Sub
End Module