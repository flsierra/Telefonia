Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Public Module Module1
    Public contDept As Integer
    Public contMun As Integer
    Public cnn As SqlConnection
    Public Function ejecutar(ByVal consulta As String)
        Try
            If cnn.State = ConnectionState.Open Then
                Dim cmd As SqlCommand
                cmd = New SqlCommand
                cmd.Connection = cnn
                cmd.CommandText = consulta
                cmd.ExecuteNonQuery()
                cnn.Close()
                MsgBox("Registro actualizado", MsgBoxStyle.Information, "Información")
            Else
                cnn.Open()
                Dim cmd As SqlCommand
                cmd = New SqlCommand
                cmd.Connection = cnn
                cmd.CommandText = consulta
                cmd.ExecuteNonQuery()
                cnn.Close()
                MsgBox("Registro actualizado", MsgBoxStyle.Information, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Exclamation, "Error")
        End Try
    End Function
End Module
