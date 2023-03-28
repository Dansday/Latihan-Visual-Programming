Module mdlSample
    Public Function average(ByRef grade As Double) As Double
        Static average_points As Double
        Static i As Double
        i += 1
        average_points += grade

        Return (average_points / i)
    End Function
End Module
