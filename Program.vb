Module Program

    Const UPPER_THRESHOLD As Integer = 20
    Const LOWER_THRESHOLD As Integer = 0
    Private score As Integer = 0

    ' Input Checker function that returns a boolean
    Function isValueValid(input As Integer) As Boolean
        Return (score + input <= UPPER_THRESHOLD) AndAlso (score + input >= LOWER_THRESHOLD)
    End Function


    ' Implementation of the input checker
    Sub Main(args As String())

        ' The main loop of the program
        While True

            ' Initializes the consoles
            Console.Clear()
            Console.WriteLine($"--------------------------------------------------------------")
            Console.WriteLine($"| Current Score            : {score}")
            Console.Write("| Input add/subtract score (or type 'exit' to quit): ")

            Dim inputString As String = Console.ReadLine()
            Console.WriteLine($"| ")

            ' Exits the program
            If inputString.ToLower() = "exit" Then
                Console.WriteLine($"--------------------------------------------------------------")
                Console.WriteLine("The program exited.")
                Exit While
            End If

            Dim input As Integer

            ' Parses the input to integer, if failed, loop again.
            If Integer.TryParse(inputString, input) Then

                ' Checks if threshold is reached
                If isValueValid(input) Then
                    score += input ' Adds input into the score
                Else
                    Console.WriteLine($"|!!!!!!!!!!!!!!!!!!!!!!!! ERROR !!!!!!!!!!!!!!!!!!!!!!!!!!!!!")
                    Console.WriteLine("| Inputted value and current score has reached the threshold!")
                    Console.WriteLine($"| Latest input rejected. Press any key to continue...")
                    Console.ReadKey()
                End If
            Else
                Console.WriteLine($"|!!!!!!!!!!!!!!!!!!!!!!!! ERROR !!!!!!!!!!!!!!!!!!!!!!!!!!!!!")
                Console.WriteLine("| Invalid input. Press any key to continue...")
                Console.ReadKey()
            End If
        End While
    End Sub

End Module
