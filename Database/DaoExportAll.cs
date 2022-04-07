using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Database
{
	public class DaoExportAll
	{
		private Dao dao = new Dao();

		public DataTable GetDataForGridView(string tableName)
		{
			DataTable data = new DataTable();
			string connString = dao.GetConnectionString();
			string sqlRead = "SELECT t1.column_name, t1.data_type, t1.data_length, t1.data_default, t1.nullable, t2.comments " +
							"FROM all_tab_columns t1, all_col_comments t2 " +
							"WHERE t1.column_name = t2.COLUMN_NAME AND t1.TABLE_NAME = " +
							":TABLENAME AND t2.TABLE_NAME = :TABLENAME";

			using (var conn = new OracleConnection(connString))
			{
				conn.Open();
				using (var cmd = new OracleCommand(sqlRead, conn))
				{
					cmd.Parameters.Add(":TABLENAME", tableName);
					cmd.ExecuteReader(); //Read data
					OracleDataAdapter oda = new OracleDataAdapter(cmd);
					oda.Fill(data);
				}
			}
			return data;
		}
	}
}