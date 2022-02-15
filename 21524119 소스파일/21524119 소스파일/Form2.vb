Imports System.Threading

Public Class Form2

    Dim bgm As New GameSounds
    Private trd As Thread

    Const TIME_LIMIT As Integer = 30 ' 제한 시간 : 30초
    Structure Mole '두더지 구조체
        Dim Flag As Integer ' 두더지 상태
        Dim Delay As Integer ' 두더지의 대기시간 
        Dim Frame As Integer ' 두더지 애니메이션 프레임
        Dim Frame2 As Integer ' 맞고난뒤의 상태
    End Structure

    Structure Rank '랭킹 구조체
        Dim name As String '이름
        Dim score As Integer '점수
    End Structure

    Dim moleimages(36) As Image '두더지 사진
    Dim moles(0 To 9) As Mole '두더지
    Dim moles_image(0 To 9) As PictureBox '두더지 구멍
    Dim score As Integer = 0 '점수'
    Dim Start As Boolean '게임이 시작 되었는가?

    Public Rank_list() As Rank '랭킹
    Public Rank_num As Integer = 0 '랭킹 인원 수

    Private Sub ThreadTask()
        Do
            Label_Score.Text = "점수 : " & score & ""
        Loop
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Start = True

        Me.BackgroundImage = Image.FromFile("초원.jpg")
        bgm.AddSound("MainTheme", "MainTheme.mp3")
        bgm.AddSound("hit", "hit.wav")
        bgm.AddSound("Theme", "Yee.mp3")
        bgm.AddSound("Ending", "End.mp3")
        bgm.AddSound("Count", "Countdown.mp3")

        '두더지 구멍 할당
        moles_image(0) = PictureBox1
        moles_image(1) = PictureBox2
        moles_image(2) = PictureBox3
        moles_image(3) = PictureBox4
        moles_image(4) = PictureBox5
        moles_image(5) = PictureBox6
        moles_image(6) = PictureBox7
        moles_image(7) = PictureBox8
        moles_image(8) = PictureBox9

        MoleImage()

        trd = New Thread(AddressOf ThreadTask)
        trd.IsBackground = True
        trd.Start()
    End Sub

    Private Sub MoleAp_Timer_Tick(sender As Object, e As EventArgs) Handles MoleAp_Timer.Tick
        If bgm.IsStopped("Theme") Then
            bgm.Play("Theme")
        End If
        Dim i As Integer
        i = Int(Rnd() * 9)

        If Rnd() < (30 - Val(Label_LimitTime.Text)) / 30 And moles(i).Frame = 0 Then
            moles(i).Flag = 1
        End If

        For i = 0 To 8
            With moles(i)
                If .Delay = 0 Then
                    If .Flag <> 0 Then
                        .Frame = .Frame + .Flag
                        moles_image(i).Image = moleimages(.Frame)
                    ElseIf .Frame > 18 Then
                        .Frame = .Frame + .Frame2
                        moles_image(i).Image = moleimages(.Frame)
                    End If

                    Select Case .Frame
                        Case 0
                            .Flag = 0
                            .Delay = 0
                        Case 17
                            .Flag = -1
                            .Delay = 0
                        Case 36
                            .Frame = 0
                            .Delay = 3
                    End Select
                Else
                    .Delay = .Delay - 1
                End If
            End With
        Next

        Invalidate()
    End Sub

    Private Sub Limit_Timer_Tick(sender As Object, e As EventArgs) Handles Limit_Timer.Tick
        Dim Yesno, name As String
        Label_LimitTime.Text = Val(Label_LimitTime.Text) - 1
        If Label_LimitTime.Text = 0 Then
            Limit_Timer.Enabled = False
            MoleAp_Timer.Enabled = False
            bgm.Stop("Theme")
            bgm.Play("Ending")
            Start = False
            Yesno = MsgBox("랭킹을 등록하시겠습니까?", vbYesNo + vbQuestion, "타임 오버!!")
            If Yesno = vbYes Then
                name = InputBox("이름을 입력해주세요.", "이름 등록")
                Rank_list(Rank_num).name = name
                Rank_list(Rank_num).score = score
                Rank_num = Rank_num + 1
                ReDim Preserve Rank_list(Rank_num)
                MsgBox("수고하셨습니다.")
                Me.Hide()
                Start = True
            Else
                MsgBox("수고하셨습니다.")
                Me.Hide()
                Start = True
            End If
        End If
    End Sub

    Private Sub MoleImage() '두더지 등장 애니메이션
        moleimages(0) = My.Resources.Mole_1
        moleimages(1) = My.Resources.Mole_2
        moleimages(2) = My.Resources.Mole_3
        moleimages(3) = My.Resources.Mole_4
        moleimages(4) = My.Resources.Mole_5
        moleimages(5) = My.Resources.Mole_6
        moleimages(6) = My.Resources.Mole_7
        moleimages(7) = My.Resources.Mole_8
        moleimages(8) = My.Resources.Mole_9
        moleimages(9) = My.Resources.Mole_10
        moleimages(10) = My.Resources.Mole_11
        moleimages(11) = My.Resources.Mole_12
        moleimages(12) = My.Resources.Mole_13
        moleimages(13) = My.Resources.Mole_14
        moleimages(14) = My.Resources.Mole_15
        moleimages(15) = My.Resources.Mole_16
        moleimages(16) = My.Resources.Mole_17
        moleimages(17) = My.Resources.Mole_18
        moleimages(18) = My.Resources.Mole_19

        moleimages(19) = My.Resources.mole_catch_1
        moleimages(20) = My.Resources.mole_catch_2
        moleimages(21) = My.Resources.mole_catch_3
        moleimages(22) = My.Resources.mole_catch_4
        moleimages(23) = My.Resources.mole_catch_5
        moleimages(24) = My.Resources.mole_catch_6
        moleimages(25) = My.Resources.mole_catch_7
        moleimages(26) = My.Resources.mole_catch_8
        moleimages(27) = My.Resources.mole_catch_9
        moleimages(28) = My.Resources.mole_catch_10
        moleimages(29) = My.Resources.mole_catch_11
        moleimages(30) = My.Resources.mole_catch_12
        moleimages(31) = My.Resources.mole_catch_13
        moleimages(32) = My.Resources.mole_catch_14
        moleimages(33) = My.Resources.mole_catch_15
        moleimages(34) = My.Resources.mole_catch_16
        moleimages(35) = My.Resources.mole_catch_17
        moleimages(36) = My.Resources.mole_catch_18

    End Sub

    Private Sub MouseClick1(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick

        If Not Limit_Timer.Enabled Then
            Exit Sub
        End If

        If moles(0).Flag <> 0 Then
            moles(0).Flag = 0
            moles(0).Delay = 0
            moles(0).Frame = 19
            bgm.Play("hit")
            score = score + CInt(10)
        Else
            moles(0).Flag = 0
            moles(0).Delay = 0
            moles(0).Frame = 0
        End If
    End Sub
    Private Sub MouseClick2(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseClick

        If Not Limit_Timer.Enabled Then
            Exit Sub
        End If

        If moles(1).Flag <> 0 Then
            moles(1).Flag = 0
            moles(1).Delay = 0
            moles(1).Frame = 19
            bgm.Play("hit")
            score = score + CInt(10)
        Else
            moles(1).Flag = 0
            moles(1).Delay = 0
            moles(1).Frame = 0
        End If
    End Sub
    Private Sub MouseClick3(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseClick

        If Not Limit_Timer.Enabled Then
            Exit Sub
        End If

        If moles(2).Flag <> 0 Then
            moles(2).Flag = 0
            moles(2).Delay = 0
            moles(2).Frame = 19
            bgm.Play("hit")
            score = score + CInt(10)
        Else
            moles(2).Flag = 0
            moles(2).Delay = 0
            moles(2).Frame = 0
        End If
    End Sub
    Private Sub MouseClick4(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseClick

        If Not Limit_Timer.Enabled Then
            Exit Sub
        End If

        If moles(3).Flag <> 0 Then
            moles(3).Flag = 0
            moles(3).Delay = 0
            moles(3).Frame = 19
            bgm.Play("hit")
            score = score + CInt(10)
        Else
            moles(3).Flag = 0
            moles(3).Delay = 0
            moles(3).Frame = 0
        End If
    End Sub
    Private Sub MouseClick5(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseClick

        If Not Limit_Timer.Enabled Then
            Exit Sub
        End If

        If moles(4).Flag <> 0 Then
            moles(4).Flag = 0
            moles(4).Delay = 0
            moles(4).Frame = 19
            bgm.Play("hit")
            score = score + CInt(10)
        Else
            moles(4).Flag = 0
            moles(4).Delay = 0
            moles(4).Frame = 0
        End If
    End Sub
    Private Sub MouseClick6(sender As Object, e As MouseEventArgs) Handles PictureBox6.MouseClick

        If Not Limit_Timer.Enabled Then
            Exit Sub
        End If

        If moles(5).Flag <> 0 Then
            moles(5).Flag = 0
            moles(5).Delay = 0
            moles(5).Frame = 19
            bgm.Play("hit")
            score = score + CInt(10)
        Else
            moles(5).Flag = 0
            moles(5).Delay = 0
            moles(5).Frame = 0
        End If
    End Sub
    Private Sub MouseClick7(sender As Object, e As MouseEventArgs) Handles PictureBox7.MouseClick

        If Not Limit_Timer.Enabled Then
            Exit Sub
        End If

        If moles(6).Flag <> 0 Then
            moles(6).Flag = 0
            moles(6).Delay = 0
            moles(6).Frame = 19
            bgm.Play("hit")
            score = score + CInt(10)
        Else
            moles(6).Flag = 0
            moles(6).Delay = 0
            moles(6).Frame = 0
        End If
    End Sub
    Private Sub MouseClick8(sender As Object, e As MouseEventArgs) Handles PictureBox8.MouseClick

        If Not Limit_Timer.Enabled Then
            Exit Sub
        End If

        If moles(7).Flag <> 0 Then
            moles(7).Flag = 0
            moles(7).Delay = 0
            moles(7).Frame = 19
            bgm.Play("hit")
            score = score + CInt(10)
        Else
            moles(7).Flag = 0
            moles(7).Delay = 0
            moles(7).Frame = 0
        End If
    End Sub
    Private Sub MouseClick9(sender As Object, e As MouseEventArgs) Handles PictureBox9.MouseClick

        If Not Limit_Timer.Enabled Then
            Exit Sub
        End If

        If moles(8).Flag <> 0 Then
            moles(8).Flag = 0
            moles(8).Delay = 0
            moles(8).Frame = 19
            bgm.Play("hit")
            score = score + CInt(10)
        Else
            moles(8).Flag = 0
            moles(8).Delay = 0
            moles(8).Frame = 0
        End If
    End Sub

    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Dim i As Integer
        For i = 0 To 8 '두더지 구조체 초기값 설정
            moles(i).Flag = 0
            moles(i).Delay = 0
            moles(i).Frame = 0
            moles(i).Frame2 = 1
        Next

        ReDim Preserve Rank_list(Rank_num) '동적배열

        If Start = True Then
            For i = 0 To 8
                moles_image(i).Image = Image.FromFile("두더지 구멍.png")
            Next
            score = 0
            Label_Score.Text = score
            Label_LimitTime.Text = TIME_LIMIT
            Label_StartCount.Text = 5
            Label_StartCount.Visible = True
            StartCount_Timer.Enabled = True
            bgm.Play("Count")
        End If
    End Sub

    Private Sub StartCount_Timer_Tick(sender As Object, e As EventArgs) Handles StartCount_Timer.Tick
        Label_StartCount.Text = Val(Label_StartCount.Text) - 1
        If Label_StartCount.Text = 0 Then
            bgm.Stop("Count")
            bgm.Play("Theme")
            MoleAp_Timer.Enabled = True
            StartCount_Timer.Enabled = False
            Label_StartCount.Hide()
            Label_StartCount.Text = 5
            Limit_Timer.Enabled = True
        End If
    End Sub
End Class
