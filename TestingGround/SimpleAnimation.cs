using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace TestingGround
{
	public class SimpleAnimation
	{
		DispatcherTimer timer = new DispatcherTimer();

		public SimpleAnimation()
		{
			timer.Interval = new TimeSpan(0, 0, 1);
			timer.Tick += Timer_Tick;
			timer.Start();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			Debug.WriteLine(DateTime.Now.Second.ToString());
		}
	}
}
