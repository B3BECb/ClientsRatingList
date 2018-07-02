using CarList.Datastorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarList
{
	class Program
	{
		static void Main(string[] args)
		{
			var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

			var context = new Context($@"Data Source={Environment.SpecialFolder.ApplicationData}\mydb.db;Version=3;");
		}
	}
}
