using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace Acceuil
{
    public partial class Acceuil_user : UserControl
    {
        public Acceuil_user()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(Total_Transfers_Gradian_panel, 7);
            Bunifu.Framework.Lib.Elipse.Apply(Total_Boxs_Gradian_Panel, 7);
            Bunifu.Framework.Lib.Elipse.Apply(Total_Folders_Gradian_Panel, 7);
        }

        private void Acceuil_Load(object sender, EventArgs e)
        {
            cartesianChart1.LegendLocation = LegendLocation.Bottom;
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "إنتاج",
                    FontSize = 25,
                    Values = new ChartValues<double> {4, 6, 5, 2, 7}
                },

            };

        }

        private void bunifuCards11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Acceuil_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
