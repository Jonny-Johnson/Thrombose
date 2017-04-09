Public Class Game
    '<DataMember()> Public hasStarted As Boolean = False
    'Public fields(7, 7) As Field
    Public testArray(4) As Integer

    Sub New()
        testArray(0) = 101
        testArray(1) = 999
    End Sub

    'Sub New()
    '    For Each f As Field In fields
    '        f = New Field
    '    Next

    '    For i As Integer = 0 To 2
    '        For j As Integer = 1 To 7 Step 2  'Step 2: nur jedes zweite Feld wird belegt
    '            If (i = 1) And (j = 1) Then j = 0 '2nd row starts shifted
    '            fields(j, i).piece.color = Piece.Colors.White
    '        Next
    '    Next

    '    For i As Integer = 5 To 7
    '        For j As Integer = 0 To 7 Step 2  'Step 2: nur jedes zweite Feld wird belegt
    '            If (i = 6) And (j = 0) Then j = 1 '6th row starts shifted
    '            fields(j, i).piece.color = Piece.Colors.Black
    '        Next
    '    Next
    'End Sub
End Class
