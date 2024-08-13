Public Class Loading

    Private isDragging As Boolean = False
    Private mouseOffset As Point

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            mouseOffset = New Point(-e.X, -e.Y)
        End If
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            isDragging = False
        End If
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If isDragging Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TransparencyKey = BackColor
        ' Initialize the progress bar
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0

        ' Update the progress bar and label periodically
        Timer1.Interval = 100
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Increment the progress bar
        ProgressBar1.Value += 10
        Label1.Text = $"Loading... {ProgressBar1.Value}%"

        ' Stop the timer when the progress reaches 100%
        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            Timer1.Stop()
            Me.Hide() ' Close the LoadingScreen form

            ' Create an instance of the MainForm and show it
            Dim mainForm As New MainForm()
            mainForm.Show()
        End If
    End Sub
End Class