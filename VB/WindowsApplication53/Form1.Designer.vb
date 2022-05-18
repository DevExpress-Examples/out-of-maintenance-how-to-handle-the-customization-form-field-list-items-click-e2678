Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication53
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding6 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.dataSet1 = New System.Data.DataSet()
            Me.dataTable1 = New System.Data.DataTable()
            Me.dataColumn1 = New System.Data.DataColumn()
            Me.dataColumn2 = New System.Data.DataColumn()
            Me.dataColumn3 = New System.Data.DataColumn()
            Me.fieldName1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldDate2 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldValue3 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldValue = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldValue1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldDate = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.panel1 = New System.Windows.Forms.Panel()
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
            Me.pivotGridControl1.DataMember = "Data"
            Me.pivotGridControl1.DataSource = Me.dataSet1
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldName1, Me.fieldDate2, Me.fieldValue3, Me.fieldValue, Me.fieldValue1, Me.fieldDate})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.Size = New System.Drawing.Size(439, 410)
            Me.pivotGridControl1.TabIndex = 0
            '
            'dataSet1
            '
            Me.dataSet1.DataSetName = "NewDataSet"
            Me.dataSet1.Tables.AddRange(New System.Data.DataTable() {Me.dataTable1})
            '
            'dataTable1
            '
            Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.dataColumn1, Me.dataColumn2, Me.dataColumn3})
            Me.dataTable1.TableName = "Data"
            '
            'dataColumn1
            '
            Me.dataColumn1.ColumnName = "Name"
            '
            'dataColumn2
            '
            Me.dataColumn2.ColumnName = "Date"
            Me.dataColumn2.DataType = GetType(Date)
            '
            'dataColumn3
            '
            Me.dataColumn3.ColumnName = "Value"
            Me.dataColumn3.DataType = GetType(Decimal)
            '
            'fieldName1
            '
            Me.fieldName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldName1.AreaIndex = 0
            DataSourceColumnBinding1.ColumnName = "Name"
            Me.fieldName1.DataBinding = DataSourceColumnBinding1
            Me.fieldName1.Name = "fieldName1"
            '
            'fieldDate2
            '
            Me.fieldDate2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldDate2.AreaIndex = 0
            Me.fieldDate2.Caption = "Year"
            DataSourceColumnBinding2.ColumnName = "Date"
            DataSourceColumnBinding2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldDate2.DataBinding = DataSourceColumnBinding2
            Me.fieldDate2.Name = "fieldDate2"
            Me.fieldDate2.Visible = False
            '
            'fieldValue3
            '
            Me.fieldValue3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldValue3.AreaIndex = 0
            Me.fieldValue3.Caption = "Sum"
            DataSourceColumnBinding3.ColumnName = "Value"
            Me.fieldValue3.DataBinding = DataSourceColumnBinding3
            Me.fieldValue3.Name = "fieldValue3"
            '
            'fieldValue
            '
            Me.fieldValue.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldValue.AreaIndex = 1
            Me.fieldValue.Caption = "Count"
            DataSourceColumnBinding4.ColumnName = "Value"
            Me.fieldValue.DataBinding = DataSourceColumnBinding4
            Me.fieldValue.Name = "fieldValue"
            Me.fieldValue.Visible = False
            '
            'fieldValue1
            '
            Me.fieldValue1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldValue1.AreaIndex = 1
            Me.fieldValue1.Caption = "Average"
            DataSourceColumnBinding5.ColumnName = "Value"
            Me.fieldValue1.DataBinding = DataSourceColumnBinding5
            Me.fieldValue1.Name = "fieldValue1"
            Me.fieldValue1.Visible = False
            '
            'fieldDate
            '
            Me.fieldDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldDate.AreaIndex = 0
            Me.fieldDate.Caption = "Date"
            DataSourceColumnBinding6.ColumnName = "Date"
            DataSourceColumnBinding6.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.[Date]
            Me.fieldDate.DataBinding = DataSourceColumnBinding6
            Me.fieldDate.Name = "fieldDate"
            Me.fieldDate.Visible = False
            '
            'panel1
            '
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel1.Location = New System.Drawing.Point(439, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(265, 410)
            Me.panel1.TabIndex = 1
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(704, 410)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn2 As System.Data.DataColumn
		Private dataColumn3 As System.Data.DataColumn
		Private fieldName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldDate2 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldValue3 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldValue As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldValue1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldDate As DevExpress.XtraPivotGrid.PivotGridField
		Private panel1 As System.Windows.Forms.Panel
	End Class
End Namespace

