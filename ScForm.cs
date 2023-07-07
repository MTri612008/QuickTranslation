using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuicklyTranslate
{
    public partial class ScForm : Form
    {
        Thread trackerThr;
       public Panel scShootPanel = new Panel();
        public Form1 form1; 
        int x, y;
        int loopbreak = 0;
        int mousecount = 0;
        public static int showForm = 0;
        public ScForm()
        {
            InitializeComponent();

            //this.BackColor = Color.LimeGreen;
            // this.TransparencyKey = Color.LimeGreen;
            //panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            
        }

        private void ScForm_Load(object sender, EventArgs e)
        {
            
        }

       
        public void Tracker() {
            while (true)
            {
                 x = MousePosition.X;  y = MousePosition.Y;
                try {
                    scShootPanel.Width = x - scShootPanel.Left;
                    scShootPanel.Height = y - scShootPanel.Top;
                }

                catch(Exception ex)
                {

                }
                
                if(loopbreak == 1)
                {
                    loopbreak = 0;
                    break;
                    
                }
            }
        }

        private void ScForm_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left) {
                mousecount += 1;
                scShootPanel.Location = new Point(MousePosition.X,MousePosition.Y);
                scShootPanel.BackColor = Color.Transparent;
                scShootPanel.BorderStyle = BorderStyle.FixedSingle;

               
                if (mousecount == 1) {
                    this.Controls.Add(scShootPanel);
                    scShootPanel.MouseDown += new MouseEventHandler(this.scShootMouseDown);
                    trackerThr = new Thread(Tracker);
                    trackerThr.Start();
                }
               
                if (mousecount == 2) {
                    this.Controls.Remove(scShootPanel);
                    loopbreak = 1;
                    //trackerThr.Suspend();
                    
                    mousecount = 0;
                
                }
                
            }
            if (e.Button == MouseButtons.Right) {
                ScForm.showForm = 1;
                //form1.Test();
               
                Form1.ScreenSnip();
                form1 = new Form1();
                form1.HideBt.Hide();
                form1.notifyIcon1.Visible = false;
                //form1.OnScBtn.Close();
                Thread.Sleep(500);
                this.Close();
                form1.Show();
                loopbreak = 1;
                //trackerThr.Suspend();
                
            }
           
          
        }

        private void ScForm_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
        private void scShootMouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left)
            {
                if (mousecount == 2)
                {
                    loopbreak = 1;
                    //trackerThr.Suspend();

                    mousecount = 0;

                }
            }
            if (e.Button == MouseButtons.Right)
            {
                Form1.TorF = 1;
                Form1.ScreenSnip();
                loopbreak = 1;
                //form1.WindowState = FormWindowState.Normal;
                this.Close();
            }
        }
    }
}
