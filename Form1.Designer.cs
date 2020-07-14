namespace DigitalImageProject
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
            this.Load_Image = new System.Windows.Forms.Button();
            this.OpenImageDisplay = new System.Windows.Forms.PictureBox();
            this.Gray_Scale = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.U = new System.Windows.Forms.Button();
            this.V = new System.Windows.Forms.Button();
            this.I = new System.Windows.Forms.Button();
            this.Q = new System.Windows.Forms.Button();
            this.Cr = new System.Windows.Forms.Button();
            this.Cb = new System.Windows.Forms.Button();
            this.Prewitt = new System.Windows.Forms.Button();
            this.Sobel = new System.Windows.Forms.Button();
            this.Robert = new System.Windows.Forms.Button();
            this.ThreshBar = new System.Windows.Forms.HScrollBar();
            this.ThreshLabel = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.SpecialPanel = new System.Windows.Forms.Panel();
            this.SFilterButton = new System.Windows.Forms.Button();
            this.FilterPanel = new System.Windows.Forms.Panel();
            this.FilterButton = new System.Windows.Forms.Button();
            this.EdgePanel = new System.Windows.Forms.Panel();
            this.EdgeButton = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Double = new System.Windows.Forms.Button();
            this.Client = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OpenImageDisplay)).BeginInit();
            this.panelSideMenu.SuspendLayout();
            this.SpecialPanel.SuspendLayout();
            this.FilterPanel.SuspendLayout();
            this.EdgePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Load_Image
            // 
            this.Load_Image.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Load_Image.Location = new System.Drawing.Point(819, 6);
            this.Load_Image.Name = "Load_Image";
            this.Load_Image.Size = new System.Drawing.Size(87, 22);
            this.Load_Image.TabIndex = 0;
            this.Load_Image.Text = "Load Image";
            this.Load_Image.UseVisualStyleBackColor = true;
            this.Load_Image.Click += new System.EventHandler(this.Load_Image_Click);
            // 
            // OpenImageDisplay
            // 
            this.OpenImageDisplay.Location = new System.Drawing.Point(228, 80);
            this.OpenImageDisplay.Name = "OpenImageDisplay";
            this.OpenImageDisplay.Size = new System.Drawing.Size(780, 533);
            this.OpenImageDisplay.TabIndex = 1;
            this.OpenImageDisplay.TabStop = false;
            // 
            // Gray_Scale
            // 
            this.Gray_Scale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Gray_Scale.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gray_Scale.FlatAppearance.BorderSize = 0;
            this.Gray_Scale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gray_Scale.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Gray_Scale.Location = new System.Drawing.Point(0, 0);
            this.Gray_Scale.Name = "Gray_Scale";
            this.Gray_Scale.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Gray_Scale.Size = new System.Drawing.Size(200, 30);
            this.Gray_Scale.TabIndex = 2;
            this.Gray_Scale.Text = "grayscale";
            this.Gray_Scale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Gray_Scale.UseVisualStyleBackColor = false;
            this.Gray_Scale.Click += new System.EventHandler(this.Gray_Scale_Click);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Red.Dock = System.Windows.Forms.DockStyle.Top;
            this.Red.FlatAppearance.BorderSize = 0;
            this.Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Red.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Red.Location = new System.Drawing.Point(0, 30);
            this.Red.Name = "Red";
            this.Red.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Red.Size = new System.Drawing.Size(200, 30);
            this.Red.TabIndex = 3;
            this.Red.Text = "red";
            this.Red.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Red.UseVisualStyleBackColor = false;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Green.Dock = System.Windows.Forms.DockStyle.Top;
            this.Green.FlatAppearance.BorderSize = 0;
            this.Green.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Green.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Green.Location = new System.Drawing.Point(0, 60);
            this.Green.Name = "Green";
            this.Green.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Green.Size = new System.Drawing.Size(200, 30);
            this.Green.TabIndex = 4;
            this.Green.Text = "green";
            this.Green.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Green.UseVisualStyleBackColor = false;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Blue.Dock = System.Windows.Forms.DockStyle.Top;
            this.Blue.FlatAppearance.BorderSize = 0;
            this.Blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Blue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Blue.Location = new System.Drawing.Point(0, 90);
            this.Blue.Name = "Blue";
            this.Blue.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Blue.Size = new System.Drawing.Size(200, 30);
            this.Blue.TabIndex = 5;
            this.Blue.Text = "blue";
            this.Blue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // U
            // 
            this.U.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.U.Dock = System.Windows.Forms.DockStyle.Top;
            this.U.FlatAppearance.BorderSize = 0;
            this.U.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.U.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.U.Location = new System.Drawing.Point(0, 30);
            this.U.Name = "U";
            this.U.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.U.Size = new System.Drawing.Size(200, 30);
            this.U.TabIndex = 6;
            this.U.Text = "U";
            this.U.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.U.UseVisualStyleBackColor = false;
            this.U.Click += new System.EventHandler(this.U_Click);
            // 
            // V
            // 
            this.V.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.V.Dock = System.Windows.Forms.DockStyle.Top;
            this.V.FlatAppearance.BorderSize = 0;
            this.V.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.V.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.V.Location = new System.Drawing.Point(0, 60);
            this.V.Name = "V";
            this.V.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.V.Size = new System.Drawing.Size(200, 30);
            this.V.TabIndex = 7;
            this.V.Text = "V";
            this.V.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.V.UseVisualStyleBackColor = false;
            this.V.Click += new System.EventHandler(this.V_Click);
            // 
            // I
            // 
            this.I.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.I.Dock = System.Windows.Forms.DockStyle.Top;
            this.I.FlatAppearance.BorderSize = 0;
            this.I.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.I.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.I.Location = new System.Drawing.Point(0, 0);
            this.I.Name = "I";
            this.I.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.I.Size = new System.Drawing.Size(200, 30);
            this.I.TabIndex = 8;
            this.I.Text = "I";
            this.I.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.I.UseVisualStyleBackColor = false;
            this.I.Click += new System.EventHandler(this.I_Click);
            // 
            // Q
            // 
            this.Q.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Q.Dock = System.Windows.Forms.DockStyle.Top;
            this.Q.FlatAppearance.BorderSize = 0;
            this.Q.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Q.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Q.Location = new System.Drawing.Point(0, 90);
            this.Q.Name = "Q";
            this.Q.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Q.Size = new System.Drawing.Size(200, 30);
            this.Q.TabIndex = 9;
            this.Q.Text = "Q";
            this.Q.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Q.UseVisualStyleBackColor = false;
            this.Q.Click += new System.EventHandler(this.Q_Click);
            // 
            // Cr
            // 
            this.Cr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Cr.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cr.FlatAppearance.BorderSize = 0;
            this.Cr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cr.Location = new System.Drawing.Point(0, 120);
            this.Cr.Name = "Cr";
            this.Cr.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Cr.Size = new System.Drawing.Size(200, 30);
            this.Cr.TabIndex = 10;
            this.Cr.Text = "Cr";
            this.Cr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cr.UseVisualStyleBackColor = false;
            this.Cr.Click += new System.EventHandler(this.Cr_Click);
            // 
            // Cb
            // 
            this.Cb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Cb.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cb.FlatAppearance.BorderSize = 0;
            this.Cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cb.Location = new System.Drawing.Point(0, 150);
            this.Cb.Name = "Cb";
            this.Cb.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Cb.Size = new System.Drawing.Size(200, 30);
            this.Cb.TabIndex = 11;
            this.Cb.Text = "Cb";
            this.Cb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cb.UseVisualStyleBackColor = false;
            this.Cb.Click += new System.EventHandler(this.Cb_Click);
            // 
            // Prewitt
            // 
            this.Prewitt.Dock = System.Windows.Forms.DockStyle.Top;
            this.Prewitt.FlatAppearance.BorderSize = 0;
            this.Prewitt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prewitt.Location = new System.Drawing.Point(0, 60);
            this.Prewitt.Name = "Prewitt";
            this.Prewitt.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Prewitt.Size = new System.Drawing.Size(200, 29);
            this.Prewitt.TabIndex = 12;
            this.Prewitt.Text = "Prewitt";
            this.Prewitt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Prewitt.UseVisualStyleBackColor = true;
            this.Prewitt.Click += new System.EventHandler(this.Prewitt_Click);
            // 
            // Sobel
            // 
            this.Sobel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sobel.FlatAppearance.BorderSize = 0;
            this.Sobel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sobel.Location = new System.Drawing.Point(0, 30);
            this.Sobel.Name = "Sobel";
            this.Sobel.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Sobel.Size = new System.Drawing.Size(200, 30);
            this.Sobel.TabIndex = 13;
            this.Sobel.Text = "Sobel";
            this.Sobel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sobel.UseVisualStyleBackColor = true;
            this.Sobel.Click += new System.EventHandler(this.Sobel_Click);
            // 
            // Robert
            // 
            this.Robert.Dock = System.Windows.Forms.DockStyle.Top;
            this.Robert.FlatAppearance.BorderSize = 0;
            this.Robert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Robert.Location = new System.Drawing.Point(0, 0);
            this.Robert.Name = "Robert";
            this.Robert.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Robert.Size = new System.Drawing.Size(200, 30);
            this.Robert.TabIndex = 14;
            this.Robert.Text = "Robert";
            this.Robert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Robert.UseVisualStyleBackColor = true;
            this.Robert.Click += new System.EventHandler(this.Robert_Click);
            // 
            // ThreshBar
            // 
            this.ThreshBar.Location = new System.Drawing.Point(203, 2);
            this.ThreshBar.Maximum = 255;
            this.ThreshBar.Name = "ThreshBar";
            this.ThreshBar.Size = new System.Drawing.Size(156, 26);
            this.ThreshBar.TabIndex = 15;
            this.ThreshBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ThreshBar_Scroll);
            // 
            // ThreshLabel
            // 
            this.ThreshLabel.AutoSize = true;
            this.ThreshLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ThreshLabel.Location = new System.Drawing.Point(410, 6);
            this.ThreshLabel.Name = "ThreshLabel";
            this.ThreshLabel.Size = new System.Drawing.Size(54, 13);
            this.ThreshLabel.TabIndex = 16;
            this.ThreshLabel.Text = "Threshold";
            // 
            // Exit
            // 
            this.Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.Location = new System.Drawing.Point(912, 6);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(96, 22);
            this.Exit.TabIndex = 18;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.SpecialPanel);
            this.panelSideMenu.Controls.Add(this.SFilterButton);
            this.panelSideMenu.Controls.Add(this.FilterPanel);
            this.panelSideMenu.Controls.Add(this.FilterButton);
            this.panelSideMenu.Controls.Add(this.EdgePanel);
            this.panelSideMenu.Controls.Add(this.EdgeButton);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 626);
            this.panelSideMenu.TabIndex = 19;
            // 
            // SpecialPanel
            // 
            this.SpecialPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.SpecialPanel.Controls.Add(this.Cb);
            this.SpecialPanel.Controls.Add(this.Cr);
            this.SpecialPanel.Controls.Add(this.Q);
            this.SpecialPanel.Controls.Add(this.V);
            this.SpecialPanel.Controls.Add(this.U);
            this.SpecialPanel.Controls.Add(this.I);
            this.SpecialPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SpecialPanel.Location = new System.Drawing.Point(0, 433);
            this.SpecialPanel.Name = "SpecialPanel";
            this.SpecialPanel.Size = new System.Drawing.Size(200, 186);
            this.SpecialPanel.TabIndex = 21;
            // 
            // SFilterButton
            // 
            this.SFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.SFilterButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SFilterButton.FlatAppearance.BorderSize = 0;
            this.SFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SFilterButton.Location = new System.Drawing.Point(0, 388);
            this.SFilterButton.Name = "SFilterButton";
            this.SFilterButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.SFilterButton.Size = new System.Drawing.Size(200, 45);
            this.SFilterButton.TabIndex = 21;
            this.SFilterButton.Text = "Special Filters";
            this.SFilterButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SFilterButton.UseVisualStyleBackColor = false;
            this.SFilterButton.Click += new System.EventHandler(this.SFilterButton_Click);
            // 
            // FilterPanel
            // 
            this.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.FilterPanel.Controls.Add(this.Blue);
            this.FilterPanel.Controls.Add(this.Green);
            this.FilterPanel.Controls.Add(this.Red);
            this.FilterPanel.Controls.Add(this.Gray_Scale);
            this.FilterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterPanel.Location = new System.Drawing.Point(0, 265);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(200, 123);
            this.FilterPanel.TabIndex = 21;
            // 
            // FilterButton
            // 
            this.FilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.FilterButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterButton.FlatAppearance.BorderSize = 0;
            this.FilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterButton.Location = new System.Drawing.Point(0, 220);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.FilterButton.Size = new System.Drawing.Size(200, 45);
            this.FilterButton.TabIndex = 21;
            this.FilterButton.Text = "Filters";
            this.FilterButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FilterButton.UseVisualStyleBackColor = false;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // EdgePanel
            // 
            this.EdgePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.EdgePanel.Controls.Add(this.Prewitt);
            this.EdgePanel.Controls.Add(this.Sobel);
            this.EdgePanel.Controls.Add(this.Robert);
            this.EdgePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EdgePanel.Location = new System.Drawing.Point(0, 125);
            this.EdgePanel.Name = "EdgePanel";
            this.EdgePanel.Size = new System.Drawing.Size(200, 95);
            this.EdgePanel.TabIndex = 20;
            // 
            // EdgeButton
            // 
            this.EdgeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EdgeButton.FlatAppearance.BorderSize = 0;
            this.EdgeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EdgeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EdgeButton.Location = new System.Drawing.Point(0, 80);
            this.EdgeButton.Name = "EdgeButton";
            this.EdgeButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.EdgeButton.Size = new System.Drawing.Size(200, 45);
            this.EdgeButton.TabIndex = 0;
            this.EdgeButton.Text = "Edge Detectors";
            this.EdgeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EdgeButton.UseVisualStyleBackColor = true;
            this.EdgeButton.Click += new System.EventHandler(this.EdgeButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 80);
            this.panelLogo.TabIndex = 20;
            // 
            // Double
            // 
            this.Double.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Double.Location = new System.Drawing.Point(228, 46);
            this.Double.Name = "Double";
            this.Double.Size = new System.Drawing.Size(76, 28);
            this.Double.TabIndex = 21;
            this.Double.Text = "Double";
            this.Double.UseVisualStyleBackColor = true;
            this.Double.Click += new System.EventHandler(this.Double_Click);
            // 
            // Client
            // 
            this.Client.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Client.Location = new System.Drawing.Point(325, 46);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(80, 28);
            this.Client.TabIndex = 22;
            this.Client.Text = "Classify";
            this.Client.UseVisualStyleBackColor = true;
            this.Client.Click += new System.EventHandler(this.Client_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 626);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.Double);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.OpenImageDisplay);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ThreshBar);
            this.Controls.Add(this.ThreshLabel);
            this.Controls.Add(this.Load_Image);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OpenImageDisplay)).EndInit();
            this.panelSideMenu.ResumeLayout(false);
            this.SpecialPanel.ResumeLayout(false);
            this.FilterPanel.ResumeLayout(false);
            this.EdgePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Load_Image;
        private System.Windows.Forms.PictureBox OpenImageDisplay;
        private System.Windows.Forms.Button Gray_Scale;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button U;
        private System.Windows.Forms.Button V;
        private System.Windows.Forms.Button I;
        private System.Windows.Forms.Button Q;
        private System.Windows.Forms.Button Cr;
        private System.Windows.Forms.Button Cb;
        private System.Windows.Forms.Button Prewitt;
        private System.Windows.Forms.Button Sobel;
        private System.Windows.Forms.Button Robert;
        private System.Windows.Forms.HScrollBar ThreshBar;
        private System.Windows.Forms.Label ThreshLabel;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel EdgePanel;
        private System.Windows.Forms.Button EdgeButton;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel SpecialPanel;
        private System.Windows.Forms.Button SFilterButton;
        private System.Windows.Forms.Panel FilterPanel;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button Double;
        private System.Windows.Forms.Button Client;
    }
}

