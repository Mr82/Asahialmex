﻿Imports System.Windows.Forms
Imports CsPresentacion
Public Class FrmPrincipal
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnPreNomina_Click(sender As Object, e As EventArgs) Handles BtnPreNomina.Click
        Dim prenomina As New FrmPrenomina()
        prenomina.Show()
    End Sub

    Private Sub BtnControlProduc_Click(sender As Object, e As EventArgs) Handles BtnControlProduc.Click
        Dim Control As New FrmProduccion()
        Control.Show()
    End Sub
End Class

