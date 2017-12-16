using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acceuil
{
    public partial class ErrorMSG : Form
    {
        int TagMove, MvalX, MvalY;
        
        public ErrorMSG()
        {
            InitializeComponent();
        }

        private void ErrorMSG_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            Error_TITRE_Label.Location = new Point(Erreur_Icon_Picturebox.Location.X + (Erreur_Icon_Picturebox.Width / 2) - (Error_TITRE_Label.Width / 2), Error_TITRE_Label.Location.Y);
            Message_Label.Location = new Point(Erreur_Icon_Picturebox.Location.X + (Erreur_Icon_Picturebox.Width / 2) - (Message_Label.Width / 2), Message_Label.Location.Y);
            this.Opacity = 0.6;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 0.99)
            {
                this.Opacity += 0.50;
            }
            else
            {
                timer1.Stop();
            }
        }
        #region Methodes

        public void ChangeCouleurForm(int R, int G, int B)
        {
            this.BackColor = Color.FromArgb(R, G, B);
        }

        public void ChangeButtonText(string Text)
        {
            Button1.Text = Text;
        }
        public void ChangeObjetText(string Text)
        {
            Error_TITRE_Label.Text = Text;
        }
        public void ChangeMessageText(string Text)
        {
            Message_Label.Text = Text;
        }
        public void ChangeIcon(Image ImageF_Resou)
        {
            Erreur_Icon_Picturebox.Image = ImageF_Resou;
        }
        public void ChangerMessagePosition(int X, int Y)
        {
            Message_Label.Location = new Point(X, Y);
        }
        public void ChangerObjetLocation(int X, int Y)
        {
            Error_TITRE_Label.Location = new Point(X, Y);
        }
        public void Changerbuttoncouleur(Bunifu.Framework.UI.BunifuThinButton2 Button,int R, int G, int B)
        {
            Button.IdleFillColor = Color.White;
            Button.IdleForecolor = Color.Black;
            Button.IdleLineColor = Color.FromArgb(R, G, B);
            Button.ActiveFillColor= Color.FromArgb(R, G, B);
            Button.ActiveForecolor = Color.Black;
            Button.ActiveLineColor = Color.FromArgb(R, G, B);
        }
        public void ChangeButtonLocation(Bunifu.Framework.UI.BunifuThinButton2 A,int X,int Y)
        {
            A.Location = new Point(X, Y);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Form1.Btn_clicked = 1;
            this.Close();
        }
        #endregion
        private void ErrorMSG_MouseDown(object sender, MouseEventArgs e)
        {
            TagMove = 1;
            MvalX = e.X;
            MvalY = e.Y;
        }

        private void ErrorMSG_MouseUp(object sender, MouseEventArgs e)
        {
            TagMove = 0;
        }

        private void ErrorMSG_MouseMove(object sender, MouseEventArgs e)
        {
            if (TagMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MvalX, MousePosition.Y - MvalY);
            }
        }

        private void Cancel_Image_Button_Click(object sender, EventArgs e)
        {
            Form1.Btn_clicked = 2;
            this.Close();
        }

        public int Clicked()
        {
            if (Form1.Btn_clicked == 1)
            {
                return 1;
            }
            if (Form1.Btn_clicked == 2)
            {
                return 2;
            }
            else
                return -1;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1.Btn_clicked = 2;
            this.Close();
        }
    }
}
