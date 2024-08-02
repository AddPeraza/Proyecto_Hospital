using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Hospital
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.pacienteDiag' table. You can move, or remove it, as needed.
            this.pacienteDiagTableAdapter.Fill(this.hospitalDataSet.pacienteDiag);
            this.panel1.Visible = false;
            this.panel2.Visible = false;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panel1.Visible=true;
            panel2.Visible=false;
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
          try { 
            String nombre = txtNombre.Text;
            String direccion = txtDireccion.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            String genero = cbGenero.Text;
            int pid = Convert.ToInt32(txtId.Text);
            String telefono = txtTelefono.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source =DESKTOP-L24LCET\\SQLEXPRESS;Database=hospital;Trusted_Connection=true";
                con.Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = con,
                    CommandText = "INSERT INTO Addpatient (Nombre, Direccion, Telefono, Genero, Edad) VALUES (@Nombre, @Direccion, @Telefono, @Genero, @Edad)"
                };
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Direccion", direccion);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Genero", genero);
                cmd.Parameters.AddWithValue("@Edad", edad);

                cmd.ExecuteNonQuery();

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                con.Close();
            }

            catch (Exception ex)
            { 
                MessageBox.Show("Formato invalido ");
            
            }

            MessageBox.Show("Paciente Guardado con exito");
            txtNombre.Clear();
            txtTelefono.Clear();
            txtEdad.Clear();
            txtDireccion.Clear();
            txtId.Clear();
            cbGenero.ResetText();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(txtpid.Text != "")
            { 

            int pid = Convert.ToInt32(txtpid.Text);
                
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = DESKTOP - L24LCET\\SQLEXPRESS; Database = hospital; Trusted_Connection = true";
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Addpatient WHERE pid = " + pid + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDiag_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible= true;
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                int pid = Convert.ToInt32(txtpid.Text);
                String sintomas = txtSintomas.Text;
                String diagnostico = txtDiagnostico.Text;
                String medicamento = txtMedicamento.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source =DESKTOP-L24LCET\\SQLEXPRESS;Database=hospital;Trusted_Connection=true";
                con.Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = con,
                    CommandText = "INSERT INTO pacienteDiag (sintomas,diagnostico,medicamento) VALUES (@Sintomas, @Diagnostico @Medicamento)"
                };
                cmd.Parameters.AddWithValue("@Sintomas", sintomas);
                cmd.Parameters.AddWithValue("@Diagnostico", diagnostico);
                cmd.Parameters.AddWithValue("@Medicamento", medicamento);
                cmd.ExecuteNonQuery();
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
            }
            catch(Exception) 
            {
                MessageBox.Show("Datos incorrectos o hay algun campo en blanco");

            }

            MessageBox.Show("Datos Guardados correctamente");
            txtDiagnostico.Clear();
            txtMedicamento.Clear();
            txtSintomas.Clear();
            txtpid.Clear();
        }
    }
}

