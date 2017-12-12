using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;

namespace Acceuil
{
    public partial class Login : Form
    {
        SoundPlayer Noti = new SoundPlayer(@"C:\Users\Abdelhkim\Desktop\ArchiveAPPLICATION\Sounds\Error.wav");
        public static int Employe_ID;
        public Login()
        {
            InitializeComponent();
        }
        int TagMove, MvalX, MvalY;
        #region mouvment_code
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (TagMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MvalX, MousePosition.Y - MvalY);
            }
        }

        private void Username_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Login_Button_Click(sender, e);

            }
        }

        private void Password_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Login_Button_Click(sender, e);

            }
        }

        private void Username_TextBox_MouseEnter(object sender, EventArgs e)
        {
            Username_TextBox.BorderColorFocused = Color.SeaGreen;
            Password_TextBox.BorderColorFocused = Color.SeaGreen;
            Username_TextBox.BorderColorIdle = Color.SeaGreen;
            Password_TextBox.BorderColorIdle = Color.SeaGreen;
        }

        private void Password_TextBox_MouseEnter(object sender, EventArgs e)
        {
            Username_TextBox.BorderColorFocused = Color.SeaGreen;
            Password_TextBox.BorderColorFocused = Color.SeaGreen;
            Username_TextBox.BorderColorIdle = Color.SeaGreen;
            Password_TextBox.BorderColorIdle = Color.SeaGreen;
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            TagMove = 0;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            TagMove = 1;
            MvalX = e.X;
            MvalY = e.Y;
        }
        #endregion
        private void Login_Button_Click(object sender, EventArgs e)
        {
            Program.Connection.Open();
            Program.CMD = new SqlCommand("select ID_Employe,Username,Password,Type_Compte from Employes where Username ='"+Username_TextBox.Text+"' AND Password='"+Password_TextBox.Text+"'",Program.Connection);
            Program.DataReader = Program.CMD.ExecuteReader();
            Program.Table.Clear();
            Program.Table.Load(Program.DataReader);
            if (Program.Table.Rows.Count > 0)
            {
                if (Convert.ToBoolean(Program.Table.Rows[0][3]) == true)
                {
                    MessageBox.Show("Admin");
                }
                if (Convert.ToBoolean(Program.Table.Rows[0][3]) == false)
                {
                    Employe_ID = int.Parse(Program.Table.Rows[0][0].ToString());
                    Form1 F = new Form1();
                    F.Show();
                    this.Hide();
                } 
            }
            else
            {
                Noti.Play();
                Username_TextBox.BorderColorIdle = Color.Red;
                Password_TextBox.BorderColorIdle = Color.Red;
                Username_TextBox.BorderColorFocused = Color.Red;
                Password_TextBox.BorderColorFocused = Color.Red;
            }
            
            Program.Connection.Close();
        }

        private void Close_Login_PictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
