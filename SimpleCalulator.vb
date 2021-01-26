Module SimpleCalulator

    Sub Main()
        Dim userInput1 As String
        Dim userInput2 As String
        Dim userDecision As String
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim problem1 As Boolean = False
        Dim problem2 As Boolean = False
        Dim userSum As Integer
        Dim userProduct As Integer

        Console.WriteLine("Enter the first number.")
        Try
            userInput1 = Console.ReadLine()
            firstNumber = CInt(userInput1)

        Catch e As Exception
            problem1 = True
        End Try


        If problem1 = True Then
            Console.Clear()
            Console.WriteLine($"I need a number, you entered {userInput1}")
        Else
            Console.WriteLine("Enter the second number.")
            Try
                userInput2 = Console.ReadLine()
                secondNumber = CInt(userInput2)
            Catch e As Exception
                problem2 = True
            End Try
            If problem2 = True Then
                Console.Clear()
                Console.WriteLine($"I need a number, you entered {userInput2}")
            Else
                Console.WriteLine("Press 1 to add, or 2 to multiply")
                userSum = firstNumber + secondNumber
                userProduct = firstNumber * secondNumber
                userDecision = Console.ReadLine()
                If userDecision = 1 Then
                    Console.WriteLine($"{userSum}")
                ElseIf userDecision = 2 Then
                    Console.WriteLine($"{userProduct}")
                Else
                    Console.WriteLine("That is not a valid selection please try again")
                End If
            End If

        End If
        Console.Read()

    End Sub

End Module
