﻿Imports Datos
Imports Clases
Public Class NEmpleado
    Public Function EmpleadoLogin(ByVal cadConex As String, ByVal us As String, ByVal pass As String) As Integer
        Dim DEmp As New DEmpleado()
        Return DEmp.EmpleadoLogin(cadConex, us, pass)
    End Function
    Public Function RecuperarDepartamentos(ByVal cadenaConex As String) As LEmpleado
        Dim DEmp As New DEmpleado()
        Return DEmp.RecuperarDepartamentos(cadenaConex)
    End Function
    Public Function RecuperarEmpleadosDepto(ByVal cadenaConex As String, ByVal idDepto As Integer, ByVal fecha As Date, ByVal semana As Integer, ByVal año As Integer) As LEmpleado
        Dim DEmp As New DEmpleado()
        Return DEmp.RecuperarEmpleadosDepto(cadenaConex, idDepto, fecha, semana, año)
    End Function
End Class
