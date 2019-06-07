using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace AppCenso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'censoDataSet.boletas' Puede moverla o quitarla según sea necesario.
            this.boletasTableAdapter.Fill(this.censoDataSet.boletas);
            // TODO: esta línea de código carga datos en la tabla 'censoDataSet.Sectores' Puede moverla o quitarla según sea necesario.
            this.sectoresTableAdapter.Fill(this.censoDataSet.Sectores);
            // TODO: esta línea de código carga datos en la tabla 'censoDataSet2.boletas' Puede moverla o quitarla según sea necesario.
         

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(
            //    @"Data Source=.\SQLEXPRESS;
            //              AttachDbFilename=C:\Users\juan.bonilla\source\repos\AppCenso\Censo.mdf;
            //              Integrated Security=True;
            //              Connect Timeout=30;
            //              User Instance=True;"
            //    );

            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =| DataDirectory |\Censo.mdf; Integrated Security = True");

            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[boletas] ([Nombres], [Apellidos], [Direccion], [NoDui], [IdSector], [Telefono], [Colaborador]) VALUES ('Carlos', 'Perez', 'San Salvador', '035478966', 1, '22222222', 0);", con);
            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show(i + "Data Saved");
            }
            
        }

        private void BindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
