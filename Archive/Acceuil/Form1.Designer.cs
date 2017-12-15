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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Header = new System.Windows.Forms.Panel();
            this.Title_Lable = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.User_name_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Timer_Check_the_Home_Button_Value = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Timer_FadeIN = new System.Windows.Forms.Timer(this.components);
            this.Help_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Logout_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Profile_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Revise_Folders_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Revise_Boxs_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Revise_Transfers_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Add_Verssement_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Home_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.User_PicturBox = new System.Windows.Forms.PictureBox();
            this.User_Background_picturebox = new System.Windows.Forms.PictureBox();
            this.Minimise_pictureBox = new System.Windows.Forms.PictureBox();
            this.Close_pictureBox = new System.Windows.Forms.PictureBox();
            this.Maximise_pictureBox = new System.Windows.Forms.PictureBox();
            this.Humbutton = new Bunifu.Framework.UI.BunifuImageButton();
            this.acceuil_user1 = new Acceuil.Acceuil_user();
            this.revise_Boxs1 = new Acceuil.Revise_Boxs();
            this.revise_transfers1 = new Acceuil.Revise_transfers();
            this.add_Transer1 = new Acceuil.Add_Transer();
            this.Header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_PicturBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_Background_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimise_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximise_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Humbutton)).BeginInit();
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
            resources.ApplyResources(this.Header, "Header");
            this.Header.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Header.Name = "Header";
            this.Header.DoubleClick += new System.EventHandler(this.Header_DoubleClick);
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // Title_Lable
            // 
            resources.ApplyResources(this.Title_Lable, "Title_Lable");
            this.Title_Lable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title_Lable.Name = "Title_Lable";
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
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel3.Controls.Add(this.User_name_label);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel3.Name = "panel3";
            // 
            // User_name_label
            // 
            resources.ApplyResources(this.User_name_label, "User_name_label");
            this.User_name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.User_name_label.Name = "User_name_label";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.User_PicturBox);
            this.panel2.Controls.Add(this.User_Background_picturebox);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // Timer_Check_the_Home_Button_Value
            // 
            this.Timer_Check_the_Home_Button_Value.Tick += new System.EventHandler(this.Timer_Check_the_Home_Button_Value_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Timer_FadeIN
            // 
            this.Timer_FadeIN.Tick += new System.EventHandler(this.Timer_FadeIN_Tick);
            // 
            // Help_Button
            // 
            this.Help_Button.Activecolor = System.Drawing.Color.Transparent;
            this.Help_Button.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Help_Button, "Help_Button");
            this.Help_Button.BorderRadius = 0;
            this.Help_Button.ButtonText = "المساعدة ";
            this.Help_Button.CausesValidation = false;
            this.Help_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Help_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Help_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Help_Button.Iconimage = null;
            this.Help_Button.Iconimage_right = global::ArchiveAPPLICATION.Properties.Resources.info;
            this.Help_Button.Iconimage_right_Selected = null;
            this.Help_Button.Iconimage_Selected = null;
            this.Help_Button.IconMarginLeft = 0;
            this.Help_Button.IconMarginRight = 0;
            this.Help_Button.IconRightVisible = true;
            this.Help_Button.IconRightZoom = 0D;
            this.Help_Button.IconVisible = true;
            this.Help_Button.IconZoom = 60D;
            this.Help_Button.IsTab = true;
            this.Help_Button.Name = "Help_Button";
            this.Help_Button.Normalcolor = System.Drawing.Color.Transparent;
            this.Help_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            this.Help_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Help_Button.selected = false;
            this.Help_Button.TabStop = false;
            this.Help_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Help_Button.Textcolor = System.Drawing.Color.White;
            this.Help_Button.TextFont = new System.Drawing.Font("GE SS Unique Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // Logout_Button
            // 
            this.Logout_Button.Activecolor = System.Drawing.Color.Transparent;
            this.Logout_Button.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Logout_Button, "Logout_Button");
            this.Logout_Button.BorderRadius = 0;
            this.Logout_Button.ButtonText = "تسجيل الخروج ";
            this.Logout_Button.CausesValidation = false;
            this.Logout_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Logout_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Logout_Button.Iconimage = null;
            this.Logout_Button.Iconimage_right = global::ArchiveAPPLICATION.Properties.Resources.logout;
            this.Logout_Button.Iconimage_right_Selected = null;
            this.Logout_Button.Iconimage_Selected = null;
            this.Logout_Button.IconMarginLeft = 0;
            this.Logout_Button.IconMarginRight = 0;
            this.Logout_Button.IconRightVisible = true;
            this.Logout_Button.IconRightZoom = 0D;
            this.Logout_Button.IconVisible = true;
            this.Logout_Button.IconZoom = 60D;
            this.Logout_Button.IsTab = true;
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Normalcolor = System.Drawing.Color.Transparent;
            this.Logout_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            this.Logout_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Logout_Button.selected = false;
            this.Logout_Button.TabStop = false;
            this.Logout_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Logout_Button.Textcolor = System.Drawing.Color.White;
            this.Logout_Button.TextFont = new System.Drawing.Font("GE SS Unique Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // Profile_Button
            // 
            this.Profile_Button.Activecolor = System.Drawing.Color.Transparent;
            this.Profile_Button.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Profile_Button, "Profile_Button");
            this.Profile_Button.BorderRadius = 0;
            this.Profile_Button.ButtonText = " الملف الشخصي ";
            this.Profile_Button.CausesValidation = false;
            this.Profile_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Profile_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Profile_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Profile_Button.Iconimage = null;
            this.Profile_Button.Iconimage_right = global::ArchiveAPPLICATION.Properties.Resources.users;
            this.Profile_Button.Iconimage_right_Selected = null;
            this.Profile_Button.Iconimage_Selected = null;
            this.Profile_Button.IconMarginLeft = 0;
            this.Profile_Button.IconMarginRight = 0;
            this.Profile_Button.IconRightVisible = true;
            this.Profile_Button.IconRightZoom = 0D;
            this.Profile_Button.IconVisible = true;
            this.Profile_Button.IconZoom = 60D;
            this.Profile_Button.IsTab = true;
            this.Profile_Button.Name = "Profile_Button";
            this.Profile_Button.Normalcolor = System.Drawing.Color.Transparent;
            this.Profile_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            this.Profile_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Profile_Button.selected = false;
            this.Profile_Button.TabStop = false;
            this.Profile_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Profile_Button.Textcolor = System.Drawing.Color.White;
            this.Profile_Button.TextFont = new System.Drawing.Font("GE SS Unique Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // Revise_Folders_Button
            // 
            this.Revise_Folders_Button.Activecolor = System.Drawing.Color.Transparent;
            this.Revise_Folders_Button.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Revise_Folders_Button, "Revise_Folders_Button");
            this.Revise_Folders_Button.BorderRadius = 0;
            this.Revise_Folders_Button.ButtonText = " مراجعة الملفات ";
            this.Revise_Folders_Button.CausesValidation = false;
            this.Revise_Folders_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Revise_Folders_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Revise_Folders_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Revise_Folders_Button.Iconimage = null;
            this.Revise_Folders_Button.Iconimage_right = global::ArchiveAPPLICATION.Properties.Resources.archive;
            this.Revise_Folders_Button.Iconimage_right_Selected = null;
            this.Revise_Folders_Button.Iconimage_Selected = null;
            this.Revise_Folders_Button.IconMarginLeft = 0;
            this.Revise_Folders_Button.IconMarginRight = 0;
            this.Revise_Folders_Button.IconRightVisible = true;
            this.Revise_Folders_Button.IconRightZoom = 0D;
            this.Revise_Folders_Button.IconVisible = true;
            this.Revise_Folders_Button.IconZoom = 60D;
            this.Revise_Folders_Button.IsTab = true;
            this.Revise_Folders_Button.Name = "Revise_Folders_Button";
            this.Revise_Folders_Button.Normalcolor = System.Drawing.Color.Transparent;
            this.Revise_Folders_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            this.Revise_Folders_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Revise_Folders_Button.selected = false;
            this.Revise_Folders_Button.TabStop = false;
            this.Revise_Folders_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Revise_Folders_Button.Textcolor = System.Drawing.Color.White;
            this.Revise_Folders_Button.TextFont = new System.Drawing.Font("GE SS Unique Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Revise_Folders_Button.Click += new System.EventHandler(this.Revise_Folders_Button_Click);
            // 
            // Revise_Boxs_Button
            // 
            this.Revise_Boxs_Button.Activecolor = System.Drawing.Color.Transparent;
            this.Revise_Boxs_Button.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Revise_Boxs_Button, "Revise_Boxs_Button");
            this.Revise_Boxs_Button.BorderRadius = 0;
            this.Revise_Boxs_Button.ButtonText = " مراجعة العلب ";
            this.Revise_Boxs_Button.CausesValidation = false;
            this.Revise_Boxs_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Revise_Boxs_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Revise_Boxs_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Revise_Boxs_Button.Iconimage = null;
            this.Revise_Boxs_Button.Iconimage_right = global::ArchiveAPPLICATION.Properties.Resources.open_carton_box;
            this.Revise_Boxs_Button.Iconimage_right_Selected = null;
            this.Revise_Boxs_Button.Iconimage_Selected = null;
            this.Revise_Boxs_Button.IconMarginLeft = 0;
            this.Revise_Boxs_Button.IconMarginRight = 0;
            this.Revise_Boxs_Button.IconRightVisible = true;
            this.Revise_Boxs_Button.IconRightZoom = 0D;
            this.Revise_Boxs_Button.IconVisible = true;
            this.Revise_Boxs_Button.IconZoom = 60D;
            this.Revise_Boxs_Button.IsTab = true;
            this.Revise_Boxs_Button.Name = "Revise_Boxs_Button";
            this.Revise_Boxs_Button.Normalcolor = System.Drawing.Color.Transparent;
            this.Revise_Boxs_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            this.Revise_Boxs_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Revise_Boxs_Button.selected = false;
            this.Revise_Boxs_Button.TabStop = false;
            this.Revise_Boxs_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Revise_Boxs_Button.Textcolor = System.Drawing.Color.White;
            this.Revise_Boxs_Button.TextFont = new System.Drawing.Font("GE SS Unique Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Revise_Boxs_Button.Click += new System.EventHandler(this.Revise_Boxs_Button_Click);
            // 
            // Revise_Transfers_Button
            // 
            this.Revise_Transfers_Button.Activecolor = System.Drawing.Color.Transparent;
            this.Revise_Transfers_Button.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Revise_Transfers_Button, "Revise_Transfers_Button");
            this.Revise_Transfers_Button.BorderRadius = 0;
            this.Revise_Transfers_Button.ButtonText = " مراجعة التحويلات ";
            this.Revise_Transfers_Button.CausesValidation = false;
            this.Revise_Transfers_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Revise_Transfers_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Revise_Transfers_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Revise_Transfers_Button.Iconimage = null;
            this.Revise_Transfers_Button.Iconimage_right = global::ArchiveAPPLICATION.Properties.Resources.boxes;
            this.Revise_Transfers_Button.Iconimage_right_Selected = null;
            this.Revise_Transfers_Button.Iconimage_Selected = null;
            this.Revise_Transfers_Button.IconMarginLeft = 0;
            this.Revise_Transfers_Button.IconMarginRight = 0;
            this.Revise_Transfers_Button.IconRightVisible = true;
            this.Revise_Transfers_Button.IconRightZoom = 0D;
            this.Revise_Transfers_Button.IconVisible = true;
            this.Revise_Transfers_Button.IconZoom = 60D;
            this.Revise_Transfers_Button.IsTab = true;
            this.Revise_Transfers_Button.Name = "Revise_Transfers_Button";
            this.Revise_Transfers_Button.Normalcolor = System.Drawing.Color.Transparent;
            this.Revise_Transfers_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            this.Revise_Transfers_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Revise_Transfers_Button.selected = false;
            this.Revise_Transfers_Button.TabStop = false;
            this.Revise_Transfers_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Revise_Transfers_Button.Textcolor = System.Drawing.Color.White;
            this.Revise_Transfers_Button.TextFont = new System.Drawing.Font("GE SS Unique Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Revise_Transfers_Button.Click += new System.EventHandler(this.Revise_Transfers_Button_Click);
            // 
            // Add_Verssement_Button
            // 
            this.Add_Verssement_Button.Activecolor = System.Drawing.Color.Transparent;
            this.Add_Verssement_Button.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Add_Verssement_Button, "Add_Verssement_Button");
            this.Add_Verssement_Button.BorderRadius = 0;
            this.Add_Verssement_Button.ButtonText = "إضافة تحويلة ";
            this.Add_Verssement_Button.CausesValidation = false;
            this.Add_Verssement_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_Verssement_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Add_Verssement_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Add_Verssement_Button.Iconimage = null;
            this.Add_Verssement_Button.Iconimage_right = global::ArchiveAPPLICATION.Properties.Resources.worker_loading_boxes;
            this.Add_Verssement_Button.Iconimage_right_Selected = null;
            this.Add_Verssement_Button.Iconimage_Selected = null;
            this.Add_Verssement_Button.IconMarginLeft = 0;
            this.Add_Verssement_Button.IconMarginRight = 0;
            this.Add_Verssement_Button.IconRightVisible = true;
            this.Add_Verssement_Button.IconRightZoom = 0D;
            this.Add_Verssement_Button.IconVisible = true;
            this.Add_Verssement_Button.IconZoom = 60D;
            this.Add_Verssement_Button.IsTab = true;
            this.Add_Verssement_Button.Name = "Add_Verssement_Button";
            this.Add_Verssement_Button.Normalcolor = System.Drawing.Color.Transparent;
            this.Add_Verssement_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            this.Add_Verssement_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Add_Verssement_Button.selected = false;
            this.Add_Verssement_Button.TabStop = false;
            this.Add_Verssement_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add_Verssement_Button.Textcolor = System.Drawing.Color.White;
            this.Add_Verssement_Button.TextFont = new System.Drawing.Font("GE SS Unique Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Add_Verssement_Button.Click += new System.EventHandler(this.Add_Verssement_Button_Click);
            // 
            // Home_Button
            // 
            this.Home_Button.Activecolor = System.Drawing.Color.Transparent;
            this.Home_Button.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Home_Button, "Home_Button");
            this.Home_Button.BorderRadius = 0;
            this.Home_Button.ButtonText = "الصفحة الرئيسية ";
            this.Home_Button.CausesValidation = false;
            this.Home_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home_Button.DisabledColor = System.Drawing.SystemColors.ControlDark;
            this.Home_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Home_Button.Iconimage = null;
            this.Home_Button.Iconimage_right = global::ArchiveAPPLICATION.Properties.Resources.icon__1_;
            this.Home_Button.Iconimage_right_Selected = null;
            this.Home_Button.Iconimage_Selected = null;
            this.Home_Button.IconMarginLeft = 0;
            this.Home_Button.IconMarginRight = 0;
            this.Home_Button.IconRightVisible = true;
            this.Home_Button.IconRightZoom = 0D;
            this.Home_Button.IconVisible = true;
            this.Home_Button.IconZoom = 60D;
            this.Home_Button.IsTab = true;
            this.Home_Button.Name = "Home_Button";
            this.Home_Button.Normalcolor = System.Drawing.Color.Transparent;
            this.Home_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            this.Home_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Home_Button.selected = false;
            this.Home_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Home_Button.Textcolor = System.Drawing.Color.White;
            this.Home_Button.TextFont = new System.Drawing.Font("GE SS Unique Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Home_Button.Click += new System.EventHandler(this.Home_Button_Click);
            // 
            // User_PicturBox
            // 
            this.User_PicturBox.BackgroundImage = global::ArchiveAPPLICATION.Properties.Resources.Cadre;
            this.User_PicturBox.Image = global::ArchiveAPPLICATION.Properties.Resources.user;
            resources.ApplyResources(this.User_PicturBox, "User_PicturBox");
            this.User_PicturBox.Name = "User_PicturBox";
            this.User_PicturBox.TabStop = false;
            // 
            // User_Background_picturebox
            // 
            this.User_Background_picturebox.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.User_Background_picturebox, "User_Background_picturebox");
            this.User_Background_picturebox.Image = global::ArchiveAPPLICATION.Properties.Resources.Cadre;
            this.User_Background_picturebox.Name = "User_Background_picturebox";
            this.User_Background_picturebox.TabStop = false;
            // 
            // Minimise_pictureBox
            // 
            this.Minimise_pictureBox.Image = global::ArchiveAPPLICATION.Properties.Resources.close;
            resources.ApplyResources(this.Minimise_pictureBox, "Minimise_pictureBox");
            this.Minimise_pictureBox.Name = "Minimise_pictureBox";
            this.Minimise_pictureBox.TabStop = false;
            this.Minimise_pictureBox.Click += new System.EventHandler(this.Minimise_pictureBox_Click);
            // 
            // Close_pictureBox
            // 
            this.Close_pictureBox.Image = global::ArchiveAPPLICATION.Properties.Resources.Reduire;
            resources.ApplyResources(this.Close_pictureBox, "Close_pictureBox");
            this.Close_pictureBox.Name = "Close_pictureBox";
            this.Close_pictureBox.TabStop = false;
            this.Close_pictureBox.Click += new System.EventHandler(this.Close_pictureBox_Click);
            // 
            // Maximise_pictureBox
            // 
            this.Maximise_pictureBox.Image = global::ArchiveAPPLICATION.Properties.Resources.Agrendire;
            resources.ApplyResources(this.Maximise_pictureBox, "Maximise_pictureBox");
            this.Maximise_pictureBox.Name = "Maximise_pictureBox";
            this.Maximise_pictureBox.TabStop = false;
            this.Maximise_pictureBox.Click += new System.EventHandler(this.Maximise_pictureBox_Click);
            // 
            // Humbutton
            // 
            resources.ApplyResources(this.Humbutton, "Humbutton");
            this.Humbutton.BackColor = System.Drawing.Color.Transparent;
            this.Humbutton.Image = global::ArchiveAPPLICATION.Properties.Resources.menu;
            this.Humbutton.ImageActive = null;
            this.Humbutton.Name = "Humbutton";
            this.Humbutton.TabStop = false;
            this.Humbutton.Zoom = 10;
            // 
            // acceuil_user1
            // 
            resources.ApplyResources(this.acceuil_user1, "acceuil_user1");
            this.acceuil_user1.Name = "acceuil_user1";
            // 
            // revise_Boxs1
            // 
            this.revise_Boxs1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.revise_Boxs1, "revise_Boxs1");
            this.revise_Boxs1.Name = "revise_Boxs1";
            // 
            // revise_transfers1
            // 
            this.revise_transfers1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.revise_transfers1, "revise_transfers1");
            this.revise_transfers1.Name = "revise_transfers1";
            // 
            // add_Transer1
            // 
            this.add_Transer1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.add_Transer1, "add_Transer1");
            this.add_Transer1.Name = "add_Transer1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.Controls.Add(this.acceuil_user1);
            this.Controls.Add(this.revise_Boxs1);
            this.Controls.Add(this.revise_transfers1);
            this.Controls.Add(this.add_Transer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.User_PicturBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_Background_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimise_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximise_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Humbutton)).EndInit();
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
        private Bunifu.Framework.UI.BunifuFlatButton Revise_Transfers_Button;
        private Bunifu.Framework.UI.BunifuFlatButton Add_Verssement_Button;
        private Bunifu.Framework.UI.BunifuFlatButton Revise_Boxs_Button;
        private Bunifu.Framework.UI.BunifuFlatButton Profile_Button;
        private Bunifu.Framework.UI.BunifuFlatButton Revise_Folders_Button;
        private Bunifu.Framework.UI.BunifuFlatButton Logout_Button;
        private Bunifu.Framework.UI.BunifuFlatButton Help_Button;
        private Add_Transer add_Transer1;
        private Revise_transfers revise_transfers1;
        private Revise_Boxs revise_Boxs1;
        private Bunifu.Framework.UI.BunifuFlatButton Home_Button;
        public Acceuil_user acceuil_user1;
        private System.Windows.Forms.Timer Timer_Check_the_Home_Button_Value;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer Timer_FadeIN;
    }
}

