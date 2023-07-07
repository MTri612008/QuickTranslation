using QuicklyTranslate.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuicklyTranslate
{
    public partial class OnScBtn : Form
    {
        int dropForm = 0;
        int LoopBreak = 0;
        int SaveLocationX = (int)Settings.Default["SaveLocationX"];
        int SaveLocationY = (int)Settings.Default["SaveLocationY"];
        int rightBtnDoubleClick = 0;
        public ScForm scForm;
        public OnScBtn()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
             this.TransparencyKey = Color.LimeGreen;
        }

        private void OnScBtn_Load(object sender, EventArgs e)
        {
            this.Location = new Point(SaveLocationX, SaveLocationY);
        }
        public void Tracker() {
            Boolean LoopBr = true;
            while (LoopBr)
            {
                int x = MousePosition.X;
                int y = MousePosition.Y;
                this.Location = new Point(x - (51-24), y - (49-20));
                if (dropForm == 2) {
                    Settings.Default["SaveLocationX"] = x - (51 - 24);
                    Settings.Default["SaveLocationY"] = y - (49 - 20);
                    Settings.Default.Save();
                    LoopBr = false;
                    dropForm = 0;

                }
                if (dropForm == 1) {
                    LoopBr = true;
                }
                
            }
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                scForm = new ScForm();
                Form1.FullScCapture();
                scForm.BackgroundImage = Clipboard.GetImage();
                scForm.Show();
            }
            if (e.Button == MouseButtons.Right)
            {
               
                dropForm += 1;
                if (dropForm == 1)
                {
                    Thread thr = new Thread(Tracker);
                    thr.Start();
                }


            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
           
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.HideBt.Visible = false;
            form.Show();
        }
    }
}
