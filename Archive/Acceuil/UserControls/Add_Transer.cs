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


namespace Acceuil
{
    public partial class Add_Transer : UserControl
    {
        public Add_Transer()
        {
            InitializeComponent();
        }
        public static int id_adress;
        private void Add_Transer_Load(object sender, EventArgs e)
        {
            Date_of_Transfer_Creation_Label.Text = DateTime.Now.Day.ToString()+"-"+DateTime.Now.Month.ToString()+"-"+DateTime.Now.Year.ToString();
            panel1.Enabled = false;
            panel2.Enabled = false;
            Insert_Folders_DataGridView.EnableHeadersVisualStyles = false;
            Insert_Folders_DataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(215, 104, 23);
            
        }
        private void Add_Transfer_Button_Click_1(object sender, EventArgs e)
        {
            if (Tribunal_ComboBox.Text != string.Empty && Tribunal_Codes_ComboBox.Text != string.Empty && Responsable_ComboBox.Text != string.Empty && Adminstration_ComboBox.Text != string.Empty && Number_Of_Boxs_numericUPDOWN.Value != 0 && (Non_radio.Checked == true || Oui_radio.Checked== true))
            {
                panel1.Enabled = true;
                panel3.Enabled = false;
                if (Program.Connection.State == ConnectionState.Closed)
                {
                    Program.Connection.Open();
                }
                if (Non_radio.Checked == true)
                {
                    //DateTime.Now.ToShortDateString() + "'," + Number_Of_Boxs_numericUPDOWN.Value + "," + float.Parse(Metrage) + ")"
                    string Metrage = Longeur_Label.Text.TrimEnd('M');
                    SqlCommand CMD = new SqlCommand("UPDATE Verssements SET Code_Tribunal = @Code_Tribunal,Nom_Administration = @Nom_Admin ,Responsable=@Responsable ,Date_Vessement= @Date_ver,Nombre_Box = @Nbr_Box,Metrage = @Metrage Where Numero_Verssement = @Num_Ver ", Program.Connection);
                    CMD.Parameters.AddWithValue("@Code_Tribunal", Tribunal_Codes_ComboBox.Text);
                    CMD.Parameters.AddWithValue("@Nom_Admin", Adminstration_ComboBox.Text);
                    CMD.Parameters.AddWithValue("@Responsable", Responsable_ComboBox.Text);
                    CMD.Parameters.AddWithValue("@Date_ver", DateTime.Now.ToShortDateString());
                    CMD.Parameters.AddWithValue("@Nbr_Box", Number_Of_Boxs_numericUPDOWN.Value);
                    CMD.Parameters.AddWithValue("@Metrage", float.Parse(Metrage));
                    CMD.Parameters.AddWithValue("@Num_Ver", int.Parse(Numero_Du_Transsmition_Label.Text));
                    CMD.ExecuteNonQuery();
                    if (Tribunal_ComboBox.Text == "محكمة الاستئناف ")
                    {
                        Codes_of_Proces_ComboBox.Items.Clear();
                        Program.CMD = new SqlCommand("SELECT Code_Proces,Nom_Proces,Duree_Archive FROM Proces WHERE Tribunal = 'محكمة إبتدائية-محكمة الاستئناف'", Program.Connection);
                        Program.DataReader = Program.CMD.ExecuteReader();
                        while (Program.DataReader.Read())
                        {
                            Codes_of_Proces_ComboBox.Items.Add(Program.DataReader[0]);
                        }
                    }
                    if (Tribunal_ComboBox.Text == "محكمة الاستئناف الإداريه ")
                    {
                        Codes_of_Proces_ComboBox.Items.Clear();
                        Program.CMD = new SqlCommand("SELECT Code_Proces,Nom_Proces,Duree_Archive FROM Proces WHERE Tribunal = 'محكمة الاستئناف الإداريه'", Program.Connection);
                        Program.DataReader = Program.CMD.ExecuteReader();
                        while (Program.DataReader.Read())
                        {
                            Codes_of_Proces_ComboBox.Items.Add(Program.DataReader[0]);
                        }
                    }
                    if (Tribunal_ComboBox.Text == "محكمة الاستئناف التجارية")
                    {
                        Codes_of_Proces_ComboBox.Items.Clear();
                        Program.CMD = new SqlCommand("SELECT Code_Proces,Nom_Proces,Duree_Archive FROM Proces WHERE Tribunal = 'محكمة تجارية-محكمة الاستئناف التجارية'", Program.Connection);
                        Program.DataReader = Program.CMD.ExecuteReader();
                        while (Program.DataReader.Read())
                        {
                            Codes_of_Proces_ComboBox.Items.Add(Program.DataReader[0]);
                        }
                    }
                    if (Tribunal_ComboBox.Text == "محكمة إبتدائية")
                    {
                        Codes_of_Proces_ComboBox.Items.Clear();
                        Program.CMD = new SqlCommand("SELECT Code_Proces,Nom_Proces,Duree_Archive FROM Proces WHERE Tribunal = 'محكمة إبتدائية-محكمة الاستئناف'", Program.Connection);
                        Program.DataReader = Program.CMD.ExecuteReader();
                        while (Program.DataReader.Read())
                        {
                            Codes_of_Proces_ComboBox.Items.Add(Program.DataReader[0]);
                        }
                    }
                    if (Tribunal_ComboBox.Text == "محكمة إدارية")
                    {
                        Codes_of_Proces_ComboBox.Items.Clear();
                        Program.CMD = new SqlCommand("SELECT Code_Proces,Nom_Proces,Duree_Archive FROM Proces WHERE Tribunal = 'محكمة إدارية'", Program.Connection);
                        Program.DataReader = Program.CMD.ExecuteReader();
                        while (Program.DataReader.Read())
                        {
                            Codes_of_Proces_ComboBox.Items.Add(Program.DataReader[0]);
                        }
                    }
                    if (Tribunal_ComboBox.Text == "محكمة تجارية ")
                    {
                        Codes_of_Proces_ComboBox.Items.Clear();
                        Program.CMD = new SqlCommand("SELECT Code_Proces,Nom_Proces,Duree_Archive FROM Proces WHERE Tribunal = 'محكمة تجارية-محكمة الاستئناف التجارية' or Tribunal = 'محكمة تجارية'", Program.Connection);
                        Program.DataReader = Program.CMD.ExecuteReader();
                        while (Program.DataReader.Read())
                        {
                            Codes_of_Proces_ComboBox.Items.Add(Program.DataReader[0]);
                        }
                    }
                    if (Tribunal_ComboBox.Text == "مركز القاضي المقيم ")
                    {
                        Codes_of_Proces_ComboBox.Items.Clear();
                        Program.CMD = new SqlCommand("SELECT Code_Proces,Nom_Proces,Duree_Archive FROM Proces WHERE Tribunal = 'محكمة إبتدائية-محكمة الاستئناف' or Tribunal = 'محكمة تجارية'", Program.Connection);
                        Program.DataReader = Program.CMD.ExecuteReader();
                        while (Program.DataReader.Read())
                        {
                            Codes_of_Proces_ComboBox.Items.Add(Program.DataReader[0]);
                        }
                    }
                    if (Tribunal_ComboBox.Text == "مراكز حكام الجماعات ")
                    {
                        Codes_of_Proces_ComboBox.Items.Clear();
                        Program.CMD = new SqlCommand("SELECT Code_Proces,Nom_Proces,Duree_Archive FROM Proces WHERE Tribunal = 'محكمة إبتدائية-محكمة الاستئناف' or Tribunal = 'محكمة تجارية'", Program.Connection);
                        Program.DataReader = Program.CMD.ExecuteReader();
                        while (Program.DataReader.Read())
                        {
                            Codes_of_Proces_ComboBox.Items.Add(Program.DataReader[0]);
                        }
                    }
                    Program.Connection.Close();
                    if (Program.Connection.State == ConnectionState.Closed)
                    {
                        Program.Connection.Open();
                    }
                    CMD = new SqlCommand("SELECT TOP(1)Position,Id_Address FROM Addressage WHERE Libre_Etat = 0 ", Program.Connection);
                    SqlDataReader Reader = CMD.ExecuteReader();
                    DataTable T = new DataTable();
                    T.Load(Reader);
                    Box_Cord_Label.Text = T.Rows[0][0].ToString();
                    id_adress = Convert.ToInt32(T.Rows[0][1]);
                }
                if (Oui_radio.Checked == true)
                {
                    string Metrage = Longeur_Label.Text.TrimEnd('M');
                    SqlCommand CMD = new SqlCommand("UPDATE Verssements SET Code_Tribunal = @Code_Tribunal,Nom_Administration = @Nom_Admin ,Responsable=@Responsable ,Date_Vessement= @Date_ver,Nombre_Box = @Nbr_Box,Metrage = @Metrage, Stocker = @Stocker,Date_Stockage = @Date_Stockage WHERE Numero_Verssement = @Num_Ver ", Program.Connection);
                    CMD.Parameters.AddWithValue("@Code_Tribunal", Tribunal_Codes_ComboBox.Text);
                    CMD.Parameters.AddWithValue("@Nom_Admin", Adminstration_ComboBox.Text);
                    CMD.Parameters.AddWithValue("@Responsable", Responsable_ComboBox.Text);
                    CMD.Parameters.AddWithValue("@Date_ver", DateTime.Now.ToShortDateString());
                    CMD.Parameters.AddWithValue("@Nbr_Box", Number_Of_Boxs_numericUPDOWN.Value);
                    CMD.Parameters.AddWithValue("@Metrage", float.Parse(Metrage));
                    CMD.Parameters.AddWithValue("@Stocker", 1);
                    CMD.Parameters.AddWithValue("@Date_Stockage", DateTime.Now.ToShortDateString());
                    CMD.Parameters.AddWithValue("@Num_Ver", int.Parse(Numero_Du_Transsmition_Label.Text));
                    CMD.ExecuteNonQuery();
                    if (Tribunal_ComboBox.Text == "محكمة الاستئناف ")
                    {
                        Codes_of_Proces_ComboBox.Items.Clear();
                        Program.CMD = new SqlCommand("SELECT Code_Proces,Nom_Proces,Duree_Archive FROM Proces WHERE Tribunal = 'محكمة إبتدائية-محكمة الاستئناف'", Program.Connection);
                        Program.DataReader = Program.CMD.ExecuteReader();
                        while (Program.DataReader.Read())
                        {
                            Codes_of_Proces_ComboBox.Items.Add(Program.DataReader[0]);
                        }
                    }
                    if (Tribunal_ComboBox.Text == "محكمة الاستئناف الإداريه ")
                    {
                        Codes_of_Proces_ComboBox.Items.Clear();
                        Program.CMD = new SqlCommand("SELECT Code_Proces,Nom_Proces,Duree_Archive FROM Proces WHERE Tribunal = 'محكمة الاستئناف الإداريه'", Program.Connection);
                        Program.DataReader = Program.CMD.ExecuteReader();
                        while (Program.DataReader.Read())
                        {
                            Codes_of_Proces_ComboBox.Items.Add(Program.DataReader[0]);
                        }
                    }
                    if (Tribunal_ComboBox.Text == "محكمة الاستئناف التجارية")
                    {
                        Codes_of_Proces_ComboBox.Items.Clear();
                        Program.CMD = new SqlCommand("SELECT Code_Proces,Nom_Proces,Duree_Archive FROM Proces WHERE Tribunal = 'محكمة تجارية-محكمة الاستئناف التجارية'", Program.Connection);
                        Program.DataReader = Program.CMD.ExecuteReader();
                        while (Program.DataReader.Read())
                        {
                            Codes_of_Proces_ComboBox.Items.Add(Program.DataReader[0]);
                        }
                    }
                    if (Tribunal_ComboBox.Text == "محكمة إبتدائية")
                    {
                        Codes_of_Proces_ComboBox.Items.Clear();
                        Program.CMD = new SqlCommand("SELECT Code_Proces,Nom_Proces,Duree_Archive FROM Proces WHERE Tribunal = 'محكمة إبتدائية-محكمة الاستئناف'", Program.Connection);
                        Program.DataReader = Program.CMD.ExecuteReader();
                        while (Program.DataReader.Read())
                        {
                            Codes_of_Proces_ComboBox.Items.Add(Program.DataReader[0]);
                        }
                    }
                    if (Tribunal_ComboBox.Text == "محكمة إدارية")
                    {
                        Codes_of_Proces_ComboBox.Items.Clear();
                        Program.CMD = new SqlCommand("SELECT Code_Proces,Nom_Proces,Duree_Archive FROM Proces WHERE Tribunal = 'محكمة إدارية'", Program.Connection);
                        Program.DataReader = Program.CMD.ExecuteReader();
                        while (Program.DataReader.Read())
                        {
                            Codes_of_Proces_ComboBox.Items.Add(Program.DataReader[0]);
                        }
                    }
                    if (Tribunal_ComboBox.Text == "محكمة تجارية ")
                    {
                        Codes_of_Proces_ComboBox.Items.Clear();
                        Program.CMD = new SqlCommand("SELECT Code_Proces,Nom_Proces,Duree_Archive FROM Proces WHERE Tribunal = 'محكمة تجارية-محكمة الاستئناف التجارية' or Tribunal = 'محكمة تجارية'", Program.Connection);
                        Program.DataReader = Program.CMD.ExecuteReader();
                        while (Program.DataReader.Read())
                        {
                            Codes_of_Proces_ComboBox.Items.Add(Program.DataReader[0]);
                        }
                    }
                    if (Tribunal_ComboBox.Text == "مركز القاضي المقيم ")
                    {
                        Codes_of_Proces_ComboBox.Items.Clear();
                        Program.CMD = new SqlCommand("SELECT Code_Proces,Nom_Proces,Duree_Archive FROM Proces WHERE Tribunal = 'محكمة إبتدائية-محكمة الاستئناف' or Tribunal = 'محكمة تجارية'", Program.Connection);
                        Program.DataReader = Program.CMD.ExecuteReader();
                        while (Program.DataReader.Read())
                        {
                            Codes_of_Proces_ComboBox.Items.Add(Program.DataReader[0]);
                        }
                    }
                    if (Tribunal_ComboBox.Text == "مراكز حكام الجماعات ")
                    {
                        Codes_of_Proces_ComboBox.Items.Clear();
                        Program.CMD = new SqlCommand("SELECT Code_Proces,Nom_Proces,Duree_Archive FROM Proces WHERE Tribunal = 'محكمة إبتدائية-محكمة الاستئناف' or Tribunal = 'محكمة تجارية'", Program.Connection);
                        Program.DataReader = Program.CMD.ExecuteReader();
                        while (Program.DataReader.Read())
                        {
                            Codes_of_Proces_ComboBox.Items.Add(Program.DataReader[0]);
                        }
                    }
                    Program.Connection.Close();
                    if (Program.Connection.State == ConnectionState.Closed)
                    {
                        Program.Connection.Open();
                    }
                    CMD = new SqlCommand("SELECT TOP(1)Position,Id_Address FROM Addressage WHERE Libre_Etat = 0 ", Program.Connection);
                    SqlDataReader Reader = CMD.ExecuteReader();
                    DataTable T = new DataTable();
                    T.Load(Reader);
                    Box_Cord_Label.Text = T.Rows[0][0].ToString();
                    id_adress = Convert.ToInt32(T.Rows[0][1]);
                }
                The_Numbers_of_Box_Label.Text = "1";
                ErrorMSG E = new ErrorMSG();
                E.Button1.Location = new Point(150, 55);
                E.Error_TITRE_Label.Text = "تم إدخال التحويلة بنجاح";
                E.Message_Label.Text = "المرجوا إدخال معلومات العلبة رقم 1";
                //E.Message_Label.Location = new Point(83, 38);
                E.BackColor = Color.FromArgb(46, 204, 113);
                E.Changerbuttoncouleur(E.Button1, 46, 204, 113);
                E.Button1.ButtonText = "نعم";
                E.ChangeIcon(ArchiveAPPLICATION.Properties.Resources.success);
                E.ShowDialog();
                
            }
            else
            {
                ErrorMSG E = new ErrorMSG();
                E.Message_Label.Text = "يجب ملئ جميع الخانات";
                E.Button1.ButtonText = "حسنا";
                E.Button1.Location = new Point(148, 55);
                E.ShowDialog();
            }
                
               
        }

