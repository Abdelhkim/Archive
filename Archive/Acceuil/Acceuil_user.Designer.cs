namespace Acceuil
{
    partial class Acceuil_user
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceuil_user));
            this.Acceuil_panel = new System.Windows.Forms.Panel();
            this.Card_Graph_Holder = new Bunifu.Framework.UI.BunifuCards();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.Card_Total_Holder = new Bunifu.Framework.UI.BunifuCards();
            this.Total_Boxs_Gradian_Panel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Total_Folders_Gradian_Panel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Total_Transfers_Gradian_panel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Card_Tribunal_Holder = new Bunifu.Framework.UI.BunifuCards();
            this.Acceuil_panel.SuspendLayout();
            this.Card_Graph_Holder.SuspendLayout();
            this.Card_Total_Holder.SuspendLayout();
            this.Total_Boxs_Gradian_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Total_Folders_Gradian_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.Total_Transfers_Gradian_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Acceuil_panel
            // 
            this.Acceuil_panel.Controls.Add(this.Card_Tribunal_Holder);
            this.Acceuil_panel.Controls.Add(this.Card_Graph_Holder);
            this.Acceuil_panel.Controls.Add(this.Card_Total_Holder);
            this.Acceuil_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Acceuil_panel.Location = new System.Drawing.Point(0, 0);
            this.Acceuil_panel.Name = "Acceuil_panel";
            this.Acceuil_panel.Size = new System.Drawing.Size(748, 597);
            this.Acceuil_panel.TabIndex = 5;
            this.Acceuil_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Acceuil_panel_Paint);
            // 
            // Card_Graph_Holder
            // 
            this.Card_Graph_Holder.BackColor = System.Drawing.Color.White;
            this.Card_Graph_Holder.BorderRadius = 0;
            this.Card_Graph_Holder.BottomSahddow = true;
            this.Card_Graph_Holder.color = System.Drawing.Color.Transparent;
            this.Card_Graph_Holder.Controls.Add(this.cartesianChart1);
            this.Card_Graph_Holder.Dock = System.Windows.Forms.DockStyle.Top;
            this.Card_Graph_Holder.LeftSahddow = false;
            this.Card_Graph_Holder.Location = new System.Drawing.Point(236, 0);
            this.Card_Graph_Holder.Name = "Card_Graph_Holder";
            this.Card_Graph_Holder.RightSahddow = true;
            this.Card_Graph_Holder.ShadowDepth = 20;
            this.Card_Graph_Holder.Size = new System.Drawing.Size(512, 296);
            this.Card_Graph_Holder.TabIndex = 1;
            this.Card_Graph_Holder.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards2_Paint);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.BackColor = System.Drawing.Color.Maroon;
            this.cartesianChart1.BackColorTransparent = true;
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartesianChart1.Location = new System.Drawing.Point(0, 0);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cartesianChart1.Size = new System.Drawing.Size(512, 296);
            this.cartesianChart1.TabIndex = 1;
            this.cartesianChart1.Text = "cartesianChart1";
            this.cartesianChart1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.cartesianChart1_ChildChanged);
            // 
            // Card_Total_Holder
            // 
            this.Card_Total_Holder.BackColor = System.Drawing.Color.White;
            this.Card_Total_Holder.BorderRadius = 0;
            this.Card_Total_Holder.BottomSahddow = true;
            this.Card_Total_Holder.color = System.Drawing.Color.Transparent;
            this.Card_Total_Holder.Controls.Add(this.Total_Boxs_Gradian_Panel);
            this.Card_Total_Holder.Controls.Add(this.Total_Folders_Gradian_Panel);
            this.Card_Total_Holder.Controls.Add(this.Total_Transfers_Gradian_panel);
            this.Card_Total_Holder.Dock = System.Windows.Forms.DockStyle.Left;
            this.Card_Total_Holder.LeftSahddow = false;
            this.Card_Total_Holder.Location = new System.Drawing.Point(0, 0);
            this.Card_Total_Holder.Name = "Card_Total_Holder";
            this.Card_Total_Holder.RightSahddow = true;
            this.Card_Total_Holder.ShadowDepth = 20;
            this.Card_Total_Holder.Size = new System.Drawing.Size(236, 597);
            this.Card_Total_Holder.TabIndex = 0;
            this.Card_Total_Holder.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // Total_Boxs_Gradian_Panel
            // 
            this.Total_Boxs_Gradian_Panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Total_Boxs_Gradian_Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Total_Boxs_Gradian_Panel.BackgroundImage")));
            this.Total_Boxs_Gradian_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Total_Boxs_Gradian_Panel.Controls.Add(this.label2);
            this.Total_Boxs_Gradian_Panel.Controls.Add(this.label5);
            this.Total_Boxs_Gradian_Panel.Controls.Add(this.pictureBox3);
            this.Total_Boxs_Gradian_Panel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(105)))));
            this.Total_Boxs_Gradian_Panel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.Total_Boxs_Gradian_Panel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(141)))));
            this.Total_Boxs_Gradian_Panel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(104)))));
            this.Total_Boxs_Gradian_Panel.Location = new System.Drawing.Point(15, 213);
            this.Total_Boxs_Gradian_Panel.Name = "Total_Boxs_Gradian_Panel";
            this.Total_Boxs_Gradian_Panel.Quality = 20;
            this.Total_Boxs_Gradian_Panel.Size = new System.Drawing.Size(207, 170);
            this.Total_Boxs_Gradian_Panel.TabIndex = 2;
            this.Total_Boxs_Gradian_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("GE SS Unique Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "مجموع العلب";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 73);
            this.label5.TabIndex = 5;
            this.label5.Text = "720";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Acceuil.Properties.Resources.boxes_white;
            this.pictureBox3.Location = new System.Drawing.Point(68, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Total_Folders_Gradian_Panel
            // 
            this.Total_Folders_Gradian_Panel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Total_Folders_Gradian_Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Total_Folders_Gradian_Panel.BackgroundImage")));
            this.Total_Folders_Gradian_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Total_Folders_Gradian_Panel.Controls.Add(this.label3);
            this.Total_Folders_Gradian_Panel.Controls.Add(this.label6);
            this.Total_Folders_Gradian_Panel.Controls.Add(this.pictureBox4);
            this.Total_Folders_Gradian_Panel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(209)))), ((int)(((byte)(158)))));
            this.Total_Folders_Gradian_Panel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(115)))), ((int)(((byte)(129)))));
            this.Total_Folders_Gradian_Panel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(98)))), ((int)(((byte)(211)))));
            this.Total_Folders_Gradian_Panel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(209)))), ((int)(((byte)(156)))));
            this.Total_Folders_Gradian_Panel.Location = new System.Drawing.Point(15, 414);
            this.Total_Folders_Gradian_Panel.Name = "Total_Folders_Gradian_Panel";
            this.Total_Folders_Gradian_Panel.Quality = 20;
            this.Total_Folders_Gradian_Panel.Size = new System.Drawing.Size(207, 170);
            this.Total_Folders_Gradian_Panel.TabIndex = 2;
            this.Total_Folders_Gradian_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel3_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("GE SS Unique Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "مجموع الملفات";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 73);
            this.label6.TabIndex = 6;
            this.label6.Text = "1820";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Acceuil.Properties.Resources.Folders_white;
            this.pictureBox4.Location = new System.Drawing.Point(69, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(71, 71);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Total_Transfers_Gradian_panel
            // 
            this.Total_Transfers_Gradian_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Total_Transfers_Gradian_panel.BackgroundImage")));
            this.Total_Transfers_Gradian_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Total_Transfers_Gradian_panel.Controls.Add(this.label1);
            this.Total_Transfers_Gradian_panel.Controls.Add(this.label4);
            this.Total_Transfers_Gradian_panel.Controls.Add(this.pictureBox2);
            this.Total_Transfers_Gradian_panel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(213)))), ((int)(((byte)(230)))));
            this.Total_Transfers_Gradian_panel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(253)))));
            this.Total_Transfers_Gradian_panel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.Total_Transfers_Gradian_panel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(194)))), ((int)(((byte)(240)))));
            this.Total_Transfers_Gradian_panel.Location = new System.Drawing.Point(16, 12);
            this.Total_Transfers_Gradian_panel.Name = "Total_Transfers_Gradian_panel";
            this.Total_Transfers_Gradian_panel.Quality = 20;
            this.Total_Transfers_Gradian_panel.Size = new System.Drawing.Size(207, 170);
            this.Total_Transfers_Gradian_panel.TabIndex = 1;
            this.Total_Transfers_Gradian_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("GE SS Unique Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "مجموع التحويلات";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 73);
            this.label4.TabIndex = 4;
            this.label4.Text = "120";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Acceuil.Properties.Resources.man_dragingBoxs_white;
            this.pictureBox2.Location = new System.Drawing.Point(67, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Card_Tribunal_Holder
            // 
            this.Card_Tribunal_Holder.BackColor = System.Drawing.Color.White;
            this.Card_Tribunal_Holder.BorderRadius = 0;
            this.Card_Tribunal_Holder.BottomSahddow = true;
            this.Card_Tribunal_Holder.color = System.Drawing.Color.Transparent;
            this.Card_Tribunal_Holder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Card_Tribunal_Holder.LeftSahddow = false;
            this.Card_Tribunal_Holder.Location = new System.Drawing.Point(236, 296);
            this.Card_Tribunal_Holder.Name = "Card_Tribunal_Holder";
            this.Card_Tribunal_Holder.RightSahddow = true;
            this.Card_Tribunal_Holder.ShadowDepth = 20;
            this.Card_Tribunal_Holder.Size = new System.Drawing.Size(512, 301);
            this.Card_Tribunal_Holder.TabIndex = 2;
            this.Card_Tribunal_Holder.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards3_Paint);
            // 
            // Acceuil_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Acceuil_panel);
            this.Name = "Acceuil_user";
            this.Size = new System.Drawing.Size(748, 597);
            this.Load += new System.EventHandler(this.Acceuil_Load);
            this.Acceuil_panel.ResumeLayout(false);
            this.Card_Graph_Holder.ResumeLayout(false);
            this.Card_Total_Holder.ResumeLayout(false);
            this.Total_Boxs_Gradian_Panel.ResumeLayout(false);
            this.Total_Boxs_Gradian_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Total_Folders_Gradian_Panel.ResumeLayout(false);
            this.Total_Folders_Gradian_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.Total_Transfers_Gradian_panel.ResumeLayout(false);
            this.Total_Transfers_Gradian_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel Acceuil_panel;
        public Bunifu.Framework.UI.BunifuCards Card_Graph_Holder;
        public LiveCharts.WinForms.CartesianChart cartesianChart1;
        public Bunifu.Framework.UI.BunifuCards Card_Total_Holder;
        public Bunifu.Framework.UI.BunifuGradientPanel Total_Boxs_Gradian_Panel;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.PictureBox pictureBox3;
        public Bunifu.Framework.UI.BunifuGradientPanel Total_Folders_Gradian_Panel;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.PictureBox pictureBox4;
        public Bunifu.Framework.UI.BunifuGradientPanel Total_Transfers_Gradian_panel;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.PictureBox pictureBox2;
        public Bunifu.Framework.UI.BunifuCards Card_Tribunal_Holder;
    }
}
