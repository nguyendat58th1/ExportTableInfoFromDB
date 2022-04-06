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

			//var dbSet = dao.GetDbSet(comboBox1.SelectedItem.ToString());
			//dataGridView.DataSource = PropertiesFromTypeExceptVitualMethod(dbSet.Create());
		}

		public List<string> PropertiesFromTypeExceptVitualMethod(object atype)
		{
			if (atype == null) return new List<string>() { };
			Type t = atype.GetType();
			PropertyInfo[] properties = atype.GetType().GetProperties()
											.Where(p => !p.GetGetMethod().IsVirtual).ToArray();
			List<string> propNames = new List<string>();
			foreach (PropertyInfo prp in properties)
			{
				Debug.WriteLine(prp.Name);
				propNames.Add(prp.Name);
			}
			return propNames;
		}

		public List<string> PropertiesFromTypeOnlyVitualMethod(object atype)
		{
			if (atype == null) return new List<string>() { };
			Type t = atype.GetType();
			PropertyInfo[] properties = atype.GetType().GetProperties()
											.Where(p => p.GetGetMethod().IsVirtual).ToArray();
			List<string> propNames = new List<string>();
			foreach (PropertyInfo prp in properties)
			{
				Debug.WriteLine(prp.Name);
				propNames.Add(prp.Name);
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
						using (XLWorkbook workBook = new XLWorkbook())
						{
							Dao dao = new Dao();
							var dbSet = dao.GetDbSet(comboBox.SelectedItem.ToString());
							var props = PropertiesFromTypeExceptVitualMethod(dbSet.Create());
							workBook.Worksheets.Add(ToDataTable(props), comboBox.SelectedItem.ToString());
							workBook.SaveAs(sfd.FileName);
						}
						MessageBox.Show("Export successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		public static DataTable ToDataTable(List<string> list)
		{
			DataTable dataTable = new DataTable();
			foreach (var col in list)
			{
				dataTable.Columns.Add(col);
			}
			return dataTable;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Dao dao = new Dao();
			//var dbSet = dao.GetDbSet(comboBox.SelectedItem.ToString());
			//var props = PropertiesFromTypeExceptVitualMethod(dbSet.Create());
			//dataGridView.Columns.Clear();
			//for (int i = 0; i < props.Count(); i++)
			//{
			//	dataGridView.Columns.Add(string.Format("col{0}", i), props[i]);
			//}
			string connString = "DATA SOURCE=localhost:1521/XE;PASSWORD=ixfds;PERSIST SECURITY INFO=True;USER ID=IXFDS";
			string sqlRead = $"SELECT COLUMN_NAME, DATA_TYPE, DATA_LENGTH  FROM all_tab_columns WHERE table_name = '{comboBox.SelectedItem.ToString()}'";
			using (var conn = new OracleConnection(connString))
			{
				conn.Open();
				using (var cmd = new OracleCommand(sqlRead, conn))
				{
					string tableNameParam = comboBox.SelectedItem.ToString();
					//cmd.Parameters.Add(":TABLENAME", tableNameParam);
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