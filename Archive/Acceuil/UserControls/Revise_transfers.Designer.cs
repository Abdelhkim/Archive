namespace Acceuil
{
    partial class Revise_transfers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Verssements_DataGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Add_Files_Button = new System.Windows.Forms.Button();
            this.Modifier_Verssement = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Verssements_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Verssements_DataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Verssements_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Verssements_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Verssements_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Verssements_DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Verssements_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Verssements_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Verssements_DataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.Verssements_DataGridView.DoubleBuffered = true;
            this.Verssements_DataGridView.EnableHeadersVisualStyles = false;
            this.Verssements_DataGridView.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            this.Verssements_DataGridView.HeaderForeColor = System.Drawing.Color.White;
            this.Verssements_DataGridView.Location = new System.Drawing.Point(0, 0);
            this.Verssements_DataGridView.Name = "Verssements_DataGridView";
            this.Verssements_DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Verssements_DataGridView.Size = new System.Drawing.Size(748, 535);
            this.Verssements_DataGridView.TabIndex = 0;
            // 
            // Add_Files_Button
            // 
            this.Add_Files_Button.Font = new System.Drawing.Font("GE SS Unique Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Add_Files_Button.Location = new System.Drawing.Point(462, 541);
            this.Add_Files_Button.Name = "Add_Files_Button";
            this.Add_Files_Button.Size = new System.Drawing.Size(115, 32);
            this.Add_Files_Button.TabIndex = 26;
            this.Add_Files_Button.Text = "إضافة علبة";
            this.Add_Files_Button.UseVisualStyleBackColor = true;
            // 
            // Modifier_Verssement
            // 
            this.Modifier_Verssement.Font = new System.Drawing.Font("GE SS Unique Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Modifier_Verssement.Location = new System.Drawing.Point(304, 541);
            this.Modifier_Verssement.Name = "Modifier_Verssement";
            this.Modifier_Verssement.Size = new System.Drawing.Size(152, 32);
            this.Modifier_Verssement.TabIndex = 27;
            this.Modifier_Verssement.Text = "تعديل التحويلة";
            this.Modifier_Verssement.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("GE SS Unique Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(166, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 32);
            this.button1.TabIndex = 28;
            this.button1.Text = "طباعة تحويلة";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Revise_transfers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Modifier_Verssement);
            this.Controls.Add(this.Add_Files_Button);
            this.Controls.Add(this.Verssements_DataGridView);
            this.Name = "Revise_transfers";
            this.Size = new System.Drawing.Size(748, 597);
            ((System.ComponentModel.ISupportInitialize)(this.Verssements_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid Verssements_DataGridView;
        private System.Windows.Forms.Button Add_Files_Button;
        private System.Windows.Forms.Button Modifier_Verssement;
        private System.Windows.Forms.Button button1;
    }
}
