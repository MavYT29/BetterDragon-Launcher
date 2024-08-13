Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Imports System.IO

Public Class MainForm
    Private pfc As New PrivateFontCollection()
    Private isDragging As Boolean = False
    Private mouseOffset As Point
    Private WithEvents timer As New Timer()


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Initialize timer settings
        timer.Interval = 55 ' Interval in milliseconds
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05 ' Increase opacity
        Else
            timer.Stop()
        End If
    End Sub
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

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' I-load ang tatlong font files mula sa fonts folder
        Dim fontFileNames As String() = {"ComboBox.Font.otf", "Label1.Font.ttf", "btnPlay.Font.ttf"} ' Palitan ito ng tamang font filenames

        For Each fontFileName In fontFileNames
            Dim fontPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fonts", fontFileName)

            If File.Exists(fontPath) Then
                ' I-load ang font mula sa file
                Dim fontData() As Byte = File.ReadAllBytes(fontPath)

                ' I-add ang font sa PrivateFontCollection
                Dim fontPtr As IntPtr = Marshal.AllocCoTaskMem(fontData.Length)
                Marshal.Copy(fontData, 0, fontPtr, fontData.Length)
                pfc.AddMemoryFont(fontPtr, fontData.Length)

                ' I-release ang memory
                Marshal.FreeCoTaskMem(fontPtr)
            Else
                MessageBox.Show("Font file not found: " & fontPath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Next

        Me.Opacity = 0 ' Start with the form invisible
        timer.Start()

        ' Itakda ang font sa mga controls
        btnPlayMinecraft.Font = New Font(pfc.Families(2), 12) ' Palitan ang size ayon sa gusto mo
        MinecraftTypeComboBox.Font = New Font(pfc.Families(0), 8.999999, FontStyle.Bold) ' Gamitin ang pangalawang font
        Label1.Font = New Font(pfc.Families(1), 9.75) ' Gamitin ang pangatlong font

        ' Add items to the ComboBox
        MinecraftTypeComboBox.Items.Add("Minecraft Normal")
        MinecraftTypeComboBox.Items.Add("Minecraft Preview")
        MinecraftTypeComboBox.SelectedIndex = 0 ' Default to the first item
    End Sub

    Private Sub btnPlayMinecraft_Click(sender As Object, e As EventArgs) Handles btnPlayMinecraft.Click
        Dim baseDirectory As String = AppDomain.CurrentDomain.BaseDirectory

        Dim dllsDirectory As String = Path.Combine(baseDirectory, "dlls")
        If Not Directory.Exists(dllsDirectory) Then
            Directory.CreateDirectory(dllsDirectory)
        End If

        Dim uwpinjectFileName As String = "uwpinject.exe"
        Dim uwpinjectFilePath As String = Path.Combine(baseDirectory, uwpinjectFileName)
        If Not File.Exists(uwpinjectFilePath) Then
            Dim uwpInjectBytes As Byte() = My.Resources.uwpinject
            File.WriteAllBytes(uwpinjectFilePath, uwpInjectBytes)
            HideFile(uwpinjectFilePath) ' Hide the uwpinject.exe file
        End If

        Dim betterRenderDragonFileName As String = "BetterRenderDragon.dll"
        Dim betterRenderDragonFilePath As String = Path.Combine(dllsDirectory, betterRenderDragonFileName)
        If Not File.Exists(betterRenderDragonFilePath) Then
            Dim betterRenderDragonBytes As Byte() = My.Resources.BetterRenderDragon
            File.WriteAllBytes(betterRenderDragonFilePath, betterRenderDragonBytes)
        End If

        Dim minecraftPackage As String = String.Empty ' Initialize the variable

        If File.Exists(uwpinjectFilePath) AndAlso File.Exists(betterRenderDragonFilePath) Then
            If MinecraftTypeComboBox.SelectedItem.ToString() = "Minecraft Normal" Then
                minecraftPackage = GetAppxPackageFullName("Microsoft.MinecraftUWP")
            ElseIf MinecraftTypeComboBox.SelectedItem.ToString() = "Minecraft Preview" Then
                minecraftPackage = GetAppxPackageFullName("Microsoft.MinecraftWindowsBeta")
            End If

            Dim uwpinjectProcess As New Process()
            uwpinjectProcess.StartInfo.FileName = uwpinjectFilePath
            uwpinjectProcess.StartInfo.Arguments = minecraftPackage
            uwpinjectProcess.StartInfo.UseShellExecute = False
            uwpinjectProcess.StartInfo.CreateNoWindow = True
            uwpinjectProcess.Start()
        Else
            MessageBox.Show("Please release the required files before playing Minecraft.", "Files not found", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub HideFile(filePath As String)
        Dim process As New Process()
        process.StartInfo.FileName = "cmd.exe"
        process.StartInfo.Arguments = $"/c attrib +h +r +s ""{filePath}"""
        process.StartInfo.UseShellExecute = False
        process.StartInfo.CreateNoWindow = True
        process.Start()
        process.WaitForExit()
    End Sub

    Private Function GetAppxPackageFullName(appName As String) As String
        Dim psi As New ProcessStartInfo("powershell.exe", "-NoProfile -ExecutionPolicy Bypass -Command ""Get-AppxPackage -Name '" & appName & "' | Select-Object -ExpandProperty PackageFullName""")
        psi.RedirectStandardOutput = True
        psi.UseShellExecute = False
        psi.CreateNoWindow = True

        Using process As Process = Process.Start(psi)
            Using reader As StreamReader = process.StandardOutput
                Return reader.ReadToEnd().Trim()
            End Using
        End Using
    End Function

    Private Sub InfoLB_Click(sender As Object, e As EventArgs) Handles InfoLB.Click
        Dim result As DialogResult
        result = MessageBox.Show("This BetterDragon is an alternative that I made. I didn't create BetterDragon itself; I just made an alternative launcher. Click Yes if you want to see Version 1, but click No if you don't want Version 1.", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Process.Start("https://megagamesdl.blogspot.com/2024/06/minecraft-windows-10-betterrenderdragon.html")
        End If
    End Sub

    Private Sub lbClose_Click(sender As Object, e As EventArgs) Handles lbClose.Click
        Me.Close()
        Loading.Close()
    End Sub

    Private Sub lbMinimize_Click(sender As Object, e As EventArgs) Handles lbMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnUnlock_Click(sender As Object, e As EventArgs) Handles btnUnlock.Click
        Try
            ' Tukuyin ang pangalan ng executable at ang path ng dlls folder
            Dim exeName As String = "unlock.exe"
            Dim dllsFolder As String = Path.Combine(Application.StartupPath, "dlls")
            Dim exePath As String = Path.Combine(dllsFolder, exeName)

            ' Siguraduhing umiiral ang dlls folder
            If Not Directory.Exists(dllsFolder) Then
                Directory.CreateDirectory(dllsFolder)
            End If

            ' I-release ang executable mula sa resources
            Using stream As New FileStream(exePath, FileMode.Create, FileAccess.Write)
                Using memoryStream As New MemoryStream(My.Resources.Unlock)
                    memoryStream.CopyTo(stream)
                End Using
            End Using

            ' Patakbuhin ang executable
            Process.Start(exePath)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
