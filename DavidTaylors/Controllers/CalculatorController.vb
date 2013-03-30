Namespace DavidTaylors
    Public Class CalculatorController
        Inherits System.Web.Mvc.Controller

        Function Index() As ActionResult
            Return View()
        End Function

        Function Add(NumberOne As Integer, NumberTwo As Integer)

            Dim result As New CalculatorResult() With _
                { _
                    .NumberOne = NumberOne, _
                    .NumberTwo = NumberTwo, _
                    .Result = NumberOne + NumberTwo _
                }

            Return View(result)
        End Function

    End Class


End Namespace



Public Class CalculatorResult

    Private _numberOne As Integer
    Public Property NumberOne() As Integer
        Get
            Return _numberOne
        End Get
        Set(ByVal value As Integer)
            _numberOne = value
        End Set
    End Property

    Private _numberTwo As Integer
    Public Property NumberTwo() As Integer
        Get
            Return _numberTwo
        End Get
        Set(ByVal value As Integer)
            _numberTwo = value
        End Set
    End Property

    Private _result As Integer
    Public Property Result() As Integer
        Get
            Return _result
        End Get
        Set(ByVal value As Integer)
            _result = value
        End Set
    End Property

End Class