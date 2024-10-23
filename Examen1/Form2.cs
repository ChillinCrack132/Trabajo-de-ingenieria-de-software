using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        public static int total = 0;
        int orden = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            generarTiket();
            orden++;
        }
        public void suma(bool x, int precio)
        {
            if (x == true)
            {
                total = total + precio;
            }
        }
        public void generarTiket()
        {
            suma(Bool(checkBox1.Checked), 100);
            suma(Bool(checkBox2.Checked), 120);
            suma(Bool(checkBox3.Checked), 120);
            suma(Bool(checkBox4.Checked), 150);
            suma(Bool(checkBox5.Checked), 140);
            suma(Bool(checkBox6.Checked), 60);
            suma(Bool(checkBox7.Checked), 50);
            suma(Bool(checkBox8.Checked), 60);
            suma(Bool(checkBox9.Checked), 80);
            suma(Bool(checkBox10.Checked), 85);
            suma(Bool(checkBox11.Checked), 80);
            suma(Bool(checkBox12.Checked), 90);
            suma(Bool(checkBox13.Checked), 80);
            suma(Bool(checkBox14.Checked), 70);
            suma(Bool(checkBox15.Checked), 40);
            suma(Bool(checkBox17.Checked), 45);
            suma(Bool(checkBox18.Checked), 15);
            suma(Bool(checkBox19.Checked), 40);
            suma(Bool(checkBox20.Checked), 15);
            suma(Bool(checkBox21.Checked), 10);
            StringBuilder sb = new StringBuilder();

            foreach (string item in listBox1.Items)
            {
                sb.Append(item+ Environment.NewLine);
            }
            string hora = DateTime.Now.ToShortTimeString();
            string fecha = DateTime.Now.ToShortDateString();
            MessageBox.Show(
                "Restaurante JAPAN"+
                "\nNUMERO DE ORDEN: #" + orden+
                "\n" + fecha+
                "\n" + hora +
                "\n" + sb.ToString() +
                "\nTOTAL: $" + total + " MXN" +
                "\nGracias por su compra",
                "TICKET DE COMPRA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        public bool Bool(bool x) 
        {
            if (x==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }
        public void Anotar(bool c, string s)
        {
            if (Bool(c) == true)
            {
                listBox1.Items.Add(s);
            }
            else
            {
                listBox1.Items.Remove(s);
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            Anotar(checkBox1.Checked, checkBox1.Text);
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            Anotar(checkBox2.Checked, checkBox2.Text);
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            Anotar(checkBox3.Checked, checkBox3.Text);
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            Anotar(checkBox4.Checked, checkBox4.Text);
        }

        private void checkBox5_Click(object sender, EventArgs e)
        {
            Anotar(checkBox5.Checked, checkBox5.Text);
        }

        private void checkBox6_Click(object sender, EventArgs e)
        {
            Anotar(checkBox6.Checked, checkBox6.Text);
        }

        private void checkBox7_Click(object sender, EventArgs e)
        {
            Anotar(checkBox7.Checked, checkBox7.Text);
        }

        private void checkBox8_Click(object sender, EventArgs e)
        {
            Anotar(checkBox8.Checked, checkBox8.Text);
        }

        private void checkBox9_Click(object sender, EventArgs e)
        {
            Anotar(checkBox9.Checked, checkBox9.Text);
        }

        private void checkBox10_Click(object sender, EventArgs e)
        {
            Anotar(checkBox10.Checked, checkBox10.Text);
        }

        private void checkBox11_Click(object sender, EventArgs e)
        {
            Anotar(checkBox11.Checked, checkBox11.Text);
        }

        private void checkBox12_Click(object sender, EventArgs e)
        {
             Anotar(checkBox12.Checked, checkBox12.Text);
        }

        private void checkBox13_Click(object sender, EventArgs e)
        {
            Anotar(checkBox13.Checked, checkBox13.Text);
        }

        private void checkBox14_Click(object sender, EventArgs e)
        {
           Anotar(checkBox14.Checked, checkBox14.Text);
        }

        private void checkBox15_Click(object sender, EventArgs e)
        {
            Anotar(checkBox15.Checked, checkBox15.Text);
        }

        private void checkBox17_Click(object sender, EventArgs e)
        {
            Anotar(checkBox17.Checked, checkBox17.Text);
        }

        private void checkBox18_Click(object sender, EventArgs e)
        {
            Anotar(checkBox18.Checked, checkBox18.Text);
        }
        private void checkBox19_Click(object sender, EventArgs e)
        {
            Anotar(checkBox19.Checked, checkBox19.Text);
        }

        private void checkBox20_Click(object sender, EventArgs e)
        {
            Anotar(checkBox20.Checked, checkBox20.Text);
        }

        private void checkBox21_Click(object sender, EventArgs e)
        {
            Anotar(checkBox21.Checked, checkBox21.Text);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Cierre de Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }   
            else
            {
                Form1 frmAcceso = new Form1();
                this.Hide();
                frmAcceso.Show();
            }
             
        }
    }
}
