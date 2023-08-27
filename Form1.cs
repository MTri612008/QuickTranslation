using CefSharp;
using CefSharp.DevTools.Browser;
using Google.Cloud.Translation.V2;
using QuicklyTranslate.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
        
        string TransTextLangUrl = "tl=" + Settings.Default["SaveUrl1"].ToString();
        string TransImgLangUrl = "tl=" + Settings.Default["SaveUrl2"].ToString();
        string path = Settings.Default["PathSave"].ToString();
      public static ScForm scForm;
       public static OnScBtn OnScBtn = new OnScBtn();
       // public static ScForm2 scForm2;
        String ValSave = Settings.Default["Save"].ToString();
       static int Show =0;
        int TextTlBtnClick = 0;
        public static int TorF = 0;
        string test;

        StreamWriter writer;
        StreamWriter SaveTransLangUrl;
        StreamWriter SaveTransLangUrl2;
        StreamReader reader;
        StreamReader ReadTransLangUrl;
        StreamReader ReadTransLangUrl2;

        public Form1()
        {
           
            
            InitializeComponent();
            
            notifyIcon1.Text = "QuicklyTranslate";
            notifyIcon1.Visible = true;
            Console.WriteLine(ScForm.showForm);
            ImgTransForm.Hide();
            if (ValSave == "btnShow")
            {
                OnScBtn.Show();
            }
            else if (ValSave == "btnHide")
            {
                OnScBtn.Hide();
            }


            //Thread.Sleep(1000);


        }
       
       

        private void Form1_Load(object sender, EventArgs e)
        {

            chromiumWebBrowser1.ExecuteScriptAsyncWhenPageLoaded("var text = document.getElementById('sdgBod'); text.innerText = 'MadeByTridepzai';text.style.fontSize = '25px';text.style.fontFamily = 'sans-serif';text.style.fontWeight = 'bold';text.style.color = '#666666'");
            SaveTextTransLang();
            SaveImgTransLang();
            chromiumWebBrowser1.Load("https://translate.google.com/?sl=en&tl=vi&text=" + "" + "&op=translate");
           
            chromiumWebBrowser1.AddressChanged += ChromiumWebBrowser1_AddressChanged1;

            if (this.WindowState == FormWindowState.Normal)
            {
                if (Clipboard.ContainsText())
                {
                    TextTlBtnClick = 1;
                    if (TransTextLangUrl == "")
                    {
                        MessageBox.Show("aaaa");
                        ImgTransForm.Hide();
                        TranslateText = Clipboard.GetText();
                        chromiumWebBrowser1.Load("https://translate.google.com/?sl=en&tl=vi" + "&text=" + TranslateText + "&op=translate");
                       
                    }
                    else {
                        
                       // MessageBox.Show("");
                       // chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser("https://translate.google.com/?sl=en&" + TransLangUrl + "&text=" + TranslateText + "&op=translate");
                        ImgTransForm.Hide();
                        TranslateText = Clipboard.GetText();
                        TransTextLangUrl = "tl=" + Settings.Default["SaveUrl1"].ToString(); test = TransTextLangUrl; chromiumWebBrowser1.LoadUrl("https://translate.google.com/?sl=en&" + TransTextLangUrl + "&text=" + TranslateText + "&op=translate");
                        

                    }
                    
                }
                else if (Clipboard.ContainsImage())
                {
                    TextTlBtnClick = 0;
                    try
                    {

                        ImgTransForm.Show();
                        ImgTranslate();
                        // code that might throw an exception
                    }
                    catch (Exception e1)
                    {
                        chromiumWebBrowser2.Load("https://translate.google.com/?sl=en&" + TransImgLangUrl);
                        this.ImgTransForm.Controls.Add(this.chromiumWebBrowser2);
                        // handle ExceptionType1
                    }
                }


            }
            this.Controls.Add(this.chromiumWebBrowser1);
            

            //    Thread.Sleep(1000);


        }

        private void ChromiumWebBrowser1_AddressChanged1(object sender, AddressChangedEventArgs e)
        {
            chromiumWebBrowser1.ExecuteScriptAsync("var text = document.getElementById('sdgBod'); text.innerText = 'MadeByTridepzai';text.style.fontSize = '25px';text.style.fontFamily = 'sans-serif';text.style.fontWeight = 'bold';text.style.color = '#666666'");
        }

        private void TextTranslateBT_Click(object sender, EventArgs e)
        {
            TextTlBtnClick = 0;
            ImgTransForm.Hide();
            TranslateText = Clipboard.GetText();
            chromiumWebBrowser1.Load("https://translate.google.com/?tl=vi&text=" + TranslateText + "&op=translate");
           
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
                    chromiumWebBrowser1.Load("https://translate.google.com/?text=" + TranslateText + "&op=translate");
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
                        chromiumWebBrowser2.Load("https://translate.google.com/?sl=en&"+TransImgLangUrl);
                        this.ImgTransForm.Controls.Add(this.chromiumWebBrowser2);
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
            TextTlBtnClick = 0;
            try
            {
                
                ImgTransForm.Show();
                ImgTranslate();
                // code that might throw an exception
            }
            catch (Exception e1)
            {
                chromiumWebBrowser2.Load("https://translate.google.com/?sl=en&"+TransImgLangUrl);
                this.ImgTransForm.Controls.Add(this.chromiumWebBrowser2);
                // handle ExceptionType1
            }


        }
        private void ImgTranslate() {

            ImgPanel.BackgroundImage = Clipboard.GetImage();
            Bitmap img = new Bitmap(Clipboard.GetImage());
            TesseractEngine engine = new TesseractEngine("./tessdata", "eng", EngineMode.Default);
            Page page = engine.Process(img, PageSegMode.Auto);
            ReadImgText = page.GetText();
            chromiumWebBrowser2.Load("https://translate.google.com/?sl=en&"+TransImgLangUrl+"&text=" + ReadImgText + "&op=translate");
            this.ImgTransForm.Controls.Add(this.chromiumWebBrowser2);
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
        public static void ScreenSnip2()
        {
            Bitmap bit2;
                Rectangle rect = Screen.PrimaryScreen.Bounds;
                Bitmap bit = new Bitmap(HotKey.scForm2.scShootPanel.Width, HotKey.scForm2.scShootPanel.Height);
                Graphics g;
                g = Graphics.FromImage(bit);
                g.CopyFromScreen(HotKey.scForm2.scShootPanel.Left, HotKey.scForm2.scShootPanel.Top, 0, 0, rect.Size);
                Clipboard.SetImage(bit);
                Show = 0;
            

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
        public async void FileWriter() {
           
            if (TextTlBtnClick == 0)
            {


                var text2 = await chromiumWebBrowser2.EvaluateScriptAsync("document.querySelector('.ryNqvb').textContent");
                var text = await chromiumWebBrowser2.EvaluateScriptAsync("document.querySelector('.D5aOJc, .vJwDU').textContent");
                string lang = text.Result.ToString();
                string Tllang = text2.Result.ToString();

                try
                {
                    reader = new StreamReader(path);
                    string[,] TextListReader = new string[,]
                    {
                    { lang.Trim() + ": " + Tllang,reader.ReadToEnd() }
                    };

                    reader.Close();
                    Thread.Sleep(1000);
                    writer = new StreamWriter(path);
                    writer.WriteLine("");
                    for (int i = 0; i < TextListReader.GetLength(0); i++)
                    {

                        for (int j = 0; j < TextListReader.GetLength(1); j++)
                        {

                            writer.Write(TextListReader[i, j]);


                        }

                    }




                    writer.Close();

                }
                catch (Exception e)
                {
                    MessageBox.Show("Empty path,If you selected a path Please Restard this Application");
                }
            } else if (TextTlBtnClick == 1) {
                var text2 = await chromiumWebBrowser1.EvaluateScriptAsync("document.querySelector('.ryNqvb').textContent");
                var text = await chromiumWebBrowser1.EvaluateScriptAsync("document.querySelector('.D5aOJc, .vJwDU').textContent");
                string lang = text.Result.ToString();
                string Tllang = text2.Result.ToString();

                try
                {
                    reader = new StreamReader(path);
                    string[,] TextListReader = new string[,]
                    {
                    { lang.Trim() + ": " + Tllang,reader.ReadToEnd() }
                    };

                    reader.Close();
                    Thread.Sleep(1000);
                    writer = new StreamWriter(path);
                    writer.WriteLine("");
                    for (int i = 0; i < TextListReader.GetLength(0); i++)
                    {

                        for (int j = 0; j < TextListReader.GetLength(1); j++)
                        {

                            writer.Write(TextListReader[i, j]);


                        }

                    }




                    writer.Close();

                }
                catch (Exception e)
                {
                    MessageBox.Show("Empty path,If you selected a path Please Restard this Application");
                }

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
        public void SaveTextTransLang()
        {
            chromiumWebBrowser1.AddressChanged += ChromiumWebBrowser1_AddressChanged;
        }
        public void SaveImgTransLang()
        {
            chromiumWebBrowser2.AddressChanged += ChromiumWebBrowser2_AddressChanged;
        }

        private void ChromiumWebBrowser2_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            SaveTransLangUrl2 = new StreamWriter("UrlData2.txt");
            SaveTransLangUrl2.Write(e.Address);
           
            SaveTransLangUrl2.Close();
            Thread.Sleep(500);
            string langurl;
            ReadTransLangUrl2 = new StreamReader("UrlData2.txt");
            langurl = ReadTransLangUrl2.ReadLine();
            Settings.Default["SaveUrl2"] = langurl.Substring(43 - 4, 2);
            Settings.Default.Save();
            ReadTransLangUrl2.Close();

        }

        private void ChromiumWebBrowser1_AddressChanged(object sender, AddressChangedEventArgs e)
        {
           // Thread.Sleep(1000);
            SaveTransLangUrl = new StreamWriter("UrlData.txt");
            SaveTransLangUrl.Write(e.Address);
            SaveTransLangUrl.Close();
              Thread.Sleep(500);
            string langurl;
            ReadTransLangUrl = new StreamReader("UrlData.txt");
            langurl = ReadTransLangUrl.ReadLine();
            Settings.Default["SaveUrl1"] = langurl.Substring(43 - 4, 2);
            Settings.Default.Save();
            ReadTransLangUrl.Close();


        }

      
    }
}
