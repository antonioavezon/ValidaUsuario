using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatosValida;
using CapaNegociacionValida;
using maq;


namespace VerificaUsuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //InitializeMyControl();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int veces = Int32.Parse(vez.Text);
            N check = new N();
            if (veces > 2)
            {
                MessageBox.Show("Fin del programa");
                Application.Exit();
            }
            while (veces <= 3)
            {
                if (check.Negocia(RutTxt.Text, PassTxt.Text) == true)
                {
                    MessageBox.Show("...Acceso correcto al sistema... ");
                    veces = 4;
                    Application.Exit();
                }
                else
                {
                    veces++;
                    vez.Text = veces.ToString();
                    return;
                }
                
            }
            
        }

        public void PassTxt_TextChanged(object sender, EventArgs e)
        {

        }
        //private void InitializeMyControl()
        //{
          //  PassTxt.Text = "";   
          //  PassTxt.PasswordChar = '*';
          //  PassTxt.MaxLength = 14;
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            BD obj = new BD();
            try
            {
                botonBaseDatos.Text = Convert.ToString(obj.AbrirBD());
                MessageBox.Show("Conexion Correcta !!!");
            }
            catch
            {
                MessageBox.Show("Error de Conexion !!!");
            }
        }
    }
}
