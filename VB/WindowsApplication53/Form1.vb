Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid.Customization

Namespace WindowsApplication53

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            PopulateTable()
            pivotGridControl1.RefreshData()
            pivotGridControl1.BestFit()
            pivotGridControl1.FieldsCustomization(panel1)
        End Sub

        Private Sub PopulateTable()
            Dim myTable As DataTable = dataSet1.Tables("Data")
            myTable.Rows.Add(New Object() {"Aaa", Date.Today, 7})
            myTable.Rows.Add(New Object() {"Aaa", Date.Today.AddDays(1), 4})
            myTable.Rows.Add(New Object() {"Bbb", Date.Today, 12})
            myTable.Rows.Add(New Object() {"Bbb", Date.Today.AddDays(1), 14})
            myTable.Rows.Add(New Object() {"Ccc", Date.Today, 11})
            myTable.Rows.Add(New Object() {"Ccc", Date.Today.AddDays(1), 10})
            myTable.Rows.Add(New Object() {"Aaa", Date.Today.AddYears(1), 4})
            myTable.Rows.Add(New Object() {"Aaa", Date.Today.AddYears(1).AddDays(1), 2})
            myTable.Rows.Add(New Object() {"Bbb", Date.Today.AddYears(1), 3})
            myTable.Rows.Add(New Object() {"Bbb", Date.Today.AddDays(1).AddYears(1), 1})
            myTable.Rows.Add(New Object() {"Ccc", Date.Today.AddYears(1), 8})
            myTable.Rows.Add(New Object() {"Ccc", Date.Today.AddDays(1).AddYears(1), 22})
        End Sub

        Private _customizationForm As Form

        Private Sub pivotGridControl1_ShowingCustomizationForm(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.CustomizationFormShowingEventArgs)
            _customizationForm = e.CustomizationForm
        End Sub

        Private Sub pivotGridControl1_ShowCustomizationForm(ByVal sender As Object, ByVal e As EventArgs)
            If _customizationForm IsNot Nothing Then
                Dim listControls As List(Of ListBoxControl) = New List(Of ListBoxControl)()
                FindListBox(_customizationForm, listControls)
                For Each listBox As ListBoxControl In listControls
                    AddHandler listBox.MouseClick, New MouseEventHandler(AddressOf listBox_MouseClick)
                Next

                listControls.Clear()
            End If
        End Sub

        Private Sub pivotGridControl1_HideCustomizationForm(ByVal sender As Object, ByVal e As EventArgs)
            If _customizationForm IsNot Nothing Then
                Dim listControls As List(Of ListBoxControl) = New List(Of ListBoxControl)()
                FindListBox(_customizationForm, listControls)
                For Each listBox As ListBoxControl In listControls
                    RemoveHandler listBox.MouseClick, New MouseEventHandler(AddressOf listBox_MouseClick)
                Next

                listControls.Clear()
                _customizationForm = Nothing
            End If
        End Sub

        Private Sub listBox_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim listBox As ListBoxControl = TryCast(sender, ListBoxControl)
            Dim treeNode As PivotCustomizationTreeNodeBase = TryCast(listBox.SelectedItem, PivotCustomizationTreeNodeBase)
            If treeNode IsNot Nothing Then Text = treeNode.Field.ToString()
        End Sub

        Private Sub FindListBox(ByVal parentControl As Control, ByVal listControls As List(Of ListBoxControl))
            For Each c As Control In parentControl.Controls
                Dim listBox As ListBoxControl = TryCast(c, ListBoxControl)
                If listBox IsNot Nothing AndAlso Not listControls.Contains(listBox) Then listControls.Add(listBox)
                If TypeOf c Is SplitContainer Then
                    Dim splitContainer As SplitContainer = TryCast(c, SplitContainer)
                    FindListBox(splitContainer.Panel1, listControls)
                    FindListBox(splitContainer.Panel2, listControls)
                End If

                FindListBox(c, listControls)
            Next
        End Sub
    End Class
End Namespace
