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
    }
}
