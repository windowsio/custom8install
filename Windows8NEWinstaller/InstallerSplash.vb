Public Class InstallerSplash
    Private Sub InstallerSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Computer.FileSystem.FileExists("C:\win8\setup.exe") Then
            MessageBox.Show("Windows 8 (setup) has been detected in C:\win8 IF THIS IS NOT CORRECT PRESS NO. PRESSING YES may HARM YOUR PC",
        "Success! (or not ;()", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
            form2.Show
            Form2.Hide()
            ProgressBar1.Value += 35
            Form3.Show()
            Form3.Hide()
            ProgressBar1.Value += 35
            Form4.Show()
            Form4.Hide()
            ProgressBar1.Value += 10
            Form5.Show()
            Form5.Hide()
            ProgressBar1.Value += 10
            IAF.Show()
            IAF.Hide()
            ProgressBar1.Value += 10
            If ProgressBar1.Value = 100 Then
                Form2.Show()
                Me.Close()

            End If
        Else
            MessageBox.Show("Windows 8 NOT FOUND in C:\win8.",
          "Login Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)
            Me.Close()

        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class