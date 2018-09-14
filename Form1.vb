Option Explicit On
Option Strict On
Option Infer Off
Public Class Form1

    Private _ClubProfit As Double = 0.0
    Private _ClubName As String = "FSGSSC "
    Private _NumberOfMembers As Integer = 32
    Private _IsthereProfit As Boolean = False
    Private _Members() As ClubMembers
    Private _isProgramNew As Boolean = True
    Private _Charity As Charity

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplaytotxtClubDesplay()
        ReDim _Members(_NumberOfMembers)
        For c As Integer = 1 To _NumberOfMembers
            'instanstiation of members 
            _Members(c) = New ClubMembers
        Next
        _Charity = New Charity

    End Sub


    'in the event that the updateClubdetils bottun is clicked
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClubDetails.Click
        frmUpdateClubDetails.Show()
    End Sub


    'in the event that the Addmember button is clicked 
    Private Sub btnAddMember_Click(sender As Object, e As EventArgs) Handles btnAddMember.Click
        frmAddMember.Show()

    End Sub

    ''in the event that the election button is clicked 
    Private Sub btnInitElections_Click(sender As Object, e As EventArgs) Handles btnInitElections.Click
        frmElectionCenter.Show()
    End Sub

    Private Sub btnUpdateMember_Click(sender As Object, e As EventArgs) Handles btnUpdateMember.Click
        frmUpdateClubMember.Show()

    End Sub

    Private Sub frmAddMember_Click(sender As Object, e As EventArgs) Handles btnAddMember.Click
        frmAddMember.Show()

    End Sub


    'Form1 Methods 
    Public Sub DisplaytotxtClubDesplay()
        txtClubDesplay.Text = _ClubName &
            Environment.NewLine
        txtClubDesplay.Text &= "Club profit:" & CStr(_ClubProfit) &
        Environment.NewLine
        txtClubDesplay.Text &= "Number of members: " & CStr(_NumberOfMembers)

    End Sub

    ' methods 
    '################################################################

    'Public Function Get_TotalMemberContibution() As Double
    'Dim m As Integer = 0
    'For m = 1 To _NumberOfMembers
    '       _Members(m).Get_TotalMoneyContributed()

    'Next m

    'End Function



    Private Sub FindClubPRofit()
        Dim m As Integer

        For m = 1 To _Members.Length
            _ClubProfit += _Members(m).indivProContributed

        Next m
    End Sub


    '################################################################
    'property methods  functions 

    Public Property numberOfMembers() As Integer
        Set(value As Integer)
            _NumberOfMembers = value
        End Set
        Get
            Return _NumberOfMembers
        End Get
    End Property

    Public Property ClubProfit() As Double
        Get

        End Get
        Set(value As Double)

        End Set
    End Property
    Public Property ClubName() As String
        Get

        End Get
        Set(value As String)

        End Set
    End Property
    Public Property NumberOfMembers() As Integer
        Get

        End Get
        Set(value As Integer)

        End Set
    End Property
    Public Property IsthereProfit() As Boolean
        Get

        End Get
        Set(value As Boolean)

        End Set
    End Property
    Public Property Members(ByVal index As Integer) As ClubMembers
        Get

            Return _Members(index)

        End Get
        Set(value As ClubMembers)
            _Members(index) = value
        End Set
    End Property
    Public Property isProgramNew As Boolean
        Get

        End Get
        Set(value As Boolean)

        End Set
    End Property

    Public Property Charity() As Charity
        Get

        End Get
        Set(value As Charity)

        End Set
    End Property
End Class
