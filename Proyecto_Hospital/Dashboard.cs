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
            this.panel1.Visible = false;
            this.panel2.Visible = false;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panel1.Visible=true;
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
            con.ConnectionString = "Data Source =DESKTOP-L24LCET\\SQLEXPRESS;Database=hospital;Integrated Security=true";
                con.Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = con,

                    CommandText = "insert into Addpatient values ('" + nombre + "','" + direccion + "', " + telefono + "," + genero + "," + edad
                };
               

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                con.Close();
            }

            catch (Exception)
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
            if(txtId.Text != "")
            { 

            int pid = Convert.ToInt32(txtId.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source DESKTOP-L24LCET\\SQLEXPRESS;database =hospital;integrated security = True";
                con.Open();
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
            panel2.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

