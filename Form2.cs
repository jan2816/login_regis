using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace login_regis
{
    public partial class Form2 : Form
    {
        MySqlConnection connection = new MySqlConnection("SERVER=127.0.0.1;port=3306;DATABASE=loginform;username=root;PASSWORD=;");



        public Form2()
        {
            InitializeComponent();
        }

      

      

        private void btniniciar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            if(!this.txtcorrreo.Text.Contains('@') || !this.txtcorrreo.Text.Contains('.'));
            {
                MessageBox.Show("Por favor ingrese un correo electrónico válido", "Correo electrónico no válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtcontraseña.Text != txtconfirmacion.Text)
            {
                MessageBox.Show("¡La contraseña no coincide!", "Error");

                return;
            }

            if (string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txtapellido.Text) || string.IsNullOrEmpty(txtcorrreo.Text) || string.IsNullOrEmpty(txtusuario.Text) || string.IsNullOrEmpty(txtcontraseña.Text) || string.IsNullOrEmpty(txtconfirmacion.Text))
            {
                MessageBox.Show("¡Por favor complete toda la información!\", \"Error");
                return;
            }

            else
            {
                connection.Open();

                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM loginform.usirinfon WHERE usuario = @usuario", connection),
                cmd2 = new MySqlCommand("SELECT * FROM loginform.usirinfon WHERE correo = @correo", connection);


                cmd1.Parameters.AddWithValue("@usuario", txtusuario.Text);
                cmd2.Parameters.AddWithValue("@correo", txtcorrreo.Text);

                bool userExists = false, mailExists = false;

                using (var dr1 = cmd1.ExecuteReader())
                    if (userExists = dr1.HasRows) MessageBox.Show("¡Nombre de usuario no disponible!");

                using (var dr2 = cmd2.ExecuteReader())
                    if (mailExists = dr2.HasRows) MessageBox.Show("¡Correo electrónico no disponible!");


                if (!(userExists || mailExists))
                {

                    string iquery = "INSERT INTO loginform.usirinfon(`ID`,`nombre`,`apelldio`,`correo`,`Usario`, `contraseña`) VALUES (NULL, @nombre, @apellido, @correo, @usuario, @contraseña)";
                    MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);
                    commandDatabase.Parameters.AddWithValue("@nombre", txtnombre.Text);
                    commandDatabase.Parameters.AddWithValue("@apellido", txtapellido.Text);
                    commandDatabase.Parameters.AddWithValue("@correo", txtcorrreo.Text);
                    commandDatabase.Parameters.AddWithValue("@usuario", txtusuario.Text);
                    commandDatabase.Parameters.AddWithValue("@contraseña", txtcontraseña.Text);


                    try
                    {
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        // Show any error message.
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("¡Cuenta creada con éxito!");

                }

                connection.Close();
            }
        }
    }
}
