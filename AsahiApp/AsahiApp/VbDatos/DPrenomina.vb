﻿Imports Clases
Imports System.Data.SqlClient
Imports System
Public Class DPrenomina
    Public Function RecuperarDiasSemana(ByVal oCon As SqlConnection, ByVal fecha As Date) As Horarios
        Dim hrs As New Horarios()
        Try
            oCon.Open()
            Dim query As New SqlCommand("LRegresarFechas", oCon)
            query.Parameters.AddWithValue("@fecha", fecha)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 60

            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                hrs.FechaI = Convert.ToDateTime(dr("fechaI").ToString)
                hrs.FechaF = Convert.ToDateTime(dr("fechaF").ToString)
                hrs.Semana = Convert.ToInt32(dr("semana").ToString)
                hrs.Año = Convert.ToInt32(dr("año").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return hrs
    End Function
    Public Function HorasChecadasSemanal() As Horarios
        Dim hrs As New Horarios()
        Return hrs
    End Function
    Public Function RecuperarAusentismo(ByVal cadConex As String, ByVal fechaI As Date, ByVal fechaF As Date) As LAusentismo
        Dim oCon As New SqlConnection(cadConex)
        Dim lstAus As New LAusentismo()
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT Empaus.CLAVE /1 ID, Empaus.DURACION, Empaus.FECHAI, Empaus.FECHAF, Empaus.TIPO FROM asahi16.Supervisor_giro.Empaus Empaus WHERE (Empaus.FECHAI>= " + "'" + fechaI + "'" + ") and (Empaus.FECHAI<= " + "'" + fechaF + "'" + ")", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                Dim aus As New Ausentismo
                aus.IdEmpleado = Convert.ToInt32(dr("ID").ToString)
                aus.Duracion = Convert.ToInt32(dr("DURACION").ToString)
                aus.FechaI = Convert.ToDateTime(dr("FECHAI").ToString)
                aus.FechaF = Convert.ToDateTime(dr("FECHAF").ToString)
                aus.TipoAusentismo = dr("TIPO").ToString
                lstAus.Add(aus)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstAus
    End Function
    Public Function RecuperarVacaciones(ByVal cadConex As String, ByVal fechaI As Date, ByVal fechaF As Date) As LVacaciones
        Dim oCon As New SqlConnection(cadConex)
        Dim lstVac As New LVacaciones()
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT Empvaca.CLAVE/1 AS ID, Empvaca.FECHA, Empvaca.DURACION, Empvaca.FECHA_FINAL FROM asahi16.Supervisor_giro.Empvaca Empvaca WHERE (Empvaca.FECHA>= " + "'" + fechaI + "'" + ") and (Empvaca.FECHA<= " + "'" + fechaF + "'" + ")", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                Dim vac As New Vacaciones
                vac.IdEmpleado = Convert.ToInt32(dr("ID").ToString)
                vac.Duracion = Convert.ToInt32(dr("DURACION").ToString)
                vac.FechaI = Convert.ToDateTime(dr("FECHA").ToString)
                vac.FechaF = Convert.ToDateTime(dr("FECHA_FINAL").ToString)
                lstVac.Add(vac)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstVac
    End Function
    Public Function RecuperarIncapacidades(ByVal cadConex As String) As LIncapacidad
        Dim oCon As New SqlConnection(cadConex)
        Dim lstInc As New LIncapacidad()
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT CLAVE/1 ID,FECHA,ID NUM,DURACION,NUMERO,TIPO,CASO,FECHA_TERMINO FECHAF, isnull(SECUELA,'') SECUELA FROM asahi16.Supervisor_giro.Empinc ORDER BY CLAVE, FECHA DESC", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                Dim inc As New Incapacidad()
                inc.IdEmpleado = Convert.ToInt32(dr("ID").ToString)
                inc.FechaI = Convert.ToDateTime(dr("FECHA").ToString)
                inc.Num = Convert.ToInt32(dr("NUM").ToString)
                inc.Duracion = Convert.ToInt32(dr("DURACION").ToString)
                inc.Numero = dr("NUMERO").ToString
                inc.Tipo = dr("TIPO").ToString
                inc.Caso = dr("CASO").ToString
                inc.FechaF = Convert.ToDateTime(dr("FECHAF").ToString)
                inc.Secuela = dr("SECUELA").ToString
                lstInc.Add(inc)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstInc
    End Function
    Public Function RecuperarHorasExtra(ByVal cadConex As String, ByVal fechaI As Date, ByVal fechaF As Date) As LHorasExtra
        Dim oCon As New SqlConnection(cadConex)
        Dim lstHrsEx As New LHorasExtra()
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT EmpHE.CLAVE/1 ID, EmpHE.TIPO, EmpHE.MONTO, ISNULL(EmpHE.AUTORIZADO,'') AUTORIZADO, EmpHE.FECHA, ISNULL(EmpHE.TIPO_PERMISO,'') TIPOPERMISO FROM asahi16.Supervisor_giro.EmpHE EmpHE WHERE (EmpHE.FECHA>= " + "'" + fechaI + "'" + " and EmpHE.FECHA<= " + "'" + fechaF + "'" + ") ORDER BY TIPO, ID", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                Dim hrsExt As New HorasExtra()
                hrsExt.IdEmpleado = Convert.ToInt32(dr("ID").ToString)
                hrsExt.Tipo = dr("TIPO").ToString
                hrsExt.Monto = Convert.ToInt32(dr("MONTO").ToString)
                hrsExt.Autorizado = Convert.ToInt32(dr("AUTORIZADO").ToString)
                hrsExt.Fecha = Convert.ToDateTime(dr("FECHA").ToString)
                hrsExt.TipoPermiso = dr("TIPOPERMISO").ToString
                lstHrsEx.Add(hrsExt)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstHrsEx
    End Function
    Public Function RecuperarBajas(ByVal cadConex As String, ByVal fechaI As Date, ByVal fechaF As Date) As LBaja
        Dim lstBja As New LBaja()
        Dim oCon As New SqlConnection(cadConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT Empsdo.CLAVE/1 AS ID, Empsdo.FECHA, Empsdo.TIPO, Empsdo.CAUSA_BAJA CAUSABAJA FROM asahi16.Supervisor_giro.Empsdo Empsdo WHERE (Empsdo.FECHA>= " + "'" + fechaI + "'" + "  And Empsdo.FECHA<= " + "'" + fechaF + "'" + ") AND (Empsdo.TIPO='B') ORDER BY Empsdo.CLAVE", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim baja As New Baja()
                baja.IdEmpleado = Convert.ToInt32(dr("ID").ToString)
                baja.Fecha = Convert.ToDateTime(dr("FECHA").ToString)
                baja.TipoBaja = dr("TIPO").ToString
                baja.CausaBaja = dr("CAUSABAJA").ToString
                lstBja.Add(baja)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstBja
    End Function
    Public Function RecuperarComedor(ByVal cadConex As String, ByVal fechaI As Date, ByVal fechaF As Date) As LComedor
        Dim lstCom As New LComedor()
        Dim oCon As New SqlConnection(cadConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT Empcome.CLAVE/1 ID, Empcome.FECHA, Empcome.HORA, ISNULL(Empcome.TIPO,'') TIPO FROM asahi16.Supervisor_giro.Empcome Empcome WHERE (Empcome.FECHA>= " + "'" + fechaI + "'" + " And Empcome.FECHA<= " + "'" + fechaF + "'" + ")", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim come As New Comedor()
                come.IdEmpleado = Convert.ToInt32(dr("ID").ToString)
                come.FechaComedor = Convert.ToDateTime(dr("FECHA").ToString)
                come.HoraComedor = Convert.ToDateTime(dr("HORA").ToString)
                come.TipoComida = Convert.ToInt32(dr("TIPO").ToString)
                lstCom.Add(come)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstCom
    End Function
    Public Sub InsertarModificacionesIncidencias(ByVal cadenaConex As String, ByVal objEmp As Empleado)
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("rh_Insertar_Incidencias_Modificadas", oCon)
            query.Parameters.AddWithValue("@XML", objEmp.Xml)
            query.CommandType = CommandType.StoredProcedure
            query.ExecuteScalar() 'En un Insert de XML, NO olvidar esta línea si no, no inserta mi madres

            MsgBox("Registros insertados en temporal")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
    End Sub
    Public Function RecuperarInc(ByVal cadenaConex As String, ByVal tipoM As String, ByVal sem As Integer, ByVal fechaI As Date, ByVal fechaF As Date) As LEmpleado
        Dim LstEmp As New LEmpleado()
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            Dim empleados As New Empleado
            empleados.Err = True
            LstEmp.Add(empleados)
            oCon.Open()
            Dim query As New SqlCommand("select rim.IdEmpleado,rim.fecha,rim.fechaModif,rim.incidencia1,rim.incidencia2,rim.tipoModificacion1,rim.tipoModificacion2,rim.horaEntrada,rim.horaSalida,rim.turno from rh_incidencias_Modificadas rim where rim.tipoModificacion1 = '" & tipoM & "' and (rim.semana = " & sem & " and (rim.fecha >= '" & fechaI & "' and rim.fecha <= '" & fechaF & "'))", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim emp As New Empleado
                emp.IdEmpleado = Convert.ToInt32(dr("IdEmpleado").ToString)
                emp.Fecha1 = Convert.ToDateTime(dr("fecha").ToString)
                emp.Fecha2 = Convert.ToDateTime(dr("fechaModif").ToString)
                emp.Incidencia1 = dr("incidencia1").ToString
                emp.Incidencia2 = dr("incidencia2").ToString
                emp.TipoIncidencia1 = dr("tipoModificacion1").ToString
                emp.TipoIncidencia2 = dr("tipoModificacion2").ToString
                emp.HoraEntrada = Convert.ToDateTime(dr("horaEntrada").ToString)
                emp.HoraSalida = Convert.ToDateTime(dr("horaSalida").ToString)
                emp.IdTurno = Convert.ToInt32(dr("turno").ToString)
                emp.Err = False
                LstEmp.Add(emp)
                LstEmp.Item(0).Err = False
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return LstEmp
    End Function
    Public Sub InsertarModificacionesAusentismo(ByVal cadenaConex As String, objEmp As Empleado)
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("rh_Incidencias_Ausentismo", oCon)
            query.Parameters.AddWithValue("@XML", objEmp.Xml)
            query.CommandType = CommandType.StoredProcedure
            query.ExecuteScalar() 'En un Insert de XML, NO olvidar esta línea si no, no inserta mi madres

            MsgBox("Ausentismos insertados")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
    End Sub
    Public Sub InsertarModificacionesHE(ByVal cadenaConex As String, objEmp As Empleado)
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("rh_Incidencias_HE", oCon)
            query.Parameters.AddWithValue("@XML", objEmp.Xml)
            query.CommandType = CommandType.StoredProcedure
            query.ExecuteScalar() 'En un Insert de XML, NO olvidar esta línea si no, no inserta mi madres

            MsgBox("Incidencias insertadas")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
    End Sub
    Public Sub InsertarModificacionesChecadas(ByVal cadenaConex As String, ByVal objEmp As Empleado)
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("rh_Incidencias_Checadas", oCon)
            query.Parameters.AddWithValue("@XML", objEmp.Xml)
            query.CommandType = CommandType.StoredProcedure
            query.ExecuteScalar()

            MsgBox("Checadas insertadas")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
    End Sub
End Class