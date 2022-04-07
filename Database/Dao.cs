using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data;

namespace Database
{
	public class Dao
	{
		public DataTable GetDataForGridView(string tableName)
		{
			DataTable data = new DataTable();
			string connString = GetConnectionString();
			string sqlRead = "SELECT t1.column_name ,t1.data_type || '(' || t1.data_length || ')' AS DATA_TYPE, t1.NULLABLE, t2.comments " +
							"FROM all_tab_columns t1, all_col_comments t2 " +
							"WHERE t1.column_name  = t2.COLUMN_NAME AND t1.TABLE_NAME =  " +
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

		public string GetConnectionString()
		{
			return ConfigurationManager.ConnectionStrings["NexEntities"].ConnectionString;
		}
	}
}