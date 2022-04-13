using Database;
using Microsoft.Office.Interop.Excel;
using Oracle.ManagedDataAccess.Client;
using System;
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
						worksheet.Cells[1, 2] = "システム名";
						worksheet.Cells[1, 3] = "FDS";
						worksheet.Cells[1, 4] = "DB名";
						worksheet.Cells[1, 5] = "IXFDS";
						worksheet.Cells[1, 6] = "テーブル名(論理)";
						worksheet.Cells[1, 7] = "";
						worksheet.Cells[1, 8] = "作成日";
						worksheet.Cells[1, 9] = "";
						worksheet.Cells[1, 10] = "改定日";
						worksheet.Cells[2, 2] = "工程名";
						worksheet.Cells[2, 3] = "詳細設計";
						worksheet.Cells[2, 4] = "設計書名";
						worksheet.Cells[2, 5] = "テーブル定義書";
						worksheet.Cells[2, 6] = "テーブル名(物理)";
						worksheet.Cells[2, 7] = comboBox.SelectedItem.ToString();
						worksheet.Cells[2, 8] = "作成者";
						worksheet.Cells[2, 9] = "";
						worksheet.Cells[2, 10] = "改定者";

						

						for (int i = 1; i <= 2; i++)
						{
							for (int j = 1; j <= 10; j++)
							{
								Microsoft.Office.Interop.Excel.Range range = worksheet.UsedRange;
								Microsoft.Office.Interop.Excel.Range cell = range.Cells[i, j];
								Microsoft.Office.Interop.Excel.Borders border = cell.Borders;
								border[XlBordersIndex.xlEdgeLeft].LineStyle =
									Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
								border[XlBordersIndex.xlEdgeTop].LineStyle =
									Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
								border[XlBordersIndex.xlEdgeBottom].LineStyle =
									Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
								border[XlBordersIndex.xlEdgeRight].LineStyle =
									Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

							}
						}

						for (int i = 1; i <= 2; i++)
						{
							for (int j = 2; j <= 10; j = j + 2)
							{
								worksheet.Cells[i, j].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);
							}
						}

						// storing header part in Excel  
						for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
						{
							worksheet.Cells[4, i+1] = dataGridView.Columns[i - 1].HeaderText;
						}
						// storing Each row and column value to excel sheet
						for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
						{
							for (int j = 0; j < dataGridView.Columns.Count; j++)
							{
								worksheet.Cells[i + 5, j + 2] = dataGridView.Rows[i].Cells[j].Value.ToString();
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
							xlNewSheet.Cells[1, 2] = "システム名";
							xlNewSheet.Cells[1, 3] = "FDS";
							xlNewSheet.Cells[1, 4] = "DB名";
							xlNewSheet.Cells[1, 5] = "IXFDS";
							xlNewSheet.Cells[1, 6] = "テーブル名(論理)";
							xlNewSheet.Cells[1, 7] = "";
							xlNewSheet.Cells[1, 8] = "作成日";
							xlNewSheet.Cells[1, 9] = "";
							xlNewSheet.Cells[1, 10] = "改定日";
							xlNewSheet.Cells[2, 2] = "工程名";
							xlNewSheet.Cells[2, 3] = "詳細設計";
							xlNewSheet.Cells[2, 4] = "設計書名";
							xlNewSheet.Cells[2, 5] = "テーブル定義書";
							xlNewSheet.Cells[2, 6] = "テーブル名(物理)";
							xlNewSheet.Cells[2, 7] = props[k - 1];
							xlNewSheet.Cells[2, 8] = "作成者";
							xlNewSheet.Cells[2, 9] = "";
							xlNewSheet.Cells[2, 10] = "改定者";

							for (int i = 1; i <= 2; i++)
							{
								for (int j = 2; j <= 10; j = j + 2)
								{
									xlNewSheet.Cells[i, j].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);
								}
							}


							var data = dao.GetDataForGridView(props[k - 1]);
							labelTableName.Text = props[k - 1];
							dataGridView.DataSource = data;

							for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
							{
								xlNewSheet.Cells[4, i + 1] = dataGridView.Columns[i - 1].HeaderText;
							}
							// storing Each row and column value to excel sheet
							for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
							{
								for (int j = 0; j < dataGridView.Columns.Count; j++)
								{
									xlNewSheet.Cells[i + 5, j + 2] = dataGridView.Rows[i].Cells[j].Value.ToString();
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