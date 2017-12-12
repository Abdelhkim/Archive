namespace Acceuil
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Forget_Pass_Label = new System.Windows.Forms.Label();
            this.Login_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Password_TextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Username_TextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Close_Login_PictureBox = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Login_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(119, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Forget_Pass_Label);
            this.panel1.Controls.Add(this.Login_Button);
            this.panel1.Controls.Add(this.Password_TextBox);
            this.panel1.Controls.Add(this.Username_TextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 255);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("GE SS Unique Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(236, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "إسم المستخدم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("GE SS Unique Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(263, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "كلمة السر";
            // 
            // Forget_Pass_Label
            // 
            this.Forget_Pass_Label.AutoSize = true;
            this.Forget_Pass_Label.Font = new System.Drawing.Font("GE SS Unique Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Forget_Pass_Label.Location = new System.Drawing.Point(227, 220);
            this.Forget_Pass_Label.Name = "Forget_Pass_Label";
            this.Forget_Pass_Label.Size = new System.Drawing.Size(100, 15);
            this.Forget_Pass_Label.TabIndex = 3;
            this.Forget_Pass_Label.Text = "هل نسيت الحساب؟";
            // 
            // Login_Button
            // 
            this.Login_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Login_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Login_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login_Button.BorderRadius = 5;
            this.Login_Button.ButtonText = "تسجيل الدخول";
            this.Login_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Login_Button.Font = new System.Drawing.Font("GE SS Unique Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Login_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Login_Button.Iconimage = null;
            this.Login_Button.Iconimage_right = null;
            this.Login_Button.Iconimage_right_Selected = null;
            this.Login_Button.Iconimage_Selected = null;
            this.Login_Button.IconMarginLeft = 0;
            this.Login_Button.IconMarginRight = 0;
            this.Login_Button.IconRightVisible = true;
            this.Login_Button.IconRightZoom = 0D;
            this.Login_Button.IconVisible = true;
            this.Login_Button.IconZoom = 90D;
            this.Login_Button.IsTab = false;
            this.Login_Button.Location = new System.Drawing.Point(99, 169);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Login_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Login_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Login_Button.selected = false;
            this.Login_Button.Size = new System.Drawing.Size(228, 48);
            this.Login_Button.TabIndex = 2;
            this.Login_Button.Text = "تسجيل الدخول";
            this.Login_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Login_Button.Textcolor = System.Drawing.Color.White;
            this.Login_Button.TextFont = new System.Drawing.Font("GE SS Unique Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.Password_TextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password_TextBox.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.Password_TextBox.BorderThickness = 3;
            this.Password_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_TextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password_TextBox.isPassword = false;
            this.Password_TextBox.Location = new System.Drawing.Point(90, 95);
            this.Password_TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Password_TextBox.Size = new System.Drawing.Size(241, 44);
            this.Password_TextBox.TabIndex = 1;
            this.Password_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_TextBox_KeyPress);
            this.Password_TextBox.MouseEnter += new System.EventHandler(this.Password_TextBox_MouseEnter);
            // 
            // Username_TextBox
            // 
            this.Username_TextBox.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.Username_TextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Username_TextBox.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.Username_TextBox.BorderThickness = 3;
            this.Username_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username_TextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Username_TextBox.isPassword = false;
            this.Username_TextBox.Location = new System.Drawing.Point(90, 25);
            this.Username_TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Username_TextBox.Name = "Username_TextBox";
            this.Username_TextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Username_TextBox.Size = new System.Drawing.Size(241, 44);
            this.Username_TextBox.TabIndex = 0;
            this.Username_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Username_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Username_TextBox_KeyPress);
            this.Username_TextBox.MouseEnter += new System.EventHandler(this.Username_TextBox_MouseEnter);
            // 
            // Close_Login_PictureBox
            // 
            this.Close_Login_PictureBox.Image = global::Acceuil.Properties.Resources.close;
            this.Close_Login_PictureBox.Location = new System.Drawing.Point(399, 4);
            this.Close_Login_PictureBox.Name = "Close_Login_PictureBox";
            this.Close_Login_PictureBox.Size = new System.Drawing.Size(23, 23);
            this.Close_Login_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close_Login_PictureBox.TabIndex = 12;
            this.Close_Login_PictureBox.TabStop = false;
            this.Close_Login_PictureBox.Click += new System.EventHandler(this.Close_Login_PictureBox_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(427, 500);
            this.Controls.Add(this.Close_Login_PictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Login_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton Login_Button;
        private Bunifu.Framework.UI.BunifuMetroTextbox Password_TextBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox Username_TextBox;
        private System.Windows.Forms.PictureBox Close_Login_PictureBox;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label Forget_Pass_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}