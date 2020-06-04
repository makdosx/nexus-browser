'
' Copyright (c) 2020 Barchampas Gerasimos <makindosx@gmail.com>.
' nexus-browser is a anonymous and vpn browser.
'
' nexus-browser Is free software: you can redistribute it And/Or modify
' it under the terms of the GNU Affero General Public License as
' published by the Free Software Foundation, either version 3 of the
' License, Or (at your option) any later version.
'
'
' nexus-browser Is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE. See the
' GNU Affero General Public License for more details.
'
' You should have received a copy of the GNU Affero General Public License, version 3,
' along with this program.  If Not, see <http://www.gnu.org/licenses/>
'
'

Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
      
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Process.Start("nexus.exe")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.GoHome()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub WebBrowser1_DocumentCompleted_1(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        'WebBrowser1.Navigate("https://www.microsoft.com")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        WebBrowser1.Print()
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button7.PerformClick()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub TableLayoutPanel1_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        WebBrowser1.Url = New Uri("https://www.microsoft.com/en-us")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        WebBrowser1.Url = New Uri("https://www.bing.com/")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        WebBrowser1.Url = New Uri("https://duckduckgo.com/")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        WebBrowser1.Url = New Uri("https://yandex.com/")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        WebBrowser1.Url = New Uri("https://www.google.com/")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        WebBrowser1.Url = New Uri("https://www.bing.com/search?q=twitter")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        WebBrowser1.Url = New Uri("https://www.facebook.com/")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        WebBrowser1.Url = New Uri("https://www.instagram.com/")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        WebBrowser1.Url = New Uri("https://www.tiktok.com/")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        WebBrowser1.Url = New Uri("https://www.yahoo.com/")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        WebBrowser1.Url = New Uri("https://www.youtube.com/")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        WebBrowser1.Url = New Uri("https://www.bing.com/search?q=dailymotion")
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        WebBrowser1.Url = New Uri("https://www.wikipedia.org/")
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        WebBrowser1.Url = New Uri("https://www.skype.com/el/free-conference-call/")
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        WebBrowser1.Url = New Uri("https://www.messenger.com/")
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        WebBrowser1.Url = New Uri("https://www.thetimes.co.uk/")
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        WebBrowser1.Url = New Uri("https://www.nytimes.com/")
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
