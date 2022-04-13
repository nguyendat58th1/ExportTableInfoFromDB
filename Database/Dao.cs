using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data;
using System.Diagnostics;

namespace Database
{
	public class Dao
	{
		public DataTable GetDataForGridView(string tableName)
		{
			DataTable data = new DataTable();
			string connString = GetConnectionString();
			Debug.WriteLine(connString);
			string sqlRead = "SELECT t1.COLUMN_ID AS NO" +
							 ",t1.column_name, CASE " +
							 "WHEN t3.CONSTRAINT_NAME LIKE 'PK%' " +
							 "THEN 'PK' " +
							 "WHEN t3.CONSTRAINT_NAME LIKE 'FK%' " +
							 "THEN 'FK' " +
							 "ELSE NULL " +
							 "END AS " +
							 "\"PK/FK\"" +
							 "," + " CASE " +
							 "WHEN t1.COLUMN_NAME LIKE 'SID' " +
							 "THEN 'Yes' " + "ELSE Null " +
							 "END AS AUTO_INCREMENT, CASE  " +
							 "WHEN t1.DATA_TYPE = 'NUMBER' " + "THEN t1.data_type || '(' || t1.DATA_PRECISION ||','|| t1.DATA_SCALE  || ')' " +
							 "WHEN  t1.DATA_TYPE LIKE  '%VARCHAR%' " + "THEN t1.data_type || '(' || t1.CHAR_LENGTH  || ')' " +
							 "ELSE t1.data_type " +
							 "END AS DATA_TYPE, t1.NULLABLE, t2.comments, t1.DATA_DEFAULT, t1.COLUMN_ID, CASE  " +
							 "WHEN t1.COLUMN_NAME LIKE 'UPDATE_USER_SID' OR t1.COLUMN_NAME LIKE 'ENTRY_USER_SID' " +
							 "THEN NULL " +
							 "ELSE t3.CONSTRAINT_NAME " +
							 "END AS CONSTRAINT_NAME " +
							 "FROM all_tab_columns t1 " +
							 "JOIN all_col_comments t2 ON t2.COLUMN_NAME  = t1.column_name " +
							 "LEFT JOIN " +
							 "(SELECT * FROM all_cons_columns t WHERE t.table_name  = :TABLENAME AND (t.POSITION IS NOT NULL AND t.constraint_name NOT LIKE 'SYS%')) " +
							 "t3 ON t3.column_name  = t2.column_name " +
							 "WHERE t1.table_name = :TABLENAME AND t2.table_name = :TABLENAME " +
							 "ORDER BY COLUMN_ID";

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