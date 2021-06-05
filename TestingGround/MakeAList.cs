using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGround
{
	public class MakeAList
	{
		public List<string> names = new List<string>();

		// List of items
		public MakeAList()
		{
			names.Add("Matthew");
			names.Add("Mark");
			names.Add("Luke");
			names.Add("John");
			names.Add("Paul");
			names.Add("Judas");
			names.Add("Pilatus");
			names.Add("Herod");
		}
	}
}
