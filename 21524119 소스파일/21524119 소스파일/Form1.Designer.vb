<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button_Start = New System.Windows.Forms.Button()
        Me.Button_Ranking = New System.Windows.Forms.Button()
        Me.Button_Quit = New System.Windows.Forms.Button()
        Me.Button_Easy = New System.Windows.Forms.Button()
        Me.Button_Normal = New System.Windows.Forms.Button()
        Me.Button_Hard = New System.Windows.Forms.Button()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button_Start
        '
        Me.Button_Start.Font = New System.Drawing.Font("굴림", 20.0!)
        Me.Button_Start.Location = New System.Drawing.Point(230, 200)
        Me.Button_Start.Name = "Button_Start"
        Me.Button_Start.Size = New System.Drawing.Size(190, 60)
        Me.Button_Start.TabIndex = 0
        Me.Button_Start.Text = "시작"
        Me.Button_Start.UseVisualStyleBackColor = True
        '
        'Button_Ranking
        '
        Me.Button_Ranking.Font = New System.Drawing.Font("굴림", 20.0!)
        Me.Button_Ranking.Location = New System.Drawing.Point(230, 280)
        Me.Button_Ranking.Name = "Button_Ranking"
        Me.Button_Ranking.Size = New System.Drawing.Size(190, 60)
        Me.Button_Ranking.TabIndex = 1
        Me.Button_Ranking.Text = "랭킹"
        Me.Button_Ranking.UseVisualStyleBackColor = True
        '
        'Button_Quit
        '
        Me.Button_Quit.Font = New System.Drawing.Font("굴림", 20.0!)
        Me.Button_Quit.Location = New System.Drawing.Point(230, 360)
        Me.Button_Quit.Name = "Button_Quit"
        Me.Button_Quit.Size = New System.Drawing.Size(190, 60)
        Me.Button_Quit.TabIndex = 2
        Me.Button_Quit.Text = "종료"
        Me.Button_Quit.UseVisualStyleBackColor = True
        '
        'Button_Easy
        '
        Me.Button_Easy.Font = New System.Drawing.Font("굴림", 20.0!)
        Me.Button_Easy.Location = New System.Drawing.Point(230, 200)
        Me.Button_Easy.Name = "Button_Easy"
        Me.Button_Easy.Size = New System.Drawing.Size(190, 60)
        Me.Button_Easy.TabIndex = 4
        Me.Button_Easy.Text = "쉬움"
        Me.Button_Easy.UseVisualStyleBackColor = True
        '
        'Button_Normal
        '
        Me.Button_Normal.Font = New System.Drawing.Font("굴림", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button_Normal.Location = New System.Drawing.Point(230, 280)
        Me.Button_Normal.Name = "Button_Normal"
        Me.Button_Normal.Size = New System.Drawing.Size(190, 60)
        Me.Button_Normal.TabIndex = 5
        Me.Button_Normal.Text = "보통"
        Me.Button_Normal.UseVisualStyleBackColor = True
        '
        'Button_Hard
        '
        Me.Button_Hard.Font = New System.Drawing.Font("굴림", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button_Hard.Location = New System.Drawing.Point(230, 360)
        Me.Button_Hard.Name = "Button_Hard"
        Me.Button_Hard.Size = New System.Drawing.Size(190, 60)
        Me.Button_Hard.TabIndex = 6
        Me.Button_Hard.Text = "어려움"
        Me.Button_Hard.UseVisualStyleBackColor = True
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Font = New System.Drawing.Font("굴림", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label_Title.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label_Title.Location = New System.Drawing.Point(86, 55)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(518, 64)
        Me.Label_Title.TabIndex = 7
        Me.Label_Title.Text = "두더지를 잡아라!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 450)
        Me.Controls.Add(Me.Label_Title)
        Me.Controls.Add(Me.Button_Hard)
        Me.Controls.Add(Me.Button_Normal)
        Me.Controls.Add(Me.Button_Easy)
        Me.Controls.Add(Me.Button_Quit)
        Me.Controls.Add(Me.Button_Ranking)
        Me.Controls.Add(Me.Button_Start)
        Me.Name = "Form1"
        Me.Text = "두더지 잡기"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Start As Button
    Friend WithEvents Button_Ranking As Button
    Friend WithEvents Button_Quit As Button
    Friend WithEvents Button_Normal As Button
    Friend WithEvents Button_Hard As Button
    Private WithEvents Button_Easy As Button
    Friend WithEvents Label_Title As Label
End Class
