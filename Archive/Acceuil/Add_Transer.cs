using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acceuil
{
    public partial class Add_Transer : UserControl
    {
        public Add_Transer()
        {
            InitializeComponent();
        }

        private void Add_Transer_Load(object sender, EventArgs e)
        {
            Date_of_Transfer_Creation_Label.Text = DateTime.Now.Day.ToString()+"/"+DateTime.Now.Month.ToString()+"/"+DateTime.Now.Year.ToString();
            panel1.Enabled = false;
            panel2.Enabled = false;
        }

        private void Add_Transfer_Button_Click(object sender, EventArgs e)
        {
            if (Tribunal_ComboBox.Text != string.Empty && Adminstration_ComboBox.Text != string.Empty && Number_Of_Boxs_TextBox.Text != string.Empty)
            {
                panel1.Enabled = true;
                bunifuCards1.Enabled = false;
            }else
                MessageBox.Show("L'un des champs des Verssement est Vide");
        }



        private void Adminstration_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Date_of_Transfer_Creation_Label_Click(object sender, EventArgs e)
        {

        }

        private void Tribunal_Label_Click(object sender, EventArgs e)
        {

        }

        private void Number_of_Boxs_Label_Click(object sender, EventArgs e)
        {

        }

        private void Administration_Label_Click(object sender, EventArgs e)
        {

        }

        private void Date_Label_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Code_of_Case_Label_Click(object sender, EventArgs e)
        {

        }

        private void Date_of_Proce_Label_Click(object sender, EventArgs e)
        {

        }

        private void Type_of_Box_Label_Click(object sender, EventArgs e)
        {

        }

        private void The_Numbers_of_Box_Label_Click(object sender, EventArgs e)
        {

        }

        private void Number_of_Box_Label_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Insert_Folders_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Box_Button_Click(object sender, EventArgs e)
        {

        }

        private void Type_of_Box_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tribunal_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dates_of_Proce_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Codes_of_Cases_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Files_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
