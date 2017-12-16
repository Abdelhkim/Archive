using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Acceuil
{
    public partial class Revise_transfers : UserControl
    {
        SqlDataAdapter Vers_Adapter;       
        BindingSource Vers_Binding = new BindingSource();
        public Revise_transfers()
        {
            InitializeComponent();
        }

        private void Revise_transfers_Load(object sender, EventArgs e)
        {
            Vers_Adapter = new SqlDataAdapter("select Numero_Verssement,Code_Tribunal,Nom_Administration,Responsable,Date_Vessement,Nombre_Box,Metrage,Date_Stockage FROM Verssements WHERE Employe_ID = @Emp", Program.Connection);
            Vers_Adapter.SelectCommand.Parameters.AddWithValue("@emp", Login.Employe_ID);
            Vers_Adapter.Fill(Program.DataSET, "Verssements");
            Vers_Binding.DataSource = Program.DataSET.Tables["Verssements"];
            Verssements_DataGridView.DataSource = Vers_Binding;
            Verssements_DataGridView.Columns[0].HeaderText = "رقم التحويلة";
            Verssements_DataGridView.Columns[1].HeaderText = "رمز المحكمة";
            Verssements_DataGridView.Columns[2].HeaderText = "رمز المصلحة";
            Verssements_DataGridView.Columns[3].HeaderText = "المسؤول";
            Verssements_DataGridView.Columns[4].HeaderText = "تاريخ التحويلة";
            Verssements_DataGridView.Columns[5].HeaderText = "عدد العلب";
            Verssements_DataGridView.Columns[6].HeaderText = "طول التحويلة";
            Verssements_DataGridView.Columns[7].HeaderText = "تاريخ التخزين";
        }
    }
}
