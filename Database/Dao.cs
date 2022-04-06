using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
	public class Dao
	{
		NexEntities context = new NexEntities();
		public DbSet GetDbSet(string tableName)
		{
			var type = Assembly.GetExecutingAssembly()
					.GetTypes()
					.FirstOrDefault(t => t.Name == tableName);
			if(type == null)
			{
				return null;
			}
			DbSet newContext = context.Set(type);
			return newContext;
		}
	}
}
