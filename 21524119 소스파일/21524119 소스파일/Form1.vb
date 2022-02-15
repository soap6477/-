Public Class Form1
    Private Sub Button_Start_Click(sender As Object, e As EventArgs) Handles Button_Start.Click
        Button_Easy.Visible = True
        Button_Normal.Visible = True
        Button_Hard.Visible = True

    End Sub

    Private Sub Button_Ranking_Click(sender As Object, e As EventArgs) Handles Button_Ranking.Click
        Form3.Show()
    End Sub

    Private Sub Button_Quit_Click(sender As Object, e As EventArgs) Handles Button_Quit.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Activated
        Button_Easy.Visible = False
        Button_Normal.Visible = False
        Button_Hard.Visible = False
    End Sub

    Private Sub Button_Easy_Click(sender As Object, e As EventArgs) Handles Button_Easy.Click
        Form2.MoleAp_Timer.Interval = 50
        Form2.Show()
    End Sub

    Private Sub Button_Normal_Click(sender As Object, e As EventArgs) Handles Button_Normal.Click
        Form2.MoleAp_Timer.Interval = 30
        Form2.Show()
    End Sub

    Private Sub Button_Hard_Click(sender As Object, e As EventArgs) Handles Button_Hard.Click
        Form2.MoleAp_Timer.Interval = 1
        Form2.Show()
    End Sub
End Class