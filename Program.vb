Module Program

    Const UPPER_THRESHOLD As Integer = 20
    Const LOWER_THRESHOLD As Integer = 0
    Private score As Integer = 0

    Function isValueValid(input As Integer) As Boolean

        Return (score + input <= UPPER_THRESHOLD) AndAlso (score + input >= LOWER_THRESHOLD)
    End Function

    Sub Main(args As String())
        While True
            Console.Clear()
            Console.WriteLine($"--------------------------------------------------------------")
            Console.WriteLine($"| Current Score            : {score}")
            Console.Write("| Input add/subtract score (or type 'exit' to quit): ")

            Dim inputString As String = Console.ReadLine()
            Console.WriteLine($"| ")
            If inputString.ToLower() = "exit" Then
                Console.WriteLine($"--------------------------------------------------------------")
                Console.WriteLine("The program exited.")
                Exit While
            End If

            Dim input As Integer
            If Integer.TryParse(inputString, input) Then
                If isValueValid(input) Then
                    score += input
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
