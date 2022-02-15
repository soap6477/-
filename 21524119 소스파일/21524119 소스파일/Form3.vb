Public Class Form3
    Dim Label_list(9) As Label
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_list(0) = Label_list1
        Label_list(1) = Label_list2
        Label_list(2) = Label_list3
        Label_list(3) = Label_list4
        Label_list(4) = Label_list5
        Label_list(5) = Label_list6
        Label_list(6) = Label_list7
        Label_list(7) = Label_list8
        Label_list(8) = Label_list9
        Label_list(9) = Label_list10

        For i = 0 To 9
            Label_list(i).Text = ""
        Next
    End Sub

    Private Sub Form3_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Dim temp As Integer
        Dim name As String
        For i = 0 To Form2.Rank_num
            For j = 0 To (Form2.Rank_num - 1) - i
                If Form2.Rank_list(j).score < Form2.Rank_list(j + 1).score Then
                    temp = Form2.Rank_list(j).score
                    name = Form2.Rank_list(j).name
                    Form2.Rank_list(j).score = Form2.Rank_list(j + 1).score
                    Form2.Rank_list(j).name = Form2.Rank_list(j + 1).name
                    Form2.Rank_list(j + 1).score = temp
                    Form2.Rank_list(j + 1).name = name
                End If
            Next
        Next

        For i = 0 To Form2.Rank_num - 1
            Label_list(i).Text = Form2.Rank_list(i).name & "              " & Form2.Rank_list(i).score & "점"
        Next
    End Sub
End Class