        private void Add_Box_Button_Click_1(object sender, EventArgs e)
        {
            if (Codes_of_Proces_ComboBox.Text != string.Empty && Date_Jujment_NumiricUpDown.Value != 0 && Type_of_Archive_DataLabel.Text != "...." )
            {
                panel2.Enabled = true;
                panel1.Enabled = false;
                if (Program.Connection.State == ConnectionState.Closed)
                {
                    Program.Connection.Open();
                }
                SqlCommand CMD = new SqlCommand("INSERT INTO Carton(Numero_Verssement,Type_Archive,Numero_Box,Id_Address,Code_Proce,Anné_proce) VALUES(@N_Ver,@Type_Arch,@N_Box,@id_address,@Code_Proce,@Anné_proce)", Program.Connection);
                CMD.Parameters.AddWithValue("@N_Ver", int.Parse(Numero_Du_Transsmition_Label.Text));
                CMD.Parameters.AddWithValue("@Type_Arch", Type_of_Archive_DataLabel.Text);
                CMD.Parameters.AddWithValue("@N_Box", int.Parse(The_Numbers_of_Box_Label.Text));
                CMD.Parameters.AddWithValue("@id_address", id_adress);
                CMD.Parameters.AddWithValue("@Code_Proce", Codes_of_Proces_ComboBox.Text);
                CMD.Parameters.AddWithValue("@Anné_proce", Date_Jujment_NumiricUpDown.Value);
                CMD.ExecuteNonQuery();
                Program.Connection.Close();
                Program.Connection.Open();
                CMD = new SqlCommand("UPDATE Addressage SET Libre_Etat = 1 WHERE Id_Address = @Id_Addre", Program.Connection);
                CMD.Parameters.AddWithValue("@Id_Addre", id_adress);
                CMD.ExecuteNonQuery();
                Program.Connection.Close();
                ErrorMSG E = new ErrorMSG();
                E.Button1.Location = new Point(150, 55);
                E.Error_TITRE_Label.Text = "تم إدخال العلبة بنجاح";
                E.Message_Label.Text = "المرجوا إدخال معلومات ملفات العلبة";
                //E.Message_Label.Location = new Point(83, 38);
                E.BackColor = Color.FromArgb(46, 204, 113);
                E.Changerbuttoncouleur(E.Button1, 46, 204, 113);
                E.Button1.ButtonText = "نعم";
                E.ChangeIcon(ArchiveAPPLICATION.Properties.Resources.success);
                E.ShowDialog();
            }
            else
            {
                ErrorMSG E = new ErrorMSG();
                E.Message_Label.Text = "يجب ملئ جميع خانات العلبة";
                E.Button1.Location = new Point(151, 55);
                E.Button1.ButtonText = "حسنا";
                E.ShowDialog();
            }

        }

