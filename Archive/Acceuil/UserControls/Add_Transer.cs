using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Acceuil
{
    public partial class Add_Transer : UserControl
    {
        public Add_Transer()
        {
            InitializeComponent();
        }
        BindingSource B_TCI = new BindingSource();
        BindingSource B_TPI = new BindingSource();
        BindingSource B_CJ  = new BindingSource();
        private void Add_Transer_Load(object sender, EventArgs e)
        {
            Date_of_Transfer_Creation_Label.Text = DateTime.Now.Day.ToString()+"/"+DateTime.Now.Month.ToString()+"/"+DateTime.Now.Year.ToString();
            panel1.Enabled = false;
            panel2.Enabled = false;
            Insert_Folders_DataGridView.EnableHeadersVisualStyles = false;
            Insert_Folders_DataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(215, 104, 23);
            
        }
        private void Add_Transfer_Button_Click_1(object sender, EventArgs e)
        {
            if (Tribunal_ComboBox.Text != string.Empty && Adminstration_ComboBox.Text != string.Empty && Number_Of_Boxs_numericUPDOWN.Value != 0)
            {
                panel1.Enabled = true;
                panel3.Enabled = false;
                if (Program.Connection.State == ConnectionState.Closed)
                {
                    Program.Connection.Open();
                }
                if (Non_radio.Checked == true)
                {
                   string Metrage = Longeur_Label.Text.TrimEnd('M');
                   Program.CMD = new SqlCommand("insert into Verssements(Code_Tribunal,Nom_Administration,Responsable,Employe_ID,Date_Vessement,Nombre_Box,Metrage) values('" + Tribunal_Codes_ComboBox.Text + "','" + Adminstration_ComboBox.Text + "','" +Responsable_ComboBox.Text + "'," +Login.Employe_ID +",'" +Date_of_Transfer_Creation_Label.Text + "'," +Number_Of_Boxs_numericUPDOWN.Value + "," +float.Parse(Metrage)+")",Program.Connection);
                }
                if (Oui_radio.Checked == true)
                {
                    string Metrage = Longeur_Label.Text.TrimEnd('M');
                    Program.CMD = new SqlCommand("insert into Verssements(Code_Tribunal,Nom_Administration,Responsable,Employe_ID,Date_Vessement,Nombre_Box,Metrage,Stocker,Date_Stockage) values('" + Tribunal_Codes_ComboBox.Text + "','" + Adminstration_ComboBox.Text + "','" + Responsable_ComboBox.Text + "'," + Login.Employe_ID + ",'" + Date_of_Transfer_Creation_Label.Text + "'," + Number_Of_Boxs_numericUPDOWN.Value + "," + float.Parse(Metrage) + ","+1 +",'" +Date_of_Transfer_Creation_Label.Text+"')", Program.Connection);
                }
                Program.CMD.ExecuteNonQuery();
                Program.Connection.Close();
                The_Numbers_of_Box_Label.Text = "1";
                MessageBox.Show("المرجوا إدخال معلومات العلبة رقم 1");
            }
            else
                MessageBox.Show("يجب ملئ جميع خانات التحويلة");
        }

        private void Add_Box_Button_Click_1(object sender, EventArgs e)
        {
            if (Codes_of_Cases_ComboBox.Text != string.Empty && Date_Jujment_NumiricUpDown.Text != string.Empty )
            {
                Program.Connection.Open();
                panel2.Enabled = true;
                panel1.Enabled = false;
                MessageBox.Show("المرجوا إدخال معلومات ملفات العلبة");
                Insert_Folders_DataGridView.Rows.Add(int.Parse(Number_of_Folders_Textbox.Text));
            }
            else
                MessageBox.Show("يجب ملئ جميع خانات العلبة");
        }

        private void Add_Files_Button_Click_1(object sender, EventArgs e)
        {
            int Etat = -1;
            foreach (DataGridViewRow Row in Insert_Folders_DataGridView.Rows)
            {
                foreach (DataGridViewCell Cell in Row.Cells)
                {
                    if (Cell.Value == null)
                    {
                        Etat = 0;
                    }

                }
            }
            if (Etat == 0)
            {
                MessageBox.Show("يوجد خانة لم يتم إملائها");
            }
            if (Etat == -1)
            {
                if (int.Parse(The_Numbers_of_Box_Label.Text) != Number_Of_Boxs_numericUPDOWN.Value)
                {
                    panel1.Enabled = true;
                    panel2.Enabled = false;
                    for (int i = 0; i < Insert_Folders_DataGridView.Rows.Count; i++)
                    {
                        Program.CMD = new SqlCommand("insert into T(id,nom,prenom) values(@id,@nom,@prenom)",Program.Connection);
                        Program.CMD.Parameters.AddWithValue("@id", Insert_Folders_DataGridView.Rows[i].Cells[0].Value);
                        Program.CMD.Parameters.AddWithValue("@nom", Insert_Folders_DataGridView.Rows[i].Cells[1].Value);
                        Program.CMD.Parameters.AddWithValue("@prenom", Insert_Folders_DataGridView.Rows[i].Cells[2].Value);
                        Program.CMD.ExecuteNonQuery();
                    }
                    Program.Connection.Close();
                    Insert_Folders_DataGridView.Rows.Clear();
                    The_Numbers_of_Box_Label.Text = (int.Parse(The_Numbers_of_Box_Label.Text) + 1).ToString();
                    ResetControls(panel1);
                    MessageBox.Show("المرجوا إدخال معلومات العلبة رقم "+ The_Numbers_of_Box_Label.Text);

                }
                else
                {
                    panel3.Enabled = true;
                    panel2.Enabled = false;
                    MessageBox.Show("لقد تم إدخال جميع الملفات في التحويلة :يمكنك إضافة تحولية جديدة بنجاح أو مراجعة التحويلة في القائمة على اليمين");
                    ResetControls(panel1);
                    ResetControls(panel2);
                    ResetControls(panel3);
                }
            }
        }
        private void Add_Transer_VisibleChanged(object sender, EventArgs e)
        {
            ResetControls(panel1);
            ResetControls(panel2);
            ResetControls(panel3);

        }
        public static void ResetControls(Panel P)
        {
            foreach (Control C in P.Controls)
            {
                var textBox       = C as TextBox;
                var comboBox      = C as ComboBox;
                var Numericupdown = C as NumericUpDown;
                var checkbox = C as CheckBox;
                if (textBox != null)
                {
                    (textBox).Clear();
                }
                if (comboBox != null)
                {
                    comboBox.SelectedIndex = -1;
                }
                if (Numericupdown != null)
                {
                    Numericupdown.Value = 0;
                }
                if (checkbox != null)
                {
                    checkbox.Checked = false;
                }
                
            }
        }
       
        private void Tribunal_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Adminstration_ComboBox.Items.Clear();
            Tribunal_Codes_ComboBox.Items.Clear();
            if (Program.Connection.State == ConnectionState.Closed)
            {
                Program.Connection.Open();
            }
            if (Tribunal_ComboBox.SelectedIndex == 0)
            {
                Program.CMD = new SqlCommand("select top(6)Code_Tribunal_TCA from TCA", Program.Connection);
                Adminstration_ComboBox.Items.Add("الرئاسة");
                Adminstration_ComboBox.Items.Add("النيابة العامة");
            }
            if (Tribunal_ComboBox.SelectedIndex == 1)
            {
                Program.CMD = new SqlCommand("select Code_Tribunal_TCA from TCA WHERE Nom_Tribunal_TCA = 'محكمة الاستئناف الإدارية بمراكش' ", Program.Connection);
                Adminstration_ComboBox.Items.Add("الرئاسة");
            }
            if (Tribunal_ComboBox.SelectedIndex == 2)
            {
                Program.CMD = new SqlCommand("select Code_Tribunal_TCA from TCA WHERE Nom_Tribunal_TCA = 'محكمة الاستئناف التجارية بمراكش' ", Program.Connection);
                Adminstration_ComboBox.Items.Add("الرئاسة");
                Adminstration_ComboBox.Items.Add("النيابة العامة");
            }
            if (Tribunal_ComboBox.SelectedIndex == 3)
            {
                Program.CMD = new SqlCommand("select TOP(24)Code_Tribunal_TPI from TPI", Program.Connection);
                Adminstration_ComboBox.Items.Add("الرئاسة");
                Adminstration_ComboBox.Items.Add("النيابة العامة");
            }
            if (Tribunal_ComboBox.SelectedIndex == 4)
            {
                Program.CMD = new SqlCommand("select Code_Tribunal_TPI from TPI WHERE (Nom_Tribunal_TPI like '%المحكمة الإدارية%') ", Program.Connection);
                Adminstration_ComboBox.Items.Add("الرئاسة");
            }
            if (Tribunal_ComboBox.SelectedIndex == 5)
            {
                Program.CMD = new SqlCommand("select Code_Tribunal_TPI from TPI WHERE (Nom_Tribunal_TPI like '%التجارية%') ", Program.Connection);
                Adminstration_ComboBox.Items.Add("الرئاسة");
                Adminstration_ComboBox.Items.Add("النيابة العامة");
            }
            if (Tribunal_ComboBox.SelectedIndex == 6)
            {
                Program.CMD = new SqlCommand("select Code_Tribunal_CJ from CJ", Program.Connection);
                Adminstration_ComboBox.Items.Add("المركز");
            }
            if (Tribunal_ComboBox.SelectedIndex == 7)
            {
                Program.CMD = new SqlCommand("select Code_Tribunal_TGC from TGC", Program.Connection);
                Adminstration_ComboBox.Items.Add("الرئاسة");
            }
            if (Tribunal_ComboBox.SelectedIndex == 8)
            {
                Program.CMD = new SqlCommand("select Code_Tribunal_SDR from SDR", Program.Connection);
                Adminstration_ComboBox.Items.Add("المديرية الفرعية");
            }
            if (Tribunal_ComboBox.SelectedIndex == 9)
            {
                Tribunal_Codes_ComboBox.Items.Clear();
                Tribunal_Codes_ComboBox.Items.Add('E');
                Adminstration_ComboBox.Items.Add("المركز");
            }
            Program.DataReader = Program.CMD.ExecuteReader();
            while (Program.DataReader.Read() && Tribunal_ComboBox.SelectedIndex != 9)
            {
                Tribunal_Codes_ComboBox.Items.Add(Program.DataReader[0]);
            }
            Program.Connection.Close();
        }

        private void Adminstration_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Responsable_ComboBox.Items.Clear();
            if (Adminstration_ComboBox.Text == "الرئاسة")
            {
                Responsable_ComboBox.Items.Add("رئيس مصلحة كتابة الضبط");
            }
            if (Adminstration_ComboBox.Text == "النيابة العامة")
            {
                Responsable_ComboBox.Items.Add("رئيس مصلحة كتابةالنيابةالعامة");
            }
            if (Adminstration_ComboBox.Text == "المديرية الفرعية")
            {
                Responsable_ComboBox.Items.Add("المدير الفرعي الإقليمي");
            }
            if (Adminstration_ComboBox.Text == "المركز" && Tribunal_ComboBox.Text == "المركز الجهوي للحفظ بمركش")
            {
                Responsable_ComboBox.Items.Add("المسؤول عن المركز");
            }
            if (Adminstration_ComboBox.Text == "المركز" && Tribunal_ComboBox.Text == "مركز القاضي المقيم ")
            {
                Responsable_ComboBox.Items.Add("القاضي المقيم");
            }
        }

        private void Number_Of_Boxs_numericUPDOWN_ValueChanged(object sender, EventArgs e)
        {
            Longeur_Label.Text = Convert.ToString(Convert.ToDouble(Number_Of_Boxs_numericUPDOWN.Value) * 0.40) + "M";

        }
    }
}
