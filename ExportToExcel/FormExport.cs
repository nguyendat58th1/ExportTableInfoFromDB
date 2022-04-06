using ClosedXML.Excel;
using Database;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
			var props = PropertiesFromTypeOnlyVitualMethod(context);
			foreach (var prop in props)
			{
				comboBox.Items.Add(prop);
			}
			this.comboBox.DropDownStyle = ComboBoxStyle.DropDown;
			this.comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
		}

		public List<string> PropertiesFromTypeOnlyVitualMethod(object atype)
		{
			if (atype == null) return new List<string>() { };
			Type t = atype.GetType();
			PropertyInfo[] properties = atype.GetType().GetProperties()
											 .Where(p => p.GetGetMethod().IsVirtual).ToArray();
			List<string> propNames = new List<string>();
			foreach (PropertyInfo prop in properties)
			{
				Debug.WriteLine(prop.Name);
				propNames.Add(prop.Name);
			}
			return propNames;
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
			string connString = "DATA SOURCE=localhost:1521/XE;PASSWORD=ixfds;PERSIST SECURITY INFO=True;USER ID=IXFDS";
			string sqlRead = "SELECT t1.COLUMN_NAME, t1.DATA_TYPE || '(' || t1.DATA_LENGTH || ')' AS DATA_TYPE , t2.COMMENTS  FROM " +
							"(SELECT COLUMN_NAME, DATA_TYPE, DATA_LENGTH FROM all_tab_columns WHERE table_name = :TABLENAME) t1 " +
							"JOIN " +
							"(SELECT COLUMN_NAME, COMMENTS " +
							"FROM ALL_COL_COMMENTS " +
							"WHERE OWNER LIKE 'IXFDS' AND TABLE_NAME LIKE :TABLENAME) t2 " +
							"ON t1.COLUMN_NAME = t2.COLUMN_NAME";

			using (var conn = new OracleConnection(connString))
			{
				conn.Open();
				using (var cmd = new OracleCommand(sqlRead, conn))
				{
					string tableNameParam = comboBox.SelectedItem.ToString();
					cmd.Parameters.Add(":TABLENAME", tableNameParam);
					OracleDataReader odr = cmd.ExecuteReader(); //Read data
					OracleDataAdapter oda = new OracleDataAdapter(cmd);
					DataTable data = new DataTable();
					oda.Fill(data);
					dataGridView.DataSource = data;
				}
			}
		}
	}
}