        private void Add_Files_Button_Click_1(object sender, EventArgs e)
        {
            int Etat = -1;
            for (int i = 0; i < Insert_Folders_DataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < Insert_Folders_DataGridView.Columns.Count; j++)
                {
                    if (Insert_Folders_DataGridView.Rows[i].Cells[j].Value == null)
                    {
                        Etat = 0;
                    }
                }
            }
            if (Insert_Folders_DataGridView.Rows[0].Cells[0].Value == null)
            {
                Etat = 0;
            }
            if (Etat == 0)
            {
                ErrorMSG E = new ErrorMSG();
                E.Message_Label.Text = "يوجد خانة لم يتم إملائها";
                //E.Message_Label.Location = new Point(124, 38);
                E.Button1.Location = new Point(151, 55);
                E.Button1.ButtonText = "حسنا";
                E.ShowDialog();
            }
            if (Etat == -1)
            {
                if (int.Parse(The_Numbers_of_Box_Label.Text) != Number_Of_Boxs_numericUPDOWN.Value)
                {
                    for (int i = 0; i < Insert_Folders_DataGridView.Rows.Count - 1; i++)
                    {
                        if (Program.Connection.State == ConnectionState.Closed)
                        {
                            Program.Connection.Open();
                        }
                        SqlCommand CMD1 = new SqlCommand("insert into Dossier(Id_Dossier,Numero_Dossier,Anne_Ouverture,Numero_jujment,description,Numero_Ver,Type_Archi,Numero_BoX) Values(@id_Dossier,@Numero_Dossier,@Ann_over,@N_jujment,@Description,@Numero_V,@T_Arch,@N_Box)", Program.Connection);
                        CMD1.Parameters.AddWithValue("@id_Dossier", Insert_Folders_DataGridView.Rows[i].Cells[0].Value);
                        CMD1.Parameters.AddWithValue("@Numero_Dossier", Insert_Folders_DataGridView.Rows[i].Cells[1].Value);
                        CMD1.Parameters.AddWithValue("@Ann_over", Insert_Folders_DataGridView.Rows[i].Cells[2].Value);
                        CMD1.Parameters.AddWithValue("@N_jujment", Insert_Folders_DataGridView.Rows[i].Cells[3].Value);
                        CMD1.Parameters.AddWithValue("@Description", Insert_Folders_DataGridView.Rows[i].Cells[4].Value);
                        CMD1.Parameters.AddWithValue("@Numero_V",int.Parse(Numero_Du_Transsmition_Label.Text) );
                        CMD1.Parameters.AddWithValue("@T_Arch",Type_of_Archive_DataLabel.Text);
                        CMD1.Parameters.AddWithValue("@N_Box",int.Parse(The_Numbers_of_Box_Label.Text));
                        CMD1.ExecuteNonQuery();
                    }
                    Program.Connection.Close();
                    Program.Connection.Open();
                    SqlCommand CMD2 = new SqlCommand("UPDATE Carton SET NBRdossier = @nbrdossier WHERE Numero_Verssement = @N_ver AND Type_Archive = @Typ_Arch AND Numero_Box = @id_File", Program.Connection);
                    CMD2.Parameters.AddWithValue("NBRdossier", Insert_Folders_DataGridView.Rows.Count - 1);
                    CMD2.Parameters.AddWithValue("N_ver", int.Parse(Numero_Du_Transsmition_Label.Text));
                    CMD2.Parameters.AddWithValue("@Typ_Arch", Type_of_Archive_DataLabel.Text);
                    CMD2.Parameters.AddWithValue("@id_File", int.Parse(The_Numbers_of_Box_Label.Text));
                    CMD2.ExecuteNonQuery();
                    Program.Connection.Close();
                    Program.Connection.Open();
                    SqlCommand CMD = new SqlCommand("SELECT TOP(1)Position,Id_Address FROM Addressage WHERE Libre_Etat = 0 ", Program.Connection);
                    SqlDataReader Reader = CMD.ExecuteReader();
                    DataTable T = new DataTable();
                    T.Load(Reader);
                    Box_Cord_Label.Text = T.Rows[0][0].ToString();
                    id_adress = Convert.ToInt32(T.Rows[0][1]);
                    Program.Connection.Close();
                    panel1.Enabled = true;
                    panel2.Enabled = false;
                    Insert_Folders_DataGridView.Rows.Clear();
                    The_Numbers_of_Box_Label.Text = (int.Parse(The_Numbers_of_Box_Label.Text) + 1).ToString();
                    ResetControls(panel1);
                    Type_of_Archive_DataLabel.Text = "....";

                    ErrorMSG E = new ErrorMSG();
                    E.Button1.Location = new Point(150, 55);
                    E.Error_TITRE_Label.Text = "تم إدخال معلومات الملفات بنجاح";
                    E.Message_Label.Text = "المرجوا إدخال معلومات العلبة رقم " + The_Numbers_of_Box_Label.Text;
                    //E.Message_Label.Location = new Point(83, 38);
                    E.BackColor = Color.FromArgb(46, 204, 113);
                    E.Changerbuttoncouleur(E.Button1, 46, 204, 113);
                    E.Button1.ButtonText = "نعم";
                    E.ChangeIcon(ArchiveAPPLICATION.Properties.Resources.success);
                    E.ShowDialog();

                }
                else
                {
                    if (Program.Connection.State == ConnectionState.Closed)
                    {
                        Program.Connection.Open();
                    }
                    SqlCommand CMD2 = new SqlCommand("UPDATE Carton SET NBRdossier = @nbrdossier WHERE Numero_Verssement = @N_ver AND Type_Archive = @Typ_Arch AND Numero_Box = @id_File", Program.Connection);
                    CMD2.Parameters.AddWithValue("NBRdossier", Insert_Folders_DataGridView.Rows.Count - 1);
                    CMD2.Parameters.AddWithValue("N_ver", int.Parse(Numero_Du_Transsmition_Label.Text));
                    CMD2.Parameters.AddWithValue("@Typ_Arch", Type_of_Archive_DataLabel.Text);
                    CMD2.Parameters.AddWithValue("@id_File", int.Parse(The_Numbers_of_Box_Label.Text));
                    CMD2.ExecuteNonQuery();
                    Insert_Folders_DataGridView.Rows.Clear();
                    ResetControls(panel1);
                    ResetControls(panel2);
                    ResetControls(panel3);
                    Numero_Du_Transsmition_Label.Text = "....";
                    Date_of_Transfer_Creation_Label.Text = "....";
                    Type_of_Archive_DataLabel.Text = "....";
                    Longeur_Label.Text = "....";
                    panel3.Enabled = true;
                    panel2.Enabled = false;

                    ErrorMSG E = new ErrorMSG();
                    E.Button1.Location = new Point(150, 55);
                    E.Error_TITRE_Label.Text = "لقد تم إدخال جميع الملفات في التحويلة";
                    E.Message_Label.Text = "يمكنك إضافة تحولية جديدة أو مراجعة التحويلة في القائمة على اليمين";
                    //E.Message_Label.Location = new Point(83, 38);
                    E.BackColor = Color.FromArgb(46, 204, 113);
                    E.Changerbuttoncouleur(E.Button1, 46, 204, 113);
                    E.Button1.ButtonText = "نعم";
                    E.ChangeIcon(ArchiveAPPLICATION.Properties.Resources.success);
                    E.ShowDialog();
                    Form1.Home_button_Click_Value = 1;
                    
                }
            }
        }
        private void Add_Transer_VisibleChanged(object sender, EventArgs e)
        {
            ResetControls(panel3);
            ResetControls(panel1);
            ResetControls(panel2);
            panel2.Enabled = false;
            panel1.Enabled = false;
            panel3.Enabled = true;
        }
        public static void ResetControls(Panel P)
        {
            foreach (Control C in P.Controls)
            {
                var textBox       = C as TextBox;
                var comboBox      = C as ComboBox;
                var Numericupdown = C as NumericUpDown;
                var checkbox      = C as CheckBox;
                var radio         = C as RadioButton; 
                if (textBox != null)
                {
                    (textBox).Clear();
                }
                if (comboBox != null)
                {
                    comboBox.SelectedIndex = -1;
                }
                if (Numericupdown != null)
                {
                    Numericupdown.Value = 0;
                }
                if (checkbox != null)
                {
                    checkbox.Checked = false;
                }
                if (radio != null)
                {
                    radio.Checked = false;
                }
            }
        }
       
