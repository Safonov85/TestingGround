using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGround
{
	public class RectangleConsole
	{
		// Needs movable rect at command in the future
		
		public void CreateRectangle()
		{
			Debug.WriteLine("");
			for (int i = 0; i < 10; i++)
			{
				Debug.Write("*");
			}
			Debug.WriteLine("");
			for (int i = 0; i < 5; i++)
			{
				Debug.WriteLine("*        *");
			}
			//Debug.WriteLine("");
			for (int i = 0; i < 10; i++)
			{
				Debug.Write("*");
			}
			Debug.WriteLine("");
		}
	}
}
