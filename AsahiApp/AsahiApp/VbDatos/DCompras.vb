﻿Imports Clases
Imports System.Data.SqlClient

Public Class DCompras
    Public Function RecuperarLstCompras(ByVal cadenaConex As String, ByVal fi As Date, ByVal ff As Date) As LCompras
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstComp As New LCompras()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Sp_previopoliza", oCon)
            query.Parameters.AddWithValue("@fechai", fi)
            query.Parameters.AddWithValue("@fechaf", ff)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 120
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim comp As New Compras()
                comp.IdProvision = Convert.ToInt32(dr("Id_provision").ToString)
                comp.IdCompra = Convert.ToInt32(dr("Compra").ToString)
                comp.IdOrdenCompra = Convert.ToInt32(dr("Oc").ToString)
                comp.Serie = dr("Serie").ToString
                comp.Factura = dr("Factura").ToString
                comp.Proveedor = dr("Proveedor").ToString
                comp.MontoOC = Convert.ToDouble(dr("MontoOc").ToString)
                comp.MontoFact = Convert.ToDouble(dr("MontoFact").ToString)
                comp.MontoPagar = Convert.ToDouble(dr("MontoaPagar").ToString)
                comp.MontoCompra = Convert.ToDouble(dr("MontoCompra").ToString)
                comp.FechaFact = Convert.ToDateTime(dr("FechaFactura").ToString)
                comp.FechaPagoFact = Convert.ToDateTime(dr("FechaPagoFact").ToString)
                comp.FechaPagoReal = Convert.ToDateTime(dr("FechaPagoReal").ToString)
                comp.Moneda = dr("Moneda").ToString
                comp.Empresa = dr("Empresa").ToString
                comp.FechaCompra = Convert.ToDateTime(dr("FechaCompra").ToString)
                comp.UUID = dr("idfact").ToString
                comp.TazaCambio = dr("tc").ToString
                lstComp.Add(comp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstComp
    End Function
    Public Function VistaPoliza(ByVal cadenaConex As String, ByVal moneda As String, ByVal idFac As String, ByVal tc As Double) As LCompras
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstComp As New LCompras()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Sp_vistaPrincipalPoliza", oCon)
            query.Parameters.AddWithValue("@variable", moneda)
            query.Parameters.AddWithValue("@uuid", idFac)
            query.Parameters.AddWithValue("@tc", tc)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 120

            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim comp As New Compras()
                comp.Pivote = Convert.ToInt32(dr("Pivote").ToString)
                comp.IdOrdenCompra = Convert.ToInt32(dr("OC").ToString)
                comp.IdCompra = Convert.ToInt32(dr("Compra").ToString)
                comp.Serie = (dr("Serie").ToString)
                comp.Factura = (dr("Factura").ToString)
                comp.Proveedor = (dr("Proveedor").ToString)
                comp.Rfc = (dr("RFC").ToString)
                comp.TotalFactura = Convert.ToDouble(dr("Total_Factura").ToString)
                comp.CompraTotal = Convert.ToDouble(dr("CompraTotal").ToString)
                comp.FechaFact = Convert.ToDateTime(dr("Fecha_Factura").ToString)
                comp.Moneda = (dr("Moneda").ToString)
                comp.Empresa = (dr("Empresa").ToString)
                comp.RfcEmisor = (dr("RFCEmisor").ToString)
                comp.NombreEmisor = (dr("NombreEmisor").ToString)
                comp.UUID = (dr("UUID").ToString)
                comp.Total = Convert.ToDouble(dr("Total").ToString)
                comp.Area = (dr("Área").ToString)
                comp.Familia = (dr("Familia").ToString)
                comp.Cuenta = (dr("Cuenta").ToString)
                comp.Neto = Convert.ToDouble(dr("Neto").ToString)
                comp.CuentaIva = (dr("Cuenta_iva").ToString)
                comp.IvaT = Convert.ToDouble(dr("Iva_t").ToString)
                comp.CuentaP = (dr("CuentaP").ToString)
                comp.Impuesto = Convert.ToDouble(dr("Impuesto").ToString)
                lstComp.Add(comp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstComp
    End Function
    Public Function RecuperarListaProveedores(ByVal cadenaConex As String, ByVal fi As Date, ByVal ff As Date) As LCompras
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstComp As New LCompras()
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT Proveedor FROM AsahiSystem.dbo.Provisiones_compras where (FechaFactura between '" & fi & "' and '" & ff & "') AND StatusConta = 1	AND Serie = 'A' and Empresa = 'AAM' group by Proveedor", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                Dim comp As New Compras
                comp.Proveedor = dr("Proveedor").ToString
                lstComp.Add(comp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstComp
    End Function
    Public Function RecuperarListaFamilia(ByVal cadenaConex As String, ByVal uuid As String) As LCompras
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstComp As New LCompras()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Select Familia FROM conta.[Asahi].[dbo].[VistaPolizaMx] where UUID = '" & uuid & "' group by Familia", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                Dim comp As New Compras
                comp.Familia = dr("Familia").ToString
                lstComp.Add(comp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstComp
    End Function
    Public Function RecuperarListaSegNeg(ByVal cadenaConex As String, ByVal uuid As String) As LCompras
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstComp As New LCompras()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Select Área FROM conta.[Asahi].[dbo].[VistaPolizaMx] where UUID = '" & uuid & "' group by Área", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                Dim comp As New Compras
                comp.Area = dr("Área").ToString
                lstComp.Add(comp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstComp
    End Function
    Public Function RecuperarLstPorProvisionar(ByVal cadenaConex As String, ByVal fi As Date, ByVal ff As Date) As LCompras
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstComp As New LCompras()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Sp_muestraprovisionescomprasPrueba", oCon)
            query.Parameters.AddWithValue("@fecha", fi)
            query.Parameters.AddWithValue("@fecha2", ff)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 120
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim comp As New Compras()
                comp.IdProvision = Convert.ToInt32(dr("Id_provision").ToString)
                comp.Oc = dr("Oc").ToString
                comp.IdCompra = Convert.ToInt32(dr("Compra").ToString)
                comp.Factura = dr("Factura").ToString
                comp.Proveedor = dr("Proveedor").ToString
                comp.Rfc = dr("RFC").ToString
                comp.RfcEmisor = dr("RFCEmisor").ToString
                comp.Moneda = dr("Moneda").ToString
                comp.MontoOC = Convert.ToDouble(dr("MontoOc").ToString)
                comp.MontoCompra = Convert.ToDouble(dr("MontoCompra").ToString)
                comp.MontoFact = Convert.ToDouble(dr("MontoFact").ToString)
                comp.MontoPagar = Convert.ToDouble(dr("MontoaPagar").ToString)
                comp.FechaFact = Convert.ToDateTime(dr("FechaFactura").ToString)
                comp.FechaPagoFact = Convert.ToDateTime(dr("FechaPagoFact").ToString)
                comp.FechaPagoReal = Convert.ToDateTime(dr("FechaPagoReal").ToString)
                comp.Status = dr("Status").ToString
                comp.ObservaCompra = dr("ObservaCompra").ToString
                comp.ObservaConta = dr("ObservaConta").ToString
                comp.Empresa = dr("Empresa").ToString
                comp.NombreEmisor = dr("NombreEmisor").ToString
                comp.Add = dr("Add").ToString
                comp.StatusConta = dr("StatusConta").ToString
                comp.Val1 = Convert.ToInt32(dr("Val1").ToString)
                comp.Val2 = Convert.ToInt32(dr("Val2").ToString)
                comp.Val3 = Convert.ToInt32(dr("Val3").ToString)
                comp.Val4 = Convert.ToInt32(dr("Val4").ToString)
                comp.Ruta = dr("Ruta").ToString
                comp.IdOrdenCompra = Convert.ToInt32(dr("o").ToString)
                comp.Serie = dr("Serie").ToString
                comp.FechaCompra = Convert.ToDateTime(dr("FechaCompra").ToString)
                lstComp.Add(comp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstComp
    End Function
    Public Function RecuperarLstProvisionadas(ByVal cadenaConex As String, ByVal fi As Date, ByVal ff As Date) As LCompras
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstComp As New LCompras()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Sp_muestraprovisionescomprasvalidadas", oCon)
            query.Parameters.AddWithValue("@inicio", fi)
            query.Parameters.AddWithValue("@fin", ff)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 120
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim comp As New Compras()
                comp.IdProvision = Convert.ToInt32(dr("Id_provision").ToString)
                comp.StatusConta = dr("SC").ToString
                comp.Oc = dr("Oc").ToString
                comp.IdCompra = Convert.ToInt32(dr("Compra").ToString)
                comp.Factura = dr("Factura").ToString
                comp.Proveedor = dr("Proveedor").ToString
                comp.Rfc = dr("RFC").ToString
                comp.RfcEmisor = dr("RFCEmisor").ToString
                comp.Moneda = dr("Moneda").ToString
                comp.MontoOC = Convert.ToDouble(dr("MontoOc").ToString)
                comp.MontoCompra = Convert.ToDouble(dr("MontoCompra").ToString)
                comp.MontoFact = Convert.ToDouble(dr("MontoFact").ToString)
                comp.MontoPagar = Convert.ToDouble(dr("MontoaPagar").ToString)
                comp.FP = Convert.ToDateTime(dr("FP").ToString)
                comp.FechaFact = Convert.ToDateTime(dr("FechaFactura").ToString)
                comp.FechaPagoFact = Convert.ToDateTime(dr("FechaPagoFact").ToString)
                comp.StatusPago = dr("StatusPago").ToString
                comp.Status = dr("Status").ToString
                comp.ObservaCompra = dr("ObservaCompra").ToString
                comp.ObservaConta = dr("ObservaConta").ToString
                comp.Empresa = dr("Empresa").ToString
                comp.NombreEmisor = dr("NombreEmisor").ToString
                comp.Add = dr("Add").ToString
                comp.Val1 = Convert.ToInt32(dr("Val1").ToString)
                comp.Val2 = Convert.ToInt32(dr("Val2").ToString)
                comp.Val3 = Convert.ToInt32(dr("Val3").ToString)
                comp.Val4 = Convert.ToInt32(dr("Val4").ToString)
                comp.Ruta = dr("Ruta").ToString
                comp.FechaProv = Convert.ToDateTime(dr("FDP").ToString)
                comp.IdOrdenCompra = Convert.ToInt32(dr("o").ToString)
                comp.Serie = dr("Serie").ToString
                comp.UUID = dr("idfact").ToString
                lstComp.Add(comp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstComp
    End Function
    Public Sub ActualizarXml(ByVal cadenaConex As String)
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("Sp_actualizaxml", oCon)
            query.CommandType = CommandType.StoredProcedure
            query.ExecuteNonQuery()
            MsgBox("¡Actualizado con éxito!")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
    End Sub
    Public Sub ProcesoProviciones(ByVal cadenaConex As String, ByVal comp As Compras)
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("Sp_actualizaxml", oCon)
            query.Parameters.AddWithValue("@id_provision", comp.IdProvision)
            query.Parameters.AddWithValue("@factura", comp.Factura)
            query.Parameters.AddWithValue("@fecha", Date.Now())
            query.Parameters.AddWithValue("@montofact", comp.MontoFact)
            query.Parameters.AddWithValue("@fechapago", comp.FechaPagoFact)
            query.Parameters.AddWithValue("@empresa", comp.Empresa)
            query.Parameters.AddWithValue("@Oc", comp.Oc)
            query.Parameters.AddWithValue("@Proveedor", comp.Proveedor)
            query.Parameters.AddWithValue("@Serie", comp.Serie)
            query.Parameters.AddWithValue("@Estado", comp.Status)
            query.Parameters.AddWithValue("@rfcemisor", comp.Rfc)
            query.Parameters.AddWithValue("@observa", comp.IdProvision)
            query.Parameters.AddWithValue("@COMPRA", comp.IdProvision)
            query.CommandType = CommandType.StoredProcedure
            query.ExecuteNonQuery()
            MsgBox("¡Proceso realizado con éxito!")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
    End Sub
    Public Sub InsertarRuta(ByVal cadenaConex As String, ByVal comp As Compras)
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("Prov_InsertarRuta", oCon)
            query.Parameters.AddWithValue("@xml", comp.Xml)
            query.CommandType = CommandType.StoredProcedure
            query.ExecuteScalar()

            MsgBox("Se insertó correctamente")
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