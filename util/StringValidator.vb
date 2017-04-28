Imports System.Text.RegularExpressions

Public Class StringValidator
    Public Shared Function isContainer(ByVal container As String) As Boolean
        Dim regex As Regex = New Regex("([A-Z]{4})-([0-9]{6})-([0-9]{1})")
        Return regex.IsMatch(container)
    End Function
End Class
