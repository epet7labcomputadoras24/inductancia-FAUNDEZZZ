Imports System
Module Program
    Dim frecuencia As Double
    Dim inductancia As Double
    Dim XL As Double
    Dim PI = 3.1416
    Sub Main(args As String())
        Console.WriteLine("INGRESE VALOR DE FRECUENCIA")
        frecuencia = Console.ReadLine()
        Console.WriteLine("INGRESE VALOR DE INDUCTANCIA")
        inductancia = Console.ReadLine()
        XL = 2 * PI * frecuencia * inductancia
        Console.WriteLine("valor de XL" & XL)


    End Sub
End Module

Imports Microsoft.VisualBasic

Public Class Class1

End Class
