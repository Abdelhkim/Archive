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
        public static int Home_button_Click_Value = 0;
        public static int Btn_clicked = -1;
        private const int ScrollIncrement = 10;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            Timer_FadeIN.Start();
            Timer_Check_the_Home_Button_Value.Start();
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
        
        private void Home_Button_Click(object sender, EventArgs e)
        {
            if (Form1.Home_button_Click_Value == 0 && add_Transer1.Visible == true && (add_Transer1.panel1.Enabled == true || add_Transer1.panel2.Enabled == true || add_Transer1.panel3.Enabled == true))
            {
                ErrorMSG E = new ErrorMSG();
                E.Button2.Visible = true;
                E.Error_TITRE_Label.Text = "تحذير";
                E.Message_Label.Text = "لم يتم إكتمال التحويلة:هل تريدالخروج من صفحت التحويلة";
                E.Message_Label.Location = new Point(6, 38);
                E.BackColor = Color.FromArgb(255, 66, 66);
                E.changerbuttoncouleur(E.Button1, 255, 66, 66);
                E.changerbuttoncouleur(E.Button2, 255, 66, 66);
                E.Button1.ButtonText = "نعم";
                E.Button2.ButtonText = "لا";
                E.ChangeButtonLocation(E.Button1, 87, 55);
                E.ChangeButtonLocation(E.Button2, 216, 55);
                E.ChangeIcon(ArchiveAPPLICATION.Properties.Resources.Error);
                E.ShowDialog();
                if (E.Clicked() == 1)
                {
                    acceuil_user1.Visible = true;
                    add_Transer1.Visible = false;
                    revise_transfers1.Visible = false;
                    revise_Boxs1.Visible = false;
                    Add_Verssement_Button.Enabled = true;
                }
                if(E.Clicked() == 2)
                {
                    
                }

            }
            else
            {
                acceuil_user1.Visible = true;
                add_Transer1.Visible = false;
                revise_transfers1.Visible = false;
                revise_Boxs1.Visible = false;
            }
        }
        private void Add_Verssement_Button_Click(object sender, EventArgs e)
        {
            ErrorMSG E = new ErrorMSG();
            E.Button2.Visible = true;
            E.Error_TITRE_Label.Text = "إنتباه";
            E.Message_Label.Text = "هل تريد إضافة تحويلة جديدة";
            E.Message_Label.Location = new Point(112, 30);
            E.BackColor = Color.FromArgb(241, 196, 15);
            E.changerbuttoncouleur(E.Button1, 241, 196, 15);
            E.changerbuttoncouleur(E.Button2, 241, 196, 15);
            E.Button1.ButtonText = "نعم";
            E.Button2.ButtonText = "لا";
            E.ChangeButtonLocation(E.Button1, 87, 55);
            E.ChangeButtonLocation(E.Button2, 216, 55);
            E.ChangeIcon(ArchiveAPPLICATION.Properties.Resources.Attention);
            E.ShowDialog();
            if (E.Clicked() == 1)
            {
                add_Transer1.Visible = true;
                if (Program.Connection.State == ConnectionState.Closed)
                {
                    Program.Connection.Open();
                }

                SqlCommand CMD = new SqlCommand("insert into Verssements(Employe_ID) values(@Employé)", Program.Connection);
                CMD.Parameters.AddWithValue("@Employé", Login.Employe_ID);
                CMD.ExecuteNonQuery();
                CMD = new SqlCommand("Select  top(1)Numero_Verssement from Verssements where Employe_ID = @Employe_id order by Numero_Verssement desc", Program.Connection);
                CMD.Parameters.AddWithValue("@Employe_id", Login.Employe_ID);
                SqlDataReader Reader = CMD.ExecuteReader();
                DataTable T = new DataTable();
                T.Load(Reader);
                add_Transer1.Numero_Du_Transsmition_Label.Text = T.Rows[0][0].ToString();
                acceuil_user1.Visible = false;
                revise_transfers1.Visible = false;
                revise_Boxs1.Visible = false;
                Program.Connection.Close();
                Add_Verssement_Button.Enabled = false;
            }
            if (E.Clicked() == 2)
            {
                
            }
                
                
        }
        private void Revise_Transfers_Button_Click(object sender, EventArgs e)
        {
            if (add_Transer1.Visible == true && (add_Transer1.panel1.Enabled == true || add_Transer1.panel2.Enabled == true || add_Transer1.panel3.Enabled == true))
            {
                ErrorMSG E = new ErrorMSG();
                E.Button2.Visible = true;
                E.Error_TITRE_Label.Text = "تحذير";
                E.Message_Label.Text = "لم يتم إكتمال التحويلة:هل تريدالخروج من صفحت التحويلة";
                E.Message_Label.Location = new Point(6, 38);
                E.BackColor = Color.FromArgb(255, 66, 66);
                E.changerbuttoncouleur(E.Button1, 255, 66, 66);
                E.changerbuttoncouleur(E.Button2, 255, 66, 66);
                E.Button1.ButtonText = "نعم";
                E.Button2.ButtonText = "لا";
                E.ChangeButtonLocation(E.Button1, 87, 55);
                E.ChangeButtonLocation(E.Button2, 216, 55);
                E.ChangeIcon(ArchiveAPPLICATION.Properties.Resources.Error);
                E.ShowDialog();
                if (E.Clicked() == 1)
                {
                    revise_Boxs1.Visible = false;
                    add_Transer1.Visible = false;
                    acceuil_user1.Visible = false;
                    revise_transfers1.Visible = true;
                    Add_Verssement_Button.Enabled = true;

                }
            }
            else
            {
                revise_Boxs1.Visible = false;
                add_Transer1.Visible = false;
                acceuil_user1.Visible = false;
                revise_transfers1.Visible = true; 
            }
        }

        private void Revise_Boxs_Button_Click(object sender, EventArgs e)
        {
            if (add_Transer1.Visible == true && (add_Transer1.panel1.Enabled == true || add_Transer1.panel2.Enabled == true || add_Transer1.panel3.Enabled == true))
            {
                ErrorMSG E = new ErrorMSG();
                E.Button2.Visible = true;
                E.Error_TITRE_Label.Text = "تحذير";
                E.Message_Label.Text = "لم يتم إكتمال التحويلة:هل تريدالخروج من صفحت التحويلة";
                E.Message_Label.Location = new Point(6, 38);
                E.BackColor = Color.FromArgb(255, 66, 66);
                E.changerbuttoncouleur(E.Button1, 255, 66, 66);
                E.changerbuttoncouleur(E.Button2, 255, 66, 66);
                E.Button1.ButtonText = "نعم";
                E.Button2.ButtonText = "لا";
                E.ChangeButtonLocation(E.Button1, 87, 55);
                E.ChangeButtonLocation(E.Button2, 216, 55);
                E.ChangeIcon(ArchiveAPPLICATION.Properties.Resources.Error);
                E.ShowDialog();
                if (E.Clicked() == 1)
                {
                    acceuil_user1.Visible = false;
                    add_Transer1.Visible = false;
                    revise_transfers1.Visible = false;
                    revise_Boxs1.Visible = true;

                    Add_Verssement_Button.Enabled = true;

                }
            }
            else
            {
                acceuil_user1.Visible = false;
                add_Transer1.Visible = false;
                revise_transfers1.Visible = false;
                revise_Boxs1.Visible = true;
            }

        }
        private void Revise_Folders_Button_Click(object sender, EventArgs e)
        {
            if (add_Transer1.Visible == true && (add_Transer1.panel1.Enabled == true || add_Transer1.panel2.Enabled == true || add_Transer1.panel3.Enabled == true))
            {
                ErrorMSG E = new ErrorMSG();
                E.Button2.Visible = true;
                E.Error_TITRE_Label.Text = "تحذير";
                E.Message_Label.Text = "لم يتم إكتمال التحويلة:هل تريدالخروج من صفحت التحويلة";
                E.Message_Label.Location = new Point(6, 38);
                E.BackColor = Color.FromArgb(255, 66, 66);
                E.changerbuttoncouleur(E.Button1, 255, 66, 66);
                E.changerbuttoncouleur(E.Button2, 255, 66, 66);
                E.Button1.ButtonText = "نعم";
                E.Button2.ButtonText = "لا";
                E.ChangeButtonLocation(E.Button1, 87, 55);
                E.ChangeButtonLocation(E.Button2, 216, 55);
                E.ChangeIcon(ArchiveAPPLICATION.Properties.Resources.Error);
                E.ShowDialog();
                if (E.Clicked() == 1)
                {
                    acceuil_user1.Visible = false;
                    add_Transer1.Visible = false;
                    revise_transfers1.Visible = false;
                    revise_Boxs1.Visible = true;
                }
            }
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
        private void Timer_Check_the_Home_Button_Value_Tick(object sender, EventArgs e)
        {
            if (Home_button_Click_Value == 1)
            {
                Home_Button_Click(sender, e);
                Home_button_Click_Value = 0;
            }
        }
        private void Minimise_pictureBox_Click(object sender, EventArgs e)
        {
            if (add_Transer1.Visible == true && (add_Transer1.panel1.Enabled == true || add_Transer1.panel2.Enabled == true || add_Transer1.panel3.Enabled == true))
            {
                ErrorMSG E = new ErrorMSG();
                E.Button2.Visible = true;
                E.Error_TITRE_Label.Text = "تحذير";
                E.Message_Label.Text = "لم يتم إكتمال التحويلة:هل تريدالخروج من صفحت التحويلة";
                E.Message_Label.Location = new Point(6, 38);
                E.BackColor = Color.FromArgb(255, 66, 66);
                E.changerbuttoncouleur(E.Button1, 255, 66, 66);
                E.changerbuttoncouleur(E.Button2, 255, 66, 66);
                E.Button1.ButtonText = "نعم";
                E.Button2.ButtonText = "لا";
                E.ChangeButtonLocation(E.Button1, 87, 55);
                E.ChangeButtonLocation(E.Button2, 216, 55);
                E.ChangeIcon(ArchiveAPPLICATION.Properties.Resources.Error);
                E.ShowDialog();
                if (E.Clicked() == 1)
                {
                    this.Close();
                    Login L = new Login();
                    L.Show();
                }
            }
            else
            {
                this.Close();
                Login L = new Login();
                L.Show();
            }

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

        private void Timer_FadeIN_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 0.99)
            {
                this.Opacity += 0.3;
                Timer_FadeIN.Start();
            }
            else
            {
                Timer_FadeIN.Stop();
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
        #endregion
    }
}
