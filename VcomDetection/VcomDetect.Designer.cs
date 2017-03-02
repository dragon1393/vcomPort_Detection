namespace VcomDetection
{
    partial class VcomDetect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VcomDetect));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pid_textBox = new System.Windows.Forms.TextBox();
            this.vid_textBox = new System.Windows.Forms.TextBox();
            this.connectBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.usb_status = new System.Windows.Forms.PictureBox();
            this.titleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usb_status)).BeginInit();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Orchid;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.pid_textBox);
            this.bunifuGradientPanel1.Controls.Add(this.vid_textBox);
            this.bunifuGradientPanel1.Controls.Add(this.connectBtn);
            this.bunifuGradientPanel1.Controls.Add(this.panel2);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Lavender;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(325, 322);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "PID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "VID";
            // 
            // pid_textBox
            // 
            this.pid_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pid_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pid_textBox.Location = new System.Drawing.Point(180, 65);
            this.pid_textBox.Name = "pid_textBox";
            this.pid_textBox.Size = new System.Drawing.Size(79, 20);
            this.pid_textBox.TabIndex = 1;
            this.pid_textBox.Text = "Type Here";
            // 
            // vid_textBox
            // 
            this.vid_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.vid_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vid_textBox.Location = new System.Drawing.Point(71, 65);
            this.vid_textBox.Name = "vid_textBox";
            this.vid_textBox.Size = new System.Drawing.Size(79, 20);
            this.vid_textBox.TabIndex = 0;
            this.vid_textBox.Text = "Type Here";
            // 
            // connectBtn
            // 
            this.connectBtn.Activecolor = System.Drawing.Color.Blue;
            this.connectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.connectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.connectBtn.BorderRadius = 3;
            this.connectBtn.ButtonText = "Connect";
            this.connectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectBtn.DisabledColor = System.Drawing.Color.Gray;
            this.connectBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.connectBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.connectBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("connectBtn.Iconimage")));
            this.connectBtn.Iconimage_right = null;
            this.connectBtn.Iconimage_right_Selected = null;
            this.connectBtn.Iconimage_Selected = null;
            this.connectBtn.IconMarginLeft = 5;
            this.connectBtn.IconMarginRight = 0;
            this.connectBtn.IconRightVisible = true;
            this.connectBtn.IconRightZoom = 0D;
            this.connectBtn.IconVisible = true;
            this.connectBtn.IconZoom = 90D;
            this.connectBtn.IsTab = true;
            this.connectBtn.Location = new System.Drawing.Point(0, 274);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.connectBtn.OnHovercolor = System.Drawing.Color.Blue;
            this.connectBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.connectBtn.selected = true;
            this.connectBtn.Size = new System.Drawing.Size(325, 48);
            this.connectBtn.TabIndex = 3;
            this.connectBtn.Text = "Connect";
            this.connectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.connectBtn.Textcolor = System.Drawing.Color.White;
            this.connectBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBtn.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.usb_status);
            this.panel2.Location = new System.Drawing.Point(71, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 163);
            this.panel2.TabIndex = 2;
            // 
            // usb_status
            // 
            this.usb_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usb_status.Image = ((System.Drawing.Image)(resources.GetObject("usb_status.Image")));
            this.usb_status.Location = new System.Drawing.Point(0, 0);
            this.usb_status.Name = "usb_status";
            this.usb_status.Size = new System.Drawing.Size(188, 163);
            this.usb_status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usb_status.TabIndex = 0;
            this.usb_status.TabStop = false;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.titleBar.Controls.Add(this.label1);
            this.titleBar.Controls.Add(this.pictureBox1);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(325, 39);
            this.titleBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "VCOM Detect";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(291, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.titleBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // VcomDetect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 322);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VcomDetect";
            this.Text = "Vcom Detect";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usb_status)).EndInit();
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox usb_status;
        private Bunifu.Framework.UI.BunifuFlatButton connectBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pid_textBox;
        private System.Windows.Forms.TextBox vid_textBox;
    }
}

