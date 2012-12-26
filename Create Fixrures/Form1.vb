Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click


        Dim i As Long, j As Long
        Dim Grid(0 To 10, 0 To 10) As Integer
        Dim Round(0 To 18) As String, temp As String

        ' initialize Grid
        For j = 1 To 9
            Grid(1, j) = j ' first row
        Next j

        For i = 2 To 9
            For j = 1 To 9
                Grid(i, j) = Grid(i - 1, j) + 1
                If Grid(i - 1, j) = 9 Then
                    Grid(i, j) = 1
                End If
            Next j
        Next i

        For i = 1 To 9 'fill in final row & col
            Grid(i, 10) = Grid(i, i)
            Grid(10, i) = Grid(i, i)
        Next i

        'now check Grid to see if ok
        For i = 1 To 10
            'Debug.Print()
            For j = 1 To 10
                ' Debug.Print Grid(i, j);
            Next j
        Next i

        For i = 1 To 9
            For j = i + 1 To 10

                Round(Grid(i, j)) = Round(Grid(i, j)) & Chr(64 + i) _
                & Chr(64 + j) & "-"
                Round(9 + Grid(i, j)) = Round(9 + Grid(i, j)) & Chr(64 + j) _
                & Chr(64 + i) & "-"
            Next j
        Next i
        'Debug.Print()

        'Now we need to get rid of clumping so
        'swap 2 with 17 ...4 with 15 ...6 with 13
        j = 17

        For i = 2 To 8 Step 2
            temp = Round(i)
            Round(i) = Round(j)
            Round(j) = temp
            j = j - 2
        Next i

        'Lets see how it went
        For i = 1 To 18
            'Debug.Print ("Round") i, Round(i)
        Next i

        Print("finished")

    End Sub
End Class
