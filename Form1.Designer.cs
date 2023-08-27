namespace QuicklyTranslate
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextTranslateBT = new System.Windows.Forms.Button();
            this.ImgTranslateBT = new System.Windows.Forms.Button();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.CloseBT = new System.Windows.Forms.Button();
            this.MinisizeBT = new System.Windows.Forms.Button();
            this.ImgTransForm = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ImgPanel = new System.Windows.Forms.Panel();
            this.chromiumWebBrowser2 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.ShowscSnip = new System.Windows.Forms.Button();
            this.HideBt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuickOP = new System.Windows.Forms.Button();
            this.btnHideQOP = new System.Windows.Forms.Button();
            this.WriteToFilebtn = new System.Windows.Forms.Button();
            this.CreateFilebtn = new System.Windows.Forms.Button();
            this.ChooseFilebtn = new System.Windows.Forms.Button();
            this.ImgTransForm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextTranslateBT
            // 
            this.TextTranslateBT.BackColor = System.Drawing.SystemColors.Highlight;
            this.TextTranslateBT.FlatAppearance.BorderSize = 0;
            this.TextTranslateBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TextTranslateBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.TextTranslateBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextTranslateBT.Location = new System.Drawing.Point(12, 12);
            this.TextTranslateBT.Name = "TextTranslateBT";
            this.TextTranslateBT.Size = new System.Drawing.Size(135, 25);
            this.TextTranslateBT.TabIndex = 0;
            this.TextTranslateBT.Text = "TranslateSelectedText";
            this.TextTranslateBT.UseVisualStyleBackColor = false;
            this.TextTranslateBT.Click += new System.EventHandler(this.TextTranslateBT_Click);
            this.TextTranslateBT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextTranslateBT_KeyDown);
            // 
            // ImgTranslateBT
            // 
            this.ImgTranslateBT.BackColor = System.Drawing.SystemColors.Highlight;
            this.ImgTranslateBT.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.ImgTranslateBT.FlatAppearance.BorderSize = 0;
            this.ImgTranslateBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImgTranslateBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.ImgTranslateBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ImgTranslateBT.Location = new System.Drawing.Point(153, 12);
            this.ImgTranslateBT.Name = "ImgTranslateBT";
            this.ImgTranslateBT.Size = new System.Drawing.Size(108, 25);
            this.ImgTranslateBT.TabIndex = 1;
            this.ImgTranslateBT.Text = "ImgTranslate";
            this.ImgTranslateBT.UseVisualStyleBackColor = false;
            this.ImgTranslateBT.Click += new System.EventHandler(this.ImgTranslateBT_Click);
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(1, 42);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(1213, 603);
            this.chromiumWebBrowser1.TabIndex = 2;
            this.chromiumWebBrowser1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chromiumWebBrowser1_KeyDown);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // CloseBT
            // 
            this.CloseBT.Location = new System.Drawing.Point(152, 0);
            this.CloseBT.Name = "CloseBT";
            this.CloseBT.Size = new System.Drawing.Size(29, 25);
            this.CloseBT.TabIndex = 3;
            this.CloseBT.Text = "X";
            this.CloseBT.UseVisualStyleBackColor = true;
            this.CloseBT.Click += new System.EventHandler(this.CloseBT_Click);
            // 
            // MinisizeBT
            // 
            this.MinisizeBT.Location = new System.Drawing.Point(119, 0);
            this.MinisizeBT.Name = "MinisizeBT";
            this.MinisizeBT.Size = new System.Drawing.Size(29, 25);
            this.MinisizeBT.TabIndex = 4;
            this.MinisizeBT.Text = "_";
            this.MinisizeBT.UseVisualStyleBackColor = true;
            this.MinisizeBT.Click += new System.EventHandler(this.MinisizeBT_Click);
            // 
            // ImgTransForm
            // 
            this.ImgTransForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgTransForm.Controls.Add(this.panel2);
            this.ImgTransForm.Controls.Add(this.label1);
            this.ImgTransForm.Controls.Add(this.ImgPanel);
            this.ImgTransForm.Location = new System.Drawing.Point(1, 42);
            this.ImgTransForm.Name = "ImgTransForm";
            this.ImgTransForm.Size = new System.Drawing.Size(1224, 637);
            this.ImgTransForm.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(847, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 55);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image";
            // 
            // ImgPanel
            // 
            this.ImgPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImgPanel.BackgroundImage = global::QuicklyTranslate.Properties.Resources.f74d9f4a_2dbd_4513_8233_f90bc5d01083;
            this.ImgPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgPanel.Location = new System.Drawing.Point(11, 31);
            this.ImgPanel.Name = "ImgPanel";
            this.ImgPanel.Size = new System.Drawing.Size(454, 603);
            this.ImgPanel.TabIndex = 0;
            // 
            // chromiumWebBrowser2
            // 
            this.chromiumWebBrowser2.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser2.Location = new System.Drawing.Point(471, 31);
            this.chromiumWebBrowser2.Name = "chromiumWebBrowser2";
            this.chromiumWebBrowser2.Size = new System.Drawing.Size(750, 603);
            this.chromiumWebBrowser2.TabIndex = 4;
            this.chromiumWebBrowser2.LoadingStateChanged += new System.EventHandler<CefSharp.LoadingStateChangedEventArgs>(this.chromiumWebBrowser2_LoadingStateChanged);
            // 
            // ShowscSnip
            // 
            this.ShowscSnip.BackColor = System.Drawing.SystemColors.Highlight;
            this.ShowscSnip.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.ShowscSnip.FlatAppearance.BorderSize = 0;
            this.ShowscSnip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowscSnip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.ShowscSnip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShowscSnip.Location = new System.Drawing.Point(267, 12);
            this.ShowscSnip.Name = "ShowscSnip";
            this.ShowscSnip.Size = new System.Drawing.Size(73, 25);
            this.ShowscSnip.TabIndex = 7;
            this.ShowscSnip.Text = "Snip";
            this.ShowscSnip.UseVisualStyleBackColor = false;
            this.ShowscSnip.Click += new System.EventHandler(this.ShowscSnip_Click);
            // 
            // HideBt
            // 
            this.HideBt.Location = new System.Drawing.Point(74, 0);
            this.HideBt.Name = "HideBt";
            this.HideBt.Size = new System.Drawing.Size(41, 25);
            this.HideBt.TabIndex = 8;
            this.HideBt.Text = "Hide";
            this.HideBt.UseVisualStyleBackColor = true;
            this.HideBt.Click += new System.EventHandler(this.HideBt_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.CloseBT);
            this.panel1.Controls.Add(this.HideBt);
            this.panel1.Controls.Add(this.MinisizeBT);
            this.panel1.Location = new System.Drawing.Point(1018, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 28);
            this.panel1.TabIndex = 5;
            // 
            // btnQuickOP
            // 
            this.btnQuickOP.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnQuickOP.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnQuickOP.FlatAppearance.BorderSize = 0;
            this.btnQuickOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickOP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuickOP.Location = new System.Drawing.Point(346, 12);
            this.btnQuickOP.Name = "btnQuickOP";
            this.btnQuickOP.Size = new System.Drawing.Size(86, 26);
            this.btnQuickOP.TabIndex = 8;
            this.btnQuickOP.Text = "ShowQOPbtn";
            this.btnQuickOP.UseVisualStyleBackColor = false;
            this.btnQuickOP.Click += new System.EventHandler(this.btnQuickOP_Click);
            // 
            // btnHideQOP
            // 
            this.btnHideQOP.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnHideQOP.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHideQOP.FlatAppearance.BorderSize = 0;
            this.btnHideQOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideQOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideQOP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHideQOP.Location = new System.Drawing.Point(438, 12);
            this.btnHideQOP.Name = "btnHideQOP";
            this.btnHideQOP.Size = new System.Drawing.Size(86, 26);
            this.btnHideQOP.TabIndex = 9;
            this.btnHideQOP.Text = "HideQOPbtn";
            this.btnHideQOP.UseVisualStyleBackColor = false;
            this.btnHideQOP.Click += new System.EventHandler(this.btnHideQOP_Click);
            // 
            // WriteToFilebtn
            // 
            this.WriteToFilebtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.WriteToFilebtn.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.WriteToFilebtn.FlatAppearance.BorderSize = 0;
            this.WriteToFilebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WriteToFilebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteToFilebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WriteToFilebtn.Location = new System.Drawing.Point(530, 12);
            this.WriteToFilebtn.Name = "WriteToFilebtn";
            this.WriteToFilebtn.Size = new System.Drawing.Size(86, 26);
            this.WriteToFilebtn.TabIndex = 10;
            this.WriteToFilebtn.Text = "WriteToFile";
            this.WriteToFilebtn.UseVisualStyleBackColor = false;
            this.WriteToFilebtn.Click += new System.EventHandler(this.WriteToFilebtn_Click);
            // 
            // CreateFilebtn
            // 
            this.CreateFilebtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.CreateFilebtn.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.CreateFilebtn.FlatAppearance.BorderSize = 0;
            this.CreateFilebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateFilebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateFilebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreateFilebtn.Location = new System.Drawing.Point(622, 12);
            this.CreateFilebtn.Name = "CreateFilebtn";
            this.CreateFilebtn.Size = new System.Drawing.Size(86, 26);
            this.CreateFilebtn.TabIndex = 11;
            this.CreateFilebtn.Text = "CreateFile";
            this.CreateFilebtn.UseVisualStyleBackColor = false;
            this.CreateFilebtn.Click += new System.EventHandler(this.CreateFilebtn_Click);
            // 
            // ChooseFilebtn
            // 
            this.ChooseFilebtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.ChooseFilebtn.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.ChooseFilebtn.FlatAppearance.BorderSize = 0;
            this.ChooseFilebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseFilebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseFilebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChooseFilebtn.Location = new System.Drawing.Point(714, 12);
            this.ChooseFilebtn.Name = "ChooseFilebtn";
            this.ChooseFilebtn.Size = new System.Drawing.Size(86, 26);
            this.ChooseFilebtn.TabIndex = 12;
            this.ChooseFilebtn.Text = "ChooseFile";
            this.ChooseFilebtn.UseVisualStyleBackColor = false;
            this.ChooseFilebtn.Click += new System.EventHandler(this.ChooseFilebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1225, 681);
            this.ControlBox = false;
            this.Controls.Add(this.ChooseFilebtn);
            this.Controls.Add(this.CreateFilebtn);
            this.Controls.Add(this.WriteToFilebtn);
            this.Controls.Add(this.btnHideQOP);
            this.Controls.Add(this.btnQuickOP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ShowscSnip);
            this.Controls.Add(this.ImgTransForm);
            this.Controls.Add(this.TextTranslateBT);
            this.Controls.Add(this.ImgTranslateBT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ME may";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ImgTransForm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TextTranslateBT;
        private System.Windows.Forms.Button ImgTranslateBT;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private System.Windows.Forms.Button CloseBT;
        private System.Windows.Forms.Button MinisizeBT;
        private System.Windows.Forms.Panel ImgTransForm;
        private System.Windows.Forms.Panel ImgPanel;
        private System.Windows.Forms.Label label1;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser2;
        private System.Windows.Forms.Button ShowscSnip;
        public System.Windows.Forms.Button HideBt;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnQuickOP;
        private System.Windows.Forms.Button btnHideQOP;
        private System.Windows.Forms.Button WriteToFilebtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CreateFilebtn;
        private System.Windows.Forms.Button ChooseFilebtn;
    }
}

