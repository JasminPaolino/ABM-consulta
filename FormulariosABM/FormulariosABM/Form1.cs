using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosABM
{
    public partial class Form1 : Form
    {
        PersonaDAO dao = new PersonaDAO();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dao.listar();
            foreach (Persona i in dao.listar())
            {
                comboBox1.Items.Add(i.Id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 formAlta = new Form2();
            this.Hide();
            formAlta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string valor = comboBox1.Text;
            if (valor != "")
            {
                dao.eliminar(valor);
            }
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valor = comboBox1.Text;
            if (valor != "")
            {
                Persona persona = new Persona();
                persona.Nombre = textBox1.Text;
                persona.Apellido = textBox2.Text;
                persona.Sueldo = float.Parse(textBox3.Text);
                dao.modificar(valor, persona);
            }
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string valor = comboBox1.Text;
            if (valor != "")
            {
                //pongo lo valores originales 
                Persona resultado = dao.obtenerUno(valor);
                if (resultado != null)
                {
                    textBox1.Text = resultado.Nombre;
                    textBox2.Text = resultado.Apellido;
                    textBox3.Text = Convert.ToString(resultado.Sueldo);

             }
            }   
        }
    }
}
