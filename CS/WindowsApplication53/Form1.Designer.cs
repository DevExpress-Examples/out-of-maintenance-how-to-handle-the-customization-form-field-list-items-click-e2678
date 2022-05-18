namespace WindowsApplication53
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding1 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding2 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding3 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding4 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding5 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding6 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.fieldName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDate2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldValue3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldValue = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldValue1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl1.DataMember = "Data";
            this.pivotGridControl1.DataSource = this.dataSet1;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldName1,
            this.fieldDate2,
            this.fieldValue3,
            this.fieldValue,
            this.fieldValue1,
            this.fieldDate});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007;
            this.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.pivotGridControl1.Size = new System.Drawing.Size(439, 410);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.ShowingCustomizationForm += new DevExpress.XtraPivotGrid.CustomizationFormShowingEventHandler(this.pivotGridControl1_ShowingCustomizationForm);
            this.pivotGridControl1.ShowCustomizationForm += new System.EventHandler(this.pivotGridControl1_ShowCustomizationForm);
            this.pivotGridControl1.HideCustomizationForm += new System.EventHandler(this.pivotGridControl1_HideCustomizationForm);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3});
            this.dataTable1.TableName = "Data";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Name";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Date";
            this.dataColumn2.DataType = typeof(System.DateTime);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Value";
            this.dataColumn3.DataType = typeof(decimal);
            // 
            // fieldName1
            // 
            this.fieldName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldName1.AreaIndex = 0;
            dataSourceColumnBinding1.ColumnName = "Name";
            this.fieldName1.DataBinding = dataSourceColumnBinding1;
            this.fieldName1.Name = "fieldName1";
            // 
            // fieldDate2
            // 
            this.fieldDate2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldDate2.AreaIndex = 0;
            this.fieldDate2.Caption = "Year";
            dataSourceColumnBinding2.ColumnName = "Date";
            dataSourceColumnBinding2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldDate2.DataBinding = dataSourceColumnBinding2;
            this.fieldDate2.Name = "fieldDate2";
            this.fieldDate2.Visible = false;
            // 
            // fieldValue3
            // 
            this.fieldValue3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldValue3.AreaIndex = 0;
            this.fieldValue3.Caption = "Sum";
            dataSourceColumnBinding3.ColumnName = "Value";
            this.fieldValue3.DataBinding = dataSourceColumnBinding3;
            this.fieldValue3.Name = "fieldValue3";
            // 
            // fieldValue
            // 
            this.fieldValue.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldValue.AreaIndex = 1;
            this.fieldValue.Caption = "Count";
            dataSourceColumnBinding4.ColumnName = "Value";
            this.fieldValue.DataBinding = dataSourceColumnBinding4;
            this.fieldValue.Name = "fieldValue";
            this.fieldValue.Visible = false;
            // 
            // fieldValue1
            // 
            this.fieldValue1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldValue1.AreaIndex = 1;
            this.fieldValue1.Caption = "Average";
            dataSourceColumnBinding5.ColumnName = "Value";
            this.fieldValue1.DataBinding = dataSourceColumnBinding5;
            this.fieldValue1.Name = "fieldValue1";
            this.fieldValue1.Visible = false;
            // 
            // fieldDate
            // 
            this.fieldDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldDate.AreaIndex = 0;
            this.fieldDate.Caption = "Date";
            dataSourceColumnBinding6.ColumnName = "Date";
            dataSourceColumnBinding6.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date;
            this.fieldDate.DataBinding = dataSourceColumnBinding6;
            this.fieldDate.Name = "fieldDate";
            this.fieldDate.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(439, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 410);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 410);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private DevExpress.XtraPivotGrid.PivotGridField fieldName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDate2;
        private DevExpress.XtraPivotGrid.PivotGridField fieldValue3;
        private DevExpress.XtraPivotGrid.PivotGridField fieldValue;
        private DevExpress.XtraPivotGrid.PivotGridField fieldValue1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDate;
        private System.Windows.Forms.Panel panel1;
    }
}

