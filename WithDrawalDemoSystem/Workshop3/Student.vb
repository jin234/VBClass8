Public Class Student

    Private _STU_ID As String
    Private _STU_NAME As String
    Private _Score_Prac As Integer
    Private _Score_Proj As Integer
    Private _Score_Mid As Integer
    Private _Score_Fin As Integer

    Private _Test As String

    Public Property STU_ID As String
        Get
            Return _STU_ID
        End Get
        Set(value As String)
            _STU_ID = value
        End Set
    End Property

    Public Property STU_NAME As String
        Get
            Return _STU_NAME
        End Get
        Set(value As String)
            _STU_NAME = value
        End Set
    End Property
    'ff'
    Public Property Score_Prac As Integer
        Get
            Return _Score_Prac
        End Get
        Set(value As Integer)
            _Score_Prac = value
        End Set
    End Property

    Public Property Score_Proj As Integer
        Get
            Return _Score_Proj
        End Get
        Set(value As Integer)
            _Score_Proj = value
        End Set
    End Property

    Public Property Score_Mid As Integer
        Get
            Return _Score_Mid
        End Get
        Set(value As Integer)
            _Score_Mid = value
        End Set
    End Property

    Public Property Score_Fin As Integer
        Get
            Return _Score_Fin
        End Get
        Set(value As Integer)
            _Score_Fin = value
        End Set
    End Property

    Public Function Total_Score() As Integer
        Return _Score_Proj + _Score_Prac + _Score_Mid + _Score_Fin
    End Function

    Public Function Find_Grade() As String
        Dim total_Score_catch As Integer = Total_Score()
        If total_Score_catch >= 80 Then
            Return "A"
        ElseIf total_Score_catch >= 75 Then
            Return "B+"
        ElseIf total_Score_catch >= 70 Then
            Return "B"
        ElseIf total_Score_catch >= 65 Then
            Return "C+"
        ElseIf total_Score_catch >= 60 Then
            Return "C"
        ElseIf total_Score_catch >= 55 Then
            Return "D+"
        ElseIf total_Score_catch >= 50 Then
            Return "D"
        ElseIf total_Score_catch >= 0 Then
            Return "F"
        Else
            Return "Error"
        End If

    End Function

End Class
