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
    public partial class Form2 : Form
    {
        PersonaDAO dao = new PersonaDAO();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona personaNueva = new Persona();
            personaNueva.Nombre = textBox1.Text;
            personaNueva.Apellido = textBox2.Text;
            personaNueva.Sueldo = float.Parse(textBox3.Text);

            dao.agregar(personaNueva);

            Form1 formMenu = new Form1();
            this.Hide();
            formMenu.Show();
        }
    }
}
