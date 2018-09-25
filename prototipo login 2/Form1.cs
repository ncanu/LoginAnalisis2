using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica;
namespace prototipo_login_2
{
    public partial class Form1 : Form
    {
        MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
        

     


        public Form1()
        {
            InitializeComponent();
        }



        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            string username = Txt_loginUser.Text;
            string password = Txt_loginPass.Text;
            CapaLogica capaLogica = new CapaLogica();

            if (username == "" || password == "")
            {
                MessageBox.Show("Los campos son obligatorios");
            }


            if (capaLogica.login(username, password))
            {

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
                capaLogicaB cl = new capaLogicaB();
                cl.insertBitacora("Error Conexion");
            }


        }

    }
}
