namespace Acceuil
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
            this.Header = new System.Windows.Forms.Panel();
            this.Minimise_pictureBox = new System.Windows.Forms.PictureBox();
            this.Close_pictureBox = new System.Windows.Forms.PictureBox();
            this.Title_Lable = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Maximise_pictureBox = new System.Windows.Forms.PictureBox();
            this.Humbutton = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Add_Verssement_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Home_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.User_name_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.User_PicturBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.acceuil_user1 = new Acceuil.Acceuil_user();
            this.add_Transer1 = new Acceuil.Add_Transer();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimise_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximise_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Humbutton)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_PicturBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            this.Header.Controls.Add(this.Minimise_pictureBox);
            this.Header.Controls.Add(this.Close_pictureBox);
            this.Header.Controls.Add(this.Title_Lable);
            this.Header.Controls.Add(this.Maximise_pictureBox);
            this.Header.Controls.Add(this.Humbutton);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(937, 62);
            this.Header.TabIndex = 2;
            this.Header.DoubleClick += new System.EventHandler(this.Header_DoubleClick);
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // Minimise_pictureBox
            // 
            this.Minimise_pictureBox.Image = global::Acceuil.Properties.Resources.close;
            this.Minimise_pictureBox.Location = new System.Drawing.Point(12, 22);
            this.Minimise_pictureBox.Name = "Minimise_pictureBox";
            this.Minimise_pictureBox.Size = new System.Drawing.Size(16, 16);
            this.Minimise_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimise_pictureBox.TabIndex = 7;
            this.Minimise_pictureBox.TabStop = false;
            this.Minimise_pictureBox.Click += new System.EventHandler(this.Minimise_pictureBox_Click);
            // 
            // Close_pictureBox
            // 
            this.Close_pictureBox.Image = global::Acceuil.Properties.Resources.Reduire;
            this.Close_pictureBox.Location = new System.Drawing.Point(83, 27);
            this.Close_pictureBox.Name = "Close_pictureBox";
            this.Close_pictureBox.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Close_pictureBox.Size = new System.Drawing.Size(16, 16);
            this.Close_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_pictureBox.TabIndex = 5;
            this.Close_pictureBox.TabStop = false;
            this.Close_pictureBox.Click += new System.EventHandler(this.Close_pictureBox_Click);
            // 
            // Title_Lable
            // 
            this.Title_Lable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Title_Lable.AutoSize = true;
            this.Title_Lable.Font = new System.Drawing.Font("GE SS Unique Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Title_Lable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title_Lable.Location = new System.Drawing.Point(770, 21);
            this.Title_Lable.Name = "Title_Lable";
            this.Title_Lable.Size = new System.Drawing.Size(127, 28);
            this.Title_Lable.TabIndex = 2;
            this.Title_Lable.Text = "تدبير الأرشيف";
            // 
            // Maximise_pictureBox
            // 
            this.Maximise_pictureBox.Image = global::Acceuil.Properties.Resources.Agrendire;
            this.Maximise_pictureBox.Location = new System.Drawing.Point(47, 22);
            this.Maximise_pictureBox.Name = "Maximise_pictureBox";
            this.Maximise_pictureBox.Size = new System.Drawing.Size(16, 16);
            this.Maximise_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Maximise_pictureBox.TabIndex = 6;
            this.Maximise_pictureBox.TabStop = false;
            this.Maximise_pictureBox.Click += new System.EventHandler(this.Maximise_pictureBox_Click);
            // 
            // Humbutton
            // 
            this.Humbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Humbutton.BackColor = System.Drawing.Color.Transparent;
            this.Humbutton.Image = global::Acceuil.Properties.Resources.menu;
            this.Humbutton.ImageActive = null;
            this.Humbutton.Location = new System.Drawing.Point(899, 16);
            this.Humbutton.Name = "Humbutton";
            this.Humbutton.Size = new System.Drawing.Size(30, 30);
            this.Humbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Humbutton.TabIndex = 1;
            this.Humbutton.TabStop = false;
            this.Humbutton.Zoom = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.bunifuFlatButton7);
            this.panel1.Controls.Add(this.bunifuFlatButton6);
            this.panel1.Controls.Add(this.bunifuFlatButton5);
            this.panel1.Controls.Add(this.bunifuFlatButton4);
            this.panel1.Controls.Add(this.bunifuFlatButton3);
            this.panel1.Controls.Add(this.bunifuFlatButton2);
            this.panel1.Controls.Add(this.Add_Verssement_Button);
            this.panel1.Controls.Add(this.Home_Button);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(748, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 597);
            this.panel1.TabIndex = 3;
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "المساعدة ";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = null;
            this.bunifuFlatButton7.Iconimage_right = global::Acceuil.Properties.Resources.info;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 60D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(0, 514);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(189, 48);
            this.bunifuFlatButton7.TabIndex = 9;
            this.bunifuFlatButton7.Text = "المساعدة ";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("GE SS Unique Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "تسجيل الخروج ";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = null;
            this.bunifuFlatButton6.Iconimage_right = global::Acceuil.Properties.Resources.logout;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 60D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(0, 466);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(189, 48);
            this.bunifuFlatButton6.TabIndex = 8;
            this.bunifuFlatButton6.Text = "تسجيل الخروج ";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("GE SS Unique Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = " الملف الشخصي ";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = null;
            this.bunifuFlatButton5.Iconimage_right = global::Acceuil.Properties.Resources.users;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 60D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(0, 418);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(189, 48);
            this.bunifuFlatButton5.TabIndex = 7;
            this.bunifuFlatButton5.Text = " الملف الشخصي ";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("GE SS Unique Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = " مراجعة الملفات ";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = null;
            this.bunifuFlatButton4.Iconimage_right = global::Acceuil.Properties.Resources.archive;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 60D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(0, 370);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(189, 48);
            this.bunifuFlatButton4.TabIndex = 6;
            this.bunifuFlatButton4.Text = " مراجعة الملفات ";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("GE SS Unique Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = " مراجعة العلب ";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = global::Acceuil.Properties.Resources.open_carton_box;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 60D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 322);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(189, 48);
            this.bunifuFlatButton3.TabIndex = 5;
            this.bunifuFlatButton3.Text = " مراجعة العلب ";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("GE SS Unique Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = " مراجعة التحويلات ";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = global::Acceuil.Properties.Resources.boxes;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 60D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 274);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(189, 48);
            this.bunifuFlatButton2.TabIndex = 4;
            this.bunifuFlatButton2.Text = " مراجعة التحويلات ";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("GE SS Unique Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // Add_Verssement_Button
            // 
            this.Add_Verssement_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.Add_Verssement_Button.BackColor = System.Drawing.Color.Transparent;
            this.Add_Verssement_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Add_Verssement_Button.BorderRadius = 0;
            this.Add_Verssement_Button.ButtonText = "إضافة تحويلة ";
            this.Add_Verssement_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_Verssement_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Add_Verssement_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Add_Verssement_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Add_Verssement_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Add_Verssement_Button.Iconimage = null;
            this.Add_Verssement_Button.Iconimage_right = global::Acceuil.Properties.Resources.worker_loading_boxes;
            this.Add_Verssement_Button.Iconimage_right_Selected = null;
            this.Add_Verssement_Button.Iconimage_Selected = null;
            this.Add_Verssement_Button.IconMarginLeft = 0;
            this.Add_Verssement_Button.IconMarginRight = 0;
            this.Add_Verssement_Button.IconRightVisible = true;
            this.Add_Verssement_Button.IconRightZoom = 0D;
            this.Add_Verssement_Button.IconVisible = true;
            this.Add_Verssement_Button.IconZoom = 60D;
            this.Add_Verssement_Button.IsTab = false;
            this.Add_Verssement_Button.Location = new System.Drawing.Point(0, 226);
            this.Add_Verssement_Button.Name = "Add_Verssement_Button";
            this.Add_Verssement_Button.Normalcolor = System.Drawing.Color.Transparent;
            this.Add_Verssement_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            this.Add_Verssement_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Add_Verssement_Button.selected = false;
            this.Add_Verssement_Button.Size = new System.Drawing.Size(189, 48);
            this.Add_Verssement_Button.TabIndex = 3;
            this.Add_Verssement_Button.Text = "إضافة تحويلة ";
            this.Add_Verssement_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add_Verssement_Button.Textcolor = System.Drawing.Color.White;
            this.Add_Verssement_Button.TextFont = new System.Drawing.Font("GE SS Unique Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Add_Verssement_Button.Click += new System.EventHandler(this.Add_Verssement_Button_Click);
            // 
            // Home_Button
            // 
            this.Home_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.Home_Button.BackColor = System.Drawing.Color.Transparent;
            this.Home_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Home_Button.BorderRadius = 0;
            this.Home_Button.ButtonText = "الصفحة الرئيسية ";
            this.Home_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Home_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Home_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Home_Button.Iconimage = null;
            this.Home_Button.Iconimage_right = global::Acceuil.Properties.Resources.icon__1_;
            this.Home_Button.Iconimage_right_Selected = null;
            this.Home_Button.Iconimage_Selected = null;
            this.Home_Button.IconMarginLeft = 0;
            this.Home_Button.IconMarginRight = 0;
            this.Home_Button.IconRightVisible = true;
            this.Home_Button.IconRightZoom = 0D;
            this.Home_Button.IconVisible = true;
            this.Home_Button.IconZoom = 60D;
            this.Home_Button.IsTab = false;
            this.Home_Button.Location = new System.Drawing.Point(0, 178);
            this.Home_Button.Name = "Home_Button";
            this.Home_Button.Normalcolor = System.Drawing.Color.Transparent;
            this.Home_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            this.Home_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Home_Button.selected = false;
            this.Home_Button.Size = new System.Drawing.Size(189, 48);
            this.Home_Button.TabIndex = 2;
            this.Home_Button.Text = "الصفحة الرئيسية ";
            this.Home_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Home_Button.Textcolor = System.Drawing.Color.White;
            this.Home_Button.TextFont = new System.Drawing.Font("GE SS Unique Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Home_Button.Click += new System.EventHandler(this.Home_Button_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel3.Controls.Add(this.User_name_label);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel3.Location = new System.Drawing.Point(0, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 20);
            this.panel3.TabIndex = 1;
            // 
            // User_name_label
            // 
            this.User_name_label.AutoSize = true;
            this.User_name_label.Font = new System.Drawing.Font("GE SS Unique Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.User_name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.User_name_label.Location = new System.Drawing.Point(56, -1);
            this.User_name_label.Name = "User_name_label";
            this.User_name_label.Size = new System.Drawing.Size(86, 20);
            this.User_name_label.TabIndex = 4;
            this.User_name_label.Text = "عبد الحكيم";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.User_PicturBox);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 158);
            this.panel2.TabIndex = 0;
            // 
            // User_PicturBox
            // 
            this.User_PicturBox.BackgroundImage = global::Acceuil.Properties.Resources.Cadre;
            this.User_PicturBox.Image = global::Acceuil.Properties.Resources.user;
            this.User_PicturBox.Location = new System.Drawing.Point(26, 8);
            this.User_PicturBox.Name = "User_PicturBox";
            this.User_PicturBox.Size = new System.Drawing.Size(140, 140);
            this.User_PicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.User_PicturBox.TabIndex = 0;
            this.User_PicturBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Acceuil.Properties.Resources.Cadre;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // acceuil_user1
            // 
            this.acceuil_user1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acceuil_user1.Location = new System.Drawing.Point(0, 62);
            this.acceuil_user1.Name = "acceuil_user1";
            this.acceuil_user1.Size = new System.Drawing.Size(748, 597);
            this.acceuil_user1.TabIndex = 4;
            // 
            // add_Transer1
            // 
            this.add_Transer1.BackColor = System.Drawing.Color.White;
            this.add_Transer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_Transer1.Location = new System.Drawing.Point(0, 62);
            this.add_Transer1.Name = "add_Transer1";
            this.add_Transer1.Size = new System.Drawing.Size(748, 597);
            this.add_Transer1.TabIndex = 5;
            this.add_Transer1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(937, 659);
            this.Controls.Add(this.add_Transer1);
            this.Controls.Add(this.acceuil_user1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimise_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximise_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Humbutton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.User_PicturBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private Bunifu.Framework.UI.BunifuImageButton Humbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Minimise_pictureBox;
        private System.Windows.Forms.PictureBox Close_pictureBox;
        private Bunifu.Framework.UI.BunifuCustomLabel Title_Lable;
        private System.Windows.Forms.PictureBox Maximise_pictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox User_PicturBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label User_name_label;
        private Bunifu.Framework.UI.BunifuFlatButton Home_Button;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton Add_Verssement_Button;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
        private Acceuil_user acceuil_user1;
        private Add_Transer add_Transer1;
    }
}

