﻿Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms


Public Class conexion
    

    Public conexion As SqlConnection = New SqlConnection("Data Source=GIRO\SQLEX2014;Initial Catalog=SistemaAAM;Uid=sa; Pwd=Pa55word;")

    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public dr As SqlDataReader

    Public Sub Conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conectado")

        Catch ex As Exception
            MessageBox.Show("Error al conectar: " + ex.ToString)
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
        conexion.Close()
    End Sub
    Function Busca(ByVal sql) As Boolean
        Dim resultado As Boolean = False
        Try
            conexion.Open()
            comando = New SqlCommand(sql, conexion)
            dr = comando.ExecuteReader
            If dr.Read Then
                resultado = True

            End If
            dr.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error en el procedimiento: " + ex.ToString)
        End Try
        Return resultado
    End Function

    Function Insertar(ByVal sql)
        Try
            conexion.Open()
            comando = New SqlCommand(sql, conexion)
            Dim i As Integer = comando.ExecuteNonQuery()
            conexion.Close()
            If (i > 0) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error al agregar: " + ex.ToString)
        End Try


    End Function
    Public Sub Consulta_join(ByVal sql As String, ByVal tb1 As String, ByVal tb2 As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tb1 + tb2)
        conexion.Close()
    End Sub
    Function Eliminar(ByVal tabla, ByVal condicion)
        conexion.Open()
        Dim elimina As String = "delete from " + tabla + " where " + condicion
        comando = New SqlCommand(elimina, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    Function Actualizar(ByVal tabla, ByVal campos, ByVal condicion)
        conexion.Open()
        Dim actualiza As String = "update " + tabla + "set " + campos + " where " + condicion
        comando = New SqlCommand(actualiza, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class


