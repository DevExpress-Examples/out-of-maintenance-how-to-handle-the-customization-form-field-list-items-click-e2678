using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid.Customization;

namespace WindowsApplication53
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateTable();
            pivotGridControl1.RefreshData();
            pivotGridControl1.BestFit();
            pivotGridControl1.FieldsCustomization(panel1 );
        }
        private void PopulateTable()
        {
            DataTable myTable = dataSet1.Tables["Data"];
            myTable.Rows.Add(new object[] {"Aaa", DateTime.Today, 7});
            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddDays(1), 4 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today, 12 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddDays(1), 14 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today, 11 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today.AddDays(1), 10 });

            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddYears(1), 4 });
            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddYears(1).AddDays(1), 2 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddYears(1), 3 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddDays(1).AddYears(1), 1 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today.AddYears(1), 8 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today.AddDays(1).AddYears(1), 22 });
        }

        Form _customizationForm;
        private void pivotGridControl1_ShowingCustomizationForm(object sender, DevExpress.XtraPivotGrid.CustomizationFormShowingEventArgs e)
        {
            _customizationForm = e.CustomizationForm;
        }

        private void pivotGridControl1_ShowCustomizationForm(object sender, EventArgs e)
        {
            if (_customizationForm != null)
            {
                List<ListBoxControl> listControls = new List<ListBoxControl>();
                FindListBox(_customizationForm, listControls);
                foreach (ListBoxControl listBox in listControls)
                {
                    listBox.MouseClick += new MouseEventHandler(listBox_MouseClick);
                }
                listControls.Clear();
            }
        }

        private void pivotGridControl1_HideCustomizationForm(object sender, EventArgs e)
        {
            if (_customizationForm != null)
            {
                List<ListBoxControl> listControls = new List<ListBoxControl>();
                FindListBox(_customizationForm, listControls);
                foreach (ListBoxControl listBox in listControls)
                {
                    listBox.MouseClick -= new MouseEventHandler(listBox_MouseClick);
                }
                listControls.Clear();
                _customizationForm = null;
            }
        }

        void listBox_MouseClick(object sender, MouseEventArgs e)
        {
            ListBoxControl listBox = sender as ListBoxControl;
            PivotCustomizationTreeNodeBase treeNode = listBox.SelectedItem as PivotCustomizationTreeNodeBase;
            if (treeNode != null)
                this.Text = treeNode.Field.ToString();
        }

        private void FindListBox(Control parentControl, List<ListBoxControl> listControls)
        {
            foreach (Control c in parentControl.Controls )
            {
                ListBoxControl listBox = c as ListBoxControl;
                if (listBox != null && !listControls.Contains(listBox)) 
                    listControls.Add(listBox);                
                if (c is SplitContainer)
                {
                    SplitContainer splitContainer = c as SplitContainer;
                    FindListBox(splitContainer.Panel1, listControls);
                    FindListBox(splitContainer.Panel2, listControls);                                        
                }
                FindListBox(c, listControls);               
            }
        }

       
        
        
       
    }
}