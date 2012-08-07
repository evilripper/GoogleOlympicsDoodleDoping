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

        private Doping _workerObject;
        private Thread _workerThread;
        
        public Form1()
        {
            InitializeComponent();

            for (int i = 1; i < 101; i++)
            {
                cbxInterval.Items.Add(i);
            }
            cbxInterval.SelectedIndex = 99;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            cbxInterval.Enabled = false;

            _workerObject = new Doping();
            _workerThread = new Thread(_workerObject.doWork);

            _workerObject.Interval = (int)cbxInterval.SelectedItem;
            _workerThread.Start();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
            {
               
                if (_workerThread.IsAlive)
                {
                    Thread.Sleep(1);
                    _workerObject.RequestStop();
                    _workerThread.Join();
                    button1.Enabled = true;
                    cbxInterval.Enabled = true;
                }
                MessageBox.Show("Thread stopped");
            }
            base.OnKeyDown(e);
        }
    }
}
