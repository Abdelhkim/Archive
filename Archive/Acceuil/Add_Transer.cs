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

        private void Add_Box_Button_Click(object sender, EventArgs e)
        {
            if (Codes_of_Cases_ComboBox.Text != string.Empty && Dates_of_Proce_ComboBox.Text != string.Empty && Type_of_Box_ComboBox.Text != string.Empty)
            {
                panel2.Enabled = true;
                panel1.Enabled = false;
            }else
                MessageBox.Show("Les Champs de Boites ne Doit pas être Vide ");
        }

        private void Number_Of_Boxs_TextBox_VisibleChanged(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
