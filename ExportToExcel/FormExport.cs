﻿using ClosedXML.Excel;
using Database;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExportToExcel
{
	public partial class FormExport : Form
	{
		private NexEntities context = new NexEntities();

		public FormExport()
		{
			InitializeComponent();
		}

		private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void FormExport_Load(object sender, EventArgs e)
		{
			var props = Extension.PropertiesFromTypeOnlyVitualMethod(context);
			foreach (var prop in props)
			{
				comboBox.Items.Add(prop);
			}
			this.comboBox.DropDownStyle = ComboBoxStyle.DropDown;
			this.comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
			{
				if (sfd.ShowDialog() == DialogResult.OK)
				{
					try
					{

						// creating Excel Application  
						Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
						// creating new WorkBook within Excel application  
						Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
						// creating new Excelsheet in workbook  
						Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
						// see the excel sheet behind the program  
						app.Visible = true;
						// get the reference of first sheet. By default its name is Sheet1.  
						// store its reference to worksheet  
						worksheet = workbook.Sheets["Sheet1"];
						worksheet = workbook.ActiveSheet;
						// changing the name of active sheet  
						worksheet.Name = comboBox.SelectedItem.ToString();
						// storing header part in Excel  
						for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
						{
							worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
						}
						// storing Each row and column value to excel sheet  
						for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
						{
							for (int j = 0; j < dataGridView.Columns.Count; j++)
							{
								worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
							}
						}
						// save the application  
						workbook.SaveAs(sfd.FileName);
						// Exit from the application  
						app.Quit();

						MessageBox.Show("Export successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Dao dao = new Dao();
			try
			{
				dataGridView.DataSource = dao.GetDataForGridView(comboBox.SelectedItem.ToString());
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnExportAll_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
			{
				Dao dao = new Dao();
				if (sfd.ShowDialog() == DialogResult.OK)
				{
					try
					{

						// creating Excel Application  
						Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
						// creating new WorkBook within Excel application  
						Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
						// see the excel sheet behind the program  
						app.Visible = true;

						var props = Extension.PropertiesFromTypeOnlyVitualMethod(context);
						for (int k = 1; k < props.Count; k++)
						{
							var xlSheets = workbook.Sheets as Excel.Sheets;
							var xlNewSheet = (Excel.Worksheet)xlSheets.Add(xlSheets[k], Type.Missing, Type.Missing, Type.Missing);
							xlNewSheet.Name = props[k-1];
							var data = dao.GetDataForGridView(props[k - 1]);
							labelTableName.Text = props[k - 1];
							dataGridView.DataSource = data;
							for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
							{
								xlNewSheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
							}
							// storing Each row and column value to excel sheet  
							for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
							{
								for (int j = 0; j < dataGridView.Columns.Count; j++)
								{
									xlNewSheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
								}
							}
						}
						workbook.SaveAs(sfd.FileName);
						// Exit from the application  
						app.Quit();

						MessageBox.Show("Export successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}
	}
}