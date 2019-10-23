Imports System

Module Program
    Sub Main(args As String())
        Dim in_age As Double
        Dim out_age As Double

        Console.Write("Enter the age of your cat: ")
        in_age = Console.ReadLine()

        If in_age >= 0.0 And in_age <= 1.0 Then
            out_age = 16.6364 * in_age
            Console.WriteLine($"Your cat is {out_age} years old.")
        ElseIf in_age > 1.0 And in_age < 2.0 Then
            out_age = 6.6364 * in_age + 10
            Console.WriteLine($"Your cat is {out_age} years old.")
        ElseIf in_age >= 2.0 Then
            out_age = 4.1364 * (in_age + 3.62634)
            Console.WriteLine($"Your cat is {out_age} years old.")
        End If

        Console.ReadLine()

    End Sub
End Module 