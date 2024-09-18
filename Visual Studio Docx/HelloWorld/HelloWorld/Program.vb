Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Console.WriteLine("What is your name?")
        Dim username = Console.ReadLine()
        Console.WriteLine("Hello " + username + "!")

        Dim now = Date.Now
        Dim dayofYear = now.DayOfYear
        Console.Write("Day of Year: ")
        Console.WriteLine(dayofYear)

    End Sub
End Module
