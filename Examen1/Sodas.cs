using System;
using System.Windows.Forms;

namespace Examen1
{
    public partial class Sodas : Form
    {
        private Form2 _form2;

        public Sodas(Form2 form2)
        {
            InitializeComponent();
            _form2 = form2; // Guarda la referencia a Form2
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            _form2.sodas++; // Incrementa la variable sodas en Form2
            _form2.Anotar(true, _form2.sodas, BLBL4.Text); // Llama al método Anotar en Form2
            _form2.ActualizarTicket(true, _form2.PrecioSodas); // Llama a ActualizarTicket en Form2
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _form2.sodas++; // Incrementa la variable sodas en Form2
            _form2.Anotar(true, _form2.sodas, label1.Text); // Llama al método Anotar en Form2
            _form2.ActualizarTicket(true, _form2.PrecioSodas); // Llama a ActualizarTicket en Form2
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _form2.sodas++; // Incrementa la variable sodas en Form2
            _form2.Anotar(true, _form2.sodas, label2.Text); // Llama al método Anotar en Form2
            _form2.ActualizarTicket(true, _form2.PrecioSodas); // Llama a ActualizarTicket en Form2
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _form2.sodas++; // Incrementa la variable sodas en Form2
            _form2.Anotar(true, _form2.sodas, label3.Text); // Llama al método Anotar en Form2
            _form2.ActualizarTicket(true, _form2.PrecioSodas); // Llama a ActualizarTicket en Form2
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _form2.sodas++; // Incrementa la variable sodas en Form2
            _form2.Anotar(true, _form2.sodas, label4.Text); // Llama al método Anotar en Form2
            _form2.ActualizarTicket(true, _form2.PrecioSodas); // Llama a ActualizarTicket en Form2
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _form2.sodas++; // Incrementa la variable sodas en Form2
            _form2.Anotar(true, _form2.sodas, label5.Text); // Llama al método Anotar en Form2
            _form2.ActualizarTicket(true, _form2.PrecioSodas); // Llama a ActualizarTicket en Form2
            this.Close();
        }
    }
}
