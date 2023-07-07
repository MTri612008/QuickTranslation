using CefSharp.DevTools.Browser;
using Google.Cloud.Translation.V2;
using QuicklyTranslate.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace QuicklyTranslate
{
    public partial class Form1 : Form
    {
        int a = 2;
        String TranslateText;
        String ReadImgText;
        string path = Settings.Default["PathSave"].ToString();
        static ScForm scForm;
       public static OnScBtn OnScBtn = new OnScBtn();
        String ValSave = Settings.Default["Save"].ToString();
       static int Show =0;
        String Hide;
        public static int TorF = 0;
       
        StreamWriter writer;
        StreamReader reader;
        public Form1()
        {
            InitializeComponent();
            
            notifyIcon1.Text = "QuicklyTranslate";
            notifyIcon1.Visible = true;
            Console.WriteLine(ScForm.showForm);
            ImgTransForm.Hide();
            if (ValSave == "btnShow") {
                OnScBtn.Show();
            }
            else if (ValSave == "btnHide") {
                OnScBtn.Hide();
            }

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            chromiumWebBrowser1.Load("https://translate.google.com/?sl=en&tl=vi&text=" + TranslateText + "&op=translate");
          

            if (this.WindowState == FormWindowState.Normal)
            {
                if (Clipboard.ContainsText())
                {
                    ImgTransForm.Hide();
                    TranslateText = Clipboard.GetText();
                    chromiumWebBrowser1.Load("https://translate.google.com/?sl=en&tl=vi&text=" + TranslateText + "&op=translate");
                }
                else if (Clipboard.ContainsImage())
                {
                    try
                    {

                        ImgTransForm.Show();
                        ImgTranslate();
                        // code that might throw an exception
                    }
                    catch (Exception e1)
                    {
                        chromiumWebBrowser2.Load("https://translate.google.com/");
                        // handle ExceptionType1
                    }
                }


            }


        }

        private void TextTranslateBT_Click(object sender, EventArgs e)
        {
            ImgTransForm.Hide();
            TranslateText = Clipboard.GetText();
            chromiumWebBrowser1.Load("https://translate.google.com/?sl=en&tl=vi&text=" + TranslateText + "&op=translate");
        }

        private void TextTranslateBT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.A)
            {
                TranslateText = Clipboard.GetText();
                chromiumWebBrowser1.Load("https://translate.google.com/?sl=en&tl=vi&text=" + TranslateText + "&op=translate");
            }
        }



        private void chromiumWebBrowser1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.A)
            {
                TranslateText = Clipboard.GetText();
                chromiumWebBrowser1.Load("https://translate.google.com/?sl=en&tl=vi&text=" + TranslateText + "&op=translate");
            }
        }

        private void openAndTranslateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://translate.google.com/?sl=en&tl=vi&text=" + TranslateText + "&op=translate");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
            {
                if (Clipboard.ContainsText())
                {
                    ImgTransForm.Hide();
                    TranslateText = Clipboard.GetText();
                    chromiumWebBrowser1.Load("https://translate.google.com/?sl=en&tl=vi&text=" + TranslateText + "&op=translate");
                }
                else if (Clipboard.ContainsImage()) {
                    try
                    {

                        ImgTransForm.Show();
                        ImgTranslate();
                        // code that might throw an exception
                    }
                    catch (Exception e1)
                    {
                        chromiumWebBrowser2.Load("https://translate.google.com/");
                        // handle ExceptionType1
                    }
                }


            }

        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left) {
                Show = 1;
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Minimized;
                }
                scForm = new ScForm();

                FullScCapture();
                scForm.BackgroundImage = Clipboard.GetImage();
                scForm.Show();
            }
            if (e.Button == MouseButtons.Right) {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void CloseBT_Click(object sender, EventArgs e)
        {

            this.Close();
            
        }

        private void MinisizeBT_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ImgTranslateBT_Click(object sender, EventArgs e)
        {

            try
            {
                
                ImgTransForm.Show();
                ImgTranslate();
                // code that might throw an exception
            }
            catch (Exception e1)
            {
                chromiumWebBrowser2.Load("https://translate.google.com/");
                // handle ExceptionType1
            }


        }
        private void ImgTranslate() {

            ImgPanel.BackgroundImage = Clipboard.GetImage();
            Bitmap img = new Bitmap(Clipboard.GetImage());
            TesseractEngine engine = new TesseractEngine("./tessdata", "eng", EngineMode.Default);
            Page page = engine.Process(img, PageSegMode.Auto);
            ReadImgText = page.GetText();
            chromiumWebBrowser2.Load("https://translate.google.com/?sl=en&tl=vi&text=" + ReadImgText + "&op=translate");
        }
        public static void FullScCapture(){
            Thread.Sleep(500);
            Rectangle rect = Screen.PrimaryScreen.Bounds;
            Bitmap bit = new Bitmap(rect.Width, rect.Height);
            Graphics g = Graphics.FromImage(bit);
            g.CopyFromScreen(0,0, 0, 0, rect.Size);
            Clipboard.SetImage(bit);
            
            
            
        }
        public static void ScreenSnip() {
            Bitmap bit2;
           

            if (Show == 1)
            {
                Rectangle rect = Screen.PrimaryScreen.Bounds;
                Bitmap bit = new Bitmap(scForm.scShootPanel.Width, scForm.scShootPanel.Height);
                Graphics g;
                g = Graphics.FromImage(bit);
                g.CopyFromScreen(scForm.scShootPanel.Left, scForm.scShootPanel.Top, 0, 0, rect.Size);

                Clipboard.SetImage(bit);
                Show = 0;
            }
            else {
                Rectangle rect = Screen.PrimaryScreen.Bounds;
                bit2 = new Bitmap(OnScBtn.scForm.scShootPanel.Width, OnScBtn.scForm.scShootPanel.Height);
                Graphics g2;
                g2 = Graphics.FromImage(bit2);
                g2.CopyFromScreen(OnScBtn.scForm.scShootPanel.Left, OnScBtn.scForm.scShootPanel.Top, 0, 0, rect.Size);
                Clipboard.SetImage(bit2);
            }
               
   
        }
       

      
        private void ShowscSnip_Click(object sender, EventArgs e)
        {
            Show = 1;
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            scForm = new ScForm();
           
            FullScCapture();
            scForm.BackgroundImage = Clipboard.GetImage();
            scForm.Show();



        }
        public void FileWriter() {
            String ReadVieImgText;
            String ReadImgText2;
            Bitmap img = new Bitmap(Clipboard.GetImage());
            TesseractEngine engine = new TesseractEngine("./tessdata", "eng", EngineMode.Default);
            Page page = engine.Process(img, PageSegMode.SparseText);
            ReadImgText2 = page.GetText();

            Rectangle rect = Screen.PrimaryScreen.Bounds;
            Bitmap bit = new Bitmap(panel2.Width, panel2.Height);
            Graphics g = Graphics.FromImage(bit);
            g.CopyFromScreen(panel2.Left + this.Left, (panel2.Top + 80) + this.Top, 0, 0, rect.Size);
            TesseractEngine engine2 = new TesseractEngine("./tessdata", "vie", EngineMode.Default);
            Page page2 = engine2.Process(bit, PageSegMode.SparseText);
            ReadVieImgText = page2.GetText();
            try
            {
                reader = new StreamReader(path);
                string[,] TextListReader = new string[,]
                {
                    { ReadImgText2,":",ReadVieImgText,reader.ReadToEnd() }
                };
                
                reader.Close();
                Thread.Sleep(1000);
                writer = new StreamWriter(path);
                writer.WriteLine("");
                for (int i = 0; i < TextListReader.GetLength(0); i++)
                {

                    for (int j = 0; j < TextListReader.GetLength(1); j++) {
                        
                        writer.Write(TextListReader[i,j]);
                       

                    }

                }
               



                writer.Close();

            }catch(Exception e)
            {
                MessageBox.Show("Empty path,If you selected a path Please Restard this Application");
            }
            

        }
      
        private void HideBt_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void chromiumWebBrowser2_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {

        }

        private void btnQuickOP_Click(object sender, EventArgs e)
        {
           
            Settings.Default["Save"] = "btnShow";
            // ValSave = Settings.Default["Save"].ToString();
            OnScBtn.Show();
            Settings.Default.Save();
           
        }

        private void btnHideQOP_Click(object sender, EventArgs e)
        {
            
            Settings.Default["Save"] = "btnHide";
            // ValSave = Settings.Default["Save"].ToString();
            OnScBtn.Hide();
            Settings.Default.Save();
        }

        private void WriteToFilebtn_Click(object sender, EventArgs e)
        {

            FileWriter();
            //TextTranslator();
        }

        private void CreateFilebtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "TXT|*.txt";
            if (sf.ShowDialog() == DialogResult.OK) {
                File.Create(sf.FileName).Close();
                Settings.Default["PathSave"] = sf.FileName;
                Settings.Default.Save();
                MessageBox.Show("Please restard the application to change the path");
            }

        }

        private void ChooseFilebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                Settings.Default["PathSave"] = of.FileName;
                Settings.Default.Save();
                MessageBox.Show("Please restard the application to change the path");
                
            }
            
        }
    }
}
