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
        public ErrorMSG()
        {
            InitializeComponent();
        }

        private void ErrorMSG_Load(object sender, EventArgs e)
        {
            Error_TITRE_Label.Location = new Point(Erreur_Icon_Picturebox.Location.X + (Erreur_Icon_Picturebox.Width / 2) - (Error_TITRE_Label.Width / 2), Error_TITRE_Label.Location.Y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
