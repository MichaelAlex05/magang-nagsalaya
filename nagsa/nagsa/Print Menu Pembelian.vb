﻿Imports MySql.Data.MySqlClient
Public Class Print_Menu_Pembelian
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String
    Private Sub Print_Menu_Pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "select * from detail_pembelian,pembelian where pembelian.no_nota_pembelian ='" + Formpembelian.tb_nonota.Text.ToString + "' and detail_pembelian.no_nota_pembelian = pembelian.no_nota_pembelian and pembelian.`delete`=0"
        Me.apotikDataSet.Clear()
        conn.Open()
        comm = New MySqlCommand(query, conn)
        adapt.SelectCommand = comm
        adapt.Fill(Me.apotikDataSet.penjualan)
        comm.Dispose()
        adapt.Dispose()
        conn.Close()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class