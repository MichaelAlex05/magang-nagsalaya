﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formreportpiutang
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.apotikDataSet = New WindowsApplication1.apotikDataSet()
        Me.piutangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.piutangTableAdapter = New WindowsApplication1.apotikDataSetTableAdapters.piutangTableAdapter()
        CType(Me.apotikDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piutangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.piutangBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report7.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(704, 371)
        Me.ReportViewer1.TabIndex = 0
        '
        'apotikDataSet
        '
        Me.apotikDataSet.DataSetName = "apotikDataSet"
        Me.apotikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'piutangBindingSource
        '
        Me.piutangBindingSource.DataMember = "piutang"
        Me.piutangBindingSource.DataSource = Me.apotikDataSet
        '
        'piutangTableAdapter
        '
        Me.piutangTableAdapter.ClearBeforeFill = True
        '
        'Formreportpiutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 395)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Formreportpiutang"
        Me.Text = "Form2"
        CType(Me.apotikDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piutangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents piutangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents apotikDataSet As WindowsApplication1.apotikDataSet
    Friend WithEvents piutangTableAdapter As WindowsApplication1.apotikDataSetTableAdapters.piutangTableAdapter
End Class
