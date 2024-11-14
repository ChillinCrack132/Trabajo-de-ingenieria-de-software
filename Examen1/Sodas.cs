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
            _form2.sodas++; 
            _form2.Anotar(true, _form2.sodas, BLBL4.Text); 
            _form2.ActualizarTicket(true, _form2.PrecioSodas); 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _form2.sodas++; 
            _form2.Anotar(true, _form2.sodas, label1.Text); 
            _form2.ActualizarTicket(true, _form2.PrecioSodas); 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _form2.sodas++; 
            _form2.Anotar(true, _form2.sodas, label2.Text); 
            _form2.ActualizarTicket(true, _form2.PrecioSodas); 
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _form2.sodas++; 
            _form2.Anotar(true, _form2.sodas, label3.Text); 
            _form2.ActualizarTicket(true, _form2.PrecioSodas); 
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _form2.sodas++; 
            _form2.Anotar(true, _form2.sodas, label4.Text); 
            _form2.ActualizarTicket(true, _form2.PrecioSodas); 
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _form2.sodas++; 
            _form2.Anotar(true, _form2.sodas, label5.Text); 
            _form2.ActualizarTicket(true, _form2.PrecioSodas); 
            
        }
    }
}
