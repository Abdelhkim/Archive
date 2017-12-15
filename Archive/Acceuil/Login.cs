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

        private void Login_Load(object sender, EventArgs e)
        {
            LoadingBAR.Visible = false;
            this.Opacity = 0.0;
            Timer_FadeIN.Start();
        }
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
        private void Username_TextBox_OnValueChanged(object sender, EventArgs e)
        {
            Username_TextBox.BorderColorFocused = Color.SeaGreen;
            Password_TextBox.BorderColorFocused = Color.SeaGreen;
            Username_TextBox.BorderColorIdle = Color.SeaGreen;
            Password_TextBox.BorderColorIdle = Color.SeaGreen;
        }

        private void Password_TextBox_OnValueChanged(object sender, EventArgs e)
        {
            Username_TextBox.BorderColorFocused = Color.SeaGreen;
            Password_TextBox.BorderColorFocused = Color.SeaGreen;
            Username_TextBox.BorderColorIdle = Color.SeaGreen;
            Password_TextBox.BorderColorIdle = Color.SeaGreen;
        }

        private void Timer_FadeIN_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 0.99)
            {
                this.Opacity += 0.5;
                Timer_FadeIN.Start();
            }
            else
            {
                Timer_FadeIN.Stop();
            }
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            
            LoadingBAR.Visible = true;
            for (int i = 0; i < 100; i++)
            {
                LoadingBAR.Value += 1;
            }
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
            Program.DataReader.Close();
            LoadingBAR.Visible = false;
            if (LoadingBAR.Value == 100)
            {
                LoadingBAR.Value = 0;
            }
        }

        private void Close_Login_PictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
