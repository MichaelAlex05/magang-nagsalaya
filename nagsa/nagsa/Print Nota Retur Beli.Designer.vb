﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Print_Nota_Retur_Beli
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.apotikDataSet = New WindowsApplication1.apotikDataSet()
        Me.detail_retur_beliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.detail_retur_beliTableAdapter = New WindowsApplication1.apotikDataSetTableAdapters.detail_retur_beliTableAdapter()
        Me.retur_pembelianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.retur_pembelianTableAdapter = New WindowsApplication1.apotikDataSetTableAdapters.retur_pembelianTableAdapter()
        CType(Me.apotikDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.detail_retur_beliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.retur_pembelianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.detail_retur_beliBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.retur_pembelianBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report24.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 13)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(756, 375)
        Me.ReportViewer1.TabIndex = 0
        '
        'apotikDataSet
        '
        Me.apotikDataSet.DataSetName = "apotikDataSet"
        Me.apotikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'detail_retur_beliBindingSource
        '
        Me.detail_retur_beliBindingSource.DataMember = "detail_retur_beli"
        Me.detail_retur_beliBindingSource.DataSource = Me.apotikDataSet
        '
        'detail_retur_beliTableAdapter
        '
        Me.detail_retur_beliTableAdapter.ClearBeforeFill = True
        '
        'retur_pembelianBindingSource
        '
        Me.retur_pembelianBindingSource.DataMember = "retur_pembelian"
        Me.retur_pembelianBindingSource.DataSource = Me.apotikDataSet
        '
        'retur_pembelianTableAdapter
        '
        Me.retur_pembelianTableAdapter.ClearBeforeFill = True
        '
        'Print_Nota_Retur_Beli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 400)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Print_Nota_Retur_Beli"
        Me.Text = "Print_Nota_Retur_Beli"
        CType(Me.apotikDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.detail_retur_beliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.retur_pembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents detail_retur_beliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents apotikDataSet As WindowsApplication1.apotikDataSet
    Friend WithEvents detail_retur_beliTableAdapter As WindowsApplication1.apotikDataSetTableAdapters.detail_retur_beliTableAdapter
    Friend WithEvents retur_pembelianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents retur_pembelianTableAdapter As WindowsApplication1.apotikDataSetTableAdapters.retur_pembelianTableAdapter
End Class
