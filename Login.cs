using Capa_Entidades;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gestion_Biblioteca
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }


        private void btnregis_Click(object sender, EventArgs e)
        {
            if (txtnomlec.Text == "" || txtgmail.Text == "" || txtel.Text == "" || txtdirec.Text == "")
            {
                MessageBox.Show("Complete los campos requeridos.");
                return;
            }

            Lectores lec = new Lectores();
            CN_Usuarios negocio = new CN_Usuarios();

            lec.Nom_Lector = txtnomlec.Text;
            lec.Direc_Lector = txtdirec.Text;
            lec.Tel_Lector = txtel.Text;
            lec.Email_Lector = txtgmail.Text;

            negocio.Insertar_lec(lec);

            bool existe = negocio.ExisteLector(lec.Nom_Lector);

            if (existe == false)
            {
                MessageBox.Show("Lector registrado correctamente");
            }
            else
            {
                MessageBox.Show("Lector actualizado correctamente");
            }
        }

        private void btnvisulec_Click(object sender, EventArgs e)
        {
            Visu_Lectores frm = new Visu_Lectores();
            frm.Show();
        }
    }
}
