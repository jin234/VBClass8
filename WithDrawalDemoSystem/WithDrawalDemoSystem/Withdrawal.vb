﻿Public Class Withdrawal

    Private _Balance As Integer
    Private _Withdrawal As Integer

    Public Property Balance As Integer
        Get
            Return _Balance
        End Get
        Set(value As Integer)
            _Balance = value
        End Set
    End Property

    Public Property Withdraw As Integer
        Get
            Return _Withdrawal
        End Get
        Set(value As Integer)
            _Withdrawal = value
        End Set
    End Property

    Public Sub Withdrawing()
        Balance -= Withdraw
    End Sub

    Public Function GenNote()
        Dim Note1000 As Integer = _Withdrawal \ 1000
        Dim Note500 As Integer = (_Withdrawal Mod 1000) \ 500
        Dim Note100 As Integer = ((_Withdrawal Mod 1000) Mod 500) \ 100

        Return "1000 : " & Note1000 & vbNewLine &
               "500 : " & Note500 & vbNewLine &
               "100 : " & Note100
    End Function

End Class
