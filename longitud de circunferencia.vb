Imports System

Module Program
	Sub Main()
		Console.Title = "Rony Rodriguez"
		Dim radio, pi, Longitud As Decimal
		pi = 3.1416
		Console.WriteLine("Ingrese el radio del dado: ")
		radio = Console.ReadLine()

		Console.WriteLine("La longitud del radio es: " & Calcular(pi, radio))

	End Sub
	Function Calcular(pi, radio) As Decimal
		Return (pi * (radio * radio))
	End Function
End Module
