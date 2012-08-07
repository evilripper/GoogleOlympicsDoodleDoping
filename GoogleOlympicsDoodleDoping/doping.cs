using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GoogleOlympicsDoodleDoping
{
    class Doping
    {
        private bool _stop = false;
        
        public bool Stop
        {
            get { return _stop; }
            set { _stop = value; }
        }
        
        private int _interval;
        
        public int Interval
        {
            get { return _interval; }
            set { _interval = value; }
        }

        public void doWork()
        {
            while (!_stop)
            {
                SendKeys.SendWait("{LEFT}");
                System.Threading.Thread.Sleep(_interval);   
                SendKeys.SendWait("{RIGHT}");
            }
        }

        internal void RequestStop()
        {
            _stop = true;
        }
    }
}
