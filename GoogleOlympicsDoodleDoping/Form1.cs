using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace GoogleOlympicsDoodleDoping
{
    public partial class Form1 : Form
    {
        bool _stopThread;

        private doping _workerObject;
        private Thread _workerThread;
        
        public Form1()
        {
            _stopThread = false;
            _workerObject = new doping();
            _workerThread = new Thread(_workerObject.doWork);
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            

            if (_stopThread)
            {
                _workerObject.Stop = true;
                _workerThread.Join();  
            }
            else
            {

                _workerThread.Start();
            }
            _stopThread = !_stopThread;
        }
    }
}
