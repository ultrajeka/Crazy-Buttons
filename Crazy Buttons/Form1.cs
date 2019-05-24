using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Crazy_Buttons
{
    public delegate void HelperToCall(Button btn); 
    public partial class Form1 : Form
    {
        Thread t1, t2, t3, t4; 

        Random r;

        HelperToCall helper;

        ButtonCompare[] btn;
        public Form1()
        {
            InitializeComponent();

            btn = new ButtonCompare [] { btn_first, btn_second, btn_third, btn_fourth };

            helper = new HelperToCall(Motion);

            r = new Random();
            
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            btn_pause.Enabled = btn_stop.Enabled = true;

            ((Button)sender).Enabled = false;
            if (t1 != null) // если потоки существуют
            {
                t1.Resume();
                t2.Resume();
                t3.Resume();
                t4.Resume();
                return;
            }

            t1 = new Thread(Movement1);
            t2 = new Thread(Movement2);
            t3 = new Thread(Movement3);
            t4 = new Thread(Movement4);

            t1.IsBackground = t2.IsBackground = t3.IsBackground = t4.IsBackground = true;

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
        }
        private void btn_pause_Click(object sender, EventArgs e)
        {
            btn_pause.Enabled = false;
            btn_start.Enabled = true;

            t1.Suspend();
            t2.Suspend();
            t3.Suspend();
            t4.Suspend();
            
        }
        private void btn_stop_Click(object sender, EventArgs e)
        {            
            btn_pause.Enabled = btn_stop.Enabled = false; 
            btn_pause_Click(sender, e);
            Reset();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            btn_stop_Click(sender, e);
        }

        private void Reset()
        {
            btn_first.Location = new Point(12, btn_first.Location.Y);
            btn_second.Location = new Point(12, btn_second.Location.Y);
            btn_third.Location = new Point(12, btn_third.Location.Y);
            btn_fourth.Location = new Point(12, btn_fourth.Location.Y);

            foreach (ButtonCompare item in btn)
                item.BackColor = SystemColors.Control;
        }

        void Motion(Button button)
        {
            button.Location = new Point(button.Location.X + r.Next(3) , button.Location.Y);

            Lider();

            Finish(button);
        }

        private void Finish(Button btn)
        {
            if (btn.Location.X + btn.Width > pictureBox1.Location.X)
                btn_pause_Click(new object(), new EventArgs());            
        }

        private void Lider()
        {
            Array.Sort(btn);
            btn[0].BackColor = Color.Yellow;
            for (int i = 1; i < btn.Length; i++)
            {
                btn[i].BackColor = SystemColors.Control;
            }
        }

        void Movement1()
        {
            while (true)
            {
                Thread.Sleep(r.Next(5, 15));
                Invoke(helper, btn_first);
            }
        }
        void Movement2()
        {
            while (true)
            {
                Thread.Sleep(r.Next(5, 15));
                Invoke(helper, btn_second);
            }
        }        
        void Movement3()
        {
            while (true)
            {
                Thread.Sleep(r.Next(5, 15));
                Invoke(helper, btn_third);
            }
        }
        void Movement4()
        {
            while (true)
            {
                Thread.Sleep(r.Next(5, 15));
                Invoke(helper, btn_fourth); 
            }
        }
    }
}
