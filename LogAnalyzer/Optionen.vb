Public Class Options2
    Dim filepath1 As String ' Nimmt den Pfadnamen auf
    Sub Options2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = logfilepath
        ReadIniFile()
        If language = "DE" Then RB_DE1.Checked = True
        If language = "EN" Then RB_EN1.Checked = True
        SetLanguage_optionen()
    End Sub
    Sub RB_DE1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_DE1.CheckedChanged
        If RB_DE1.Checked Then
            language = "DE"
        ElseIf RB_EN1.Checked = True Then
            language = "EN"
        End If
        SetLanguage_optionen()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WriteIniFile()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ReadIniFile()
        Me.Close()
    End Sub
    Public Sub SetLanguage_optionen()
        language_settings()
        Button2.Text = t1
        GroupBox1.Text = t2
        Label1.Text = t3
    End Sub

    Private Sub RB_EN1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_EN1.CheckedChanged

    End Sub

    Public Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_klein1.CheckedChanged
        If RB_klein1.Checked Then

        ElseIf RB_gross1.Checked = True Then
            language = "EN"
        End If

    End Sub

    Private Sub bn_file1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bn_file1.Click
        OpenFileDialog1.InitialDirectory = logfilepath
        OpenFileDialog1.ShowDialog()
        filepath1 = OpenFileDialog1.FileName
        If filepath1 = "" Then Exit Sub
    End Sub


End Class