        private void Tribunal_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Adminstration_ComboBox.Items.Clear();
            Tribunal_Codes_ComboBox.Items.Clear();
            if (Program.Connection.State == ConnectionState.Closed)
            {
                Program.Connection.Open();
            }
            if (Tribunal_ComboBox.SelectedIndex == 0)
            {
                Program.CMD = new SqlCommand("select top(6)Code_Tribunal_TCA from TCA", Program.Connection);
                Adminstration_ComboBox.Items.Add("الرئاسة");
                Adminstration_ComboBox.Items.Add("النيابة العامة");
            }
            if (Tribunal_ComboBox.SelectedIndex == 1)
            {
                Program.CMD = new SqlCommand("select Code_Tribunal_TCA from TCA WHERE Nom_Tribunal_TCA = 'محكمة الاستئناف الإدارية بمراكش' ", Program.Connection);
                Adminstration_ComboBox.Items.Add("الرئاسة");
            }
            if (Tribunal_ComboBox.SelectedIndex == 2)
            {
                Program.CMD = new SqlCommand("select Code_Tribunal_TCA from TCA WHERE Nom_Tribunal_TCA = 'محكمة الاستئناف التجارية بمراكش' ", Program.Connection);
                Adminstration_ComboBox.Items.Add("الرئاسة");
                Adminstration_ComboBox.Items.Add("النيابة العامة");
            }
            if (Tribunal_ComboBox.SelectedIndex == 3)
            {
                Program.CMD = new SqlCommand("select TOP(24)Code_Tribunal_TPI from TPI", Program.Connection);
                Adminstration_ComboBox.Items.Add("الرئاسة");
                Adminstration_ComboBox.Items.Add("النيابة العامة");
            }
            if (Tribunal_ComboBox.SelectedIndex == 4)
            {
                Program.CMD = new SqlCommand("select Code_Tribunal_TPI from TPI WHERE (Nom_Tribunal_TPI like '%المحكمة الإدارية%') ", Program.Connection);
                Adminstration_ComboBox.Items.Add("الرئاسة");
            }
            if (Tribunal_ComboBox.SelectedIndex == 5)
            {
                Program.CMD = new SqlCommand("select Code_Tribunal_TPI from TPI WHERE (Nom_Tribunal_TPI like '%التجارية%') ", Program.Connection);
                Adminstration_ComboBox.Items.Add("الرئاسة");
                Adminstration_ComboBox.Items.Add("النيابة العامة");
            }
            if (Tribunal_ComboBox.SelectedIndex == 6)
            {
                Program.CMD = new SqlCommand("select Code_Tribunal_CJ from CJ", Program.Connection);
                Adminstration_ComboBox.Items.Add("المركز");
            }
            if (Tribunal_ComboBox.SelectedIndex == 7)
            {
                Program.CMD = new SqlCommand("select Code_Tribunal_TGC from TGC", Program.Connection);
                Adminstration_ComboBox.Items.Add("الرئاسة");
            }
            if (Tribunal_ComboBox.SelectedIndex == 8)
            {
                Program.CMD = new SqlCommand("select Code_Tribunal_SDR from SDR", Program.Connection);
                Adminstration_ComboBox.Items.Add("المديرية الفرعية");
            }
            if (Tribunal_ComboBox.SelectedIndex == 9)
            {
                Tribunal_Codes_ComboBox.Items.Clear();
                Tribunal_Codes_ComboBox.Items.Add('E');
                Adminstration_ComboBox.Items.Add("المركز");
            }
            Program.DataReader = Program.CMD.ExecuteReader();
            while (Program.DataReader.Read() && Tribunal_ComboBox.SelectedIndex != 9)
            {
                Tribunal_Codes_ComboBox.Items.Add(Program.DataReader[0]);
            }
            Program.Connection.Close();
        }

        private void Adminstration_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Responsable_ComboBox.Items.Clear();
            if (Adminstration_ComboBox.Text == "الرئاسة")
            {
                Responsable_ComboBox.Items.Add("رئيس مصلحة كتابة الضبط");
            }
            if (Adminstration_ComboBox.Text == "النيابة العامة")
            {
                Responsable_ComboBox.Items.Add("رئيس مصلحة كتابةالنيابةالعامة");
            }
            if (Adminstration_ComboBox.Text == "المديرية الفرعية")
            {
                Responsable_ComboBox.Items.Add("المدير الفرعي الإقليمي");
            }
            if (Adminstration_ComboBox.Text == "المركز" && Tribunal_ComboBox.Text == "المركز الجهوي للحفظ بمركش")
            {
                Responsable_ComboBox.Items.Add("المسؤول عن المركز");
            }
            if (Adminstration_ComboBox.Text == "المركز" && Tribunal_ComboBox.Text == "مركز القاضي المقيم ")
            {
                Responsable_ComboBox.Items.Add("القاضي المقيم");
            }
        }

        private void Number_Of_Boxs_numericUPDOWN_ValueChanged(object sender, EventArgs e)
        {
            Longeur_Label.Text = Convert.ToString(Convert.ToDouble(Number_Of_Boxs_numericUPDOWN.Value) * 0.40) + "M";

        }

        private void Box_Archive_update_Button_Click(object sender, EventArgs e)
        {
            if (Codes_of_Proces_ComboBox.Text != string.Empty && Date_Jujment_NumiricUpDown.Value != 0)
            {
                if (Program.Connection.State == ConnectionState.Closed)
                {
                    Program.Connection.Open();
                }
                SqlCommand CMD = new SqlCommand("SELECT Duree_Archive FROM Proces WHERE Code_Proces = @code ",Program.Connection);
                CMD.Parameters.AddWithValue("@code", Codes_of_Proces_ComboBox.Text);
                SqlDataReader Reader = CMD.ExecuteReader();
                DataTable T = new DataTable();
                T.Load(Reader);
                int Anne_archive = Convert.ToInt32(Date_Jujment_NumiricUpDown.Value.ToString()) + int.Parse(T.Rows[0][0].ToString());
                if (Anne_archive > DateTime.Now.Year)
                    {
                     Type_of_Archive_DataLabel.Text = "EY";
                    }
                else
                   Type_of_Archive_DataLabel.Text = "EZ"; 
            }
        }

        private void Codes_of_Proces_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Codes_of_Proces_ComboBox.Text != string.Empty && Date_Jujment_NumiricUpDown.Value != 0)
            {
                if (Program.Connection.State == ConnectionState.Closed)
                {
                    Program.Connection.Open();
                }
                SqlCommand CMD = new SqlCommand("SELECT Duree_Archive FROM Proces WHERE Code_Proces = @code ", Program.Connection);
                CMD.Parameters.AddWithValue("@code", Codes_of_Proces_ComboBox.Text);
                SqlDataReader Reader = CMD.ExecuteReader();
                DataTable T = new DataTable();
                T.Load(Reader);
                int Anne_archive = Convert.ToInt32(Date_Jujment_NumiricUpDown.Value.ToString()) + int.Parse(T.Rows[0][0].ToString());
                if (Anne_archive > DateTime.Now.Year)
                {
                    Type_of_Archive_DataLabel.Text = "EY";
                }
                else
                    Type_of_Archive_DataLabel.Text = "EZ";
            }
        }

        private void Date_Jujment_NumiricUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            if (Codes_of_Proces_ComboBox.Text != string.Empty && Date_Jujment_NumiricUpDown.Value != 0)
            {
                if (Program.Connection.State == ConnectionState.Closed)
                {
                    Program.Connection.Open();
                }
                SqlCommand CMD = new SqlCommand("SELECT Duree_Archive FROM Proces WHERE Code_Proces = @code ", Program.Connection);
                CMD.Parameters.AddWithValue("@code", Codes_of_Proces_ComboBox.Text);
                SqlDataReader Reader = CMD.ExecuteReader();
                DataTable T = new DataTable();
                T.Load(Reader);
                int Anne_archive = Convert.ToInt32(Date_Jujment_NumiricUpDown.Value.ToString()) + int.Parse(T.Rows[0][0].ToString());
                if (Anne_archive > DateTime.Now.Year)
                {
                    Type_of_Archive_DataLabel.Text = "EY";
                }
                else
                    Type_of_Archive_DataLabel.Text = "EZ";
            }
        }
    }
}
