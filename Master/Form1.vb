Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButterscotchTheme1_Click(sender As Object, e As EventArgs) Handles ButterscotchTheme1.Click

    End Sub

    Private Sub ButterscotchButton1_Click(sender As Object, e As EventArgs) Handles ButterscotchButton1.Click
        Try
            If (Me.TextBox1.Text = "") Then
                Interaction.MsgBox("Please Add Host !!", MsgBoxStyle.Information, Nothing)
            End If
            Dim addressList As IPAddress() = Dns.GetHostByName(Me.TextBox1.Text).AddressList
            Me.TextBox2.Text = addressList(0).ToString
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
    End Sub
End Class
