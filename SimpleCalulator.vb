
'Sean Gingerich
'RCET0265
'Fall 2020
'Simple Calculator
'https://github.com/gingsean5/SimpleCalculator

Option Strict On
Option Explicit On

Module SimpleCalulator

    Sub Main()
        Dim userInput1 As String
        Dim userInput2 As String
        Dim userDecision As Integer
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim problem1 As Boolean = False
        Dim problem2 As Boolean = False
        Dim problem3 As Boolean = True
        Dim userSum As Integer
        Dim userProduct As Integer
        Dim userString As String

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


                While problem3 = True
                    Try
                        userString = Console.ReadLine()
                        userDecision = CInt(userString)
                        problem3 = False
                    Catch
                        problem3 = True
                    End Try
                End While

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
