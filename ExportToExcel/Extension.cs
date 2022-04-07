using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace ExportToExcel
{
	public static class Extension
	{
		public static List<string> PropertiesFromTypeOnlyVitualMethod(object atype)
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
	}
}