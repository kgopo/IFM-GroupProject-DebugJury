Public Class ClubMembers


    'Attributes
    Private _MemberName As String
    Private _IDNumber As Integer
    Private _Address As String
    Private _ISOwing As Boolean
    Private _AmounntOwing As Double
    Private _TotalAmountinvested As Double
    Private _indivProContributed As Double
    Private _ExpectedAmountP As Double
    Private _TotalAmountPaid As Double
    Private _NominatedCharity As String

    '*************************************************************
    'To give the every members profit contribution    
    Public ReadOnly Property indivProContributed() As Double
        Get
            FindIndividualProfit_M()
            Return _indivProContributed
        End Get
    End Property

    '****************************************************************
    Public Property ISOwing() As Boolean
        Set(value As Boolean)
            _ISOwing = value
        End Set
        Get
            Return _ISOwing
        End Get
    End Property

    Public Property AmounntOwing() As Double
        Set(value As Double)
            _AmounntOwing = value
        End Set
        Get
            Return _AmounntOwing
        End Get
    End Property

    Public Property TotalAmountinvested() As Double
        Set(value As Double)
            _TotalAmountinvested = value
        End Set
        Get
            Return _TotalAmountinvested
        End Get
    End Property

    Public Property ExpectedAmountP() As Double
        Set(value As Double)
            _ExpectedAmountP = value
        End Set
        Get
            Return _ExpectedAmountP
        End Get
    End Property


    Public Property TotalAmountPaid() As Double
        Set(value As Double)
            _TotalAmountPaid = value
        End Set
        Get
            Return TotalAmountPaid
        End Get
    End Property




    Public Property NominatedCharity() As Double
        Set(value As Double)
            _NominatedCharity = value
        End Set
        Get
            Return _NominatedCharity
        End Get
    End Property

    'Helper Methods 
    '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

    Private Sub FindIndividualProfit_M()
        _indivProContributed = _TotalAmountinvested - _ExpectedAmountP
    End Sub




    '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^




    'public methods 
    '##################################################################
    Public Function Get_TotalMoneyContributed() As Double

        '
        Return _TotalAmountPaid

    End Function



    Public Sub New()
        _ISOwing = False
        _AmounntOwing = 0.0
        _TotalAmountinvested = 0.0
        _indivProContributed = 0.0
        _ExpectedAmountP = 0.0
        _TotalAmountPaid = 0.0
    End Sub

End Class
