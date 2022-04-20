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
	
	// refactoring on datatype methods needed
	public class SimpleAnimation
	{
		public DispatcherTimer timer = new DispatcherTimer();
        string line = "-";
        bool reverse = false;
        public bool timerRuns = false;
        int count = 1;
        float countingSteps = 1;

		public SimpleAnimation()
		{
			timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
			timer.Tick += Timer_Tick;
			//timer.Start();
            timerRuns = false;
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
            //Debug.Flush();

            if(reverse == false)
            {
                Debug.WriteLine(MoveLineForward());
                if(line.Length > 10)
                {
                    reverse = true;
                    Debug.WriteLine(MoveLineForward() + " " + count);
                    count++;
                }
            }
            else
            {
                Debug.WriteLine(MoveLineBackward());
                if (line.Length == 1)
                {
                    reverse = false;
                }
            }
        }

        string MoveLineForward()
        {
            line = " " + line;

            return line;
        }
        
        string MoveLineBackward()
        {
            line = line.Remove(0, 1);

            return line;
        }

        public void StopAnimation()
        {
            timer.Stop();
            timerRuns = false;
        }

        public void StartAnimation()
        {
            timer.Start();
            timerRuns = true;
        }
	
	bool Selecta()
	{
		return true
	}
	}
}
