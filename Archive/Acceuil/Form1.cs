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
using System.Data.SqlClient;

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
            acceuil_user1.Visible = true;
            add_Transer1.Visible = false;
            revise_Boxs1.Visible = false;
            revise_transfers1.Visible = false;

            Home_Button.selected = true;
            statu = 0;
            this.CenterToScreen();
            User_Background_picturebox.BackColor = Color.Transparent;
            User_Background_picturebox.Parent = User_PicturBox;

        }
        #region Mouvment Code
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
        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (TagMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MvalX, MousePosition.Y - MvalY);
            }
        }
        private void Close_pictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
        private void Minimise_pictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void Home_Button_Click(object sender, EventArgs e)
        {
            if (add_Transer1.Visible == true && (add_Transer1.panel1.Enabled == true || add_Transer1.panel2.Enabled == true))
            {
                MessageBox.Show("لم يتم إكتمال التحويلة");
            }
            else
            {
                Home_Button.selected = true;
                Add_Verssement_Button.selected = false;
                Revise_Transfers_Button.selected = false;

                acceuil_user1.Visible = true;
                add_Transer1.Visible = false;
                revise_transfers1.Visible = false;
                revise_Boxs1.Visible = false;
            }
        }
        private void Add_Verssement_Button_Click(object sender, EventArgs e)
        {
                Add_Verssement_Button.selected = true;
                Home_Button.selected = false;
                Revise_Transfers_Button.selected = false;

                add_Transer1.Visible = true;

            if (Program.Connection.State == ConnectionState.Closed)
            {
                Program.Connection.Open();
            }
             SqlCommand CMD = new SqlCommand("select Top(1)* from Verssements order by Numero_Verssement desc", Program.Connection);
            SqlDataReader Reader;
            DataTable T = new DataTable();
            Reader = CMD.ExecuteReader();
            T.Load(Reader);
            int Numero = Convert.ToInt32(T.Rows[0][0]) + 1;
            add_Transer1.Numero_Du_Transsmition_Label.Text = Numero.ToString();
            Program.Connection.Close();
            acceuil_user1.Visible = false;
            revise_transfers1.Visible = false;
            revise_Boxs1.Visible = false;
        }
        private void Revise_Transfers_Button_Click(object sender, EventArgs e)
        {
            if (add_Transer1.Visible == true && (add_Transer1.panel1.Enabled == true || add_Transer1.panel2.Enabled == true))
            {
                MessageBox.Show("لم يتم إكتمال التحويلة");
            }
            else
            {
                Revise_Transfers_Button.selected = true;
                Home_Button.selected = false;
                Add_Verssement_Button.selected = false;

                revise_Boxs1.Visible = false;
                add_Transer1.Visible = false;
                acceuil_user1.Visible = false;
                revise_transfers1.Visible = true; 
            }
        }


        private void Revise_Boxs_Button_Click(object sender, EventArgs e)
        {
            acceuil_user1.Visible = false;
            add_Transer1.Visible = false;
            revise_transfers1.Visible = false;
            revise_Boxs1.Visible = true;
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
