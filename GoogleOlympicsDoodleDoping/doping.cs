using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GoogleOlympicsDoodleDoping
{
    class doping
    {
        public bool Stop
        {
            get { return _stop; }
            set { _stop = value; }
        }

        private bool _stop = false;

        public void doWork()
        {
            while (!_stop)
            {
                SendKeys.SendWait("{LEFT}");
                System.Threading.Thread.Sleep(50);   
                SendKeys.SendWait("{RIGHT}");
            }
        }
    }
}
