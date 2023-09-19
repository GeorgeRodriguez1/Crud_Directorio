using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Crud_Directorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Aqui va el codigo de los botones
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String NumerodeDocumento = cardId.Text;
                String NombreyApellidos = fullName.Text;
                double TelefonoEmpresarial = double.Parse (phone.Text);
                String CargoActual = (currentPosition.Text);
                int NumerodeOficina = int.Parse(officeNumber.Text); 
                
                if (NumerodeDocumento !="" && NombreyApellidos!="" && TelefonoEmpresarial > 0 && CargoActual!=""
                    && NumerodeOficina > 0)
                {
                    string sql = "INSERT INTO `registro de empleados` (documento,nombres,telefono,cargo,numero_oficina) VALUES " +
                        "(" + NumerodeDocumento + " , '" + NombreyApellidos + "' , " + TelefonoEmpresarial + " , '" + CargoActual + "' , " + NumerodeOficina + ")";
                    Console.Write(sql);
                    MySqlConnection conexionBD = Conexion.conexion();
                    conexionBD.Open();
                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Registro Guardado");
                        limpiar();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show ("Error al Guardar " + ex.Message);
                    }finally { conexionBD.Close(); }    
                }else 
                {
                    MessageBox.Show("Debe completar todos los campos");
                }    
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Datos incorrectos" + fex.Message);
            }
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string documento = cardId.Text;
            string sql = "DELETE FROM `registro de empleados` WHERE documento= '" + documento + "'";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Eliminado");
                limpiar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Guardar " + ex.Message);
            }
            finally { conexionBD.Close(); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar ()
        {
            cardId.Text = "";
            fullName.Text = "";
            phone.Text = "";
            currentPosition.Text = "";
            officeNumber.Text = "";
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String NumerodeDocumento = cardId.Text;
            String NombreyApellidos = fullName.Text;
            int TelefonoEmpresarial = int.Parse(phone.Text);
            String CargoActual = (currentPosition.Text);
            int NumerodeOficina = int.Parse(officeNumber.Text);

            string sql = "UPDATE `registro de empleados` SET documento=" + NumerodeDocumento + ", nombres ='" + NombreyApellidos + "', " +
                "telefono =" + TelefonoEmpresarial + ", cargo= '" + CargoActual + "', numero_oficina=  " + NumerodeOficina ;
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Actualizado");
                limpiar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Guardar " + ex.Message);
            }
            finally { conexionBD.Close(); }    
             
            }

    //hasta aqui

    private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
