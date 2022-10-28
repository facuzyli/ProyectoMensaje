using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        MensajesBLL miMensajeBLL = new MensajesBLL();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mensaje miMensaje = new Mensaje();
            
            miMensaje.Asunto = textBox1.Text;
            miMensaje.Mensajee = richTextBox1.Text;
            miMensaje.Emisor = textBox2.Text;
            miMensaje.Receptor = textBox3.Text;
            miMensaje.Urgencia =  checkBox1.Checked;
            miMensaje.FechayHora = DateTime.Now;

            miMensajeBLL.Crear(miMensaje);


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            richTextBox1.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = miMensajeBLL.obtenerTodos();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
