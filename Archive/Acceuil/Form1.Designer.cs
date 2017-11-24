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
            this.Help_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Logout_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Profile_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Revise_Folders_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Revise_Boxs_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Revise_Transfers_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Add_Verssement_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Home_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.User_name_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.User_PicturBox = new System.Windows.Forms.PictureBox();
            this.User_Background_picturebox = new System.Windows.Forms.PictureBox();
            this.add_Transer1 = new Acceuil.Add_Transer();
            this.acceuil_user1 = new Acceuil.Acceuil_user();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimise_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximise_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Humbutton)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_PicturBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_Background_picturebox)).BeginInit();
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
            this.panel1.Controls.Add(this.Help_Button);
            this.panel1.Controls.Add(this.Logout_Button);
            this.panel1.Controls.Add(this.Profile_Button);
            this.panel1.Controls.Add(this.Revise_Folders_Button);
            this.panel1.Controls.Add(this.Revise_Boxs_Button);
            this.panel1.Controls.Add(this.Revise_Transfers_Button);
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
            // Help_Button
            // 
            this.Help_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.Help_Button.BackColor = System.Drawing.Color.Transparent;
            this.Help_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Help_Button.BorderRadius = 0;
            this.Help_Button.ButtonText = "المساعدة ";
            this.Help_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Help_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Help_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Help_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Help_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Help_Button.Iconimage = null;
            this.Help_Button.Iconimage_right = global::Acceuil.Properties.Resources.info;
            this.Help_Button.Iconimage_right_Selected = null;
            this.Help_Button.Iconimage_Selected = null;
            this.Help_Button.IconMarginLeft = 0;
            this.Help_Button.IconMarginRight = 0;
            this.Help_Button.IconRightVisible = true;
            this.Help_Button.IconRightZoom = 0D;
            this.Help_Button.IconVisible = true;
            this.Help_Button.IconZoom = 60D;
            this.Help_Button.IsTab = false;
            this.Help_Button.Location = new System.Drawing.Point(0, 514);
            this.Help_Button.Name = "Help_Button";
            this.Help_Button.Normalcolor = System.Drawing.Color.Transparent;
            this.Help_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            this.Help_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Help_Button.selected = false;
            this.Help_Button.Size = new System.Drawing.Size(189, 48);
            this.Help_Button.TabIndex = 9;
            this.Help_Button.Text = "المساعدة ";
            this.Help_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Help_Button.Textcolor = System.Drawing.Color.White;
            this.Help_Button.TextFont = new System.Drawing.Font("GE SS Unique Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // Logout_Button
            // 
            this.Logout_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.Logout_Button.BackColor = System.Drawing.Color.Transparent;
            this.Logout_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logout_Button.BorderRadius = 0;
            this.Logout_Button.ButtonText = "تسجيل الخروج ";
            this.Logout_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Logout_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logout_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Logout_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Logout_Button.Iconimage = null;
            this.Logout_Button.Iconimage_right = global::Acceuil.Properties.Resources.logout;
            this.Logout_Button.Iconimage_right_Selected = null;
            this.Logout_Button.Iconimage_Selected = null;
            this.Logout_Button.IconMarginLeft = 0;
            this.Logout_Button.IconMarginRight = 0;
            this.Logout_Button.IconRightVisible = true;
            this.Logout_Button.IconRightZoom = 0D;
            this.Logout_Button.IconVisible = true;
            this.Logout_Button.IconZoom = 60D;
            this.Logout_Button.IsTab = false;
            this.Logout_Button.Location = new System.Drawing.Point(0, 466);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Normalcolor = System.Drawing.Color.Transparent;
            this.Logout_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            this.Logout_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Logout_Button.selected = false;
            this.Logout_Button.Size = new System.Drawing.Size(189, 48);
            this.Logout_Button.TabIndex = 8;
            this.Logout_Button.Text = "تسجيل الخروج ";
            this.Logout_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Logout_Button.Textcolor = System.Drawing.Color.White;
            this.Logout_Button.TextFont = new System.Drawing.Font("GE SS Unique Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // Profile_Button
            // 
            this.Profile_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.Profile_Button.BackColor = System.Drawing.Color.Transparent;
            this.Profile_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Profile_Button.BorderRadius = 0;
            this.Profile_Button.ButtonText = " الملف الشخصي ";
            this.Profile_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Profile_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Profile_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Profile_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Profile_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Profile_Button.Iconimage = null;
            this.Profile_Button.Iconimage_right = global::Acceuil.Properties.Resources.users;
            this.Profile_Button.Iconimage_right_Selected = null;
            this.Profile_Button.Iconimage_Selected = null;
            this.Profile_Button.IconMarginLeft = 0;
            this.Profile_Button.IconMarginRight = 0;
            this.Profile_Button.IconRightVisible = true;
            this.Profile_Button.IconRightZoom = 0D;
            this.Profile_Button.IconVisible = true;
            this.Profile_Button.IconZoom = 60D;
            this.Profile_Button.IsTab = false;
            this.Profile_Button.Location = new System.Drawing.Point(0, 418);
            this.Profile_Button.Name = "Profile_Button";
            this.Profile_Button.Normalcolor = System.Drawing.Color.Transparent;
            this.Profile_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            this.Profile_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Profile_Button.selected = false;
            this.Profile_Button.Size = new System.Drawing.Size(189, 48);
            this.Profile_Button.TabIndex = 7;
            this.Profile_Button.Text = " الملف الشخصي ";
            this.Profile_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Profile_Button.Textcolor = System.Drawing.Color.White;
            this.Profile_Button.TextFont = new System.Drawing.Font("GE SS Unique Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // Revise_Folders_Button
            // 
            this.Revise_Folders_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.Revise_Folders_Button.BackColor = System.Drawing.Color.Transparent;
            this.Revise_Folders_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Revise_Folders_Button.BorderRadius = 0;
            this.Revise_Folders_Button.ButtonText = " مراجعة الملفات ";
            this.Revise_Folders_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Revise_Folders_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Revise_Folders_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Revise_Folders_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Revise_Folders_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Revise_Folders_Button.Iconimage = null;
            this.Revise_Folders_Button.Iconimage_right = global::Acceuil.Properties.Resources.archive;
            this.Revise_Folders_Button.Iconimage_right_Selected = null;
            this.Revise_Folders_Button.Iconimage_Selected = null;
            this.Revise_Folders_Button.IconMarginLeft = 0;
            this.Revise_Folders_Button.IconMarginRight = 0;
            this.Revise_Folders_Button.IconRightVisible = true;
            this.Revise_Folders_Button.IconRightZoom = 0D;
            this.Revise_Folders_Button.IconVisible = true;
            this.Revise_Folders_Button.IconZoom = 60D;
            this.Revise_Folders_Button.IsTab = false;
            this.Revise_Folders_Button.Location = new System.Drawing.Point(0, 370);
            this.Revise_Folders_Button.Name = "Revise_Folders_Button";
            this.Revise_Folders_Button.Normalcolor = System.Drawing.Color.Transparent;
            this.Revise_Folders_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            this.Revise_Folders_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Revise_Folders_Button.selected = false;
            this.Revise_Folders_Button.Size = new System.Drawing.Size(189, 48);
            this.Revise_Folders_Button.TabIndex = 6;
            this.Revise_Folders_Button.Text = " مراجعة الملفات ";
            this.Revise_Folders_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Revise_Folders_Button.Textcolor = System.Drawing.Color.White;
            this.Revise_Folders_Button.TextFont = new System.Drawing.Font("GE SS Unique Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // Revise_Boxs_Button
            // 
            this.Revise_Boxs_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.Revise_Boxs_Button.BackColor = System.Drawing.Color.Transparent;
            this.Revise_Boxs_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Revise_Boxs_Button.BorderRadius = 0;
            this.Revise_Boxs_Button.ButtonText = " مراجعة العلب ";
            this.Revise_Boxs_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Revise_Boxs_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Revise_Boxs_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Revise_Boxs_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Revise_Boxs_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Revise_Boxs_Button.Iconimage = null;
            this.Revise_Boxs_Button.Iconimage_right = global::Acceuil.Properties.Resources.open_carton_box;
            this.Revise_Boxs_Button.Iconimage_right_Selected = null;
            this.Revise_Boxs_Button.Iconimage_Selected = null;
            this.Revise_Boxs_Button.IconMarginLeft = 0;
            this.Revise_Boxs_Button.IconMarginRight = 0;
            this.Revise_Boxs_Button.IconRightVisible = true;
            this.Revise_Boxs_Button.IconRightZoom = 0D;
            this.Revise_Boxs_Button.IconVisible = true;
            this.Revise_Boxs_Button.IconZoom = 60D;
            this.Revise_Boxs_Button.IsTab = false;
            this.Revise_Boxs_Button.Location = new System.Drawing.Point(0, 322);
            this.Revise_Boxs_Button.Name = "Revise_Boxs_Button";
            this.Revise_Boxs_Button.Normalcolor = System.Drawing.Color.Transparent;
            this.Revise_Boxs_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            this.Revise_Boxs_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Revise_Boxs_Button.selected = false;
            this.Revise_Boxs_Button.Size = new System.Drawing.Size(189, 48);
            this.Revise_Boxs_Button.TabIndex = 5;
            this.Revise_Boxs_Button.Text = " مراجعة العلب ";
            this.Revise_Boxs_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Revise_Boxs_Button.Textcolor = System.Drawing.Color.White;
            this.Revise_Boxs_Button.TextFont = new System.Drawing.Font("GE SS Unique Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // Revise_Transfers_Button
            // 
            this.Revise_Transfers_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.Revise_Transfers_Button.BackColor = System.Drawing.Color.Transparent;
            this.Revise_Transfers_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Revise_Transfers_Button.BorderRadius = 0;
            this.Revise_Transfers_Button.ButtonText = " مراجعة التحويلات ";
            this.Revise_Transfers_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Revise_Transfers_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Revise_Transfers_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Revise_Transfers_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Revise_Transfers_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Revise_Transfers_Button.Iconimage = null;
            this.Revise_Transfers_Button.Iconimage_right = global::Acceuil.Properties.Resources.boxes;
            this.Revise_Transfers_Button.Iconimage_right_Selected = null;
            this.Revise_Transfers_Button.Iconimage_Selected = null;
            this.Revise_Transfers_Button.IconMarginLeft = 0;
            this.Revise_Transfers_Button.IconMarginRight = 0;
            this.Revise_Transfers_Button.IconRightVisible = true;
            this.Revise_Transfers_Button.IconRightZoom = 0D;
            this.Revise_Transfers_Button.IconVisible = true;
            this.Revise_Transfers_Button.IconZoom = 60D;
            this.Revise_Transfers_Button.IsTab = false;
            this.Revise_Transfers_Button.Location = new System.Drawing.Point(0, 274);
            this.Revise_Transfers_Button.Name = "Revise_Transfers_Button";
            this.Revise_Transfers_Button.Normalcolor = System.Drawing.Color.Transparent;
            this.Revise_Transfers_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            this.Revise_Transfers_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Revise_Transfers_Button.selected = false;
            this.Revise_Transfers_Button.Size = new System.Drawing.Size(189, 48);
            this.Revise_Transfers_Button.TabIndex = 4;
            this.Revise_Transfers_Button.Text = " مراجعة التحويلات ";
            this.Revise_Transfers_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Revise_Transfers_Button.Textcolor = System.Drawing.Color.White;
            this.Revise_Transfers_Button.TextFont = new System.Drawing.Font("GE SS Unique Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
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
            this.panel2.Controls.Add(this.User_Background_picturebox);
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
            // User_Background_picturebox
            // 
            this.User_Background_picturebox.BackColor = System.Drawing.Color.Transparent;
            this.User_Background_picturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User_Background_picturebox.ErrorImage = null;
            this.User_Background_picturebox.Image = global::Acceuil.Properties.Resources.Cadre;
            this.User_Background_picturebox.InitialImage = null;
            this.User_Background_picturebox.Location = new System.Drawing.Point(0, 0);
            this.User_Background_picturebox.Name = "User_Background_picturebox";
            this.User_Background_picturebox.Size = new System.Drawing.Size(189, 158);
            this.User_Background_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.User_Background_picturebox.TabIndex = 0;
            this.User_Background_picturebox.TabStop = false;
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
            // acceuil_user1
            // 
            this.acceuil_user1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acceuil_user1.Location = new System.Drawing.Point(0, 62);
            this.acceuil_user1.Name = "acceuil_user1";
            this.acceuil_user1.Size = new System.Drawing.Size(748, 597);
            this.acceuil_user1.TabIndex = 4;
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
            ((System.ComponentModel.ISupportInitialize)(this.User_Background_picturebox)).EndInit();
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
        private System.Windows.Forms.PictureBox User_Background_picturebox;
        private System.Windows.Forms.PictureBox User_PicturBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label User_name_label;
        private Bunifu.Framework.UI.BunifuFlatButton Home_Button;
        private Bunifu.Framework.UI.BunifuFlatButton Revise_Transfers_Button;
        private Bunifu.Framework.UI.BunifuFlatButton Add_Verssement_Button;
        private Bunifu.Framework.UI.BunifuFlatButton Revise_Boxs_Button;
        private Bunifu.Framework.UI.BunifuFlatButton Profile_Button;
        private Bunifu.Framework.UI.BunifuFlatButton Revise_Folders_Button;
        private Bunifu.Framework.UI.BunifuFlatButton Logout_Button;
        private Bunifu.Framework.UI.BunifuFlatButton Help_Button;
        private Acceuil_user acceuil_user1;
        private Add_Transer add_Transer1;
    }
}

