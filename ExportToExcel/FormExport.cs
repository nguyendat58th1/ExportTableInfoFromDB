using ClosedXML.Excel;
using Database;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

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
						// creating new Excel sheet in workbook  
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
			object missing = Type.Missing;
			var conn = new OracleConnection("DATA SOURCE=localhost:1521/XE;PASSWORD=ixfds;PERSIST SECURITY INFO=True;USER ID=IXFDS");
			for (int i = 0; i < comboBox.Items.Count; i++)
			{
				string sqlRead = "SELECT t1.column_name, t1.data_type, t1.data_length, t1.data_default, t1.nullable, t2.comments " +
								"FROM all_tab_columns t1, all_col_comments t2 " +
								"WHERE t1.column_name = t2.COLUMN_NAME AND t1.TABLE_NAME = " +
								":TABLENAME AND t2.TABLE_NAME = :TABLENAME";
				DataTable dt = new DataTable();
				conn.Open();
				using (var cmd = new OracleCommand(sqlRead, conn))
				{
					string tableName = comboBox.Items.ToString();
					cmd.Parameters.Add(":TABLENAME", tableName);
					cmd.ExecuteReader(); //Read data
					OracleDataAdapter da = new OracleDataAdapter(cmd);
					da.Fill(dt);
					if (dt == null || dt.Columns.Count == 0)
					{
						throw new Exception("ExportToExcel: Null or empty input table!\n");
					}
					Excel.Application oXL = new Excel.Application();
					Excel.Workbook oWB = oXL.Workbooks.Add(missing);
					Excel.Worksheet oSheet = oWB.ActiveSheet as Excel.Worksheet;
					oSheet.Name = tableName;

					for (var j = 0; j < dt.Columns.Count; j++)
					{
						oSheet.Cells[1, j + 1] = dt.Columns[j].ColumnName;
					}
					for (var j = 0; j < dt.Rows.Count; j++)
					{
						for (var a = 0; a < dt.Columns.Count; a++)
						{
							oSheet.Cells[a + 2, a + 1] = dt.Rows[a][a];
						}
					}
					oXL.Visible = true;
				}
				
				
			}
			
			
			

			// From Here am taking EXCEL SHEET -2

			//Excel.Worksheet oSheet2 = oWB.Sheets.Add(missing, missing, 1, missing) as Excel.Worksheet;

			//if (dt1 == null || dt1.Columns.Count == 0)
			//	throw new Exception("ExportToExcel: Null or empty input table!\n");
			//oSheet2.Name = "Depatment Details";

			//for (var i = 0; i < dt1.Columns.Count; i++)
			//{
			//	oSheet2.Cells[1, i + 1] = dt1.Columns[i].ColumnName;
			//}
			//for (var i = 0; i < dt1.Rows.Count; i++)
			//{
			//	for (var j = 0; j < dt1.Columns.Count; j++)
			//	{
			//		oSheet2.Cells[i + 2, j + 1] = dt1.Rows[i][j];
			//	}
			//}
			
		}
	}
}