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
		public DispatcherTimer timer = new DispatcherTimer();
        string line = "-";

		public SimpleAnimation()
		{
			timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
			timer.Tick += Timer_Tick;
			timer.Start();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
            //Debug.Flush();

            Debug.WriteLine(MoveLine());
		}

        string MoveLine()
        {
            line = " " + line;

            return line;
        }
	}
}
