Imports System

Module Program
	Sub Main()
		Dim b, a As Decimal

		Console.WriteLine("Ingrese la base del triangulo: ")
		b = Console.ReadLine()

		Console.WriteLine("Ingrese la altura del triangulo: ")
		a = Console.ReadLine()
		area(b, a)
	End Sub

	Sub area(base As Decimal, altura As Decimal)

		Dim r As Decimal

		r = base * altura / 2
		Console.WriteLine("La base del triangulo es: " & r)

	End Sub

End Module
