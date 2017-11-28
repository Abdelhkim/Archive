using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;



namespace Acceuil
{
    public partial class Form1 : Form
    {
        int TagMove, MvalX, MvalY, statu;
        private const int ScrollIncrement = 10;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            statu = 0;
            this.CenterToScreen();
            User_Background_picturebox.BackColor = Color.Transparent;
            User_Background_picturebox.Parent = User_PicturBox;
            add_Transer1.Visible = false;
            acceuil_user1.Visible = true;
            revise_transfers1.Visible = false;


        }
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            TagMove = 1;
            MvalX = e.X;
            MvalY = e.Y;

        }

        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            TagMove = 0;

        }

        private void Close_pictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (TagMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MvalX, MousePosition.Y - MvalY);
            }
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            if (statu == 1)
            {
                this.Width = 958;
                this.Height = 631;
                this.CenterToScreen();
                statu = 0;
            }
        }

        private void Header_DoubleClick(object sender, EventArgs e)
        {
            if (statu == 0)
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                Left = Top = 0;
                Width = Screen.PrimaryScreen.WorkingArea.Width;
                Height = Screen.PrimaryScreen.WorkingArea.Height;
                statu = 1;
            }
            else
            {
                this.Width = 958;
                this.Height = 631;
                this.CenterToScreen();
                statu = 0;
            }
        }

        private void Maximise_pictureBox_Click(object sender, EventArgs e)
        {
            if (statu == 0)
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                Left = Top = 0;
                Width = Screen.PrimaryScreen.WorkingArea.Width;
                Height = Screen.PrimaryScreen.WorkingArea.Height;
                statu = 1;
            }
            else
            {

                this.Width = 958;
                this.Height = 631;
                this.CenterToScreen();
                statu = 0;
            }
        }
        private void Home_Button_Click(object sender, EventArgs e)
        {
            if (add_Transer1.panel1.Enabled == true || add_Transer1.panel2.Enabled == true)
            {
                MessageBox.Show("لم يتم إكتمال التحويلة");
            }
            else
            {
                add_Transer1.Visible = false;
                acceuil_user1.Visible = true;
                revise_transfers1.Visible = false;
            }
            

        }
        private void Add_Verssement_Button_Click(object sender, EventArgs e)
        {
            add_Transer1.Visible = true;
            acceuil_user1.Visible = false;
            revise_transfers1.Visible = false;
        }
        private void Revise_Transfers_Button_Click(object sender, EventArgs e)
        {
            if (add_Transer1.panel1.Enabled == true || add_Transer1.panel2.Enabled == true)
            {
                MessageBox.Show("لم يتم إكتمال التحويلة");
            }
            else
            {
                add_Transer1.Visible = false;
                acceuil_user1.Visible = false;
                revise_transfers1.Visible = true;
            }
        }

        private void Minimise_pictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Agrendire_Panels(Bunifu.Framework.UI.BunifuCards a)
        {
            int pourcWidth = this.Width * 100 / Screen.PrimaryScreen.WorkingArea.Width;
            int pourcHeight = this.Height * 100 / Screen.PrimaryScreen.WorkingArea.Height;
            a.Height = a.Height * 100 / pourcHeight;
            a.Width = a.Width * 100 / pourcWidth;
        }
        public void Minimize_Panel(Bunifu.Framework.UI.BunifuCards a)
        {
            int pourcWidth = Screen.PrimaryScreen.WorkingArea.Width * 100 / this.Width;
            int pourcHeight = Screen.PrimaryScreen.WorkingArea.Height  * 100 / this.Height;
            a.Height = 271;
            a.Width = 365;
        }
        
    }
}
