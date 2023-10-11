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
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("SERVER=127.0.0.1;port=3306;DATABASE=loginform;username=root;PASSWORDS=;");
        MySqlCommand command;
        MySqlDataReader mdr;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnentrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txrcontraseña.Text) || string.IsNullOrEmpty(txtusuario.Text))
            {
                MessageBox.Show("Por favor ingrese nombre de usuario y contraseña", "Error");
            }

            else
            {
                connection.Open();
                string selectQuery = "SELECT * FROM loginform.userinfo WHERE Username = '" + txrcontraseña.Text + "' AND Password = '" + txtusuario.Text + "';";
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                    string Query = "update loginform.userinfo set LastLogin='" + "' where Username='" + this.txrcontraseña.Text + "';";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();

                    MessageBox.Show("Inicio de sesión exitosa");
                    this.Hide();
                    Form3 frm3 = new Form3();
                    frm3.ShowDialog();

                }
                else
                {

                    MessageBox.Show("¡Información de ingreso incorrecta! Intentar otra vez.");
                }

                connection.Close();
            }
        }

        private void btnregistrate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}



