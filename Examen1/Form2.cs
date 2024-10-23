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
        //public static int total = 0;
        int orden = 0;
        public int TotalArticulos = 0;
        public static double totalTicket = 0.00;
        public int nigiris = 0;
        public bool c;

        private void button1_Click(object sender, EventArgs e)
        {
            generarTiket();
            orden++;
        }

        private void ActualizarTicket(bool c, double precio)
        {
            if (c == true)
            {
                totalTicket += precio;
            }
            else
            {
                totalTicket -= precio;
            }

        }

        public void generarTiket()
        {

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
                "\nTOTAL: $" + totalTicket + " MXN" +
                "\nGracias por su compra",
                "TICKET DE COMPRA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            TotalArticulos = nigiris = 0;
            totalTicket = 0;
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
        public void Anotar(int producto, string texto)
        {
            if (producto >= 1)
            {
                TotalArticulos++;
                listBox1.Items.Add(texto);
            }
            else
            {
                TotalArticulos--;
                listBox1.Items.Remove(texto);
            }
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

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            double PrecioNigiri = 100.00;

            if (e.Button == MouseButtons.Left)
            {
                nigiris++;
                Anotar(nigiris, lbl1.Text);
                ActualizarTicket(c=true, PrecioNigiri);
            }
            else if (e.Button == MouseButtons.Right)
            {
                nigiris--;
                Anotar(nigiris, lbl1.Text);
                ActualizarTicket(c = false, PrecioNigiri);
            }
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            int hosomakis = 0;
            double PrecioHosomaki = 120.00;
            if (e.Button == MouseButtons.Left)
            {
                hosomakis++;
                Anotar(hosomakis, lbl2.Text);
                ActualizarTicket(c= true, PrecioHosomaki);
            }
            else if (e.Button == MouseButtons.Right)
            {
                hosomakis--;
                Anotar(hosomakis, lbl2.Text);
                ActualizarTicket(c = false, PrecioHosomaki);
            }
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            int gunkans = 0;
            double PrecioGunkans = 120.00;
            if (e.Button == MouseButtons.Left)
            {
                gunkans++;
                Anotar(gunkans, lbl3.Text);
                ActualizarTicket(c = true, PrecioGunkans);
            }
            else if (e.Button == MouseButtons.Right)
            {
                gunkans--;
                Anotar(gunkans, lbl3.Text);
                ActualizarTicket(c = false, PrecioGunkans);
            }
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            int uramaki = 0;
            double PrecioUramaki = 150.00;
            if (e.Button == MouseButtons.Left)
            {
                uramaki++;
                Anotar(uramaki,label2.Text);
                ActualizarTicket(c = true, PrecioUramaki);
            }
            else if (e.Button == MouseButtons.Right)
            {
                uramaki--;
                Anotar(uramaki, label2.Text);
                ActualizarTicket(c = false, PrecioUramaki);
            }
        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            int gunkans = 0;
            double PrecioGunkans = 140.00;
            if (e.Button == MouseButtons.Left)
            {
                gunkans++;
                Anotar(gunkans, label3.Text);
                ActualizarTicket(c = true, PrecioGunkans);
            }
            else if (e.Button == MouseButtons.Right)
            {
                gunkans--;
                Anotar(gunkans, label3.Text);
                ActualizarTicket(c = false, PrecioGunkans);
            }
        }


        private void button10_MouseDown(object sender, MouseEventArgs e)
        {
            int pescado = 0;
            double PrecioPescado = 140.00;
            if (e.Button == MouseButtons.Left)
            {
                pescado++;
                Anotar(pescado, label3.Text);
                ActualizarTicket(c = true, PrecioPescado);
            }
            else if (e.Button == MouseButtons.Right)
            {
                pescado--;
                Anotar(pescado, label3.Text);
                ActualizarTicket(c = false, PrecioPescado);
            }
        }

        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            int verduras = 0;
            double PrecioVerduras = 140.00;
            if (e.Button == MouseButtons.Left)
            {
                verduras++;
                Anotar(verduras, label3.Text);
                ActualizarTicket(c = true, PrecioVerduras);
            }
            else if (e.Button == MouseButtons.Right)
            {
                verduras--;
                Anotar(verduras, label3.Text);
                ActualizarTicket(c = false, PrecioVerduras);
            }
        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            int maitake = 0;
            double PrecioMaitake = 60.00;
            if (e.Button == MouseButtons.Left)
            {
                maitake++;
                Anotar(maitake, label3.Text);
                ActualizarTicket(c = true, PrecioMaitake);
            }
            else if (e.Button == MouseButtons.Right)
            {
                maitake--;
                Anotar(maitake, label3.Text);
                ActualizarTicket(c = false, PrecioMaitake);
            }
        }

        private void button13_MouseDown(object sender, MouseEventArgs e)
        {
            int tonkotsu = 0;
            double Preciotonkotsu = 160.00;
            if (e.Button == MouseButtons.Left)
            {
                tonkotsu++;
                Anotar(tonkotsu, rlbl1.Text);
                ActualizarTicket(c = true, Preciotonkotsu);
            }
            else if (e.Button == MouseButtons.Right)
            {
                tonkotsu--;
                Anotar(tonkotsu, rlbl1.Text);
                ActualizarTicket(c = false, Preciotonkotsu);
            }
        }

        private void button11_MouseDown(object sender, MouseEventArgs e)
        {
            int miso = 0;
            double PrecioMiso = 110.00;
            if (e.Button == MouseButtons.Left)
            {
                miso++;
                Anotar(miso, rlbl2.Text);
                ActualizarTicket(c = true, PrecioMiso);
            }
            else if (e.Button == MouseButtons.Right)
            {
                miso--;
                Anotar(miso, rlbl2.Text);
                ActualizarTicket(c = false, PrecioMiso);
            }
        }

        private void button12_MouseDown(object sender, MouseEventArgs e)
        {
            int shoyu = 0;
            double PrecioShoyu = 100.00;
            if (e.Button == MouseButtons.Left)
            {
                shoyu++;
                Anotar(shoyu, rlbl3.Text);
                ActualizarTicket(c = true, PrecioShoyu);
            }
            else if (e.Button == MouseButtons.Right)
            {
                shoyu--;
                Anotar(shoyu, rlbl3.Text);
                ActualizarTicket(c = false, PrecioShoyu);
            }
        }

        private void button14_MouseDown(object sender, MouseEventArgs e)
        {
            int shio = 0;
            double PrecioShio = 130.00;
            if (e.Button == MouseButtons.Left)
            {
                shio++;
                Anotar(shio, rlbl4.Text);
                ActualizarTicket(c = true, PrecioShio);
            }
            else if (e.Button == MouseButtons.Right)
            {
                shio--;
                Anotar(shio, rlbl4.Text);
                ActualizarTicket(c = false, PrecioShio);
            }
        }

        private void button16_MouseDown(object sender, MouseEventArgs e)
        {
            int clasico = 0;
            double PrecioClasico = 40.00;
            if (e.Button == MouseButtons.Left)
            {
                clasico++;
                Anotar(clasico, rlbl4.Text);
                ActualizarTicket(c = true, PrecioClasico);
            }
            else if (e.Button == MouseButtons.Right)
            {
                clasico--;
                Anotar(clasico, olbl1.Text);
                ActualizarTicket(c = false, PrecioClasico);
            }
        }

        private void button15_MouseDown(object sender, MouseEventArgs e)
        {
            int clasico = 0;
            double PrecioClasico = 65.00;
            if (e.Button == MouseButtons.Left)
            {
                clasico++;
                Anotar(clasico, olbl2.Text);
                ActualizarTicket(c = true, PrecioClasico);
            }
            else if (e.Button == MouseButtons.Right)
            {
                clasico--;
                Anotar(clasico, rlbl4.Text);
                ActualizarTicket(c = false, PrecioClasico);
            }
        }

        private void button20_MouseDown(object sender, MouseEventArgs e)
        {
            int limonada = 0;
            double PrecioLimonada = 30.00;
            if (e.Button == MouseButtons.Left)
            {
                limonada++;
                Anotar(limonada, olbl2.Text);
                ActualizarTicket(c = true, PrecioLimonada);
            }
            else if (e.Button == MouseButtons.Right)
            {
                limonada--;
                Anotar(limonada, rlbl4.Text);
                ActualizarTicket(c = false, PrecioLimonada);
            }
        }

        private void button18_MouseDown(object sender, MouseEventArgs e)
        {
            int matcha = 0;
            double PrecioMatcha = 50.00;
            if (e.Button == MouseButtons.Left)
            {
                matcha++;
                Anotar(matcha, olbl2.Text);
                ActualizarTicket(c = true, PrecioMatcha);
            }
            else if (e.Button == MouseButtons.Right)
            {
                matcha--;
                Anotar(matcha, rlbl4.Text);
                ActualizarTicket(c = false, PrecioMatcha);
            }
        }

        private void button19_MouseDown(object sender, MouseEventArgs e)
        {
            int agua = 0;
            double PrecioAgua = 30.00;
            if (e.Button == MouseButtons.Left)
            {
                agua++;
                Anotar(agua, olbl2.Text);
                ActualizarTicket(c = true, PrecioAgua);
            }
            else if (e.Button == MouseButtons.Right)
            {
                agua--;
                Anotar(agua, rlbl4.Text);
                ActualizarTicket(c = false, PrecioAgua);
            }
        }

        private void button17_MouseDown(object sender, MouseEventArgs e)
        {
            int sodas = 0;
            double PrecioSodas = 30.00;
            if (e.Button == MouseButtons.Left)
            {
                sodas++;
                Anotar(sodas, olbl2.Text);
                ActualizarTicket(c = true, PrecioSodas);
            }
            else if (e.Button == MouseButtons.Right)
            {
                sodas--;
                Anotar(sodas, rlbl4.Text);
                ActualizarTicket(c = false, PrecioSodas);
            }
        }
    }
}
