using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Imaging;

namespace Crud_Directorio
{
    /// <summary>
    /// Class <c>Form1</c> manage events related with Form1 Windows Form
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Method <c>Form1</c> initialize Windows Forms Form1 object
        /// </summary>
        /// <returns>void</returns>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method <c>btnSave_Click</c> store a new employee into the database
        /// </summary>
        /// <returns>void</returns>
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
                    string FotoRuta;
                    if (profileImage.Image != null)
                    {
                        FotoRuta = guardarFoto(profileImage, NumerodeDocumento);
                    }
                    else
                    {
                        FotoRuta = null;
                    }
                    string sql = "INSERT INTO `registro de empleados` (documento,nombres,telefono,cargo,numero_oficina,foto) VALUES " +
                        "(" + NumerodeDocumento + " , '" + NombreyApellidos + "' , " + TelefonoEmpresarial + " , '" + CargoActual + "' , " + NumerodeOficina + ", '" + FotoRuta + "')";
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
        /// <summary>
        /// Method <c>btnDelete_Click</c> delete an employee into from database
        /// </summary>
        /// <returns>void</returns>
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

        /// <summary>
        /// Method <c>btnClear_Click</c> clean all input controls from the main Form1
        /// </summary>
        /// <returns>void</returns>
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
            profileImage.Image = null;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String NumerodeDocumento = cardId.Text;
            String NombreyApellidos = fullName.Text;
            int TelefonoEmpresarial = int.Parse(phone.Text);
            String CargoActual = (currentPosition.Text);
            int NumerodeOficina = int.Parse(officeNumber.Text);

            string FotoRuta;
            if (profileImage.Image != null)
            {
                FotoRuta = guardarFoto(profileImage, NumerodeDocumento);
            }
            else
            {
                FotoRuta = null;
            }

            string sql = "UPDATE `registro de empleados` SET documento=" + NumerodeDocumento + ", nombres ='" + NombreyApellidos + "', " +
                "telefono =" + TelefonoEmpresarial + ", cargo= '" + CargoActual + "', numero_oficina= " + NumerodeOficina + 
                ", foto='" + FotoRuta + "'";

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

        /// <summary>
        /// Method <c>profileImage_Click</c> open a select dialog to upload a image as
        /// employee photo.
        /// </summary>
        /// <returns>void</returns>
        private void profileImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            foto.Filter = "Imagenes (*.bmp, *.jpg, *.jpeg)|*.bmp;*.jpg;*.jpeg";
            if (foto.ShowDialog() == DialogResult.OK)
            {
                if (foto.CheckFileExists)
                {
                    profileImage.Image = new Bitmap(foto.FileName);
                    profileImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }

            Console.WriteLine(profileImage.Image);
        }

        /// <summary>
        /// Method <c>cardId_KeyPress</c> search for an employee using their 
        /// documentation id.
        /// </summary>
        /// <returns>void</returns>
        private void cardId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(cardId.Text))
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                    string sql = "SELECT * from `registro de empleados` where documento='" + cardId.Text + "'";
                    MySqlConnection conexionBD = Conexion.conexion();
                    conexionBD.Open();
                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        MySqlDataReader registro = comando.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(registro);

                        if(dt.Rows.Count > 0)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                this.fullName.Text = row["nombres"].ToString();
                                this.phone.Text = row["telefono"].ToString();
                                this.currentPosition.Text = row["cargo"].ToString();
                                this.officeNumber.Text = row["numero_oficina"].ToString();
                                string foto = row["foto"].ToString();
                                if (foto != "")
                                {
                                    profileImage.Image = Image.FromFile(foto);
                                    profileImage.SizeMode = PictureBoxSizeMode.StretchImage;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontro: " + cardId.Text);
                        }

                        registro.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al Buscar " + ex.Message);
                    }
                    finally { conexionBD.Close(); }
                }
            }
        }
        /// <summary>
        /// Method <c>guardarFoto</c> store an employee's photo into machine 
        /// filesystem
        /// </summary>
        /// <returns>string</returns>
        private string guardarFoto(PictureBox foto, string NumerodeDocumento)
        {
            string fotoRuta = @"C:\\profileImages\\" + NumerodeDocumento + ".jpeg";
            foto.Image.Save(fotoRuta, ImageFormat.Jpeg);
            Console.WriteLine(fotoRuta);
            return fotoRuta;
        }
    }
}
