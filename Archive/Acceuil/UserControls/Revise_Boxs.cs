using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Acceuil
{
    public partial class Revise_Boxs : UserControl
    {
        SqlDataAdapter Box_Adapter = new SqlDataAdapter();
        BindingSource Box_Binding = new BindingSource();
        public Revise_Boxs()
        {
            InitializeComponent();
        }

        private void Revise_Boxs_Load(object sender, EventArgs e)
        {
            Box_Adapter = new SqlDataAdapter("SELECT Numero_Box,Type_Archive,Carton.Numero_Verssement,Position,Code_Proce,Anné_proce,NBRdossier FROM Carton inner join Addressage on Carton.Id_Address = Addressage.Id_Address inner join Verssements on Verssements.Numero_Verssement = Carton.Numero_Verssement Where Employe_ID = @Emp",Program.Connection);
            Box_Adapter.SelectCommand.Parameters.AddWithValue("@emp", Login.Employe_ID);
            Box_Adapter.Fill(Program.DataSET, "Carton");
            Box_Binding.DataSource = Program.DataSET.Tables["Carton"];
            Boxs_DataGridView.DataSource = Box_Binding;
        }
    }
}
