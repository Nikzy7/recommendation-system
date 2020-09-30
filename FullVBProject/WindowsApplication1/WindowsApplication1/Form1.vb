Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using sw As StreamWriter = New StreamWriter("ip.txt")
            sw.WriteLine(TextBox1.Text)
        End Using



        Process.Start("cmd", "/c python Source.py")
        Timer1.Enabled = True



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("op.txt")
        Label2.Text = fileReader
        Timer1.Enabled = False
    End Sub

End Class
