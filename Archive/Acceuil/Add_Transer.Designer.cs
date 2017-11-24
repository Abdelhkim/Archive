namespace Acceuil
{
    partial class Add_Transer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.Add_Transfer_Button = new System.Windows.Forms.Button();
            this.Number_Of_Boxs_TextBox = new System.Windows.Forms.TextBox();
            this.Adminstration_ComboBox = new System.Windows.Forms.ComboBox();
            this.Tribunal_ComboBox = new System.Windows.Forms.ComboBox();
            this.Date_of_Transfer_Creation_Label = new System.Windows.Forms.Label();
            this.Tribunal_Label = new System.Windows.Forms.Label();
            this.Number_of_Boxs_Label = new System.Windows.Forms.Label();
            this.Administration_Label = new System.Windows.Forms.Label();
            this.Date_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Codes_of_Cases_ComboBox = new System.Windows.Forms.ComboBox();
            this.Dates_of_Proce_ComboBox = new System.Windows.Forms.ComboBox();
            this.Type_of_Box_ComboBox = new System.Windows.Forms.ComboBox();
            this.Add_Box_Button = new System.Windows.Forms.Button();
            this.Code_of_Case_Label = new System.Windows.Forms.Label();
            this.Date_of_Proce_Label = new System.Windows.Forms.Label();
            this.Type_of_Box_Label = new System.Windows.Forms.Label();
            this.The_Numbers_of_Box_Label = new System.Windows.Forms.Label();
            this.Number_of_Box_Label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Add_Files_Button = new System.Windows.Forms.Button();
            this.Insert_Folders_DataGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Box_Cord_Label = new System.Windows.Forms.Label();
            this.bunifuCards1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Insert_Folders_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Transparent;
            this.bunifuCards1.Controls.Add(this.Add_Transfer_Button);
            this.bunifuCards1.Controls.Add(this.Number_Of_Boxs_TextBox);
            this.bunifuCards1.Controls.Add(this.Adminstration_ComboBox);
            this.bunifuCards1.Controls.Add(this.Tribunal_ComboBox);
            this.bunifuCards1.Controls.Add(this.Date_of_Transfer_Creation_Label);
            this.bunifuCards1.Controls.Add(this.Tribunal_Label);
            this.bunifuCards1.Controls.Add(this.Number_of_Boxs_Label);
            this.bunifuCards1.Controls.Add(this.Administration_Label);
            this.bunifuCards1.Controls.Add(this.Date_Label);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(748, 173);
            this.bunifuCards1.TabIndex = 0;
            // 
            // Add_Transfer_Button
            // 
            this.Add_Transfer_Button.Font = new System.Drawing.Font("GE SS Unique Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Add_Transfer_Button.Location = new System.Drawing.Point(307, 134);
            this.Add_Transfer_Button.Name = "Add_Transfer_Button";
            this.Add_Transfer_Button.Size = new System.Drawing.Size(130, 32);
            this.Add_Transfer_Button.TabIndex = 43;
            this.Add_Transfer_Button.Text = "إضافة تحويلة";
            this.Add_Transfer_Button.UseVisualStyleBackColor = true;
            this.Add_Transfer_Button.Click += new System.EventHandler(this.Add_Transfer_Button_Click);
            // 
            // Number_Of_Boxs_TextBox
            // 
            this.Number_Of_Boxs_TextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_Of_Boxs_TextBox.Location = new System.Drawing.Point(20, 78);
            this.Number_Of_Boxs_TextBox.Name = "Number_Of_Boxs_TextBox";
            this.Number_Of_Boxs_TextBox.Size = new System.Drawing.Size(159, 22);
            this.Number_Of_Boxs_TextBox.TabIndex = 43;
            this.Number_Of_Boxs_TextBox.VisibleChanged += new System.EventHandler(this.Number_Of_Boxs_TextBox_VisibleChanged);
            // 
            // Adminstration_ComboBox
            // 
            this.Adminstration_ComboBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminstration_ComboBox.FormattingEnabled = true;
            this.Adminstration_ComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "5",
            "6"});
            this.Adminstration_ComboBox.Location = new System.Drawing.Point(438, 76);
            this.Adminstration_ComboBox.Name = "Adminstration_ComboBox";
            this.Adminstration_ComboBox.Size = new System.Drawing.Size(182, 24);
            this.Adminstration_ComboBox.TabIndex = 42;
            // 
            // Tribunal_ComboBox
            // 
            this.Tribunal_ComboBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tribunal_ComboBox.FormattingEnabled = true;
            this.Tribunal_ComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "5",
            "6"});
            this.Tribunal_ComboBox.Location = new System.Drawing.Point(438, 17);
            this.Tribunal_ComboBox.Name = "Tribunal_ComboBox";
            this.Tribunal_ComboBox.Size = new System.Drawing.Size(182, 24);
            this.Tribunal_ComboBox.TabIndex = 41;
            // 
            // Date_of_Transfer_Creation_Label
            // 
            this.Date_of_Transfer_Creation_Label.AutoSize = true;
            this.Date_of_Transfer_Creation_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_of_Transfer_Creation_Label.Location = new System.Drawing.Point(16, 15);
            this.Date_of_Transfer_Creation_Label.Name = "Date_of_Transfer_Creation_Label";
            this.Date_of_Transfer_Creation_Label.Size = new System.Drawing.Size(60, 24);
            this.Date_of_Transfer_Creation_Label.TabIndex = 19;
            this.Date_of_Transfer_Creation_Label.Text = "label2";
            // 
            // Tribunal_Label
            // 
            this.Tribunal_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tribunal_Label.AutoSize = true;
            this.Tribunal_Label.Font = new System.Drawing.Font("GE SS Unique Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Tribunal_Label.Location = new System.Drawing.Point(645, 17);
            this.Tribunal_Label.Name = "Tribunal_Label";
            this.Tribunal_Label.Size = new System.Drawing.Size(90, 25);
            this.Tribunal_Label.TabIndex = 16;
            this.Tribunal_Label.Text = "المحكمة";
            // 
            // Number_of_Boxs_Label
            // 
            this.Number_of_Boxs_Label.AutoSize = true;
            this.Number_of_Boxs_Label.Font = new System.Drawing.Font("GE SS Unique Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Number_of_Boxs_Label.Location = new System.Drawing.Point(186, 76);
            this.Number_of_Boxs_Label.Name = "Number_of_Boxs_Label";
            this.Number_of_Boxs_Label.Size = new System.Drawing.Size(94, 25);
            this.Number_of_Boxs_Label.TabIndex = 15;
            this.Number_of_Boxs_Label.Text = "عدد العلب";
            // 
            // Administration_Label
            // 
            this.Administration_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Administration_Label.AutoSize = true;
            this.Administration_Label.Font = new System.Drawing.Font("GE SS Unique Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Administration_Label.Location = new System.Drawing.Point(650, 76);
            this.Administration_Label.Name = "Administration_Label";
            this.Administration_Label.Size = new System.Drawing.Size(85, 25);
            this.Administration_Label.TabIndex = 14;
            this.Administration_Label.Text = "المصلحة";
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Font = new System.Drawing.Font("GE SS Unique Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Date_Label.Location = new System.Drawing.Point(222, 17);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(58, 25);
            this.Date_Label.TabIndex = 13;
            this.Date_Label.Text = "التاريخ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Codes_of_Cases_ComboBox);
            this.panel1.Controls.Add(this.Dates_of_Proce_ComboBox);
            this.panel1.Controls.Add(this.Type_of_Box_ComboBox);
            this.panel1.Controls.Add(this.Add_Box_Button);
            this.panel1.Controls.Add(this.Code_of_Case_Label);
            this.panel1.Controls.Add(this.Date_of_Proce_Label);
            this.panel1.Controls.Add(this.Type_of_Box_Label);
            this.panel1.Controls.Add(this.The_Numbers_of_Box_Label);
            this.panel1.Controls.Add(this.Number_of_Box_Label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 163);
            this.panel1.TabIndex = 30;
            // 
            // Codes_of_Cases_ComboBox
            // 
            this.Codes_of_Cases_ComboBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codes_of_Cases_ComboBox.FormattingEnabled = true;
            this.Codes_of_Cases_ComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.Codes_of_Cases_ComboBox.Location = new System.Drawing.Point(10, 72);
            this.Codes_of_Cases_ComboBox.Name = "Codes_of_Cases_ComboBox";
            this.Codes_of_Cases_ComboBox.Size = new System.Drawing.Size(169, 24);
            this.Codes_of_Cases_ComboBox.TabIndex = 42;
            // 
            // Dates_of_Proce_ComboBox
            // 
            this.Dates_of_Proce_ComboBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dates_of_Proce_ComboBox.FormattingEnabled = true;
            this.Dates_of_Proce_ComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.Dates_of_Proce_ComboBox.Location = new System.Drawing.Point(10, 17);
            this.Dates_of_Proce_ComboBox.Name = "Dates_of_Proce_ComboBox";
            this.Dates_of_Proce_ComboBox.Size = new System.Drawing.Size(169, 24);
            this.Dates_of_Proce_ComboBox.TabIndex = 41;
            // 
            // Type_of_Box_ComboBox
            // 
            this.Type_of_Box_ComboBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_of_Box_ComboBox.FormattingEnabled = true;
            this.Type_of_Box_ComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.Type_of_Box_ComboBox.Location = new System.Drawing.Point(438, 72);
            this.Type_of_Box_ComboBox.Name = "Type_of_Box_ComboBox";
            this.Type_of_Box_ComboBox.Size = new System.Drawing.Size(169, 24);
            this.Type_of_Box_ComboBox.TabIndex = 40;
            // 
            // Add_Box_Button
            // 
            this.Add_Box_Button.Font = new System.Drawing.Font("GE SS Unique Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Add_Box_Button.Location = new System.Drawing.Point(10, 125);
            this.Add_Box_Button.Name = "Add_Box_Button";
            this.Add_Box_Button.Size = new System.Drawing.Size(169, 32);
            this.Add_Box_Button.TabIndex = 39;
            this.Add_Box_Button.Text = "إضافة العلبة";
            this.Add_Box_Button.UseVisualStyleBackColor = true;
            this.Add_Box_Button.Click += new System.EventHandler(this.Add_Box_Button_Click);
            // 
            // Code_of_Case_Label
            // 
            this.Code_of_Case_Label.AutoSize = true;
            this.Code_of_Case_Label.Font = new System.Drawing.Font("GE SS Unique Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Code_of_Case_Label.Location = new System.Drawing.Point(199, 73);
            this.Code_of_Case_Label.Name = "Code_of_Case_Label";
            this.Code_of_Case_Label.Size = new System.Drawing.Size(102, 25);
            this.Code_of_Case_Label.TabIndex = 35;
            this.Code_of_Case_Label.Text = "رمز القضية";
            // 
            // Date_of_Proce_Label
            // 
            this.Date_of_Proce_Label.AutoSize = true;
            this.Date_of_Proce_Label.Font = new System.Drawing.Font("GE SS Unique Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Date_of_Proce_Label.Location = new System.Drawing.Point(193, 17);
            this.Date_of_Proce_Label.Name = "Date_of_Proce_Label";
            this.Date_of_Proce_Label.Size = new System.Drawing.Size(108, 25);
            this.Date_of_Proce_Label.TabIndex = 34;
            this.Date_of_Proce_Label.Text = "تاريخ الحكم";
            // 
            // Type_of_Box_Label
            // 
            this.Type_of_Box_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Type_of_Box_Label.AutoSize = true;
            this.Type_of_Box_Label.Font = new System.Drawing.Font("GE SS Unique Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Type_of_Box_Label.Location = new System.Drawing.Point(638, 73);
            this.Type_of_Box_Label.Name = "Type_of_Box_Label";
            this.Type_of_Box_Label.Size = new System.Drawing.Size(99, 25);
            this.Type_of_Box_Label.TabIndex = 33;
            this.Type_of_Box_Label.Text = "نوع  العلبة";
            // 
            // The_Numbers_of_Box_Label
            // 
            this.The_Numbers_of_Box_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.The_Numbers_of_Box_Label.AutoSize = true;
            this.The_Numbers_of_Box_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.The_Numbers_of_Box_Label.Location = new System.Drawing.Point(547, 18);
            this.The_Numbers_of_Box_Label.Name = "The_Numbers_of_Box_Label";
            this.The_Numbers_of_Box_Label.Size = new System.Drawing.Size(60, 24);
            this.The_Numbers_of_Box_Label.TabIndex = 29;
            this.The_Numbers_of_Box_Label.Text = "label7";
            // 
            // Number_of_Box_Label
            // 
            this.Number_of_Box_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Number_of_Box_Label.AutoSize = true;
            this.Number_of_Box_Label.Font = new System.Drawing.Font("GE SS Unique Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Number_of_Box_Label.Location = new System.Drawing.Point(650, 18);
            this.Number_of_Box_Label.Name = "Number_of_Box_Label";
            this.Number_of_Box_Label.Size = new System.Drawing.Size(87, 25);
            this.Number_of_Box_Label.TabIndex = 30;
            this.Number_of_Box_Label.Text = "علبة رقم";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Box_Cord_Label);
            this.panel2.Controls.Add(this.Add_Files_Button);
            this.panel2.Controls.Add(this.Insert_Folders_DataGridView);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 261);
            this.panel2.TabIndex = 31;
            // 
            // Add_Files_Button
            // 
            this.Add_Files_Button.Font = new System.Drawing.Font("GE SS Unique Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Add_Files_Button.Location = new System.Drawing.Point(10, 224);
            this.Add_Files_Button.Name = "Add_Files_Button";
            this.Add_Files_Button.Size = new System.Drawing.Size(130, 32);
            this.Add_Files_Button.TabIndex = 43;
            this.Add_Files_Button.Text = "إضافة الملفات";
            this.Add_Files_Button.UseVisualStyleBackColor = true;
            // 
            // Insert_Folders_DataGridView
            // 
            this.Insert_Folders_DataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Insert_Folders_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Insert_Folders_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Insert_Folders_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Insert_Folders_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Insert_Folders_DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("GE SS Unique Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Insert_Folders_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Insert_Folders_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Insert_Folders_DataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.Insert_Folders_DataGridView.DoubleBuffered = true;
            this.Insert_Folders_DataGridView.EnableHeadersVisualStyles = false;
            this.Insert_Folders_DataGridView.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(104)))), ((int)(((byte)(23)))));
            this.Insert_Folders_DataGridView.HeaderForeColor = System.Drawing.Color.White;
            this.Insert_Folders_DataGridView.Location = new System.Drawing.Point(0, 0);
            this.Insert_Folders_DataGridView.Name = "Insert_Folders_DataGridView";
            this.Insert_Folders_DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Insert_Folders_DataGridView.Size = new System.Drawing.Size(748, 218);
            this.Insert_Folders_DataGridView.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("GE SS Unique Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(633, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "عنوان العلبة";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("GE SS Unique Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(626, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "عدد الملفات";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(438, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 22);
            this.textBox1.TabIndex = 44;
            // 
            // Box_Cord_Label
            // 
            this.Box_Cord_Label.AutoSize = true;
            this.Box_Cord_Label.Font = new System.Drawing.Font("GE SS Unique Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Box_Cord_Label.Location = new System.Drawing.Point(515, 227);
            this.Box_Cord_Label.Name = "Box_Cord_Label";
            this.Box_Cord_Label.Size = new System.Drawing.Size(32, 25);
            this.Box_Cord_Label.TabIndex = 44;
            this.Box_Cord_Label.Text = "....";
            // 
            // Add_Transer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCards1);
            this.Font = new System.Drawing.Font("GE SS Unique Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "Add_Transer";
            this.Size = new System.Drawing.Size(748, 597);
            this.Load += new System.EventHandler(this.Add_Transer_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Insert_Folders_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuCards bunifuCards1;
        public System.Windows.Forms.Label Date_of_Transfer_Creation_Label;
        public System.Windows.Forms.Label Tribunal_Label;
        public System.Windows.Forms.Label Number_of_Boxs_Label;
        public System.Windows.Forms.Label Administration_Label;
        public System.Windows.Forms.Label Date_Label;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label Code_of_Case_Label;
        public System.Windows.Forms.Label Date_of_Proce_Label;
        public System.Windows.Forms.Label Type_of_Box_Label;
        public System.Windows.Forms.Label The_Numbers_of_Box_Label;
        public System.Windows.Forms.Label Number_of_Box_Label;
        public System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuCustomDataGrid Insert_Folders_DataGridView;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button Add_Box_Button;
        public System.Windows.Forms.ComboBox Type_of_Box_ComboBox;
        public System.Windows.Forms.ComboBox Adminstration_ComboBox;
        public System.Windows.Forms.ComboBox Tribunal_ComboBox;
        public System.Windows.Forms.Button Add_Transfer_Button;
        public System.Windows.Forms.ComboBox Codes_of_Cases_ComboBox;
        public System.Windows.Forms.ComboBox Dates_of_Proce_ComboBox;
        public System.Windows.Forms.Button Add_Files_Button;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label Box_Cord_Label;
        public System.Windows.Forms.TextBox Number_Of_Boxs_TextBox;
    }
}
