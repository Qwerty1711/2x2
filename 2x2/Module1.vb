Module Module1
    Dim cube(,,) As Integer =
                     {{{1, 1},
                       {1, 1}},
            {{2, 2},
             {2, 2}}, {{3, 3},
                       {3, 3}}, {{4, 4},
                                 {4, 4}},
                      {{5, 5},
                       {5, 5}},
                      {{6, 6},
                       {6, 6}}}

    Sub printCube()
        Console.WriteLine("faces:")
        Console.WriteLine(" A")
        Console.WriteLine("BCD")
        Console.WriteLine(" E")
        Console.WriteLine(" F")
        Console.WriteLine()
        Console.WriteLine("cube:")
        
        For i = 0 To 1
            Console.Write("   ")
            For j = 0 To 1
                Console.Write(cube(0, i, j))
            Next
            Console.WriteLine()
        Next
        Console.WriteLine()
        For i = 0 To 1
            For j = 1 To 3
                For k = 0 To 1
                    Console.Write(cube(j, i, k))
                Next
                Console.Write(" ")
            Next
            Console.WriteLine()
        Next
        Console.WriteLine()
        For i = 4 To 5
            For j = 0 To 1
                Console.Write("   ")
                For k = 0 To 1
                    Console.Write(cube(i, j, k))
                Next
                Console.WriteLine()
            Next
            Console.WriteLine()
        Next
    End Sub

    Sub switch(code As String, dir As String)
        Dim x As Integer
        If dir = "C" Then
            x = cube(Char.GetNumericValue(code(9)), Char.GetNumericValue(code(10)), Char.GetNumericValue(code(11)))
            cube(Char.GetNumericValue(code(9)), Char.GetNumericValue(code(10)), Char.GetNumericValue(code(11))) = cube(Char.GetNumericValue(code(6)), Char.GetNumericValue(code(7)), Char.GetNumericValue(code(8)))
            cube(Char.GetNumericValue(code(6)), Char.GetNumericValue(code(7)), Char.GetNumericValue(code(8))) = cube(Char.GetNumericValue(code(3)), Char.GetNumericValue(code(4)), Char.GetNumericValue(code(5)))
            cube(Char.GetNumericValue(code(3)), Char.GetNumericValue(code(4)), Char.GetNumericValue(code(5))) = cube(Char.GetNumericValue(code(0)), Char.GetNumericValue(code(1)), Char.GetNumericValue(code(2)))
            cube(Char.GetNumericValue(code(0)), Char.GetNumericValue(code(1)), Char.GetNumericValue(code(2))) = x
        ElseIf dir = "A" Then
            x = cube(Char.GetNumericValue(code(0)), Char.GetNumericValue(code(1)), Char.GetNumericValue(code(2)))
            cube(Char.GetNumericValue(code(0)), Char.GetNumericValue(code(1)), Char.GetNumericValue(code(2))) = cube(Char.GetNumericValue(code(3)), Char.GetNumericValue(code(4)), Char.GetNumericValue(code(5)))
            cube(Char.GetNumericValue(code(3)), Char.GetNumericValue(code(4)), Char.GetNumericValue(code(5))) = cube(Char.GetNumericValue(code(6)), Char.GetNumericValue(code(7)), Char.GetNumericValue(code(8)))
            cube(Char.GetNumericValue(code(6)), Char.GetNumericValue(code(7)), Char.GetNumericValue(code(8))) = cube(Char.GetNumericValue(code(9)), Char.GetNumericValue(code(10)), Char.GetNumericValue(code(11)))
            cube(Char.GetNumericValue(code(9)), Char.GetNumericValue(code(10)), Char.GetNumericValue(code(11))) = x
        End If

    End Sub

    Dim func As String

    Sub Main()
        While True
            printCube()
            func = Console.ReadLine()
            If func(0) = "A" Then
                switch("510301201101", func(1))
                switch("511300200100", func(1))
            ElseIf func(0) = "B" Then
                switch("000200400500", func(1))
                switch("010210410510", func(1))
            ElseIf func(0) = "C" Then
                switch("010300401111", func(1))
                switch("011310400101", func(1))
            ElseIf func(0) = "D" Then
                switch("011511411211", func(1))
                switch("001501401201", func(1))
            ElseIf func(0) = "E" Then
                switch("210310501110", func(1))
                switch("211311500111", func(1))
            ElseIf func(0) = "F" Then
                switch("410311001100", func(1))
                switch("411301000110", func(1))
            End If
            Console.Clear()
        End While
    End Sub

End Module
