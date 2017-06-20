<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listarparcelas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitularcatastralDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CDRDSparcela = New CDR.CDRDSparcela()
        Me.ParcelasTableAdapter2 = New CDR.CDRDSparcelaTableAdapters.parcelasTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CDRDSparcela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.TitularcatastralDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.DataGridView1.DataSource = Me.BindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1084, 297)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "referenciacatastral"
        Me.DataGridViewTextBoxColumn1.HeaderText = "referenciacatastral"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 104
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "provincia"
        Me.DataGridViewTextBoxColumn2.HeaderText = "provincia"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 104
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "municipio"
        Me.DataGridViewTextBoxColumn3.HeaderText = "municipio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 104
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "poligono"
        Me.DataGridViewTextBoxColumn4.HeaderText = "poligono"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 104
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "parcela"
        Me.DataGridViewTextBoxColumn5.HeaderText = "parcela"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 104
        '
        'TitularcatastralDataGridViewTextBoxColumn
        '
        Me.TitularcatastralDataGridViewTextBoxColumn.DataPropertyName = "titularcatastral"
        Me.TitularcatastralDataGridViewTextBoxColumn.HeaderText = "titularcatastral"
        Me.TitularcatastralDataGridViewTextBoxColumn.Name = "TitularcatastralDataGridViewTextBoxColumn"
        Me.TitularcatastralDataGridViewTextBoxColumn.Width = 105
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "arrendatario"
        Me.DataGridViewTextBoxColumn6.HeaderText = "arrendatario"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 104
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "superficie"
        Me.DataGridViewTextBoxColumn7.HeaderText = "superficie"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 104
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "pago"
        Me.DataGridViewTextBoxColumn8.HeaderText = "pago"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 104
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "observaciones"
        Me.DataGridViewTextBoxColumn9.HeaderText = "observaciones"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 104
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "parcelas"
        Me.BindingSource1.DataSource = Me.CDRDSparcela
        '
        'CDRDSparcela
        '
        Me.CDRDSparcela.DataSetName = "CDRDSparcela"
        Me.CDRDSparcela.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ParcelasTableAdapter2
        '
        Me.ParcelasTableAdapter2.ClearBeforeFill = True
        '
        'listarparcelas
        '
        Me.ClientSize = New System.Drawing.Size(1108, 321)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "listarparcelas"
        Me.Text = "Lista de Parcelas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CDRDSparcela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CDRDataSetBindingSource As BindingSource
    Friend WithEvents DataGridViewParcelas As DataGridView
    Friend WithEvents CDRDataSetBindingSource1 As BindingSource
    Friend WithEvents CDRDataSet1 As CDRDSMiembros
    Friend WithEvents ParcelasBindingSource As BindingSource
    Friend WithEvents CDRDataSet2 As CDRDSparcela
    Friend WithEvents ParcelasBindingSource1 As BindingSource
    Friend WithEvents ReferenciacatastralDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvinciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MunicipioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PoligonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ParcelaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents titularcatastral As DataGridViewTextBoxColumn
    Friend WithEvents ArrendatarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuperficieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CDRDSparcela As CDRDSparcela
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents ParcelasTableAdapter2 As CDRDSparcelaTableAdapters.parcelasTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents TitularcatastralDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
End Class
