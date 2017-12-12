namespace Acceuil
{
    partial class ErrorMSG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorMSG));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Erreur_Icon_Picturebox = new System.Windows.Forms.PictureBox();
            this.Error_TITRE_Label = new System.Windows.Forms.Label();
            this.Message_Label = new System.Windows.Forms.Label();
            this.Close_Button = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Erreur_Icon_Picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Controls.Add(this.Close_Button);
            this.panel1.Controls.Add(this.Message_Label);
            this.panel1.Controls.Add(this.Error_TITRE_Label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 102);
            this.panel1.TabIndex = 0;
            // 
            // Erreur_Icon_Picturebox
            // 
            this.Erreur_Icon_Picturebox.Image = ((System.Drawing.Image)(resources.GetObject("Erreur_Icon_Picturebox.Image")));
            this.Erreur_Icon_Picturebox.Location = new System.Drawing.Point(170, 20);
            this.Erreur_Icon_Picturebox.Name = "Erreur_Icon_Picturebox";
            this.Erreur_Icon_Picturebox.Size = new System.Drawing.Size(80, 80);
            this.Erreur_Icon_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Erreur_Icon_Picturebox.TabIndex = 5;
            this.Erreur_Icon_Picturebox.TabStop = false;
            // 
            // Error_TITRE_Label
            // 
            this.Error_TITRE_Label.AutoSize = true;
            this.Error_TITRE_Label.Font = new System.Drawing.Font("GE SS Unique Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Error_TITRE_Label.Location = new System.Drawing.Point(181, 2);
            this.Error_TITRE_Label.Name = "Error_TITRE_Label";
            this.Error_TITRE_Label.Size = new System.Drawing.Size(64, 36);
            this.Error_TITRE_Label.TabIndex = 0;
            this.Error_TITRE_Label.Text = "خطأ";
            // 
            // Message_Label
            // 
            this.Message_Label.AutoSize = true;
            this.Message_Label.Font = new System.Drawing.Font("GE SS Unique Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Message_Label.Location = new System.Drawing.Point(191, 38);
            this.Message_Label.Name = "Message_Label";
            this.Message_Label.Size = new System.Drawing.Size(49, 21);
            this.Message_Label.TabIndex = 1;
            this.Message_Label.Text = "label2";
            // 
            // Close_Button
            // 
            this.Close_Button.ActiveBorderThickness = 1;
            this.Close_Button.ActiveCornerRadius = 20;
            this.Close_Button.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Close_Button.ActiveForecolor = System.Drawing.Color.White;
            this.Close_Button.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Close_Button.BackColor = System.Drawing.Color.LightGray;
            this.Close_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Close_Button.BackgroundImage")));
            this.Close_Button.ButtonText = "إغلاق";
            this.Close_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_Button.Font = new System.Drawing.Font("GE SS Unique Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Close_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Close_Button.IdleBorderThickness = 1;
            this.Close_Button.IdleCornerRadius = 20;
            this.Close_Button.IdleFillColor = System.Drawing.Color.White;
            this.Close_Button.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Close_Button.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Close_Button.Location = new System.Drawing.Point(152, 55);
            this.Close_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(117, 43);
            this.Close_Button.TabIndex = 2;
            this.Close_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Acceuil.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(398, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.LightGray;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "إغلاق";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("GE SS Unique Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(275, 55);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(117, 43);
            this.bunifuThinButton21.TabIndex = 3;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorMSG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(421, 218);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Erreur_Icon_Picturebox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ErrorMSG";
            this.Text = "ErrorMSG";
            this.Load += new System.EventHandler(this.ErrorMSG_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Erreur_Icon_Picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.PictureBox Erreur_Icon_Picturebox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Message_Label;
        private System.Windows.Forms.Label Error_TITRE_Label;
        private Bunifu.Framework.UI.BunifuThinButton2 Close_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}