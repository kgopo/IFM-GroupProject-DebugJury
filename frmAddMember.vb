Public Class frmAddMember

    Private _numberOfMembers = 0
    Private Sub frmAddMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim m As Integer = 0

        'loop to display names of all of the members 
        For m = 1 To _numberOfMembers
            txtDisplayMembers.Text &= "Member " & m &
                Environment.NewLine
        Next m
    End Sub

    '
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m As Integer = 0

        'loop to display names of all of the members 
        For m = 1 To _numberOfMembers
            txtDisplayMembers.Text &= "Member " & m &
                Environment.NewLine
        Next m

    End Sub
    Public number
End Class